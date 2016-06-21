using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Modularity;
using Prism.Regions;

#region MEF
using Prism.Mef.Regions;
using System.ComponentModel.Composition;
using Prism.Mef.Modularity;
#endregion

namespace HelloWorldModule
{
    // MEF
    [ModuleExport(typeof(HelloWorldModule))]    
    public class HelloWorldModule : IModule    
    {
       
        private readonly IRegionManager regionManager;

        [ImportingConstructor]
        public HelloWorldModule(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }

        public void Initialize()
        {
            regionManager.RegisterViewWithRegion("MainRegion", typeof(Views.HelloWorldView));

            //Uri viewNav = new Uri("HelloWorldView", UriKind.Relative);
            //regionManager.RequestNavigate("PrimaryRegion", viewNav);

        }
    }
}
