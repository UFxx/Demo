using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class AgencyWorker
    {
        public int ID_worker;
        public string Surname;
        public string Name;
        public string Patronymic;
        public char Sex;
        public string Birthday;
        public int PassportSeries;
        public int PassportNumber;
        public string Phone;
        public int WorkExperience;
        public string Password;
        public string Login;

        // Первый конструктор
        public AgencyWorker
            (
                int id_worker, 
                string surnname, 
                string name,
                string patronymic, 
                char sex, 
                string birthday,
                int passportseries,
                int passportnumber,
                string phone,
                int workexperience,
                string password,
                string login
            ) 
            {
                ID_worker = id_worker;
                Surname = surnname;
                Name = name;
                Patronymic = patronymic;
                Sex = sex;
                Birthday = birthday;
                PassportSeries = passportseries;
                PassportNumber = passportnumber;
                Phone = phone;
                WorkExperience = workexperience;
                Password = password;
                Login = login;
            }

        // Второй конструктор
        public AgencyWorker (string password,string login) {Password = password;Login = login;}
    }
}
