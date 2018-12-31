using System;
using BaseFrame.Interface;
using DevComponents.DotNetBar;
using System.Drawing;
using System.ComponentModel;
using BaseFrame.Model;

namespace BaseFrame.MultiDocView
{
    /// <summary>
    /// MVP模式基础：View基类，实现了 IView 接口，定义了界面的基本结构。
    /// </summary>
    public partial class BaseForm : DevComponents.DotNetBar.OfficeForm, IView, IDependencyService
    {
        #region Properties
        private IPresenter currentPresenter;

        /// <summary>
        /// 当前View所关联的Presenter。
        /// </summary>
        protected IPresenter CurrentPresenter
        {
            get
            {
                return this.currentPresenter;
            }
            private set
            {
                this.currentPresenter = value;
            }
        }
        #endregion

        #region Constructor
        public BaseForm()
        {
            //InitializeComponent();
            StyleManager.Style = eStyle.Office2016;
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// 显示页面。
        /// </summary>
        public virtual void ShowView()
        {
            return;
        }

        /// <summary>
        /// 关闭页面。
        /// </summary>
        public virtual void CloseView()
        {
            return;
        }

        /// <summary>
        /// 刷新页面。
        /// </summary>
        /// <param name="dataObj"></param>
        public virtual void RefreshView(object dataObj)
        {
            return;
        }

        /// <summary>
        /// 页面关联到Presenter的方法。
        /// </summary>
        /// <param name="source"></param>
        public void ApplyPresenter(IPresenter source)
        {
            this.CurrentPresenter = source;
            this.OnPresenterApplied(source);
        }

        /// <summary>
        /// 初始化通过依赖注入初始化数据：在此方法中解决循环依赖问题。
        /// </summary>
        public void InitDependencyData()
        {
            this.InternalInitData();
        }
        #endregion

        #region Protected Methods
        /// <summary>
        /// 内部可重写的页面关联到Presenter的方法。
        /// </summary>
        /// <param name="source"></param>
        protected virtual void OnPresenterApplied(IPresenter source)
        {
        }

        /// <summary>
        /// 初始化页面所需的数据：在此方法中解决循环依赖问题。
        /// </summary>
        protected virtual void InternalInitData()
        {
        }

        /// <summary>
        /// 改变UI风格。
        /// </summary>
        /// <param name="uiStyle"></param>
        protected virtual void ChangeUIStyle(eStyle uiStyle)
        {
            PrepareBeforeChangeUIStyle(uiStyle);
            if (StyleManager.IsMetro(uiStyle))
            {
                StyleManager.Style = uiStyle;
            }
            else
            {
                StyleManager.ChangeStyle(uiStyle, Color.Empty);
            }
        }

        /// <summary>
        /// 改变界面风格前的准备工作。
        /// </summary>
        /// <param name="uiStyle"></param>
        protected virtual void PrepareBeforeChangeUIStyle(eStyle uiStyle)
        {
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (this.CurrentPresenter != null)
            {
                this.CurrentPresenter.HandleLoadView();
            }
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            if (this.CurrentPresenter != null)
            {
                this.CurrentPresenter.HandleClosedView();
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            if (this.CurrentPresenter != null)
            {
                ClosingEventArgs closingArg = this.CreateClosingEventArgs(e);
                this.CurrentPresenter.HandleClosingView(closingArg);
                e.Cancel = closingArg.Cancel;
            }
        }

        /// <summary>
        /// 初始化 ClosingEventArgs 类的新实例。
        /// </summary>
        /// <param name="e">View界面传入的参数。</param>
        protected virtual ClosingEventArgs CreateClosingEventArgs(CancelEventArgs e)
        {
            ClosingEventArgs closingArg = new Model.ClosingEventArgs(e.Cancel, false);
            return closingArg;
        }
        #endregion
    }
}