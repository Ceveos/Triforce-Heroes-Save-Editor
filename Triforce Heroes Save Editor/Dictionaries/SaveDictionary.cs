using System.Collections.Generic;

namespace Triforce_Heroes_Save_Editor.Dictionaries
{
    public static class SaveDictionary
    {
        public static Dictionary<int, string> MaterialsDictionary = new Dictionary<int, string>
        {
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

        public static int RupeeLocation = 0x2B0; // Rupee's are from 0x2B0-0x2B3
    }
}
