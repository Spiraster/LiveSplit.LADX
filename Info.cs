using System.Collections.Generic;
using System.Linq;

namespace LiveSplit.LADX
{
    public static class DefaultInfo
    {
        public static InfoList Pointers = new InfoList
        {
            //WRAM0 pointers
            new Info("ResetCheck", "byte", 0, 0xEFF),

            //WRAM1 pointers
            new Info("D1Enter", "byte", 1, 0x917),
            new Info("D2Enter", "byte", 1, 0x936),
            new Info("D3Enter", "byte", 1, 0x952),
            new Info("D4Enter", "byte", 1, 0x97A),
            new Info("D5Enter", "byte", 1, 0x9A1),
            new Info("D6Enter", "byte", 1, 0x9D4),
            new Info("D7Enter", "byte", 1, 0xA0E),
            new Info("D8Enter", "byte", 1, 0xA5D),
            new Info("D0Enter", "byte", 1, 0xDF2),
            new Info("D1Instrument", "byte", 1, 0xB65),
            new Info("D2Instrument", "byte", 1, 0xB66),
            new Info("D3Instrument", "byte", 1, 0xB67),
            new Info("D4Instrument", "byte", 1, 0xB68),
            new Info("D5Instrument", "byte", 1, 0xB69),
            new Info("D6Instrument", "byte", 1, 0xB6A),
            new Info("D7Instrument", "byte", 1, 0xB6B),
            new Info("D8Instrument", "byte", 1, 0xB6C),
            new Info("OverworldTile", "byte", 1, 0xB54),
            new Info("DungeonTile", "byte", 1, 0xBAE),
            new Info("Music1", "short", 1, 0x3CA),
            new Info("Music2", "byte", 1, 0x3CA),
            new Info("Sound", "byte", 1, 0x3C8),
            new Info("TailKey", "byte", 1, 0xB11),
            new Info("AnglerKey", "byte", 1, 0xB12),
            new Info("Bracelet", "byte", 1, 0x920),
            new Info("Boots", "byte", 1, 0x946),
            new Info("Flippers", "byte", 1, 0xB0C),
            new Info("MagicRod", "byte", 1, 0xA37),
            new Info("Marin", "byte", 1, 0xB73),
            new Info("Steals", "byte", 1, 0xB6E),
            new Info("Photos", "short", 1, 0xC0C),

            new Info("VersionCheck", "int", 1, 0xC10),
            new Info("FileSelect", "short", 1, 0xB95)
        };

        public static InfoList BaseSplits = new InfoList
        {
            //dungeon entrances
            new Info("ED1", "D1Enter", 0x8E),
            new Info("ED2", "D2Enter", 0x8C),
            new Info("ED3", "D3Enter", 0x8D),
            new Info("ED4", "D4Enter", 0x8C),
            new Info("ED5", "D5Enter", 0x8A),
            new Info("ED6", "D6Enter", 0x8B),
            new Info("ED7", "D7Enter", 0x8B),
            new Info("ED8", "D8Enter", 0x8C),
            new Info("ED0", "D0Enter", 0x84),
                
            //keys, items and others
            new Info("TK", "TailKey", 1),
            new Info("AK", new InfoList { new Info("Music2", 0x10), new Info("OverworldTile", 0xCE) }),
            new Info("BK", new InfoList { new Info("Music2", 0x10), new Info("OverworldTile", 0x0A) }),
            new Info("Shop", "Steals", 2),
            new Info("D2T", "Bracelet", 0x91),
            new Info("D3T", "Boots", 0x9B),
            new Info("D4T", "Flippers", 1),
            new Info("D8T", "MagicRod", 0x98),
            new Info("Marin", "Marin", 1),
            new Info("RP", "Photos", 0x27F),
            new Info("Song1", "Music1", 0x2A10),
            new Info("Song2", "Music1", 0x2010),
            new Info("Song3", "Music1", 0x3510),
            new Info("ML", new InfoList { new Info("Music2", 0x10), new Info("OverworldTile", 0xE9) }),
            new Info("L1S", new InfoList { new Info("Music2", 0x0F), new Info("OverworldTile", 0xF2) }),
            new Info("L2S", new InfoList { new Info("Music2", 0x0F), new Info("OverworldTile", 0x8A) }),
            new Info("D0", new InfoList { new Info("Music1", 0x610C), new Info("Sound", 1) }),
            new Info("Egg", new InfoList { new Info("Music2", 0x39), new Info("OverworldTile", 0x06) })
        };

