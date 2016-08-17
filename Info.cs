using System.Collections.Generic;
using System.Linq;

namespace LiveSplit.LADX
{
    public static class DefaultInfo
    {
        public static InfoList Pointers = new InfoList
        {
            //0x0XXX pointers
            new Info("D1Grab", "byte", 0, 0xF02),
            new Info("D2Grab", "byte", 0, 0xF2A),
            new Info("D3Grab", "byte", 0, 0xF59),
            new Info("D4Grab", "byte", 0, 0xF62),
            new Info("D5Grab", "byte", 0, 0xF82),
            new Info("D6Grab", "byte", 0, 0xFB5),
            new Info("D7Grab", "byte", 0, 0xF2C),
            new Info("D8Grab", "byte", 0, 0xF30),
            new Info("BKGrab", "byte", 0, 0xF7A),
            new Info("SwordGrab", "byte", 0, 0xFF2),

            //0x1XXX pointers
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
            new Info("Music1", "short", 1, 0x3CA),
            new Info("Music2", "byte", 1, 0x3CA),
            new Info("Sound", "byte", 1, 0x3C8),
            new Info("TailKey", "byte", 1, 0xB11),
            new Info("Flippers", "byte", 1, 0xB0C),
            new Info("Marin", "byte", 1, 0xB73),
            new Info("Steals", "byte", 1, 0xB6E),
            new Info("Photos", "short", 1, 0xC0C),
            new Info("VersionCheck", "int", 1, 0xC10),
            new Info("ResetCheck", "byte", 1, 0xA0),
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
            new Info("BK", "BKGrab", 1),
            new Info("Shop", "Steals", 2),
            new Info("Flippers", "Flippers", 1),
            new Info("Marin", "Marin", 1),
            new Info("RP", "Photos", 0x27F),
            new Info("Song1", "Music1", 0x2A10),
            new Info("Song2", "Music1", 0x2010),
            new Info("Song3", "Music1", 0x3510),
            new Info("ML", "Music1", 0x1610),
            new Info("L1S", "SwordGrab", 2),
            new Info("L2S", "Music1", 0x360F),

            new Info("D0", new Dictionary<string, int> { { "Music1", 0x610C }, { "Sound", 1 } }),
            new Info("Egg", "Music1", 0x5939)
        };

        public static InfoList InstrumentSplits = new InfoList
        {
            //instruments
            new Info("D1", "D1Grab", 1),
            new Info("D2", "D2Grab", 1),
            new Info("D3", "D3Grab", 1),
            new Info("D4", "D4Grab", 1),
            new Info("D5", "D5Grab", 1),
            new Info("D6", "D6Grab", 1),
            new Info("D7", "D7Grab", 1),
            new Info("D8", "D8Grab", 1),
        };

        public static InfoList ICSSplits = new InfoList
        {
            //instruments
            new Info("D1", new Dictionary<string, int> { { "D1Instrument", 3 }, { "Music2", 5 } }),
            new Info("D2", new Dictionary<string, int> { { "D2Instrument", 3 }, { "Music2", 5 } }),
            new Info("D3", new Dictionary<string, int> { { "D3Instrument", 3 }, { "Music2", 5 } }),
            new Info("D4", new Dictionary<string, int> { { "D4Instrument", 3 }, { "Music2", 5 } }),
            new Info("D5", new Dictionary<string, int> { { "D5Instrument", 2 }, { "Music2", 5 } }),
            new Info("D6", new Dictionary<string, int> { { "D6Instrument", 3 }, { "Music2", 5 } }),
            new Info("D7", new Dictionary<string, int> { { "D7Instrument", 6 }, { "Music2", 6 } }),
            new Info("D8", new Dictionary<string, int> { { "D8Instrument", 3 }, { "Music2", 6 } }),
        };
    }

    public class Info
    {
        public string Name { get; }

        public string Type { get; }
        public int Index { get; }
        public int Offset { get; }

        public Dictionary<string, int> Triggers { get; }

        public bool isEnabled { get; set; }

        //pointer
        public Info(string _name, string _type, int _index, int _offset)
        {
            Name = _name;
            Type = _type;
            Index = _index;
            Offset = _offset;
        }

        //split
        public Info(string _name, string _pointer, int _condition)
        {
            Name = _name;
            Triggers = new Dictionary<string, int> { { _pointer, _condition } };
        }

        //split
        public Info(string _name, Dictionary<string, int> _triggers)
        {
            Name = _name;
            Triggers = _triggers;
        }

        //settings
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
