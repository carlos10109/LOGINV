namespace presentacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.txtusu = new System.Windows.Forms.TextBox();
            this.txtcontra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnacce = new System.Windows.Forms.Button();
            this.btnlink = new System.Windows.Forms.LinkLabel();
            this.salir = new System.Windows.Forms.PictureBox();
            this.minimizar = new System.Windows.Forms.PictureBox();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.btninicio = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btninicio)).BeginInit();
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(486, 517);
            this.shapeContainer1.TabIndex = 1;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 45;
            this.lineShape2.X2 = 182;
            this.lineShape2.Y1 = 379;
            this.lineShape2.Y2 = 379;
            this.lineShape2.Click += new System.EventHandler(this.LineShape2_Click);
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.Maroon;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 21;
            this.lineShape1.X2 = 428;
            this.lineShape1.Y1 = 449;
            this.lineShape1.Y2 = 449;
            this.lineShape1.Click += new System.EventHandler(this.LineShape1_Click);
            // 
            // txtusu
            // 
            this.txtusu.BackColor = System.Drawing.Color.White;
            this.txtusu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtusu.Location = new System.Drawing.Point(41, 199);
            this.txtusu.Name = "txtusu";
            this.txtusu.Size = new System.Drawing.Size(412, 24);
            this.txtusu.TabIndex = 1;
            this.txtusu.Text = "USUARIO";
            this.txtusu.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            this.txtusu.Enter += new System.EventHandler(this.Txtusu_Enter);
            this.txtusu.Leave += new System.EventHandler(this.Txtusu_Leave);
            // 
            // txtcontra
            // 
            this.txtcontra.BackColor = System.Drawing.Color.White;
            this.txtcontra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtcontra.Location = new System.Drawing.Point(41, 244);
            this.txtcontra.Name = "txtcontra";
            this.txtcontra.Size = new System.Drawing.Size(408, 24);
            this.txtcontra.TabIndex = 2;
            this.txtcontra.Text = "CONTRASEÑA";
            this.txtcontra.TextChanged += new System.EventHandler(this.Txtcontra_TextChanged);
            this.txtcontra.Enter += new System.EventHandler(this.Txtcontra_Enter);
            this.txtcontra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtcontra_KeyPress);
            this.txtcontra.Leave += new System.EventHandler(this.Txtcontra_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(55, 426);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 33);
            this.label1.TabIndex = 4;
            // 
            // btnacce
            // 
            this.btnacce.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(152)))), ((int)(((byte)(200)))));
            this.btnacce.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnacce.FlatAppearance.BorderSize = 0;
            this.btnacce.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnacce.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnacce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnacce.ForeColor = System.Drawing.Color.Transparent;
            this.btnacce.Location = new System.Drawing.Point(45, 274);
            this.btnacce.Name = "btnacce";
            this.btnacce.Size = new System.Drawing.Size(401, 29);
            this.btnacce.TabIndex = 3;
            this.btnacce.Text = "ACCEDER";
            this.btnacce.UseVisualStyleBackColor = false;
            this.btnacce.Click += new System.EventHandler(this.Btnacce_Click);
            // 
            // btnlink
            // 
            this.btnlink.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(44)))), ((int)(((byte)(101)))));
            this.btnlink.AutoSize = true;
            this.btnlink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlink.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnlink.LinkColor = System.Drawing.Color.DimGray;
            this.btnlink.Location = new System.Drawing.Point(137, 388);
            this.btnlink.Name = "btnlink";
            this.btnlink.Size = new System.Drawing.Size(209, 15);
            this.btnlink.TabIndex = 0;
            this.btnlink.TabStop = true;
            this.btnlink.Text = "¿HAS OLVIDADO LA CONTRASEÑA?";
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(152)))), ((int)(((byte)(200)))));
            this.salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salir.Image = ((System.Drawing.Image)(resources.GetObject("salir.Image")));
            this.salir.Location = new System.Drawing.Point(452, 0);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(38, 42);
            this.salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.salir.TabIndex = 7;
            this.salir.TabStop = false;
            this.salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // minimizar
            // 
            this.minimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(152)))), ((int)(((byte)(200)))));
            this.minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizar.Image = ((System.Drawing.Image)(resources.GetObject("minimizar.Image")));
            this.minimizar.Location = new System.Drawing.Point(413, 0);
            this.minimizar.Name = "minimizar";
            this.minimizar.Size = new System.Drawing.Size(33, 42);
            this.minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimizar.TabIndex = 8;
            this.minimizar.TabStop = false;
            this.minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(152)))), ((int)(((byte)(200)))));
            this.lblErrorMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblErrorMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMessage.ForeColor = System.Drawing.Color.Black;
            this.lblErrorMessage.Image = ((System.Drawing.Image)(resources.GetObject("lblErrorMessage.Image")));
            this.lblErrorMessage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblErrorMessage.Location = new System.Drawing.Point(58, 335);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(103, 19);
            this.lblErrorMessage.TabIndex = 9;
            this.lblErrorMessage.Text = "Error Message";
            this.lblErrorMessage.Visible = false;
            this.lblErrorMessage.Click += new System.EventHandler(this.LblErrorMessage_Click);
            // 
            // btninicio
            // 
            this.btninicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(231)))), ((int)(((byte)(240)))));
            this.btninicio.Image = ((System.Drawing.Image)(resources.GetObject("btninicio.Image")));
            this.btninicio.Location = new System.Drawing.Point(145, 47);
            this.btninicio.Name = "btninicio";
            this.btninicio.Size = new System.Drawing.Size(201, 146);
            this.btninicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btninicio.TabIndex = 10;
            this.btninicio.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(231)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(486, 517);
            this.Controls.Add(this.btninicio);
            this.Controls.Add(this.btnlink);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.btnacce);
            this.Controls.Add(this.minimizar);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcontra);
            this.Controls.Add(this.txtusu);
            this.Controls.Add(this.shapeContainer1);
            this.ForeColor = System.Drawing.Color.LightGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.salir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btninicio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.TextBox txtusu;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.TextBox txtcontra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnacce;
        private System.Windows.Forms.LinkLabel btnlink;
        private System.Windows.Forms.PictureBox salir;
        private System.Windows.Forms.PictureBox minimizar;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.PictureBox btninicio;
    }
}

