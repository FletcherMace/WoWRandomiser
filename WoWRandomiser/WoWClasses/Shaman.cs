using System.Collections.Generic;
using System.Windows.Media;

namespace WoWRandomiser.WowClasses
{
    class Shaman : WarcraftClass
    {
        public Shaman()
        {
            ClassName = "Shaman";
            ClassColour = new SolidColorBrush(Color.FromRgb(0, 112, 221));
        }

        public override List<string> GetAvailableRaces(string faction, bool allied)
        {
            if (faction == alliance)
            {
                allianceRaces = new List<string> { "Draenei", "Dwarf", "Pandaren" };
                if (allied == true)
                    allianceRaces.AddRange(new List<string> { "Dark Iron Dwarf", "Kul Tiran"});
                return allianceRaces;
            }
            else
            {
                hordeRaces = new List<string> { "Goblin", "Orc", "Pandaren", "Tauren", "Troll" };
                if (allied == true)
                    hordeRaces.AddRange(new List<string> { "Highmountain Tauren", "Mag'har Orc", "Vulpera", "Zandalari Troll" });
                return hordeRaces;
            }

        }

        public override List<string> GetAvailableSpecs(string faction, bool allied)
        {
            return new List<string> { "Elemental", "Enhancement", "Restoration" };
        }
    }
}
