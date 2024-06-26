﻿using System;
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.errorNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorApellido = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDni = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnModo = new System.Windows.Forms.Button();
            this.dataGrid1 = new System.Windows.Forms.DataGridView();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.alumnosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FechaSelector = new Alumnos_FE.Controles_Personalizados.FechaCustom();
            this.cargaAlumnosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipBorrar = new System.Windows.Forms.ToolTip(this.components);
            this.btnEditar = new System.Windows.Forms.Button();
            this.tipCargar = new System.Windows.Forms.ToolTip(this.components);
            this.tipNombre = new System.Windows.Forms.ToolTip(this.components);
            this.tipApellido = new System.Windows.Forms.ToolTip(this.components);
            this.tipDNI = new System.Windows.Forms.ToolTip(this.components);
            this.tipFecha = new System.Windows.Forms.ToolTip(this.components);
            this.TipAsistencia = new System.Windows.Forms.ToolTip(this.components);
            this.tipModo = new System.Windows.Forms.ToolTip(this.components);
            this.btnMostrar = new System.Windows.Forms.Button();
            this.boxLanguage = new System.Windows.Forms.ComboBox();
            this.PanelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorApellido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargaAlumnosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.btnCerrar.Location = new System.Drawing.Point(1010, 0);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo;
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.btnMinimizar.Location = new System.Drawing.Point(968, 0);
            // 
            // PanelBarraTitulo
            // 
            this.PanelBarraTitulo.BackColor = System.Drawing.Color.Blue;
            this.PanelBarraTitulo.Size = new System.Drawing.Size(1052, 34);
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
            this.txtNombre.ForeColor = System.Drawing.Color.LightGray;
            this.txtNombre.Location = new System.Drawing.Point(114, 185);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(218, 24);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.Text = "Nombre";
            this.tipNombre.SetToolTip(this.txtNombre, "Ingrese un nombre");
            this.txtNombre.Click += new System.EventHandler(this.txtNombre_Click);
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.DoubleClick += new System.EventHandler(this.txtNombre_DoubleClick);
            this.txtNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNombre_KeyDown);
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.Color.AliceBlue;
            this.txtApellido.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.ForeColor = System.Drawing.Color.LightGray;
            this.txtApellido.Location = new System.Drawing.Point(114, 231);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(218, 24);
            this.txtApellido.TabIndex = 3;
            this.txtApellido.Text = "Apellido";
            this.tipApellido.SetToolTip(this.txtApellido, "Ingrese un Apellido");
            this.txtApellido.Click += new System.EventHandler(this.txtApellido_Click);
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            this.txtApellido.DoubleClick += new System.EventHandler(this.txtApellido_DoubleClick);
            this.txtApellido.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtApellido_KeyDown);
            this.txtApellido.Leave += new System.EventHandler(this.txtApellido_Leave);
            // 
            // txtDni
            // 
            this.txtDni.BackColor = System.Drawing.Color.AliceBlue;
            this.txtDni.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDni.ForeColor = System.Drawing.Color.LightGray;
            this.txtDni.Location = new System.Drawing.Point(114, 277);
            this.txtDni.MaxLength = 8;
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(218, 26);
            this.txtDni.TabIndex = 5;
            this.txtDni.Text = "Dni";
            this.tipDNI.SetToolTip(this.txtDni, "Ingrese un DNI");
            this.txtDni.Click += new System.EventHandler(this.txtDni_Click);
            this.txtDni.TextChanged += new System.EventHandler(this.txtDni_TextChanged);
            this.txtDni.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDni_KeyDown);
            this.txtDni.Leave += new System.EventHandler(this.txtDni_Leave);
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.AliceBlue;
            this.btnCargar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCargar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnCargar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Location = new System.Drawing.Point(104, 448);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(100, 46);
            this.btnCargar.TabIndex = 9;
            this.btnCargar.Text = "CARGAR\r\n ALUMNO";
            this.tipCargar.SetToolTip(this.btnCargar, "Cargar un registro requiere:\r\nNombre, Apellido, DNI y Fecha");
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCrear_Click);
            this.btnCargar.MouseLeave += new System.EventHandler(this.btnCargar_MouseLeave);
            this.btnCargar.MouseHover += new System.EventHandler(this.btnCargar_MouseHover);
            // 
            // errorNombre
            // 
            this.errorNombre.ContainerControl = this;
            // 
            // errorApellido
            // 
            this.errorApellido.ContainerControl = this;
            // 
            // errorDni
            // 
            this.errorDni.ContainerControl = this;
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
            this.tipModo.SetToolTip(this.btnModo, "Seleccione entre Modo Claro o Modo Oscuro");
            this.btnModo.UseVisualStyleBackColor = false;
            this.btnModo.Click += new System.EventHandler(this.btnModo_Click);
            // 
            // dataGrid1
            // 
            this.dataGrid1.AllowUserToAddRows = false;
            this.dataGrid1.AllowUserToDeleteRows = false;
            this.dataGrid1.AllowUserToResizeColumns = false;
            this.dataGrid1.AllowUserToResizeRows = false;
            this.dataGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGrid1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGrid1.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGrid1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.NullValue = "null";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrid1.ColumnHeadersHeight = 30;
            this.dataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGrid1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGrid1.EnableHeadersVisualStyles = false;
            this.dataGrid1.GridColor = System.Drawing.Color.DarkGray;
            this.dataGrid1.Location = new System.Drawing.Point(414, 117);
            this.dataGrid1.MaximumSize = new System.Drawing.Size(9999, 9999);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.ReadOnly = true;
            this.dataGrid1.RowHeadersVisible = false;
            this.dataGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGrid1.Size = new System.Drawing.Size(555, 312);
            this.dataGrid1.TabIndex = 38;
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.FlatAppearance.BorderSize = 0;
            this.checkBox1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.checkBox1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.checkBox1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.Black;
            this.checkBox1.Image = global::Alumnos_FE.Properties.Resources.Vunchecked;
            this.checkBox1.Location = new System.Drawing.Point(104, 384);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(123, 35);
            this.checkBox1.TabIndex = 39;
            this.checkBox1.Text = " Ausente";
            this.checkBox1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.TipAsistencia.SetToolTip(this.checkBox1, "Marque la asistencia");
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.AliceBlue;
            this.btnBorrar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBorrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnBorrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(220, 448);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(100, 46);
            this.btnBorrar.TabIndex = 41;
            this.btnBorrar.Text = "BORRAR\r\n ALUMNO";
            this.tipBorrar.SetToolTip(this.btnBorrar, "Borrar un registro requiere DNI y Fecha");
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.Borrar_Click);
            this.btnBorrar.MouseLeave += new System.EventHandler(this.btnBorrar_MouseLeave);
            this.btnBorrar.MouseHover += new System.EventHandler(this.btnBorrar_MouseHover);
            // 
            // alumnosBindingSource
            // 
            this.alumnosBindingSource.DataSource = typeof(Alumnos_BE.Alumnos);
            // 
            // FechaSelector
            // 
            this.FechaSelector.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.FechaSelector.BorderSize = 0;
            this.FechaSelector.CustomFormat = "dd \'de\' MMMM \'de\' yyyy";
            this.FechaSelector.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaSelector.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaSelector.Location = new System.Drawing.Point(114, 325);
            this.FechaSelector.MinimumSize = new System.Drawing.Size(4, 35);
            this.FechaSelector.Name = "FechaSelector";
            this.FechaSelector.Size = new System.Drawing.Size(218, 35);
            this.FechaSelector.SkinColor = System.Drawing.Color.Blue;
            this.FechaSelector.TabIndex = 43;
            this.FechaSelector.TextColor = System.Drawing.Color.White;
            this.tipFecha.SetToolTip(this.FechaSelector, "Presione el calendario \r\npara ingresar una Fecha");
            this.FechaSelector.CloseUp += new System.EventHandler(this.FechaSelector_CloseUp);
            // 
            // cargaAlumnosBindingSource
            // 
            this.cargaAlumnosBindingSource.DataSource = typeof(Alumnos_FE.Carga_Alumnos);
            // 
            // tipBorrar
            // 
            this.tipBorrar.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.AliceBlue;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(335, 448);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(112, 46);
            this.btnEditar.TabIndex = 44;
            this.btnEditar.Text = "EDITAR \r\n ASISTENCIA";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // tipCargar
            // 
            this.tipCargar.AutoPopDelay = 5000;
            this.tipCargar.InitialDelay = 500;
            this.tipCargar.ReshowDelay = 0;
            this.tipCargar.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.AliceBlue;
            this.btnMostrar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMostrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnMostrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.Location = new System.Drawing.Point(737, 448);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(112, 46);
            this.btnMostrar.TabIndex = 45;
            this.btnMostrar.Text = "MOSTRAR\r\n TODO";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // boxLanguage
            // 
            this.boxLanguage.BackColor = System.Drawing.SystemColors.Window;
            this.boxLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxLanguage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boxLanguage.FormattingEnabled = true;
            this.boxLanguage.Items.AddRange(new object[] {
            "Español",
            "Ingles "});
            this.boxLanguage.Location = new System.Drawing.Point(754, 56);
            this.boxLanguage.Name = "boxLanguage";
            this.boxLanguage.Size = new System.Drawing.Size(121, 21);
            this.boxLanguage.TabIndex = 46;
            this.boxLanguage.SelectionChangeCommitted += new System.EventHandler(this.boxLanguage_SelectionChangeCommitted);
            // 
            // Carga_Alumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1052, 536);
            this.Controls.Add(this.boxLanguage);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.FechaSelector);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.btnModo);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtApellido);
            this.MinimizeBox = false;
            this.Name = "Carga_Alumnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Carga_Alumnos_Load);
            this.Click += new System.EventHandler(this.Carga_Alumnos_Click);
            this.Controls.SetChildIndex(this.PanelBarraTitulo, 0);
            this.Controls.SetChildIndex(this.txtApellido, 0);
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.txtDni, 0);
            this.Controls.SetChildIndex(this.btnCargar, 0);
            this.Controls.SetChildIndex(this.labelTitulo, 0);
            this.Controls.SetChildIndex(this.btnModo, 0);
            this.Controls.SetChildIndex(this.dataGrid1, 0);
            this.Controls.SetChildIndex(this.checkBox1, 0);
            this.Controls.SetChildIndex(this.btnBorrar, 0);
            this.Controls.SetChildIndex(this.FechaSelector, 0);
            this.Controls.SetChildIndex(this.btnEditar, 0);
            this.Controls.SetChildIndex(this.btnMostrar, 0);
            this.Controls.SetChildIndex(this.boxLanguage, 0);
            this.PanelBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorApellido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargaAlumnosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.ErrorProvider errorNombre;
        private System.Windows.Forms.ErrorProvider errorApellido;
        private System.Windows.Forms.ErrorProvider errorDni;
        public System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnModo;
        public System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.BindingSource alumnosBindingSource;
        private System.Windows.Forms.BindingSource cargaAlumnosBindingSource;
        private Controles_Personalizados.FechaCustom FechaSelector;
        public System.Windows.Forms.DataGridView dataGrid1;
        private System.Windows.Forms.ToolTip tipBorrar;
        private System.Windows.Forms.ToolTip tipCargar;
        private System.Windows.Forms.ToolTip tipNombre;
        private System.Windows.Forms.ToolTip tipApellido;
        private System.Windows.Forms.ToolTip tipDNI;
        private System.Windows.Forms.ToolTip tipFecha;
        private System.Windows.Forms.ToolTip TipAsistencia;
        private System.Windows.Forms.ToolTip tipModo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnMostrar;
        public System.Windows.Forms.ComboBox boxLanguage;
    }
}

