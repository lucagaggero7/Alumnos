using Alumnos_BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Alumnos_BE
{
    public class Alumnos
    {
        //Creamos nuestra lista para la data table
        public DataTable ListaDT { get; set; } = new DataTable();

        //Crea la Estructura de la Lista de alumnos
        //
        public Alumnos()
        {
            ListaDT.TableName = "ListaUsuarios";
            ListaDT.Columns.Add("Nombre");
            ListaDT.Columns.Add("Apellido");
            ListaDT.Columns.Add("Dni");
            ListaDT.Columns.Add("Fecha");
            ListaDT.Columns.Add("Asistencia");

            LeerArchivo();
        }

        //Lee el archivo Alumnos.xml si es que este existe
        //
        public void LeerArchivo()
        {
            if (System.IO.File.Exists("Alumnos.xml"))
            {
                ListaDT.ReadXml("Alumnos.xml");
            }
        }

        // Inserta un nuevo alumno en la lista de alumnos y luego escribe esta lista en el archivo Alumnos.xml
        //
        public void InsertAlumno(Alumno aAlumno)
        {
            ListaDT.Rows.Add(); //agrego renglon vacio
            int NuevoRenglon = ListaDT.Rows.Count - 1;
            ListaDT.Rows[NuevoRenglon]["Nombre"] = aAlumno.Nombre;
            ListaDT.Rows[NuevoRenglon]["Apellido"] = aAlumno.Apellido;
            ListaDT.Rows[NuevoRenglon]["Dni"] = aAlumno.Dni;
            ListaDT.Rows[NuevoRenglon]["Fecha"] = aAlumno.Fecha;
            ListaDT.Rows[NuevoRenglon]["Asistencia"] = aAlumno.Asistencia;

            ListaDT.WriteXml("Alumnos.xml");
        }



    }
}
