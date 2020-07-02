using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escola
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void alunoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmAluno frm = new FrmAluno();
            frm.ShowDialog();
        }

        private void professorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmProfessor frm = new FrmProfessor();
            frm.ShowDialog();
        }

        private void materiaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmPMateria frm = new FrmPMateria();
            frm.ShowDialog();
        }

        private void notasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmNota frm = new FrmNota();
            frm.ShowDialog();
        }

        private void salaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSalas frm = new FrmSalas();
            frm.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToLongDateString();
            toolStripStatusLabel3.Text = DateTime.Now.ToLongTimeString();
        }

        private void professorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void materiaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void notasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FrmMenu_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    alunoToolStripMenuItem1_Click(sender, e);
                    break;
                case Keys.F2:
                    salaToolStripMenuItem_Click(sender, e);
                    break;
                case Keys.F3:
                    materiaToolStripMenuItem1_Click(sender, e);
                    break;
                case Keys.F4:
                    notasToolStripMenuItem1_Click(sender, e);
                    break;
                case Keys.F5:
                    professorToolStripMenuItem1_Click(sender, e);
                    break;               
               case Keys.F16:
                    sairToolStripMenuItem_Click(sender, e);
                    break;
            }
        }
   

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void relatoioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastroToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
