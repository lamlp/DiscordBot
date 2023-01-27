using Discord;
using Discord.Interactions;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpi.Services
{
    // interation modules must be public and inherit from an IInterationModuleBase
    public class DoSomethingCommands : InteractionModuleBase<SocketInteractionContext>
    {
        // dependencies can be accessed through Property injection, public properties with public setters will be set by the service provider
        public InteractionService Commands { get; set; }
        private DoSomethingService _doSomethingService { get; set; }

        // constructor injection is also a valid way to access the dependecies
        public DoSomethingCommands(DoSomethingService doSomethingService)
        {
            _doSomethingService = doSomethingService;
        }

        // /command!
        [SlashCommand("hello", "hello")]
        public async Task SayHello()
        {
            await RespondAsync($"Welcome to Dạ Hành!");
        }

        // /command!
        [SlashCommand("open", "open your website on server machine!")]
        public async Task OpenWebsite(string url)
        {
            await RespondAsync(await _doSomethingService.OpenWebsite(url));
        }
    }
}