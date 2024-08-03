using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ColorPicker
{
    public partial class ColorPicker : Form
    {
        private const int WH_MOUSE_LL = 14;
        private const int WM_MOUSEMOVE = 0x0200;
        private const int WM_MBUTTONDOWN = 0x0207;

        private LowLevelMouseProc _proc;
        private IntPtr _hookID = IntPtr.Zero;
        private bool _isUnlocked = true;

        public ColorPicker()
        {
            InitializeComponent();
            _proc = HookCallback;
            _hookID = SetHook(_proc);
        }

        private IntPtr SetHook(LowLevelMouseProc proc)
        {
            using (var curProcess = System.Diagnostics.Process.GetCurrentProcess())
            using (var curModule = curProcess.MainModule)
            {
                return SetWindowsHookEx(WH_MOUSE_LL, proc, GetModuleHandle(null), 0);
            }
        }

        private delegate IntPtr LowLevelMouseProc(int nCode, IntPtr wParam, IntPtr lParam);

        private IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0)
            {
                if (wParam == (IntPtr)WM_MOUSEMOVE)
                {
                    var mouseHookStruct = Marshal.PtrToStructure<MouseHookStruct>(lParam);
                    Point mousePosition = mouseHookStruct.pt;

                    if (_isUnlocked)
                    {
                        UpdateColorAtPosition(mousePosition);
                    }
                }
                else if (wParam == (IntPtr)WM_MBUTTONDOWN)
                {
                    _isUnlocked = !_isUnlocked;
                    statuslabel.Text = _isUnlocked ? "Current Status: Unlocked" : "Current Status: Locked";
                }
            }
            return CallNextHookEx(_hookID, nCode, wParam, lParam);
        }

        private void UpdateColorAtPosition(Point mousePosition)
        {
            try
            {
                Bitmap screenCapture = new Bitmap(1, 1);

                using (Graphics g = Graphics.FromImage(screenCapture))
                {
                    g.CopyFromScreen(mousePosition.X, mousePosition.Y, 0, 0, new Size(1, 1));
                }

                Color color = screenCapture.GetPixel(0, 0);
                UpdateColorDisplay(color);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        private void UpdateColorDisplay(Color color)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => UpdateColorDisplay(color)));
            }
            else
            {
                int r = color.R;
                int g = color.G;
                int b = color.B;

                float c = 1 - r / 255f;
                float m = 1 - g / 255f;
                float y = 1 - b / 255f;
                float k = Math.Min(c, Math.Min(m, y));

                if (k < 1)
                {
                    c = (c - k) / (1 - k);
                    m = (m - k) / (1 - k);
                    y = (y - k) / (1 - k);
                }
                else
                {
                    c = m = y = 0;
                }

                hexlabel.Text = $"#{r:X2}{g:X2}{b:X2}";
                rgblabel.Text = $"R: {r}, G: {g}, B: {b}";
                cmkylabel.Text = $"CMYK: C: {(c * 100):0}%, M: {(m * 100):0}%, Y: {(y * 100):0}%, K: {(k * 100):0}%";
                colorpreview.BackColor = color;
            }
        }

        private string ColorToHex(Color color)
        {
            return $"#{color.R:X2}{color.G:X2}{color.B:X2}";
        }

        private struct MouseHookStruct
        {
            public Point pt;
            public int mouseData;
            public int flags;
            public int time;
            public IntPtr dwExtraInfo;
        }

        [DllImport("user32.dll")]
        private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelMouseProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll")]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);
    }
}
