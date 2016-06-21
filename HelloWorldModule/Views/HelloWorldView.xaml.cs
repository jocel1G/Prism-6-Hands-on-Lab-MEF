using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

#region MEF
using System.ComponentModel.Composition;
using Prism.Modularity;
#endregion

namespace HelloWorldModule.Views
{
    /// <summary>
    /// Interaction logic for HelloWorldView.xaml
    /// </summary>
    //Plantage avec la ligne ci-dessous
    //[Export("HelloWorldView") ]
    [Export]
    // Fonctionne avec ou sans la ligne ci-dessous
    //[PartCreationPolicy(CreationPolicy.Shared)]
    // Fonctionne avec ou sans la ligne ci-dessous
    //[PartCreationPolicy(CreationPolicy.NonShared)]
    
    // MEF -> IModule implémentée
    public partial class HelloWorldView : UserControl
    {
        public HelloWorldView()
        {
            InitializeComponent();
        }

        
    }
}
