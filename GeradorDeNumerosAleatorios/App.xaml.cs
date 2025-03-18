namespace GeradorDeNumerosAleatorios
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent(); //Leia o XAML e carregue os componentes

            MainPage = new AppShell();
        }
    }
}
