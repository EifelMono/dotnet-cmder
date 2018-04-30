using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;

namespace DotNetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args?.Length > 0 && (args[0] == "--help" || args[0] == "-h"))
            {
                string Help = $"dotnet-cmder {System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString()} starts cmder in the current folder.";
                Console.WriteLine(Help);
                return;
            }
            var isWindows = System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform(System.Runtime.InteropServices.OSPlatform.Windows);

            if (!isWindows)
            {
                Console.WriteLine("Cmder works only on Windows");
                return;
            }

            var dotnetDllPath = Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]);
            var cmderMiniPath = Path.Combine(dotnetDllPath, "cmder_mini");
            if (!Directory.Exists(cmderMiniPath))
            {
                try
                {
                    System.IO.Compression.ZipFile.ExtractToDirectory(Path.Combine(dotnetDllPath, "cmder_mini.zip"), dotnetDllPath, true);
                }
                catch { }
            }
            try
            {
                var exe = Path.Combine(cmderMiniPath, "Cmder.exe");
                var dir = Directory.GetCurrentDirectory();
                Process.Start(exe, dir);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Can no start cmder");
                Console.WriteLine(ex);
            }
        }
    }
}