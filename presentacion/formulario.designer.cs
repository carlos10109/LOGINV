namespace presentacion
{
    partial class formulario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formulario));
            this.barratitulo = new System.Windows.Forms.Panel();
            this.restaurar = new System.Windows.Forms.PictureBox();
            this.maximizar = new System.Windows.Forms.PictureBox();
            this.minimizar = new System.Windows.Forms.PictureBox();
            this.salir = new System.Windows.Forms.PictureBox();
            this.menuvertical = new System.Windows.Forms.Panel();
            this.btninicio = new System.Windows.Forms.PictureBox();
            this.button6 = new System.Windows.Forms.Button();
            this.submenureportes = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txtrecompra = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txtrepago = new System.Windows.Forms.Button();
            this.txtreventa = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtreporte = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnproducto = new System.Windows.Forms.Button();
            this.panelcontenedor = new System.Windows.Forms.Panel();
            this.barratitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salir)).BeginInit();
            this.menuvertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btninicio)).BeginInit();
            this.submenureportes.SuspendLayout();
            this.SuspendLayout();
            // 
            // barratitulo
            // 
            this.barratitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(207)))), ((int)(((byte)(245)))));
            this.barratitulo.Controls.Add(this.restaurar);
            this.barratitulo.Controls.Add(this.maximizar);
            this.barratitulo.Controls.Add(this.minimizar);
            this.barratitulo.Controls.Add(this.salir);
            this.barratitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.barratitulo.Location = new System.Drawing.Point(0, 0);
            this.barratitulo.Name = "barratitulo";
            this.barratitulo.Size = new System.Drawing.Size(1300, 42);
            this.barratitulo.TabIndex = 0;
            this.barratitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.Barratitulo_Paint);
            this.barratitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Barratitulo_MouseDown);
            // 
            // restaurar
            // 
            this.restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.restaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.restaurar.Image = ((System.Drawing.Image)(resources.GetObject("restaurar.Image")));
            this.restaurar.Location = new System.Drawing.Point(1232, 7);
            this.restaurar.Name = "restaurar";
            this.restaurar.Size = new System.Drawing.Size(25, 25);
            this.restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.restaurar.TabIndex = 1;
            this.restaurar.TabStop = false;
            this.restaurar.Click += new System.EventHandler(this.Restaurar_Click);
            // 
            // maximizar
            // 
            this.maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maximizar.Image = ((System.Drawing.Image)(resources.GetObject("maximizar.Image")));
            this.maximizar.Location = new System.Drawing.Point(1232, 7);
            this.maximizar.Name = "maximizar";
            this.maximizar.Size = new System.Drawing.Size(25, 25);
            this.maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.maximizar.TabIndex = 3;
            this.maximizar.TabStop = false;
            this.maximizar.Visible = false;
            this.maximizar.Click += new System.EventHandler(this.Maximizar_Click);
            // 
            // minimizar
            // 
            this.minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizar.Image = ((System.Drawing.Image)(resources.GetObject("minimizar.Image")));
            this.minimizar.Location = new System.Drawing.Point(1201, 7);
            this.minimizar.Name = "minimizar";
            this.minimizar.Size = new System.Drawing.Size(25, 25);
            this.minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimizar.TabIndex = 2;
            this.minimizar.TabStop = false;
            this.minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // salir
            // 
            this.salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salir.Image = ((System.Drawing.Image)(resources.GetObject("salir.Image")));
            this.salir.Location = new System.Drawing.Point(1263, 7);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(25, 25);
            this.salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.salir.TabIndex = 0;
            this.salir.TabStop = false;
            this.salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // menuvertical
            // 
            this.menuvertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(156)))));
            this.menuvertical.Controls.Add(this.btninicio);
            this.menuvertical.Controls.Add(this.button6);
            this.menuvertical.Controls.Add(this.submenureportes);
            this.menuvertical.Controls.Add(this.panel7);
            this.menuvertical.Controls.Add(this.panel6);
            this.menuvertical.Controls.Add(this.txtreporte);
            this.menuvertical.Controls.Add(this.button5);
            this.menuvertical.Controls.Add(this.panel5);
            this.menuvertical.Controls.Add(this.button4);
            this.menuvertical.Controls.Add(this.button3);
            this.menuvertical.Controls.Add(this.panel4);
            this.menuvertical.Controls.Add(this.panel3);
            this.menuvertical.Controls.Add(this.button1);
            this.menuvertical.Controls.Add(this.panel1);
            this.menuvertical.Controls.Add(this.btnproducto);
            this.menuvertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuvertical.Location = new System.Drawing.Point(0, 42);
            this.menuvertical.Name = "menuvertical";
            this.menuvertical.Size = new System.Drawing.Size(220, 608);
            this.menuvertical.TabIndex = 1;
            this.menuvertical.Paint += new System.Windows.Forms.PaintEventHandler(this.Menuvertical_Paint);
            // 
            // btninicio
            // 
            this.btninicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(156)))));
            this.btninicio.Image = ((System.Drawing.Image)(resources.GetObject("btninicio.Image")));
            this.btninicio.Location = new System.Drawing.Point(0, -13);
            this.btninicio.Name = "btninicio";
            this.btninicio.Size = new System.Drawing.Size(220, 160);
            this.btninicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btninicio.TabIndex = 0;
            this.btninicio.TabStop = false;
            this.btninicio.Click += new System.EventHandler(this.Btninicio_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(108)))), ((int)(((byte)(140)))));
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(3, 573);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(220, 32);
            this.button6.TabIndex = 11;
            this.button6.Text = "SALIR";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // submenureportes
            // 
            this.submenureportes.Controls.Add(this.panel10);
            this.submenureportes.Controls.Add(this.txtrecompra);
            this.submenureportes.Controls.Add(this.panel11);
            this.submenureportes.Controls.Add(this.panel9);
            this.submenureportes.Controls.Add(this.txtrepago);
            this.submenureportes.Controls.Add(this.txtreventa);
            this.submenureportes.Location = new System.Drawing.Point(33, 388);
            this.submenureportes.Name = "submenureportes";
            this.submenureportes.Size = new System.Drawing.Size(181, 100);
            this.submenureportes.TabIndex = 10;
            this.submenureportes.Visible = false;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(59)))), ((int)(((byte)(91)))));
            this.panel10.Location = new System.Drawing.Point(2, 38);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(5, 28);
            this.panel10.TabIndex = 7;
            // 
            // txtrecompra
            // 
            this.txtrecompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(108)))), ((int)(((byte)(140)))));
            this.txtrecompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtrecompra.FlatAppearance.BorderSize = 0;
            this.txtrecompra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(207)))), ((int)(((byte)(245)))));
            this.txtrecompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtrecompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrecompra.ForeColor = System.Drawing.Color.Black;
            this.txtrecompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtrecompra.Location = new System.Drawing.Point(2, 36);
            this.txtrecompra.Name = "txtrecompra";
            this.txtrecompra.Size = new System.Drawing.Size(176, 28);
            this.txtrecompra.TabIndex = 12;
            this.txtrecompra.Text = "CASOS NUEVOS";
            this.txtrecompra.UseVisualStyleBackColor = false;
            this.txtrecompra.Click += new System.EventHandler(this.Txtrepago_Click);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(59)))), ((int)(((byte)(91)))));
            this.panel11.Location = new System.Drawing.Point(2, 72);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(5, 28);
            this.panel11.TabIndex = 7;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(59)))), ((int)(((byte)(91)))));
            this.panel9.Location = new System.Drawing.Point(3, 4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(5, 28);
            this.panel9.TabIndex = 6;
            // 
            // txtrepago
            // 
            this.txtrepago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(108)))), ((int)(((byte)(140)))));
            this.txtrepago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtrepago.FlatAppearance.BorderSize = 0;
            this.txtrepago.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(207)))), ((int)(((byte)(245)))));
            this.txtrepago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtrepago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrepago.ForeColor = System.Drawing.Color.Black;
            this.txtrepago.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtrepago.Location = new System.Drawing.Point(5, 69);
            this.txtrepago.Name = "txtrepago";
            this.txtrepago.Size = new System.Drawing.Size(176, 28);
            this.txtrepago.TabIndex = 13;
            this.txtrepago.Text = "PANDEMIAS";
            this.txtrepago.UseVisualStyleBackColor = false;
            this.txtrepago.Click += new System.EventHandler(this.Txtrepago_Click);
            // 
            // txtreventa
            // 
            this.txtreventa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(108)))), ((int)(((byte)(140)))));
            this.txtreventa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtreventa.FlatAppearance.BorderSize = 0;
            this.txtreventa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(207)))), ((int)(((byte)(245)))));
            this.txtreventa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtreventa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtreventa.ForeColor = System.Drawing.Color.Black;
            this.txtreventa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtreventa.Location = new System.Drawing.Point(6, 4);
            this.txtreventa.Name = "txtreventa";
            this.txtreventa.Size = new System.Drawing.Size(175, 28);
            this.txtreventa.TabIndex = 11;
            this.txtreventa.Text = "ENFERMEDADES";
            this.txtreventa.UseVisualStyleBackColor = false;
            this.txtreventa.Click += new System.EventHandler(this.Txtreventa_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(59)))), ((int)(((byte)(91)))));
            this.panel7.Location = new System.Drawing.Point(2, 350);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(5, 32);
            this.panel7.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(59)))), ((int)(((byte)(91)))));
            this.panel6.Location = new System.Drawing.Point(3, 305);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(5, 32);
            this.panel6.TabIndex = 5;
            // 
            // txtreporte
            // 
            this.txtreporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(108)))), ((int)(((byte)(140)))));
            this.txtreporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtreporte.FlatAppearance.BorderSize = 0;
            this.txtreporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(207)))), ((int)(((byte)(245)))));
            this.txtreporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtreporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtreporte.ForeColor = System.Drawing.Color.Black;
            this.txtreporte.Image = ((System.Drawing.Image)(resources.GetObject("txtreporte.Image")));
            this.txtreporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtreporte.Location = new System.Drawing.Point(5, 350);
            this.txtreporte.Name = "txtreporte";
            this.txtreporte.Size = new System.Drawing.Size(217, 32);
            this.txtreporte.TabIndex = 9;
            this.txtreporte.Text = "REPORTE";
            this.txtreporte.UseVisualStyleBackColor = false;
            this.txtreporte.Click += new System.EventHandler(this.Txtreporte_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(108)))), ((int)(((byte)(140)))));
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(207)))), ((int)(((byte)(245)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(4, 305);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(217, 32);
            this.button5.TabIndex = 8;
            this.button5.Text = "CONSULTAS";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(59)))), ((int)(((byte)(91)))));
            this.panel5.Location = new System.Drawing.Point(2, 267);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(5, 32);
            this.panel5.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(108)))), ((int)(((byte)(140)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(207)))), ((int)(((byte)(245)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(5, 267);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(217, 32);
            this.button4.TabIndex = 7;
            this.button4.Text = "EMPLEADOS";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(108)))), ((int)(((byte)(140)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(207)))), ((int)(((byte)(245)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(9, 191);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(216, 32);
            this.button3.TabIndex = 6;
            this.button3.Text = "USUARIOS";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(59)))), ((int)(((byte)(91)))));
            this.panel4.Location = new System.Drawing.Point(3, 229);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 32);
            this.panel4.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(59)))), ((int)(((byte)(91)))));
            this.panel3.Location = new System.Drawing.Point(3, 191);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 32);
            this.panel3.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(108)))), ((int)(((byte)(140)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(207)))), ((int)(((byte)(245)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(5, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "PACIENTES";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(59)))), ((int)(((byte)(91)))));
            this.panel1.Location = new System.Drawing.Point(1, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 32);
            this.panel1.TabIndex = 2;
            // 
            // btnproducto
            // 
            this.btnproducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(108)))), ((int)(((byte)(140)))));
            this.btnproducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnproducto.FlatAppearance.BorderSize = 0;
            this.btnproducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(207)))), ((int)(((byte)(245)))));
            this.btnproducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnproducto.ForeColor = System.Drawing.Color.Black;
            this.btnproducto.Image = ((System.Drawing.Image)(resources.GetObject("btnproducto.Image")));
            this.btnproducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnproducto.Location = new System.Drawing.Point(3, 153);
            this.btnproducto.Name = "btnproducto";
            this.btnproducto.Size = new System.Drawing.Size(217, 32);
            this.btnproducto.TabIndex = 1;
            this.btnproducto.Text = "PRODUCTO";
            this.btnproducto.UseVisualStyleBackColor = false;
            this.btnproducto.Click += new System.EventHandler(this.Btnproducto_Click);
            // 
            // panelcontenedor
            // 
            this.panelcontenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(156)))));
            this.panelcontenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcontenedor.Location = new System.Drawing.Point(220, 42);
            this.panelcontenedor.Name = "panelcontenedor";
            this.panelcontenedor.Size = new System.Drawing.Size(1080, 608);
            this.panelcontenedor.TabIndex = 2;
            this.panelcontenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.Panelcontenedor_Paint);
            // 
            // formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.panelcontenedor);
            this.Controls.Add(this.menuvertical);
            this.Controls.Add(this.barratitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formulario";
            this.Text = "formulario";
            this.Load += new System.EventHandler(this.Formulario_Load);
            this.barratitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salir)).EndInit();
            this.menuvertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btninicio)).EndInit();
            this.submenureportes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel barratitulo;
        private System.Windows.Forms.PictureBox salir;
        private System.Windows.Forms.Panel menuvertical;
        private System.Windows.Forms.Panel panelcontenedor;
        private System.Windows.Forms.PictureBox restaurar;
        private System.Windows.Forms.PictureBox maximizar;
        private System.Windows.Forms.PictureBox minimizar;
        private System.Windows.Forms.Button btnproducto;
        private System.Windows.Forms.PictureBox btninicio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button txtreporte;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel submenureportes;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button txtrepago;
        private System.Windows.Forms.Button txtrecompra;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button txtreventa;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel3;
    }
}