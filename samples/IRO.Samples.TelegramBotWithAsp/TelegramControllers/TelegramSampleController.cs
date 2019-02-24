﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot.AspNetPipeline.Extensions;
using Telegram.Bot.AspNetPipeline.Mvc.Controllers.Core;
using Telegram.Bot.AspNetPipeline.Mvc.Routing.Metadata;

namespace IRO.Samples.TelegramBotWithAsp.TelegramControllers
{
    public class TelegramSampleController : BotController
    {
        [BotRoute("/hi")]
        public async Task Hi()
        {
            await UpdateContext.SendTextMessageAsync("Oh, hi mark.");
        }


    }
}
