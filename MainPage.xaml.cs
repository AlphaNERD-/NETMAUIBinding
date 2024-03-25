namespace BindingDemoForGithub
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            this.BindingContext = new ViewModelTest();
        }
    }
}
