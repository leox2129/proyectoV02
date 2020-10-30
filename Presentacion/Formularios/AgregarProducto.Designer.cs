namespace Presentacion.Formularios
{
    partial class AgregarProducto
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
            this.groupProd = new System.Windows.Forms.GroupBox();
            this.btntest = new System.Windows.Forms.Button();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.txtdescription = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.groupProd.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupProd
            // 
            this.groupProd.Controls.Add(this.btntest);
            this.groupProd.Controls.Add(this.txtprecio);
            this.groupProd.Controls.Add(this.txtdescription);
            this.groupProd.Controls.Add(this.txtcodigo);
            this.groupProd.Controls.Add(this.txtid);
            this.groupProd.Controls.Add(this.label4);
            this.groupProd.Controls.Add(this.dtpfecha);
            this.groupProd.Controls.Add(this.label3);
            this.groupProd.Controls.Add(this.label2);
            this.groupProd.Controls.Add(this.label1);
            this.groupProd.Controls.Add(this.lblid);
            this.groupProd.Location = new System.Drawing.Point(72, 68);
            this.groupProd.Name = "groupProd";
            this.groupProd.Size = new System.Drawing.Size(962, 300);
            this.groupProd.TabIndex = 0;
            this.groupProd.TabStop = false;
            this.groupProd.Text = "Agregar Producto";
            // 
            // btntest
            // 
            this.btntest.Location = new System.Drawing.Point(418, 33);
            this.btntest.Name = "btntest";
            this.btntest.Size = new System.Drawing.Size(200, 23);
            this.btntest.TabIndex = 2;
            this.btntest.Text = "Test";
            this.btntest.UseVisualStyleBackColor = true;
            this.btntest.Click += new System.EventHandler(this.btntest_Click);
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(154, 194);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(200, 22);
            this.txtprecio.TabIndex = 9;
            // 
            // txtdescription
            // 
            this.txtdescription.Location = new System.Drawing.Point(154, 121);
            this.txtdescription.Multiline = true;
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(200, 50);
            this.txtdescription.TabIndex = 8;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(154, 78);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(200, 22);
            this.txtcodigo.TabIndex = 7;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(154, 39);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(200, 22);
            this.txtid.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Precio";
            // 
            // dtpfecha
            // 
            this.dtpfecha.Location = new System.Drawing.Point(154, 242);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(200, 22);
            this.dtpfecha.TabIndex = 4;
            this.dtpfecha.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(28, 39);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(19, 17);
            this.lblid.TabIndex = 0;
            this.lblid.Text = "Id";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(72, 389);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(177, 388);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(285, 388);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // AgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 461);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.groupProd);
            this.Name = "AgregarProducto";
            this.Text = "Agregar Producto";
            this.groupProd.ResumeLayout(false);
            this.groupProd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupProd;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpfecha;
        private System.Windows.Forms.TextBox txtdescription;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Button btntest;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
    }
}