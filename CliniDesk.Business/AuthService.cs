using CliniDesk.Data;
using CliniDesk.Entity;
using CliniDesk.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CliniDesk.Business
{
    public class AuthService
    {   
        private readonly RepositoryUser repository;
        private readonly SecurityService security;
        private readonly JwtService jwt;
        public AuthService(RepositoryUser repository, SecurityService security, JwtService jwt)
        {
            this.repository = repository;
            this.security = security;
            this.jwt = jwt;
        }

        public string Login(string username, string password)
        {
            User user = repository.GetByUsername(username);

            if (user == null || !security.VerifyPassword(password, user.PasswordHash))
                throw new InvalidCredentialsException("Invalid credentials");

            string token = jwt.GenerateToken(user.Username);

            return token;
        }

        public User Register(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                throw new ValidationException("The username is required");
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                throw new ValidationException("The password is required");
            }

            User existingUser = repository.GetByUsername(username);

            if (existingUser != null)
                throw new UserAlreadyExistsException("The user already exists");
                

            string hash = security.HashPassword(password);

            User user = new User
            {
                Username = username,
                PasswordHash = hash
            };

            repository.Save(user);



            return user;
        }
    }
}