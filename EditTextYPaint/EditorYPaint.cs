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
    public partial class EditorYPaint : Form
    {
        public EditorYPaint()
        {
            InitializeComponent();
        }

        private void EditorYPaint_Load(object sender, EventArgs e)
        {

        }

        private void editorDeTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditText E = new EditText();
            AddFormulario(E);

        }
        
            public void AddFormulario(Form f)
            {

            if (this.panel1.Controls.Count > 0)
            {
                this.panel1.Controls.RemoveAt(0);
            }

                f.TopLevel = false;
            this.panel1.Controls.Add(f);
            f.Dock = DockStyle.Fill;
            f.Show();
            }

        private void paintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Paint E = new Paint();
            AddFormulario(E);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    }
