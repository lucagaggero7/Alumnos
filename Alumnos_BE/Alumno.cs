using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumnos_BE
{
    //Esta clase tiene las propiedades de cada alumno
    //
    public class Alumno
    {
        //Creamos variables publicas para las propiedades de cada alumno
        //
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }
        public string Fecha { get; set; }
        public bool Asistencia { get; set; }

        //Este metodo es llamado desde el formulario de carga y agrega a la instancia
        //actual del alumno todos los argumentos que corresponden a las propiedades del alumno
        //
        public void Agregar(string aNombre,
                       string aApellido,
                       string aDni,
                       string aFecha,
                       bool aAsistencia)
        {
            Nombre = aNombre;
            Apellido = aApellido;
            Dni = aDni;
            Fecha = aFecha;
            Asistencia = aAsistencia;
        }

    }
}
