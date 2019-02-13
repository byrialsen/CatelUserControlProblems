using Catel;
using Catel.MVVM;
using Catel.Windows.Input;
using Windows.System;

namespace CatelTest.Uwp.Ui.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly ICommandManager _commandManager;

        public MainViewModel(ICommandManager commandManager)
        {
            Argument.IsNotNull(() => commandManager);

            _commandManager = commandManager;

            _commandManager.CreateCommand("TestCommand", new InputGesture(VirtualKey.F5));
        }
    }
}
