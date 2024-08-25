﻿using HintServiceMeow.Core.Models.Hints;
using HintServiceMeow.Core.Utilities;

namespace HintServiceMeow.Core.Extension
{
#if EXILED
    public static class ExiledPlayerExtension
    {
        public static PlayerDisplay GetPlayerDisplay(this Exiled.API.Features.Player player)
        {
            return PlayerDisplay.Get(player);
        }

        public static void AddHint(this Exiled.API.Features.Player player, Hint hint)
        {
            PlayerDisplay.Get(player).AddHint(hint);
        }

        public static void RemoveHint(this Exiled.API.Features.Player player, Hint hint)
        {
            PlayerDisplay.Get(player).RemoveHint(hint);
        }
    }
#endif

    public static class NWPlayerExtension
    {
        public static PlayerDisplay GetPlayerDisplay(this PluginAPI.Core.Player player)
        {
            return PlayerDisplay.Get(player.ReferenceHub);
        }

        public static void AddHint(this PluginAPI.Core.Player player, Hint hint)
        {
            PlayerDisplay.Get(player.ReferenceHub).AddHint(hint);
        }

        public static void RemoveHint(this PluginAPI.Core.Player player, Hint hint)
        {
            PlayerDisplay.Get(player.ReferenceHub).RemoveHint(hint);
        }
    }
}
