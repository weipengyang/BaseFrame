using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseFrame.Interface;

namespace BaseFrame.SingleDocView
{
    /// <summary>
    /// 单文档类界面接口
    /// </summary>
    public interface ISingleDocView : IView
    {
        /// <summary>
        /// 显示界面
        /// </summary>
        void ShowView();
        /// <summary>
        /// 关闭界面
        /// </summary>
        void CloseView();
        /// <summary>
        /// 刷新界面数据
        /// </summary>
        /// <param name="dataObj">数据对象</param>
        void RefreshView(object dataObj);
    }
}
