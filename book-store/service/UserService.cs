using book_store.context;
using book_store.database.entity;
using book_store.database.repository;
using book_store.exception;
using book_store.util;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_store.service
{
    internal class UserService
    {
        private readonly ImageService imageService = new ImageService();
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
            await userRepository.CreateAsync(user);
        }

        public async Task UpdateUser(string username, string currentPassword, string newPassword, string email, string address, string? fileName)
        {
            var user = await userRepository.FindByIdAsync(SecurityContext.Authentication.Id);
            if(!user.Username.Equals(username))
            {
                var byUsername = await userRepository.FindByUsernameAsync(username);
                if (byUsername != null)
                {
                    throw new ArgumentException($"пользователь с username {username} уже существует");
                }
            }
            if(!user.Email.Equals(email))
            {
                var byEmail = await userRepository.FindByEmailAsync(email);
                if (byEmail != null)
                {
                    throw new ArgumentException($"полльзователь с email {email} уже существует");
                }
            }

            if(!currentPassword.Equals("") || !newPassword.Equals(""))
            {
                if (!PasswordEncoder.Matches(currentPassword, user.Password))
                {
                    throw new AuthenticationException($"Введённый текущий пароль неверный");
                } else
                {
                    user.Password = PasswordEncoder.Encode(newPassword);
                }
            }

            user.Username = username;
            
            user.Email = email;
            user.Address = address;
            if(fileName != null)
            {
                string savePath = imageService.SaveImage(fileName);
                user.ImagePath = savePath;
            }
            await userRepository.UpdateAsync(user);
            SecurityContext.Authentication = user;
        }

        public async Task DeleteProfile(string password)
        {
            if(!PasswordEncoder.Matches(password, SecurityContext.Authentication.Password))
            {
                throw new AuthenticationException("Неверный пароль от учётной записи");
            }
            string imagePath = SecurityContext.Authentication.ImagePath;
            if (imagePath != null)
            {
                imageService.DeleteImage(imagePath);
            }
            await userRepository.DeleteByIdAsync(SecurityContext.Authentication.Id);
            SecurityContext.Authentication = null;
        }
    }
}
