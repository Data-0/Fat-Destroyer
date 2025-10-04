using Il2CppNewtonsoft.Json.Linq;
using ModSettings;
using System.ComponentModel;

namespace SharpArrows
{
    internal class Settings : JsonModSettings
    {
        internal static Settings instance = new Settings();

        [Section("Despawn Fat")]        

        [Name("What % to despawn fat at")]
        [Slider(10f, 80f)]
        public int minAmount = 20;        

    }
}


