// Copyright © 2015 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace WebApplication
{
  public class Program
  {
    public static void Main(string[] args)
    {
      var host = new WebHostBuilder()
          .UseContentRoot(Directory.GetCurrentDirectory())
          .UseKestrel()
          .UseIISIntegration()
          .UseStartup<Startup>()
          .Build();

      host.Run();
    }
  }
}