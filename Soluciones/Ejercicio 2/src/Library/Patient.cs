using System;

namespace Library
{
    public class Patient
    {
        public string name { get ; set; }
        public string id { get ; set; }
        public string phoneNumber { get ;  set; }
        public string age { get ; set; }
        public string address { get ; set; }
        public string mail { get ; set; }

        public Patient(String name, String id, String phoneNumber, String age, String address, String mail)
        {
            this.Name = name;
            this.Id = id;
            this.PhoneNumber = phoneNumber;
            this.Age = age;
            this.Address = specialization;
            this.Mail = mail;
        }
    }
}