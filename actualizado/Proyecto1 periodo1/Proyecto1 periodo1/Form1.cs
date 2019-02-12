using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace Proyecto1_periodo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        //BOTON DE SALIR
        private void btnSalir_Click(object sender, EventArgs e)
        {
                this.Close();   
        }
        //CODIGO DE CERRA FORM CLOSING
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Quiere salir del formulario?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        //CODIGO DE LIMPIEZA
        //falta limpieza de la puntuacion,y las fechas de nacimiento y contratacion
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" ||  mtxTelefono.Text == "" || mtxDUI.Text == "" || mtxNIT.Text == "" || txtCorreo.Text == "" || cboDepartamento.Text == null || cboCargo.Text == null || mtxSueldo.Text == "" || mtxCodigo.Text=="")
            {
                MessageBox.Show("Ingrese datos", "falta de informacion");
            }
            else  
            {
                MessageBox.Show("Se guardó satisfactoriamente", "Guardado Correcto");
                this.Refresh();
                txtNombre.Clear();
                this.rdoFemenino.Checked = false;
                this.rdoMasculino.Checked = false;
                this.rdoCasado.Checked = false;
                this.rdoDivorciado.Checked = false;
                this.rdoSoltero.Checked = false;
                this.rdoViudo.Checked = false;
                mtxTelefono.Clear();
                mtxDUI.Clear();
                mtxNIT.Clear();
                mtxCodigo.Clear();
                txtCorreo.Clear();
                dtpFechaContratacion.Format = DateTimePickerFormat.Long;
                dtpFechaContratacion.CustomFormat = " ";
                cboCargo.Text = "";
                cboDepartamento.ResetText();
                
                dtpFechaNacimiento.Format = DateTimePickerFormat.Long;
                dtpFechaContratacion.CustomFormat = " ";
                mtxSueldo.Clear();
                picFoto.Image = null;

            }

        }
        //FORMATO DE VALIDACION DE CORREO
        private void txtCorreo_Validating(object sender, CancelEventArgs e)
        {
            string patron = @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";
            if(txtCorreo.Text == "")
            {

            }
            else if (Regex.IsMatch(txtCorreo.Text, patron) == false)
            {
                e.Cancel = true;
                txtCorreo.SelectAll();
                errCorreo.SetError(txtCorreo, "Ingrese el formato correcto de correo: ejemplo23@gmail.com");
            }

        }
        //LIMPIAR EL ERROR PROVIDER DEL CORREO POR SI SE INGRESA MAL EL FORMATO DEL CORREO
        private void txtCorreo_Validated(object sender, EventArgs e)
        {
            errCorreo.Clear();
        }
        //PROGRAMACION DE BOTON EXAMINAR FOTO
        private void btnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog imagen = new OpenFileDialog();
            imagen.Filter = "Archivos de imagen|*.jpg";
            imagen.FileName = "";
            imagen.Title = "Buscar imagen";
            imagen.InitialDirectory = "C:\\";
            if (imagen.ShowDialog() == DialogResult.OK)
            {
                string NombreDireccion = imagen.FileName;
                this.picFoto.ImageLocation = NombreDireccion;
                picFoto.SizeMode = PictureBoxSizeMode.StretchImage;
                lblExaminar.Visible = false;
            }
        }
        //VALIDACION NOMBRE
        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
            string patronNombre = @"^([A-ZÁÉÍÓÚ]{1}[a-zñáéíóú]+[\s]*)+$";
            if (txtNombre.Text == "")
            {

            }
            else if (Regex.IsMatch(txtNombre.Text, patronNombre) == false)
            {
                e.Cancel = true;
                txtNombre.SelectAll();
                errNombre.SetError(txtNombre, "Ingrese por lo menos un nombre y un apellido");
            }

        }

        private void txtNombre_Validated(object sender, EventArgs e)
        {
            errNombre.Clear();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            this.mtxCodigo.Mask = "99999";
            this.mtxCodigo.PromptChar = '0';
            
        }

        //VALIDACIÓN CÓDIGO

        private void mtxCodigo_Enter(object sender, EventArgs e)
        {
            this.mtxCodigo.PromptChar = '_';
            this.mtxCodigo.Text = this.mtxCodigo.Text.TrimStart();
        }

        private void mtxCodigo_Leave(object sender, EventArgs e)
        {
            this.mtxCodigo.Text = this.mtxCodigo.Text.PadLeft(this.mtxCodigo.Mask.Length);
            this.mtxCodigo.PromptChar = '0';
        }

        private void mtxCodigo_Click(object sender, EventArgs e)
        {
            this.mtxCodigo.Focus();
            this.mtxCodigo.Select(0, 0);
        }

        private void mtxCodigo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            tipNIT.ToolTipTitle = "Entrada Incorrecta";
            tipNIT.Show("Sólo números",mtxNIT,mtxNIT.Location, 5000);
        }

        private void mtxSueldo_Click(object sender, EventArgs e)
        {
            mtxSueldo.Focus();
            mtxSueldo.Select(0, 0);
        }

        private void mtxSueldo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            tipSueldo.ToolTipTitle = "Entrada Incorrecta";
            tipSueldo.Show("Sólo números", mtxSueldo, mtxSueldo.Location, 5000);
        }
    }
}
