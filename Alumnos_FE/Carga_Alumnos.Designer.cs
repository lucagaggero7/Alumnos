using System;
using System.Drawing;

namespace Alumnos_FE
{
    partial class Carga_Alumnos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.errorNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorApellido = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorNombredeusuario = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCorreo = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorContraseña = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorVerificacion = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnModo = new System.Windows.Forms.Button();
            this.datagrid1 = new System.Windows.Forms.DataGridView();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.PanelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorApellido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNombredeusuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCorreo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorContraseña)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorVerificacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnCerrar.Location = new System.Drawing.Point(1090, 0);
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnMinimizar.Location = new System.Drawing.Point(1048, 0);
            // 
            // PanelBarraTitulo
            // 
            this.PanelBarraTitulo.Size = new System.Drawing.Size(1132, 34);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(109, 134);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(260, 25);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "CARGAR ASISTENCIA";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.AliceBlue;
            this.txtNombre.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.DarkGray;
            this.txtNombre.Location = new System.Drawing.Point(114, 182);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(218, 24);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.Text = "Nombre";
            this.txtNombre.Click += new System.EventHandler(this.txtNombre_Click);
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.DoubleClick += new System.EventHandler(this.txtNombre_DoubleClick);
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.Color.AliceBlue;
            this.txtApellido.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.ForeColor = System.Drawing.Color.DarkGray;
            this.txtApellido.Location = new System.Drawing.Point(114, 228);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(218, 24);
            this.txtApellido.TabIndex = 3;
            this.txtApellido.Text = "Apellido";
            this.txtApellido.Click += new System.EventHandler(this.txtApellido_Click);
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            this.txtApellido.DoubleClick += new System.EventHandler(this.txtApellido_DoubleClick);
            // 
            // txtDni
            // 
            this.txtDni.BackColor = System.Drawing.Color.AliceBlue;
            this.txtDni.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDni.ForeColor = System.Drawing.Color.DarkGray;
            this.txtDni.Location = new System.Drawing.Point(114, 277);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(218, 24);
            this.txtDni.TabIndex = 5;
            this.txtDni.Text = "Dni";
            this.txtDni.Click += new System.EventHandler(this.txtDni_Click);
            this.txtDni.TextChanged += new System.EventHandler(this.txtDni_TextChanged);
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.Color.AliceBlue;
            this.btnCrear.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCrear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnCrear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.Location = new System.Drawing.Point(114, 448);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(111, 36);
            this.btnCrear.TabIndex = 9;
            this.btnCrear.Text = "CARGAR";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // errorNombre
            // 
            this.errorNombre.ContainerControl = this;
            // 
            // errorApellido
            // 
            this.errorApellido.ContainerControl = this;
            // 
            // errorNombredeusuario
            // 
            this.errorNombredeusuario.ContainerControl = this;
            // 
            // errorCorreo
            // 
            this.errorCorreo.ContainerControl = this;
            // 
            // errorContraseña
            // 
            this.errorContraseña.ContainerControl = this;
            // 
            // errorVerificacion
            // 
            this.errorVerificacion.ContainerControl = this;
            // 
            // btnModo
            // 
            this.btnModo.BackColor = System.Drawing.Color.AliceBlue;
            this.btnModo.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnModo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnModo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnModo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModo.ForeColor = System.Drawing.Color.Black;
            this.btnModo.Location = new System.Drawing.Point(12, 56);
            this.btnModo.Name = "btnModo";
            this.btnModo.Size = new System.Drawing.Size(127, 38);
            this.btnModo.TabIndex = 37;
            this.btnModo.Text = "Modo Claro\r\nActivado\r\n";
            this.btnModo.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnModo.UseVisualStyleBackColor = false;
            this.btnModo.Click += new System.EventHandler(this.btnModo_Click);
            // 
            // datagrid1
            // 
            this.datagrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.datagrid1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.datagrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid1.Location = new System.Drawing.Point(444, 134);
            this.datagrid1.Name = "datagrid1";
            this.datagrid1.Size = new System.Drawing.Size(570, 315);
            this.datagrid1.TabIndex = 38;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.MistyRose;
            this.checkBox1.FlatAppearance.BorderSize = 0;
            this.checkBox1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.checkBox1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.checkBox1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.Crimson;
            this.checkBox1.Location = new System.Drawing.Point(114, 370);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(112, 29);
            this.checkBox1.TabIndex = 39;
            this.checkBox1.Text = "Asistencia";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(114, 327);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 40;
            // 
            // Carga_Alumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1132, 536);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.datagrid1);
            this.Controls.Add(this.btnModo);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtApellido);
            this.Name = "Carga_Alumnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Carga_Alumnos_Load);
            this.Controls.SetChildIndex(this.PanelBarraTitulo, 0);
            this.Controls.SetChildIndex(this.txtApellido, 0);
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.txtDni, 0);
            this.Controls.SetChildIndex(this.btnCrear, 0);
            this.Controls.SetChildIndex(this.labelTitulo, 0);
            this.Controls.SetChildIndex(this.btnModo, 0);
            this.Controls.SetChildIndex(this.datagrid1, 0);
            this.Controls.SetChildIndex(this.checkBox1, 0);
            this.Controls.SetChildIndex(this.dateTimePicker1, 0);
            this.PanelBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorApellido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNombredeusuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCorreo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorContraseña)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorVerificacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.ErrorProvider errorNombre;
        private System.Windows.Forms.ErrorProvider errorApellido;
        private System.Windows.Forms.ErrorProvider errorNombredeusuario;
        private System.Windows.Forms.ErrorProvider errorCorreo;
        private System.Windows.Forms.ErrorProvider errorContraseña;
        private System.Windows.Forms.ErrorProvider errorVerificacion;
        public System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnModo;
        public System.Windows.Forms.DataGridView datagrid1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.CheckBox checkBox1;
    }
}

