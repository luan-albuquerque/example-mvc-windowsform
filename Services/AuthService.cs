using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using examplemvcwindowsform.Models;
using examplemvcwindowsform.Services.Contract;

namespace examplemvcwindowsform.Services
{

    // AuthService.cs
    public class AuthService : IAuthService
    {
        public bool AuthenticateUser(User user)
        {
            // Lógica de autenticação (simplificada para o exemplo)
            return user.Username == "admin" && user.Password == "password";
        }
    }

}
