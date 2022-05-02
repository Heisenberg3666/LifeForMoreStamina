using Exiled.API.Interfaces;
using System.ComponentModel;

namespace LifeForMoreStamina
{
    internal class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;

        [Description("Defines how much HP is removed for every time a player runs without stamina.")]
        public int HpRemoved { get; set; } = 1;

        [Description("Defines how much stamina is added when HP is removed.")]
        public float StaminaAdded { get; set; } = .05f;
    }
}
