using BaseFrame.Interface;

namespace BaseFrame.MultiDocView
{
    /// <summary>
    /// 多文档类界面接口
    /// </summary>
    public interface IMultiDocView : IView
    {
        /// <summary>
        /// 改变当前界面：显示指定的View界面。
        /// </summary>
        /// <param name="view">需要显示的View界面。</param>
        void ChangeView(IView view);
    }
}
