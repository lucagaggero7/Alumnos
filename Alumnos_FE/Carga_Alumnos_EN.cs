using Alumnos_BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Alumnos_FE
{
    public partial class Carga_Alumnos_EN : FrmBase
    {


        //variables que cuentan los clicks del modo oscuro y checkbox de asistencia
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

        //Instanciamos la clase alumnos del backend

        //Creamos una nueva instancia de la clase alumno
        //
        Student student = new Student();

        //Creamos una nueva instancia de la clase alumnos
        Students students = new Students();
        //

        //variables que cuentan los clicks de los textbox para simular placeholders
        int nombreclick = 0;
        int apellidoclick = 0;
        int dniclick = 0;
        int mostrarclick = 0;
        //
        public Carga_Alumnos_EN()
        {
            InitializeComponent();
        }

     

        private void Carga_Alumnos_EN_Load(object sender, EventArgs e)
        {
            //restringimos las interacciones con el combobox
            //restringimos las interacciones con el combobox
            boxLanguage.DropDownStyle = ComboBoxStyle.DropDownList;
            //damos el valor por defecto al lenguaje español
            boxLanguage.SelectedIndex = 1;

            //actualizar datagridview desde que inicia el formulario para ver los datos desde el principio
            dataGrid1.DataSource = students.ListaDT;
            //

            //Le damos una fecha minima de dos meses anterior a la fecha actual
            //por lo que solo se podran cargar y borrar registros desde esa fecha en adelante
            FechaSelector.MinDate = DateTime.Today.AddDays(-60);
            //

            //Inicia el formulario con un filtrado de la tabla de datos
            //por la fecha del date-time-picker (fecha actual por defecto)
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGrid1.DataSource;
            bs.Filter = "Date like '%" + FechaSelector.Text + "%'";
            dataGrid1.DataSource = bs.DataSource;
            //

            //Limpiamos la seleccion del datagridview para que arranque 
            //el programa sin filas seleccionadas
            dataGrid1.ClearSelection();
            //

        }

        //FUNCION MODO OSCURO
        public void btnModo_Click(object sender, EventArgs e)
        {
            this.ActiveControl = PanelBarraTitulo;
            contadormodo++;
            //codigo arcaico usado en formularios padre con login
            //Login f1 = Owner as Login;
            //f1.contadormodo = contadormodo;
            if ((contadormodo % 2) == 0)
            {
                btnModo.Text = "Light Mode\r\nActivated\r\n";
                this.BackColor = Color.AliceBlue;
                dataGrid1.BackgroundColor = Color.AliceBlue;
                dataGrid1.DefaultCellStyle.BackColor = Color.AliceBlue;
                dataGrid1.DefaultCellStyle.ForeColor = Color.Black;
                dataGrid1.GridColor = Color.DarkGray;
                dataGrid1.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.Control;
                dataGrid1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
                PanelBarraTitulo.BackColor = System.Drawing.Color.DarkOrchid;
                FechaSelector.SkinColor =  System.Drawing.Color.DarkOrchid;
                btnCargar.BackColor = Color.AliceBlue;
                btnBorrar.BackColor = Color.AliceBlue;
                btnModo.BackColor = Color.AliceBlue;
                btnEditar.BackColor = Color.AliceBlue;
                btnMostrar.BackColor = Color.AliceBlue;
                boxLanguage.BackColor = Color.AliceBlue;
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
                    txtNombre.ForeColor = Color.LightGray;
                }
                if (txtApellido.ForeColor == Color.Black)
                {
                }
                else
                {
                    txtApellido.ForeColor = Color.LightGray;
                }

                if (txtDni.ForeColor == Color.Black)
                {
                }
                else
                {
                    txtDni.ForeColor = Color.LightGray;
                }
            }
            else
            {
                btnModo.Text = "Dark Mode\r\nActivated\r\n";
                this.BackColor = Color.FromArgb(45, 66, 91);
                dataGrid1.BackgroundColor = Color.FromArgb(45, 66, 91);
                dataGrid1.DefaultCellStyle.BackColor = Color.FromArgb(45, 66, 91);
                dataGrid1.DefaultCellStyle.ForeColor = Color.White;
                dataGrid1.GridColor = System.Drawing.Color.DarkOrchid;
                dataGrid1.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.DarkOrchid;
                dataGrid1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                PanelBarraTitulo.BackColor = Color.FromArgb(32, 47, 65);
                FechaSelector.SkinColor = Color.FromArgb(32, 47, 65);
                btnCargar.BackColor = Color.Lavender;
                btnBorrar.BackColor = Color.Lavender;
                btnModo.BackColor = Color.Lavender;
                btnEditar.BackColor = Color.Lavender;
                btnMostrar.BackColor = Color.Lavender;
                boxLanguage.BackColor = Color.Lavender;
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
                    txtNombre.ForeColor = Color.LightGray;
                }
                if (txtApellido.ForeColor == Color.Black)
                {
                }
                else
                {
                    txtApellido.ForeColor = Color.LightGray;
                }

                if (txtDni.ForeColor == Color.Black)
                {
                }
                else
                {
                    txtDni.ForeColor = Color.LightGray;
                }
            }
        }



        // Verifica todos los textbox y si cumple los requisitos establecidos
        // se insertan las variables en el backend 
        private void btnCrear_Click(object sender, EventArgs e)
        {

            if (txtNombre.Text != "" && txtNombre.Text != "Name")
            {
                //borro el error 
                errorNombre.SetError(txtNombre, "");
            }
            else
            {
                errorNombre.SetError(txtNombre, "Need to insert a name");
                txtNombre.Focus();
                return;
            }

            if (txtApellido.Text != "" && txtApellido.Text != "Surname")
            {
                //borro el error 
                errorApellido.SetError(txtApellido, "");
            }
            else
            {
                errorApellido.SetError(txtApellido, "Need to insert a surname");
                txtApellido.Focus();
                return;

            }

            if (txtDni.Text != "" && txtDni.Text != "Id Number" && txtDni.Text.Length >= 8)
            {
                //borro el error 
                errorDni.SetError(txtDni, "");
            }
            else
            {
                errorDni.SetError(txtDni, "Need to insert a 8 digits valid Id");
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
                errorDni.SetError(txtDni, "Insert a integer");
                return;
            }

            //Agregamos todos los datos a la clase alumno (alumno individual)
            //
            student.Insert(txtNombre.Text,
                             txtApellido.Text,
                            txtDni.Text,
                            FechaSelector.Text,
                            checkBox1.Checked);
            //

            //llamamos al metodo que verifica si ya existe el DNI y que coincida con la fecha en la lista de alumnos
            existe = students.DateandId_Exist(students, student);

            if (existe == false)
            {
                //borro el error 
                errorDni.SetError(txtDni, "");
            }
            else
            {
                //en el caso de que ya exista un registro (fila/row) en esa misma fecha
                //el backend nos devolvio la variable true por lo que no permitimos volver a cargarlo
                MessageBox.Show("Load an Id in the same day is not allowed");
                return;
            }

            //Insertamos el alumno con todos sus datos en la clase alumnos que contiene la lista
            // de todos los alumnos cargados en el .XML
            //
            students.Load(student);

            //Aviso que el alumno fue cargado correctamente en la lista
            MessageBox.Show("Student succesfully loaded");
            //

            //este codigo se utiliza para actualizar el datagrid view
            //cuando se agrega un registro (fila/row) sin tener que reiniciar el programa
            dataGrid1.DataSource = students.ListaDT;
            //

            //Aqui se vuelve a filtrar la tabla de datos por la fecha seleccionada
            if (mostrarclick == 0)
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = dataGrid1.DataSource;
                bs.Filter = "Date like '%" + FechaSelector.Text + "%'";
                dataGrid1.DataSource = bs.DataSource;
                mostrarclick = 0;
            }
            //
        }

        //Este evento click pertenece al boton borrar que borra un registro (fila/row)
        //seleccionado mediante la fecha y dni del registro
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
                errorDni.SetError(txtDni, "Insert a integer");
                return;
            }

            //Agregamos todos los datos a la clase alumno (alumno individual)
            //en este caso se va a utilizar para comparar los datos con 
            //la data table y buscar coincidencias en los registros
            student.Insert(txtNombre.Text,
                             txtApellido.Text,
                            txtDni.Text,
                            FechaSelector.Text,
                            checkBox1.Checked);
            //

            //Llamamos al metodo del backend que creamos para que borre
            // el registro en la tabla y nos devuelva si existia el alumno o no
            existealumno = students.Delete(student);
            //

            //Notificamos si el valor exisita o no en el registro
            //y si fue borrado con exito
            if (existealumno == false)
            {
                MessageBox.Show("Value doesn't exist");
                return;
            }
            else
            {
                MessageBox.Show("Value succesfully loaded");
                errorDni.SetError(txtDni, "");


            }
            //

            //este codigo se utiliza para actualizar el datagrid view
            //cuando se elimina un registro (fila/row) sin tener que reiniciar el programa
            dataGrid1.DataSource = students.ListaDT;
            //

            //Aqui se vuelve a filtrar la tabla de datos por la fecha seleccionada
            if (mostrarclick == 0)
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = dataGrid1.DataSource;
                bs.Filter = "Date like '%" + FechaSelector.Text + "%'";
                dataGrid1.DataSource = bs.DataSource;
                mostrarclick = 0;
            }
            //
        }

        //Este evento click pertenece al boton editar que edita la asistencia
        //de un registro (fila/row) que el usuario seleccione
        //mediante la fecha y dni del registro
        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Verificamos que el dni sea un valor entero
            if (long.TryParse(txtDni.Text, out Verificacion))

            {
                //borro el error 
                errorDni.SetError(txtDni, "");
                Valorverif = long.Parse(txtDni.Text);
            }
            else
            {
                errorDni.SetError(txtDni, "Insert a integer");
                return;
            }
           
            //Agregamos todos los datos a la clase alumno (alumno individual)
            //en este caso se va a utilizar para comparar los datos con 
            //la data table y buscar coincidencias en los registros
            student.Insert(txtNombre.Text,
                             txtApellido.Text,
                            txtDni.Text,
                            FechaSelector.Text,
                            checkBox1.Checked);
            //

            //Llamamos al metodo del backend que creamos para que edite
            // el registro en la tabla y nos devuelva si existia el alumno o no
            existealumno = students.Edit(student);
            //

            //Notificamos si el valor exisita o no en el registro
            //y si fue editado con exito
            if (existealumno == false)
            {
                MessageBox.Show("Value doesn't exist");
                return;
            }
            else
            {
                MessageBox.Show("Value succesfully edited");
                errorDni.SetError(txtDni, "");


            }
            //

            //este codigo se utiliza para actualizar el datagrid view
            //cuando se edita un registro (fila/row) sin tener que reiniciar el programa
            dataGrid1.DataSource = students.ListaDT;
            //

            //Aqui se vuelve a filtrar la tabla de datos por la fecha seleccionada
            if (mostrarclick == 0)
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = dataGrid1.DataSource;
                bs.Filter = "Date like '%" + FechaSelector.Text + "%'";
                dataGrid1.DataSource = bs.DataSource;
                mostrarclick = 0;
            }
            //

        }

        private void Carga_Alumnos_EN_Click(object sender, EventArgs e)
        {
            //Limpiamos la seleccion del datagridview
            //cuando se presiona click fuera del datagridview
            dataGrid1.ClearSelection();
            //

            //Ejecutamos los evenetos leave para ahorrar lineas if
            txtNombre_Leave(sender, e);
            txtApellido_Leave(sender, e);
            txtDni_Leave(sender, e);
            //

            //Sacamos el foco de los textbox para no generar bugs del cursor
            checkBox1.Focus();
            //

            //if (txtNombre.Text == "")
            //{
            //    txtNombre.Text = "Nombre";
            //    txtNombre.ForeColor = Color.LightGray;

            //}

            //if (txtApellido.Text == "")
            //{
            //    txtApellido.Text = "Apellido";
            //    txtApellido.ForeColor = Color.LightGray;
            //}

            //if (txtDni.Text == "")
            //{
            //    txtDni.Text = "Dni";
            //    txtDni.ForeColor = Color.LightGray;
            //}


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //el checkbox cambiara de color dependiendo si esta activado o no
            //mediante un if/else
            CheckBox chk = sender as CheckBox;
            if (chk.Checked)
            {
                chk.Image = Properties.Resources.Vchecked;
                checkBox1.Text = " Present";
            }
            else
            {
                chk.Image = Properties.Resources.Vunchecked;
                checkBox1.Text = " Absent";
            }
            //

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
        // para simular un placeholder, el cual no está implementado en Winforms
        private void txtNombre_Click(object sender, EventArgs e)
        {
            nombreclick++;

            if (nombreclick >= 1 && txtNombre.Text == "Name")
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
            if (apellidoclick >= 1 && txtApellido.Text == "Surname")
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
            if (dniclick >= 1 && txtDni.Text == "Id Number")
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

        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
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

        private void txtApellido_KeyDown(object sender, KeyEventArgs e)
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

        private void txtDni_KeyDown(object sender, KeyEventArgs e)
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
        ////

        //Anteriormente se utilizaba un boton para filtrar los registros
        //actualmente se filtra automaticamente
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            //BindingSource bs = new BindingSource();
            //bs.DataSource = dataGrid1.DataSource;
            //bs.Filter = "Fecha like '%" + FechaSelector.Text + "%'";
            //dataGrid1.DataSource = bs.DataSource;
        }
        //

        //Este evento se creo para mostrar todos los registros
        //y no filtrar la tabla de datos
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            mostrarclick = 1;
            if (mostrarclick == 1)
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = students.ListaDT;
                bs.Filter = null;
                dataGrid1.DataSource = bs.DataSource;
            }

            //Limpiamos la seleccion del datagridview 
            dataGrid1.ClearSelection();
            //
        }
        //

        //Este evento se ejecuta cuando el usuario termina de seleccionar
        //una fecha en el date-time-picker y filtra todos los registros
        //usando esa fecha
        private void FechaSelector_CloseUp(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGrid1.DataSource;
            bs.Filter = "Date like '%" + FechaSelector.Text + "%'";
            dataGrid1.DataSource = bs.DataSource;
            mostrarclick = 0;

        }
        //

        //Eventos que controlan la aparicion de los tooltip
        //sin estos eventos los controles se bugean y se superponen al ejecutarse
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
        //

        //Eventos leave que reinician los placeholder
        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Name";
                txtNombre.ForeColor = Color.LightGray;
            }

        }

        private void txtApellido_Leave(object sender, EventArgs e)
        {
            if (txtApellido.Text == "")
            {
                txtApellido.Text = "Surname";
                txtApellido.ForeColor = Color.LightGray;
            }
        }

        private void txtDni_Leave(object sender, EventArgs e)
        {
            if (txtDni.Text == "")
            {
                txtDni.Text = "Id Number";
                txtDni.ForeColor = Color.LightGray;
            }
        }

        private void boxLanguage_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //quita el molesto highlight del combobox
            this.ActiveControl = null;
            //

            if (boxLanguage.Text == "Spanish")
            {
                Owner.Show();
                this.Hide();
            }
        }

        private void FechaSelector_ValueChanged(object sender, EventArgs e)
        {
            
        }

       
    }
}
