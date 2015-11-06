using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Configuration;
using System.Security.Cryptography.X509Certificates;

namespace Triforce_Heroes_Save_Editor.Dictionaries
{
    public static class SaveDictionary
    {
        public static Dictionary<int, string> MaterialsDictionary = new Dictionary<int, string>
        {
            { 0x233, "Frilly Fabric" },
            { 0x234, "Friendly Token" },
            { 0x235, "Freebie" },
            { 0x236, "Blob Jelly" },
            { 0x237, "Armos Spirit" },
            { 0x238, "Tektite Shell" },
            { 0x239, "Sweet Shroom" },
            { 0x23A, "Blin Bling" },
            { 0x23B, "Ghoma's Eye" },
            { 0x23C, "Mystery Jade" },
            { 0x23D, "Supple Leaf" },
            { 0x23E, "Fresh Kelp" },
            { 0x23F, "Zora Scale" },
            { 0x240, "Hytopian Silk" },
            { 0x241, "Aqua Crown" },
            { 0x242, "Octorok Sucker" },
            { 0x243, "Fairy Dust" },
            { 0x244, "Rainbow Coral" },
            { 0x245, "Thornberry" },
            { 0x246, "Goron Ore" },
            { 0x247, "Monster Guts" },
            { 0x248, "Demon Fossil" },
            { 0x249, "Rugged Horn" },
            { 0x24A, "Kodongo Tail" },
            { 0x24B, "Keese Wing" },
            { 0x24C, "Star Fragment" },
            { 0x24D, "Divine Whiskers" },
            { 0x24E, "Fluffy Fuzz" },
            { 0x24F, "Tiny Snowflake" },
            { 0x250, "Serpent Fangs" },
            { 0x251, "Crimson Shell" },
            { 0x252, "Freezard Water" },
            { 0x253, "Chill Stone" },
            { 0x254, "Ice Rose" },
            { 0x255, "Beastie Patch" },
            { 0x256, "Stiff Puff" },
            { 0x257, "Silver Thread" },
            { 0x258, "Royal Ring" },
            { 0x259, "Antique Coin" },
            { 0x25A, "Fancy Fabric" },
            { 0x25B, "Exquisite Lace" },
            { 0x25C, "Vibrant Brooch" },
            { 0x25D, "Brittle Papyrus" },
            { 0x25E, "Palm Cone" },
            { 0x25F, "Ancient Fin" },
            { 0x260, "Vintage Linen" },
            { 0x261, "Gibdo Bandage" },
            { 0x262, "Stal Skull" },
            { 0x263, "Sandy Ribbon" },
            { 0x264, "Crystal Skull" },
            { 0x265, "Golden Insect" },
            { 0x266, "Carrumpkin" },
            { 0x267, "Mystery Extract" },
            { 0x268, "Spider Silk Lace" },
            { 0x269, "Poe Soul" },
            { 0x26A, "Twisted Twig" },
            { 0x26B, "Lava Drop" },
            { 0x26C, "Sanctuary Mask" },
            { 0x26D, "Gold Dust" },
            { 0x26E, "Cucco Feathers" },
            { 0x26F, "Carmine Pearl" },
            { 0x270, "Sky Dragon Tail" },
            { 0x271, "Pretty Plum" },
            { 0x272, "Mock Fairy" },
            { 0x273, "Aurora Stone" },
            { 0x274, "Steel Mask" },
            { 0x275, "Fabled Butteryfly" }
        };

        public static Dictionary<int, string> KeyItemsDictionary = new Dictionary<int, string>
        {
            { 0x230, "Lady's Glasses" },
            { 0x231, "Lady's Collar" },
            { 0x232, "Lady's Parasol" }
        };

        public static Dictionary<int, string> VoicesDictionary = new Dictionary<int, string>
        {
            { 0x00, "Link Between Worlds" },
            { 0x01, "Wind Waker" },
            { 0x02, "Ocarina of Time/Majoras Mask" },
            { 0x03, "Spirit Tracks" }
        };

