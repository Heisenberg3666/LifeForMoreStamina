using Exiled.API.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeForMoreStamina
{
    internal class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;

        [Description("Defines how many hp is removed for every time a player runs without stamina.")]
        public int HpRemoved { get; set; } = 1;
    }
}
