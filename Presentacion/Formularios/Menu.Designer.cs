namespace Presentacion.Formularios
{
    partial class Menu
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
            this.components = new System.ComponentModel.Container();
            this.dataUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.btConsulta = new System.Windows.Forms.Button();
            this.btnChat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataUsuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataUsuarioBindingSource
            // 
            
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(11, 11);
            this.btnAgregarProducto.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(138, 28);
            this.btnAgregarProducto.TabIndex = 1;
            this.btnAgregarProducto.Text = "Agregar Producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // btConsulta
            // 
            this.btConsulta.Location = new System.Drawing.Point(13, 45);
            this.btConsulta.Name = "btConsulta";
            this.btConsulta.Size = new System.Drawing.Size(136, 27);
            this.btConsulta.TabIndex = 2;
            this.btConsulta.Text = "Consulta";
            this.btConsulta.UseVisualStyleBackColor = true;
            this.btConsulta.Click += new System.EventHandler(this.btConsulta_Click);
            // 
            // btnChat
            // 
            this.btnChat.Location = new System.Drawing.Point(13, 78);
            this.btnChat.Name = "btnChat";
            this.btnChat.Size = new System.Drawing.Size(136, 27);
            this.btnChat.TabIndex = 3;
            this.btnChat.Text = " Chat";
            this.btnChat.UseVisualStyleBackColor = true;
            this.btnChat.Click += new System.EventHandler(this.btnChat_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 195);
            this.Controls.Add(this.btnChat);
            this.Controls.Add(this.btConsulta);
            this.Controls.Add(this.btnAgregarProducto);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataUsuarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.BindingSource dataUsuarioBindingSource;
        private System.Windows.Forms.Button btConsulta;
        private System.Windows.Forms.Button btnChat;
    }
}