using System;

namespace Library
{
    public class Medical
    {
        public string doctorName { get ; set; }
        public string id { get ; set; }
        public string phoneNumber { get ; set; }
        public string specialization { get ; set; }
        public string address { get ; set; }
        public string nameUnderstudy { get ; set; }

        public Medical(String doctorName, String id, String phoneNumber, String specialization, String address, String nameUnderstudy)
        {
            this.DoctorName = doctorName;
            this.Id = id;
            this.PhoneNumber = phoneNumber;
            this.Specialization = specialization;
            this.Address = specialization;
            this.NameUnderstudy = nameUnderstudy;
        }
    }
}
