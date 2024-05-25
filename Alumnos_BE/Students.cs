using Alumnos_BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Alumnos_BE
{
    public class Students
    {

        //Creamos nuestra lista para la data table
        public DataTable ListaDT { get; set; } = new DataTable();

        //Crea la Estructura de la Lista de alumnos
        //
        public Students()
        {
            ListaDT.TableName = "StudentsList";
            ListaDT.Columns.Add("Name");
            ListaDT.Columns.Add("Surname");
            ListaDT.Columns.Add("Id Number");
            ListaDT.Columns.Add("Date");
            ListaDT.Columns.Add("Assistance");

            ReadFile();
        }

        //Lee el archivo Alumnos.xml si es que este existe
        //
        public void ReadFile()
        {
            if (System.IO.File.Exists("Students.xml"))
            {
                ListaDT.ReadXml("Students.xml");
            }
        }

        // Inserta un nuevo alumno en la lista de alumnos y luego escribe esta lista en el archivo Alumnos.xml
        //
        public void Load(Student aStudent)
        {
            ListaDT.Rows.Add(); //agrego renglon vacio
            int NuevoRenglon = ListaDT.Rows.Count - 1;
            ListaDT.Rows[NuevoRenglon]["Name"] = aStudent.Name;
            ListaDT.Rows[NuevoRenglon]["Surname"] = aStudent.Surname;
            ListaDT.Rows[NuevoRenglon]["Id Number"] = aStudent.Id_Number;
            ListaDT.Rows[NuevoRenglon]["Date"] = aStudent.Date;
            //ListaDT.Rows[NuevoRenglon]["Asistencia"] = aAlumno.Asistencia;
            //

            //Este if cambia el string de asistencia de True a Presente
            //y de False a Ausente para la facilitacion de lectura del usuario que carga los alumnos
            //
            if (aStudent.Assistance == true)
            {
                ListaDT.Rows[NuevoRenglon]["Assistance"] = "P";
            }

            else
            {
                ListaDT.Rows[NuevoRenglon]["Assistance"] = "A";
            }

            ListaDT.WriteXml("Students.xml");
            
            //
        }

        //Nuevo metodo que verifica si existe el DNI en la lista de alumnos
        public bool DateandId_Exist(Students studentslist,
                                    Student student)
        {
            bool existe = false;
            foreach (DataRow row in studentslist.ListaDT.Rows)
            {
                if (student.Id_Number == (row["Id Number"].ToString()) && student.Date == (row["Date"].ToString()))
                {
                    existe = true;
                }
            }
            return existe;
        }


        // Metodo propio el cual verifica si en la lista de alumnos existe
        // una fila con los mismos valores de DNI y Fecha 
        // de existir lo borra y envia al front un bool verdadero
        public bool Delete(Student student)
        {
            bool existealumno = false;
            ListaDT.AcceptChanges();
            foreach (DataRow row in ListaDT.Rows)
            {
                if (student.Id_Number == (row["Id Number"].ToString())
                    && student.Date == (row["Date"].ToString()))
                {
                    row.Delete();
                    ListaDT.WriteXml("Students.xml");
                    existealumno = true;
                }
            }
            return existealumno;

        }

        public bool Edit(Student student)
        {
            bool existealumno = false;
            ListaDT.AcceptChanges();
            foreach (DataRow row in ListaDT.Rows)
            {
                if (student.Id_Number == (row["Id_Number"].ToString())
                    && student.Date == (row["Date"].ToString()))
                {
                    if (student.Assistance == true)
                    {
                        row["Assistance"] = "Present";
                        ListaDT.WriteXml("Students.xml");
                    }
                    else
                    {
                        row["Assistance"] = "Absent";
                        ListaDT.WriteXml("Students.xml");
                    }

                    existealumno = true;
                }
            }
            return existealumno;
        }
    }
}
