using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditTextYPaint
{
    public partial class EditText : Form


    {
        string archivo;
        public EditText()
        {
            InitializeComponent();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFile = new OpenFileDialog();
            //Filtro para que solo acepte archivos txt
            OpenFile.Filter = "Texto |*.txt";

            //Indico si tolo sali bien(ok) permita abrir el nuevo documento
            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                //Lo guardo en mi variable
                archivo = OpenFile.FileName;
                // indico lo siguiente
                using (StreamReader sr = new StreamReader(archivo))
                {
                    richTextBox1.Text = sr.ReadToEnd();
                }
            }


        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveFile = new SaveFileDialog();
            SaveFile.Filter = "Texto |*.txt";

            // para que no me guarde archivo vacio
            if (archivo != null)
            {
                using (StreamWriter sw = new StreamWriter(archivo))
                {
                    sw.Write(richTextBox1.Text);
                }
            }
            else
            {
                if (SaveFile.ShowDialog() == DialogResult.OK)
                {
                    archivo = SaveFile.FileName;

                    using (StreamWriter sw = new StreamWriter(archivo))
                    {
                        sw.Write(richTextBox1.Text);
                    }
                }

            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        
           
        }
    }
