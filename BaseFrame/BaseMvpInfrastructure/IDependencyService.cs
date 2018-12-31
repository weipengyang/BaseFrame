using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaseFrame.Interface
{
    /// <summary>
    /// 依赖性服务：用于解决依赖注入的循环依赖问题。在IOC容器构建完成后，通过此接口完成依赖注入的赋值。
    /// </summary>
    public interface IDependencyService
    {
        /// <summary>
        /// 初始化通过依赖注入初始化数据：在此方法中解决循环依赖问题。
        /// </summary>
        void InitDependencyData();
    }
}
