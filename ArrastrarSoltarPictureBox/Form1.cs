using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrastrarSoltarPictureBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Nos permite arrastrar la foto al otro pictureBox
            this.picBoxIzq.AllowDrop = true;
            this.picBoxDer.AllowDrop = true;
            //Le asignamos que haga lo mismo que el evento que tiene entre parentesis
            picBoxDer.MouseDown += new MouseEventHandler(picBoxIzq_MouseDown);
            picBoxDer.DragEnter += new DragEventHandler(picBoxIzq_DragEnter);
            picBoxDer.DragDrop += new DragEventHandler(picBoxIzq_DragDrop);

        }
        //Se produce cuando presionamos el boton izquierdo del raton
        private void picBoxIzq_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pictBox = (PictureBox)sender;

            if (pictBox.Image == null)
            {
                MessageBox.Show("No hay imagenes.");
            } else
            {
                //Comienza una operacion de arrastrar y soltar
                pictBox.DoDragDrop(pictBox.Image, DragDropEffects.Copy);
            }
        }
        //Se produce cuando se arrastra la imagen dentro del pictureBox
        private void picBoxIzq_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                //Se muestra el puntero de copia en la operacion de arrastrar y soltar
                e.Effect = DragDropEffects.Copy;
            } else
            {
                //Se muestra el puntero normal
                e.Effect = DragDropEffects.None;
            }
        }
        //Se produce cuando se inicia una operacion de arrastrar y colocar
        private void picBoxIzq_DragDrop(object sender, DragEventArgs e)
        {
            //Hace que se pegue la imagen en el otro pictureBox
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
        }
    }
}
