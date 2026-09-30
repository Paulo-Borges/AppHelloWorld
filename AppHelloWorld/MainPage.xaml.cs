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
            var nome = NomeCompleto.Text;
            var data = DataNascimento.Date;
            var genero = Genero.SelectedItem;
            var idade = Idade.Text;

            DisplayAlertAsync("Cadastro de Usuário", string.Format("Cadastro do usuario {0} foi realizado com SUCESSO!", nome), "Ok!");
        }

        private void DataNascimento_DateSelected(object sender, DateChangedEventArgs e)
        {
            var dataNascimento = DataNascimento.Date;
            int idade = CalcularIdade(dataNascimento);
            Idade.Text = idade.ToString("D");

        }

        static int CalcularIdade(DateTime? dataNascimento)
        {
            if (!dataNascimento.HasValue)
                return 0; // ou lance exceção, conforme sua regra de negócio

            var dataAtual = DateTime.Today;
            int idade = dataAtual.Year - dataNascimento.Value.Year;

            if (dataAtual < dataNascimento.Value.AddYears(idade))
            {
                idade--;
            }
            return idade;
        }
    }
}
