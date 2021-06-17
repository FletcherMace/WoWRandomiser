using System.Collections.Generic;
using System.Windows.Media;

namespace WoWRandomiser.WowClasses
{
    public class DemonHunter : WarcraftClass
    {
        public DemonHunter()
        {
            ClassName = "Demon Hunter";
            ClassColour = new SolidColorBrush(Color.FromRgb(163, 48, 201));
        }

        public override List<string> GetAvailableRaces(string faction, bool allied)
        {
            if (faction == alliance)
            {
                return new List<string> { "Night Elf" };
            }
            else
            {
                return new List<string> { "Bloof Elf" };
            }

        }

        public override List<string> GetAvailableSpecs(string faction, bool allied)
        {
            return new List<string> { "Havoc", "Vengeance" };
        }
    }
}
