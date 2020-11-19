using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace file2clipboard
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            //Application.Run();
            copyFile(args);
            Application.Exit();
        }

        private static void copyFile(string[] args)
        {
            StringCollection filePaths = new StringCollection();
            if (args.Length > 0)
            {
                foreach (string filename in args) {
            	    filePaths.Add(filename);
                }
                Clipboard.Clear();
                Clipboard.SetFileDropList(filePaths);
            }
        }
    }
}
