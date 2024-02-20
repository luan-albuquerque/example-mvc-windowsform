using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using examplemvcwindowsform.Models;
using examplemvcwindowsform.Services.Contract;

namespace examplemvcwindowsform.Controllers
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
