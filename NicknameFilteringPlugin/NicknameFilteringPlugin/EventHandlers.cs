using Exiled.Events.EventArgs;

namespace NicknameFilteringPlugin
{
    public class EventHandlers
    {
        
        private readonly Plugin _pluginInstance;
        public EventHandlers(Plugin pluginInstance) => this._pluginInstance = pluginInstance;
        
        internal void OnRoundStart()
        {
            Plugin.IsStarted = true;
        }
        
        internal void OnRoundEnded(RoundEndedEventArgs ev)
        {
            Plugin.IsStarted = false;
        }
        
        internal void OnRoundRestart()
        {
            Plugin.IsStarted = false;
        }

        internal void OnJoin(JoinedEventArgs ev)
        {
            string nickname = ev.Player.Nickname;
            string newnickname = NicknameFiltering(nickname);
            if (nickname != newnickname) ev.Player.Nickname = newnickname;
        }


        private string NicknameFiltering(string nickname)
        {
            return nickname.Replace("Twitch", "").Replace("Youtube", "").Replace("트위치", "").Replace("유튜브", "");
        }
    }
}