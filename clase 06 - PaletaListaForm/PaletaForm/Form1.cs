using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PaletaLibreria;

namespace PaletaForm
{
    public partial class Form1 : Form
    {
        private List<Tempera> _temperas;

        public Form1()
        {
            InitializeComponent();
            this._temperas = new List<Tempera>();
        }

        //public void CargaTempera(Tempera t)
        //{
        //    this._temperas.Add(t);
        //}

        private void nuevaTemperaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTempera tmp = new FormTempera();
            tmp.MdiParent = this;
            tmp.StartPosition = FormStartPosition.CenterParent;
            tmp.Show();
            //if (tmp.DialogResult == System.Windows.Forms.DialogResult.OK)
                this._temperas.Add(tmp.Tempera);
        }
    }
}
