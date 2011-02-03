using Tibia.Addresses;

namespace Tibia
{
    public partial class Version
    {
        public static void SetVersion855()
        {
            BattleList.Start = 0x63D350;
            BattleList.StepCreatures = 0xA8;
            BattleList.MaxCreatures = 250;
            BattleList.End = BattleList.Start + (BattleList.StepCreatures * BattleList.MaxCreatures);

            Client.StartTime = 0x7DDCB8;
            Client.XTeaKey = 0x796DE4;
            Client.SocketStruct = 0x796DB8;
            Client.RecvPointer = 0x5B75DC;
            Client.SendPointer = 0x5B7608;
            Client.FrameRatePointer = 0x79AF9C;
            Client.FrameRateCurrentOffset = 0x60;
            Client.FrameRateLimitOffset = 0x58;
            Client.MultiClient = 0x50B874;
            Client.Status = 0x79A450;
            Client.SafeMode = 0x79720C;
            Client.FollowMode = Client.SafeMode + 4;
            Client.AttackMode = Client.FollowMode + 4;
            Client.ActionState = 0x79A4B0;
            Client.ActionStateFreezer = 0x51CBB4;
            Client.LastMSGText = 0x7DDF28;
            Client.LastMSGAuthor = Client.LastMSGText - 0x28;
            Client.StatusbarText = 0x7DDCD8;
            Client.StatusbarTime = Client.StatusbarText - 4;
            Client.ClickId = 0x79A4F0;
            Client.ClickCount = Client.ClickId + 4;
            Client.ClickZ = Client.ClickId - 0x68;
            Client.SeeId = Client.ClickId + 12;
            Client.SeeCount = Client.SeeId + 4;
            Client.SeeZ = Client.SeeId - 0x68;
            Client.ClickContextMenuItemId = 0x79A4FC;
            Client.ClickContextMenuItemGroundId = 0x79A500;
            Client.ClickContextMenuCreatureId = 0x79A4F8;
            Client.LoginServerStart = 0x791D20;
            Client.StepLoginServer = 112;
            Client.DistancePort = 100;
            Client.MaxLoginServers = 10;
            Client.RSA = 0x5B7610;
            Client.LoginCharList = 0x79A404;
            Client.LoginCharListLength = 0x79A408;
            Client.LoginSelectedChar = 0x79A400;
            Client.GameWindowRectPointer = 0x649784;
            Client.GameWindowBar = 0x7DDCCC;
            Client.DatPointer = 0x796E04;
            Client.EventTriggerPointer = 0x51EC50;
            Client.DialogPointer = 0x64CAEC;
            Client.DialogLeft = 0x14;
            Client.DialogTop = 0x18;
            Client.DialogWidth = 0x1C;
            Client.DialogHeight = 0x20;
            Client.DialogCaption = 0x50;
            Client.LastRcvPacket = 0x792598;
            Client.DecryptCall = 0x45C1B5;
            Client.LoginAccountNum = 0;
            Client.LoginPassword = 0x79A40C;
            Client.LoginAccount = Client.LoginPassword + 32;
            Client.LoginPatch = 0;
            Client.LoginPatch2 = 0;
            Client.LoginPatchOrig = new byte[] { 0xE8, 0x0D, 0x1D, 0x09, 0x00 };
            Client.LoginPatchOrig2 = new byte[] { 0xE8, 0xC8, 0x15, 0x09, 0x00 };
            Client.ParserFunc = 0x45C180;
            Client.GetNextPacketCall = 0x45C1B5;
            Client.RecvStream = 0x796DD4;

            Container.Start = 0x64A238;
            Container.StepContainer = 492;
            Container.StepSlot = 12;
            Container.MaxContainers = 16;
            Container.MaxStack = 100;
            Container.DistanceIsOpen = 0;
            Container.DistanceId = 4;
            Container.DistanceName = 16;
            Container.DistanceVolume = 48;
            Container.DistanceAmount = 56;
            Container.DistanceItemId = 60;
            Container.DistanceItemCount = 64;
            Container.End = Container.Start + (Container.MaxContainers * Container.StepContainer);

            ContextMenus.AddContextMenuPtr = 0x4520F0;
            ContextMenus.OnClickContextMenuPtr = 0x44E700;
            ContextMenus.OnClickContextMenuVf = 0x5BCBD0;
            ContextMenus.AddSetOutfitContextMenu = 0x453022;
            ContextMenus.AddPartyActionContextMenu = 0x45349C;
            ContextMenus.AddCopyNameContextMenu = 0x45354D;
            ContextMenus.AddTradeWithContextMenu = 0x452C99;
            ContextMenus.AddLookContextMenu = 0x452B4F;

            Creature.DistanceId = 0;
            Creature.DistanceType = 3;
            Creature.DistanceName = 4;
            Creature.DistanceX = 36;
            Creature.DistanceY = 40;
            Creature.DistanceZ = 44;
            Creature.DistanceScreenOffsetHoriz = 48;
            Creature.DistanceScreenOffsetVert = 52;
            Creature.DistanceIsWalking = 76;
            Creature.DistanceWalkSpeed = 140;
            Creature.DistanceDirection = 80;
            Creature.DistanceIsVisible = 144;
            Creature.DistanceBlackSquare = 132;
            Creature.DistanceLight = 120;
            Creature.DistanceLightColor = 124;
            Creature.DistanceHPBar = 136;
            Creature.DistanceSkull = 148;
            Creature.DistanceParty = 152;
            Creature.DistanceWarIcon = 160;
            Creature.DistanceIsBlocking = 164;
            Creature.DistanceOutfit = 96;
            Creature.DistanceColorHead = 100;
            Creature.DistanceColorBody = 104;
            Creature.DistanceColorLegs = 108;
            Creature.DistanceColorFeet = 112;
            Creature.DistanceAddon = 116;

            DatItem.StepItems = 0x50;
            DatItem.Width = 0;
            DatItem.Height = 4;
            DatItem.MaxSizeInPixels = 8;
            DatItem.Layers = 12;
            DatItem.PatternX = 16;
            DatItem.PatternY = 20;
            DatItem.PatternDepth = 24;
            DatItem.Phase = 28;
            DatItem.Sprite = 32;
            DatItem.Flags = 36;
            DatItem.CanLookAt = 40;
            DatItem.WalkSpeed = 44;
            DatItem.TextLimit = 48;
            DatItem.LightRadius = 52;
            DatItem.LightColor = 56;
            DatItem.ShiftX = 60;
            DatItem.ShiftY = 64;
            DatItem.WalkHeight = 68;
            DatItem.Automap = 72;
            DatItem.LensHelp = 76;

            DrawItem.DrawItemFunc = 0x4B4CF0;

            DrawSkin.DrawSkinFunc = 0x4B8BE0;

            Hotkey.SendAutomaticallyStart = 0x797408;
            Hotkey.SendAutomaticallyStep = 0x01;
            Hotkey.TextStart = 0x797430;
            Hotkey.TextStep = 0x100;
            Hotkey.ObjectStart = 0x797378;
            Hotkey.ObjectStep = 0x04;
            Hotkey.ObjectUseTypeStart = 0x797258;
            Hotkey.ObjectUseTypeStep = 0x04;
            Hotkey.MaxHotkeys = 36;

            Map.MapPointer = 0x651640;
            Map.StepTile = 168;
            Map.StepTileObject = 12;
            Map.DistanceTileObjectCount = 0;
            Map.DistanceTileObjects = 4;
            Map.DistanceObjectId = 0;
            Map.DistanceObjectData = 4;
            Map.DistanceObjectDataEx = 8;
            Map.MaxTileObjects = 10;
            Map.MaxX = 18;
            Map.MaxY = 14;
            Map.MaxZ = 8;
            Map.MaxTiles = 2016;
            Map.ZAxisDefault = 7;
            Map.NameSpy1 = 0x4F2119;
            Map.NameSpy2 = 0x4F2123;
            Map.NameSpy1Default = 19061;
            Map.NameSpy2Default = 16501;
            Map.LevelSpy1 = 0x4F3FCA;
            Map.LevelSpy2 = 0x4F40CF;
            Map.LevelSpy3 = 0x4F4150;
            Map.LevelSpyPtr = 0x649784;
            Map.LevelSpyAdd1 = 28;
            Map.LevelSpyAdd2 = 0x2A88;
            Map.LevelSpyDefault = new byte[] { 0x89, 0x86, 0x88, 0x2A, 0x00, 0x00 };
            Map.FullLightNop = 0x4EA8B9;
            Map.FullLightAdr = 0x4EA8BC;
            Map.FullLightNopDefault = new byte[] { 0x7E, 0x05 };
            Map.FullLightNopEdited = new byte[] { 0x90, 0x90 };
            Map.FullLightAdrDefault = 0x80;
            Map.FullLightAdrEdited = 0xFF;

            Player.Experience = 0x63D2E4;
            Player.Flags = Player.Experience - 108;
            Player.Id = Player.Experience + 12;
            Player.Health = Player.Experience + 8;
            Player.HealthMax = Player.Experience + 4;
            Player.Level = Player.Experience - 4;
            Player.MagicLevel = Player.Experience - 8;
            Player.LevelPercent = Player.Experience - 12;
            Player.MagicLevelPercent = Player.Experience - 16;
            Player.Mana = Player.Experience - 20;
            Player.ManaMax = Player.Experience - 24;
            Player.Soul = Player.Experience - 28;
            Player.Stamina = Player.Experience - 32;
            Player.Capacity = Player.Experience - 36;
            Player.FistPercent = 0x63D27C;
            Player.ClubPercent = Player.FistPercent + 4;
            Player.SwordPercent = Player.FistPercent + 8;
            Player.AxePercent = Player.FistPercent + 12;
            Player.DistancePercent = Player.FistPercent + 16;
            Player.ShieldingPercent = Player.FistPercent + 20;
            Player.FishingPercent = Player.FistPercent + 24;
            Player.Fist = Player.FistPercent + 28;
            Player.Club = Player.FistPercent + 32;
            Player.Sword = Player.FistPercent + 36;
            Player.Axe = Player.FistPercent + 40;
            Player.Distance = Player.FistPercent + 44;
            Player.Shielding = Player.FistPercent + 48;
            Player.Fishing = Player.FistPercent + 52;
            Player.SlotHead = 0x64A1C0;
            Player.SlotNeck = Player.SlotHead + 12;
            Player.SlotBackpack = Player.SlotHead + 24;
            Player.SlotArmor = Player.SlotHead + 36;
            Player.SlotRight = Player.SlotHead + 48;
            Player.SlotLeft = Player.SlotHead + 60;
            Player.SlotLegs = Player.SlotHead + 72;
            Player.SlotFeet = Player.SlotHead + 84;
            Player.SlotRing = Player.SlotHead + 96;
            Player.SlotAmmo = Player.SlotHead + 108;
            Player.MaxSlots = 10;
            Player.DistanceSlotCount = 4;
            Player.CurrentTileToGo = 0x63D2F8;
            Player.TilesToGo = 0x63D2FC;
            Player.GoToX = Player.Experience + 80;
            Player.GoToY = Player.GoToX - 4;
            Player.GoToZ = Player.GoToX - 8;
            Player.RedSquare = 0x63D2BC;
            Player.GreenSquare = Player.RedSquare - 4;
            Player.WhiteSquare = Player.GreenSquare - 8;
            Player.AccessN = 0;
            Player.AccessS = 0;
            Player.TargetId = Player.RedSquare;
            Player.TargetBattlelistId = Player.TargetId - 8;
            Player.TargetBattlelistType = Player.TargetId - 5;
            Player.TargetType = Player.TargetId + 3;
            Player.Z = 0x64CB28;

            TextDisplay.PrintName = 0x4F5133;
            TextDisplay.PrintFPS = 0x45A058;
            TextDisplay.ShowFPS = 0x63AF94;
            TextDisplay.PrintTextFunc = 0x4B4130;
            TextDisplay.NopFPS = 0x459F94;

            Vip.Start = 0x63B010;
            Vip.StepPlayers = 0x2C;
            Vip.MaxPlayers = 200;
            Vip.DistanceId = 0;
            Vip.DistanceName = 4;
            Vip.DistanceStatus = 34;
            Vip.DistanceIcon = 40;
            Vip.End = Vip.Start + (Vip.StepPlayers * Vip.MaxPlayers);
        }
    }
}
