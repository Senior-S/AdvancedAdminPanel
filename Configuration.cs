using AdvancedAdminPanel.Model;
using Rocket.API;

namespace AdvancedAdminPanel
{
    public class Configuration : IRocketPluginConfiguration
    {
        public void LoadDefaults()
        {
            Enabled = true;
            Panel_Background_Image = "https://colorineseducacion.com/wp-content/uploads/revslider/splash-creative-light-01-animated/Slider-CL01-Background.png";
            DisabledIcon = "https://www.iconninja.com/files/597/1019/768/disabled-delete-icon.png";
            //Page1_Active = true;
            //Page2_Active = false;
            //Page3_Active = false;

            Places = new Place[21] { toAddPlace, toAddPlace, toAddPlace, toAddPlace, toAddPlace, toAddPlace, toAddPlace, toAddPlace, toAddPlace, toAddPlace, toAddPlace, toAddPlace, toAddPlace, toAddPlace, toAddPlace, toAddPlace, toAddPlace, toAddPlace, toAddPlace, toAddPlace, toAddPlace };
        }
         
        public bool Enabled;

        public string Panel_Background_Image;

        public string DisabledIcon;

        //public bool Page1_Active;
        //public bool Page2_Active;
        //public bool Page3_Active;

        Place toAddPlace = new Place
        {
            Enabled = true,
            IconImage = "https://www.iconninja.com/files/740/790/561/sun-icon.png",
            Command = "day",
            NeedArguments = false
        };

        //public List<Place> Places = new List<Place>();

        public Place[] Places = new Place[21];
    }
}
