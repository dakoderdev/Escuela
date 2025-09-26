namespace Escuela
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnBuscar = new Button();
            lblTitulo = new Label();
            lblNombre = new Label();
            txtbNombre = new TextBox();
            txtbApellido = new TextBox();
            lblApellido = new Label();
            txtbEdad = new TextBox();
            lblFechaNacimiento = new Label();
            datelblFechaNacimiento = new DateTimePicker();
            lblEdad = new Label();
            lblEmail = new Label();
            txtbEmail = new TextBox();
            lblAñoIngreso = new Label();
            txtbAñoIngreso = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(420, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(534, 334);
            dataGridView1.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(12, 404);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(112, 34);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(130, 404);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(112, 34);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(248, 404);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 34);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(842, 404);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(112, 34);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Geist", 13.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(12, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(124, 35);
            lblTitulo.TabIndex = 5;
            lblTitulo.Text = "Escuela";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Geist Medium", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(12, 68);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(88, 25);
            lblNombre.TabIndex = 6;
            lblNombre.Text = "Nombre";
            // 
            // txtbNombre
            // 
            txtbNombre.Location = new Point(12, 96);
            txtbNombre.Name = "txtbNombre";
            txtbNombre.Size = new Size(184, 31);
            txtbNombre.TabIndex = 7;
            // 
            // txtbApellido
            // 
            txtbApellido.Location = new Point(211, 96);
            txtbApellido.Name = "txtbApellido";
            txtbApellido.Size = new Size(184, 31);
            txtbApellido.TabIndex = 9;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Geist Medium", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApellido.Location = new Point(210, 68);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(91, 25);
            lblApellido.TabIndex = 8;
            lblApellido.Text = "Apellido";
            // 
            // txtbEdad
            // 
            txtbEdad.Location = new Point(12, 315);
            txtbEdad.Name = "txtbEdad";
            txtbEdad.Size = new Size(112, 31);
            txtbEdad.TabIndex = 15;
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Font = new Font("Geist Medium", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFechaNacimiento.Location = new Point(12, 144);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(211, 25);
            lblFechaNacimiento.TabIndex = 10;
            lblFechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // datelblFechaNacimiento
            // 
            datelblFechaNacimiento.Location = new Point(12, 172);
            datelblFechaNacimiento.Name = "datelblFechaNacimiento";
            datelblFechaNacimiento.Size = new Size(382, 31);
            datelblFechaNacimiento.TabIndex = 11;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Font = new Font("Geist Medium", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEdad.Location = new Point(12, 287);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(59, 25);
            lblEdad.TabIndex = 14;
            lblEdad.Text = "Edad";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Geist Medium", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(12, 222);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(64, 25);
            lblEmail.TabIndex = 12;
            lblEmail.Text = "Email";
            // 
            // txtbEmail
            // 
            txtbEmail.Location = new Point(12, 250);
            txtbEmail.Name = "txtbEmail";
            txtbEmail.Size = new Size(382, 31);
            txtbEmail.TabIndex = 13;
            // 
            // lblAñoIngreso
            // 
            lblAñoIngreso.AutoSize = true;
            lblAñoIngreso.Font = new Font("Geist Medium", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAñoIngreso.Location = new Point(144, 287);
            lblAñoIngreso.Name = "lblAñoIngreso";
            lblAñoIngreso.Size = new Size(156, 25);
            lblAñoIngreso.TabIndex = 16;
            lblAñoIngreso.Text = "Año de Ingreso";
            // 
            // txtbAñoIngreso
            // 
            txtbAñoIngreso.Location = new Point(144, 315);
            txtbAñoIngreso.Name = "txtbAñoIngreso";
            txtbAñoIngreso.Size = new Size(250, 31);
            txtbAñoIngreso.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(966, 450);
            Controls.Add(lblAñoIngreso);
            Controls.Add(txtbAñoIngreso);
            Controls.Add(lblEmail);
            Controls.Add(txtbEmail);
            Controls.Add(lblEdad);
            Controls.Add(datelblFechaNacimiento);
            Controls.Add(txtbEdad);
            Controls.Add(lblFechaNacimiento);
            Controls.Add(txtbApellido);
            Controls.Add(lblApellido);
            Controls.Add(txtbNombre);
            Controls.Add(lblNombre);
            Controls.Add(lblTitulo);
            Controls.Add(btnBuscar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnBuscar;
        private Label lblTitulo;
        private Label lblNombre;
        private TextBox txtbNombre;
        private TextBox txtbApellido;
        private Label lblApellido;
        private TextBox txtbEdad;
        private Label lblFechaNacimiento;
        private DateTimePicker datelblFechaNacimiento;
        private Label lblEdad;
        private Label lblEmail;
        private TextBox txtbEmail;
        private Label lblAñoIngreso;
        private TextBox txtbAñoIngreso;
    }
}
