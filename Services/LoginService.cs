using LoginMVC.Models;
using LoginMVC.Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginMVC.Services
{
    public class LoginService : ILoginService
    {

        private LoginContext _context;

        public LoginService(LoginContext context)
        {
            _context = context;
        }
        public void Login(Models.LoginModel model)
        {
            try
            {
                using (_context)
                {
                    LoginDataModel data = new LoginDataModel()
                    {
                        UserName = model.UserName
                    };

                    _context.Add(data);
                    _context.SaveChanges();
                }
            }
            catch(Exception ex)
            {
                //Handle Exceptions
            }
        }

        public IEnumerable<LoginModel> GetUsers()
        {
            try
            {
                using (_context)
                {
                    var users = _context.LoginInfo.Select(x => new LoginModel()
                    {
                        UserName = x.UserName
                    }).ToArray();

                    return users;
                }
            }
            catch (Exception ex)
            {
                //Handle Exceptions
            }
            return null;
        }
    }
}