        public static Dictionary<CostumeOffsets, string> CostumeDictionary = new Dictionary<CostumeOffsets, string>
        {
            { new CostumeOffsets(0x00, 0x838), "Bear Minimum"},
            { new CostumeOffsets(0x01, 0x83C), "Sword Link"},
            { new CostumeOffsets(0x02, 0x840), "Kokiri Clothes"},
            { new CostumeOffsets(0x03, 0x844), "Legendary Dress"},
            { new CostumeOffsets(0x04, 0x848), "Showstopper"},
            { new CostumeOffsets(0x05, 0x84C), "Goron Garb"},
            { new CostumeOffsets(0x06, 0x850), "Zora Costume"},
            { new CostumeOffsets(0x07, 0x854), "Queen of Hearts"},
            { new CostumeOffsets(0x08, 0x858), "Big Bomb Outfit"},
            { new CostumeOffsets(0x09, 0x85C), "Energy Gear"},
            { new CostumeOffsets(0x0A, 0x860), "Cozy Parka"},
            { new CostumeOffsets(0x0B, 0x864), "Spin Attack Attire"},
            { new CostumeOffsets(0x0C, 0x868), "Ninja Gi"},
            { new CostumeOffsets(0x0D, 0x86C), "Rupee Regalia"},
            { new CostumeOffsets(0x0E, 0x870), "Boomeranger"},
            { new CostumeOffsets(0x0F, 0x874), "Tri Suit"},
            { new CostumeOffsets(0x10, 0x878), "Lucky Loungewear"},
            { new CostumeOffsets(0x11, 0x87C), "Torrent Robe"},
            { new CostumeOffsets(0x12, 0x880, true), "Lady's Ensemble"}, // Key costume
            { new CostumeOffsets(0x13, 0x884, true), "Cursed Tights"}, // Key costume
            { new CostumeOffsets(0x14, 0x888), "Timeless Tunic"},
            { new CostumeOffsets(0x15, 0x88C), "Light Armour"},
            { new CostumeOffsets(0x16, 0x890), "Cheetah Costume"},
            { new CostumeOffsets(0x17, 0x894), "Jack of Hearts"},
            { new CostumeOffsets(0x18, 0x898), "Hero's Tunic"},
            { new CostumeOffsets(0x19, 0x89C), "Gust Garb"},
            { new CostumeOffsets(0x1A, 0x8A0), "Hammerwear"},
            { new CostumeOffsets(0x1B, 0x8A4), "Dunewalker Duds"},
            { new CostumeOffsets(0x1C, 0x8A8), "Robo Wear"},
            { new CostumeOffsets(0x1D, 0x8AC), "Fire Blazer"},
            { new CostumeOffsets(0x1E, 0x8B0), "Tingle Tights"},
            { new CostumeOffsets(0x1F, 0x8B4), "Serpent's Toga"},
            { new CostumeOffsets(0x20, 0x8B8), "Sword Master"},
            { new CostumeOffsets(0x21, 0x8BC), "Dapper Spinner"},
            { new CostumeOffsets(0x22, 0x8C0), "Cheerleader"},
            { new CostumeOffsets(0x23, 0x8C4), "Cacto Clothes"},
        };


        public static class Constants
        {
            public static int CurrentVoiceLocation = 0x37C;
            public static int CurrentCostumeLocation = 0x2B4;
            public static int PurchasedCostumeLocation = 0x2A8;
            public static int UnlockedCostumeLocation = 0x4D0;
            public static int NewIconCostumeLocation = 0x4D8;
            public static int RupeeLocation = 0x2B0; // Rupee's are from 0x2B0-0x2B3
        }

    }

    /// <summary>
    /// Contains two fields for a given item
    /// For example, a costume can have a hex value associated,
    /// along with a bitflag value.
    /// </summary>
    public class CostumeOffsets
    {
        // Value of the costume. Used for the current costume and bitflags
        public int CurrentCostumeValue;

        // Where in the save file is the costume located?
        public int CostumeUnlockedHex;

        public bool KeyCostume;

        // Default constructor
        public CostumeOffsets()
        {
            this.CurrentCostumeValue = 0x0;
            this.CostumeUnlockedHex = 0x0;
        }

        // Overloaded constructor
        public CostumeOffsets(int currentCostumeOffset, int costumeUnlockedHex, bool keyCostume = false)
        {
            this.CurrentCostumeValue = currentCostumeOffset;
            this.CostumeUnlockedHex = costumeUnlockedHex;
            this.KeyCostume = keyCostume;
        }

    }
}
