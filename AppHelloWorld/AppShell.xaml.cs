using AppHelloWorld.Views;

namespace AppHelloWorld
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeRouting();
            InitializeComponent();
        }

        public static void InitializeRouting()
        {
            Routing.RegisterRoute("cadastro", typeof(CadastroView));
          
        }
    }
}
