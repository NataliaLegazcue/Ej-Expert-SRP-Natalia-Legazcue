using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string appointmentResult = AppointmentService.CreateAppointment("Steven Jhonson", "986782342", "5555-555-555", "Medicina General", "Juncal 245", "Dr Jonh", "Armand Hugon", "12345", "4752845", "25", "Avda artigas 84", "elsol@gmail.com");
            Console.WriteLine(appointmentResult);

            string appointmentResult2 = AppointmentService.CreateAppointment("Ralf Manson", "847502843", "5555-555-555", "Dermatologo", "Queen Street 453", "Dr Juan Perez", "Pedro Soto", "38205", "8503275", "18", "Rambla 482", "pedro@hotmail.com");
            Console.WriteLine(appointmentResult2);
        }
    }
}
