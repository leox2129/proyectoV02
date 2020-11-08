namespace Medicos.Formularios
{
    partial class ListarDiagnostico
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
            this.dgvDianostico = new System.Windows.Forms.DataGridView();
            this.iddiagnosticoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gravedadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrePatologiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrePacienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dTDiagnosticoMostrarMedicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAgregarSintoma = new System.Windows.Forms.Button();
            this.btnChat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDianostico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTDiagnosticoMostrarMedicoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDianostico
            // 
            this.dgvDianostico.AllowUserToAddRows = false;
            this.dgvDianostico.AllowUserToDeleteRows = false;
            this.dgvDianostico.AutoGenerateColumns = false;
            this.dgvDianostico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDianostico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iddiagnosticoDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.gravedadDataGridViewTextBoxColumn,
            this.nombrePatologiaDataGridViewTextBoxColumn,
            this.nombrePacienteDataGridViewTextBoxColumn});
            this.dgvDianostico.DataSource = this.dTDiagnosticoMostrarMedicoBindingSource;
            this.dgvDianostico.Location = new System.Drawing.Point(12, 137);
            this.dgvDianostico.Name = "dgvDianostico";
            this.dgvDianostico.ReadOnly = true;
            this.dgvDianostico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDianostico.Size = new System.Drawing.Size(765, 245);
            this.dgvDianostico.TabIndex = 0;
            this.dgvDianostico.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSintomas_CellContentClick);
            // 
            // iddiagnosticoDataGridViewTextBoxColumn
            // 
            this.iddiagnosticoDataGridViewTextBoxColumn.DataPropertyName = "Iddiagnostico";
            this.iddiagnosticoDataGridViewTextBoxColumn.HeaderText = "Id";
            this.iddiagnosticoDataGridViewTextBoxColumn.Name = "iddiagnosticoDataGridViewTextBoxColumn";
            this.iddiagnosticoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gravedadDataGridViewTextBoxColumn
            // 
            this.gravedadDataGridViewTextBoxColumn.DataPropertyName = "Gravedad";
            this.gravedadDataGridViewTextBoxColumn.HeaderText = "Gravedad";
            this.gravedadDataGridViewTextBoxColumn.Name = "gravedadDataGridViewTextBoxColumn";
            this.gravedadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombrePatologiaDataGridViewTextBoxColumn
            // 
            this.nombrePatologiaDataGridViewTextBoxColumn.DataPropertyName = "NombrePatologia";
            this.nombrePatologiaDataGridViewTextBoxColumn.HeaderText = "Patologia";
            this.nombrePatologiaDataGridViewTextBoxColumn.Name = "nombrePatologiaDataGridViewTextBoxColumn";
            this.nombrePatologiaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombrePacienteDataGridViewTextBoxColumn
            // 
            this.nombrePacienteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombrePacienteDataGridViewTextBoxColumn.DataPropertyName = "NombrePaciente";
            this.nombrePacienteDataGridViewTextBoxColumn.HeaderText = "Nombre Paciente";
            this.nombrePacienteDataGridViewTextBoxColumn.Name = "nombrePacienteDataGridViewTextBoxColumn";
            this.nombrePacienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dTDiagnosticoMostrarMedicoBindingSource
            // 
            this.dTDiagnosticoMostrarMedicoBindingSource.DataSource = typeof(_4_TipoDeDato.DTDiagnosticoMostrarMedico);
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
            // btnChat
            // 
            this.btnChat.Location = new System.Drawing.Point(319, 62);
            this.btnChat.Name = "btnChat";
            this.btnChat.Size = new System.Drawing.Size(113, 23);
            this.btnChat.TabIndex = 5;
            this.btnChat.Text = "Chatear con usuario";
            this.btnChat.UseVisualStyleBackColor = true;
            this.btnChat.Click += new System.EventHandler(this.btnChat_Click);
            // 
            // ListarDiagnostico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(801, 450);
            this.Controls.Add(this.btnChat);
            this.Controls.Add(this.btnAgregarSintoma);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.dgvDianostico);
            this.Name = "ListarDiagnostico";
            this.Text = "AgregarSintoma";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDianostico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTDiagnosticoMostrarMedicoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDianostico;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAgregarSintoma;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddiagnosticoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gravedadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrePatologiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrePacienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dTDiagnosticoMostrarMedicoBindingSource;
        private System.Windows.Forms.Button btnChat;
    }
}