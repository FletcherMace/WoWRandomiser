using System.Collections.Generic;
using System.Windows.Media;

namespace WoWRandomiser.WowClasses
{
    class Warlock : WarcraftClass
    {
        public Warlock()
        {
            ClassName = "Warlock";
            ClassColour = new SolidColorBrush(Color.FromRgb(135, 136, 238));
        }

        public override List<string> GetAvailableRaces(string faction, bool allied)
        {
            if (faction == alliance)
            {
                allianceRaces = new List<string> { "Dwarf", "Gnome", "Human", "Night Elf" };
                if (allied == true)
                    allianceRaces.AddRange(new List<string> { "Dark Iron Dwarf", "Mechagnome", "Void Elf" });
                return allianceRaces;
            }
            else
            {
                hordeRaces = new List<string> { "Bloof Elf", "Goblin", "Orc", "Troll", "Undead" };
                if (allied == true)
                    hordeRaces.AddRange(new List<string> { "Nightborne", "Vulpera" });
                return hordeRaces;
            }

        }

        public override List<string> GetAvailableSpecs(string faction, bool allied)
        {
            return new List<string> { "Affliction", "Destruction", "Demonology" };
        }
    }
}
