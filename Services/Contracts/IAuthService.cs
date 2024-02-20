using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using examplemvcwindowsform.Models;

namespace examplemvcwindowsform.Services.Contract
{
    public interface IAuthService
    {
        bool AuthenticateUser(User user);
    }
}
