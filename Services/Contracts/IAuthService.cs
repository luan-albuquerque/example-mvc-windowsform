using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPFlow.Models;

namespace TPFlow.Services.Contract
{
    public interface IAuthService
    {
        bool AuthenticateUser(User user);
    }
}
