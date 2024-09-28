using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Example_5_MessageBox
{
    internal class Program
    {
        // Import MessageBox function from user32.dll
        [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        static extern int MessageBox(IntPtr hWnd, String text, String caption, int type);
        static void Main(string[] args)
        {
            MessageBox(IntPtr.Zero, "Hello, World!", "My Message Box", 0);
        }
    }
}
