using Rocket.Core.Plugins;
using Rocket.Unturned.Player;
using SDG.Unturned;
using Logger = Rocket.Core.Logging.Logger;
using System.Collections.Generic;
using Steamworks;
using Rocket.Core;
using Rocket.API.Collections;

namespace AdvancedAdminPanel
{
    public class AdvancedAdminPanel : RocketPlugin<Configuration>
    {
        // This version only have one page, if the users need more i can add it for future versions.

        protected override void Load()
        {
            Logger.Log(" Plugin loaded correctly!");
            Logger.Log(" More plugins: www.dvtserver.xyz");
            if (!Configuration.Instance.Enabled)
            {
                Logger.Log(" Plugin disabled! Please enable it in the config.");
                this.Unload();
                return;
            }

            Instance = this;
            //U.Events.OnPlayerConnected += OnPlayerConnected;
            EffectManager.onEffectButtonClicked += OnEffectButtonClicked;
            EffectManager.onEffectTextCommitted += OnEffectTextCommited;
        }

        private void OnEffectTextCommited(Player player, string buttonName, string text)
        {
            if (buttonName == "arguments")
            {
                if (PlayerCommand.TryGetValue(player.channel.owner.playerID.steamID, out List<string> value))
                {
                    if(value.Count == 2)
                    {
                        value[1] = text;
                    }
                    else if(value.Count == 1)
                    {
                        value.Add(text);
                    }
                }
            }
        }

        //private void OnPlayerConnected(UnturnedPlayer player)
        //{
        //    if (R.Permissions.HasPermission(player, new List<string> { "ss.openpanel" }))
        //    {
        //        //PanelPage.Add(player.CSteamID, 1);
        //    }
        //}

