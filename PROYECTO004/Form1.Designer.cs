
namespace PROYECTO004
{
    partial class Formulario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formulario));
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_Telefono = new System.Windows.Forms.Label();
            this.lbl_Estatura = new System.Windows.Forms.Label();
            this.lbl_Apellido = new System.Windows.Forms.Label();
            this.lbl_Edad = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbEdad = new System.Windows.Forms.TextBox();
            this.tbEstatura = new System.Windows.Forms.TextBox();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.tbApellidos = new System.Windows.Forms.TextBox();
            this.gB_Genero = new System.Windows.Forms.GroupBox();
            this.rB_Femenino = new System.Windows.Forms.RadioButton();
            this.rB_Masculino = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_guardar = new System.Windows.Forms.Button();
            this.bt_Limpiar = new System.Windows.Forms.Button();
            this.gB_Genero.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nombre.Location = new System.Drawing.Point(69, 62);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(90, 20);
            this.lbl_Nombre.TabIndex = 0;
            this.lbl_Nombre.Text = "NOMBRE:";
            this.lbl_Nombre.Click += new System.EventHandler(this.lbl_Nombre_Click);
            // 
            // lbl_Telefono
            // 
            this.lbl_Telefono.AutoSize = true;
            this.lbl_Telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Telefono.Location = new System.Drawing.Point(69, 154);
            this.lbl_Telefono.Name = "lbl_Telefono";
            this.lbl_Telefono.Size = new System.Drawing.Size(107, 20);
            this.lbl_Telefono.TabIndex = 2;
            this.lbl_Telefono.Text = "TELEFONO:";
            // 
            // lbl_Estatura
            // 
            this.lbl_Estatura.AutoSize = true;
            this.lbl_Estatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Estatura.Location = new System.Drawing.Point(69, 196);
            this.lbl_Estatura.Name = "lbl_Estatura";
            this.lbl_Estatura.Size = new System.Drawing.Size(108, 20);
            this.lbl_Estatura.TabIndex = 3;
            this.lbl_Estatura.Text = "ESTATURA:";
            // 
            // lbl_Apellido
            // 
            this.lbl_Apellido.AutoSize = true;
            this.lbl_Apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Apellido.Location = new System.Drawing.Point(69, 113);
            this.lbl_Apellido.Name = "lbl_Apellido";
            this.lbl_Apellido.Size = new System.Drawing.Size(101, 20);
            this.lbl_Apellido.TabIndex = 4;
            this.lbl_Apellido.Text = "APELLIDO:";
            // 
            // lbl_Edad
            // 
            this.lbl_Edad.AutoSize = true;
            this.lbl_Edad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Edad.Location = new System.Drawing.Point(69, 235);
            this.lbl_Edad.Name = "lbl_Edad";
            this.lbl_Edad.Size = new System.Drawing.Size(64, 20);
            this.lbl_Edad.TabIndex = 5;
            this.lbl_Edad.Text = "EDAD:";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(176, 56);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(220, 26);
            this.tbNombre.TabIndex = 6;
            // 
            // tbEdad
            // 
            this.tbEdad.Location = new System.Drawing.Point(176, 229);
            this.tbEdad.Name = "tbEdad";
            this.tbEdad.Size = new System.Drawing.Size(220, 26);
            this.tbEdad.TabIndex = 7;
            // 
            // tbEstatura
            // 
            this.tbEstatura.Location = new System.Drawing.Point(176, 190);
            this.tbEstatura.Name = "tbEstatura";
            this.tbEstatura.Size = new System.Drawing.Size(220, 26);
            this.tbEstatura.TabIndex = 8;
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(176, 148);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(220, 26);
            this.tbTelefono.TabIndex = 9;
            // 
            // tbApellidos
            // 
            this.tbApellidos.Location = new System.Drawing.Point(176, 107);
            this.tbApellidos.Name = "tbApellidos";
            this.tbApellidos.Size = new System.Drawing.Size(220, 26);
            this.tbApellidos.TabIndex = 10;
            // 
            // gB_Genero
            // 
            this.gB_Genero.Controls.Add(this.rB_Femenino);
            this.gB_Genero.Controls.Add(this.rB_Masculino);
            this.gB_Genero.Location = new System.Drawing.Point(88, 321);
            this.gB_Genero.Name = "gB_Genero";
            this.gB_Genero.Size = new System.Drawing.Size(271, 137);
            this.gB_Genero.TabIndex = 11;
            this.gB_Genero.TabStop = false;
            this.gB_Genero.Text = " ";
            // 
            // rB_Femenino
            // 
            this.rB_Femenino.AutoSize = true;
            this.rB_Femenino.Location = new System.Drawing.Point(145, 49);
            this.rB_Femenino.Name = "rB_Femenino";
            this.rB_Femenino.Size = new System.Drawing.Size(105, 24);
            this.rB_Femenino.TabIndex = 1;
            this.rB_Femenino.TabStop = true;
            this.rB_Femenino.Text = "Femenino";
            this.rB_Femenino.UseVisualStyleBackColor = true;
            // 
            // rB_Masculino
            // 
            this.rB_Masculino.AutoSize = true;
            this.rB_Masculino.Location = new System.Drawing.Point(6, 49);
            this.rB_Masculino.Name = "rB_Masculino";
            this.rB_Masculino.Size = new System.Drawing.Size(105, 24);
            this.rB_Masculino.TabIndex = 0;
            this.rB_Masculino.TabStop = true;
            this.rB_Masculino.Text = "Masculino";
            this.rB_Masculino.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "GENERO:";
            // 
            // bt_guardar
            // 
            this.bt_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_guardar.Location = new System.Drawing.Point(73, 464);
            this.bt_guardar.Name = "bt_guardar";
            this.bt_guardar.Size = new System.Drawing.Size(105, 31);
            this.bt_guardar.TabIndex = 14;
            this.bt_guardar.Text = "GUARDAR";
            this.bt_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_guardar.UseVisualStyleBackColor = true;
            this.bt_guardar.Click += new System.EventHandler(this.bt_guardar_Click);
            // 
            // bt_Limpiar
            // 
            this.bt_Limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Limpiar.Location = new System.Drawing.Point(277, 464);
            this.bt_Limpiar.Name = "bt_Limpiar";
            this.bt_Limpiar.Size = new System.Drawing.Size(119, 31);
            this.bt_Limpiar.TabIndex = 15;
            this.bt_Limpiar.Text = "CANCELAR";
            this.bt_Limpiar.UseVisualStyleBackColor = true;
            this.bt_Limpiar.Click += new System.EventHandler(this.bt_Limpiar_Click);
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(462, 548);
            this.Controls.Add(this.bt_Limpiar);
            this.Controls.Add(this.bt_guardar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gB_Genero);
            this.Controls.Add(this.tbApellidos);
            this.Controls.Add(this.tbTelefono);
            this.Controls.Add(this.tbEstatura);
            this.Controls.Add(this.tbEdad);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lbl_Edad);
            this.Controls.Add(this.lbl_Apellido);
            this.Controls.Add(this.lbl_Estatura);
            this.Controls.Add(this.lbl_Telefono);
            this.Controls.Add(this.lbl_Nombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Formulario";
            this.Text = " Formulario";
            this.gB_Genero.ResumeLayout(false);
            this.gB_Genero.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_Telefono;
        private System.Windows.Forms.Label lbl_Estatura;
        private System.Windows.Forms.Label lbl_Apellido;
        private System.Windows.Forms.Label lbl_Edad;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbEdad;
        private System.Windows.Forms.TextBox tbEstatura;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.TextBox tbApellidos;
        private System.Windows.Forms.GroupBox gB_Genero;
        private System.Windows.Forms.RadioButton rB_Femenino;
        private System.Windows.Forms.RadioButton rB_Masculino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_guardar;
        private System.Windows.Forms.Button bt_Limpiar;
    }
}

