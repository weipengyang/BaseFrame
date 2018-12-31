using Microsoft.Practices.ServiceLocation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaseFrame.Utility
{
    /// <summary>
    /// 依赖注入服务。
    /// </summary>
    public class InjectorService : IInjectorService
    {
        private static InjectorService _instance;

        /// <summary>
        /// 获取当前系统运行时的依赖注入服务对象。
        /// </summary>
        public static IInjectorService Current
        {
            get
            {
                return InjectorService._instance;
            }
        }

        static InjectorService()
        {
            InjectorService._instance = new InjectorService();
        }

        private InjectorService()
        {
        }

        /// <summary>
        /// 获取依赖注入容器接口：用于依赖注入接口实例。
        /// </summary>
        private IServiceLocator Injector
        {
            get;
            set;
        }

        public static void InitInjector(IServiceLocator serviceLocator)
        {
            InjectorService._instance.Injector = serviceLocator;
        }

        /// <summary>
        /// 用于获取指定接口的实现服务。
        /// </summary>
        /// <typeparam name="TService">接口。</typeparam>
        /// <returns>实现了接口的服务实例。</returns>
        public TService GetInstance<TService>()
        {
            return this.Injector.GetInstance<TService>();
        }

        /// <summary>
        /// 获取接口的所有实现服务。
        /// </summary>
        /// <typeparam name="TService">接口。</typeparam>
        /// <returns>实现了接口的所有服务实例。</returns>
        public IEnumerable<TService> GetAllInstances<TService>()
        {
            return this.Injector.GetAllInstances<TService>();
        }
    }
}
