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
    public partial class Paint : Form
    {
        public Paint()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            
            
                ColorDialog MyDialog = new ColorDialog();
            // Evita que el usuario seleccione un color personalizado.
            MyDialog.AllowFullOpen = false;
            // Permite al usuario obtener ayuda. (El valor predeterminado es falso.)
            MyDialog.ShowHelp = true;
            // Establece la selección de color inicial en el color de texto actual.
            MyDialog.Color = textBox1.ForeColor;

            // Actualizar el color del cuadro de texto si el usuario hace clic en Aceptar
            if (MyDialog.ShowDialog() == DialogResult.OK)
                    textBox1.ForeColor = MyDialog.Color;
                    textBox1.BackColor = MyDialog.Color;
                    
        }
        }
}
