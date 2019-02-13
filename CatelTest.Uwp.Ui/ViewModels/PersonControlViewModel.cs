using System.Threading.Tasks;
using Catel.MVVM;

namespace CatelTest.Uwp.Ui.ViewModels
{
    public class PersonControlViewModel : ViewModelBase
    {
        public string FirstNames { get; set; }
        public string LastNames { get; set; }

        public PersonControlViewModel()
        {
            TestCommand = new Command(
                () =>
                {
                    System.Diagnostics.Debug.WriteLine($"{FirstNames} {LastNames}");
                });
        }

        public Command TestCommand { get; set; }

        protected override Task InitializeAsync()
        {
            FirstNames = "Paw Hauge";
            LastNames = "Byrialsen";

            return base.InitializeAsync();
        }
    }
}
