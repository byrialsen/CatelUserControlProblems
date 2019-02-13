using System.Threading.Tasks;
using Catel;
using Catel.MVVM;

namespace CatelTest.Uwp.Ui.ViewModels
{
    public class PersonControlViewModel : ViewModelBase
    {
        private readonly ICommandManager _commandManager;

        public string FirstNames { get; set; }
        public string LastNames { get; set; }

        public PersonControlViewModel(ICommandManager commandManager)
        {
            Argument.IsNotNull(() => commandManager);

            _commandManager = commandManager;


            FirstNames = "Paw Hauge";
            LastNames = "Byrialsen";

            TestCommand = new Command(
                () =>
                {
                    System.Diagnostics.Debug.WriteLine($"{FirstNames} {LastNames}");
                });

            _commandManager.RegisterCommand("TestCommand", TestCommand);
        }

        public Command TestCommand { get; set; }

        protected override Task InitializeAsync()
        {
            return base.InitializeAsync();
        }
    }
}
