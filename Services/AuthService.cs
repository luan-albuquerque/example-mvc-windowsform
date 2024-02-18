using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPFlow.Models;
using TPFlow.Services.Contract;

namespace TPFlow.Services
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
