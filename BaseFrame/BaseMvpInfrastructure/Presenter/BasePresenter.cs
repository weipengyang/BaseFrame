using BaseFrame.Interface;
using BaseFrame.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaseFrame.Presenter
{
    /// <summary>
    /// MVP模式基础：Presenter基类，实现了 IPresenter 接口，定义了逻辑处理的基本结构。
    /// </summary>
    public class BasePresenter : IPresenter, IDependencyService
    {
        #region Properties
        /// <summary>
        /// 保存当前与Presenter关联的View页面。
        /// </summary>
        public object ViewHost
        {
            get;
            private set;
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// 初始化通过依赖注入初始化数据：在此方法中解决循环依赖问题。
        /// </summary>
        public void InitDependencyData()
        {
            this.InternalInitData();
        }

        /// <summary>
        /// 附加界面相关对象：各实现类根据具体情况对IView对象进行转换。
        /// </summary>
        /// <param name="view"></param>
        public void AttachView(IView view)
        {
            this.ViewHost = view;
            this.OnViewAttached(view);
        }

        /// <summary>
        /// 处理与当前工作台关联的窗体加载事件。
        /// </summary>
        public void HandleLoadView()
        {
            this.OnHandleViewLoaded();
            return;
        }

        /// <summary>
        /// 与当前工作台关联的窗体关闭完成事件。
        /// </summary>
        public void HandleClosedView()
        {
            this.OnHandleViewClosed();
            return;
        }

        /// <summary>
        /// 与当前工作台关联的窗体请求关闭事件。
        /// </summary>
        /// <param name="closingArg"></param>
        public void HandleClosingView(ClosingEventArgs closingArg)
        {
            this.OnHandleViewClosing(closingArg);
            return;
        }
        #endregion

        #region Protected Methods
        /// <summary>
        /// 初始化Presenter数据：在此方法中解决循环依赖问题。
        /// </summary>
        protected virtual void InternalInitData()
        {
        }

        /// <summary>
        /// 内部处理处理与当前工作台关联的窗体加载事件。
        /// </summary>
        protected virtual void OnHandleViewLoaded()
        {
        }

        /// <summary>
        /// 内部处理与当前工作台关联的窗体关闭完成事件。
        /// </summary>
        protected virtual void OnHandleViewClosed()
        {
        }

        /// <summary>
        /// 内部处理附加界面相关对象：给实现类根据具体情况对IView对象进行转换。
        /// </summary>
        /// <param name="view"></param>
        protected virtual void OnViewAttached(IView view)
        {
        }

        /// <summary>
        /// 内部处理与当前工作台关联的窗体请求关闭事件。
        /// </summary>
        /// <param name="closingArg"></param>
        protected virtual void OnHandleViewClosing(ClosingEventArgs closingArg)
        {
        }
        #endregion
    }
}
