using System;
using Python.Runtime;
namespace EmbeddedPythonDebugging
{
    public class Program
    {
        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        public static extern IntPtr LoadLibrary(string dllToLoad);

        // this should be called with "testmodule" as argument.
        public static void Main(string[] args)
        {
            LoadLibrary(@"C:\Python27\python27.dll"); // preload python27 so we are sure it is found.
            PythonEngine.Initialize();
            string modulePath = args[0];
            using (Py.GIL())
            {
                PythonEngine.ImportModule(modulePath);
            }
        }
    }
}
