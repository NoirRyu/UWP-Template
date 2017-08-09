using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace MDSTemplate
{
    public partial class MainPage : Page
    {
        public const string FEATURE_NAME = "MDS Demo";

        List<Scenario> scenarios = new List<Scenario>
        {
            new Scenario() {Title = "Scenario 1", ClassType = typeof(Scenario1)},
            new Scenario() {Title = "Scenario 2", ClassType = typeof(Scenario2)}
        };
       

    }

    public class Scenario
    {
        public string Title { get; set; }
        public Type ClassType { get; set; }
    }
}
