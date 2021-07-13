using LoginMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginMVC.Services
{
    public interface ILoginService
    {
        /// <summary>
        /// Logs In the user and saves to Database
        /// </summary>
        /// <param name="model"></param>
        public void Login(LoginModel model);

        /// <summary>
        /// Get the list of Logged in users
        /// </summary>
        /// <returns></returns>
        public IEnumerable<LoginModel> GetUsers();
    }
}
