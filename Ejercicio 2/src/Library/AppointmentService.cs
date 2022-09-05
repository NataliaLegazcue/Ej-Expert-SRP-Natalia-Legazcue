using System;
using System.Text;

namespace Library
{
    /*
En una misma clase se ingresan los datos del médico, se lo válida he ingresa los datos del 
paciente, no hay nada específicamnte para el paciente (método, clase). Debe haber una clase experta en los datos 
del paciente, donde se ingresen y actualicen, validen, y haga un listado de pacientes, principio Expert, 
otra clase que conozca los datos de los médicos (donde se ingresen y actualicen) y los valide que estén 
completos(Expert) y lleve un listado de médicos y una tercera clase que vincule al listado de pacientes 
con el listado de médicos y le asigne una consulta según un criterio de códigos 
(código de médico + código de horario + número de paciente según orden de llegada)
De esta forma estaríamos cumpliendo el principio Expert (se le asigna la responsabilidad al experto en 
información, a la clase que tiene la información necesaria para poder cumplir con la responsabilidad) y 
SRP (no hay más de un motivo para que una clase cambie).
*/
    public class AppointmentService
    {
        public static string CreateAppointment(string name, string id, string phoneNumber, DateTime date, string appoinmentPlace, string doctorName)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;

            if (string.IsNullOrEmpty(name))
            {
                stringBuilder.Append("Unable to schedule appointment, 'name' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(id))
            {
                stringBuilder.Append("Unable to schedule appointment, 'id' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(phoneNumber))
            {
                stringBuilder.Append("Unable to schedule appointment, 'phone number' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(appoinmentPlace))
            {
                stringBuilder.Append("Unable to schedule appointment, 'appoinment place' is required\n");
                isValid = false;
            }


            if (string.IsNullOrEmpty(doctorName))
            {
                stringBuilder.Append("Unable to schedule appointment, 'doctor name' is required\n");
                isValid = false;
            }

            if (isValid)
            {
                stringBuilder.Append("Appoinment scheduled");
            }

            return stringBuilder.ToString();
        }

    }
}
