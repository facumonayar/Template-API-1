
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Template_Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }
        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(confing  => { confing.UseStartup<Startup>(); });
        }
    }
}
