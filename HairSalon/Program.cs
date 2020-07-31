using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace HairSalon
{
  public class Program
  {
    public static void Main(string[] args)
    {
      var host = new WebHostBuilder()
      .UseKestrel()
      .UseContentRoot(Directory.GetCurrentDirectorey())
      .UseIISIntegration()
      .UseStartup<Startup>()
      .Build();

      host.Run();
    }
  }
}