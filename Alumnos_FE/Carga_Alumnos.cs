using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Alumnos_BE;
using Alumnos_FE;


namespace Alumnos_FE
{
    //En la siguiente linea hacemos que el formulario actual herede
    //todas las propiedades de diseño y de funcion del formulario plantilla (FrmBase)
    //creado anteriormente
    public partial class Carga_Alumnos : FrmBase
    //
    {
        //variables que cuentan los clicks del modo oscuro y checkbox
        public int contadormodo = 0;
        public int contadorcheckbox = 0;
        //

        //Variables para el if de verificacion numerica en el textbox dni
        int Valorverif;
        decimal Verificacion;
        //

        public Alumnos ListaAlumnos { get; set; } = new Alumnos();
        //variables que cuentan los clicks de los textbox 
        int nombreclick = 0;
        int apellidoclick = 0;
        int dniclick = 0;
        //

        public Carga_Alumnos()
        {
            InitializeComponent();
            //actualizar datagridview desde que inicia la aplicacion para ver los datos desde el principio
            datagrid1.DataSource = ListaAlumnos.ListaDT;
        }

        //FUNCION MODO OSCURO
        
        private void Carga_Alumnos_Load(object sender, EventArgs e)
        {
            //codigo arcaico en desuso 
            //Login f1 = Owner as Login;
            //contadormodo = f1.contadormodo;
            //
            if ((contadormodo % 2) == 0)
            {
                btnModo.Text = "Modo Claro\r\nActivado\r\n";
                this.BackColor = Color.AliceBlue;
                PanelBarraTitulo.BackColor = Color.MediumSlateBlue;
                btnCrear.BackColor = Color.AliceBlue;
                btnModo.BackColor = Color.AliceBlue;
                btnCrear.FlatAppearance.BorderColor = Color.DarkGray;
                btnModo.FlatAppearance.BorderColor = Color.DarkGray;
                btnCerrar.FlatAppearance.MouseDownBackColor = Color.Indigo;
                btnCerrar.FlatAppearance.MouseOverBackColor = Color.Indigo;
                btnMinimizar.FlatAppearance.MouseDownBackColor = Color.Indigo;
                btnMinimizar.FlatAppearance.MouseOverBackColor = Color.Indigo;
                txtNombre.BackColor = Color.AliceBlue;
                txtApellido.BackColor = Color.AliceBlue;
               
                txtDni.BackColor = Color.AliceBlue;
                btnModo.ForeColor = Color.Black;
                labelTitulo.ForeColor = Color.Black;
                btnCrear.ForeColor = Color.Black;
                if (txtNombre.ForeColor == Color.Black)
                {
                }
                else
                {
                    txtNombre.ForeColor = Color.DarkGray;
                }
                if (txtApellido.ForeColor == Color.Black)
                {
                }
                else
                {
                    txtApellido.ForeColor = Color.DarkGray;
                }
               
                if (txtDni.ForeColor == Color.Black)
                {
                }
                else
                {
                    txtDni.ForeColor = Color.DarkGray;
                }
            }
            else
            {
                btnModo.Text = "Modo Oscuro\r\nActivado\r\n";
                this.BackColor = Color.DimGray;
                PanelBarraTitulo.BackColor = Color.FromArgb(25, 25, 25);
                btnCrear.BackColor = Color.Lavender;
                btnModo.BackColor = Color.Lavender;
                txtNombre.BackColor = Color.Lavender;
                txtApellido.BackColor = Color.Lavender;
                
                txtDni.BackColor = Color.Lavender;
                btnModo.ForeColor = Color.Black;
                labelTitulo.ForeColor = Color.White;
                btnCrear.ForeColor = Color.Black;
                if (txtNombre.ForeColor == Color.Black)
                {
                }
                else
                {
                    txtNombre.ForeColor = Color.DarkGray;
                }
                if (txtApellido.ForeColor == Color.Black)
                {
                }
                else
                {
                    txtApellido.ForeColor = Color.DarkGray;
                }
               
                if (txtDni.ForeColor == Color.Black)
                {
                }
                else
                {
                    txtDni.ForeColor = Color.DarkGray;
                }

            }
        }

        //FUNCION MODO OSCURO
        public void btnModo_Click(object sender, EventArgs e)
        {
            this.ActiveControl = PanelBarraTitulo;
            contadormodo++;
            //codigo arcaico en desuso 
            //Login f1 = Owner as Login;
            //f1.contadormodo = contadormodo;
            if ((contadormodo % 2) == 0)
            {
                btnModo.Text = "Modo Claro\r\nActivado\r\n";
                this.BackColor = Color.AliceBlue;
                PanelBarraTitulo.BackColor = Color.MediumSlateBlue;
                btnCrear.BackColor = Color.AliceBlue;
                btnModo.BackColor = Color.AliceBlue;
                btnCrear.FlatAppearance.BorderColor = Color.DarkGray;
                btnModo.FlatAppearance.BorderColor = Color.DarkGray;
                btnCerrar.FlatAppearance.MouseDownBackColor = Color.Indigo;
                btnCerrar.FlatAppearance.MouseOverBackColor = Color.Indigo;
                btnMinimizar.FlatAppearance.MouseDownBackColor = Color.Indigo;
                btnMinimizar.FlatAppearance.MouseOverBackColor = Color.Indigo;
                txtNombre.BackColor = Color.AliceBlue;
                txtApellido.BackColor = Color.AliceBlue;
                
                txtDni.BackColor = Color.AliceBlue;
                btnModo.ForeColor = Color.Black;
                labelTitulo.ForeColor = Color.Black;
                btnCrear.ForeColor = Color.Black;
                if (txtNombre.ForeColor == Color.Black)
                {
                }
                else
                {
                    txtNombre.ForeColor = Color.DarkGray;
                }
                if (txtApellido.ForeColor == Color.Black)
                {
                }
                else
                {
                    txtApellido.ForeColor = Color.DarkGray;
                }
               
                if (txtDni.ForeColor == Color.Black)
                {
                }
                else
                {
                    txtDni.ForeColor = Color.DarkGray;
                }
            }
            else
            {
                btnModo.Text = "Modo Oscuro\r\nActivado\r\n";
                this.BackColor = Color.DimGray;
                PanelBarraTitulo.BackColor = Color.FromArgb(25, 25, 25);
                btnCrear.BackColor = Color.Lavender;
                btnModo.BackColor = Color.Lavender;
                txtNombre.BackColor = Color.Lavender;
                txtApellido.BackColor = Color.Lavender;
               
                txtDni.BackColor = Color.Lavender;
                btnModo.ForeColor = Color.Black;
                labelTitulo.ForeColor = Color.White;
                btnCrear.ForeColor = Color.Black;
                if (txtNombre.ForeColor == Color.Black)
                {
                }
                else
                {
                    txtNombre.ForeColor = Color.DarkGray;
                }
                if (txtApellido.ForeColor == Color.Black)
                {
                }
                else
                {
                    txtApellido.ForeColor = Color.DarkGray;
                }
               
                if (txtDni.ForeColor == Color.Black)
                {
                }
                else
                {
                    txtDni.ForeColor = Color.DarkGray;
                }
            }
        }


        // Verifica todos los textbox y si cumple los requisitos
        // se inserta las variables en el backend para luego crear
        // un alumno en la lista de alumnos y escribirlo en la Data Table
        // por ultimo actualiza el origen de la data table y escribe un aviso
        // si es cargado correctamente
        //
        private void btnCrear_Click(object sender, EventArgs e)
        {

            if (txtNombre.Text != "" && txtNombre.Text != "Nombre")
            {
                //borro el error 
                errorNombre.SetError(txtNombre, "");
            }
            else
            {
                errorNombre.SetError(txtNombre, "Debe ingresar un nombre");
                txtNombre.Focus();
                return;
            }

            if (txtApellido.Text != "" && txtApellido.Text != "Apellido")
            {
                //borro el error 
                errorApellido.SetError(txtApellido, "");
            }
            else
            {
                errorApellido.SetError(txtApellido, "Debe ingresar un apellido");
                txtApellido.Focus();
                return;

            }


            if (txtDni.Text != "" && txtDni.Text != "Dni")
            {
                //borro el error 
                errorCorreo.SetError(txtDni, "");
            }
            else
            {
                errorCorreo.SetError(txtDni, "Debe ingresar un Dni");
                txtDni.Focus();
                return;
            }

            if (Decimal.TryParse(txtDni.Text, out Verificacion))

            {
                //borro el error 
                errorVerificacion.SetError(txtDni, "");
                Valorverif = int.Parse(txtDni.Text);
            }
            else
            {
                errorVerificacion.SetError(txtDni, "Ingrese un dato numerico");
                return;
            }

            //Creamos una nueva instancia de alumno
            //
            Alumno alumno = new Alumno();

            //Creamos una nueva instancia de alumnos
            //
            Alumnos alumnos = new Alumnos();

            //Agregamos todos los argumentos a la instancia de alumno q creamos
            //
            alumno.Agregar(txtNombre.Text,
                             txtApellido.Text,
                            txtDni.Text,
                            dateTimePicker1.Text,
                            checkBox1.Checked);

            //Insertamos el alumno con todos sus argumentos incluidos en la lista de alumnos
            //
            ListaAlumnos.InsertAlumno(alumno);

            //Aviso que el alumno fue cargado correctamente
            MessageBox.Show("Alumno Cargado");
            
            
            //este codigo se utiliza para actualizar el datagrid view
            // del login cuando se registra un nuevo usuario sin tener que reiniciar el programa
            datagrid1.DataSource = ListaAlumnos.ListaDT;
         

        }

        //el checkbox cambiara de color dependiendo si esta activado o no
        //mediante un if y else
        //
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox1.ForeColor = Color.Green;
                checkBox1.BackColor = Color.SpringGreen;
            }
            else
            {
                checkBox1.ForeColor = Color.Crimson;
                checkBox1.BackColor = Color.MistyRose;
            }
        }


        //Los siguientes metodos cambian los colores de las fuentes en los textbox
        // para simular un placeholder, el cual lamentablemente no existe en Winform ni .NETframework
        private void txtNombre_Click(object sender, EventArgs e)
        {
            nombreclick++;

            if (nombreclick == 1)
            {
                txtNombre.Text = "";
            }
            else
            {
                return;
            }
        }

        private void txtNombre_DoubleClick(object sender, EventArgs e)
        {
            nombreclick++;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            nombreclick++;
            txtNombre.ForeColor = Color.Black;
        }

        private void txtApellido_Click(object sender, EventArgs e)
        {

            apellidoclick++;
            if (apellidoclick == 1)
            {
                txtApellido.Text = "";
            }
            else
            {
                return;
            }
        }

        private void txtApellido_DoubleClick(object sender, EventArgs e)
        {
            apellidoclick++;
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            apellidoclick++;
            txtApellido.ForeColor = Color.Black;
        }


        private new void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            txtDni.ForeColor = Color.Black;
        }

       

        private void txtDni_Click(object sender, EventArgs e)
        {
            dniclick++;
            if (dniclick == 1)
            {
                txtDni.Text = "";
            }
            else
            {
                return;
            }
        }

      





        //
        //

    }
}
