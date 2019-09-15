using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.System;
using Windows.UI.Xaml.Controls;

namespace MiniGames
{
    public class Menu
    {
        public string Name { get; set; }
        public string Icon { get; set; }
        public string Value { get; set; }
    }

    class MainLibrary
    {
        /**
         * 미니게임 메뉴 리스트
         * 30개
         */
        public static List<Menu> Menus
        {
            get
            {
                return new List<Menu>()
                {
                    new Menu() { Name = "Noughts and Crosses", Icon = "\uE7FC", Value = "display" },
                    new Menu() { Name = "Memory Game", Icon = "\uE7FC", Value = "notifications" },
                    new Menu() { Name = "Light Game", Icon = "\uE7FC", Value = "batterysaver" },
                    new Menu() { Name = "Order Game", Icon = "\uE7FC", Value = "storagesense" },
                    new Menu() { Name = "Sound Game", Icon = "\uE7FC", Value = "datausage" },
                    new Menu() { Name = "Lucky Bingo", Icon = "\uE7FC", Value = "personalization" },
                    new Menu() { Name = "Hit or Miss", Icon = "\uE7FC", Value = "privacy" },
                    new Menu() { Name = "Flag Game", Icon = "\uE7FC", Value = "developers" },
                    new Menu() { Name = "Chase Game", Icon = "\uE7FC", Value = "developers" },
                    new Menu() { Name = "Slide Game", Icon = "\uE7FC", Value = "developers" },
                    new Menu() { Name = "High or Low", Icon = "\uE7FC", Value = "developers" },
                    new Menu() { Name = "Racer Game", Icon = "\uE7FC", Value = "developers" },
                    new Menu() { Name = "Emoji Game", Icon = "\uE7FC", Value = "developers" },
                    new Menu() { Name = "Tiles Game", Icon = "\uE7FC", Value = "developers" },
                    new Menu() { Name = "Lucky Wheel", Icon = "\uE7FC", Value = "developers" },
                    new Menu() { Name = "Lucky Chess", Icon = "\uE7FC", Value = "developers" },
                    new Menu() { Name = "Reversi", Icon = "\uE7FC", Value = "developers" },
                    new Menu() { Name = "Mahjong", Icon = "\uE7FC", Value = "developers" },
                };
            }
        }

        public async void Launch(GridView display)
        {
            string value = ((Menu)(display.SelectedItem)).Value;
            await Launcher.LaunchUriAsync(new Uri($"ms-settings:{value}"));
        }
    }
}
