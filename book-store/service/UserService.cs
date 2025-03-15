using book_store.context;
using book_store.database.entity;
using book_store.database.repository;
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
        private readonly UserRepository userRepository = new UserRepository(AppDbContext.INSTANCE);

        public async Task AuthenticateAsync(string username, string password)
        {
            var user = await userRepository.FindByUsernameAsync(username);

            if (user == null)
            {
                throw new EntityNotFoundException($"Пользователь с username {username} не найден.");
            }

            // Проверка пароля
            if (!PasswordEncoder.Matches(password, user.Password))
            {
                throw new AuthenticationException("Неправильный пароль.");
            }

            SecurityContext.Authentication = user;
        }

        public async Task CreateUser(string username, string password, string email, string address)
        {
            var byUsername = await userRepository.FindByUsernameAsync(username);
            if (byUsername != null)
            {
                throw new ArgumentException($"пользователь с username {username} уже существует");
            }
            var byEmail = await userRepository.FindByEmailAsync(email);
            if (byEmail != null)
            {
                throw new ArgumentException($"полльзователь с email {email} уже существует");
            }
            string encodedPassword = PasswordEncoder.Encode(password);
            User user = new User
            {
                Username = username,
                Password = PasswordEncoder.Encode(password),
                Email = email,
                Address = address,
                Role = "user"
            };
            await userRepository.AddAsync(user);
        }
    }
}
