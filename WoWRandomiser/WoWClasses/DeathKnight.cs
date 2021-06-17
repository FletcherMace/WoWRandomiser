using System.Collections.Generic;
using System.Windows.Media;

namespace WoWRandomiser.WowClasses
{
    public class DeathKnight : WarcraftClass
    {
        public DeathKnight()
        {
            ClassName = "Death Knight";
            ClassColour = new SolidColorBrush(Color.FromRgb(196, 30, 58));
        }

        public override List<string> GetAvailableRaces(string faction, bool allied)
        {
            if(faction == alliance)
            {
                allianceRaces = new List<string> { "Draenei", "Dwarf", "Gnome", "Human", "Night Elf", "Pandaren", "Worgen" };
                if (allied == true)
                    allianceRaces.AddRange(new List<string> { "Dark Iron Dwarf", "Kul Tiran", "Lightforged Draenei", "Mechagnome", "Void Elf" });
                return allianceRaces;
            }
            else
            {
                hordeRaces = new List<string> { "Bloof Elf", "Goblin", "Orc", "Pandaren", "Tauren", "Troll", "Undead" };
                if (allied == true)
                    hordeRaces.AddRange(new List<string> { "Highmountain Tauren", "Mag'har Orc", "Nightborne", "Vulpera", "Zandalari Troll" });
                return hordeRaces;
            }
            
        }

        public override List<string> GetAvailableSpecs(string faction, bool allied)
        {
            return new List<string> { "Blood", "Frost", "Unholy" };
        }
    }
}
