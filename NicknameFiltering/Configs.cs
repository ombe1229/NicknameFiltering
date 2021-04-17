using System.Collections.Generic;
using System.ComponentModel;
using Exiled.API.Interfaces;

namespace NicknameFiltering
{
    public class Configs : IConfig
    {
        public bool IsEnabled { get; set; } = true;

        [Description("필터링할 단어 목록")]
        public List<string> FilteringList { get; private set; } = new List<string>
        {
            "youtube", "twitch", "유튜브", "트위치"
        };
    }
}