using LiveSplit.ComponentUtil;
using System.Diagnostics;
using System.Collections.Generic;
using System.Windows.Forms;
using System;

namespace LiveSplit.LADX
{
    class LADXMemory
    {
        public Emulator emulator { get; set; }
        private GameVersion version { get; set; }

        private LADXData data;
        private InfoList splits;

        public LADXMemory()
        {

        }
        
        public void setPointers()
        {
            data = new LADXData(emulator);
        }

        public void setSplits(LADXSettings settings)
        {
            splits = new InfoList();
            splits.AddRange(DefaultInfo.BaseSplits);
           
            if (version == GameVersion.LA && settings.ICSTimings)
                splits.AddRange(DefaultInfo.ICSSplits);
            else
                splits.AddRange(DefaultInfo.InstrumentSplits);

            foreach (var _setting in settings.CheckedSplits)
            {
                if (!_setting.isEnabled)
                    splits.Remove(splits[_setting.Name]);
            }
        }

        public void getVersion(Process game)
        {
            data["VersionCheck"].Update(game);

            int _int = Convert.ToInt32(data["VersionCheck"].Current);
            if (_int == 0)
                version = GameVersion.LA;
            else
                version = GameVersion.LADX;
        }

        public bool doStart(Process game)
        {
            data["FileSelect"].Update(game);

            short _short = Convert.ToInt16(data["FileSelect"].Current);
            if (_short == 0x0902)
                return true;

            return false;
        }

        public bool doReset(Process game)
        {
            data["ResetCheck"].Update(game);

            byte _byte = Convert.ToByte(data["ResetCheck"].Current);
            if (_byte > 0)
                return true;

            return false;
        }

        public bool doSplit(string segment, Process game, LADXSettings settings)
        {
            data.UpdateAll(game);

            foreach (var _split in splits)
            {
                int count = 0;
                foreach (var _trigger in _split.Triggers)
                {
                    int _int = Convert.ToInt32(data[_trigger.Key].Current);
                    if (_int == _trigger.Value)
                        count++;
                }

                if (count == _split.Triggers.Count)
                {
                    splits.Remove(_split);
                    return true;
                }

            }

            return false;
        }

        private enum GameVersion
        {
            unknown,
            LADX,
            LA
        }
    }

    class LADXData : MemoryWatcherList
    {
        private int ptrBase;
        private List<int>[] ptrOffsets;

        public LADXData(Emulator emulator)
        {
            if (emulator == Emulator.bgb151)
            {
                ptrBase = 0x000FC5CC;
                ptrOffsets = new List<int>[] { new List<int> { 0xF5C, 0x1A8 }, new List<int> { 0xF5C, 0x264 } };
            }
            else if (emulator == Emulator.bgb152)
            {
                ptrBase = 0x000FE5CC;
                ptrOffsets = new List<int>[] { new List<int> { 0xC4C, 0x1B0 }, new List<int> { 0xC4C, 0x26C } };
            }
            else if (emulator == Emulator.gambatte571)
            {
                ptrBase = 0x00552038;
                ptrOffsets = new List<int>[] { new List<int> { 0x1C, 0x10, 0x10, 0x110, 0x6C }, new List<int> { 0x1C, 0x10, 0x10, 0x110, 0x8C } };
            }

            foreach (var _ptr in DefaultInfo.Pointers)
            {
                if (_ptr.Type == "byte")
                    this.Add(new MemoryWatcher<byte>(new DeepPointer(ptrBase, getOffsets(_ptr.Index, _ptr.Offset))) { Name = _ptr.Name });
                else if (_ptr.Type == "short")
                    this.Add(new MemoryWatcher<short>(new DeepPointer(ptrBase, getOffsets(_ptr.Index, _ptr.Offset))) { Name = _ptr.Name });
                else if (_ptr.Type == "int")
                    this.Add(new MemoryWatcher<int>(new DeepPointer(ptrBase, getOffsets(_ptr.Index, _ptr.Offset))) { Name = _ptr.Name });
            }
        }

        private int[] getOffsets(int index, int offset)
        {
            var list = new List<int>();
            list.AddRange(ptrOffsets[index]);
            list.Add(offset);

            return list.ToArray();
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
