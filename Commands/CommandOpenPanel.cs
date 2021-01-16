using Rocket.API;
using Rocket.Unturned.Player;
using SDG.Unturned;
using System.Collections.Generic;

namespace AdvancedAdminPanel.Commands
{
    public class CommandOpenPanel : IRocketCommand
    {
        public AllowedCaller AllowedCaller => AllowedCaller.Player;

        public string Name => "openpanel";

        public string Help => "Open the admin panel.";

        public string Syntax => string.Empty;

        public List<string> Aliases => new List<string> { "opanel" };

        public List<string> Permissions => new List<string> { "ss.openpanel" };

        public void Execute(IRocketPlayer caller, string[] command)
        {
            UnturnedPlayer user = (UnturnedPlayer)caller;
            AdvancedAdminPanel main = AdvancedAdminPanel.Instance;

            main.PlayerCommand.Add(user.CSteamID, new List<string>());

            user.Player.enablePluginWidgetFlag(EPluginWidgetFlags.Modal);
            EffectManager.sendUIEffect(23400, 400, user.CSteamID, true);
            EffectManager.sendUIEffectImageURL(400, user.CSteamID, true, "background", main.Configuration.Instance.Panel_Background_Image, true, true);
            for (byte i = 0; i < main.Configuration.Instance.Places.Length; i++)
            {
                if (!main.Configuration.Instance.Places[i].Enabled)
                {
                    EffectManager.sendUIEffectImageURL(400, user.CSteamID, true, $"place{i + 1}_icon", main.Configuration.Instance.DisabledIcon, true, false);
                }
                else
                {
                    EffectManager.sendUIEffectImageURL(400, user.CSteamID, true, $"place{i + 1}_icon", main.Configuration.Instance.Places[i].IconImage, true, false);
                }
            }
        }
    }
}
