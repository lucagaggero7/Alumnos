using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Alumnos_BE;
using Alumnos_FE;
using Alumnos_FE.Controles_Personalizados;




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
        long Valorverif;
        long Verificacion;
        //

        //Variable que verifica si existe el DNI con la llamada al metodo del backend
        bool existe;

        //Variable que verifica si existe el DNI y la Fecha coincide con la llamada al metodo del backend
        bool existealumno;

        public Alumnos alumnos { get; set; } = new Alumnos();

        //variables que cuentan los clicks de los textbox 
        int nombreclick = 0;
        int apellidoclick = 0;
        int dniclick = 0;
        //

        public Carga_Alumnos()
        {
            InitializeComponent();
        }

        //FUNCION MODO OSCURO
        
        private void Carga_Alumnos_Load(object sender, EventArgs e)
        {
            //actualizar datagridview desde que inicia la aplicacion para ver los datos desde el principio
            datagrid1.DataSource = alumnos.ListaDT;
            //

            //Limpiamos la seleccion del datagridview para que arranque 
            //el programa sin filas seleccionadas
            datagrid1.ClearSelection();
            //

            //Le damos una fecha minima de una semana anterior a la fecha actual
            //por lo que solo se podran cargar y borrar registros de la semana anterior en adelante
            FechaSelector.MinDate = DateTime.Today.AddDays(-7);
            //
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
                datagrid1.BackgroundColor = Color.AliceBlue;
                datagrid1.DefaultCellStyle.BackColor = Color.AliceBlue;
                datagrid1.DefaultCellStyle.ForeColor = Color.Black;
                datagrid1.GridColor = Color.DarkGray;
                datagrid1.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.Control;
                datagrid1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
                //
                PanelBarraTitulo.BackColor = Color.Blue;
                FechaSelector.SkinColor = Color.Blue;
                btnCargar.BackColor = Color.AliceBlue;
                btnBorrar.BackColor = Color.AliceBlue;
                btnModo.BackColor = Color.AliceBlue;
                btnCargar.FlatAppearance.BorderColor = Color.DarkGray;
                btnModo.FlatAppearance.BorderColor = Color.DarkGray;
                btnCerrar.FlatAppearance.MouseDownBackColor = Color.Indigo;
                btnCerrar.FlatAppearance.MouseOverBackColor = Color.Indigo;
                btnMinimizar.FlatAppearance.MouseDownBackColor = Color.Indigo;
                btnMinimizar.FlatAppearance.MouseOverBackColor = Color.Indigo;
                txtNombre.BackColor = Color.AliceBlue;
                txtApellido.BackColor = Color.AliceBlue;
                
                txtDni.BackColor = Color.AliceBlue;
                btnModo.ForeColor = Color.Black;
                checkBox1.ForeColor = Color.Black;
                labelTitulo.ForeColor = Color.Black;
                btnCargar.ForeColor = Color.Black;
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
                this.BackColor = Color.FromArgb(45, 66, 91);
                datagrid1.BackgroundColor = Color.FromArgb(45, 66, 91);
                datagrid1.DefaultCellStyle.BackColor = Color.FromArgb(45, 66, 91);
                datagrid1.DefaultCellStyle.ForeColor = Color.White;
                datagrid1.GridColor = Color.SteelBlue;
                datagrid1.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.HotTrack;
                datagrid1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

                PanelBarraTitulo.BackColor = Color.FromArgb(32, 47, 65);
                FechaSelector.SkinColor = Color.FromArgb(32, 47, 65);
                btnCargar.BackColor = Color.Lavender;
                btnBorrar.BackColor = Color.Lavender;
                btnModo.BackColor = Color.Lavender;
                btnCerrar.FlatAppearance.MouseDownBackColor = Color.DarkGray;
                btnCerrar.FlatAppearance.MouseOverBackColor = Color.DarkGray;
                btnMinimizar.FlatAppearance.MouseDownBackColor = Color.DarkGray;
                btnMinimizar.FlatAppearance.MouseOverBackColor = Color.DarkGray;
                txtNombre.BackColor = Color.Lavender;
                txtApellido.BackColor = Color.Lavender;
               
                txtDni.BackColor = Color.Lavender;
                btnModo.ForeColor = Color.Black;
                checkBox1.ForeColor = Color.White;
                labelTitulo.ForeColor = Color.White;
                btnCargar.ForeColor = Color.Black;
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
        // se insertan las variables en el backend 
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
                errorDni.SetError(txtDni, "");
            }
            else
            {
                errorDni.SetError(txtDni, "Debe ingresar un Dni");
                txtDni.Focus();
                return;
            }

            if (long.TryParse(txtDni.Text, out Verificacion))

            {
                //borro el error 
                errorDni.SetError(txtDni, "");
                Valorverif = long.Parse(txtDni.Text);
            }
            else
            {
                errorDni.SetError(txtDni, "Ingrese un numero entero");
                return;
            }

            //Creamos una nueva instancia de alumno
            //
            Alumno alumno = new Alumno();

            //Creamos una nueva instancia de alumnos
            //
            Alumnos alumnos = new Alumnos();

            //Agregamos todos los datos al alumno q creamos
            //
            alumno.Agregar(txtNombre.Text,
                             txtApellido.Text,
                            txtDni.Text,
                            FechaSelector.Text,
                            checkBox1.Checked);

            //llamamos al metodo que verifica si ya existe el DNI que coincida con la fecha en la lista de alumnos
            existe = alumnos.ExisteFechayDNI(alumnos, alumno);

            if (existe == false)
            {
                //borro el error 
                errorDni.SetError(txtDni, "");
            }
            else
            {
                MessageBox.Show("No se permite cargar el mismo DNI en el mismo dia");
                return;
            }

            //Insertamos el alumno con todos sus datos en la lista de alumnos
            //
            alumnos.InsertAlumno(alumno);

            //Aviso que el alumno fue cargado correctamente
            MessageBox.Show("Alumno Cargado");
            
            
            //este codigo se utiliza para actualizar el datagrid view
            // del login cuando se registra un nuevo usuario sin tener que reiniciar el programa
            datagrid1.DataSource = alumnos.ListaDT;
        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            if (long.TryParse(txtDni.Text, out Verificacion))

            {
                //borro el error 
                errorDni.SetError(txtDni, "");
                Valorverif = long.Parse(txtDni.Text);
            }
            else
            {
                errorDni.SetError(txtDni, "Ingrese un numero entero");
                return;
            }

            //Creamos una nueva instancia de alumno
            //
            Alumno alumno = new Alumno();

            //Creamos una nueva instancia de alumnos
            //
            Alumnos alumnos = new Alumnos();


            alumno.Agregar(txtNombre.Text,
                             txtApellido.Text,
                            txtDni.Text,
                            FechaSelector.Text,
                            checkBox1.Checked);

            existealumno = alumnos.BorrarAlumno(alumno);

            if (existealumno == false)
            {
                errorDni.SetError(txtDni, "El valor no existe");
                return;
            }
            else
            {
                errorDni.SetError(txtDni, "");

            }

            //Aviso que el valor fue borrado de la lista correctamente

            MessageBox.Show("Valor borrado de la lista");

            //este codigo se utiliza para actualizar el datagrid view
            // del login cuando se registra un nuevo usuario sin tener que reiniciar el programa

            datagrid1.DataSource = alumnos.ListaDT;
        }

        private void Carga_Alumnos_Click(object sender, EventArgs e)
        {
            //Limpiamos la seleccion del datagridview
            //cuando se presiona click fuera del datagridview
            datagrid1.ClearSelection();
        }

        //el checkbox cambiara de color dependiendo si esta activado o no
        //mediante un if y else
        //
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = sender as CheckBox;
            if (chk.Checked)
            {
                chk.Image = Properties.Resources.Vchecked;
                checkBox1.Text = " Presente";
            }
            else
            {
                chk.Image = Properties.Resources.Vunchecked;
                checkBox1.Text = " Ausente";
            }
            //if (checkbox1.checked == true)
            //{
            //    checkbox1.forecolor = color.green;
            //    checkbox1.backcolor = color.springgreen;
            //}
            //else
            //{
            //    checkbox1.forecolor = color.crimson;
            //    checkbox1.backcolor = color.mistyrose;
            //}
        }


        //Los siguientes metodos cambian los colores de las fuentes en los textbox
        // para simular un placeholder, el cual lamentablemente no existe en Winforms .NETframework
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

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            dniclick++;
            txtDni.ForeColor = Color.Black;
        }


        private void btnCargar_MouseLeave(object sender, EventArgs e)
        {
            tipCargar.Active = false;
        }

        private void btnBorrar_MouseLeave(object sender, EventArgs e)
        {
            tipBorrar.Active = false;
        }

        private void btnCargar_MouseHover(object sender, EventArgs e)
        {
            tipCargar.Active = true;
        }

        private void btnBorrar_MouseHover(object sender, EventArgs e)
        {
            tipBorrar.Active = true;
        }

        private void tipDNI_Popup(object sender, PopupEventArgs e)
        {

        }

        //
        //

    }
}
