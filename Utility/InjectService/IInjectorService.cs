using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaseFrame.Utility
{
    /// <summary>
    /// 依赖注入服务接口
    /// </summary>
    public interface IInjectorService
    {
        /// <summary>
        /// 用于获取指定接口的实现服务。
        /// </summary>
        /// <typeparam name="TService">接口。</typeparam>
        /// <returns>实现了接口的服务实例。</returns>
        TService GetInstance<TService>();

        /// <summary>
        /// 获取接口的所有实现服务。
        /// </summary>
        /// <typeparam name="TService">接口。</typeparam>
        /// <returns>实现了接口的所有服务实例。</returns>
        IEnumerable<TService> GetAllInstances<TService>();
    }
}
