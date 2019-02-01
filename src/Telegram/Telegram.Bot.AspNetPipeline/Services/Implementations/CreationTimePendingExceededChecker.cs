﻿using System;
using Telegram.Bot.AspNetPipeline.Core;

namespace Telegram.Bot.AspNetPipeline.Services.Implementations
{
    public class CreationTimePendingExceededChecker : IPendingExceededChecker
    {
        public TimeSpan PendingTimeLimit { get; }

        public CreationTimePendingExceededChecker(TimeSpan pendingTimeLimit)
        {
            PendingTimeLimit = pendingTimeLimit;
        }
        
        /// <summary>
        /// Return true if DateTime.Now - {UpdContextCreationTime} > PendingTimeLimit.
        /// </summary>
        public bool IsPendingExceeded(UpdateContext updateContext)
        {
            var hiddenCtx = (HiddenUpdateContext)updateContext.Properties[HiddenUpdateContext.DictKeyName];
            return DateTime.Now - hiddenCtx.CreatedAt > PendingTimeLimit;
        }
    }
}
