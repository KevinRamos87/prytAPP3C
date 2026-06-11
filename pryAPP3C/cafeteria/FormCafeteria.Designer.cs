namespace pryAPP3C.cafeteria
{
    partial class FormCafeteria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdb_alcoholica = new System.Windows.Forms.RadioButton();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.txt_extra = new System.Windows.Forms.TextBox();
            this.lbl_opcion = new System.Windows.Forms.Label();
            this.cmb_tamaño = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdb_caliente = new System.Windows.Forms.RadioButton();
            this.rdb_fria = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lsbLista = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.chkGluten = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Cornsilk;
            this.groupBox1.Controls.Add(this.chkGluten);
            this.groupBox1.Controls.Add(this.rdb_alcoholica);
            this.groupBox1.Controls.Add(this.btn_agregar);
            this.groupBox1.Controls.Add(this.txt_extra);
            this.groupBox1.Controls.Add(this.lbl_opcion);
            this.groupBox1.Controls.Add(this.cmb_tamaño);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_precio);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_nombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rdb_caliente);
            this.groupBox1.Controls.Add(this.rdb_fria);
            this.groupBox1.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Brown;
            this.groupBox1.Location = new System.Drawing.Point(20, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 461);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "    🥛 CAPTURA DE BEBIDAS";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdb_alcoholica
            // 
            this.rdb_alcoholica.AutoSize = true;
            this.rdb_alcoholica.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_alcoholica.ForeColor = System.Drawing.Color.Black;
            this.rdb_alcoholica.Location = new System.Drawing.Point(240, 60);
            this.rdb_alcoholica.Name = "rdb_alcoholica";
            this.rdb_alcoholica.Size = new System.Drawing.Size(134, 20);
            this.rdb_alcoholica.TabIndex = 11;
            this.rdb_alcoholica.TabStop = true;
            this.rdb_alcoholica.Text = "🍸 Alcoholica";
            this.rdb_alcoholica.UseVisualStyleBackColor = true;
            this.rdb_alcoholica.CheckedChanged += new System.EventHandler(this.rdb_caliente_CheckedChanged);
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.SaddleBrown;
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.Font = new System.Drawing.Font("Segoe Fluent Icons", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.ForeColor = System.Drawing.Color.White;
            this.btn_agregar.Location = new System.Drawing.Point(120, 411);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(120, 41);
            this.btn_agregar.TabIndex = 10;
            this.btn_agregar.Text = "AGREGAR";
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // txt_extra
            // 
            this.txt_extra.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_extra.Location = new System.Drawing.Point(20, 363);
            this.txt_extra.Name = "txt_extra";
            this.txt_extra.Size = new System.Drawing.Size(213, 33);
            this.txt_extra.TabIndex = 9;
            // 
            // lbl_opcion
            // 
            this.lbl_opcion.AutoSize = true;
            this.lbl_opcion.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_opcion.ForeColor = System.Drawing.Color.Brown;
            this.lbl_opcion.Location = new System.Drawing.Point(16, 335);
            this.lbl_opcion.Name = "lbl_opcion";
            this.lbl_opcion.Size = new System.Drawing.Size(199, 20);
            this.lbl_opcion.TabIndex = 8;
            this.lbl_opcion.Text = "Cantidad de hielos";
            // 
            // cmb_tamaño
            // 
            this.cmb_tamaño.FormattingEnabled = true;
            this.cmb_tamaño.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmb_tamaño.Items.AddRange(new object[] {
            "Chico",
            "Mediano",
            "Grande"});
            this.cmb_tamaño.Location = new System.Drawing.Point(20, 265);
            this.cmb_tamaño.Name = "cmb_tamaño";
            this.cmb_tamaño.Size = new System.Drawing.Size(200, 34);
            this.cmb_tamaño.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(20, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tamaño";
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(20, 195);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(150, 33);
            this.txt_precio.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(16, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "PRECIO";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(20, 125);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(250, 33);
            this.txt_nombre.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(20, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre de la bebida";
            // 
            // rdb_caliente
            // 
            this.rdb_caliente.AutoSize = true;
            this.rdb_caliente.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_caliente.ForeColor = System.Drawing.Color.Black;
            this.rdb_caliente.Location = new System.Drawing.Point(120, 60);
            this.rdb_caliente.Name = "rdb_caliente";
            this.rdb_caliente.Size = new System.Drawing.Size(110, 20);
            this.rdb_caliente.TabIndex = 1;
            this.rdb_caliente.TabStop = true;
            this.rdb_caliente.Text = "🔥 Caliente";
            this.rdb_caliente.UseVisualStyleBackColor = true;
            this.rdb_caliente.CheckedChanged += new System.EventHandler(this.rdb_caliente_CheckedChanged);
            this.rdb_caliente.Click += new System.EventHandler(this.rdb_caliente_CheckedChanged);
            // 
            // rdb_fria
            // 
            this.rdb_fria.AutoSize = true;
            this.rdb_fria.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_fria.ForeColor = System.Drawing.Color.Black;
            this.rdb_fria.Location = new System.Drawing.Point(20, 60);
            this.rdb_fria.Name = "rdb_fria";
            this.rdb_fria.Size = new System.Drawing.Size(78, 20);
            this.rdb_fria.TabIndex = 0;
            this.rdb_fria.TabStop = true;
            this.rdb_fria.Text = " 🧊 Fria";
            this.rdb_fria.UseVisualStyleBackColor = true;
            this.rdb_fria.CheckedChanged += new System.EventHandler(this.rdb_caliente_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(650, 10);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.lsbLista);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(400, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(450, 280);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BEBIDAS AGREGADAS";
            // 
            // lsbLista
            // 
            this.lsbLista.FormattingEnabled = true;
            this.lsbLista.ItemHeight = 24;
            this.lsbLista.Location = new System.Drawing.Point(15, 30);
            this.lsbLista.Name = "lsbLista";
            this.lsbLista.Size = new System.Drawing.Size(420, 220);
            this.lsbLista.TabIndex = 0;
            this.lsbLista.SelectedIndexChanged += new System.EventHandler(this.lsbLista_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbl_descripcion);
            this.panel1.Location = new System.Drawing.Point(400, 340);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 120);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_descripcion.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descripcion.Location = new System.Drawing.Point(15, 30);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(0, 17);
            this.lbl_descripcion.TabIndex = 0;
            // 
            // chkGluten
            // 
            this.chkGluten.AutoSize = true;
            this.chkGluten.Location = new System.Drawing.Point(240, 362);
            this.chkGluten.Name = "chkGluten";
            this.chkGluten.Size = new System.Drawing.Size(123, 30);
            this.chkGluten.TabIndex = 12;
            this.chkGluten.TabStop = false;
            this.chkGluten.Text = "Gluten";
            this.chkGluten.UseVisualStyleBackColor = true;
            this.chkGluten.Visible = false;
            // 
            // FormCafeteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(878, 527);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormCafeteria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCafeteria";
            this.Load += new System.EventHandler(this.FormCafeteria_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdb_fria;
        private System.Windows.Forms.RadioButton rdb_caliente;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_extra;
        private System.Windows.Forms.Label lbl_opcion;
        private System.Windows.Forms.ComboBox cmb_tamaño;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lsbLista;
        private System.Windows.Forms.RadioButton rdb_alcoholica;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.CheckBox chkGluten;
    }
}