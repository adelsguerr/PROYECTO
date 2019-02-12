namespace Proyecto1_periodo1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.pnlSexo = new System.Windows.Forms.Panel();
            this.rdoFemenino = new System.Windows.Forms.RadioButton();
            this.rdoMasculino = new System.Windows.Forms.RadioButton();
            this.lblSexo = new System.Windows.Forms.Label();
            this.pnlEstadoCivl = new System.Windows.Forms.Panel();
            this.rdoDivorciado = new System.Windows.Forms.RadioButton();
            this.rdoViudo = new System.Windows.Forms.RadioButton();
            this.rdoCasado = new System.Windows.Forms.RadioButton();
            this.rdoSoltero = new System.Windows.Forms.RadioButton();
            this.lblEstadoCivil = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.mtxTelefono = new System.Windows.Forms.MaskedTextBox();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblDUI = new System.Windows.Forms.Label();
            this.mtxDUI = new System.Windows.Forms.MaskedTextBox();
            this.lblNIT = new System.Windows.Forms.Label();
            this.mtxNIT = new System.Windows.Forms.MaskedTextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.lblFechaContratacion = new System.Windows.Forms.Label();
            this.lblPuntuacion = new System.Windows.Forms.Label();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.mtxSueldo = new System.Windows.Forms.MaskedTextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.errCorreo = new System.Windows.Forms.ErrorProvider(this.components);
            this.cboDepartamento = new System.Windows.Forms.ComboBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.cboCargo = new System.Windows.Forms.ComboBox();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaContratacion = new System.Windows.Forms.DateTimePicker();
            this.nudPuntuacion = new System.Windows.Forms.NumericUpDown();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.lblExaminar = new System.Windows.Forms.Label();
            this.grpDatosPersonales = new System.Windows.Forms.GroupBox();
            this.grpDatosLaborales = new System.Windows.Forms.GroupBox();
            this.mtxCodigo = new System.Windows.Forms.MaskedTextBox();
            this.errNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlSexo.SuspendLayout();
            this.pnlEstadoCivl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errCorreo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPuntuacion)).BeginInit();
            this.grpDatosPersonales.SuspendLayout();
            this.grpDatosLaborales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errNombre)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(52, 39);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(235, 20);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.Validating += new System.ComponentModel.CancelEventHandler(this.txtNombre_Validating);
            this.txtNombre.Validated += new System.EventHandler(this.txtNombre_Validated);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(4, 39);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // pnlSexo
            // 
            this.pnlSexo.Controls.Add(this.rdoFemenino);
            this.pnlSexo.Controls.Add(this.rdoMasculino);
            this.pnlSexo.Controls.Add(this.lblSexo);
            this.pnlSexo.Location = new System.Drawing.Point(4, 62);
            this.pnlSexo.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSexo.Name = "pnlSexo";
            this.pnlSexo.Size = new System.Drawing.Size(199, 32);
            this.pnlSexo.TabIndex = 4;
            // 
            // rdoFemenino
            // 
            this.rdoFemenino.AutoSize = true;
            this.rdoFemenino.Location = new System.Drawing.Point(118, 6);
            this.rdoFemenino.Margin = new System.Windows.Forms.Padding(2);
            this.rdoFemenino.Name = "rdoFemenino";
            this.rdoFemenino.Size = new System.Drawing.Size(71, 17);
            this.rdoFemenino.TabIndex = 2;
            this.rdoFemenino.TabStop = true;
            this.rdoFemenino.Text = "Femenino";
            this.rdoFemenino.UseVisualStyleBackColor = true;
            // 
            // rdoMasculino
            // 
            this.rdoMasculino.AutoSize = true;
            this.rdoMasculino.Location = new System.Drawing.Point(44, 6);
            this.rdoMasculino.Margin = new System.Windows.Forms.Padding(2);
            this.rdoMasculino.Name = "rdoMasculino";
            this.rdoMasculino.Size = new System.Drawing.Size(68, 17);
            this.rdoMasculino.TabIndex = 1;
            this.rdoMasculino.TabStop = true;
            this.rdoMasculino.Text = "Maculino";
            this.rdoMasculino.UseVisualStyleBackColor = true;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(0, 8);
            this.lblSexo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(34, 13);
            this.lblSexo.TabIndex = 0;
            this.lblSexo.Text = "Sexo:";
            // 
            // pnlEstadoCivl
            // 
            this.pnlEstadoCivl.Controls.Add(this.rdoDivorciado);
            this.pnlEstadoCivl.Controls.Add(this.rdoViudo);
            this.pnlEstadoCivl.Controls.Add(this.rdoCasado);
            this.pnlEstadoCivl.Controls.Add(this.rdoSoltero);
            this.pnlEstadoCivl.Controls.Add(this.lblEstadoCivil);
            this.pnlEstadoCivl.Location = new System.Drawing.Point(4, 99);
            this.pnlEstadoCivl.Margin = new System.Windows.Forms.Padding(2);
            this.pnlEstadoCivl.Name = "pnlEstadoCivl";
            this.pnlEstadoCivl.Size = new System.Drawing.Size(320, 38);
            this.pnlEstadoCivl.TabIndex = 5;
            // 
            // rdoDivorciado
            // 
            this.rdoDivorciado.AutoSize = true;
            this.rdoDivorciado.Location = new System.Drawing.Point(244, 11);
            this.rdoDivorciado.Margin = new System.Windows.Forms.Padding(2);
            this.rdoDivorciado.Name = "rdoDivorciado";
            this.rdoDivorciado.Size = new System.Drawing.Size(76, 17);
            this.rdoDivorciado.TabIndex = 4;
            this.rdoDivorciado.TabStop = true;
            this.rdoDivorciado.Text = "Divorciado";
            this.rdoDivorciado.UseVisualStyleBackColor = true;
            // 
            // rdoViudo
            // 
            this.rdoViudo.AutoSize = true;
            this.rdoViudo.Location = new System.Drawing.Point(191, 11);
            this.rdoViudo.Margin = new System.Windows.Forms.Padding(2);
            this.rdoViudo.Name = "rdoViudo";
            this.rdoViudo.Size = new System.Drawing.Size(52, 17);
            this.rdoViudo.TabIndex = 3;
            this.rdoViudo.TabStop = true;
            this.rdoViudo.Text = "Viudo";
            this.rdoViudo.UseVisualStyleBackColor = true;
            // 
            // rdoCasado
            // 
            this.rdoCasado.AutoSize = true;
            this.rdoCasado.Location = new System.Drawing.Point(129, 11);
            this.rdoCasado.Margin = new System.Windows.Forms.Padding(2);
            this.rdoCasado.Name = "rdoCasado";
            this.rdoCasado.Size = new System.Drawing.Size(61, 17);
            this.rdoCasado.TabIndex = 2;
            this.rdoCasado.TabStop = true;
            this.rdoCasado.Text = "Casado";
            this.rdoCasado.UseVisualStyleBackColor = true;
            // 
            // rdoSoltero
            // 
            this.rdoSoltero.AutoSize = true;
            this.rdoSoltero.Location = new System.Drawing.Point(69, 11);
            this.rdoSoltero.Margin = new System.Windows.Forms.Padding(2);
            this.rdoSoltero.Name = "rdoSoltero";
            this.rdoSoltero.Size = new System.Drawing.Size(58, 17);
            this.rdoSoltero.TabIndex = 1;
            this.rdoSoltero.TabStop = true;
            this.rdoSoltero.Text = "Soltero";
            this.rdoSoltero.UseVisualStyleBackColor = true;
            // 
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.Location = new System.Drawing.Point(-2, 12);
            this.lblEstadoCivil.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(62, 13);
            this.lblEstadoCivil.TabIndex = 0;
            this.lblEstadoCivil.Text = "Estado Civil";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(4, 153);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 13);
            this.lblTelefono.TabIndex = 6;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // mtxTelefono
            // 
            this.mtxTelefono.Location = new System.Drawing.Point(60, 153);
            this.mtxTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.mtxTelefono.Mask = "0000-0000";
            this.mtxTelefono.Name = "mtxTelefono";
            this.mtxTelefono.Size = new System.Drawing.Size(76, 20);
            this.mtxTelefono.TabIndex = 7;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(4, 218);
            this.lblFechaNacimiento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(111, 13);
            this.lblFechaNacimiento.TabIndex = 8;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento:";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(147, 155);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(41, 13);
            this.lblCorreo.TabIndex = 10;
            this.lblCorreo.Text = "Correo:";
            // 
            // lblDUI
            // 
            this.lblDUI.AutoSize = true;
            this.lblDUI.Location = new System.Drawing.Point(4, 184);
            this.lblDUI.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDUI.Name = "lblDUI";
            this.lblDUI.Size = new System.Drawing.Size(29, 13);
            this.lblDUI.TabIndex = 12;
            this.lblDUI.Text = "DUI:";
            // 
            // mtxDUI
            // 
            this.mtxDUI.Location = new System.Drawing.Point(60, 181);
            this.mtxDUI.Margin = new System.Windows.Forms.Padding(2);
            this.mtxDUI.Mask = "00000000-0";
            this.mtxDUI.Name = "mtxDUI";
            this.mtxDUI.Size = new System.Drawing.Size(68, 20);
            this.mtxDUI.TabIndex = 13;
            // 
            // lblNIT
            // 
            this.lblNIT.AutoSize = true;
            this.lblNIT.Location = new System.Drawing.Point(147, 186);
            this.lblNIT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNIT.Name = "lblNIT";
            this.lblNIT.Size = new System.Drawing.Size(28, 13);
            this.lblNIT.TabIndex = 14;
            this.lblNIT.Text = "NIT:";
            // 
            // mtxNIT
            // 
            this.mtxNIT.Location = new System.Drawing.Point(193, 184);
            this.mtxNIT.Margin = new System.Windows.Forms.Padding(2);
            this.mtxNIT.Mask = "0000-000000-000-0";
            this.mtxNIT.Name = "mtxNIT";
            this.mtxNIT.Size = new System.Drawing.Size(95, 20);
            this.mtxNIT.TabIndex = 15;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(542, 451);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(77, 24);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(181, 72);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 19;
            this.lblCodigo.Text = "Codigo:";
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Location = new System.Drawing.Point(4, 41);
            this.lblDepartamento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(77, 13);
            this.lblDepartamento.TabIndex = 21;
            this.lblDepartamento.Text = "Departamento:";
            // 
            // lblFechaContratacion
            // 
            this.lblFechaContratacion.AutoSize = true;
            this.lblFechaContratacion.Location = new System.Drawing.Point(4, 112);
            this.lblFechaContratacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaContratacion.Name = "lblFechaContratacion";
            this.lblFechaContratacion.Size = new System.Drawing.Size(115, 13);
            this.lblFechaContratacion.TabIndex = 23;
            this.lblFechaContratacion.Text = "Fecha de Contratación";
            // 
            // lblPuntuacion
            // 
            this.lblPuntuacion.AutoSize = true;
            this.lblPuntuacion.Location = new System.Drawing.Point(4, 72);
            this.lblPuntuacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPuntuacion.Name = "lblPuntuacion";
            this.lblPuntuacion.Size = new System.Drawing.Size(61, 13);
            this.lblPuntuacion.TabIndex = 25;
            this.lblPuntuacion.Text = "Puntuación";
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.Location = new System.Drawing.Point(4, 142);
            this.lblSueldo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(82, 13);
            this.lblSueldo.TabIndex = 27;
            this.lblSueldo.Text = "Sueldo:           $";
            // 
            // mtxSueldo
            // 
            this.mtxSueldo.Location = new System.Drawing.Point(86, 140);
            this.mtxSueldo.Margin = new System.Windows.Forms.Padding(2);
            this.mtxSueldo.Mask = "000000.00";
            this.mtxSueldo.Name = "mtxSueldo";
            this.mtxSueldo.Size = new System.Drawing.Size(66, 20);
            this.mtxSueldo.TabIndex = 28;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(424, 452);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(77, 24);
            this.btnGuardar.TabIndex = 30;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(193, 153);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(146, 20);
            this.txtCorreo.TabIndex = 31;
            this.txtCorreo.Validating += new System.ComponentModel.CancelEventHandler(this.txtCorreo_Validating);
            this.txtCorreo.Validated += new System.EventHandler(this.txtCorreo_Validated);
            // 
            // errCorreo
            // 
            this.errCorreo.ContainerControl = this;
            // 
            // cboDepartamento
            // 
            this.cboDepartamento.FormattingEnabled = true;
            this.cboDepartamento.Items.AddRange(new object[] {
            "Administracíon",
            "Ventas",
            "Producción",
            "Compras",
            "Recursos Humanos",
            "Mantenimiento"});
            this.cboDepartamento.Location = new System.Drawing.Point(86, 39);
            this.cboDepartamento.Margin = new System.Windows.Forms.Padding(2);
            this.cboDepartamento.Name = "cboDepartamento";
            this.cboDepartamento.Size = new System.Drawing.Size(92, 21);
            this.cboDepartamento.TabIndex = 32;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(181, 41);
            this.lblCargo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(38, 13);
            this.lblCargo.TabIndex = 33;
            this.lblCargo.Text = "Cargo:";
            // 
            // cboCargo
            // 
            this.cboCargo.FormattingEnabled = true;
            this.cboCargo.Items.AddRange(new object[] {
            "Gerente",
            "Jefe",
            "Vendedor",
            "Operario",
            "Motorista",
            "Secretaria",
            "Asistente",
            "Supervisor",
            "Ejecutivo de venta"});
            this.cboCargo.Location = new System.Drawing.Point(227, 39);
            this.cboCargo.Margin = new System.Windows.Forms.Padding(2);
            this.cboCargo.Name = "cboCargo";
            this.cboCargo.Size = new System.Drawing.Size(92, 21);
            this.cboCargo.TabIndex = 34;
            // 
            // picFoto
            // 
            this.picFoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picFoto.Location = new System.Drawing.Point(415, 61);
            this.picFoto.Margin = new System.Windows.Forms.Padding(2);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(176, 270);
            this.picFoto.TabIndex = 29;
            this.picFoto.TabStop = false;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(123, 214);
            this.dtpFechaNacimiento.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(202, 20);
            this.dtpFechaNacimiento.TabIndex = 35;
            this.dtpFechaNacimiento.Value = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            // 
            // dtpFechaContratacion
            // 
            this.dtpFechaContratacion.Location = new System.Drawing.Point(134, 108);
            this.dtpFechaContratacion.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaContratacion.Name = "dtpFechaContratacion";
            this.dtpFechaContratacion.Size = new System.Drawing.Size(202, 20);
            this.dtpFechaContratacion.TabIndex = 36;
            // 
            // nudPuntuacion
            // 
            this.nudPuntuacion.Location = new System.Drawing.Point(86, 67);
            this.nudPuntuacion.Margin = new System.Windows.Forms.Padding(2);
            this.nudPuntuacion.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudPuntuacion.Name = "nudPuntuacion";
            this.nudPuntuacion.Size = new System.Drawing.Size(90, 20);
            this.nudPuntuacion.TabIndex = 37;
            // 
            // btnExaminar
            // 
            this.btnExaminar.Location = new System.Drawing.Point(465, 364);
            this.btnExaminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(59, 20);
            this.btnExaminar.TabIndex = 38;
            this.btnExaminar.Text = "Examinar";
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // lblExaminar
            // 
            this.lblExaminar.AutoSize = true;
            this.lblExaminar.Location = new System.Drawing.Point(463, 203);
            this.lblExaminar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExaminar.Name = "lblExaminar";
            this.lblExaminar.Size = new System.Drawing.Size(87, 13);
            this.lblExaminar.TabIndex = 39;
            this.lblExaminar.Text = "Ingrese una Foto";
            // 
            // grpDatosPersonales
            // 
            this.grpDatosPersonales.Controls.Add(this.pnlSexo);
            this.grpDatosPersonales.Controls.Add(this.txtNombre);
            this.grpDatosPersonales.Controls.Add(this.lblNombre);
            this.grpDatosPersonales.Controls.Add(this.dtpFechaNacimiento);
            this.grpDatosPersonales.Controls.Add(this.pnlEstadoCivl);
            this.grpDatosPersonales.Controls.Add(this.lblTelefono);
            this.grpDatosPersonales.Controls.Add(this.mtxTelefono);
            this.grpDatosPersonales.Controls.Add(this.lblCorreo);
            this.grpDatosPersonales.Controls.Add(this.txtCorreo);
            this.grpDatosPersonales.Controls.Add(this.lblDUI);
            this.grpDatosPersonales.Controls.Add(this.mtxDUI);
            this.grpDatosPersonales.Controls.Add(this.lblNIT);
            this.grpDatosPersonales.Controls.Add(this.mtxNIT);
            this.grpDatosPersonales.Controls.Add(this.lblFechaNacimiento);
            this.grpDatosPersonales.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpDatosPersonales.Location = new System.Drawing.Point(9, 22);
            this.grpDatosPersonales.Margin = new System.Windows.Forms.Padding(2);
            this.grpDatosPersonales.Name = "grpDatosPersonales";
            this.grpDatosPersonales.Padding = new System.Windows.Forms.Padding(2);
            this.grpDatosPersonales.Size = new System.Drawing.Size(364, 258);
            this.grpDatosPersonales.TabIndex = 40;
            this.grpDatosPersonales.TabStop = false;
            this.grpDatosPersonales.Text = "Datos Personales";
            // 
            // grpDatosLaborales
            // 
            this.grpDatosLaborales.Controls.Add(this.mtxCodigo);
            this.grpDatosLaborales.Controls.Add(this.cboDepartamento);
            this.grpDatosLaborales.Controls.Add(this.lblCodigo);
            this.grpDatosLaborales.Controls.Add(this.lblDepartamento);
            this.grpDatosLaborales.Controls.Add(this.nudPuntuacion);
            this.grpDatosLaborales.Controls.Add(this.lblFechaContratacion);
            this.grpDatosLaborales.Controls.Add(this.dtpFechaContratacion);
            this.grpDatosLaborales.Controls.Add(this.lblPuntuacion);
            this.grpDatosLaborales.Controls.Add(this.cboCargo);
            this.grpDatosLaborales.Controls.Add(this.lblSueldo);
            this.grpDatosLaborales.Controls.Add(this.lblCargo);
            this.grpDatosLaborales.Controls.Add(this.mtxSueldo);
            this.grpDatosLaborales.Location = new System.Drawing.Point(9, 296);
            this.grpDatosLaborales.Margin = new System.Windows.Forms.Padding(2);
            this.grpDatosLaborales.Name = "grpDatosLaborales";
            this.grpDatosLaborales.Padding = new System.Windows.Forms.Padding(2);
            this.grpDatosLaborales.Size = new System.Drawing.Size(364, 180);
            this.grpDatosLaborales.TabIndex = 41;
            this.grpDatosLaborales.TabStop = false;
            this.grpDatosLaborales.Text = "Datos Laborales";
            // 
            // mtxCodigo
            // 
            this.mtxCodigo.Location = new System.Drawing.Point(227, 72);
            this.mtxCodigo.Name = "mtxCodigo";
            this.mtxCodigo.Size = new System.Drawing.Size(92, 20);
            this.mtxCodigo.TabIndex = 38;
            this.mtxCodigo.Click += new System.EventHandler(this.mtxCodigo_Click);
            this.mtxCodigo.Enter += new System.EventHandler(this.mtxCodigo_Enter);
            this.mtxCodigo.Leave += new System.EventHandler(this.mtxCodigo_Leave);
            // 
            // errNombre
            // 
            this.errNombre.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 485);
            this.Controls.Add(this.grpDatosLaborales);
            this.Controls.Add(this.grpDatosPersonales);
            this.Controls.Add(this.lblExaminar);
            this.Controls.Add(this.btnExaminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.picFoto);
            this.Controls.Add(this.btnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Achilles Recruitment";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlSexo.ResumeLayout(false);
            this.pnlSexo.PerformLayout();
            this.pnlEstadoCivl.ResumeLayout(false);
            this.pnlEstadoCivl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errCorreo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPuntuacion)).EndInit();
            this.grpDatosPersonales.ResumeLayout(false);
            this.grpDatosPersonales.PerformLayout();
            this.grpDatosLaborales.ResumeLayout(false);
            this.grpDatosLaborales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errNombre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Panel pnlSexo;
        private System.Windows.Forms.RadioButton rdoFemenino;
        private System.Windows.Forms.RadioButton rdoMasculino;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Panel pnlEstadoCivl;
        private System.Windows.Forms.RadioButton rdoSoltero;
        private System.Windows.Forms.Label lblEstadoCivil;
        private System.Windows.Forms.RadioButton rdoCasado;
        private System.Windows.Forms.RadioButton rdoDivorciado;
        private System.Windows.Forms.RadioButton rdoViudo;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.MaskedTextBox mtxTelefono;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblDUI;
        private System.Windows.Forms.MaskedTextBox mtxDUI;
        private System.Windows.Forms.Label lblNIT;
        private System.Windows.Forms.MaskedTextBox mtxNIT;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.Label lblFechaContratacion;
        private System.Windows.Forms.Label lblPuntuacion;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.MaskedTextBox mtxSueldo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.ErrorProvider errCorreo;
        private System.Windows.Forms.ComboBox cboDepartamento;
        private System.Windows.Forms.ComboBox cboCargo;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.DateTimePicker dtpFechaContratacion;
        private System.Windows.Forms.NumericUpDown nudPuntuacion;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.Label lblExaminar;
        private System.Windows.Forms.GroupBox grpDatosPersonales;
        private System.Windows.Forms.GroupBox grpDatosLaborales;
        private System.Windows.Forms.ErrorProvider errNombre;
        private System.Windows.Forms.MaskedTextBox mtxCodigo;
    }
}

