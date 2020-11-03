namespace Presentacion.Formularios
{
    partial class AgregarPatologiaNuevo
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
            this.dgvPatologia = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gravedadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dTPatologiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAgregarPatologia = new System.Windows.Forms.Button();
            this.txtGravedad = new System.Windows.Forms.TextBox();
            this.lblGravedad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatologia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTPatologiaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPatologia
            // 
            this.dgvPatologia.AllowUserToAddRows = false;
            this.dgvPatologia.AllowUserToDeleteRows = false;
            this.dgvPatologia.AutoGenerateColumns = false;
            this.dgvPatologia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatologia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.gravedadDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn});
            this.dgvPatologia.DataSource = this.dTPatologiaBindingSource;
            this.dgvPatologia.Location = new System.Drawing.Point(12, 137);
            this.dgvPatologia.Name = "dgvPatologia";
            this.dgvPatologia.ReadOnly = true;
            this.dgvPatologia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPatologia.Size = new System.Drawing.Size(765, 245);
            this.dgvPatologia.TabIndex = 0;
            this.dgvPatologia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSintomas_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gravedadDataGridViewTextBoxColumn
            // 
            this.gravedadDataGridViewTextBoxColumn.DataPropertyName = "Gravedad";
            this.gravedadDataGridViewTextBoxColumn.HeaderText = "Gravedad";
            this.gravedadDataGridViewTextBoxColumn.Name = "gravedadDataGridViewTextBoxColumn";
            this.gravedadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dTPatologiaBindingSource
            // 
            this.dTPatologiaBindingSource.DataSource = typeof(_4_TipoDeDato.DTPatologia);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(28, 27);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(91, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre Patologia";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(134, 22);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // btnAgregarPatologia
            // 
            this.btnAgregarPatologia.Location = new System.Drawing.Point(319, 22);
            this.btnAgregarPatologia.Name = "btnAgregarPatologia";
            this.btnAgregarPatologia.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarPatologia.TabIndex = 4;
            this.btnAgregarPatologia.Text = "Agregar";
            this.btnAgregarPatologia.UseVisualStyleBackColor = true;
            this.btnAgregarPatologia.Click += new System.EventHandler(this.btnAgregarPatologia_Click);
            // 
            // txtGravedad
            // 
            this.txtGravedad.Location = new System.Drawing.Point(125, 63);
            this.txtGravedad.Name = "txtGravedad";
            this.txtGravedad.Size = new System.Drawing.Size(128, 20);
            this.txtGravedad.TabIndex = 5;
            // 
            // lblGravedad
            // 
            this.lblGravedad.AutoSize = true;
            this.lblGravedad.Location = new System.Drawing.Point(28, 66);
            this.lblGravedad.Name = "lblGravedad";
            this.lblGravedad.Size = new System.Drawing.Size(54, 13);
            this.lblGravedad.TabIndex = 6;
            this.lblGravedad.Text = "Gravedad";
            // 
            // AgregarPatologiaNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblGravedad);
            this.Controls.Add(this.txtGravedad);
            this.Controls.Add(this.btnAgregarPatologia);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.dgvPatologia);
            this.Name = "AgregarPatologiaNuevo";
            this.Text = "Gravedad";
            this.Load += new System.EventHandler(this.AgregarPatologiaNuevo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatologia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTPatologiaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPatologia;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAgregarPatologia;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gravedadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dTPatologiaBindingSource;
        private System.Windows.Forms.TextBox txtGravedad;
        private System.Windows.Forms.Label lblGravedad;
    }
}