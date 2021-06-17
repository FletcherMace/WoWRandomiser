using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoWRandomiser.WowClasses;

namespace WoWRandomiser
{
    public class Player
    {
        static readonly Random rnd = new Random();

        private static readonly object syncLock = new object();

        public Player(string rFaction, bool isAllied)
        {
            CreatePlayer(rFaction, isAllied);
        }

        public WarcraftClass Class { get; set; }
        public string Race { get; set; }
        public string Specialisation { get; set; }
        public string Covenant { get; set; }
        public string Faction { get; set; }

        public bool Allied { get; set; }

        public void CreatePlayer(string rFaction, bool isAllied)
        {
            Faction = rFaction;
            Allied = isAllied;
            Class = GetRandomClass().Randomise(rFaction, isAllied);
            Race = Class.Race;
            Specialisation = Class.Spec;
        }

        public void ResetPlayer(string rFaction, bool isAllied)
        {
            CreatePlayer(rFaction, isAllied);
        }

        //Return a random WarcraftClass
        public WarcraftClass GetRandomClass()
        {
            lock (syncLock)
            {
                switch (rnd.Next(0, 11))
                {
                    case 0:
                        return new DeathKnight();
                    case 1:
                        return new DemonHunter();
                    case 2:
                        return new Druid();
                    case 3:
                        return new Hunter();
                    case 4:
                        return new Mage();
                    case 5:
                        return new Monk();
                    case 6:
                        return new Paladin();
                    case 7:
                        return new Priest();
                    case 8:
                        return new Rogue();
                    case 9:
                        return new Shaman();
                    case 10:
                        return new Warlock();
                    case 11:
                        return new Warrior();
                    default:
                        return new Druid();
                }
            }
        }
    }
}
