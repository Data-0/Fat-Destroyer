using MelonLoader;
using FatDestroyer;
using System.Reflection;
using System.Runtime.InteropServices;

//This is a C# comment. Comments have no impact on compilation.

//ModName, ModVersion, ModAuthor, and ModNamespace.ModClassInheritingFromMelonMod all need changed.

[assembly: AssemblyTitle("RuinedFatDestroyer")]
[assembly: AssemblyCopyright("Data-0")]

//Version numbers in C# are a set of 1 to 4 positive integers separated by periods.
//Mods typically use 3 numbers. For example: 1.2.1
//The mod version need specified in three places.
[assembly: AssemblyVersion("0.5.0")]
[assembly: AssemblyFileVersion("0.5.0")]
[assembly: MelonInfo(typeof(DespawnFat), "RuinedFatDestroyer", "1.0.0", "Data-0", null)]

//This tells MelonLoader that the mod is only for The Long Dark.
[assembly: MelonGame("Hinterland", "TheLongDark")]