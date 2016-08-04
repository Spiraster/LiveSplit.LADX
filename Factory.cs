using LiveSplit.Model;
using LiveSplit.UI.Components;
using System;
using System.Reflection;

[assembly: ComponentFactory(typeof(LiveSplit.LADX.LADXFactory))]

namespace LiveSplit.LADX
{
    public class LADXFactory : IComponentFactory
    {
        public string ComponentName => "LADX Auto Splitter";
        public string Description => "Autosplitter for Link's Awakening (JP 1.0) with BGB and Gambatte";
        public Version Version => Assembly.GetExecutingAssembly().GetName().Version;

        public ComponentCategory Category => ComponentCategory.Control;

        public string UpdateName => ComponentName;
        public string UpdateURL => "https://raw.githubusercontent.com/Spiraster/LiveSplit.LADX/master/";
        public string XMLURL => UpdateURL + "Components/update.LiveSplit.LADX.xml";

        public IComponent Create(LiveSplitState state)
        {
            return new LADXComponent(state);
        }
    }
}
