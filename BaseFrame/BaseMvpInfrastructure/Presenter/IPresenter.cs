using BaseFrame.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseFrame.Interface
{
    /// <summary>
    /// MVP模式基础：Presenter接口。
    /// </summary>
    public interface IPresenter
    {
        /// <summary>
        /// 附加界面相关对象：各实现类根据具体情况对IView对象进行转换。
        /// </summary>
        /// <param name="view"></param>
        void AttachView(IView view);

        /// <summary>
        /// 页面关闭后的处理
        /// </summary>
        void HandleClosedView();

        /// <summary>
        /// 加载页面时的处理
        /// </summary>
        void HandleLoadView();

        /// <summary>
        /// 页面关闭前的处理
        /// </summary>
        void HandleClosingView(ClosingEventArgs closingArg);
    }
}
