using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseFrame.Interface;
using BaseFrame.Model;
using BaseFrame.MultiDocView;
using BaseFrame.Utility;
using BaseFrame.FrameInterface.ViewInterface;

namespace BaseFrame.Presenter
{
    /// <summary>
    /// 多文档界面相关联的Presenter接口实现。
    /// </summary>
    public class MultiDocFormPresenter : BasePresenter, IMultiDocFormPresenter
    {
        #region Fields
        /// <summary>
        /// 多文档主界面的接口。
        /// </summary>
        private IMultiDocForm multiDocView;
        #endregion

        #region Constructor
        /// <summary>
        /// MVP模式中View页面对应的Presenter：用于后台逻辑处理。
        /// </summary>
        public MultiDocFormPresenter()
        {
        }
        #endregion

        #region Properties

        #endregion

        #region Public Methods
        /// <summary>
        /// 改变当前界面：显示指定的View界面。
        /// </summary>
        /// <param name="view">需要显示的View界面。</param>
        public virtual void ChangeView(IView view)
        {
            this.multiDocView.ChangeView(view);
            return;
        }
        #endregion

        #region Protected Methods
        /// <summary>
        /// 初始化Presenter数据：在此方法中解决循环依赖问题。
        /// </summary>
        protected override void InternalInitData()
        {
            this.multiDocView = ServiceContainer.GetInstance<IMultiDocForm>();
            this.AttachView(this.multiDocView);
        }

        /// <inheritdoc/>
        protected override void OnHandleViewLoaded()
        {
            base.OnHandleViewLoaded();
            this.ChangeView(ServiceContainer.GetInstance<IMsgBoxExampleView>());
        }
        #endregion

        #region Private Methods

        #endregion

        #region CommandHandler

        #endregion

        #region EventHandler

        #endregion
    }
}
