using Catel.MVVM;
using CatelTest.Uwp.Ui.Models;

namespace CatelTest.Uwp.Ui.ViewModels
{
    public class PersonViewModel : ViewModelBase
    {
        public Command ForceUpdateCommand { get; set; }

        [Model]
        public Person Person { get; set; }

        [ViewModelToModel]
        public string FirstName { get; set; }

        [ViewModelToModel]
        public string Surnames { get; set; }

        /// <summary>
        /// Fullname (calculated property)
        /// </summary>
        public string Fullname
        {
            get { return $"{FirstName} {Surnames}"; }
        }

        public PersonViewModel()
        {
            Person = new Models.Person() { FirstName = "Paw", Surnames = "Hauge Byrialsen", Age = 45 };

            ForceUpdateCommand = new Command(() =>
            {
                RaisePropertyChanged(nameof(Fullname));
            });
        }
    }
}
