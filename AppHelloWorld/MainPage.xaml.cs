namespace AppHelloWorld
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Cadastrar_Clicked(object sender, EventArgs e)
        {
            DisplayAlertAsync("Cadastro de Usuário", "Cadastro realizado com SUCESSO!", "Ok!");
        }
    }
}
