﻿//#define OLD

using System;
using System.Windows.Forms;

namespace WaveViewer
{

    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
#if OLD
            Application.Run(new Forms.MainWindow());
#else
            Application.Run(new Forms.Main());
#endif
        }
    }
}