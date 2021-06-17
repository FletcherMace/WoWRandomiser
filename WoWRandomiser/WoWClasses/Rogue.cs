using System.Collections.Generic;
using System.Windows.Media;

namespace WoWRandomiser.WowClasses
{
    class Rogue : WarcraftClass
    {
        public Rogue()
        {
            ClassName = "Rogue";
            ClassColour = new SolidColorBrush(Color.FromRgb(255, 244, 104));
        }

        public override List<string> GetAvailableRaces(string faction, bool allied)
        {
            if (faction == alliance)
            {
                allianceRaces = new List<string> { "Dwarf", "Gnome", "Human", "Night Elf", "Pandaren", "Worgen" };
                if (allied == true)
                    allianceRaces.AddRange(new List<string> { "Dark Iron Dwarf", "Kul Tiran", "Mechagnome", "Void Elf" });
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
            return new List<string> { "Assassination", "Outlaw", "Subtlety" };
        }
    }
}
