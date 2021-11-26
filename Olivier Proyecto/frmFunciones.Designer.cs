
namespace Olivier_Proyecto
{
    partial class frmFunciones
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
            this.tbcFunciones = new System.Windows.Forms.TabControl();
            this.tbpHorarios = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSecHor = new System.Windows.Forms.ComboBox();
            this.dgvHor = new System.Windows.Forms.DataGridView();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.tbpAsistencias = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.btnGuardarAsis = new System.Windows.Forms.Button();
            this.btnElimAsis = new System.Windows.Forms.Button();
            this.btnListarAsis = new System.Windows.Forms.Button();
            this.cmbSeccionAsis = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbEstadoAsis = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMateria = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomAsis = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvAsistencias = new System.Windows.Forms.DataGridView();
            this.btnBuscarAsis = new System.Windows.Forms.Button();
            this.txtCedAsis = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbpCalificaciones = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.txtMateriaCalif = new System.Windows.Forms.TextBox();
            this.btnListarCalif = new System.Windows.Forms.Button();
            this.btnElimCalif = new System.Windows.Forms.Button();
            this.btnGuardarCalif = new System.Windows.Forms.Button();
            this.cmbSecCalif = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbEstadoCalif = new System.Windows.Forms.ComboBox();
            this.cmbTrim = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCalif = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNomCalif = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvCalificaciones = new System.Windows.Forms.DataGridView();
            this.txtCedCalif = new System.Windows.Forms.TextBox();
            this.btnBuscarCedCalif = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tbcFunciones.SuspendLayout();
            this.tbpHorarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHor)).BeginInit();
            this.tbpAsistencias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistencias)).BeginInit();
            this.tbpCalificaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalificaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcFunciones
            // 
            this.tbcFunciones.Controls.Add(this.tbpHorarios);
            this.tbcFunciones.Controls.Add(this.tbpAsistencias);
            this.tbcFunciones.Controls.Add(this.tbpCalificaciones);
            this.tbcFunciones.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbcFunciones.Location = new System.Drawing.Point(0, 0);
            this.tbcFunciones.Name = "tbcFunciones";
            this.tbcFunciones.SelectedIndex = 0;
            this.tbcFunciones.Size = new System.Drawing.Size(984, 532);
            this.tbcFunciones.TabIndex = 0;
            // 
            // tbpHorarios
            // 
            this.tbpHorarios.Controls.Add(this.button1);
            this.tbpHorarios.Controls.Add(this.label1);
            this.tbpHorarios.Controls.Add(this.cmbSecHor);
            this.tbpHorarios.Controls.Add(this.dgvHor);
            this.tbpHorarios.Controls.Add(this.btnGenerar);
            this.tbpHorarios.Location = new System.Drawing.Point(4, 34);
            this.tbpHorarios.Name = "tbpHorarios";
            this.tbpHorarios.Padding = new System.Windows.Forms.Padding(3);
            this.tbpHorarios.Size = new System.Drawing.Size(976, 494);
            this.tbpHorarios.TabIndex = 0;
            this.tbpHorarios.Text = "HORARIOS";
            this.tbpHorarios.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(208, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 49);
            this.button1.TabIndex = 4;
            this.button1.Text = "Listar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleccione Sección";
            // 
            // cmbSecHor
            // 
            this.cmbSecHor.FormattingEnabled = true;
            this.cmbSecHor.Items.AddRange(new object[] {
            "7-1",
            "7-2",
            "7-3",
            "7-4",
            "8-1",
            "8-2",
            "8-3",
            "9-1",
            "9-2",
            "10-1",
            "10-2",
            "11-1",
            "12-1"});
            this.cmbSecHor.Location = new System.Drawing.Point(19, 109);
            this.cmbSecHor.Name = "cmbSecHor";
            this.cmbSecHor.Size = new System.Drawing.Size(161, 33);
            this.cmbSecHor.TabIndex = 2;
            // 
            // dgvHor
            // 
            this.dgvHor.AllowUserToAddRows = false;
            this.dgvHor.AllowUserToDeleteRows = false;
            this.dgvHor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHor.Location = new System.Drawing.Point(19, 156);
            this.dgvHor.Name = "dgvHor";
            this.dgvHor.ReadOnly = true;
            this.dgvHor.RowTemplate.Height = 25;
            this.dgvHor.Size = new System.Drawing.Size(565, 329);
            this.dgvHor.TabIndex = 1;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(19, 17);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(300, 44);
            this.btnGenerar.TabIndex = 0;
            this.btnGenerar.Text = "Generar Horarios";
            this.btnGenerar.UseVisualStyleBackColor = true;
            // 
            // tbpAsistencias
            // 
            this.tbpAsistencias.Controls.Add(this.label13);
            this.tbpAsistencias.Controls.Add(this.btnGuardarAsis);
            this.tbpAsistencias.Controls.Add(this.btnElimAsis);
            this.tbpAsistencias.Controls.Add(this.btnListarAsis);
            this.tbpAsistencias.Controls.Add(this.cmbSeccionAsis);
            this.tbpAsistencias.Controls.Add(this.label6);
            this.tbpAsistencias.Controls.Add(this.cmbEstadoAsis);
            this.tbpAsistencias.Controls.Add(this.label5);
            this.tbpAsistencias.Controls.Add(this.txtMateria);
            this.tbpAsistencias.Controls.Add(this.label4);
            this.tbpAsistencias.Controls.Add(this.txtNomAsis);
            this.tbpAsistencias.Controls.Add(this.label3);
            this.tbpAsistencias.Controls.Add(this.dgvAsistencias);
            this.tbpAsistencias.Controls.Add(this.btnBuscarAsis);
            this.tbpAsistencias.Controls.Add(this.txtCedAsis);
            this.tbpAsistencias.Controls.Add(this.label2);
            this.tbpAsistencias.Location = new System.Drawing.Point(4, 34);
            this.tbpAsistencias.Name = "tbpAsistencias";
            this.tbpAsistencias.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAsistencias.Size = new System.Drawing.Size(976, 494);
            this.tbpAsistencias.TabIndex = 1;
            this.tbpAsistencias.Text = "ASISTENCIAS";
            this.tbpAsistencias.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(297, 177);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(428, 42);
            this.label13.TabIndex = 15;
            this.label13.Text = "Doble click sobre la asistencia para modificar o eliminar, \r\nsi estás en listar, " +
    "para crear, busca de nuevo";
            // 
            // btnGuardarAsis
            // 
            this.btnGuardarAsis.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuardarAsis.Location = new System.Drawing.Point(205, 98);
            this.btnGuardarAsis.Name = "btnGuardarAsis";
            this.btnGuardarAsis.Size = new System.Drawing.Size(241, 37);
            this.btnGuardarAsis.TabIndex = 14;
            this.btnGuardarAsis.Text = "Guardar";
            this.btnGuardarAsis.UseVisualStyleBackColor = true;
            this.btnGuardarAsis.Click += new System.EventHandler(this.btnGuardarAsis_Click);
            // 
            // btnElimAsis
            // 
            this.btnElimAsis.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnElimAsis.Location = new System.Drawing.Point(465, 99);
            this.btnElimAsis.Name = "btnElimAsis";
            this.btnElimAsis.Size = new System.Drawing.Size(328, 37);
            this.btnElimAsis.TabIndex = 13;
            this.btnElimAsis.Text = "Eliminar";
            this.btnElimAsis.UseVisualStyleBackColor = true;
            this.btnElimAsis.Click += new System.EventHandler(this.btnElimAsis_Click);
            // 
            // btnListarAsis
            // 
            this.btnListarAsis.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnListarAsis.Location = new System.Drawing.Point(170, 157);
            this.btnListarAsis.Name = "btnListarAsis";
            this.btnListarAsis.Size = new System.Drawing.Size(121, 76);
            this.btnListarAsis.TabIndex = 12;
            this.btnListarAsis.Text = "Listar";
            this.btnListarAsis.UseVisualStyleBackColor = true;
            this.btnListarAsis.Click += new System.EventHandler(this.btnListarAsis_Click);
            // 
            // cmbSeccionAsis
            // 
            this.cmbSeccionAsis.FormattingEnabled = true;
            this.cmbSeccionAsis.Items.AddRange(new object[] {
            "7-1",
            "7-2",
            "7-3",
            "7-4",
            "8-1",
            "8-2",
            "8-3",
            "9-1",
            "9-2",
            "10-1",
            "10-2",
            "11-1",
            "12-1"});
            this.cmbSeccionAsis.Location = new System.Drawing.Point(29, 200);
            this.cmbSeccionAsis.Name = "cmbSeccionAsis";
            this.cmbSeccionAsis.Size = new System.Drawing.Size(121, 33);
            this.cmbSeccionAsis.TabIndex = 11;
            this.cmbSeccionAsis.Text = "7-1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Sección";
            // 
            // cmbEstadoAsis
            // 
            this.cmbEstadoAsis.FormattingEnabled = true;
            this.cmbEstadoAsis.Items.AddRange(new object[] {
            "PR",
            "TA",
            "AI",
            "AJ"});
            this.cmbEstadoAsis.Location = new System.Drawing.Point(592, 54);
            this.cmbEstadoAsis.Name = "cmbEstadoAsis";
            this.cmbEstadoAsis.Size = new System.Drawing.Size(201, 33);
            this.cmbEstadoAsis.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(592, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Estado de la asistencia";
            // 
            // txtMateria
            // 
            this.txtMateria.Location = new System.Drawing.Point(465, 54);
            this.txtMateria.Name = "txtMateria";
            this.txtMateria.Size = new System.Drawing.Size(121, 33);
            this.txtMateria.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(484, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Materia";
            // 
            // txtNomAsis
            // 
            this.txtNomAsis.Location = new System.Drawing.Point(205, 54);
            this.txtNomAsis.Name = "txtNomAsis";
            this.txtNomAsis.Size = new System.Drawing.Size(241, 33);
            this.txtNomAsis.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre Completo";
            // 
            // dgvAsistencias
            // 
            this.dgvAsistencias.AllowUserToAddRows = false;
            this.dgvAsistencias.AllowUserToDeleteRows = false;
            this.dgvAsistencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsistencias.Location = new System.Drawing.Point(16, 267);
            this.dgvAsistencias.Name = "dgvAsistencias";
            this.dgvAsistencias.ReadOnly = true;
            this.dgvAsistencias.RowTemplate.Height = 25;
            this.dgvAsistencias.Size = new System.Drawing.Size(942, 220);
            this.dgvAsistencias.TabIndex = 3;
            this.dgvAsistencias.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAsistencias_CellDoubleClick);
            // 
            // btnBuscarAsis
            // 
            this.btnBuscarAsis.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBuscarAsis.Location = new System.Drawing.Point(16, 99);
            this.btnBuscarAsis.Name = "btnBuscarAsis";
            this.btnBuscarAsis.Size = new System.Drawing.Size(171, 37);
            this.btnBuscarAsis.TabIndex = 2;
            this.btnBuscarAsis.Text = "Buscar";
            this.btnBuscarAsis.UseVisualStyleBackColor = true;
            this.btnBuscarAsis.Click += new System.EventHandler(this.btnBuscarAsis_Click);
            // 
            // txtCedAsis
            // 
            this.txtCedAsis.Location = new System.Drawing.Point(16, 54);
            this.txtCedAsis.Name = "txtCedAsis";
            this.txtCedAsis.Size = new System.Drawing.Size(171, 33);
            this.txtCedAsis.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Número de Cédula";
            // 
            // tbpCalificaciones
            // 
            this.tbpCalificaciones.Controls.Add(this.label15);
            this.tbpCalificaciones.Controls.Add(this.label14);
            this.tbpCalificaciones.Controls.Add(this.txtMateriaCalif);
            this.tbpCalificaciones.Controls.Add(this.btnListarCalif);
            this.tbpCalificaciones.Controls.Add(this.btnElimCalif);
            this.tbpCalificaciones.Controls.Add(this.btnGuardarCalif);
            this.tbpCalificaciones.Controls.Add(this.cmbSecCalif);
            this.tbpCalificaciones.Controls.Add(this.label12);
            this.tbpCalificaciones.Controls.Add(this.cmbEstadoCalif);
            this.tbpCalificaciones.Controls.Add(this.cmbTrim);
            this.tbpCalificaciones.Controls.Add(this.label11);
            this.tbpCalificaciones.Controls.Add(this.label10);
            this.tbpCalificaciones.Controls.Add(this.txtCalif);
            this.tbpCalificaciones.Controls.Add(this.label9);
            this.tbpCalificaciones.Controls.Add(this.txtNomCalif);
            this.tbpCalificaciones.Controls.Add(this.label8);
            this.tbpCalificaciones.Controls.Add(this.dgvCalificaciones);
            this.tbpCalificaciones.Controls.Add(this.txtCedCalif);
            this.tbpCalificaciones.Controls.Add(this.btnBuscarCedCalif);
            this.tbpCalificaciones.Controls.Add(this.label7);
            this.tbpCalificaciones.Location = new System.Drawing.Point(4, 34);
            this.tbpCalificaciones.Name = "tbpCalificaciones";
            this.tbpCalificaciones.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCalificaciones.Size = new System.Drawing.Size(976, 494);
            this.tbpCalificaciones.TabIndex = 2;
            this.tbpCalificaciones.Text = "CALIFICACIONES";
            this.tbpCalificaciones.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(852, 17);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 25);
            this.label14.TabIndex = 19;
            this.label14.Text = "Materia";
            // 
            // txtMateriaCalif
            // 
            this.txtMateriaCalif.Location = new System.Drawing.Point(825, 46);
            this.txtMateriaCalif.Name = "txtMateriaCalif";
            this.txtMateriaCalif.Size = new System.Drawing.Size(148, 33);
            this.txtMateriaCalif.TabIndex = 18;
            // 
            // btnListarCalif
            // 
            this.btnListarCalif.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnListarCalif.Location = new System.Drawing.Point(149, 161);
            this.btnListarCalif.Name = "btnListarCalif";
            this.btnListarCalif.Size = new System.Drawing.Size(178, 61);
            this.btnListarCalif.TabIndex = 17;
            this.btnListarCalif.Text = "Listar";
            this.btnListarCalif.UseVisualStyleBackColor = true;
            this.btnListarCalif.Click += new System.EventHandler(this.btnListarCalif_Click);
            // 
            // btnElimCalif
            // 
            this.btnElimCalif.Location = new System.Drawing.Point(443, 85);
            this.btnElimCalif.Name = "btnElimCalif";
            this.btnElimCalif.Size = new System.Drawing.Size(239, 34);
            this.btnElimCalif.TabIndex = 16;
            this.btnElimCalif.Text = "Eliminar";
            this.btnElimCalif.UseVisualStyleBackColor = true;
            this.btnElimCalif.Click += new System.EventHandler(this.btnElimCalif_Click);
            // 
            // btnGuardarCalif
            // 
            this.btnGuardarCalif.Location = new System.Drawing.Point(198, 84);
            this.btnGuardarCalif.Name = "btnGuardarCalif";
            this.btnGuardarCalif.Size = new System.Drawing.Size(239, 34);
            this.btnGuardarCalif.TabIndex = 15;
            this.btnGuardarCalif.Text = "Guardar";
            this.btnGuardarCalif.UseVisualStyleBackColor = true;
            this.btnGuardarCalif.Click += new System.EventHandler(this.btnGuardarCalif_Click);
            // 
            // cmbSecCalif
            // 
            this.cmbSecCalif.FormattingEnabled = true;
            this.cmbSecCalif.Items.AddRange(new object[] {
            "7-1",
            "7-2",
            "7-3",
            "7-4",
            "8-1",
            "8-2",
            "8-3",
            "9-1",
            "9-2",
            "10-1",
            "10-2",
            "11-1",
            "12-1"});
            this.cmbSecCalif.Location = new System.Drawing.Point(19, 189);
            this.cmbSecCalif.Name = "cmbSecCalif";
            this.cmbSecCalif.Size = new System.Drawing.Size(121, 33);
            this.cmbSecCalif.TabIndex = 14;
            this.cmbSecCalif.Text = "7-1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(44, 161);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 25);
            this.label12.TabIndex = 13;
            this.label12.Text = "Sección";
            // 
            // cmbEstadoCalif
            // 
            this.cmbEstadoCalif.FormattingEnabled = true;
            this.cmbEstadoCalif.Items.AddRange(new object[] {
            "APR",
            "APL",
            "REP"});
            this.cmbEstadoCalif.Location = new System.Drawing.Point(561, 46);
            this.cmbEstadoCalif.Name = "cmbEstadoCalif";
            this.cmbEstadoCalif.Size = new System.Drawing.Size(121, 33);
            this.cmbEstadoCalif.TabIndex = 12;
            // 
            // cmbTrim
            // 
            this.cmbTrim.FormattingEnabled = true;
            this.cmbTrim.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbTrim.Location = new System.Drawing.Point(698, 46);
            this.cmbTrim.Name = "cmbTrim";
            this.cmbTrim.Size = new System.Drawing.Size(121, 33);
            this.cmbTrim.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(712, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 25);
            this.label11.TabIndex = 10;
            this.label11.Text = "Trimestre";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(582, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 25);
            this.label10.TabIndex = 8;
            this.label10.Text = "Estado";
            // 
            // txtCalif
            // 
            this.txtCalif.Location = new System.Drawing.Point(443, 45);
            this.txtCalif.Name = "txtCalif";
            this.txtCalif.Size = new System.Drawing.Size(110, 33);
            this.txtCalif.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(443, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 25);
            this.label9.TabIndex = 6;
            this.label9.Text = "Calificación";
            // 
            // txtNomCalif
            // 
            this.txtNomCalif.Location = new System.Drawing.Point(198, 45);
            this.txtNomCalif.Name = "txtNomCalif";
            this.txtNomCalif.Size = new System.Drawing.Size(239, 33);
            this.txtNomCalif.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(231, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "Nombre Completo";
            // 
            // dgvCalificaciones
            // 
            this.dgvCalificaciones.AllowUserToAddRows = false;
            this.dgvCalificaciones.AllowUserToDeleteRows = false;
            this.dgvCalificaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCalificaciones.Location = new System.Drawing.Point(16, 255);
            this.dgvCalificaciones.Name = "dgvCalificaciones";
            this.dgvCalificaciones.ReadOnly = true;
            this.dgvCalificaciones.RowTemplate.Height = 25;
            this.dgvCalificaciones.Size = new System.Drawing.Size(937, 238);
            this.dgvCalificaciones.TabIndex = 3;
            this.dgvCalificaciones.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCalificaciones_CellDoubleClick);
            // 
            // txtCedCalif
            // 
            this.txtCedCalif.Location = new System.Drawing.Point(16, 46);
            this.txtCedCalif.Name = "txtCedCalif";
            this.txtCedCalif.Size = new System.Drawing.Size(164, 33);
            this.txtCedCalif.TabIndex = 2;
            // 
            // btnBuscarCedCalif
            // 
            this.btnBuscarCedCalif.Location = new System.Drawing.Point(16, 85);
            this.btnBuscarCedCalif.Name = "btnBuscarCedCalif";
            this.btnBuscarCedCalif.Size = new System.Drawing.Size(164, 34);
            this.btnBuscarCedCalif.TabIndex = 1;
            this.btnBuscarCedCalif.Text = "Buscar";
            this.btnBuscarCedCalif.UseVisualStyleBackColor = true;
            this.btnBuscarCedCalif.Click += new System.EventHandler(this.btnBuscarCedCalif_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ingrese Cédula";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(333, 180);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(549, 42);
            this.label15.TabIndex = 20;
            this.label15.Text = "Doble click sobre la asistencia para modificar o eliminar, si estás en listar,\r\n " +
    "para crear, busca de nuevo";
            // 
            // frmFunciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 534);
            this.Controls.Add(this.tbcFunciones);
            this.Name = "frmFunciones";
            this.Text = "Acciones dentro del sistema del colegio";
            this.tbcFunciones.ResumeLayout(false);
            this.tbpHorarios.ResumeLayout(false);
            this.tbpHorarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHor)).EndInit();
            this.tbpAsistencias.ResumeLayout(false);
            this.tbpAsistencias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistencias)).EndInit();
            this.tbpCalificaciones.ResumeLayout(false);
            this.tbpCalificaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalificaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcFunciones;
        private System.Windows.Forms.TabPage tbpHorarios;
        private System.Windows.Forms.TabPage tbpAsistencias;
        private System.Windows.Forms.TabPage tbpCalificaciones;
        private System.Windows.Forms.DataGridView dgvHor;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSecHor;
        private System.Windows.Forms.ComboBox cmbSeccionAsis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbEstadoAsis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMateria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNomAsis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvAsistencias;
        private System.Windows.Forms.Button btnBuscarAsis;
        private System.Windows.Forms.TextBox txtCedAsis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCalif;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNomCalif;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvCalificaciones;
        private System.Windows.Forms.TextBox txtCedCalif;
        private System.Windows.Forms.Button btnBuscarCedCalif;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbEstadoCalif;
        private System.Windows.Forms.ComboBox cmbTrim;
        private System.Windows.Forms.Button btnListarAsis;
        private System.Windows.Forms.Button btnGuardarAsis;
        private System.Windows.Forms.Button btnElimAsis;
        private System.Windows.Forms.Button btnListarCalif;
        private System.Windows.Forms.Button btnElimCalif;
        private System.Windows.Forms.Button btnGuardarCalif;
        private System.Windows.Forms.ComboBox cmbSecCalif;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtMateriaCalif;
        private System.Windows.Forms.Label label15;
    }
}