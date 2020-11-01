namespace Presentacion.Formularios
{
    partial class Sintoma
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
            this.button1 = new System.Windows.Forms.Button();
            this.cmbsintomas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnelim = new System.Windows.Forms.Button();
            this.grsintomas = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(617, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbsintomas
            // 
            this.cmbsintomas.FormattingEnabled = true;
            this.cmbsintomas.Location = new System.Drawing.Point(137, 19);
            this.cmbsintomas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbsintomas.Name = "cmbsintomas";
            this.cmbsintomas.Size = new System.Drawing.Size(92, 21);
            this.cmbsintomas.TabIndex = 1;
            this.cmbsintomas.SelectedIndexChanged += new System.EventHandler(this.cmbsintomas_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "sintoma";
            // 
            // btnelim
            // 
            this.btnelim.Location = new System.Drawing.Point(706, 9);
            this.btnelim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnelim.Name = "btnelim";
            this.btnelim.Size = new System.Drawing.Size(56, 19);
            this.btnelim.TabIndex = 3;
            this.btnelim.Text = "eliminar";
            this.btnelim.UseVisualStyleBackColor = true;
            this.btnelim.Click += new System.EventHandler(this.btnelim_Click);
            // 
            // grsintomas
            // 
            this.grsintomas.AutoSize = true;
            this.grsintomas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grsintomas.Location = new System.Drawing.Point(38, 58);
            this.grsintomas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grsintomas.Name = "grsintomas";
            this.grsintomas.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grsintomas.Size = new System.Drawing.Size(4, 3);
            this.grsintomas.TabIndex = 4;
            this.grsintomas.TabStop = false;
            this.grsintomas.Text = "sintomas";
            // 
            // Sintoma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 530);
            this.Controls.Add(this.grsintomas);
            this.Controls.Add(this.btnelim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbsintomas);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Sintoma";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Sintoma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbsintomas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnelim;
        private System.Windows.Forms.GroupBox grsintomas;
    }
}