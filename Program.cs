using TPFlow.Controllers;
using TPFlow.Services.Contract;
using TPFlow.Services;
using TPFlow.Views;
using Microsoft.Extensions.DependencyInjection;

namespace TPFlow
{
    static class Program
    {
     
            [STAThread]
            static void Main()
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                // Configuração do serviço e injeção de dependência
                var serviceProvider = ConfigureServices();

                // Resolução do formulário principal e execução da aplicação
                using (var loginForm = serviceProvider.GetRequiredService<LoginForm>())
                {
                    Application.Run(loginForm);
                }
            }

            private static IServiceProvider ConfigureServices()
            {
                var services = new ServiceCollection();

                // Registro de serviços e implementações no container DI
                services.AddTransient<IAuthService, AuthService>();
                services.AddTransient<LoginController>();
                // Registro do formulário principal no container DI
                services.AddTransient<LoginForm>();

                // Configuração do container e construção do provedor de serviços
                return services.BuildServiceProvider();
            }
        }
    }
