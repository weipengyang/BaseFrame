using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autofac;
using Autofac.Configuration;
using Autofac.Extras.CommonServiceLocator;
using BaseFrame.SingleDocView;
using Microsoft.Practices.ServiceLocation;
using BaseFrame.Utility;
using BaseFrame.Presenter;
using BaseFrame.Interface;
using BaseFrame.Interface.ViewInterface;
using BaseFrame.MultiDocView;
using BaseFrame.FrameInterface.ViewInterface;
using BaseFrame.FrameInterface.PresenterInterface;

namespace BaseFrame
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            bool success = InitService();

            if (!success)
            {
                Application.Exit();
                return;
            }

            Form mainForm = ServiceContainer.GetInstance<IMainView>() as Form;
            Application.Run(mainForm);
        }

        /// <summary>
        /// 初始化依赖注入实例和注入配置。
        /// </summary>
        private static bool InitService()
        {
            bool success = true;
            try
            {
                var iocBuilder = CreateIocBuilder();
                var container = iocBuilder.Build();
                var locator = new AutofacServiceLocator(container);
                ServiceLocator.SetLocatorProvider(() => locator);
                InjectorService.InitInjector(ServiceLocator.Current);

                InitServiceData();
                success = true;
            }
            catch (Exception err)
            {
                success = false;
                LoggingService.Error("Program.InitService()，初始化依赖注入服务失败。", err);
                System.Diagnostics.Trace.WriteLine("Program InitService Error:" + err.ToString());
                MessageBox.Show("初始化依赖注入服务失败：" + err.ToString());
            }
            return success;
        }

        /// <summary>
        /// 依赖注入完成后：初始化各个注入对象所需的依赖数据。解决注入时的循环依赖问题。
        /// </summary>
        private static void InitServiceData()
        {
            var lstDependencyServices = ServiceContainer.GetAllInstances<IDependencyService>().ToList();
            if (lstDependencyServices != null && lstDependencyServices.Count > 0)
            {
                foreach (var service in lstDependencyServices)
                {
                    service.InitDependencyData();
                }
            }
        }

        /// <summary>
        /// 创建IOC服务加载类。
        /// </summary>
        /// <returns></returns>
        private static ContainerBuilder CreateIocBuilder()
        {
            Autofac.ContainerBuilder iocBuilder = new Autofac.ContainerBuilder();
            iocBuilder.RegisterModule(new ConfigurationSettingsReader("autofac"));
            return iocBuilder;
        }
    }
}
