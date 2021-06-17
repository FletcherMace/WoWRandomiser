using System.Collections.Generic;
using System.Windows.Media;

namespace WoWRandomiser.WowClasses
{
    public class Druid : WarcraftClass
    {
        public Druid()
        {
            ClassName = "Druid";
            ClassColour = new SolidColorBrush(Color.FromRgb(255, 124, 10));
        }

        public override List<string> GetAvailableRaces(string faction, bool allied)
        {
            if (faction == alliance)
            {
                allianceRaces = new List<string> { "Night Elf", "Worgen" };
                if (allied == true)
                    allianceRaces.AddRange(new List<string> { "Kul Tiran" });
                return allianceRaces;
            }
            else
            {
                hordeRaces = new List<string> { "Tauren", "Troll" };
                if (allied == true)
                    hordeRaces.AddRange(new List<string> { "Highmountain Tauren", "Zandalari Troll"});
                return hordeRaces;
            }

        }

        public override List<string> GetAvailableSpecs(string faction, bool allied)
        {
            return new List<string> { "Balance", "Feral", "Guardian", "Restoration" };
        }
    }
}
