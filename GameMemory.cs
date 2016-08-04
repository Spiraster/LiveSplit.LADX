using System.Diagnostics;

namespace LiveSplit.LADX
{
    class LADXMemory
    {
        public Emulator emulator { get; set; }
        private GameVersion version { get; set; }

        public int ptrBase;
        public int[] ptrOffsetsA;
        public int[] ptrOffsetsB;

        public DeepPointer D1Enter, D2Enter, D3Enter, D4Enter, D5Enter, D6Enter, D7Enter, D8Enter, D0Enter;
        public DeepPointer D1Grab, D2Grab, D3Grab, D4Grab, D5Grab, D6Grab, D7Grab, D8Grab;
        public DeepPointer D1Instrument, D2Instrument, D3Instrument, D4Instrument, D5Instrument, D6Instrument, D7Instrument, D8Instrument; //inventory values (slightly delayed)
        public DeepPointer BirdKeyGrab, SwordGrab, Music, SoundCue, Keys, Flippers, Marin, StealCount, Photos;
        public DeepPointer FileSelect1, FileSelect2, FileSelect3, VersionCheck, ResetCheck, FileSelect;

        public LADXMemory()
        {
            
        }

        public void setPointers()
        {
            if (emulator == Emulator.bgb151)
            {
                ptrBase = 0x000FC5CC;
                ptrOffsetsA = new int[] { 0xF5C, 0x1A8 };
                ptrOffsetsB = new int[] { 0xF5C, 0x264 };
            }
            else if (emulator == Emulator.bgb152)
            {
                ptrBase = 0x000FE5CC;
                ptrOffsetsA = new int[] { 0xC4C, 0x1B0 };
                ptrOffsetsB = new int[] { 0xC4C, 0x26C };
            }
            else if (emulator == Emulator.gambatte571)
            {
                ptrBase = 0x00552038;
                ptrOffsetsA = new int[] { 0x1C, 0x10, 0x10, 0x110, 0x6C };
                ptrOffsetsB = new int[] { 0x1C, 0x10, 0x10, 0x110, 0x8C };
            }

            //set A
            D1Grab = new DeepPointer(ptrBase, ptrOffsetsA, 0xF02);
            D2Grab = new DeepPointer(ptrBase, ptrOffsetsA, 0xF2A);
            D3Grab = new DeepPointer(ptrBase, ptrOffsetsA, 0xF59);
            D4Grab = new DeepPointer(ptrBase, ptrOffsetsA, 0xF62);
            D5Grab = new DeepPointer(ptrBase, ptrOffsetsA, 0xF82);
            D6Grab = new DeepPointer(ptrBase, ptrOffsetsA, 0xFB5);
            D7Grab = new DeepPointer(ptrBase, ptrOffsetsA, 0xF2C);
            D8Grab = new DeepPointer(ptrBase, ptrOffsetsA, 0xF30);
            BirdKeyGrab = new DeepPointer(ptrBase, ptrOffsetsA, 0xF7A);
            SwordGrab = new DeepPointer(ptrBase, ptrOffsetsA, 0xFF2);

            //set B
            D1Enter = new DeepPointer(ptrBase, ptrOffsetsB, 0x917);
            D2Enter = new DeepPointer(ptrBase, ptrOffsetsB, 0x936);
            D3Enter = new DeepPointer(ptrBase, ptrOffsetsB, 0x952);
            D4Enter = new DeepPointer(ptrBase, ptrOffsetsB, 0x97A);
            D5Enter = new DeepPointer(ptrBase, ptrOffsetsB, 0x9A1);
            D6Enter = new DeepPointer(ptrBase, ptrOffsetsB, 0x9D4);
            D7Enter = new DeepPointer(ptrBase, ptrOffsetsB, 0xA0E);
            D8Enter = new DeepPointer(ptrBase, ptrOffsetsB, 0xA5D);
            D0Enter = new DeepPointer(ptrBase, ptrOffsetsB, 0xDF2);
            D1Instrument = new DeepPointer(ptrBase, ptrOffsetsB, 0xB65);
            D2Instrument = new DeepPointer(ptrBase, ptrOffsetsB, 0xB66);
            D3Instrument = new DeepPointer(ptrBase, ptrOffsetsB, 0xB67);
            D4Instrument = new DeepPointer(ptrBase, ptrOffsetsB, 0xB68);
            D5Instrument = new DeepPointer(ptrBase, ptrOffsetsB, 0xB69);
            D6Instrument = new DeepPointer(ptrBase, ptrOffsetsB, 0xB6A);
            D7Instrument = new DeepPointer(ptrBase, ptrOffsetsB, 0xB6B);
            D8Instrument = new DeepPointer(ptrBase, ptrOffsetsB, 0xB6C);
            Music = new DeepPointer(ptrBase, ptrOffsetsB, 0x3CA);
            SoundCue = new DeepPointer(ptrBase, ptrOffsetsB, 0x3C8);
            Keys = new DeepPointer(ptrBase, ptrOffsetsB, 0xB11);
            Flippers = new DeepPointer(ptrBase, ptrOffsetsB, 0xB0C);
            Marin = new DeepPointer(ptrBase, ptrOffsetsB, 0xB73);
            StealCount = new DeepPointer(ptrBase, ptrOffsetsB, 0xB6E);
            Photos = new DeepPointer(ptrBase, ptrOffsetsB, 0xC0C);
            FileSelect1 = new DeepPointer(ptrBase, ptrOffsetsB, 0x3BC);
            FileSelect2 = new DeepPointer(ptrBase, ptrOffsetsB, 0xDD5);
            FileSelect3 = new DeepPointer(ptrBase, ptrOffsetsB, 0xB96);
            VersionCheck = new DeepPointer(ptrBase, ptrOffsetsB, 0xC10);
            ResetCheck = new DeepPointer(ptrBase, ptrOffsetsB, 0xA0);
            FileSelect = new DeepPointer(ptrBase, ptrOffsetsB, 0xB95);
        }

