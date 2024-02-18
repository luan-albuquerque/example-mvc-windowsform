using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPFlow.Models;
using TPFlow.Services.Contract;

namespace TPFlow.Controllers
{
    public class LoginController
    {
        private readonly IAuthService _authService;

        public LoginController(IAuthService authService)
        {
            _authService = authService;
        }

        public bool TryLogin(User user)
        {
            return _authService.AuthenticateUser(user);
        }
    }
}
