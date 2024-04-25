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
            //ListaDT.Rows[NuevoRenglon]["Asistencia"] = aAlumno.Asistencia;
            //

            //Este if cambia el string de asistencia de True a Presente
            //y de False a Ausente para la facilitacion de lectura del usuario que carga los alumnos
            //
            if (aAlumno.Asistencia == true)
            {
                ListaDT.Rows[NuevoRenglon]["Asistencia"] = "Presente";
            }

            else
            {
                ListaDT.Rows[NuevoRenglon]["Asistencia"] = "Ausente";
            }

            ListaDT.WriteXml("Alumnos.xml");
            //
        }

        //Nuevo metodo que verifica si existe el DNI en la lista de alumnos
        public bool ExisteFechayDNI(Alumnos listaalumnos,
                                    Alumno alumno)
        {
            bool existe = false;
            foreach (DataRow row in listaalumnos.ListaDT.Rows)
            {
                if (alumno.Dni == (row["Dni"].ToString()) && alumno.Fecha == (row["Fecha"].ToString()))
                {
                    existe = true;
                }
            }
            return existe;
        }


        // Metodo propio el cual verifica si en la lista de alumnos existe
        // una fila con los mismos valores de DNI y Fecha 
        // de existir lo borra y envia al front un bool verdadero
        public bool BorrarAlumno(Alumno alumno)
        {
            bool existealumno = false;
            ListaDT.AcceptChanges();
            foreach (DataRow row in ListaDT.Rows)
            {
                if (alumno.Dni == (row["Dni"].ToString()) 
                    && alumno.Fecha == (row["Fecha"].ToString()))
                {
                    row.Delete();
                    ListaDT.WriteXml("Alumnos.xml");
                    existealumno = true;
                }
            }
            return existealumno;

        }
    }
}
