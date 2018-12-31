using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseFrame.Interface;

namespace BaseFrame.Presenter
{
    /// <summary>
    /// 多文档类的业务层接口Presenter
    /// </summary>
    public interface IMultiDocPresenter : IPresenter
    {
        /// <summary>
        /// 改变当前界面：显示指定的View界面。
        /// </summary>
        /// <param name="view">需要显示的View界面。</param>
        void ChangeView(IView view);
    }
}
