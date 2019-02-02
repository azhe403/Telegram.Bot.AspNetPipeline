﻿namespace Telegram.Bot.AspNetPipeline.Extensions.ImprovedBot.UpdateContextFastSearching
{
    public interface IUpdateContextSearchBag
    {
        /// <summary>
        /// If context with current key exists - it will be disposed and overridden by current context.
        /// </summary>
        void Add(UpdateContextSearchData searchData);

        /// <summary>
        /// Return value or null.
        /// </summary>
        UpdateContextSearchData? TryFind(long chatId, int botId);

        bool Contains(long chatId, int botId);

        /// <summary>
        /// Return removed object or null.
        /// </summary>
        UpdateContextSearchData? TryRemove(long chatId, int botId);
    }
}