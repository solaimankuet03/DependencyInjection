namespace DependencyInjection
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class NinjectBindings : Ninject.Modules.NinjectModule
    {
        public override void Load()
        {
            //#if DEBUG
                //Kernel.Bind<ISMSService>().To<MockSMSService>();
            //#else
                Kernel.Bind<ISMSService>().To<ProductionSMSService>();
            //#endif

            Kernel.Bind<INotifyService>().To<NotifyService>();
        }
    }
}
