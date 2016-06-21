using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

#region Managed Extensibility Framework (MEF)
using Prism.Mef;
using Prism.Modularity;
using System.ComponentModel.Composition.Hosting;

#endregion

namespace HelloWorld.Desktop
{
    class Bootstrapper : MefBootstrapper
    {
        
        protected override DependencyObject CreateShell()
        {
            // Fonctionne avec MEF et Unity
            //return new Shell();
            // Fonctionne avec MEF
            return this.Container.GetExportedValue<Shell>();
        }

        protected override void InitializeShell()
        {
            base.InitializeShell();

            Application.Current.MainWindow = (Shell)this.Shell;
            Application.Current.MainWindow.Show();
        }

        #region Managed Extensibility Framework (MEF)

        protected override IModuleCatalog CreateModuleCatalog()
        {
            return new ConfigurationModuleCatalog();
        }

        protected override void ConfigureAggregateCatalog()
        {
            base.ConfigureAggregateCatalog();
            
            this.AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(Bootstrapper).Assembly));
            
            this.AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(HelloWorldModule.HelloWorldModule).Assembly));
            // plantage
            /*
            Type MD = typeof(HelloWorldModule.HelloWorldModule);
 
            this.ModuleCatalog.AddModule(
                new ModuleInfo()
            {
                ModuleName = MD.Name,
                ModuleType = MD.AssemblyQualifiedName,
            });
            */
            

        }

        #endregion

        
    }
}
