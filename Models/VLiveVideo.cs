﻿using Newtonsoft.Json;
using System;

namespace VSharp.Models
{
    // TODO: Add special converters for properties, data: http://api.vfan.vlive.tv/vproxy/channelplus/getChannelVideoList?app_id=&channelSeq=6&maxNumOfRows=5
    public class VLiveVideo
    {
        [JsonProperty("videoSeq")]
        public int VideoSeq { get; set; }

        [JsonProperty("videoType")]
        public string VideoType { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("playCount")]
        public int PlayCount { get; set; }

        [JsonProperty("likeCount")]
        public int LikeCount { get; set; }

        [JsonProperty("commentCount")]
        public int CommentCount { get; set; }

        [JsonProperty("thumbnail")]
        public string ThumbnailUrl { get; set; }

        [JsonProperty("pickSortOrder")]
        public int PickSortOrder { get; set; }

        [JsonProperty("screenOrientation")]
        public string ScreenOrientation { get; set; }

        [JsonProperty("willStartAt")]
        public DateTime WillStartAt { get; set; }

        [JsonProperty("willEndAt")]
        public DateTime WillEndAt { get; set; }

        [JsonProperty("createdAt")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("upcomingYn")]
        public string UpcomingYn { get; set; }

        [JsonProperty("specialLiveYn")]
        public string SpecialLiveYn { get; set; }

        [JsonProperty("liveThumbYn")]
        public string LiveThumbYn { get; set; }

        [JsonProperty("productId")]
        public string ProductId { get; set; }

        [JsonProperty("packageProductId")]
        public string PackageProductId { get; set; }

        [JsonProperty("productType")]
        public string ProductType { get; set; }

        [JsonProperty("playTime")]
        public int PlayTimeInSeconds { get; set; }

        [JsonProperty("channelPlusPublicYn")]
        public string ChannelPlusPublicYn { get; set; }

        [JsonProperty("exposeStatus")]
        public string ExposeStatus { get; set; }

        [JsonProperty("representChannelName")]
        public string RepresentChannelName { get; set; }

        [JsonProperty("representChannelProfileImg")]
        public string RepresentChannelProfileImageUrl { get; set; }

        [JsonProperty("onAirStartAt")]
        public DateTime OnAirStartAt { get; set; }

        [JsonProperty("@type")]
        public string Type { get; set; }
    }
}
