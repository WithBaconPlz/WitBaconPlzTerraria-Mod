using Terraria.ModLoader;

namespace WithBaconPlzMod
{
	class WithBaconPlzMod : Mod
	{
		public WithBaconPlzMod()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
