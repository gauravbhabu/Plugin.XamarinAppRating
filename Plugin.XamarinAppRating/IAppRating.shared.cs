﻿using System;
using System.Threading.Tasks;

namespace Plugin.XamarinAppRating
{
    /// <summary>
    /// IAppRating interface
    /// </summary>
    public interface IAppRating
    {
        /// <summary>
        /// Perform rating without leaving the app.
        /// </summary>
        Task PerformInAppRateAsync();

        /// <summary>
        /// Perform rating on the current OS store app or open the store page on browser.
        /// </summary>
        /// <param name="packageName">Use this for Android.</param>
        /// <param name="applicationId">Use this for iOS.</param>
        /// <param name="productId">Use this for UWP.</param>
        Task PerformRatingOnStoreAsync(string packageName = "", string applicationId = "", string productId = "");

        /// <summary>
        /// Open rating system on your selected devices.
        /// </summary>
        [Obsolete("Please use PerformInAppRateAsync or PerformRatingOnStoreAsync instead.")]
        Task PerformPlatformRateAppAsync();

        [Obsolete("Please use PerformInAppRateAsync or PerformRatingOnStoreAsync instead.")]
        Task PerformPlatformRateAppAsync(string packageName = null);

        [Obsolete("Please use PerformInAppRateAsync or PerformRatingOnStoreAsync instead.")]
        Task PerformPlatformRateAppAsync(string packageName = null, string applicationId = null);

        [Obsolete("Please use PerformInAppRateAsync or PerformRatingOnStoreAsync instead.")]
        Task PerformPlatformRateAppAsync(string packageName = null, string applicationId = null, string productId = null);
    }
}