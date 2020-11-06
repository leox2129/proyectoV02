namespace Presentacion.Formularios
{
    partial class AgregarSintomaPatologia
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
            this.dgvSintomas = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sintomaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dTSintomaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAgregarSintoma = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSintomas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTSintomaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSintomas
            // 
            this.dgvSintomas.AllowUserToAddRows = false;
            this.dgvSintomas.AllowUserToDeleteRows = false;
            this.dgvSintomas.AutoGenerateColumns = false;
            this.dgvSintomas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSintomas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.sintomaDataGridViewTextBoxColumn});
            this.dgvSintomas.DataSource = this.dTSintomaBindingSource;
            this.dgvSintomas.Location = new System.Drawing.Point(12, 137);
            this.dgvSintomas.Name = "dgvSintomas";
            this.dgvSintomas.ReadOnly = true;
            this.dgvSintomas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSintomas.Size = new System.Drawing.Size(765, 245);
            this.dgvSintomas.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sintomaDataGridViewTextBoxColumn
            // 
            this.sintomaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sintomaDataGridViewTextBoxColumn.DataPropertyName = "Sintoma";
            this.sintomaDataGridViewTextBoxColumn.HeaderText = "Sintoma";
            this.sintomaDataGridViewTextBoxColumn.Name = "sintomaDataGridViewTextBoxColumn";
            this.sintomaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dTSintomaBindingSource
            // 
            this.dTSintomaBindingSource.DataSource = typeof(_4_TipoDeDato.DTSintoma);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(34, 22);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(85, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre Sintoma";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(125, 22);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // btnAgregarSintoma
            // 
            this.btnAgregarSintoma.Location = new System.Drawing.Point(319, 22);
            this.btnAgregarSintoma.Name = "btnAgregarSintoma";
            this.btnAgregarSintoma.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarSintoma.TabIndex = 4;
            this.btnAgregarSintoma.Text = "Agregar";
            this.btnAgregarSintoma.UseVisualStyleBackColor = true;
            this.btnAgregarSintoma.Click += new System.EventHandler(this.btnAgregarSintoma_Click);
            // 
            // AgregarSintomaPatologia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAgregarSintoma);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.dgvSintomas);
            this.Name = "AgregarSintomaPatologia";
            this.Text = "AgregarSintoma";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSintomas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTSintomaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSintomas;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sintomaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dTSintomaBindingSource;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAgregarSintoma;
    }
}