using Rocket.API;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Player;
using System.Collections.Generic;

namespace AdvancedAdminPanel.Commands
{
    public class CommandChangePlace : IRocketCommand
    {
        public AllowedCaller AllowedCaller => AllowedCaller.Player;

        public string Name => "changeplace";

        public string Help => "Change an option from a specific place.";

        public string Syntax => "<option> <place> <value>";

        public List<string> Aliases => new List<string>();

        public List<string> Permissions => new List<string> { "ss.changeplace" };

        public void Execute(IRocketPlayer caller, string[] command)
        {
            UnturnedPlayer user = (UnturnedPlayer)caller;
            AdvancedAdminPanel main = AdvancedAdminPanel.Instance;

            if (command.Length < 1)
            {
                UnturnedChat.Say(user, "Error! You need to specify an option.");
                UnturnedChat.Say(user, "Options: iconurl - command - enabled - needarguments", true);
                return;
            }

            switch (command[0].ToLower())
            {
                case "iconurl":
                    if (command.Length != 3)
                    {
                        UnturnedChat.Say(user, "Error! Correct usage: /changeplace iconurl <place> <image url>", UnityEngine.Color.red, true);
                        return;
                    }
                    else if (!byte.TryParse(command[1], out byte place))
                    {
                        UnturnedChat.Say(user, "Error! Enter a number between 1 and 21", UnityEngine.Color.red, false);
                    }
                    else if (place < 1 || place > 21)
                    {
                        UnturnedChat.Say(user, "Error! Enter a number between 1 and 21", UnityEngine.Color.red, false);
                    }
                    else
                    {
                        string iconUrl = command[2];
                        main.Configuration.Instance.Places[place - 1].IconImage = iconUrl;
                        UnturnedChat.Say(user, $"Place image changed to: {iconUrl}", false);
                    }
                    break;
                case "command":
                    if (command.Length != 3)
                    {
                        UnturnedChat.Say(user, "Error! Correct usage: /changeplace command <place> <command>", UnityEngine.Color.red, true);
                        return;
                    }
                    else if (!byte.TryParse(command[1], out byte place))
                    {
                        UnturnedChat.Say(user, "Error! Enter a number between 1 and 21", UnityEngine.Color.red, false);
                    }
                    else if (place < 1 || place > 21)
                    {
                        UnturnedChat.Say(user, "Error! Enter a number between 1 and 21", UnityEngine.Color.red, false);
                    }
                    else
                    {
                        string comm = command[2];
                        main.Configuration.Instance.Places[place - 1].Command = comm;
                        UnturnedChat.Say(user, $"Place command changed to: {comm}", false);
                    }
                    break;
                case "enabled":
                    if (command.Length != 3)
                    {
                        UnturnedChat.Say(user, "Error! Correct usage: /changeplace enabled <place> <true-false>", UnityEngine.Color.red, true);
                        return;
                    }
                    else if (!byte.TryParse(command[1], out byte place))
                    {
                        UnturnedChat.Say(user, "Error! Enter a number between 1 and 21", UnityEngine.Color.red, false);
                    }
                    else if (place < 1 || place > 21)
                    {
                        UnturnedChat.Say(user, "Error! Enter a number between 1 and 21", UnityEngine.Color.red, false);
                    }
                    else if (!bool.TryParse(command[2], out bool enabled))
                    {
                        UnturnedChat.Say(user, "Error! Set true or false.", false);
                    }
                    else
                    {
                        main.Configuration.Instance.Places[place - 1].Enabled = enabled;
                        UnturnedChat.Say(user, $"Place enabled changed to: {enabled}", false);
                    }
                    break;
                case "needarguments":
                    if (command.Length != 3)
                    {
                        UnturnedChat.Say(user, "Error! Correct usage: /changeplace needarguments <place> <true-false>", UnityEngine.Color.red, true);
                        return;
                    }
                    else if (!byte.TryParse(command[1], out byte place))
                    {
                        UnturnedChat.Say(user, "Error! Enter a number between 1 and 21", UnityEngine.Color.red, false);
                    }
                    else if (place < 1 || place > 21)
                    {
                        UnturnedChat.Say(user, "Error! Enter a number between 1 and 21", UnityEngine.Color.red, false);
                    }
                    else if (!bool.TryParse(command[2], out bool enabled))
                    {
                        UnturnedChat.Say(user, "Error! Set true or false.", false);
                    }
                    else
                    {
                        main.Configuration.Instance.Places[place - 1].Enabled = enabled;
                        UnturnedChat.Say(user, $"Place needarguments changed to: {enabled}", false);
                    }
                    break;
                default:
                    UnturnedChat.Say(user, "Error! You need to specify a valid option.");
                    UnturnedChat.Say(user, "Options: iconurl - command - enabled - needarguments", true);
                    break;
            }
        }
    }
}
