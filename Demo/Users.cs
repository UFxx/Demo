using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Users
    {
        public int ID_user;
        public string Surname;
        public string Name;
        public string Patronymic;
        public char Sex;
        public string Birthday;
        public int PassportSeries;
        public int PassportNumber;
        public string Phone;
        public string Password;
        public string Login;

        // Первый конструктор
        public Users
            (
                int id_user,
                string surnname,
                string name,
                string patronymic,
                char sex,
                string birthday,
                int passportseries,
                int passportnumber,
                string phone,
                string password,
                string login
            )
            {
                ID_user = id_user;
                Surname = surnname;
                Name = name;
                Patronymic = patronymic;
                Sex = sex;
                Birthday = birthday;
                PassportSeries = passportseries;
                PassportNumber = passportnumber;
                Phone = phone;
                Password = password;
                Login = login;
            }

        // Второй конструктор
        public Users (string password, string login) { Password = password; Login = login; }
    }
}
