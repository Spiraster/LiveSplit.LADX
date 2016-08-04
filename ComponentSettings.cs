using System;
using System.Windows.Forms;
using System.Xml;
using System.Reflection;
using System.Collections.Generic;

namespace LiveSplit.LADX
{
    public partial class LADXSettings : UserControl
    {
        public string[][] SplitInfo;
        
        public bool AutoStartTimer, AutoSelectFile, AutoReset, ICSTimings;

        public LADXSettings()
        {
            InitializeComponent();

            AutoStartTimer = false;
            AutoSelectFile = false;
            AutoReset = false;
            ICSTimings = false;
            
            List<string[]> list = new List<string[]>();

            //{ variable name, XML tag, split name }
            list.Add(new string[] { "D1", "Cello", "full moon cello" });
            list.Add(new string[] { "D2", "Conch", "conch horn" });
            list.Add(new string[] { "D3", "Bell", "sea lily's bell" });
            list.Add(new string[] { "D4", "Harp", "surf harp" });
            list.Add(new string[] { "D5", "Marimba", "wind marimba" });
            list.Add(new string[] { "D6", "Triangle", "coral triangle" });
            list.Add(new string[] { "D7", "Organ", "organ of evening calm" });
            list.Add(new string[] { "D8", "Drum", "thunder drum" });
            list.Add(new string[] { "D0", "Tunic", "tunic upgrade" });

            list.Add(new string[] { "ED1", "EnterD1", "enter d1" });
            list.Add(new string[] { "ED2", "EnterD2", "enter d2" });
            list.Add(new string[] { "ED3", "EnterD3", "enter d3" });
            list.Add(new string[] { "ED4", "EnterD4", "enter d4" });
            list.Add(new string[] { "ED5", "EnterD5", "enter d5" });
            list.Add(new string[] { "ED6", "EnterD6", "enter d6" });
            list.Add(new string[] { "ED7", "EnterD7", "enter d7" });
            list.Add(new string[] { "ED8", "EnterD8", "enter d8" });
            list.Add(new string[] { "ED0", "EnterD0", "enter d0" });

            list.Add(new string[] { "TK", "TailKey", "tail key" });
            list.Add(new string[] { "Shop", "Shoplifting", "shoplifting" });
            list.Add(new string[] { "Flips", "Flippers", "flippers" });
            list.Add(new string[] { "BK", "BirdKey", "bird key" });
            list.Add(new string[] { "Egg", "Egg", "wind fish's egg" });

            list.Add(new string[] { "Marin", "Marin", "marin" });
            list.Add(new string[] { "RP", "RoosterPhoto", "rooster photo" });
            list.Add(new string[] { "Song1", "Song1", "ballad of the wind fish" });
            list.Add(new string[] { "Song2", "Song2", "manbo's mambo" });
            list.Add(new string[] { "Song3", "Song3", "song of soul" });
            list.Add(new string[] { "ML", "MagnifyingLens", "magnifying lens" });
            list.Add(new string[] { "L1Sword", "L1Sword", "sword" });
            list.Add(new string[] { "L2Sword", "L2Sword", "l2 sword" });

            SplitInfo = list.ToArray();

            LoadSplits(null);
        }

        public XmlNode GetSettings(XmlDocument document)
        {
            var settingsNode = document.CreateElement("Settings");

            settingsNode.AppendChild(ToElement(document, "Version", Assembly.GetExecutingAssembly().GetName().Version.ToString(3)));

            settingsNode.AppendChild(ToElement(document, "AutoStartTimer", AutoStartTimer.ToString()));
            settingsNode.AppendChild(ToElement(document, "AutoSelectFile", AutoSelectFile.ToString()));
            settingsNode.AppendChild(ToElement(document, "AutoReset", AutoReset.ToString()));
            settingsNode.AppendChild(ToElement(document, "ICSTimings", ICSTimings.ToString()));

            foreach (string[] split in SplitInfo)
            {
                settingsNode.AppendChild(ToElement(document, split[1], split[2]));
            }
            
            return settingsNode;
        }

        public void SetSettings(XmlNode settings)
        {
            var element = (XmlElement)settings;
            if (!element.IsEmpty)
            {
                Version version;
                if (element["Version"] != null)
                    version = Version.Parse(element["Version"].InnerText);
                else
                    version = new Version(1, 0, 0);

                if (element["AutoStartTimer"] != null)
                {
                    AutoStartTimer = Convert.ToBoolean(element["AutoStartTimer"].InnerText);
                    chkStartTimer.Checked = AutoStartTimer;
                }
                if (element["AutoSelectFile"] != null)
                {
                    AutoSelectFile = Convert.ToBoolean(element["AutoSelectFile"].InnerText);
                    chkSelectFile.Checked = AutoSelectFile;
                }
                if (element["AutoReset"] != null)
                {
                    AutoReset = Convert.ToBoolean(element["AutoReset"].InnerText);
                    chkAutoReset.Checked = AutoReset;
                }
                if (element["ICSTimings"] != null)
                {
                    ICSTimings = Convert.ToBoolean(element["ICSTimings"].InnerText);
                    chkICSTimings.Checked = ICSTimings;
                }

                LoadSplits(element);
                SaveSplits();
            }
        }

        private TextBox GetTextBox(string search)
        {
            foreach (Control page in tabControl.Controls)
            {
                foreach (Control table in page.Controls)
                {
                    foreach (Control c in table.Controls)
                    {
                        if (c.Name == "txt_" + search)
                        {
                            return ((TextBox)c);
                        }
                    }
                }
            }
            return null;
        }

        private void SaveSplits()
        {
            foreach (string[] split in SplitInfo)
            {
                var textBox = GetTextBox(split[0]);

                if (textBox != null)
                {
                    split[2] = textBox.Text.ToLower();
                }
            }
        }

        private void LoadSplits(XmlElement element)
        {
            foreach (string[] split in SplitInfo)
            {
                var textBox = GetTextBox(split[0]);

                if (textBox != null)
                {
                    if (element != null && element[split[1]] != null && element[split[1]].InnerText != "")
                        textBox.Text = element[split[1]].InnerText;
                    else
                        textBox.Text = split[2];
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SaveSplits();
        }

        private void checkAutoReset_CheckedChanged(object sender, EventArgs e)
        {
            AutoReset = chkAutoReset.Checked;
        }

        private void checkStartTimer_CheckedChanged(object sender, EventArgs e)
        {
            AutoStartTimer = chkStartTimer.Checked;
        }

        private void chkICSTimings_CheckedChanged(object sender, EventArgs e)
        {
            ICSTimings = chkICSTimings.Checked;
        }

        private void checkSelectFile_CheckedChanged(object sender, EventArgs e)
        {
            AutoSelectFile = chkSelectFile.Checked;
        }

        private XmlElement ToElement<T>(XmlDocument document, String name, T value)
        {
            var element = document.CreateElement(name);
            element.InnerText = value.ToString();
            return element;
        }
    }
}
