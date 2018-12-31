using BaseFrame.Utility.Files;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaseFrame.Utility
{
    /// <summary>
    /// 获取应用所有程序服务的入口点。
    /// </summary>
    public static class ServiceContainer
    {
        /// <summary>
        /// 用于获取指定接口的实现服务。
        /// </summary>
        /// <typeparam name="TService">接口。</typeparam>
        /// <returns>实现了接口的服务实例。</returns>
        public static T GetInstance<T>() where T : class
        {
            return InjectorService.GetInstance<T>();
        }

        /// <summary>
        /// 获取接口的所有实现服务。
        /// </summary>
        /// <typeparam name="TService">接口。</typeparam>
        /// <returns>实现了接口的所有服务实例。</returns>
        public static IEnumerable<T> GetAllInstances<T>()
        {
            return InjectorService.GetAllInstances<T>();
        }

        /// <summary>
        /// 获取依赖注入接口实现。
        /// </summary>
        public static IInjectorService InjectorService
        {
            get
            {
                return BaseFrame.Utility.InjectorService.Current;
            }
        }

        /// <summary>
        /// 获取消息处理接口实现。
        /// </summary>
        public static IMessageService MessageService
        {
            get { return GetInstance<IMessageService>(); }
        }

        /// <summary>
        /// 获取文件相关的服务接口实现。
        /// </summary>
        public static IFileService FileService
        {
            get { return GetInstance<IFileService>(); }
        }
    }
}
