using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.ConsoleApp
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }


        //Login Service

        //public void Login()
        //{
        //    //Logic
        //    string username = this.Username;
        //    string password = this.Password;
        //}

        //public void Logout()
        //{
        //    //Logic
        //    string username = this.Username;
        //}

        //public bool MailValidation()
        //{
        //    //Logic

        //    if (this.Email == null)
        //        return false;

        //    return true;
        //}
    }

    public class MailValidator
    {
        public bool Validate(string email)
        {
            //Sadece Gmail olanları doğrula

            if (email == null)
                return false;

            return true;
        }
    }

    public class AccountService
    {
        private MailValidator _mailValidator;

        public AccountService(MailValidator mailValidator)
        {
            _mailValidator = mailValidator;
        }

        public void Register(User user)
        {
            //Logic User kayıt işlemi

            if (_mailValidator.Validate(user.Email))
            {
                //Kayıt yapılabilir.
            }
            else
            {
                //Mail doğru değil kayıt yapılmadı.
            }

        }

        public void Login(User user)
        {
            //Logic
            string username = user.Username;
            string password = user.Password;
        }

        public void Logout(User user)
        {
            //Logic
            string username = user.Username;
        }


        public void Login(string username, string password)
        {
            //Logic
            string _username = username;
            string _password = password;
        }

        public void Logout(string username)
        {
            //Logic
            string _username = username;
        }
    }
}
