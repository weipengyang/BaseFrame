using BaseFrame.Interface;
using BaseFrame.Model;
using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BaseFrame.MultiDocView
{
    /// <summary>
    /// 多文档窗体基类。
    /// </summary>
    public class BaseMultiDocForm : DevComponents.DotNetBar.RibbonForm, IMultiDocView, IView, IDependencyService
    {
        #region Fields
        #endregion

        #region Constructor
        /// <summary>
        /// 创建多文档窗体。
        /// </summary>
        public BaseMultiDocForm()
        {
            this.IsMdiContainer = true;
            StyleManager.Style = eStyle.Office2016;
            this.KeyPreview = true;
        }
        #endregion

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

        /// <summary>
        /// 代表当前App的主窗体，一般只用于设置弹出框的归属。
        /// The main window as IWin32Window.
        /// </summary>
        public virtual IWin32Window MainWin32Window
        {
            get
            {
                return this;
            }
        }

        /// <summary>
        /// 提供同步或异步执行委托的方法：一般只用于操作界面元素。
        /// </summary>
        public virtual ISynchronizeInvoke SynchronizingObject
        {
            get
            {
                return this;
            }
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

        /// <summary>
        /// 改变当前界面：显示指定的View界面。
        /// </summary>
        /// <param name="view">需要显示的View界面。</param>
        public void ChangeView(IView view)
        {
            BaseForm currForm = view as BaseForm;
            ChangeView(currForm);
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

        #region Private Methods
        private void ChangeView(BaseForm currForm)
        {
            if (this.ActiveMdiChild != null)
            {
                //防止ActiveControl失去焦点后，自动激活父窗体，导致页面自动被切换到ActiveControl的父窗体。
                this.ActiveMdiChild.ActiveControl = null;
            }
            currForm.MdiParent = this;
            currForm.WindowState = FormWindowState.Maximized;
            currForm.Show();
            currForm.Update();
        }

        /// <summary>
        /// 选中主窗体Header头部的指定Tab页面。
        /// </summary>
        /// <param name="currRibbonTabItem"></param>
        private void SelectRibbonTabItem(RibbonTabItem currRibbonTabItem)
        {
            if (!currRibbonTabItem.Checked)
            {
                currRibbonTabItem.Checked = true;
            }
        }
        #endregion
    }
}
