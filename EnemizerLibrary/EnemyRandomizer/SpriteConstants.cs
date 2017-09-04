﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnemizerLibrary
{
    public static class SpriteConstants
    {
        /*
         * $06B44C
         * Byte formatted thus: i s phhhhh
         * s - 'Statis'. If set, indicates that the sprite should not be considered as "alive" in routines that try to check that property. 
         * Functionally, the sprites might not actually be considered to be in statis though. 
         * Example: Bubbles (aka Fire Faeries) are not considered alive for the purposes of puzzles, 
         * because it's not expected that you always have the resources to kill them. Thus, they always have this bit set.
         */
        public static readonly byte StatisMask = 0x40; // 0100 0000
        public static readonly byte OverlordRemoveMask = 0x1F; // 0001 1111

        public static string GetSpriteName(int spriteId)
        {
            string spriteName;

            if (spriteNames.TryGetValue(spriteId, out spriteName))
            {
                return spriteName;
            }

            return null;
        }
        static Dictionary<int, string> spriteNames = new Dictionary<int, string>()
        {
            { 0x00, "Raven" },
            { 0x01, "Vulture" },
            { 0x02, "Flying Stalfos Head" },
            { 0x03, "Empty" },
            { 0x04, "Pull Switch (Good)" },
            { 0x05, "Pull Switch (Unused)" },
            { 0x06, "Pull Switch (Trap)" },
            { 0x07, "Pull Switch (Unused)" },
            { 0x08, "Octorok (One Way)" },
            { 0x09, "Moldorm (Boss)" },
            { 0x0A, "Octorok (Four Way)" },
            { 0x0B, "Chicken" },
            { 0x0C, "Octorok (?)" },
            { 0x0D, "Buzzblob" },
            { 0x0E, "Snapdragon" },
            { 0x0F, "Octoballoon" },
            { 0x10, "Octoballoon Hatchlings" },
            { 0x11, "Hinox" },
            { 0x12, "Moblin" },
            { 0x13, "Mini Helmasaur" },
            { 0x14, "Gargoyle's Domain Gate" },
            { 0x15, "Antifairy" },
            { 0x16, "Sahasrahla / Aginah" },
            { 0x17, "Bush Hoarder" },
            { 0x18, "Mini Moldorm" },
            { 0x19, "Poe" },
            { 0x1A, "Dwarves" },
            { 0x1B, "Arrow in wall?" },
            { 0x1C, "Statue" },
            { 0x1D, "Weathervane" },
            { 0x1E, "Crystal Switch" },
            { 0x1F, "Bug-Catching Kid" },
            { 0x20, "Sluggula" },
            { 0x21, "Push Switch" },
            { 0x22, "Ropa" },
            { 0x23, "Red Bari" },
            { 0x24, "Blue Bari" },
            { 0x25, "Talking Tree" },
            { 0x26, "Hardhat Beetle" },
            { 0x27, "Deadrock" },
            { 0x28, "Storytellers" },
            { 0x29, "Blind Hideout attendant" },
            { 0x2A, "Sweeping Lady" },
            { 0x2B, "Multipurpose Sprite" },
            { 0x2C, "Lumberjacks" },
            { 0x2D, "Telepathic stones? (No idea what this actually is, likely unused)" },
            { 0x2E, "Flute Boy's Notes" },
            { 0x2F, "Race HP NPCs" },
            { 0x30, "Person?" },
            { 0x31, "Fortune Teller" },
            { 0x32, "Angry Brothers" },
            { 0x33, "Pull For Rupees Sprite" },
            { 0x34, "Scared Girl 2" },
            { 0x35, "Innkeeper" },
            { 0x36, "Witch" },
            { 0x37, "Waterfall" },
            { 0x38, "Arrow Target (Eye Statue in PoD)" },
            { 0x39, "Average Middle-Aged Man" },
            { 0x3A, "Half Magic Bat" },
            { 0x3B, "Dash Item" },
            { 0x3C, "Village Kid" },
            { 0x3D, "Signs? Chicken lady also showed up / Scared ladies outside houses." },
            { 0x3E, "Rock Hoarder" },
            { 0x3F, "Tutorial Soldier" },
            { 0x40, "Lightning Lock" },
            { 0x41, "Blue Sword Soldier / Used by guards to detect player" },
            { 0x42, "Green Sword Soldier" },
            { 0x43, "Red Spear Soldier" },
            { 0x44, "Assault Sword Soldier" },
            { 0x45, "Green Spear Soldier" },
            { 0x46, "Blue Archer" },
            { 0x47, "Green Archer" },
            { 0x48, "Red Javelin Soldier" },
            { 0x49, "Red Javelin Soldier 2" },
            { 0x4A, "Red Bomb Soldiers" },
            { 0x4B, "Green Soldier Recruits" },
            { 0x4C, "Geldman" },
            { 0x4D, "Rabbit" },
            { 0x4E, "Popo" },
            { 0x4F, "Popo 2" },
            { 0x50, "Cannon Balls" },
            { 0x51, "Armos" },
            { 0x52, "Giant Zora" },
            { 0x53, "Armos Knights (Boss)" },
            { 0x54, "Lanmolas (Boss)" },
            { 0x55, "Fireball Zora" },
            { 0x56, "Walking Zora" },
            { 0x57, "Desert Palace Barriers" },
            { 0x58, "Crab" },
            { 0x59, "Bird" },
            { 0x5A, "Squirrel" },
            { 0x5B, "Spark (Left to Right)" },
            { 0x5C, "Spark (Right to Left)" },
            { 0x5D, "Roller (vertical moving)" },
            { 0x5E, "Roller (vertical moving)" },
            { 0x5F, "Roller" },
            { 0x60, "Roller (horizontal moving)" },
            { 0x61, "Beamos" },
            { 0x62, "Master Sword" },
            { 0x63, "Devalant (Non-shooter)" },
            { 0x64, "Devalant (Shooter)" },
            { 0x65, "Shooting Gallery Proprietor" },
            { 0x66, "Moving Cannon Ball Shooters (Right)" },
            { 0x67, "Moving Cannon Ball Shooters (Left)" },
            { 0x68, "Moving Cannon Ball Shooters (Down)" },
            { 0x69, "Moving Cannon Ball Shooters (Up)" },
            { 0x6A, "Ball N' Chain Trooper" },
            { 0x6B, "Cannon Soldier" },
            { 0x6C, "Mirror Portal" },
            { 0x6D, "Rat" },
            { 0x6E, "Rope" },
            { 0x6F, "Keese" },
            { 0x70, "Helmasaur King Fireball" },
            { 0x71, "Leever" },
            { 0x72, "Activator for the ponds (where you throw in items)" },
            { 0x73, "Uncle / Priest" },
            { 0x74, "Running Man" },
            { 0x75, "Bottle Salesman" },
            { 0x76, "Princess Zelda" },
            { 0x77, "Antifairy (Alternate)" },
            { 0x78, "Village Elder" },
            { 0x79, "Bee" },
            { 0x7A, "Agahnim" },
            { 0x7B, "Agahnim Energy Ball" },
            { 0x7C, "Hyu (DW Ghosts)" },
            { 0x7D, "Big Spike Trap" },
            { 0x7E, "Guruguru Bar (Clockwise)" },
            { 0x7F, "Guruguru Bar (Counter Clockwise)" },
            { 0x80, "Winder" },
            { 0x81, "Water Tektite (Hover, Water Bug)" },
            { 0x82, "Antifairy Circle" },
            { 0x83, "Green Eyegore/Mimic" },
            { 0x84, "Red Eyegore/Mimic" },
            { 0x85, "Yellow Stalfos" },
            { 0x86, "Kodongos" },
            { 0x87, "Flames" },
            { 0x88, "Mothula (Boss)" },
            { 0x89, "Mothula's Beam" },
            { 0x8A, "Spike Trap" },
            { 0x8B, "Gibdo" },
            { 0x8C, "Arrghus (Boss)" },
            { 0x8D, "Arrghus spawn" },
            { 0x8E, "Terrorpin" },
            { 0x8F, "Slime" },
            { 0x90, "Wallmaster" },
            { 0x91, "Stalfos Knight" },
            { 0x92, "Helmasaur King" },
            { 0x93, "Bumper" },
            { 0x94, "Swimmers" },
            { 0x95, "Eye Laser (Right)" },
            { 0x96, "Eye Laser (Left)" },
            { 0x97, "Eye Laser (Down)" },
            { 0x98, "Eye Laser (Up)" },
            { 0x99, "Pengator" },
            { 0x9A, "Kyameron" },
            { 0x9B, "Wizzrobe" },
            { 0x9C, "Tadpoles (Pirogusu)" },
            { 0x9D, "Tadpoles (Pirogusu)" },
            { 0x9E, "Ostrich (Haunted Grove)" },
            { 0x9F, "Flute" },
            { 0xA0, "Birds (Haunted Grove)" },
            { 0xA1, "Freezor" },
            { 0xA2, "Kholdstare (Boss)" },
            { 0xA3, "Kholdstare's Shell" },
            { 0xA4, "Falling Ice" },
            { 0xA5, "Zazak Fireball" },
            { 0xA6, "Red Zazak" },
            { 0xA7, "Stalfos" },
            { 0xA8, "Bomber Flying Creatures from Darkworld" },
            { 0xA9, "Bomber Flying Creatures from Darkworld" },
            { 0xAA, "Pikit" },
            { 0xAB, "Maiden" },
            { 0xAC, "Apple" },
            { 0xAD, "Lost Old Man" },
            { 0xAE, "Down Pipe" },
            { 0xAF, "Up Pipe" },
            { 0xB0, "Right Pip" },
            { 0xB1, "Left Pipe" },
            { 0xB2, "Good bee again?" },
            { 0xB3, "Hylian Inscription" },
            { 0xB4, "Thief's chest (not the one that follows you, the one that you grab from the DW smithy house)" },
            { 0xB5, "Bomb Salesman" },
            { 0xB6, "Kiki" },
            { 0xB7, "Maiden following you in Blind Dungeon" },
            { 0xB8, "Monologue Testing Sprite" },
            { 0xB9, "Feuding Friends on Death Mountain" },
            { 0xBA, "Whirlpool" },
            { 0xBB, "Salesman / chestgame guy / 300 rupee giver guy / Chest game thief" },
            { 0xBC, "Drunk in the inn" },
            { 0xBD, "Vitreous (Large Eyeball)" },
            { 0xBE, "Vitreous (Small Eyeball)" },
            { 0xBF, "Vitreous' Lightning" },
            { 0xC0, "Monster in Lake of Ill Omen / Quake Medallion" },
            { 0xC1, "Agahnim teleporting Zelda to dark world" },
            { 0xC2, "Boulders" },
            { 0xC3, "Gibo" },
            { 0xC4, "Thief" },
            { 0xC5, "Medusa" },
            { 0xC6, "Four Way Fireball Spitters (spit when you use your sword)" },
            { 0xC7, "Hokku-Bokku" },
            { 0xC8, "Big Fairy who heals you" },
            { 0xC9, "Tektite" },
            { 0xCA, "Chain Chomp" },
            { 0xCB, "Trinexx" },
            { 0xCC, "Another part of trinexx" },
            { 0xCD, "Yet another part of trinexx" },
            { 0xCE, "Blind The Thief (Boss)" },
            { 0xCF, "Swamola" },
            { 0xD0, "Lynel" },
            { 0xD1, "Bunny Beam" },
            { 0xD2, "Flopping fish" },
            { 0xD3, "Stal" },
            { 0xD4, "Landmine" },
            { 0xD5, "Digging Game Proprietor" },
            { 0xD6, "Ganon" },
            { 0xD7, "Copy of Ganon, except invincible?" },
            { 0xD8, "Heart" },
            { 0xD9, "Green Rupee" },
            { 0xDA, "Blue Rupee" },
            { 0xDB, "Red Rupee" },
            { 0xDC, "Bomb Refill (1)" },
            { 0xDD, "Bomb Refill (4)" },
            { 0xDE, "Bomb Refill (8)" },
            { 0xDF, "Small Magic Refill" },
            { 0xE0, "Full Magic Refill" },
            { 0xE1, "Arrow Refill (5)" },
            { 0xE2, "Arrow Refill (10)" },
            { 0xE3, "Fairy" },
            { 0xE4, "Key" },
            { 0xE5, "Big Key" },
            { 0xE6, "Shield" },
            { 0xE7, "Mushroom" },
            { 0xE8, "Fake Master Sword" },
            { 0xE9, "Magic Shop dude / His items, including the magic powder" },
            { 0xEA, "Heart Container" },
            { 0xEB, "Heart Piece" },
            { 0xEC, "Bushes" },
            { 0xED, "Cane Of Somaria Platform" },
            { 0xEE, "Mantle" },
            { 0xEF, "Cane of Somaria Platform (Unused)" },
            { 0xF0, "Cane of Somaria Platform (Unused)" },
            { 0xF1, "Cane of Somaria Platform (Unused)" },
            { 0xF2, "Medallion Tablet" },
            // Overlords (add 0x100 to the sprite id)
            { 0x102, "Canon Balls (EP 4 Wall Canonballs)" },
            { 0x103, "Canon Balls (EP Entry)" },
            { 0x105, "Stalfos Head Trap" },
            { 0x106, "'Bomb drop' (Ropes) trap" },
            { 0x107, "Moving Floor" },
            { 0x108, "'Transformer' bunny beam" },
            { 0x109, "Wallmaster" },
            { 0x10A, "Floor Drop (Square)" },
            { 0x10B, "Floor Drop (Path?)" },
            { 0x110, "'Right Evil' Pirogusu spawner in Swamp (9C/9D is Pirogusu)" },
            { 0x111, "'Left Evil' Pirogusu spawner in Swamp (9C/9D is Pirogusu)" },
            { 0x112, "'Down Evil' Pirogusu spawner in Swamp (9C/9D is Pirogusu)" },
            { 0x113, "'Up Evil' Pirogusu spawner in Swamp (9C/9D is Pirogusu)" },
            { 0x114, "Flying Floor Tile Trap" },
            { 0x115, "Wizzrobe Spawner" },
            { 0x116, "Black spawn (Zoro) from bomb hole" },
            { 0x117, "4 Skull Trap in PoD (Under pot)" },
            { 0x118, "Stalfos Spawn Trap (Busted on in EP)" },
            { 0x119, "Armos Knights trigger?" },
            { 0x11A, "Bomb drop (Bombs) trap" },
            { 0x141, "Soldier Alerter?? (Blue)" },
            { 0x142, "Soldier Alerter?? (Green)" },
        };

        public static readonly byte
            RavenSprite = 0x00,
            VultureSprite = 0x01,
            FlyingStalfosHeadSprite = 0x02,
            EmptySprite = 0x03,
            PullSwitch_GoodSprite = 0x04,
            PullSwitch_Unused1Sprite = 0x05,
            PullSwitch_TrapSprite = 0x06,
            PullSwitch_Unused2Sprite = 0x07,
            Octorok_OneWaySprite = 0x08,
            MoldormSprite = 0x09,
            Octorok_FourWaySprite = 0x0A,
            ChickenSprite = 0x0B,
            Octorok_MaybeSprite = 0x0C,
            BuzzblobSprite = 0x0D,
            SnapdragonSprite = 0x0E,
            OctoballoonSprite = 0x0F,
            OctoballoonHatchlingsSprite = 0x10,
            HinoxSprite = 0x11,
            MoblinSprite = 0x12,
            MiniHelmasaurSprite = 0x13,
            GargoylesDomainGateSprite = 0x14,
            AntifairySprite = 0x15,
            SahasrahlaAginahSprite = 0x16,
            BushHoarderSprite = 0x17,
            MiniMoldormSprite = 0x18,
            PoeSprite = 0x19,
            DwarvesSprite = 0x1A,
            ArrowInWall_MaybeSprite = 0x1B,
            StatueSprite = 0x1C,
            WeathervaneSprite = 0x1D,
            CrystalSwitchSprite = 0x1E,
            BugCatchingKidSprite = 0x1F,
            SluggulaSprite = 0x20,
            PushSwitchSprite = 0x21,
            RopaSprite = 0x22,
            RedBariSprite = 0x23,
            BlueBariSprite = 0x24,
            TalkingTreeSprite = 0x25,
            HardhatBeetleSprite = 0x26,
            DeadrockSprite = 0x27,
            StorytellersSprite = 0x28,
            BlindHideoutAttendantSprite = 0x29,
            SweepingLadySprite = 0x2A,
            MultipurposeSpriteSprite = 0x2B,
            LumberjacksSprite = 0x2C,
            TelepathicStones_NoIdeaWhatThisActuallyIsLikelyUnusedSprite = 0x2D,
            FluteBoysNotesSprite = 0x2E,
            RaceHPNPCsSprite = 0x2F,
            Person_MaybeSprite = 0x30,
            FortuneTellerSprite = 0x31,
            AngryBrothersSprite = 0x32,
            PullForRupeesSpriteSprite = 0x33,
            ScaredGirl2Sprite = 0x34,
            InnkeeperSprite = 0x35,
            WitchSprite = 0x36,
            WaterfallSprite = 0x37,
            ArrowTargetSprite = 0x38,
            AverageMiddleAgedManSprite = 0x39,
            HalfMagicBatSprite = 0x3A,
            DashItemSprite = 0x3B,
            VillageKidSprite = 0x3C,
            Signs_ChickenLadyAlsoShowedUp_ScaredLadiesOutsideHousesSprite = 0x3D,
            RockHoarderSprite = 0x3E,
            TutorialSoldierSprite = 0x3F,
            LightningLockSprite = 0x40,
            BlueSwordSoldier_DetectPlayerSprite = 0x41,
            GreenSwordSoldierSprite = 0x42,
            RedSpearSoldierSprite = 0x43,
            AssaultSwordSoldierSprite = 0x44,
            GreenSpearSoldierSprite = 0x45,
            BlueArcherSprite = 0x46,
            GreenArcherSprite = 0x47,
            RedJavelinSoldierSprite = 0x48,
            RedJavelinSoldier2Sprite = 0x49,
            RedBombSoldiersSprite = 0x4A,
            GreenSoldierRecruits_HMKnightSprite = 0x4B,
            GeldmanSprite = 0x4C,
            RabbitSprite = 0x4D,
            PopoSprite = 0x4E,
            Popo2Sprite = 0x4F,
            CannonBallsSprite = 0x50,
            ArmosSprite = 0x51,
            GiantZoraSprite = 0x52,
            ArmosKnightsSprite = 0x53,
            LanmolasSprite = 0x54,
            FireballZoraSprite = 0x55,
            WalkingZoraSprite = 0x56,
            DesertPalaceBarriersSprite = 0x57,
            CrabSprite = 0x58,
            BirdSprite = 0x59,
            SquirrelSprite = 0x5A,
            Spark_LeftToRightSprite = 0x5B,
            Spark_RightToLeftSprite = 0x5C,
            Roller_VerticalMovingSprite = 0x5D,
            Roller_VerticalMoving2Sprite = 0x5E,
            RollerSprite = 0x5F,
            Roller_HorizontalMovingSprite = 0x60,
            BeamosSprite = 0x61,
            MasterSwordSprite = 0x62,
            Devalant_NonShooterSprite = 0x63,
            Devalant_ShooterSprite = 0x64,
            ShootingGalleryProprietorSprite = 0x65,
            MovingCannonBallShooters_RightSprite = 0x66,
            MovingCannonBallShooters_LeftSprite = 0x67,
            MovingCannonBallShooters_DownSprite = 0x68,
            MovingCannonBallShooters_UpSprite = 0x69,
            BallNChainTrooperSprite = 0x6A,
            CannonSoldierSprite = 0x6B,
            MirrorPortalSprite = 0x6C,
            RatSprite = 0x6D,
            RopeSprite = 0x6E,
            KeeseSprite = 0x6F,
            HelmasaurKingFireballSprite = 0x70,
            LeeverSprite = 0x71,
            ActivatoForThePonds_WhereYouThrowInItemsSprite = 0x72,
            UnclePriestSprite = 0x73,
            RunningManSprite = 0x74,
            BottleSalesmanSprite = 0x75,
            PrincessZeldaSprite = 0x76,
            Antifairy_AlternateSprite = 0x77,
            VillageElderSprite = 0x78,
            BeeSprite = 0x79,
            AgahnimSprite = 0x7A,
            AgahnimEnergyBallSprite = 0x7B,
            HyuSprite = 0x7C,
            BigSpikeTrapSprite = 0x7D,
            GuruguruBar_ClockwiseSprite = 0x7E,
            GuruguruBar_CounterClockwiseSprite = 0x7F,
            WinderSprite = 0x80,
            WaterTektiteSprite = 0x81,
            AntifairyCircleSprite = 0x82,
            GreenEyegoreSprite = 0x83,
            RedEyegoreSprite = 0x84,
            YellowStalfosSprite = 0x85,
            KodongosSprite = 0x86,
            FlamesSprite = 0x87,
            MothulaSprite = 0x88,
            MothulasBeamSprite = 0x89,
            SpikeTrapSprite = 0x8A,
            GibdoSprite = 0x8B,
            ArrghusSprite = 0x8C,
            ArrghusSpawnSprite = 0x8D,
            TerrorpinSprite = 0x8E,
            SlimeSprite = 0x8F,
            WallmasterSprite = 0x90,
            StalfosKnightSprite = 0x91,
            HelmasaurKingSprite = 0x92,
            BumperSprite = 0x93,
            SwimmersSprite = 0x94,
            EyeLaser_RightSprite = 0x95,
            EyeLaser_LeftSprite = 0x96,
            EyeLaser_DownSprite = 0x97,
            EyeLaser_UpSprite = 0x98,
            PengatorSprite = 0x99,
            KyameronSprite = 0x9A,
            WizzrobeSprite = 0x9B,
            TadpolesSprite = 0x9C,
            Tadpoles2Sprite = 0x9D,
            Ostrich_HauntedGroveSprite = 0x9E,
            FluteSprite = 0x9F,
            Birds_HauntedGroveSprite = 0xA0,
            FreezorSprite = 0xA1,
            KholdstareSprite = 0xA2,
            KholdstaresShellSprite = 0xA3,
            FallingIceSprite = 0xA4,
            ZazakFireballSprite = 0xA5,
            RedZazakSprite = 0xA6,
            StalfosSprite = 0xA7,
            BomberFlyingCreaturesFromDarkworldSprite = 0xA8,
            BomberFlyingCreaturesFromDarkworld2Sprite = 0xA9,
            PikitSprite = 0xAA,
            MaidenSprite = 0xAB,
            AppleSprite = 0xAC,
            LostOldManSprite = 0xAD,
            DownPipeSprite = 0xAE,
            UpPipeSprite = 0xAF,
            RightPipeSprite = 0xB0,
            LeftPipeSprite = 0xB1,
            GoodBee_AgainMaybeSprite = 0xB2,
            HylianInscriptionSprite = 0xB3,
            ThiefsChestSprite = 0xB4,
            BombSalesmanSprite = 0xB5,
            KikiSprite = 0xB6,
            MaidenInBlindDungeonSprite = 0xB7,
            MonologueTestingSpriteSprite = 0xB8,
            FeudingFriendsOnDeathMountainSprite = 0xB9,
            WhirlpoolSprite = 0xBA,
            SalesmanChestgameGuy300RupeeGiverGuyChestGameThiefSprite = 0xBB,
            DrunkInTheInnSprite = 0xBC,
            Vitreous_LargeEyeballSprite = 0xBD,
            Vitreous_SmallEyeballSprite = 0xBE,
            VitreousLightningSprite = 0xBF,
            CatFish_QuakeMedallionSprite = 0xC0,
            AgahnimTeleportingZeldaToDarkworldSprite = 0xC1,
            BouldersSprite = 0xC2,
            GiboSprite = 0xC3,
            ThiefSprite = 0xC4,
            MedusaSprite = 0xC5,
            FourWayFireballSpittersSprite = 0xC6,
            HokkuBokkuSprite = 0xC7,
            BigFairyWhoHealsYouSprite = 0xC8,
            TektiteSprite = 0xC9,
            ChainChompSprite = 0xCA,
            TrinexxSprite = 0xCB,
            AnotherPartOfTrinexxSprite = 0xCC,
            YetAnotherPartOfTrinexxSprite = 0xCD,
            BlindTheThiefSprite = 0xCE,
            SwamolaSprite = 0xCF,
            LynelSprite = 0xD0,
            BunnyBeamSprite = 0xD1,
            FloppingFishSprite = 0xD2,
            StalSprite = 0xD3,
            LandmineSprite = 0xD4,
            DiggingGameProprietorSprite = 0xD5,
            GanonSprite = 0xD6,
            CopyOfGanon_ExceptInvincibleSprite = 0xD7,
            HeartSprite = 0xD8,
            GreenRupeeSprite = 0xD9,
            BlueRupeeSprite = 0xDA,
            RedRupeeSprite = 0xDB,
            BombRefill1Sprite = 0xDC,
            BombRefill4Sprite = 0xDD,
            BombRefill8Sprite = 0xDE,
            SmallMagicRefillSprite = 0xDF,
            FullMagicRefillSprite = 0xE0,
            ArrowRefill5Sprite = 0xE1,
            ArrowRefill10Sprite = 0xE2,
            FairySprite = 0xE3,
            KeySprite = 0xE4,
            BigKeySprite = 0xE5,
            ShieldSprite = 0xE6,
            MushroomSprite = 0xE7,
            FakeMasterSwordSprite = 0xE8,
            MagicShopDude_HisItemsIncludingTheMagicPowderSprite = 0xE9,
            HeartContainerSprite = 0xEA,
            HeartPieceSprite = 0xEB,
            BushesSprite = 0xEC,
            CaneOfSomariaPlatformSprite = 0xED,
            MantleSprite = 0xEE,
            CaneOfSomariaPlatform_Unused1Sprite = 0xEF,
            CaneOfSomariaPlatform_Unused2Sprite = 0xF0,
            CaneOfSomariaPlatform_Unused3Sprite = 0xF1,
            MedallionTabletSprite = 0xF2;

        //all the absorbable sprites fairy, bombs, rupees, arrows, ect, that can be used in any rooms without any specific set selected
        public static readonly byte[] absorbable_sprites =
        {
            SpriteConstants.HeartSprite,
            SpriteConstants.GreenRupeeSprite,
            SpriteConstants.BlueRupeeSprite,
            SpriteConstants.RedRupeeSprite,
            SpriteConstants.BombRefill1Sprite,
            SpriteConstants.BombRefill4Sprite,
            SpriteConstants.BombRefill8Sprite,
            SpriteConstants.SmallMagicRefillSprite,
            SpriteConstants.FullMagicRefillSprite,
            SpriteConstants.ArrowRefill5Sprite,
            SpriteConstants.ArrowRefill10Sprite,
            SpriteConstants.FairySprite,
            SpriteConstants.KeySprite // TODO: do we want this in the pool?
        };


        //For Keys
        public static readonly byte[] NonKillable =
        {
            SpriteConstants.ActivatoForThePonds_WhereYouThrowInItemsSprite,
            SpriteConstants.AngryBrothersSprite,
            SpriteConstants.Antifairy_AlternateSprite,
            SpriteConstants.AntifairyCircleSprite,
            SpriteConstants.AntifairySprite,
            SpriteConstants.AppleSprite,
            SpriteConstants.ArrowRefill10Sprite,
            SpriteConstants.ArrowRefill5Sprite,
            SpriteConstants.ArrowTargetSprite,
            SpriteConstants.BeamosSprite,
            SpriteConstants.BigKeySprite,
            SpriteConstants.BigSpikeTrapSprite,
            SpriteConstants.Birds_HauntedGroveSprite,
            SpriteConstants.BlindHideoutAttendantSprite,
            SpriteConstants.BlueRupeeSprite,
            SpriteConstants.BomberFlyingCreaturesFromDarkworld2Sprite,
            SpriteConstants.BomberFlyingCreaturesFromDarkworldSprite,
            SpriteConstants.BombRefill1Sprite,
            SpriteConstants.BombRefill4Sprite,
            SpriteConstants.BombRefill8Sprite,
            SpriteConstants.BouldersSprite,
            SpriteConstants.BumperSprite,
            SpriteConstants.BunnyBeamSprite,
            SpriteConstants.ChainChompSprite,
            SpriteConstants.ChickenSprite,
            SpriteConstants.CrystalSwitchSprite,
            SpriteConstants.DeadrockSprite,
            SpriteConstants.DesertPalaceBarriersSprite,
            SpriteConstants.DownPipeSprite,
            SpriteConstants.DwarvesSprite,
            SpriteConstants.EmptySprite,
            SpriteConstants.EyeLaser_DownSprite,
            SpriteConstants.EyeLaser_LeftSprite,
            SpriteConstants.EyeLaser_RightSprite,
            SpriteConstants.EyeLaser_UpSprite,
            SpriteConstants.FairySprite,
            SpriteConstants.FallingIceSprite,
            SpriteConstants.FluteSprite,
            SpriteConstants.FlyingStalfosHeadSprite,
            SpriteConstants.FortuneTellerSprite,
            SpriteConstants.FourWayFireballSpittersSprite,
            SpriteConstants.FreezorSprite,
            SpriteConstants.FullMagicRefillSprite,
            SpriteConstants.GargoylesDomainGateSprite,
            SpriteConstants.GoodBee_AgainMaybeSprite,
            SpriteConstants.GreenRupeeSprite,
            SpriteConstants.GuruguruBar_ClockwiseSprite,
            SpriteConstants.GuruguruBar_CounterClockwiseSprite,
            SpriteConstants.HardhatBeetleSprite,
            SpriteConstants.HeartSprite,
            SpriteConstants.HyuSprite,
            SpriteConstants.InnkeeperSprite,
            SpriteConstants.KeeseSprite,
            SpriteConstants.KeySprite,
            SpriteConstants.KyameronSprite,
            SpriteConstants.LeftPipeSprite,
            SpriteConstants.LightningLockSprite,
            SpriteConstants.LostOldManSprite,
            SpriteConstants.LynelSprite,
            SpriteConstants.MaidenInBlindDungeonSprite,
            SpriteConstants.MedusaSprite,
            SpriteConstants.MonologueTestingSpriteSprite,
            SpriteConstants.MovingCannonBallShooters_DownSprite,
            SpriteConstants.MovingCannonBallShooters_LeftSprite,
            SpriteConstants.MovingCannonBallShooters_RightSprite,
            SpriteConstants.MovingCannonBallShooters_UpSprite,
            SpriteConstants.MushroomSprite,
            SpriteConstants.Ostrich_HauntedGroveSprite,
            SpriteConstants.PikitSprite,
            SpriteConstants.PoeSprite,
            SpriteConstants.PullSwitch_TrapSprite,
            SpriteConstants.PullSwitch_GoodSprite,
            SpriteConstants.PullSwitch_Unused1Sprite,
            SpriteConstants.PullSwitch_Unused2Sprite,
            SpriteConstants.PushSwitchSprite,
            SpriteConstants.RabbitSprite,
            SpriteConstants.RaceHPNPCsSprite,
            SpriteConstants.RavenSprite,
            SpriteConstants.RedBariSprite,
            SpriteConstants.RedEyegoreSprite,
            SpriteConstants.RedRupeeSprite,
            SpriteConstants.RightPipeSprite,
            SpriteConstants.Roller_HorizontalMovingSprite,
            SpriteConstants.Roller_VerticalMoving2Sprite,
            SpriteConstants.Roller_VerticalMovingSprite,
            SpriteConstants.RollerSprite,
            SpriteConstants.SahasrahlaAginahSprite,
            SpriteConstants.ShieldSprite,
            SpriteConstants.SmallMagicRefillSprite,
            SpriteConstants.Spark_LeftToRightSprite,
            SpriteConstants.Spark_RightToLeftSprite,
            SpriteConstants.SpikeTrapSprite,
            SpriteConstants.StalfosKnightSprite,
            SpriteConstants.StatueSprite,
            SpriteConstants.StorytellersSprite,
            SpriteConstants.SweepingLadySprite,
            SpriteConstants.SwimmersSprite,
            SpriteConstants.TerrorpinSprite,
            SpriteConstants.TutorialSoldierSprite,
            SpriteConstants.UpPipeSprite,
            SpriteConstants.VillageKidSprite,
            SpriteConstants.VultureSprite,
            SpriteConstants.WallmasterSprite,
            SpriteConstants.WaterfallSprite,
            SpriteConstants.WaterTektiteSprite,
            SpriteConstants.WinderSprite,
            SpriteConstants.WitchSprite,
            SpriteConstants.YellowStalfosSprite
        };

        /*
         * $06B44C
         * Byte formatted thus: i s phhhhh
         * s - 'Statis'. If set, indicates that the sprite should not be considered as "alive" in routines that try to check that property. 
         * Functionally, the sprites might not actually be considered to be in statis though. 
         * Example: Bubbles (aka Fire Faeries) are not considered alive for the purposes of puzzles, 
         * because it's not expected that you always have the resources to kill them. Thus, they always have this bit set.
         */
        public static readonly byte[] statis_sprites =
        {
            SpriteConstants.ChainChompSprite,
            SpriteConstants.DeadrockSprite,
            SpriteConstants.Roller_VerticalMovingSprite,
            SpriteConstants.Roller_VerticalMoving2Sprite,
            SpriteConstants.RollerSprite,
            SpriteConstants.Roller_HorizontalMovingSprite,
            SpriteConstants.GuruguruBar_ClockwiseSprite,
            SpriteConstants.GuruguruBar_CounterClockwiseSprite
        };

        //Non Killable in shutter doors Rooms
        public static readonly byte[] NonKillable_shutter =
        {
            SpriteConstants.ActivatoForThePonds_WhereYouThrowInItemsSprite,
            SpriteConstants.AngryBrothersSprite,
            SpriteConstants.Antifairy_AlternateSprite,
            SpriteConstants.AntifairyCircleSprite,
            SpriteConstants.ArrowTargetSprite,
            SpriteConstants.Birds_HauntedGroveSprite,
            SpriteConstants.BlindHideoutAttendantSprite,
            SpriteConstants.BouldersSprite,
            SpriteConstants.BumperSprite,
            SpriteConstants.ChickenSprite,
            SpriteConstants.CrystalSwitchSprite,
            SpriteConstants.DeadrockSprite,
            SpriteConstants.DesertPalaceBarriersSprite,
            SpriteConstants.DownPipeSprite,
            SpriteConstants.DwarvesSprite,
            SpriteConstants.EmptySprite,
            SpriteConstants.EyeLaser_DownSprite,
            SpriteConstants.EyeLaser_LeftSprite,
            SpriteConstants.EyeLaser_RightSprite,
            SpriteConstants.EyeLaser_UpSprite,
            SpriteConstants.FluteSprite,
            SpriteConstants.FlyingStalfosHeadSprite,
            SpriteConstants.FortuneTellerSprite,
            SpriteConstants.FourWayFireballSpittersSprite,
            SpriteConstants.FreezorSprite,
            SpriteConstants.GargoylesDomainGateSprite,
            SpriteConstants.GoodBee_AgainMaybeSprite,
            SpriteConstants.HardhatBeetleSprite,
            SpriteConstants.InnkeeperSprite,
            SpriteConstants.KeeseSprite,
            SpriteConstants.KyameronSprite,
            SpriteConstants.LeftPipeSprite,
            SpriteConstants.LightningLockSprite,
            SpriteConstants.LostOldManSprite,
            SpriteConstants.LynelSprite,
            SpriteConstants.MaidenInBlindDungeonSprite,
            SpriteConstants.MedusaSprite,
            SpriteConstants.MonologueTestingSpriteSprite,
            SpriteConstants.MovingCannonBallShooters_DownSprite,
            SpriteConstants.MovingCannonBallShooters_LeftSprite,
            SpriteConstants.MovingCannonBallShooters_RightSprite,
            SpriteConstants.MovingCannonBallShooters_UpSprite,
            SpriteConstants.Ostrich_HauntedGroveSprite,
            SpriteConstants.PoeSprite,
            SpriteConstants.PullSwitch_TrapSprite,
            SpriteConstants.PullSwitch_GoodSprite,
            SpriteConstants.PullSwitch_Unused1Sprite,
            SpriteConstants.PullSwitch_Unused2Sprite,
            SpriteConstants.PushSwitchSprite,
            SpriteConstants.RabbitSprite,
            SpriteConstants.RaceHPNPCsSprite,
            SpriteConstants.RavenSprite,
            SpriteConstants.RedEyegoreSprite,
            SpriteConstants.RightPipeSprite,
            SpriteConstants.SahasrahlaAginahSprite,
            SpriteConstants.SpikeTrapSprite,
            SpriteConstants.StalfosKnightSprite,
            SpriteConstants.StatueSprite,
            SpriteConstants.StorytellersSprite,
            SpriteConstants.SweepingLadySprite,
            SpriteConstants.SwimmersSprite,
            SpriteConstants.TerrorpinSprite,
            SpriteConstants.TutorialSoldierSprite,
            SpriteConstants.UpPipeSprite,
            SpriteConstants.VillageKidSprite,
            SpriteConstants.VultureSprite,
            SpriteConstants.WallmasterSprite,
            SpriteConstants.WaterfallSprite,
            SpriteConstants.WaterTektiteSprite,
            SpriteConstants.WinderSprite,
            SpriteConstants.WitchSprite,
            SpriteConstants.YellowStalfosSprite
        };


        public static readonly byte[] bowSprites = { SpriteConstants.GreenEyegoreSprite, SpriteConstants.RedEyegoreSprite };
        public static readonly byte[] hammerSprites = { SpriteConstants.TerrorpinSprite };

        public static readonly int[] key_sprite = { 0x04DA20, 0x04DA5C, 0x04DB7F, 0x04DD73, 0x04DDC3, 0x04DE07, 0x04E203, 0x04E20B, 0x04E326, 0x04E4F7, 0x04E70C, 0x04E7C8, 0x04E7FA, 0x04E200, 0x04E687, 0x04E991, 0x04E994, 0x04E997, 0x04E99A, 0x04E99D, 0x04E9A0, 0x04E9A3, 0x04E9A6, 0x04E9A9, 0x04E9AC, 0x04E9AF, 0x04E790, 0x04E78D, 0x04E78A };

        //all the sprites "gfx" sheet 
        public static readonly byte[] sprite_subset_0 = { 22, 31, 47, 14 }; //70-72 part of guards we already have 4 guard set don't need more
        public static readonly byte[] sprite_subset_1 = { 44, 30, 32 };//73-13
        public static readonly byte[] sprite_subset_2 = { 12, 18, 23, 24, 28, 46, 34, 35, 39, 40, 38, 41, 36, 37, 42 };//19 trainee guard
        public static readonly byte[] sprite_subset_3 = { 17, 16, 27, 20, 82, 83 };

        public static readonly byte[] NpcSprites = 
        {
            PrincessZeldaSprite,
            UnclePriestSprite
        };
    }
}
