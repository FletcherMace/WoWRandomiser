using System.Collections.Generic;
using System.Windows.Media;

namespace WoWRandomiser.WowClasses
{
    class Paladin : WarcraftClass
    {
        public Paladin()
        {
            ClassName = "Paladin";
            ClassColour = new SolidColorBrush(Color.FromRgb(244, 140, 186));
        }

        public override List<string> GetAvailableRaces(string faction, bool allied)
        {
            if (faction == alliance)
            {
                allianceRaces = new List<string> { "Draenei", "Dwarf", "Human" };
                if (allied == true)
                    allianceRaces.AddRange(new List<string> { "Dark Iron Dwarf", "Lightforged Draenei"});
                return allianceRaces;
            }
            else
            {
                hordeRaces = new List<string> { "Bloof Elf", "Tauren" };
                if (allied == true)
                    hordeRaces.AddRange(new List<string> { "Zandalari Troll" });
                return hordeRaces;
            }

        }

        public override List<string> GetAvailableSpecs(string faction, bool allied)
        {
            return new List<string> { "Holy", "Protection", "Retribution" };
        }
    }
}
