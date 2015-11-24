﻿// Generated by Xamasoft JSON Class Generator
// http://www.xamasoft.com/json-class-generator

using Newtonsoft.Json;
using System.Collections.Generic;

namespace SteamWebAPI2.Models.SteamCommunity
{
    public class UserGroupGid
    {
        [JsonProperty("gid")]
        public long Gid { get; set; }
    }

    public class UserGroupListResult
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("groups")]
        public IList<UserGroupGid> Groups { get; set; }
    }

    internal class UserGroupListResultContainer
    {
        [JsonProperty("response")]
        public UserGroupListResult Result { get; set; }
    }
}