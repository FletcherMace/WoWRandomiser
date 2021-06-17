using System.Collections.Generic;

namespace WoWRandomiser.WowClasses
{
    interface IWarcraftClass
    {
        List<string> GetAvailableRaces(string faction, bool allied);
        List<string> GetAvailableSpecs(string faction, bool allied);
    }
}
