using Exiled.API.Features;
using Player = Exiled.Events.Handlers.Player;
using System;

namespace LifeForMoreStamina
{
    internal class Plugin : Plugin<Config>
    {
        public static Plugin Instance;
        private EventHandlers _events;

        public override string Name => "LifeForMoreStamina";
        public override string Author => "Memw#6969";
        public override Version Version => new Version(1, 1, 0);
        public override Version RequiredExiledVersion => new Version(5, 1, 3);

        public override void OnEnabled()
        {
            base.OnEnabled();
            Instance = this;
            _events = new EventHandlers();
            RegisterEvents();
        }

        public override void OnDisabled()
        {
            base.OnDisabled();
            UnregisterEvents();
            _events = null;
            Instance = null;
        }

        public void RegisterEvents()
        {
            Player.ChangingMoveState += _events.OnPlayerRunning;
        }

        public void UnregisterEvents()
        {
            Player.ChangingMoveState -= _events.OnPlayerRunning;
        }
    }
}
