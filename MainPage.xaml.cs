using Maui.binding.Models;

namespace Maui.binding
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            var person = new Person()
            {
                Name = "Güven",
                Phone = "1111111111",
                Address = "xxxxxxx"
            };
            Binding personBinding = new();
            personBinding.Source = person;
            personBinding.Path = "Name";
            txtName.SetBinding(Label.TextProperty, personBinding);


        }
    }

}
