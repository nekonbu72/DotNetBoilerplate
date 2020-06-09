using System;
using System.Diagnostics;

namespace DotNetBoilerplate
{
    public class Hello
    {
        public static void Main()
        {
            Console.WriteLine("Hello, DotNet!");

            var startInfo = new ProcessStartInfo
            {
                FileName = @"C:\Program Files\dotnet\dotnet.exe",
                CreateNoWindow = true,
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardInput = false
            };

            using (var process = Process.Start(startInfo))
            {
                var output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();
                Console.WriteLine(output);
            }


        }
    }
}
