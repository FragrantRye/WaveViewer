//#define OLD

using System;
using System.Reflection;
using System.Windows.Forms;

namespace WaveViewer
{

    static class Program
    {
        static Program()
        {
            //手动加载当前目录里没有的DLL
            AppDomain.CurrentDomain.AssemblyResolve += CurrentDomain_AssemblyResolve;
        }

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Forms.Main());
        }
        static Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            //获取加载失败的程序集的全名
            var assName = new AssemblyName(args.Name).FullName;
            if (args.Name == "SharpDX.Desktop, Version=4.2.0.0, Culture=neutral, PublicKeyToken=b4dcf0f35e5521f1")
            {
                //读取资源
                var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("WaveViewer.SharpDXDLL.SharpDX.Desktop.dll");
                var bytes = new byte[stream.Length];
                stream.Read(bytes, 0, (int)stream.Length);
                return Assembly.Load(bytes);//加载资源文件中的dll,代替加载失败的程序集
            }
            else if(args.Name== "SharpDX, Version=4.2.0.0, Culture=neutral, PublicKeyToken=b4dcf0f35e5521f1")
            {
                var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("WaveViewer.SharpDXDLL.SharpDX.dll");
                var bytes = new byte[stream.Length];
                stream.Read(bytes, 0, (int)stream.Length);
                return Assembly.Load(bytes);//加载资源文件中的dll,代替加载失败的程序集
            }
            else if (args.Name == "SharpDX.DXGI, Version=4.2.0.0, Culture=neutral, PublicKeyToken=b4dcf0f35e5521f1")
            {
                var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("WaveViewer.SharpDXDLL.SharpDX.DXGI.dll");
                var bytes = new byte[stream.Length];
                stream.Read(bytes, 0, (int)stream.Length);
                return Assembly.Load(bytes);//加载资源文件中的dll,代替加载失败的程序集
            }
            else if (args.Name == "SharpDX.Direct2D1, Version=4.2.0.0, Culture=neutral, PublicKeyToken=b4dcf0f35e5521f1")
            {
                var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("WaveViewer.SharpDXDLL.SharpDX.Direct2D1.dll");
                var bytes = new byte[stream.Length];
                stream.Read(bytes, 0, (int)stream.Length);
                return Assembly.Load(bytes);//加载资源文件中的dll,代替加载失败的程序集
            }
            throw new DllNotFoundException(assName);
        }
    }
}
