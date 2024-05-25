using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumnos_BE
{
    //Esta clase tiene las propiedades de cada alumno
    //
    public class Student
    {
        //Creamos variables publicas para las propiedades de cada alumno
        //
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Id_Number { get; set; }
        public string Date { get; set; }
        public bool Assistance { get; set; }

        //Este metodo es llamado desde el formulario de carga y agrega a la instancia
        //actual del alumno todos los argumentos que corresponden a las propiedades del alumno
        //
        public void Insert(string aName,
                       string aSurname,
                       string aId_Number,
                       string aDate,
                       bool aAssistance)
        {
            Name = aName;
            Surname = aSurname;
            Id_Number = aId_Number;
            Date = aDate;
            Assistance = aAssistance;
        }

    }
}