        public void getVersion(Process game)
        {
            int _int;

            VersionCheck.Deref<int>(game, out _int);
            if (_int == 0)
            {
                version = GameVersion.LA;
            }
            else
            {
                version = GameVersion.LADX;
            }
        }

        public bool doStart(Process game)
        {
            short _short;

            FileSelect.Deref<short>(game, out _short);
            if (_short == 0x0902)
                return true;

            return false;
        }

        public bool doReset(Process game)
        {
            byte _byte;

            ResetCheck.Deref<byte>(game, out _byte);
            if (_byte > 0)
                return true;
            
            return false;
        }

        public bool doSplit(string segment, Process game, LADXSettings settings)
        {
            int _int;
            short _short;
            byte _byte;

            //dungeon entrances
            if (segment == settings.SplitInfo[(int)Splits.ED1][2])
            {
                D1Enter.Deref<byte>(game, out _byte);
                if (_byte == 0x8E)
                    return true;
            }
            else if (segment == settings.SplitInfo[(int)Splits.ED2][2])
            {
                D2Enter.Deref<byte>(game, out _byte);
                if (_byte == 0x8C)
                    return true;
            }
            else if (segment == settings.SplitInfo[(int)Splits.ED3][2])
            {
                D3Enter.Deref<byte>(game, out _byte);
                if (_byte == 0x8D)
                    return true;
            }
            else if (segment == settings.SplitInfo[(int)Splits.ED4][2])
            {
                D4Enter.Deref<byte>(game, out _byte);
                if (_byte == 0x8C)
                    return true;
            }
            else if (segment == settings.SplitInfo[(int)Splits.ED5][2])
            {
                D5Enter.Deref<byte>(game, out _byte);
                if (_byte == 0x8A)
                    return true;
            }
            else if (segment == settings.SplitInfo[(int)Splits.ED6][2])
            {
                D6Enter.Deref<byte>(game, out _byte);
                if (_byte == 0x8B)
                    return true;
            }
            else if (segment == settings.SplitInfo[(int)Splits.ED7][2])
            {
                D7Enter.Deref<byte>(game, out _byte);
                if (_byte == 0x8B)
                    return true;
            }
            else if (segment == settings.SplitInfo[(int)Splits.ED8][2])
            {
                D8Enter.Deref<byte>(game, out _byte);
                if (_byte == 0x8C)
                    return true;
            }
            else if (segment == settings.SplitInfo[(int)Splits.ED0][2])
            {
                D0Enter.Deref<byte>(game, out _byte);
                if (_byte == 0x84)
                    return true;
            }

            //keys, items and others
            else if (segment == settings.SplitInfo[(int)Splits.TK][2])
            {
                Keys.Deref<int>(game, out _int);
                if (_int == 1)
                    return true;
            }
            else if (segment == settings.SplitInfo[(int)Splits.Flips][2])
            {
                Flippers.Deref<byte>(game, out _byte);
                if (_byte == 1)
                    return true;
            }
            else if (segment == settings.SplitInfo[(int)Splits.BK][2])
            {
                BirdKeyGrab.Deref<byte>(game, out _byte);
                if (_byte == 1)
                    return true;
            }
            else if (segment == settings.SplitInfo[(int)Splits.Shop][2])
            {
                StealCount.Deref<byte>(game, out _byte);
                if (_byte == 2)
                    return true;
            }
            else if (segment == settings.SplitInfo[(int)Splits.Marin][2])
            {
                Marin.Deref<byte>(game, out _byte);
                if (_byte == 1)
                    return true;
            }
            else if (segment == settings.SplitInfo[(int)Splits.RP][2])
            {
                Photos.Deref<short>(game, out _short);
                if (_short == 0x27F)
                    return true;
            }
            else if (segment == settings.SplitInfo[(int)Splits.L1Sword][2])
            {
                SwordGrab.Deref<byte>(game, out _byte);
                if (_byte == 2)
                    return true;
            }
            else if (segment == settings.SplitInfo[(int)Splits.Song1][2])
            {
                Music.Deref<short>(game, out _short);
                if (_short == 0x2A10)
                    return true;
            }
            else if (segment == settings.SplitInfo[(int)Splits.Song2][2])
            {
                Music.Deref<short>(game, out _short);
                if (_short == 0x2010)
                    return true;
            }
            else if (segment == settings.SplitInfo[(int)Splits.Song3][2])
            {
                Music.Deref<short>(game, out _short);
                if (_short == 0x3510)
                    return true;
            }
            else if (segment == settings.SplitInfo[(int)Splits.ML][2])
            {
                Music.Deref<short>(game, out _short);
                if (_short == 0x1610)
                    return true;
            }
            else if (segment == settings.SplitInfo[(int)Splits.L2Sword][2])
            {
                Music.Deref<short>(game, out _short);
                if (_short == 0x360F)
                    return true;
            }
            else if (segment == settings.SplitInfo[(int)Splits.D0][2])
            {
                Music.Deref<short>(game, out _short);
                if (_short == 0x610C)
                {
                    SoundCue.Deref<byte>(game, out _byte);
                    if (_byte == 1)
                        return true;
                }
            }
            else if (segment == settings.SplitInfo[(int)Splits.Egg][2])
            {
                Music.Deref<short>(game, out _short);
                if (_short == 0x5939)
                    return true;
            }

            //LA instruments
            else if (version == GameVersion.LA && settings.ICSTimings == true)
            {
                if (segment == settings.SplitInfo[(int)Splits.D1][2])
                {
                    D1Instrument.Deref<byte>(game, out _byte);
                    if (_byte == 3)
                    {
                        Music.Deref<byte>(game, out _byte);
                        if (_byte == 5)
                            return true;
                    }
                }
                else if (segment == settings.SplitInfo[(int)Splits.D2][2])
                {
                    D2Instrument.Deref<byte>(game, out _byte);
                    if (_byte == 3)
                    {
                        Music.Deref<byte>(game, out _byte);
                        if (_byte == 5)
                            return true;
                    }
                }
                else if (segment == settings.SplitInfo[(int)Splits.D3][2])
                {
                    D3Instrument.Deref<byte>(game, out _byte);
                    if (_byte == 3)
                    {
                        Music.Deref<byte>(game, out _byte);
                        if (_byte == 5)
                            return true;
                    }
                }
                else if (segment == settings.SplitInfo[(int)Splits.D4][2])
                {
                    D4Instrument.Deref<byte>(game, out _byte);
                    if (_byte == 3)
                    {
                        Music.Deref<byte>(game, out _byte);
                        if (_byte == 5)
                            return true;
                    }
                }
                else if (segment == settings.SplitInfo[(int)Splits.D5][2])
                {
                    D5Instrument.Deref<byte>(game, out _byte);
                    if (_byte == 2)
                    {
                        Music.Deref<byte>(game, out _byte);
                        if (_byte == 5)
                            return true;
                    }
                }
                else if (segment == settings.SplitInfo[(int)Splits.D6][2])
                {
                    D6Instrument.Deref<byte>(game, out _byte);
                    if (_byte == 3)
                    {
                        Music.Deref<byte>(game, out _byte);
                        if (_byte == 5)
                            return true;
                    }
                }
                else if (segment == settings.SplitInfo[(int)Splits.D7][2])
                {
                    D7Instrument.Deref<byte>(game, out _byte);
                    if (_byte == 6)
                    {
                        Music.Deref<byte>(game, out _byte);
                        if (_byte == 6)
                            return true;
                    }
                }
                else if (segment == settings.SplitInfo[(int)Splits.D8][2])
                {
                    D8Instrument.Deref<byte>(game, out _byte);
                    if (_byte == 3)
                    {
                        Music.Deref<byte>(game, out _byte);
                        if (_byte == 6)
                            return true;
                    }
                }
            }

            //LADX instruments
            else
            {
                if (segment == settings.SplitInfo[(int)Splits.D1][2])
                {
                    D1Grab.Deref<byte>(game, out _byte);
                    if (_byte == 1)
                        return true;
                }
                else if (segment == settings.SplitInfo[(int)Splits.D2][2])
                {
                    D2Grab.Deref<byte>(game, out _byte);
                    if (_byte == 1)
                        return true;
                }
                else if (segment == settings.SplitInfo[(int)Splits.D3][2])
                {
                    D3Grab.Deref<byte>(game, out _byte);
                    if (_byte == 1)
                        return true;
                }
                else if (segment == settings.SplitInfo[(int)Splits.D4][2])
                {
                    D4Grab.Deref<byte>(game, out _byte);
                    if (_byte == 1)
                        return true;
                }
                else if (segment == settings.SplitInfo[(int)Splits.D5][2])
                {
                    D5Grab.Deref<byte>(game, out _byte);
                    if (_byte == 1)
                        return true;
                }
                else if (segment == settings.SplitInfo[(int)Splits.D6][2])
                {
                    D6Grab.Deref<byte>(game, out _byte);
                    if (_byte == 1)
                        return true;
                }
                else if (segment == settings.SplitInfo[(int)Splits.D7][2])
                {
                    D7Grab.Deref<byte>(game, out _byte);
                    if (_byte == 1)
                        return true;
                }
                else if (segment == settings.SplitInfo[(int)Splits.D8][2])
                {
                    D8Grab.Deref<byte>(game, out _byte);
                    if (_byte == 1)
                        return true;
                }
            }
        
            return false;
        }

        private enum Splits
        {
            D1, D2, D3, D4, D5, D6, D7, D8, D0,
            ED1, ED2, ED3, ED4, ED5, ED6, ED7, ED8, ED0,
            TK, Shop, Flips, BK, Egg,
            Marin, RP, Song1, Song2, Song3, ML, L1Sword, L2Sword
        }

        private enum GameVersion
        {
            unknown,
            LADX,
            LA
        }
    }
    
    public enum Emulator
    {
        unknown,
        bgb151,
        bgb152,
        gambatte571
    }
}
