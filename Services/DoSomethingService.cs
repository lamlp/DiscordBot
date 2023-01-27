using Discord;
using Discord.WebSocket;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace csharpi.Services
{
    public class DoSomethingService
    {
        public async Task<string> OpenWebsite(string url)
        {
            try
            {
                Process process = new Process();
                process.StartInfo.UseShellExecute = true;
                process.StartInfo.FileName = "chrome";
                process.StartInfo.Arguments = $"{url}";
                process.Start();
                await process.WaitForExitAsync();
                return $"Opened {url} on server browser!";
            }
            catch(Exception ex)
            {
                return $"Can not open {url} because: {ex.Message}";
            }
        }
    }
}
