using CatelTest.Uwp.Ui.ViewModels;

namespace CatelTest.Uwp.Ui.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PersonView : Catel.Windows.Controls.Page
    {
        public PersonViewModel VM { get => DataContext as PersonViewModel; } 

        public PersonView()
        {
            this.InitializeComponent();
        }
    }
}
