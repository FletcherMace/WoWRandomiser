using System.Collections.Generic;
using System.Windows.Media;

namespace WoWRandomiser.WowClasses
{
    class Mage : WarcraftClass
    {
        public Mage()
        {
            ClassName = "Mage";
            ClassColour = new SolidColorBrush(Color.FromRgb(63, 199, 235));
        }

        public override List<string> GetAvailableRaces(string faction, bool allied)
        {
            if (faction == alliance)
            {
                allianceRaces = new List<string> { "Draenei", "Dwarf", "Gnome", "Human", "Night Elf", "Pandaren", "Worgen" };
                if (allied == true)
                    allianceRaces.AddRange(new List<string> { "Dark Iron Dwarf", "Kul Tiran", "Lightforged Draenei", "Mechagnome", "Void Elf" });
                return allianceRaces;
            }
            else
            {
                hordeRaces = new List<string> { "Bloof Elf", "Goblin", "Orc", "Pandaren", "Troll", "Undead" };
                if (allied == true)
                    hordeRaces.AddRange(new List<string> { "Mag'har Orc", "Nightborne", "Vulpera", "Zandalari Troll" });
                return hordeRaces;
            }

        }

        public override List<string> GetAvailableSpecs(string faction, bool allied)
        {
            return new List<string> { "Arcane", "Fire", "Frost" };
        }
    }
}
