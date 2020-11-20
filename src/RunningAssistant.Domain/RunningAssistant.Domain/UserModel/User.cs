﻿using System;

namespace RunningAssistant.Domain.UserModel
{
    public class User
    {
        public User(
            string surname
            , string name
            , bool gender
            , string patronymic = "")
        {
            Surname = surname;
            Name = name;
            Gender = gender;
            Patronymic = patronymic;
        }

        public string Surname { get; private set; }
        public string Name { get; private set; }
        public string Patronymic { get; private set; }
        public string Login { get; private set; }
        public string Password { get; private set; }
        public bool Gender { get; private set; }

        public void SetLogin(string login)
        {
            if (String.IsNullOrEmpty(login))
            {
                throw new ArgumentException("login cannot be empty");
            }
            Login = login;
        }

        public void SetPassword(string password)
        {
            if (String.IsNullOrEmpty(password))
            {
                throw new ArgumentException("login cannot be empty");
            }
            Password = password;
        }
    }
}