using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void btnExercise1_Click(object sender, EventArgs e)
        {
            var form = new Exercise1Form();
            form.ShowDialog();
        }

        private void btnExercise2_Click(object sender, EventArgs e)
        {
            var form = new Exercise2Form();
            form.ShowDialog();
        }

        private void btnExercise3_Click(object sender, EventArgs e)
        {
            var form = new Exercise3Form();
            form.ShowDialog();
        }

        private void btnExercise4_Click(object sender, EventArgs e)
        {
            var form = new Exercise4Form();
            form.ShowDialog();
        }
    }
}
