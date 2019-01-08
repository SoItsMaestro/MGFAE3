using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticInventory : MonoBehaviour {

    public static class InvStatic
    {
        private static int inventoryspace;
        private static int gold;
        private static int dummyBolt;
        private static int goblinPie;
        private static int essanceOfAir;
        private static int essanceOfUndeath;
        private static int boneDust;
        private static int skull;
        private static int essanceOfFire;
        private static int spectralDust;
        private static int volcanicEssence;
        private static int essanceOfEarth;
        private static int shroomHead;


        public static int InventorySpace
        {
            get
            {
                return inventoryspace;
            }
            set
            {
                inventoryspace = value;
            }
        }

        public static int Gold
        {
            get
            {
                return gold;
            }
            set
            {
                gold = value;
            }
        }

        public static int DummyBolt
        {
            get
            {
                return dummyBolt;
            }
            set
            {
                dummyBolt = value;
            }
        }

        public static int GoblinPie
        {
            get
            {
                return goblinPie;
            }
            set
            {
                goblinPie = value;
            }
        }

        public static int EssenceOfAir
        {
            get
            {
                return essanceOfAir;
            }
            set
            {
                essanceOfAir = value;
            }
        }

        public static int EssenceOfUndeath
        {
            get
            {
                return essanceOfUndeath;
            }
            set
            {
                essanceOfUndeath = value;
            }
        }

        public static int BoneDust
        {
            get
            {
                return boneDust;
            }
            set
            {
                boneDust = value;
            }
        }

        public static int Skull
        {
            get
            {
                return skull;
            }
            set
            {
                skull = value;
            }
        }

        public static int EssanceOfFire
        {
            get
            {
                return essanceOfFire;
            }
            set
            {
                essanceOfFire = value;
            }
        }

        public static int SpectralDust
        {
            get
            {
                return spectralDust;
            }
            set
            {
                spectralDust = value;
            }
        }

        public static int VolcanicEssance
        {
            get
            {
                return volcanicEssence;
            }
            set
            {
                volcanicEssence = value;
            }
        }

        public static int EssanceOfEarth
        {
            get
            {
                return essanceOfEarth;
            }
            set
            {
                essanceOfEarth = value;
            }
        }

        public static int ShroomHead
        {
            get
            {
                return shroomHead;
            }
            set
            {
                shroomHead = value;
            }
        }

    }
}
