using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseFrame.Interface
{
    /// <summary>
    /// MVP模式基础：View接口，界面层的基础接口
    /// </summary>
    public interface IView
    {
        /// <summary>
        /// 界面关联Presenter。
        /// </summary>
        /// <param name="source"></param>
        void ApplyPresenter(IPresenter source);
    }
}
