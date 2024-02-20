using examplemvcwindowsform.Controllers;
using examplemvcwindowsform.Services.Contract;
using examplemvcwindowsform.Services;
using examplemvcwindowsform.Views;
using Microsoft.Extensions.DependencyInjection;

namespace examplemvcwindowsform
{
    static class Program
    {
     
            [STAThread]
            static void Main()
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                // Configura��o do servi�o e inje��o de depend�ncia
                var serviceProvider = ConfigureServices();

                // Resolu��o do formul�rio principal e execu��o da aplica��o
                using (var loginForm = serviceProvider.GetRequiredService<LoginForm>())
                {
                    Application.Run(loginForm);
                }
            }

            private static IServiceProvider ConfigureServices()
            {
                var services = new ServiceCollection();

                // Registro de servi�os e implementa��es no container DI
                services.AddTransient<IAuthService, AuthService>();
                services.AddTransient<LoginController>();
                // Registro do formul�rio principal no container DI
                services.AddTransient<LoginForm>();

                // Configura��o do container e constru��o do provedor de servi�os
                return services.BuildServiceProvider();
            }
        }
    }
