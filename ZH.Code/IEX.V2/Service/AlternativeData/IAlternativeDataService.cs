﻿using System;
using System.Threading.Tasks;
using ZH.Code.IEX.V2.Model.AlternativeData.Response;
using ZH.Code.IEX.V2.Model.Shared.Response;

namespace ZH.Code.IEX.V2.Service.AlternativeData
{
    public interface IAlternativeDataService
    {
        /// <summary>
        /// <see cref="https://iexcloud.io/docs/api/#volume-by-venue"/>
        /// </summary>
        /// <param name="symbol"></param>
        /// <returns></returns>
        Task<Quote> CryptoAsync(string symbol);

        /// <summary>
        /// <see cref="https://iexcloud.io/docs/api/#social-sentiment"/>
        /// </summary>
        /// <param name="symbol"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        Task<SocialSentimentDailyResponse> SocialSentimentDailyAsync(string symbol, DateTime? date = null);

        /// <summary>
        /// <see cref="https://iexcloud.io/docs/api/#social-sentiment"/>
        /// </summary>
        /// <param name="symbol"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        Task<SocialSentimentMinuteResponse> SocialSentimentMinuteAsync(string symbol, DateTime? date = null);

        /// <summary>
        /// <see cref="https://iexcloud.io/docs/api/#ceo-compensation"/>
        /// </summary>
        /// <param name="symbol"></param>
        /// <returns></returns>
        Task<CEOCompensationResponse> CEOCompensationAsync(string symbol);
    }
}