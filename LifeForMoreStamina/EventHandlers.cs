using Exiled.Events.EventArgs;

namespace LifeForMoreStamina
{
    internal class EventHandlers
    {
        public void OnPlayerRunning(ChangingMoveStateEventArgs ev)
        {
            if (ev.Player.Stamina.RemainingStamina > .025f)
                return;

            ev.Player.Stamina.RemainingStamina += Plugin.Instance.Config.StaminaAdded;
            ev.Player.Health -= Plugin.Instance.Config.HpRemoved;
        }
    }
}
