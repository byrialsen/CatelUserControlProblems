using Catel.Data;

namespace CatelTest.Uwp.Ui.Models
{
    public class Person : SavableModelBase<Person>
    {
        public string FirstName { get; set; }
        public string Surnames { get; set; }
        public int Age { get; set; }
    }
}
