using System;
using BaseFrame.Interface;
using DevComponents.DotNetBar;
using System.Drawing;
using System.ComponentModel;
using BaseFrame.Model;

namespace BaseFrame.MultiDocView
{
    /// <summary>
    /// MVPģʽ������View���࣬ʵ���� IView �ӿڣ������˽���Ļ����ṹ��
    /// </summary>
    public partial class BaseForm : DevComponents.DotNetBar.OfficeForm, IView, IDependencyService
    {
        #region Properties
        private IPresenter currentPresenter;

        /// <summary>
        /// ��ǰView��������Presenter��
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
        /// ��ʾҳ�档
        /// </summary>
        public virtual void ShowView()
        {
            return;
        }

        /// <summary>
        /// �ر�ҳ�档
        /// </summary>
        public virtual void CloseView()
        {
            return;
        }

        /// <summary>
        /// ˢ��ҳ�档
        /// </summary>
        /// <param name="dataObj"></param>
        public virtual void RefreshView(object dataObj)
        {
            return;
        }

        /// <summary>
        /// ҳ�������Presenter�ķ�����
        /// </summary>
        /// <param name="source"></param>
        public void ApplyPresenter(IPresenter source)
        {
            this.CurrentPresenter = source;
            this.OnPresenterApplied(source);
        }

        /// <summary>
        /// ��ʼ��ͨ������ע���ʼ�����ݣ��ڴ˷����н��ѭ���������⡣
        /// </summary>
        public void InitDependencyData()
        {
            this.InternalInitData();
        }
        #endregion

        #region Protected Methods
        /// <summary>
        /// �ڲ�����д��ҳ�������Presenter�ķ�����
        /// </summary>
        /// <param name="source"></param>
        protected virtual void OnPresenterApplied(IPresenter source)
        {
        }

        /// <summary>
        /// ��ʼ��ҳ����������ݣ��ڴ˷����н��ѭ���������⡣
        /// </summary>
        protected virtual void InternalInitData()
        {
        }

        /// <summary>
        /// �ı�UI���
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
        /// �ı������ǰ��׼��������
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
        /// ��ʼ�� ClosingEventArgs �����ʵ����
        /// </summary>
        /// <param name="e">View���洫��Ĳ�����</param>
        protected virtual ClosingEventArgs CreateClosingEventArgs(CancelEventArgs e)
        {
            ClosingEventArgs closingArg = new Model.ClosingEventArgs(e.Cancel, false);
            return closingArg;
        }
        #endregion
    }
}