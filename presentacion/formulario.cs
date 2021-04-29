using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace presentacion
{
    public partial class formulario : Form
    {
        public formulario()
        {
            InitializeComponent();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Maximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            maximizar.Visible = false;
            restaurar.Visible = true;

        }

        private void Restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            restaurar.Visible = false;
            maximizar.Visible = true;
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 161;

        private const int HTCAPTION = 2;

        private void Barratitulo_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Txtreporte_Click(object sender, EventArgs e)
        {
            submenureportes.Visible = true;
        }

        private void Txtreventa_Click(object sender, EventArgs e)
        {
            submenureportes.Visible = false;
            Rayado ray = new Rayado();
            ray.Show();
        }

        private void Txtrecompra_Click(object sender, EventArgs e)
        {
            submenureportes.Visible = false;

        }

        private void Txtrepago_Click(object sender, EventArgs e)
        {
            submenureportes.Visible = false;
        }

        private void AbrirFormHija(object formhija)
        {
            if (this.panelcontenedor.Controls.Count > 0)
                this.panelcontenedor.Controls.RemoveAt(0);

            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelcontenedor.Controls.Add(fh);
            this.panelcontenedor.Tag = fh;
            fh.Show();


        }

        private void Btnproducto_Click(object sender, EventArgs e)
        {
            PRODUCTO pro = new PRODUCTO();
            pro.Show();

            Rayado ray = new Rayado();
            new Rayado();

            

            
        }

        private void Btninicio_Click(object sender, EventArgs e)
        {

            PRODUCTO pro = new PRODUCTO();
            new PRODUCTO();
            AbrirFormHija(new inicio());
        }

        private void Panelcontenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Barratitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Menuvertical_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Formulario_Load(object sender, EventArgs e)
        {
            Btninicio_Click(null, e);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas cerrar sesion? ", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void txtcatalago_Click(object sender, EventArgs e)
        {
            submenureportes.Visible = false;
        }

        private void Txtcatalago_Click(object sender, EventArgs e)
        {
            submenureportes.Visible = false;
        }

        private void Btncatalago_Click(object sender, EventArgs e)
        {
            
           
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Usuario usu = new Usuario();
            usu.Show();
        }
    }
}