        public static InfoList InstrumentSplits = new InfoList
        {
            //instruments
            new Info("D1", new InfoList { new Info("Music2", 0x0B), new Info("OverworldTile", 0xD3) }),
            new Info("D2", new InfoList { new Info("Music2", 0x0B), new Info("OverworldTile", 0x24) }),
            new Info("D3", new InfoList { new Info("Music2", 0x0B), new Info("OverworldTile", 0xB5) }),
            new Info("D4", new InfoList { new Info("Music2", 0x0B), new Info("OverworldTile", 0x2B) }),
            new Info("D5", new InfoList { new Info("Music2", 0x0B), new Info("OverworldTile", 0xD9) }),
            new Info("D6", new InfoList { new Info("Music2", 0x0B), new Info("OverworldTile", 0x8C) }),
            new Info("D7", new InfoList { new Info("Music2", 0x0B), new Info("OverworldTile", 0x0E) }),
            new Info("D8", new InfoList { new Info("Music2", 0x0B), new Info("OverworldTile", 0x10) })
        };

        public static InfoList ICSSplits = new InfoList
        {
            //instruments
            new Info("D1", new InfoList { new Info("D1Instrument", 3), new Info("Music2", 5) }),
            new Info("D2", new InfoList { new Info("D2Instrument", 3), new Info("Music2", 5) }),
            new Info("D3", new InfoList { new Info("D3Instrument", 3), new Info("Music2", 5) }),
            new Info("D4", new InfoList { new Info("D4Instrument", 3), new Info("Music2", 5) }),
            new Info("D5", new InfoList { new Info("D5Instrument", 2), new Info("Music2", 5) }),
            new Info("D6", new InfoList { new Info("D6Instrument", 2, ">="), new Info("Music2", 5) }),
            new Info("D7", new InfoList { new Info("D7Instrument", 6), new Info("Music2", 6) }),
            new Info("D8", new InfoList { new Info("D8Instrument", 2, ">="), new Info("DungeonTile", 0x3B) }),
        };
    }

    public class Info
    {
        public string Name { get; }

        public string Type { get; }
        public int Index { get; }
        public int Offset { get; }

        public InfoList Triggers { get; }

        public string Pointer { get; }
        public int Value { get; }
        public string Operator { get; }

        public bool isEnabled { get; set; }

        /// <summary>
        /// For pointers
        /// </summary>
        /// <param name="_name"></param>
        /// <param name="_type"></param>
        /// <param name="_index"></param>
        /// <param name="_offset"></param>
        public Info(string _name, string _type, int _index, int _offset)
        {
            Name = _name;
            Type = _type;
            Index = _index;
            Offset = _offset;
        }

        /// <summary>
        /// For a single-trigger split
        /// </summary>
        /// <param name="_name"></param>
        /// <param name="_pointer"></param>
        /// <param name="_condition"></param>
        public Info(string _name, string _pointer, int _value)
        {
            Name = _name;
            Triggers = new InfoList { new Info(_pointer, _value) };
        }

        /// <summary>
        /// For a multiple-trigger split
        /// </summary>
        /// <param name="_name"></param>
        /// <param name="_triggers"></param>
        public Info(string _name, InfoList _triggers)
        {
            Name = _name;
            Triggers = _triggers;
        }
        
        /// <summary>
        /// For split triggers
        /// </summary>
        /// <param name="_pointer"></param>
        /// <param name="_value"></param>
        /// <param name="_op"></param>
        public Info(string _pointer, int _value, string _op = "==")
        {
            Pointer = _pointer;
            Value = _value;
            Operator = _op;
        }

        /// <summary>
        /// For split settings
        /// </summary>
        /// <param name="_name"></param>
        /// <param name="_enabled"></param>
        public Info(string _name, bool _enabled)
        {
            Name = _name;
            isEnabled = _enabled;
        }
    }

    public class InfoList : List<Info>
    {
        public Info this[string name]
        {
            get { return this.First(w => w.Name == name); }
        }
    }
}
