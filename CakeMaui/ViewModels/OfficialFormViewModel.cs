using CakeMaui.Models;
using System;

namespace CakeMaui.ViewModels
{
    public class OfficialFormViewModel : ObservableObject
    {
        private OfficialForm _officialForm;

        public OfficialForm OfficialForm
        {
            get { return _officialForm; }
            set
            {
                _officialForm = value;
                OnPropertyChanged(nameof(OfficialForm));
            }
        }

        public OfficialFormViewModel()
        {
            OfficialForm = new OfficialForm();
        }

        public OfficialFormViewModel(OfficialForm officialForm)
        {
            OfficialForm = officialForm;
        }
    }
}
