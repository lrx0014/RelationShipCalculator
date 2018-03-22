using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.ApplicationModel;

namespace RelationshipCalculator.ViewModel
{
    public class AboutViewModel : ViewModelBase
    {
        private string versionNumber;

        public AboutViewModel()
        {
            this.versionNumber = string.Empty;
            getVersion();
            this.versionNumber = VersionNumber;
        }

        public string VersionNumber
        {
            get
            {
                return this.versionNumber;
            }
            set
            {
                this.versionNumber = value;
                RaisePropertyChanged("VersionNumber");
            }
        }

        private void getVersion()
        {
            try
            {
                VersionNumber = string.Format("版本:{0}.{1}.{2}.{3}",
                    Package.Current.Id.Version.Major,
                    Package.Current.Id.Version.Minor,
                    Package.Current.Id.Version.Build,
                    Package.Current.Id.Version.Revision);
            }
            catch (Exception e)
            {
                VersionNumber = e.Message;
            }
        }

        public ICommand GetVersionCommand
        {
            get
            {
                return new RelayCommand(getVersion);
            }
        }
    }
}
