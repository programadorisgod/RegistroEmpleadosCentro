using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Presentacion_GUI
{
    public partial class RegistroClientes : Form
    {
        int p = -1;
        Cliente cliente = new Cliente();   
        public RegistroClientes()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        
        void Guardar()
        {
            if (txtCedula.Text==string.Empty ||txtNombre.Text == string.Empty || txtTelefono.Text ==string.Empty || txtIdempleado.Text == string.Empty)
            {
                MessageBox.Show("Llene todos los campos, por favor");
            }
            else
            {
                if (p == -1)
                {
                   // cliente.c
                }
            }
        }
        
        
        
        
        
        private void btnguardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void RegistroClientes_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
