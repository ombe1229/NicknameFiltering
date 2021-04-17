using System.Linq;
using Exiled.Events.EventArgs;

namespace NicknameFiltering
{
    public class EventHandlers
    {
        private readonly NicknameFiltering _pluginInstance;
        public EventHandlers(NicknameFiltering pluginInstance) => this._pluginInstance = pluginInstance;

        internal void OnJoined(JoinedEventArgs eventArgs)
        {
            string oldNickname = eventArgs.Player.Nickname;
            string newNickname = _pluginInstance.Config.FilteringList.Aggregate(oldNickname, (current, keyword) => current.Replace(keyword, ""));
            if (oldNickname != newNickname) eventArgs.Player.DisplayNickname = newNickname;
        }
    }
}