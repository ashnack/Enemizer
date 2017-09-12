﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnemizerLibrary
{
    public class OverworldAreaConstants
    {
        public static string GetAreaName(int areaId)
        {
            string areaName;

            if (areaNames.TryGetValue(areaId, out areaName))
            {
                return areaName;
            }

            return null;
        }

        static Dictionary<int, string> areaNames = new Dictionary<int, string>()
        {
            // Light World (After Saving Zelda)
            { 0x000, "Lost Woods" },
            { 0x001, "Lost Woods (2)" },
            { 0x002, "Lumber Jack House" },
            { 0x003, "West Death Mountain" },
            { 0x004, "West Death Mountain (2)" },
            { 0x005, "East Death Mountain" },
            { 0x006, "East Death Mountain (2)" },
            { 0x007, "East Death Mountain Warp for Turtle Rock" },
            { 0x008, "Lost Woods (3?)" },
            { 0x009, "Lost Woods (4?)" },
            { 0x00A, "Entrance to Death Mountain" },
            { 0x00B, "West Death Mountain (3?)" },
            { 0x00C, "West Death Mountain (4?)" },
            { 0x00D, "East Death Mountain (3?)" },
            { 0x00E, "East Death Mountain (3?)" },
            { 0x00F, "Entrance to Zora's Domain" },
            { 0x010, "Path Between Kakariko Village and Lost Woods" },
            { 0x011, "Kakariko Village Fortune Teller" },
            { 0x012, "Pond Between Kakariko Village Fortune Teller and Sanctuary" },
            { 0x013, "Sanctuary" },
            { 0x014, "Graveyard" },
            { 0x015, "River Between Graveyard and Witch's Hut" },
            { 0x016, "Witch's Hut" },
            { 0x017, "East of Witch's Hut" },
            { 0x018, "Kakariko Village" },
            { 0x019, "Kakariko Village (2)" },
            { 0x01A, "Forest Between Kakariko Village and Hyrule Castle" },
            { 0x01B, "Hyrule Castle" },
            { 0x01C, "Hyrule Castle (2)" },
            { 0x01D, "Bridge Between Graveyard and Witch's Hut" },
            { 0x01E, "Eastern Palace" },
            { 0x01F, "Eastern Palace (2)" },
            { 0x020, "Kakariko Village (3?)" },
            { 0x021, "Kakariko Village (4?)" },
            { 0x022, "Smithy" },
            { 0x023, "Hyrule Castle (3?)" },
            { 0x024, "Hyrule Castle (4?)" },
            { 0x025, "Path Between Hyrule Castle and Eastern Palace (top)" },
            { 0x026, "Eastern Palace (3?)" },
            { 0x027, "Eastern Palace (4?)" },
            { 0x028, "Kakariko Village Maze Race" },
            { 0x029, "Kakariko Village Library" },
            { 0x02A, "Haunted Grove" },
            { 0x02B, "Forest Between Haunted Grove and Link's House" },
            { 0x02C, "Link's House" },
            { 0x02D, "Path Between Hyrule Castle and Eastern Palace (bottom)" },
            { 0x02E, "Caves South of Eastern Palace (left)" },
            { 0x02F, "Caves South of Eastern Palace (right)" },
            { 0x030, "Desert of Mystery" },
            { 0x031, "Desert of Mystery (2)" },
            { 0x032, "South of Haunted Grove" },
            { 0x033, "North-western Great Swamp" },
            { 0x034, "North-eastern Great Swamp" },
            { 0x035, "Lake Hylia" },
            { 0x036, "Lake Hylia (2)" },
            { 0x037, "Ice Cave" },
            { 0x038, "Desert of Mystery (3?)" },
            { 0x039, "Desert of Mystery (4?)" },
            { 0x03A, "Path Between Desert of Mystery and Great Swamp" },
            { 0x03B, "South-western Great Swamp" },
            { 0x03C, "South-eastern Great Swamp" },
            { 0x03D, "Lake Hylia (3?)" },
            { 0x03E, "Lake Hylia (4?)" },
            { 0x03F, "Path Between Lake Hylia and Ice Cave" },

            // Dark World
            { 0x040, "Skull Woods (DW)" },
            { 0x041, "Lumber Jack House (DW)" }, // double check, this should be Skull Woods....
            { 0x042, "Lumber Jack House (2) (DW)" },
            { 0x043, "West Death Mountain (DW)" },
            { 0x044, "East Death Mountain (DW)" }, // double check, this should be West DM....
            { 0x045, "East Death Mountain (2) (DW)" }, // double check, this should be East 1
            { 0x046, "??" }, // double check, this should be East (2)
            { 0x047, "Turtle Rock" },
            { 0x048, "Lost Woods (3?) (DW)" },
            { 0x049, "Lost Woods (4?) (DW)" },
            { 0x04A, "Bumper Cave Entrance (DW)" },
            { 0x04B, "West Death Mountain (3?) (DW)" },
            { 0x04C, "West Death Mountain (4?) (DW)" },
            { 0x04D, "East Death Mountain (3?) (DW)" },
            { 0x04E, "East Death Mountain (4?) (DW)" },
            { 0x04F, "Catfish (DW)" },
            { 0x050, "Path Between Village of Outcasts and Skull Woods (DW)" },
            { 0x051, "Village of Outcasts Fortune Teller (DW)" },
            { 0x052, "Pond Between Village of Outcasts Fortune Teller and Sanctuary (DW)" },
            { 0x053, "Sanctuary (DW)" },
            { 0x054, "Graveyard (DW)" },
            { 0x055, "River Between Graveyard and Witch's Hut (DW)" },
            { 0x056, "Witch's Hut (DW)" },
            { 0x057, "East of Witch's Hut (DW)" },
            { 0x058, "Village of Outcasts (DW)" },
            { 0x059, "Village of Outcasts (2) (DW)" },
            { 0x05A, "Forest Between Village of Outcasts and Pyramid (DW)" },
            { 0x05B, "Pyramid (DW)" },
            { 0x05C, "Pyramid (2) (DW)" },
            { 0x05D, "Broken Bridge Between Graveyard and Witch's Hut (DW)" },
            { 0x05E, "Palace of Darkness (DW)" },
            { 0x05F, "Palace of Darkness (2) (DW)" },
            { 0x060, "Village of Outcasts (3?) (DW)" },
            { 0x061, "Village of Outcasts (4?) (DW)" },
            { 0x062, "Smithy (DW)" },
            { 0x063, "Pyramid (3?) (DW)" },
            { 0x064, "Pyramid (4?) (DW)" },
            { 0x065, "Path Between Pyramid and Palace of Darkness (top) (DW)" },
            { 0x066, "Palace of Darkness (3?) (DW)" },
            { 0x067, "Palace of Darkness (4?) (DW)" },
            { 0x068, "Digging Game (DW)" },
            { 0x069, "Village of Outcasts Frog Smith (DW)" },
            { 0x06A, "Haunted Grove (DW)" },
            { 0x06B, "Forest Between Haunted Grove and Link's House (DW)" },
            { 0x06C, "Bomb Shop (Link's House) (DW)" },
            { 0x06D, "Path Between Pyramid and Palace of Darkness (bottom) (DW)" },
            { 0x06E, "Caves South of Palace of Darkness (left) (DW)" },
            { 0x06F, "Caves South of Palace of Darkness (right) (DW)" },
            { 0x070, "Misery Mire (DW)" },
            { 0x071, "South of Haunted Grove (DW)" },
            { 0x072, "South of Haunted Grove (DW) (Duplicate)" },
            { 0x073, "North-western Great Swamp (DW)" },
            { 0x074, "North-eastern Great Swamp (DW)" },
            { 0x075, "Lake Hylia (DW)" },
            { 0x076, "Ice Cave (DW)" },
            { 0x077, "Ice Cave (DW)" },
            { 0x078, "Misery Mire (3?) (DW)" },
            { 0x079, "Misery Mire (4?) (DW)" },
            { 0x07A, "Path Between Misery Mire and Great Swamp (DW)" },
            { 0x07B, "South-western Great Swamp (DW)" },
            { 0x07C, "South-eastern Great Swamp (DW)" },
            { 0x07D, "Lake Hylia (3?) (DW)" },
            { 0x07E, "Lake Hylia (4?) (DW)" },
            { 0x07F, "Path Between Lake Hylia and Ice Cave (DW)" },

            { 0x080, "Master Sword Glade / Under Bridge" },
            { 0x081, "Zora's Domain" },

            { 0x082, "??" },
            { 0x083, "??" },
            { 0x084, "??" },
            { 0x085, "??" },
            { 0x086, "??" },
            { 0x087, "??" },
            { 0x088, "??" },
            { 0x089, "??" },
            { 0x08A, "??" },
            { 0x08B, "??" },
            { 0x08C, "??" },
            { 0x08D, "??" },
            { 0x08E, "??" },
            { 0x08F, "??" },

            // after killing Aga (probably)
            // Light World (Post-Aga)
            { 0x090, "Lost Woods (Post-Aga)" },
            { 0x091, "Lost Woods (2) (Post-Aga)" },
            { 0x092, "Lumber Jack House (Post-Aga)" },
            { 0x093, "West Death Mountain (Post-Aga)" },
            { 0x094, "West Death Mountain (2) (Post-Aga)" },
            { 0x095, "East Death Mountain (Post-Aga)" },
            { 0x096, "East Death Mountain (2) (Post-Aga)" },
            { 0x097, "East Death Mountain Warp for Turtle Rock (Post-Aga)" },
            { 0x098, "Lost Woods (3?) (Post-Aga)" },
            { 0x099, "Lost Woods (4?) (Post-Aga)" },
            { 0x09A, "Entrance to Death Mountain (Post-Aga)" },
            { 0x09B, "West Death Mountain (3?) (Post-Aga)" },
            { 0x09C, "West Death Mountain (4?) (Post-Aga)" },
            { 0x09D, "East Death Mountain (3?) (Post-Aga)" },
            { 0x09E, "East Death Mountain (3?) (Post-Aga)" },
            { 0x09F, "Entrance to Zora's Domain (Post-Aga)" },
            { 0x0A0, "Path Between Kakariko Village and Lost Woods (Post-Aga)" },
            { 0x0A1, "Kakariko Village Fortune Teller (Post-Aga)" },
            { 0x0A2, "Pond Between Kakariko Village Fortune Teller and Sanctuary (Post-Aga)" },
            { 0x0A3, "Sanctuary (Post-Aga)" },
            { 0x0A4, "Graveyard (Post-Aga)" },
            { 0x0A5, "River Between Graveyard and Witch's Hut (Post-Aga)" },
            { 0x0A6, "Witch's Hut (Post-Aga)" },
            { 0x0A7, "East of Witch's Hut (Post-Aga)" },
            { 0x0A8, "Kakariko Village (Post-Aga)" },
            { 0x0A9, "Kakariko Village (2) (Post-Aga)" },
            { 0x0AA, "Forest Between Kakariko Village and Hyrule Castle (Post-Aga)" },
            { 0x0AB, "Hyrule Castle (Post-Aga)" },
            { 0x0AC, "Hyrule Castle (2) (Post-Aga)" },
            { 0x0AD, "Bridge Between Graveyard and Witch's Hut (Post-Aga)" },
            { 0x0AE, "Eastern Palace (Post-Aga)" },
            { 0x0AF, "Eastern Palace (2) (Post-Aga)" },
            { 0x0B0, "Kakariko Village (3?) (Post-Aga)" },
            { 0x0B1, "Kakariko Village (4?) (Post-Aga)" },
            { 0x0B2, "Smithy (Post-Aga)" },
            { 0x0B3, "Hyrule Castle (3?) (Post-Aga)" },
            { 0x0B4, "Hyrule Castle (4?) (Post-Aga)" },
            { 0x0B5, "Path Between Hyrule Castle and Eastern Palace (top) (Post-Aga)" },
            { 0x0B6, "Eastern Palace (3?) (Post-Aga)" },
            { 0x0B7, "Eastern Palace (4?) (Post-Aga)" },
            { 0x0B8, "Kakariko Village Maze Race (Post-Aga)" },
            { 0x0B9, "Kakariko Village Library (Post-Aga)" },
            { 0x0BA, "Haunted Grove (Post-Aga)" },
            { 0x0BB, "Forest Between Haunted Grove and Link's House (Post-Aga)" },
            { 0x0BC, "Link's House (Post-Aga)" },
            { 0x0BD, "Path Between Hyrule Castle and Eastern Palace (bottom) (Post-Aga)" },
            { 0x0BE, "Caves South of Eastern Palace (left) (Post-Aga)" },
            { 0x0BF, "Caves South of Eastern Palace (right) (Post-Aga)" },
            { 0x0C0, "Desert of Mystery (Post-Aga)" },
            { 0x0C1, "Desert of Mystery (2) (Post-Aga)" },
            { 0x0C2, "South of Haunted Grove (Post-Aga)" },
            { 0x0C3, "North-western Great Swamp (Post-Aga)" },
            { 0x0C4, "North-eastern Great Swamp (Post-Aga)" },
            { 0x0C5, "Lake Hylia (Post-Aga)" },
            //{ 0x0C6, "Lake Hylia (2) (Post-Aga)" },
            { 0x0C6, "Ice Cave (Post-Aga)??" }, // check, should be hylia (2)
            { 0x0C7, "Ice Cave (Post-Aga)" },
            //{ 0x0C8, "Desert of Mystery (3?) (Post-Aga)" },
            //{ 0x0C9, "Desert of Mystery (4?) (Post-Aga)" },
            { 0x0C8, "Path Between Desert of Mystery and Great Swamp (Post-Aga)??" }, // check, should be desert (3)
            { 0x0C9, "Path Between Desert of Mystery and Great Swamp (Post-Aga)??" }, // check, should be desert (4)
            { 0x0CA, "Path Between Desert of Mystery and Great Swamp (Post-Aga)" },
            { 0x0CB, "South-western Great Swamp (Post-Aga)" },
            { 0x0CC, "South-eastern Great Swamp (Post-Aga)" },
            //{ 0x0CD, "Lake Hylia (3?) (Post-Aga)" },
            //{ 0x0CE, "Lake Hylia (4?) (Post-Aga)" },
            { 0x0CD, "Path Between Lake Hylia and Ice Cave (Post-Aga)??" }, // check, should be lake (3)
            { 0x0CE, "Path Between Lake Hylia and Ice Cave (Post-Aga)??" }, // check, should be lake (4)
            { 0x0CF, "Path Between Lake Hylia and Ice Cave (Post-Aga)" },

            // Dark World (Post-Aga?)
            { 0x0D0, "Skull Woods (DW) (Post-Aga)" },
            { 0x0D1, "Lumber Jack House (DW) (Post-Aga)" }, // double check, this should be Skull Woods....
            { 0x0D2, "Lumber Jack House (2) (DW) (Post-Aga)" },
            { 0x0D3, "West Death Mountain (DW) (Post-Aga)" },
            { 0x0D4, "East Death Mountain (DW) (Post-Aga)" }, // double check, this should be West DM....
            { 0x0D5, "East Death Mountain (2) (DW) (Post-Aga)" }, // double check, this should be East 1
            { 0x0D6, "?? (Post-Aga)" }, // double check, this should be East (2)
            { 0x0D7, "Turtle Rock (Post-Aga)" },
            { 0x0D8, "Lost Woods (3?) (DW) (Post-Aga)" },
            { 0x0D9, "Lost Woods (4?) (DW) (Post-Aga)" },
            { 0x0DA, "Bumper Cave Entrance (DW) (Post-Aga)" },
            { 0x0DB, "West Death Mountain (3?) (DW) (Post-Aga)" },
            { 0x0DC, "West Death Mountain (4?) (DW) (Post-Aga)" },
            { 0x0DD, "East Death Mountain (3?) (DW) (Post-Aga)" },
            { 0x0DE, "East Death Mountain (4?) (DW) (Post-Aga)" },
            { 0x0DF, "Catfish (DW) (Post-Aga)" },
            { 0x0E0, "Path Between Village of Outcasts and Skull Woods (DW) (Post-Aga)" },
            { 0x0E1, "Village of Outcasts Fortune Teller (DW) (Post-Aga)" },
            { 0x0E2, "Pond Between Village of Outcasts Fortune Teller and Sanctuary (DW) (Post-Aga)" },
            { 0x0E3, "Sanctuary (DW) (Post-Aga)" },
            { 0x0E4, "Graveyard (DW) (Post-Aga)" },
            { 0x0E5, "River Between Graveyard and Witch's Hut (DW) (Post-Aga)" },
            { 0x0E6, "Witch's Hut (DW) (Post-Aga)" },
            { 0x0E7, "East of Witch's Hut (DW) (Post-Aga)" },
            { 0x0E8, "Village of Outcasts (DW) (Post-Aga)" },
            { 0x0E9, "Village of Outcasts (2) (DW) (Post-Aga)" },
            { 0x0EA, "Forest Between Village of Outcasts and Pyramid (DW) (Post-Aga)" },
            { 0x0EB, "Pyramid (DW) (Post-Aga)" },
            { 0x0EC, "Pyramid (2) (DW) (Post-Aga)" },
            { 0x0ED, "Broken Bridge Between Graveyard and Witch's Hut (DW) (Post-Aga)" },
            { 0x0EE, "Palace of Darkness (DW) (Post-Aga)" },
            { 0x0EF, "Palace of Darkness (2) (DW) (Post-Aga)" },
            { 0x0F0, "Village of Outcasts (3?) (DW) (Post-Aga)" },
            { 0x0F1, "Village of Outcasts (4?) (DW) (Post-Aga)" },
            { 0x0F2, "Smithy (DW) (Post-Aga)" },
            { 0x0F3, "Pyramid (3?) (DW) (Post-Aga)" },
            { 0x0F4, "Pyramid (4?) (DW) (Post-Aga)" },
            { 0x0F5, "Path Between Pyramid and Palace of Darkness (top) (DW) (Post-Aga)" },
            { 0x0F6, "Palace of Darkness (3?) (DW) (Post-Aga)" },
            { 0x0F7, "Palace of Darkness (4?) (DW) (Post-Aga)" },
            { 0x0F8, "Digging Game (DW) (Post-Aga)" },
            { 0x0F9, "Village of Outcasts Frog Smith (DW) (Post-Aga)" },
            { 0x0FA, "Haunted Grove (DW) (Post-Aga)" },
            { 0x0FB, "Forest Between Haunted Grove and Link's House (DW) (Post-Aga)" },
            { 0x0FC, "Bomb Shop (Link's House) (DW) (Post-Aga)" },
            { 0x0FD, "Path Between Pyramid and Palace of Darkness (bottom) (DW) (Post-Aga)" },
            { 0x0FE, "Caves South of Palace of Darkness (left) (DW) (Post-Aga)" },
            { 0x0FF, "Caves South of Palace of Darkness (right) (DW) (Post-Aga)" },
            { 0x100, "Misery Mire (DW) (Post-Aga)" },
            { 0x101, "South of Haunted Grove (DW) (Post-Aga)" },
            { 0x102, "South of Haunted Grove (DW) (Duplicate) (Post-Aga)" },
            { 0x103, "North-western Great Swamp (DW) (Post-Aga)" },
            { 0x104, "North-eastern Great Swamp (DW) (Post-Aga)" },
            { 0x105, "Lake Hylia (DW) (Post-Aga)" },
            { 0x106, "Ice Cave (DW) (Post-Aga)" },
            { 0x107, "Ice Cave (DW) (Post-Aga)" },
            { 0x108, "Misery Mire (3?) (DW) (Post-Aga)" },
            { 0x109, "Misery Mire (4?) (DW) (Post-Aga)" },
            { 0x10A, "Path Between Misery Mire and Great Swamp (DW) (Post-Aga)" },
            { 0x10B, "South-western Great Swamp (DW) (Post-Aga)" },
            { 0x10C, "South-eastern Great Swamp (DW) (Post-Aga)" },
            { 0x10D, "Lake Hylia (3?) (DW) (Post-Aga)" },
            { 0x10E, "Lake Hylia (4?) (DW) (Post-Aga)" },
            { 0x10F, "Path Between Lake Hylia and Ice Cave (DW) (Post-Aga)" },
            // these seem to be pointing to the same sprite data as pre-aga (same addresses)
            { 0x110, "Master Sword Glade / Under Bridge (Post-Aga)" },
            { 0x111, "Zora's Domain (Post-Aga)" },
        };

        public const int
            A000_LostWoods = 0x000,
            A001_LostWoods_2 = 0x001,
            A002_LumberJackHouse = 0x002,
            A003_WestDeathMountain = 0x003,
            A004_WestDeathMountain_2 = 0x004,
            A005_EastDeathMountain = 0x005,
            A006_EastDeathMountain_2 = 0x006,
            A007_EastDeathMountainWarpforTurtleRock = 0x007,
            A008_LostWoods_3 = 0x008,
            A009_LostWoods_4 = 0x009,
            A00A_EntrancetoDeathMountain = 0x00A,
            A00B_WestDeathMountain_3 = 0x00B,
            A00C_WestDeathMountain_4 = 0x00C,
            A00D_EastDeathMountain_3 = 0x00D,
            A00E_EastDeathMountain_3_2 = 0x00E,
            A00F_EntrancetoZorasDomain = 0x00F,
            A010_PathBetweenKakarikoVillageandLostWoods = 0x010,
            A011_KakarikoVillageFortuneTeller = 0x011,
            A012_PondBetweenKakarikoVillageFortuneTellerandSanctuary = 0x012,
            A013_Sanctuary = 0x013,
            A014_Graveyard = 0x014,
            A015_RiverBetweenGraveyardandWitchsHut = 0x015,
            A016_WitchsHut = 0x016,
            A017_EastofWitchsHut = 0x017,
            A018_KakarikoVillage = 0x018,
            A019_KakarikoVillage_2 = 0x019,
            A01A_ForestBetweenKakarikoVillageandHyruleCastle = 0x01A,
            A01B_HyruleCastle = 0x01B,
            A01C_HyruleCastle_2 = 0x01C,
            A01D_BridgeBetweenGraveyardandWitchsHut = 0x01D,
            A01E_EasternPalace = 0x01E,
            A01F_EasternPalace_2 = 0x01F,
            A020_KakarikoVillage_3 = 0x020,
            A021_KakarikoVillage_4 = 0x021,
            A022_Smithy = 0x022,
            A023_HyruleCastle_3 = 0x023,
            A024_HyruleCastle_4 = 0x024,
            A025_PathBetweenHyruleCastleandEasternPalace_top = 0x025,
            A026_EasternPalace_3 = 0x026,
            A027_EasternPalace_4 = 0x027,
            A028_KakarikoVillageMazeRace = 0x028,
            A029_KakarikoVillageLibrary = 0x029,
            A02A_HauntedGrove = 0x02A,
            A02B_ForestBetweenHauntedGroveandLinksHouse = 0x02B,
            A02C_LinksHouse = 0x02C,
            A02D_PathBetweenHyruleCastleandEasternPalace_bottom = 0x02D,
            A02E_CavesSouthofEasternPalace_left = 0x02E,
            A02F_CavesSouthofEasternPalace_right = 0x02F,
            A030_DesertofMystery = 0x030,
            A031_DesertofMystery_2 = 0x031,
            A032_SouthofHauntedGrove = 0x032,
            A033_NorthWesternGreatSwamp = 0x033,
            A034_NorthEasternGreatSwamp = 0x034,
            A035_LakeHylia = 0x035,
            A036_LakeHylia_2 = 0x036,
            A037_IceCave = 0x037,
            A038_DesertofMystery_3 = 0x038,
            A039_DesertofMystery_4 = 0x039,
            A03A_PathBetweenDesertofMysteryandGreatSwamp = 0x03A,
            A03B_SouthWesternGreatSwamp = 0x03B,
            A03C_SouthEasternGreatSwamp = 0x03C,
            A03D_LakeHylia_3 = 0x03D,
            A03E_LakeHylia_4 = 0x03E,
            A03F_PathBetweenLakeHyliaandIceCave = 0x03F,

            //DarkWorld					
            A040_SkullWoods_DW = 0x040,
            A041_LumberJackHouse_DW = 0x041,	//doublecheck,thisshouldbeSkullWoods....		
            A042_LumberJackHouse_2_DW = 0x042,
            A043_WestDeathMountain_DW = 0x043,
            A044_EastDeathMountain_DW = 0x044,	//doublecheck,thisshouldbeWestDM....		
            A045_EastDeathMountain_2_DW = 0x045,	//doublecheck,thisshouldbeEast1		
            A046_Unknown_0x46 = 0x046,	//doublecheck,thisshouldbeEast_2		
            A047_TurtleRock = 0x047,
            A048_LostWoods_3_DW = 0x048,
            A049_LostWoods_4_DW = 0x049,
            A04A_BumperCaveEntrance_DW = 0x04A,
            A04B_WestDeathMountain_3_DW = 0x04B,
            A04C_WestDeathMountain_4_DW = 0x04C,
            A04D_EastDeathMountain_3_DW = 0x04D,
            A04E_EastDeathMountain_4_DW = 0x04E,
            A04F_Catfish_DW = 0x04F,
            A050_PathBetweenVillageofOutcastsandSkullWoods_DW = 0x050,
            A051_VillageofOutcastsFortuneTeller_DW = 0x051,
            A052_PondBetweenVillageofOutcastsFortuneTellerandSanctuary_DW = 0x052,
            A053_Sanctuary_DW = 0x053,
            A054_Graveyard_DW = 0x054,
            A055_RiverBetweenGraveyardandWitchsHut_DW = 0x055,
            A056_WitchsHut_DW = 0x056,
            A057_EastofWitchsHut_DW = 0x057,
            A058_VillageofOutcasts_DW = 0x058,
            A059_VillageofOutcasts_2_DW = 0x059,
            A05A_ForestBetweenVillageofOutcastsandPyramid_DW = 0x05A,
            A05B_Pyramid_DW = 0x05B,
            A05C_Pyramid_2_DW = 0x05C,
            A05D_BrokenBridgeBetweenGraveyardandWitchsHut_DW = 0x05D,
            A05E_PalaceofDarkness_DW = 0x05E,
            A05F_PalaceofDarkness_2_DW = 0x05F,
            A060_VillageofOutcasts_3_DW = 0x060,
            A061_VillageofOutcasts_4_DW = 0x061,
            A062_Smithy_DW = 0x062,
            A063_Pyramid_3_DW = 0x063,
            A064_Pyramid_4_DW = 0x064,
            A065_PathBetweenPyramidandPalaceofDarkness_top_DW = 0x065,
            A066_PalaceofDarkness_3_DW = 0x066,
            A067_PalaceofDarkness_4_DW = 0x067,
            A068_DiggingGame_DW = 0x068,
            A069_VillageofOutcastsFrogSmith_DW = 0x069,
            A06A_HauntedGrove_DW = 0x06A,
            A06B_ForestBetweenHauntedGroveandLinksHouse_DW = 0x06B,
            A06C_BombShop_LinksHouse_DW = 0x06C,
            A06D_PathBetweenPyramidandPalaceofDarkness_bottom_DW = 0x06D,
            A06E_CavesSouthofPalaceofDarkness_left_DW = 0x06E,
            A06F_CavesSouthofPalaceofDarkness_right_DW = 0x06F,
            A070_MiseryMire_DW = 0x070,
            A071_SouthofHauntedGrove_DW = 0x071,
            A072_SouthofHauntedGrove_DW_Duplicate = 0x072,
            A073_NorthWesternGreatSwamp_DW = 0x073,
            A074_NorthEasternGreatSwamp_DW = 0x074,
            A075_LakeHylia_DW = 0x075,
            A076_IceCave_DW = 0x076,
            A077_IceCave_DW_2 = 0x077,
            A078_MiseryMire_3_DW = 0x078,
            A079_MiseryMire_4_DW = 0x079,
            A07A_PathBetweenMiseryMireandGreatSwamp_DW = 0x07A,
            A07B_SouthWesternGreatSwamp_DW = 0x07B,
            A07C_SouthEasternGreatSwamp_DW = 0x07C,
            A07D_LakeHylia_3_DW = 0x07D,
            A07E_LakeHylia_4_DW = 0x07E,
            A07F_PathBetweenLakeHyliaandIceCave_DW = 0x07F,

            A080_MasterSwordGlade_UnderBridge = 0x080,
            A081_ZorasDomain = 0x081,

            A082_Unknown_0x82 = 0x082,
            A083_Unknown_0x83 = 0x083,
            A084_Unknown_0x84 = 0x084,
            A085_Unknown_0x85 = 0x085,
            A086_Unknown_0x86 = 0x086,
            A087_Unknown_0x87 = 0x087,
            A088_Unknown_0x88 = 0x088,
            A089_Unknown_0x89 = 0x089,
            A08A_Unknown_0x8A = 0x08A,
            A08B_Unknown_0x8B = 0x08B,
            A08C_Unknown_0x8C = 0x08C,
            A08D_Unknown_0x8D = 0x08D,
            A08E_Unknown_0x8E = 0x08E,
            A08F_Unknown_0x8F = 0x08F,

            //afterkillingAga(probably)					
            //LightWorld_PostAga					
            A090_LostWoods_PostAga = 0x090,
            A091_LostWoods_2_PostAga = 0x091,
            A092_LumberJackHouse_PostAga = 0x092,
            A093_WestDeathMountain_PostAga = 0x093,
            A094_WestDeathMountain_2_PostAga = 0x094,
            A095_EastDeathMountain_PostAga = 0x095,
            A096_EastDeathMountain_2_PostAga = 0x096,
            A097_EastDeathMountainWarpforTurtleRock_PostAga = 0x097,
            A098_LostWoods_3_PostAga = 0x098,
            A099_LostWoods_4_PostAga = 0x099,
            A09A_EntrancetoDeathMountain_PostAga = 0x09A,
            A09B_WestDeathMountain_3_PostAga = 0x09B,
            A09C_WestDeathMountain_4_PostAga = 0x09C,
            A09D_EastDeathMountain_3_PostAga = 0x09D,
            A09E_EastDeathMountain_3_PostAga_2 = 0x09E,
            A09F_EntrancetoZorasDomain_PostAga = 0x09F,
            A0A0_PathBetweenKakarikoVillageandLostWoods_PostAga = 0x0A0,
            A0A1_KakarikoVillageFortuneTeller_PostAga = 0x0A1,
            A0A2_PondBetweenKakarikoVillageFortuneTellerandSanctuary_PostAga = 0x0A2,
            A0A3_Sanctuary_PostAga = 0x0A3,
            A0A4_Graveyard_PostAga = 0x0A4,
            A0A5_RiverBetweenGraveyardandWitchsHut_PostAga = 0x0A5,
            A0A6_WitchsHut_PostAga = 0x0A6,
            A0A7_EastofWitchsHut_PostAga = 0x0A7,
            A0A8_KakarikoVillage_PostAga = 0x0A8,
            A0A9_KakarikoVillage_2_PostAga = 0x0A9,
            A0AA_ForestBetweenKakarikoVillageandHyruleCastle_PostAga = 0x0AA,
            A0AB_HyruleCastle_PostAga = 0x0AB,
            A0AC_HyruleCastle_2_PostAga = 0x0AC,
            A0AD_BridgeBetweenGraveyardandWitchsHut_PostAga = 0x0AD,
            A0AE_EasternPalace_PostAga = 0x0AE,
            A0AF_EasternPalace_2_PostAga = 0x0AF,
            A0B0_KakarikoVillage_3_PostAga = 0x0B0,
            A0B1_KakarikoVillage_4_PostAga = 0x0B1,
            A0B2_Smithy_PostAga = 0x0B2,
            A0B3_HyruleCastle_3_PostAga = 0x0B3,
            A0B4_HyruleCastle_4_PostAga = 0x0B4,
            A0B5_PathBetweenHyruleCastleandEasternPalace_top_PostAga = 0x0B5,
            A0B6_EasternPalace_3_PostAga = 0x0B6,
            A0B7_EasternPalace_4_PostAga = 0x0B7,
            A0B8_KakarikoVillageMazeRace_PostAga = 0x0B8,
            A0B9_KakarikoVillageLibrary_PostAga = 0x0B9,
            A0BA_HauntedGrove_PostAga = 0x0BA,
            A0BB_ForestBetweenHauntedGroveandLinksHouse_PostAga = 0x0BB,
            A0BC_LinksHouse_PostAga = 0x0BC,
            A0BD_PathBetweenHyruleCastleandEasternPalace_bottom_PostAga = 0x0BD,
            A0BE_CavesSouthofEasternPalace_left_PostAga = 0x0BE,
            A0BF_CavesSouthofEasternPalace_right_PostAga = 0x0BF,
            A0C0_DesertofMystery_PostAga = 0x0C0,
            A0C1_DesertofMystery_2_PostAga = 0x0C1,
            A0C2_SouthofHauntedGrove_PostAga = 0x0C2,
            A0C3_NorthWesternGreatSwamp_PostAga = 0x0C3,
            A0C4_NorthEasternGreatSwamp_PostAga = 0x0C4,
            A0C5_LakeHylia_PostAga = 0x0C5,
            A0C6_LakeHylia_2_PostAga = 0x0C6,
            A0C6_IceCave_PostAga_ShouldBeHylia2 = 0x0C6,	//check,shouldbehylia_2		
            A0C7_IceCave_PostAga = 0x0C7,
            A0C8_DesertofMystery_3_PostAga = 0x0C8,
            A0C9_DesertofMystery_4_PostAga = 0x0C9,
            A0C8_PathBetweenDesertofMysteryandGreatSwamp_PostAga_ShouldBeDesert3 = 0x0C8,	//check,shouldbedesert(3)		
            A0C9_PathBetweenDesertofMysteryandGreatSwamp_PostAga_ShouldBeDesert4 = 0x0C9,	//check,shouldbedesert(4)		
            A0CA_PathBetweenDesertofMysteryandGreatSwamp_PostAga = 0x0CA,
            A0CB_SouthWesternGreatSwamp_PostAga = 0x0CB,
            A0CC_SouthEasternGreatSwamp_PostAga = 0x0CC,
            A0CD_LakeHylia_3_PostAga = 0x0CD,
            A0CE_LakeHylia_4_PostAga = 0x0CE,
            A0CD_PathBetweenLakeHyliaandIceCave_PostAga_ShouldBeLake3 = 0x0CD,	//check,shouldbelake(3)		
            A0CE_PathBetweenLakeHyliaandIceCave_PostAga_ShouldBeLake4 = 0x0CE,	//check,shouldbelake(4)		
            A0CF_PathBetweenLakeHyliaandIceCave_PostAga = 0x0CF,

            //DarkWorld(Post-Aga?)					
            A0D0_SkullWoods_DW_PostAga = 0x0D0,
            A0D1_LumberJackHouse_DW_PostAga = 0x0D1,	//doublecheck,thisshouldbeSkullWoods....		
            A0D2_LumberJackHouse_2_DW_PostAga = 0x0D2,
            A0D3_WestDeathMountain_DW_PostAga = 0x0D3,
            A0D4_EastDeathMountain_DW_PostAga = 0x0D4,	//doublecheck,thisshouldbeWestDM....		
            A0D5_EastDeathMountain_2_DW_PostAga = 0x0D5,	//doublecheck,thisshouldbeEast1		
            A0D6_Unknown_0xD6_PostAga = 0x0D6,	//doublecheck,thisshouldbeEast_2		
            A0D7_TurtleRock_PostAga = 0x0D7,
            A0D8_LostWoods_3_DW_PostAga = 0x0D8,
            A0D9_LostWoods_4_DW_PostAga = 0x0D9,
            A0DA_BumperCaveEntrance_DW_PostAga = 0x0DA,
            A0DB_WestDeathMountain_3_DW_PostAga = 0x0DB,
            A0DC_WestDeathMountain_4_DW_PostAga = 0x0DC,
            A0DD_EastDeathMountain_3_DW_PostAga = 0x0DD,
            A0DE_EastDeathMountain_4_DW_PostAga = 0x0DE,
            A0DF_Catfish_DW_PostAga = 0x0DF,
            A0E0_PathBetweenVillageofOutcastsandSkullWoods_DW_PostAga = 0x0E0,
            A0E1_VillageofOutcastsFortuneTeller_DW_PostAga = 0x0E1,
            A0E2_PondBetweenVillageofOutcastsFortuneTellerandSanctuary_DW_PostAga = 0x0E2,
            A0E3_Sanctuary_DW_PostAga = 0x0E3,
            A0E4_Graveyard_DW_PostAga = 0x0E4,
            A0E5_RiverBetweenGraveyardandWitchsHut_DW_PostAga = 0x0E5,
            A0E6_WitchsHut_DW_PostAga = 0x0E6,
            A0E7_EastofWitchsHut_DW_PostAga = 0x0E7,
            A0E8_VillageofOutcasts_DW_PostAga = 0x0E8,
            A0E9_VillageofOutcasts_2_DW_PostAga = 0x0E9,
            A0EA_ForestBetweenVillageofOutcastsandPyramid_DW_PostAga = 0x0EA,
            A0EB_Pyramid_DW_PostAga = 0x0EB,
            A0EC_Pyramid_2_DW_PostAga = 0x0EC,
            A0ED_BrokenBridgeBetweenGraveyardandWitchsHut_DW_PostAga = 0x0ED,
            A0EE_PalaceofDarkness_DW_PostAga = 0x0EE,
            A0EF_PalaceofDarkness_2_DW_PostAga = 0x0EF,
            A0F0_VillageofOutcasts_3_DW_PostAga = 0x0F0,
            A0F1_VillageofOutcasts_4_DW_PostAga = 0x0F1,
            A0F2_Smithy_DW_PostAga = 0x0F2,
            A0F3_Pyramid_3_DW_PostAga = 0x0F3,
            A0F4_Pyramid_4_DW_PostAga = 0x0F4,
            A0F5_PathBetweenPyramidandPalaceofDarkness_top_DW_PostAga = 0x0F5,
            A0F6_PalaceofDarkness_3_DW_PostAga = 0x0F6,
            A0F7_PalaceofDarkness_4_DW_PostAga = 0x0F7,
            A0F8_DiggingGame_DW_PostAga = 0x0F8,
            A0F9_VillageofOutcastsFrogSmith_DW_PostAga = 0x0F9,
            A0FA_HauntedGrove_DW_PostAga = 0x0FA,
            A0FB_ForestBetweenHauntedGroveandLinksHouse_DW_PostAga = 0x0FB,
            A0FC_BombShop_LinksHouse_DW_PostAga = 0x0FC,
            A0FD_PathBetweenPyramidandPalaceofDarkness_bottom_DW_PostAga = 0x0FD,
            A0FE_CavesSouthofPalaceofDarkness_left_DW_PostAga = 0x0FE,
            A0FF_CavesSouthofPalaceofDarkness_right_DW_PostAga = 0x0FF,
            A100_MiseryMire_DW_PostAga = 0x100,
            A101_SouthofHauntedGrove_DW_PostAga = 0x101,
            A102_SouthofHauntedGrove_DW_Duplicate_PostAga = 0x102,
            A103_NorthWesternGreatSwamp_DW_PostAga = 0x103,
            A104_NorthEasternGreatSwamp_DW_PostAga = 0x104,
            A105_LakeHylia_DW_PostAga = 0x105,
            A106_IceCave_DW_PostAga = 0x106,
            A107_IceCave_DW_PostAga_2 = 0x107,
            A108_MiseryMire_3_DW_PostAga = 0x108,
            A109_MiseryMire_4_DW_PostAga = 0x109,
            A10A_PathBetweenMiseryMireandGreatSwamp_DW_PostAga = 0x10A,
            A10B_SouthWesternGreatSwamp_DW_PostAga = 0x10B,
            A10C_SouthEasternGreatSwamp_DW_PostAga = 0x10C,
            A10D_LakeHylia_3_DW_PostAga = 0x10D,
            A10E_LakeHylia_4_DW_PostAga = 0x10E,
            A10F_PathBetweenLakeHyliaandIceCave_DW_PostAga = 0x10F,
            //theseseemtobepointingtothesamespritedataaspre-aga(sameaddresses)					
            A110_MasterSwordGlade_UnderBridge_PostAga = 0x110,
            A111_ZorasDomain_PostAga = 0x111;

        public static readonly int[] DoNotRandomizeAreas =
        {
            A018_KakarikoVillage,
            A019_KakarikoVillage_2,
            A020_KakarikoVillage_3,
            A021_KakarikoVillage_4,
            A028_KakarikoVillageMazeRace,
            A02A_HauntedGrove,
            A068_DiggingGame_DW,
            A06A_HauntedGrove_DW,
            A080_MasterSwordGlade_UnderBridge,
            A081_ZorasDomain,
            A082_Unknown_0x82, A083_Unknown_0x83, A084_Unknown_0x84, A085_Unknown_0x85, A086_Unknown_0x86, A087_Unknown_0x87, A088_Unknown_0x88, A089_Unknown_0x89,
            A08A_Unknown_0x8A, A08B_Unknown_0x8B, A08C_Unknown_0x8C, A08D_Unknown_0x8D, A08E_Unknown_0x8E, A08F_Unknown_0x8F,
            A092_LumberJackHouse_PostAga,
            A0A8_KakarikoVillage_PostAga,
            A0A9_KakarikoVillage_2_PostAga,
            A0B0_KakarikoVillage_3_PostAga,
            A0B1_KakarikoVillage_4_PostAga,
            A0B8_KakarikoVillageMazeRace_PostAga,
            A0BA_HauntedGrove_PostAga,
            A0F8_DiggingGame_DW_PostAga,
            A0FA_HauntedGrove_DW_PostAga,
            A110_MasterSwordGlade_UnderBridge_PostAga,
            A111_ZorasDomain_PostAga,
            0x112, 0x113, 0x114, 0x115, 0x116, 0x117, 0x119, 0x120
        };
    }
}
