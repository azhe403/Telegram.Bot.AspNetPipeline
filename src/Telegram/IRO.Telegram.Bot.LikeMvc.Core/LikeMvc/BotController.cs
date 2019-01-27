﻿using IRO.Telegram.Bot.ProcessingPipeline.Core;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace IRO.Telegram.Bot.ProcessingPipeline.LikeMvc
{
    public class BotController
    {
        public ControllerContext ControllerContext { get; }

        #region Proxy properties.
        public UpdateContext UpdateContext => ControllerContext.UpdateContext;

        public Update Update => ControllerContext.UpdateContext.Update;

        public Message Message => Update.Message;

        public Chat Chat => Update.Message.Chat;

        public BotClientContext BotContext => UpdateContext.BotContext;

        public ITelegramBotClient Bot => UpdateContext.BotContext.Bot;
        #endregion
    }
}