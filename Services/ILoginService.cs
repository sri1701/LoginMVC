using LoginMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginMVC.Services
{
    public interface ILoginService
    {
        public void Login(LoginModel model);

        public IEnumerable<LoginModel> GetUsers();
    }
}
