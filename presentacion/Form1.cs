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
using Dominio1;
using Common.Cache;

namespace presentacion

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txtusu_Enter(object sender, EventArgs e)
        {
            if(txtusu.Text == "USUARIO")//focus para el cursor al darle click que desaparesca 
            {
                txtusu.Text = "";
                txtusu.ForeColor = Color.Black;
            }
        }

        private void Txtusu_Leave(object sender, EventArgs e)
        {
            if (txtusu.Text == "")//leave para el cursor 
            {
                txtusu.Text = "USUARIO";
                txtusu.ForeColor = Color.Black;

            }
        }

        private void Txtcontra_Enter(object sender, EventArgs e)
        {
            if(txtcontra.Text == "CONTRASEÑA")//focus para el cursor al darle click que desaparesca
            {
                txtcontra.Text = "";
                txtcontra.ForeColor = Color.Black;
                txtcontra.UseSystemPasswordChar = true;
            }
        }

        private void Txtcontra_Leave(object sender, EventArgs e)
        {
            if (txtcontra.Text == "")//para el cursor
            {
                txtcontra.Text = "CONTRASEÑA";
                txtcontra.ForeColor = Color.Black;
                txtcontra.UseSystemPasswordChar = false;
            }
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btnacce_Click(object sender, EventArgs e)
        {
            if (txtusu.Text != "Username" && txtusu.TextLength > 2)
            {
                if (txtcontra.Text != "password") {
                    usermodel user = new usermodel(); //INSTANCIAMOS LA CAPA DE DOMINIO
                    var validLogin = user.LoginUser(txtusu.Text, txtcontra.Text); // DECLARACION DE LA VARIABLE IMPLICITA PARA PARAMETRO EL TEXBOX
                    if(validLogin == true)// VAMOS A INSTANCIAR
                    {

                        this.Hide();
                        Bienvenida Bienvenida = new Bienvenida();
                        Bienvenida.ShowDialog();

                        formulario mainmenu = new formulario();
                        mainmenu.Show();
                        mainmenu.FormClosed += Logout;
                        
                    }
                    else
                    {
                        msgError("incorrect username or password entered. \n please try again. ");//MENSSAGE INCORRECT
             
                        txtcontra.Text = "CONTRASEÑA";
                        txtcontra.UseSystemPasswordChar = false;
                        txtusu.Focus();
                        
                    }

                }
                else msgError("please enter password");
            }
            else msgError("please enter username");
        }
        private void msgError(string msg)// ES UN PARAMETRO 
        {
            lblErrorMessage.Text = "      " + msg;// PARAMETRO DE ENTRADA
            lblErrorMessage.Visible = true;
        }



        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtcontra.Text = "CONTRASEÑA";
            txtcontra.UseSystemPasswordChar = false;
            txtusu.Text = "USUARIO";
            lblErrorMessage.Visible = false;
            this.Show();
           
        }



        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 161;

        private const int HTCAPTION = 2;


        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void LineShape1_Click(object sender, EventArgs e)
        {

        }

        private void LineShape2_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {


        }

        private void LblErrorMessage_Click(object sender, EventArgs e)
        {

        }

        private void Txtcontra_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txtcontra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtusu.Text != "Username" && txtusu.TextLength > 2)
                {
                    if (txtcontra.Text != "password")
                    {
                        usermodel user = new usermodel(); //INSTANCIAMOS LA CAPA DE DOMINIO
                        var validLogin = user.LoginUser(txtusu.Text, txtcontra.Text); // DECLARACION DE LA VARIABLE IMPLICITA PARA PARAMETRO EL TEXBOX
                        if (validLogin == true)// VAMOS A INSTANCIAR
                        {

                            this.Hide();
                            Bienvenida Bienvenida = new Bienvenida();
                            Bienvenida.ShowDialog();

                            formulario mainmenu = new formulario();
                            mainmenu.Show();
                            mainmenu.FormClosed += Logout;

                        }
                        else
                        {
                            msgError("incorrect username or password entered. \n please try again. ");//MENSSAGE INCORRECT

                            txtcontra.Text = "CONTRASEÑA";
                            txtcontra.UseSystemPasswordChar = false;
                            txtusu.Focus();

                        }

                    }
                    else msgError("please enter password");
                }
                else msgError("please enter username");


            }
        }
    }
}
