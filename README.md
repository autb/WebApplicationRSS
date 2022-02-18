# WebApplicationRSS
It's a simple RSS Feed with ASP.NET Core Web API implemented wit VS2019 with a basic template of an ASP.NET Core web empty template,
and where the code was saw in the [article](https://referbruv.com/blog/posts/creating-a-simple-rss-feed-with-aspnet-core-web-api).

# Using NGrok to expose local webapp to public space

## Ngrok & TPLINK & livebox
Interesting way aslo was to see how use ngrok to expose the local web app.

In my case to test i just do : `ngrok http https://192.168.0.140:5001` where the IP (192.168.0.140) was my local laptop, behing a TPlink wiht IP (192.168.1.43)
which was also itself behind a web box (livebox).

So to test this rss feed with a classic rss reader on my browser, what i did was simple:

(1) In the TPLINK i configured by the dahsoard of tplink (http://192.168.0.1/), the forwarding port in the advanced module : 5001 to the 192.168.0.140:5001 (laptop)
*A good article is there around [How to configure Virual Server on an Archer C50](https://www.tp-link.com/us/support/faq/1721/)*

(2) In my box i also confiured nat/froward, to open the port 5001 and forard it to the TPLINK ip: 192.168.1.43:5001
By the way ngrok url was running well from public side to go to my running local laptop web app.


## Ngrok & CliWrap to Start ngrok automatically during ASP.NET Core startup
One good tool [CliWrap](https://github.com/Tyrrrz/CliWrap) well described in this [article](https://www.twilio.com/blog/integrate-ngrok-into-aspdotnet-core-startup-and-automatically-update-your-webhook-urls) could be use to automatically startup ngrok.
A good video to discover the nice feature of this tool can be watch [here](https://www.youtube.com/watch?v=3_Ucw3Fflmo).

# Coding points:
Once the first step, when I launched the webapp, in fact the feed endpoint /api/feed/rss was not running. The issue was in the Statup.cs in the function Configure where the app.useEndpoints has no declaration of the MapControllers.
Then once i added the line endpoints.MapControllers(); it was running well.

Before:
```
app.UseEndpoints(endpoints =>
{
    endpoints.MapRazorPages();
});
 ```

After:

```
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();  <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    endpoints.MapRazorPages();
});
```

# Thanks
*(Tx to [markdownguide.org](https://www.markdownguide.org/cheat-sheet/) to remember the MK syntax to this short article)*
