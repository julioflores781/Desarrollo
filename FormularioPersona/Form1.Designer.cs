namespace FormularioPersona
{
    partial class Form1
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
            this.TxtDoc = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BTBusca = new System.Windows.Forms.Button();
            this.BTCrea = new System.Windows.Forms.Button();
            this.BTElimina = new System.Windows.Forms.Button();
            this.BTActualiza = new System.Windows.Forms.Button();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BTLimpiaTxt = new System.Windows.Forms.Button();
            this.listViewPersona = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Documento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Apellido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Fecha_Crea = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BTLimpiaList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtDoc
            // 
            this.TxtDoc.Location = new System.Drawing.Point(123, 37);
            this.TxtDoc.Name = "TxtDoc";
            this.TxtDoc.Size = new System.Drawing.Size(191, 20);
            this.TxtDoc.TabIndex = 0;
            this.TxtDoc.TextChanged += new System.EventHandler(this.TxtDoc_TextChanged);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(123, 64);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(191, 20);
            this.TxtNombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Documento:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 5;
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(123, 90);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(191, 20);
            this.TxtApellido.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Apellido:";
            // 
            // BTBusca
            // 
            this.BTBusca.Location = new System.Drawing.Point(340, 41);
            this.BTBusca.Name = "BTBusca";
            this.BTBusca.Size = new System.Drawing.Size(75, 23);
            this.BTBusca.TabIndex = 8;
            this.BTBusca.Text = "Buscar";
            this.BTBusca.UseVisualStyleBackColor = true;
            this.BTBusca.Click += new System.EventHandler(this.BTBusca_Click);
            // 
            // BTCrea
            // 
            this.BTCrea.Location = new System.Drawing.Point(15, 139);
            this.BTCrea.Name = "BTCrea";
            this.BTCrea.Size = new System.Drawing.Size(75, 23);
            this.BTCrea.TabIndex = 9;
            this.BTCrea.Text = "Crear";
            this.BTCrea.UseVisualStyleBackColor = true;
            this.BTCrea.Click += new System.EventHandler(this.BTCrea_Click);
            // 
            // BTElimina
            // 
            this.BTElimina.Location = new System.Drawing.Point(96, 139);
            this.BTElimina.Name = "BTElimina";
            this.BTElimina.Size = new System.Drawing.Size(75, 23);
            this.BTElimina.TabIndex = 10;
            this.BTElimina.Text = "Eliminar";
            this.BTElimina.UseVisualStyleBackColor = true;
            this.BTElimina.Click += new System.EventHandler(this.BTElimina_Click);
            // 
            // BTActualiza
            // 
            this.BTActualiza.Location = new System.Drawing.Point(177, 139);
            this.BTActualiza.Name = "BTActualiza";
            this.BTActualiza.Size = new System.Drawing.Size(75, 23);
            this.BTActualiza.TabIndex = 11;
            this.BTActualiza.Text = "Actualizar";
            this.BTActualiza.UseVisualStyleBackColor = true;
            this.BTActualiza.Click += new System.EventHandler(this.BTActualiza_Click);
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(123, 11);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(191, 20);
            this.TxtId.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "ID:";
            // 
            // BTLimpiaTxt
            // 
            this.BTLimpiaTxt.Location = new System.Drawing.Point(340, 12);
            this.BTLimpiaTxt.Name = "BTLimpiaTxt";
            this.BTLimpiaTxt.Size = new System.Drawing.Size(75, 23);
            this.BTLimpiaTxt.TabIndex = 14;
            this.BTLimpiaTxt.Text = "Limpiar";
            this.BTLimpiaTxt.UseVisualStyleBackColor = true;
            this.BTLimpiaTxt.Click += new System.EventHandler(this.button1_Click);
            // 
            // listViewPersona
            // 
            this.listViewPersona.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Documento,
            this.Nombre,
            this.Apellido,
            this.Fecha_Crea});
            this.listViewPersona.Location = new System.Drawing.Point(12, 168);
            this.listViewPersona.Name = "listViewPersona";
            this.listViewPersona.Size = new System.Drawing.Size(429, 170);
            this.listViewPersona.TabIndex = 15;
            this.listViewPersona.UseCompatibleStateImageBehavior = false;
            this.listViewPersona.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // Documento
            // 
            this.Documento.Text = "Documento";
            this.Documento.Width = 84;
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 79;
            // 
            // Apellido
            // 
            this.Apellido.Text = "Apellido";
            this.Apellido.Width = 88;
            // 
            // Fecha_Crea
            // 
            this.Fecha_Crea.Text = "Fecha_Crea";
            this.Fecha_Crea.Width = 112;
            // 
            // BTLimpiaList
            // 
            this.BTLimpiaList.Location = new System.Drawing.Point(340, 139);
            this.BTLimpiaList.Name = "BTLimpiaList";
            this.BTLimpiaList.Size = new System.Drawing.Size(75, 23);
            this.BTLimpiaList.TabIndex = 16;
            this.BTLimpiaList.Text = "Limpiar";
            this.BTLimpiaList.UseVisualStyleBackColor = true;
            this.BTLimpiaList.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 362);
            this.Controls.Add(this.BTLimpiaList);
            this.Controls.Add(this.listViewPersona);
            this.Controls.Add(this.BTLimpiaTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.BTActualiza);
            this.Controls.Add(this.BTElimina);
            this.Controls.Add(this.BTCrea);
            this.Controls.Add(this.BTBusca);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtDoc);
            this.Name = "Form1";
            this.Text = "Control De Datos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtDoc;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BTBusca;
        private System.Windows.Forms.Button BTCrea;
        private System.Windows.Forms.Button BTElimina;
        private System.Windows.Forms.Button BTActualiza;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BTLimpiaTxt;
        private System.Windows.Forms.ListView listViewPersona;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Documento;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Apellido;
        private System.Windows.Forms.ColumnHeader Fecha_Crea;
        private System.Windows.Forms.Button BTLimpiaList;
    }
}