        private void OnEffectButtonClicked(Player player, string buttonName)
        {
            UnturnedPlayer user = UnturnedPlayer.FromPlayer(player);
            switch (buttonName)
            {
                case "place1_button":
                    if (Configuration.Instance.Places[0].Enabled)
                    {
                        string com1 = Configuration.Instance.Places[0].Command;
                        if (Configuration.Instance.Places[0].NeedArguments)
                        {
                            PlayerCommand[user.CSteamID].Add(com1);
                            EffectManager.askEffectClearByID(23400, user.CSteamID);
                            EffectManager.sendUIEffect(23410, 410, user.CSteamID, true);
                            EffectManager.sendUIEffectImageURL(410, user.CSteamID, true, "background", Configuration.Instance.Panel_Background_Image);
                        }
                        else
                        {
                            R.Commands.Execute(user, com1);
                            PlayerCommand.Remove(user.CSteamID);
                            EffectManager.askEffectClearByID(23400, user.CSteamID);
                            user.Player.disablePluginWidgetFlag(EPluginWidgetFlags.Modal);
                        }
                    }
                    break;
                case "place2_button":
                    if (Configuration.Instance.Places[1].Enabled)
                    {
                        string com2 = Configuration.Instance.Places[1].Command;
                        if (Configuration.Instance.Places[1].NeedArguments)
                        {
                            PlayerCommand[user.CSteamID].Add(com2);
                            EffectManager.askEffectClearByID(23400, user.CSteamID);
                            EffectManager.sendUIEffect(23410, 410, user.CSteamID, true);
                            EffectManager.sendUIEffectImageURL(410, user.CSteamID, true, "background", Configuration.Instance.Panel_Background_Image);
                        }
                        else
                        {
                            R.Commands.Execute(user, com2);
                            PlayerCommand.Remove(user.CSteamID);
                            EffectManager.askEffectClearByID(23400, user.CSteamID);
                            user.Player.disablePluginWidgetFlag(EPluginWidgetFlags.Modal);
                        }
                    }
                    break;
                case "place3_button":
                    if (Configuration.Instance.Places[2].Enabled)
                    {
                        string com3 = Configuration.Instance.Places[2].Command;
                        if (Configuration.Instance.Places[2].NeedArguments)
                        {
                            PlayerCommand[user.CSteamID].Add(com3);
                            EffectManager.askEffectClearByID(23400, user.CSteamID);
                            EffectManager.sendUIEffect(23410, 410, user.CSteamID, true);
                            EffectManager.sendUIEffectImageURL(410, user.CSteamID, true, "background", Configuration.Instance.Panel_Background_Image);
                        }
                        else
                        {
                            R.Commands.Execute(user, com3);
                            PlayerCommand.Remove(user.CSteamID);
                            EffectManager.askEffectClearByID(23400, user.CSteamID);
                            user.Player.disablePluginWidgetFlag(EPluginWidgetFlags.Modal);
                        }
                    }
                    break;
                case "place4_button":
                    if (Configuration.Instance.Places[3].Enabled)
                    {
                        string com4 = Configuration.Instance.Places[3].Command;
                        if (Configuration.Instance.Places[3].NeedArguments)
                        {
                            PlayerCommand[user.CSteamID].Add(com4);
                            EffectManager.askEffectClearByID(23400, user.CSteamID);
                            EffectManager.sendUIEffect(23410, 410, user.CSteamID, true);
                            EffectManager.sendUIEffectImageURL(410, user.CSteamID, true, "background", Configuration.Instance.Panel_Background_Image);
                        }
                        else
                        {
                            R.Commands.Execute(user, com4);
                            PlayerCommand.Remove(user.CSteamID);
                            EffectManager.askEffectClearByID(23400, user.CSteamID);
                            user.Player.disablePluginWidgetFlag(EPluginWidgetFlags.Modal);
                        }
                    }
                    break;
                case "place5_button":
                    if (Configuration.Instance.Places[4].Enabled)
                    {
                        string com5 = Configuration.Instance.Places[4].Command;
                        if (Configuration.Instance.Places[4].NeedArguments)
                        {
                            PlayerCommand[user.CSteamID].Add(com5);
                            EffectManager.askEffectClearByID(23400, user.CSteamID);
                            EffectManager.sendUIEffect(23410, 410, user.CSteamID, true);
                            EffectManager.sendUIEffectImageURL(410, user.CSteamID, true, "background", Configuration.Instance.Panel_Background_Image);
                        }
                        else
                        {
                            R.Commands.Execute(user, com5);
                            PlayerCommand.Remove(user.CSteamID);
                            EffectManager.askEffectClearByID(23400, user.CSteamID);
                            user.Player.disablePluginWidgetFlag(EPluginWidgetFlags.Modal);
                        }
                    }
                    break;
                case "place6_button":
                    if (Configuration.Instance.Places[5].Enabled)
                    {
                        string com6 = Configuration.Instance.Places[5].Command;
                        if (Configuration.Instance.Places[5].NeedArguments)
                        {
                            PlayerCommand[user.CSteamID].Add(com6);
                            EffectManager.askEffectClearByID(23400, user.CSteamID);
                            EffectManager.sendUIEffect(23410, 410, user.CSteamID, true);
                            EffectManager.sendUIEffectImageURL(410, user.CSteamID, true, "background", Configuration.Instance.Panel_Background_Image);
                        }
                        else
                        {
                            R.Commands.Execute(user, com6);
                            PlayerCommand.Remove(user.CSteamID);
                            EffectManager.askEffectClearByID(23400, user.CSteamID);
                            user.Player.disablePluginWidgetFlag(EPluginWidgetFlags.Modal);
                        }
                    }
                    break;
                case "place7_button":
                    if (Configuration.Instance.Places[6].Enabled)
                    {
                        string com7 = Configuration.Instance.Places[6].Command;
                        if (Configuration.Instance.Places[6].NeedArguments)
                        {
                            PlayerCommand[user.CSteamID].Add(com7);
                            EffectManager.askEffectClearByID(23400, user.CSteamID);
                            EffectManager.sendUIEffect(23410, 410, user.CSteamID, true);
                            EffectManager.sendUIEffectImageURL(410, user.CSteamID, true, "background", Configuration.Instance.Panel_Background_Image);
                        }
                        else
                        {
                            R.Commands.Execute(user, com7);
                            PlayerCommand.Remove(user.CSteamID);
                            EffectManager.askEffectClearByID(23400, user.CSteamID);
                            user.Player.disablePluginWidgetFlag(EPluginWidgetFlags.Modal);
                        }
                    }
                    break;
                case "place8_button":
                    if (Configuration.Instance.Places[7].Enabled)
                    {
                        string com8 = Configuration.Instance.Places[7].Command;
                        if (Configuration.Instance.Places[7].NeedArguments)
                        {
                            PlayerCommand[user.CSteamID].Add(com8);
                            EffectManager.askEffectClearByID(23400, user.CSteamID);
                            EffectManager.sendUIEffect(23410, 410, user.CSteamID, true);
                            EffectManager.sendUIEffectImageURL(410, user.CSteamID, true, "background", Configuration.Instance.Panel_Background_Image);
                        }
                        else
                        {
                            R.Commands.Execute(user, com8);
                            PlayerCommand.Remove(user.CSteamID);
                            EffectManager.askEffectClearByID(23400, user.CSteamID);
                            user.Player.disablePluginWidgetFlag(EPluginWidgetFlags.Modal);
                        }
                    }
                    break;
                case "place9_button":
                    if (Configuration.Instance.Places[8].Enabled)
                    {
                        string com9 = Configuration.Instance.Places[8].Command;
                        if (Configuration.Instance.Places[8].NeedArguments)
                        {
                            PlayerCommand[user.CSteamID].Add(com9);
                            EffectManager.askEffectClearByID(23400, user.CSteamID);
                            EffectManager.sendUIEffect(23410, 410, user.CSteamID, true);
                            EffectManager.sendUIEffectImageURL(410, user.CSteamID, true, "background", Configuration.Instance.Panel_Background_Image);
                        }
                        else
                        {
                            R.Commands.Execute(user, com9);
                            PlayerCommand.Remove(user.CSteamID);
                            EffectManager.askEffectClearByID(23400, user.CSteamID);
                            user.Player.disablePluginWidgetFlag(EPluginWidgetFlags.Modal);
                        }
                    }
                    break;
                case "place10_button":
                    if (Configuration.Instance.Places[9].Enabled)
                    {
                        string com10 = Configuration.Instance.Places[9].Command;
                        if (Configuration.Instance.Places[9].NeedArguments)
                        {
                            PlayerCommand[user.CSteamID].Add(com10);
                            EffectManager.askEffectClearByID(23400, user.CSteamID);
                            EffectManager.sendUIEffect(23410, 410, user.CSteamID, true);
                            user.Player.disablePluginWidgetFlag(EPluginWidgetFlags.Modal);
                            EffectManager.sendUIEffectImageURL(410, user.CSteamID, true, "background", Configuration.Instance.Panel_Background_Image);
                        }
                        else
                        {
                            R.Commands.Execute(user, com10);
                            PlayerCommand.Remove(user.CSteamID);
                            EffectManager.askEffectClearByID(23400, user.CSteamID);
                            user.Player.disablePluginWidgetFlag(EPluginWidgetFlags.Modal);
                        }
                    }
                    break;
                case "place11_button":
                    if (Configuration.Instance.Places[10].Enabled)
                    {
                        string com11 = Configuration.Instance.Places[10].Command;
                        if (Configuration.Instance.Places[10].NeedArguments)
                        {
                            PlayerCommand[user.CSteamID].Add(com11);
                            EffectManager.askEffectClearByID(23400, user.CSteamID);
                            EffectManager.sendUIEffect(23410, 410, user.CSteamID, true);
                            EffectManager.sendUIEffectImageURL(410, user.CSteamID, true, "background", Configuration.Instance.Panel_Background_Image);
                        }
                        else
                        {
                            R.Commands.Execute(user, com11);
                            PlayerCommand.Remove(user.CSteamID);
                            EffectManager.askEffectClearByID(23400, user.CSteamID);
                            user.Player.disablePluginWidgetFlag(EPluginWidgetFlags.Modal);
                        }
                    }
                    break;
                case "place12_button":
                    if (Configuration.Instance.Places[11].Enabled)
                    {
                        string com12 = Configuration.Instance.Places[11].Command;
                        if (Configuration.Instance.Places[11].NeedArguments)
                        {
                            PlayerCommand[user.CSteamID].Add(com12);
                            EffectManager.askEffectClearByID(23400, user.CSteamID);
                            EffectManager.sendUIEffect(23410, 410, user.CSteamID, true);
                            EffectManager.sendUIEffectImageURL(410, user.CSteamID, true, "background", Configuration.Instance.Panel_Background_Image);
                        }
                        else
                        {
                            R.Commands.Execute(user, com12);
                            PlayerCommand.Remove(user.CSteamID);
                            EffectManager.askEffectClearByID(23400, user.CSteamID);
                            user.Player.disablePluginWidgetFlag(EPluginWidgetFlags.Modal);
                        }
                    }
                    break;
                case "place13_button":
                    if (Configuration.Instance.Places[12].Enabled)
                    {
                        string com13 = Configuration.Instance.Places[12].Command;
                        if (Configuration.Instance.Places[12].NeedArguments)
                        {
                            PlayerCommand[user.CSteamID].Add(com13);
                            EffectManager.askEffectClearByID(23400, user.CSteamID);
                            EffectManager.sendUIEffect(23410, 410, user.CSteamID, true);
                            EffectManager.sendUIEffectImageURL(410, user.CSteamID, true, "background", Configuration.Instance.Panel_Background_Image);
                        }
                        else
                        {
                            R.Commands.Execute(user, com13);
                            PlayerCommand.Remove(user.CSteamID);
                            EffectManager.askEffectClearByID(23400, user.CSteamID);
                            user.Player.disablePluginWidgetFlag(EPluginWidgetFlags.Modal);
                        }
                    }
                    break;
                case "place14_button":
                    if (Configuration.Instance.Places[13].Enabled)
                    {
                        string com14 = Configuration.Instance.Places[13].Command;
                        if (Configuration.Instance.Places[13].NeedArguments)
                        {
                            PlayerCommand[user.CSteamID].Add(com14);
                            EffectManager.askEffectClearByID(23400, user.CSteamID);
                            EffectManager.sendUIEffect(23410, 410, user.CSteamID, true);
                            EffectManager.sendUIEffectImageURL(410, user.CSteamID, true, "background", Configuration.Instance.Panel_Background_Image);
                        }
                        else
                        {
                            R.Commands.Execute(user, com14);
                            PlayerCommand.Remove(user.CSteamID);
                            EffectManager.askEffectClearByID(23400, user.CSteamID);
                            user.Player.disablePluginWidgetFlag(EPluginWidgetFlags.Modal);
                        }
                    }
                    break;
                case "place15_button":
                    if (Configuration.Instance.Places[14].Enabled)
                    {
                        string com15 = Configuration.Instance.Places[14].Command;
                        if (Configuration.Instance.Places[14].NeedArguments)
                        {
                            PlayerCommand[user.CSteamID].Add(com15);
                            EffectManager.askEffectClearByID(23400, user.CSteamID);
                            EffectManager.sendUIEffect(23410, 410, user.CSteamID, true);
                            EffectManager.sendUIEffectImageURL(410, user.CSteamID, true, "background", Configuration.Instance.Panel_Background_Image);
                        }
                        else
                        {
                            R.Commands.Execute(user, com15);
                            PlayerCommand.Remove(user.CSteamID);
                            EffectManager.askEffectClearByID(23400, user.CSteamID);
                            user.Player.disablePluginWidgetFlag(EPluginWidgetFlags.Modal);
                        }
                    }
                    break;
                case "place16_button":
                    if (Configuration.Instance.Places[15].Enabled)
                    {
                        string com16 = Configuration.Instance.Places[15].Command;
                        if (Configuration.Instance.Places[15].NeedArguments)
                        {
                            PlayerCommand[user.CSteamID].Add(com16);
                            EffectManager.askEffectClearByID(23400, user.CSteamID);
                            EffectManager.sendUIEffect(23410, 410, user.CSteamID, true);
                            EffectManager.sendUIEffectImageURL(410, user.CSteamID, true, "background", Configuration.Instance.Panel_Background_Image);
                        }
                        else
                        {
                            R.Commands.Execute(user, com16);
                            PlayerCommand.Remove(user.CSteamID);
                            EffectManager.askEffectClearByID(23400, user.CSteamID);
                            user.Player.disablePluginWidgetFlag(EPluginWidgetFlags.Modal);
                        }
                    }
                    break;
                case "place17_button":
                    if (Configuration.Instance.Places[16].Enabled)
                    {
                        string com17 = Configuration.Instance.Places[16].Command;
                        if (Configuration.Instance.Places[16].NeedArguments)
                        {
                            PlayerCommand[user.CSteamID].Add(com17);
                            EffectManager.askEffectClearByID(23400, user.CSteamID);
                            EffectManager.sendUIEffect(23410, 410, user.CSteamID, true);
                            EffectManager.sendUIEffectImageURL(410, user.CSteamID, true, "background", Configuration.Instance.Panel_Background_Image);
                        }
                        else
                        {
                            R.Commands.Execute(user, com17);
                            PlayerCommand.Remove(user.CSteamID);
                            EffectManager.askEffectClearByID(23400, user.CSteamID);
                            user.Player.disablePluginWidgetFlag(EPluginWidgetFlags.Modal);
                        }
                    }
                    break;
                case "place18_button":
                    if (Configuration.Instance.Places[17].Enabled)
                    {
                        string com18 = Configuration.Instance.Places[17].Command;
                        if (Configuration.Instance.Places[17].NeedArguments)
                        {
                            PlayerCommand[user.CSteamID].Add(com18);
                            EffectManager.askEffectClearByID(23400, user.CSteamID);
                            EffectManager.sendUIEffect(23410, 410, user.CSteamID, true);
                            EffectManager.sendUIEffectImageURL(410, user.CSteamID, true, "background", Configuration.Instance.Panel_Background_Image);
                        }
                        else
                        {
                            R.Commands.Execute(user, com18);
                            PlayerCommand.Remove(user.CSteamID);
                            EffectManager.askEffectClearByID(23400, user.CSteamID);
                            user.Player.disablePluginWidgetFlag(EPluginWidgetFlags.Modal);
                        }
                    }
                    break;
                case "place19_button":
                    if (Configuration.Instance.Places[18].Enabled)
                    {
                        string com19 = Configuration.Instance.Places[18].Command;
                        if (Configuration.Instance.Places[18].NeedArguments)
                        {
                            PlayerCommand[user.CSteamID].Add(com19);
                            EffectManager.askEffectClearByID(23400, user.CSteamID);
                            EffectManager.sendUIEffect(23410, 410, user.CSteamID, true);
                            EffectManager.sendUIEffectImageURL(410, user.CSteamID, true, "background", Configuration.Instance.Panel_Background_Image);

                        }
                        else
                        {
                            R.Commands.Execute(user, com19);
                            PlayerCommand.Remove(user.CSteamID);
                            EffectManager.askEffectClearByID(23400, user.CSteamID);
                            user.Player.disablePluginWidgetFlag(EPluginWidgetFlags.Modal);
                        }
                    }
                    break;
                case "place20_button":
                    if (Configuration.Instance.Places[19].Enabled)
                    {
                        string com20 = Configuration.Instance.Places[19].Command;
                        if (Configuration.Instance.Places[19].NeedArguments)
                        {
                            PlayerCommand[user.CSteamID].Add(com20);
                            EffectManager.askEffectClearByID(23400, user.CSteamID);
                            EffectManager.sendUIEffect(23410, 410, user.CSteamID, true);
                            EffectManager.sendUIEffectImageURL(410, user.CSteamID, true, "background", Configuration.Instance.Panel_Background_Image);
                        }
                        else
                        {
                            R.Commands.Execute(user, com20);
                            PlayerCommand.Remove(user.CSteamID);
                            EffectManager.askEffectClearByID(23400, user.CSteamID);
                            user.Player.disablePluginWidgetFlag(EPluginWidgetFlags.Modal);
                        }
                    }
                    break;
                case "place21_button":
                    if (Configuration.Instance.Places[20].Enabled)
                    {
                        string com21 = Configuration.Instance.Places[20].Command;
                        if (Configuration.Instance.Places[20].NeedArguments)
                        {
                            PlayerCommand[user.CSteamID].Add(com21);
                            EffectManager.askEffectClearByID(23400, user.CSteamID);
                            EffectManager.sendUIEffect(23410, 410, user.CSteamID, true);
                            EffectManager.sendUIEffectImageURL(410, user.CSteamID, true, "background", Configuration.Instance.Panel_Background_Image);
                        }
                        else
                        {
                            user.Player.disablePluginWidgetFlag(EPluginWidgetFlags.Modal);
                            R.Commands.Execute(user, com21);
                            PlayerCommand.Remove(user.CSteamID);
                            EffectManager.askEffectClearByID(23400, user.CSteamID);
                        }
                    }
                    break;
                case "sendcommand":
                    if (PlayerCommand[user.CSteamID].Count != 2)
                    {
                        EffectManager.sendUIEffect(23410, 410, user.CSteamID, true, Translate("no_arguments"));
                        EffectManager.sendUIEffectImageURL(410, user.CSteamID, true, "background", Configuration.Instance.Panel_Background_Image);
                    }
                    else if(PlayerCommand[user.CSteamID].Count == 2)
                    {
                        user.Player.disablePluginWidgetFlag(EPluginWidgetFlags.Modal);
                        EffectManager.askEffectClearByID(23410, user.CSteamID);
                        string command = PlayerCommand[user.CSteamID][0] + " " + PlayerCommand[user.CSteamID][1]; 
                        R.Commands.Execute(user, command);
                        PlayerCommand.Remove(user.CSteamID);
                    }
                    break;
                case "close":
                    PlayerCommand.Remove(user.CSteamID);
                    user.Player.disablePluginWidgetFlag(EPluginWidgetFlags.Modal);
                    EffectManager.askEffectClearByID(23400, user.CSteamID);
                    break;
                //case "nextpage":
                //    if (PanelPage[user.CSteamID] == 1 && Configuration.Instance.Page3_Active)
                //    {
                //        PanelPage[user.CSteamID] = 2;
                //        EffectManager.sendUIEffect(0, 0, user.CSteamID, true);
                //    }
                //    break;
            }
        }

        public override TranslationList DefaultTranslations
        {
            get
            {
                return new TranslationList()
                {
                    { "no_arguments", "Error! You need to add arguments for this command" }
                };
            }
        }

        protected override void Unload()
        {
            EffectManager.onEffectButtonClicked -= OnEffectButtonClicked;
            Logger.Log(" Plugin unloaded correctly!");
        }

        internal static AdvancedAdminPanel Instance;

        //internal Dictionary<CSteamID, byte> PanelPage = new Dictionary<CSteamID, byte>();

        internal Dictionary<CSteamID, List<string>> PlayerCommand = new Dictionary<CSteamID, List<string>>();
    }
}