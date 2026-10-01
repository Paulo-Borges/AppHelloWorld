namespace AppHelloWorld.Views
{
    [QueryProperty(nameof(Route), "route" )]
    public partial class CadastroView : ContentPage
    {
        public string Route { get; set; }
        public const double FontSize14 = 14;

        public CadastroView()
        {
            InitializeComponent();
        }

        private async void Cadastrar_Clicked(object sender, EventArgs e)
        {
            var nome = NomeCompleto.Text;
            var data = DataNascimento.Date;
            var genero = Genero.SelectedItem;
            var idade = Idade.Text;

            await DisplayAlert("Cadastro de Usuário", string.Format("Cadastro do usuario {0} foi realizado com SUCESSO!", nome), "Ok!");

            await Shell.Current.GoToAsync(Route);
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

    public class GlobalFontSizeExtension : IMarkupExtension
    {
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return DeviceInfo.Platform == DevicePlatform.Android ? 18 : CadastroView.FontSize14;
        }
    }
}
