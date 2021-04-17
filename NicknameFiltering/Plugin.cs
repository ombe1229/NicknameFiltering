using PlayerEvents = Exiled.Events.Handlers.Player;
using Features = Exiled.API.Features;
using Log = Exiled.API.Features.Log;

namespace NicknameFiltering
{
    public class NicknameFiltering : Features.Plugin<Configs>
    {
        private EventHandlers EventHandlers { get; set; }

        private void LoadEvents()
        {
            PlayerEvents.Joined += EventHandlers.OnJoined;
        }

        public override void OnEnabled()
        {
            if (!Config.IsEnabled) return;
            Log.Info("NicknameFiltering enabled.");
            EventHandlers = new EventHandlers(this);
            LoadEvents();
        }

        public override void OnDisabled()
        {
            PlayerEvents.Joined -= EventHandlers.OnJoined;
        }
    }
}