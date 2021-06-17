using System;
using System.Collections.Generic;
using System.Windows.Media;

namespace WoWRandomiser.WowClasses
{
    public abstract class WarcraftClass : IWarcraftClass
    {
        protected static readonly Random rnd = new Random();

        private static readonly object syncLock = new object();

        public string Spec = "";
        public string Race = "";
        public string ClassName = "";

        public string Talent15 = "";
        public string Talent25 = "";
        public string Talent30 = "";
        public string Talent35 = "";
        public string Talent40 = "";
        public string Talent45 = "";
        public string Talent50 = "";


        public SolidColorBrush ClassColour;

        protected List<string> allianceRaces;
        protected List<string> hordeRaces;

        protected readonly string alliance = "Alliance";
        protected readonly string horde = "Horde";

        public WarcraftClass Randomise(string faction, bool allied)
        {
            List<string> races = GetAvailableRaces(faction, allied);
            List<string> specs = GetAvailableSpecs(faction, allied);
            lock(syncLock)
                this.Race = races[rnd.Next(0, races.Count)];
            lock (syncLock)
                this.Spec = specs[rnd.Next(0, specs.Count)];
            return this;
        }

        public abstract List<string> GetAvailableRaces(string faction, bool allied);
        public abstract List<string> GetAvailableSpecs(string faction, bool allied);
    }
}
