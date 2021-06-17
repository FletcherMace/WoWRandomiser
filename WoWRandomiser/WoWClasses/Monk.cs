using System.Collections.Generic;
using System.Windows.Media;

namespace WoWRandomiser.WowClasses
{
    class Monk : WarcraftClass
    {
        public Monk()
        {
            ClassName = "Monk";
            ClassColour = new SolidColorBrush(Color.FromRgb(0, 255, 152));
        }

        public override List<string> GetAvailableRaces(string faction, bool allied)
        {
            if (faction == alliance)
            {
                allianceRaces = new List<string> { "Draenei", "Dwarf", "Gnome", "Human", "Night Elf", "Pandaren" };
                if (allied == true)
                    allianceRaces.AddRange(new List<string> { "Dark Iron Dwarf", "Kul Tiran", "Lightforged Draenei", "Mechagnome" });
                return allianceRaces;
            }
            else
            {
                hordeRaces = new List<string> { "Bloof Elf", "Orc", "Pandaren", "Tauren", "Troll", "Undead" };
                if (allied == true)
                    hordeRaces.AddRange(new List<string> { "Highmountain Tauren", "Mag'har Orc", "Nightborne", "Vulpera", "Zandalari Troll" });
                return hordeRaces;
            }

        }

        public override List<string> GetAvailableSpecs(string faction, bool allied)
        {
            return new List<string> { "Brewmaster", "Mistweaver", "Windwalker" };
        }
    }
}
