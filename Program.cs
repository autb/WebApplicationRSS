using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


//cf. https://referbruv.com/blog/posts/creating-a-simple-rss-feed-with-aspnet-core-web-api
namespace WebApplicationRSS
{
    public class Program
    {
        //interesting i exposed via ngrock to test..
        // by doing: 
        // ==> ngrok http https://192.168.0.140:5001  (i need to put in the launchSettings.json the ip of the machine
        // explcitly to be sure also that my TPLINK doing gateway will also do port forward for this i on this 5001 also
        // and also in the libebox open the port 5001 to forward to the tplink where pc-spare is connected on it.
        //and gives for example:  http://0cc9-86-227-29-255.ngrok.io
        //
        // very goo:d see in twilio blog: https://www.twilio.com/blog/integrate-ngrok-into-aspdotnet-core-startup-and-automatically-update-your-webhook-urls
        // Start ngrok automatically during ASP.NET Core startup
        // To start the ngrok tunnel programmatically, you'll need to run the ngrok CLI command from code. You could use
        // the Process .NET APIs, but there's an open-source library that makes interacting with CLI tools and processes
        // easier: CliWrap. (cf <https://github.com/Tyrrrz/CliWrap>  and good video here : https://www.youtube.com/watch?v=3_Ucw3Fflmo )
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
