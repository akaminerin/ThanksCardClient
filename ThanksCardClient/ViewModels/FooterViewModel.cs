#nullable disable
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThanksCardClient.Models;
using ThanksCardClient.Services;

namespace ThanksCardClient.ViewModels
{
    public class FooterViewModel : BindableBase
    {
        private readonly IRegionManager regionManager;

        private User _AuthorizedUser;
        public User AuthorizedUser
        {
            get { return _AuthorizedUser; }
            set { SetProperty(ref _AuthorizedUser, value); }
        }

        public FooterViewModel(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
            this.AuthorizedUser = SessionService.Instance.AuthorizedUser;
        }

        #region ShowThanksCardCreateCommand
        private DelegateCommand _ShowThanksCardCreateCommand;
        public DelegateCommand ShowThanksCardCreateCommand =>
            _ShowThanksCardCreateCommand ?? (_ShowThanksCardCreateCommand = new DelegateCommand(ExecuteShowThanksCardCreateCommand));

        void ExecuteShowThanksCardCreateCommand()
        {
            this.regionManager.Regions["FooterRegion"].RemoveAll();
            this.regionManager.RequestNavigate("FooterRegion", nameof(Views.ThanksCardCreate));
        }
        #endregion

        #region ShowThanksCardListCommand
        private DelegateCommand _ShowThanksCardListCommand;
        public DelegateCommand ShowThanksCardListCommand =>
            _ShowThanksCardListCommand ?? (_ShowThanksCardListCommand = new DelegateCommand(ExecuteShowThanksCardListCommand));

        void ExecuteShowThanksCardListCommand()
        {
            this.regionManager.Regions["FooterRegion"].RemoveAll();
            this.regionManager.RequestNavigate("FooterRegion", nameof(Views.ThanksCardList));
        }
        #endregion

        #region ShowDepartmentMstCommand
        private DelegateCommand _ShowDepartmentMstCommand;
        public DelegateCommand ShowDepartmentMstCommand =>
            _ShowDepartmentMstCommand ?? (_ShowDepartmentMstCommand = new DelegateCommand(ExecuteShowDepartmentMstCommand));

        void ExecuteShowDepartmentMstCommand()
        {
            this.regionManager.Regions["FooterRegion"].RemoveAll();
            this.regionManager.RequestNavigate("FooterRegion", nameof(Views.DepartmentMst));
        }
        #endregion

        #region ShowTagMstCommand
        private DelegateCommand _ShowTagMstCommand;
        public DelegateCommand ShowTagMstCommand =>
            _ShowTagMstCommand ?? (_ShowTagMstCommand = new DelegateCommand(ExecuteShowTagMstCommand));

        void ExecuteShowTagMstCommand()
        {
            this.regionManager.Regions["FooterRegion"].RemoveAll();
            this.regionManager.RequestNavigate("FooterRegion", nameof(Views.TagMst));
        }
        #endregion

        #region ShowkeijibanCommand
        private DelegateCommand _ShowkeijibanCommand;
        public DelegateCommand ShowkeijibanCommand =>
            _ShowkeijibanCommand ?? (_ShowkeijibanCommand = new DelegateCommand(ExecuteShowkeijibanCommand));

        void ExecuteShowkeijibanCommand()
        {
            this.regionManager.Regions["FooterRegion"].RemoveAll();
            this.regionManager.RequestNavigate("FooterRegion", nameof(Views.Keijiban));
        }
        #endregion

        #region LogoffCommand
        private DelegateCommand _logoffCommand;
        public DelegateCommand LogoffCommand =>
            _logoffCommand ?? (_logoffCommand = new DelegateCommand(ExecuteLogoffCommand));

        void ExecuteLogoffCommand()
        {
            SessionService.Instance.AuthorizedUser = null;
            SessionService.Instance.IsAuthorized = false;

            // HeaderRegion, FooterRegion を破棄して、FooterRegion をログオン画面に遷移させる。
            this.regionManager.Regions["FooterRegion"].RemoveAll();
            this.regionManager.RequestNavigate("FooterRegion", nameof(Views.Logon));
        }
        #endregion

        #region ShowMVPCommand
        private DelegateCommand _ShowMVPCommand;
        public DelegateCommand ShowMVPCommand =>
            _ShowMVPCommand ?? (_ShowMVPCommand = new DelegateCommand(ExecuteShowMVPCommand));

        void ExecuteShowMVPCommand()
        {
            this.regionManager.Regions["FooterRegion"].RemoveAll();
            this.regionManager.RequestNavigate("FooterRegion", nameof(Views.Mvp));
        }
        #endregion

        #region ShowmanualCommand
        private DelegateCommand _ShowmanualCommand;
        public DelegateCommand ShowmanualCommand =>
            _ShowmanualCommand ?? (_ShowmanualCommand = new DelegateCommand(ExecuteShowmanualCommand));

        void ExecuteShowmanualCommand()
        {
            this.regionManager.Regions["FooterRegion"].RemoveAll();

        //    this.regionManager.RequestNavigate("FooterRegion", nameof(Views.Manual));

        }
        #endregion

        #region ShowregistrationscreenCommand
        private DelegateCommand _ShowregistrationscreenCommand;
        public DelegateCommand ShowregistrationscreenCommand =>
            _ShowregistrationscreenCommand ?? (_ShowregistrationscreenCommand = new DelegateCommand(ExecuteShowregistrationscreenCommand));

        void ExecuteShowregistrationscreenCommand()
        {
            this.regionManager.Regions["FooterRegion"].RemoveAll();
            this.regionManager.RequestNavigate("FooterRegion", nameof(Views.RegistrationScreen));
        }
        #endregion

    }
}
