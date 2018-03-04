using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SleepyBot.Modules
{
    public class Test : ModuleBase<SocketCommandContext>
    {
        [Command("Repeat")]
        public async Task Rygfyegygf(string repeat)
        {
            await Context.Channel.SendMessageAsync(repeat);
        }

        [Command("Test")]
        public async Task Rygfyegygf()
        {
            await Context.Channel.SendMessageAsync("Congrats, you woke me up. What do you want.");
        }

        [Command("Lyken")]
        public async Task YgregufygRygfyegygf()
        {
            await Context.Channel.SendMessageAsync("I LOVE HIM");
        }

        [Command("I'm so fresh")]
        public async Task YgreygRygfyegygf()
        {
            await Context.Channel.SendMessageAsync("you can suck my nuts lmao");
        }
        [Command("XgamerPortrait")]
        public async Task YgreygRygfyegyrf()
        {
            await Context.Channel.SendMessageAsync("https://i.imgur.com/UMLdBRV.png");
        }

       
    }
}
