using book_store.context;
using book_store.dao;
using book_store.entity;
using book_store.exception;
using book_store.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_store.service
{
    internal class UserService
    {
        private readonly UserDao userDao = new UserDao();

        public void Authenticate(string username, string password)
        {
            User user = userDao.FindByUsername(username);
            if(user != null)
            {
                if(PasswordEncoder.Matches(password, user.Password))
                {
                    SecurityContext.authentication = user;
                } else
                {
                    throw new AuthenticationException("неправильный пароль");
                }
            } else
            {
                throw new EntityNotFoundException($"пользователь с username {username} не найден");
            }
        }

        public void CreateUser(string username, string password, string email, string address)
        {
            User byUsername = userDao.FindByUsername(username);
            if(byUsername != null)
            {
                throw new ArgumentException($"пользователь с username {username} уже существует");
            }
            User byEmail = userDao.FindByEmail(email);
            if(byEmail != null)
            {
                throw new ArgumentException($"полльзователь с email {email} уже существует");
            }
            string encodedPassword = PasswordEncoder.Encode(password);
            userDao.Create(username, encodedPassword, email, address);
        }
    }
}
