using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Escola
{
    public partial class FrmPMateria : Form
    {
        clsDados.Model.Materia oMa = new clsDados.Model.Materia();
        clsDados.DAL.Materia dalMateria = new clsDados.DAL.Materia();
        clsDados.BLL.Materia bllMateria = new clsDados.BLL.Materia();

        public FrmPMateria()
        {
            InitializeComponent();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_ButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
        private void selecionarMateria()
        {
            TxtCodigo1.Text = DtgvMateria1[0, DtgvMateria1.CurrentRow.Index].Value.ToString();
            txtDesc1.Text = DtgvMateria1[1, DtgvMateria1.CurrentRow.Index].Value.ToString();
            cbProf.Text = DtgvMateria1[2, DtgvMateria1.CurrentRow.Index].Value.ToString();
        }
        private void btnExcluir_ButtonClick(object sender, EventArgs e)
        {
            if (TxtCodigo1.Text != "")
            {
                clsDados.Model.Materia oMa = new clsDados.Model.Materia();
                clsDados.DAL.Materia dalMateria = new clsDados.DAL.Materia();
                clsDados.BLL.Materia bllMateria = new clsDados.BLL.Materia();
                DialogResult result;
                string msg = "Deseja remover o Codigo: " + TxtCodigo1.Text.ToString() + " ?";
                result = MessageBox.Show(msg, "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    oMa.Codigo = int.Parse(TxtCodigo1.Text);
                    bllMateria.Delete(oMa);
                    MessageBox.Show(" Foi excluido com sucesso!!");
                    DtgvMateria1.DataSource = dalMateria.Select();
                    DtgvMateria1.Refresh();

                }
                if (result == DialogResult.No)
                {
                    MessageBox.Show("Operação cancelada!!");
                    DtgvMateria1.DataSource = dalMateria.Select();
                    DtgvMateria1.Refresh();
                }
            }
            else MessageBox.Show("Codigo Invalido", "Remover", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEditar_ButtonClick(object sender, EventArgs e)
        {
            clsDados.Model.Materia oMa = new clsDados.Model.Materia();
            clsDados.DAL.Materia dalMateria = new clsDados.DAL.Materia();
            clsDados.BLL.Materia bllMateria = new clsDados.BLL.Materia();

            string n = txtDesc1.Text;
            n = n.ToUpper();
            txtDesc1.Text = n;


            if (TxtCodigo1.Text != "" && txtDesc1.Text != "" && cbProf.Text != "")
            {
                DialogResult result;
                string msg = "Deseja alterar o Aluno: " + txtDesc1.Text.ToString() + " ?";
                result = MessageBox.Show(msg, "Alterar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    oMa.Codigo = int.Parse(TxtCodigo1.Text);
                    oMa.Disciplina = txtDesc1.Text;
                    oMa.Professor = cbProf.Text;
                    bllMateria.Update(oMa);
                    MessageBox.Show(" Foi alterado com sucesso!!");
                    DtgvMateria1.DataSource = dalMateria.Select();
                    DtgvMateria1.Refresh();
                }
                if (result == DialogResult.No)
                {
                    MessageBox.Show("Operação cancelada!");
                    DtgvMateria1.DataSource = dalMateria.Select();
                    DtgvMateria1.Refresh();
                }
            }
            else
            {
                MessageBox.Show("Codigo inválido -\n Atribua valores aos campos!! ", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCadastrar_ButtonClick(object sender, EventArgs e)
        {
            clsDados.Model.Materia oMa = new clsDados.Model.Materia();
            clsDados.DAL.Materia dalMateria = new clsDados.DAL.Materia();
            clsDados.BLL.Materia bllMateria = new clsDados.BLL.Materia();

            string n = txtDesc1.Text;
            n = n.ToUpper();
            txtDesc1.Text = n;

            if (TxtCodigo1.Text != "" && txtDesc1.Text != "" && cbProf.Text != "")
            {
                DialogResult result;
                string msg = "Deseja salvar o Aluno: " + txtDesc1.Text.ToString() + " ?";
                result = MessageBox.Show(msg, "Salvar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    //                    oAluno.Codigo = int.Parse(TxtCodigo1.Text);
                    oMa.Disciplina = txtDesc1.Text;
                    oMa.Professor = cbProf.Text;
                    bllMateria.Insert(oMa);
                    MessageBox.Show(" Foi cadastrado com sucesso!!");
                    DtgvMateria1.DataSource = dalMateria.Select();
                    DtgvMateria1.Refresh();
                }
                if (result == DialogResult.No)
                {
                    MessageBox.Show("Operação cancelada!");
                    DtgvMateria1.DataSource = dalMateria.Select();
                    DtgvMateria1.Refresh();
                }
            }
            else
            {
                MessageBox.Show("Codigo inválido -\n Atribua valores aos campos!! ", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNovo_ButtonClick(object sender, EventArgs e)
        {
            TxtCodigo1.Text = "0";
            txtDesc1.Text = "";
            cbProf.Text = "Escolha o professor";
        }

        private void FrmMateria_Load(object sender, EventArgs e)
        {
            btnNovo_ButtonClick(sender, e);
            DtgvMateria1.DataSource = dalMateria.Select();
            DtgvMateria1.Refresh();
        }

        private void cbProf_DropDown(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(clsDados.DAL.Banco.stringDeConexao);
            DataTable Serie = new DataTable();
            string sql = "select Nome from Professor ";
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(Serie);
            cbProf.DataSource = Serie;
            cbProf.DisplayMember = "Nome";
            cbProf.DisplayMember = "Nome";
            con.Close();
        }

        private void cbProf_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbProf.Text = cbProf.SelectedValue.ToString();
        }

        private void DtgvMateria1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selecionarMateria();
        }

        private void btnLimparr_Click(object sender, EventArgs e)
        {
            DtgvMateria1.DataSource = dalMateria.Select();
            DtgvMateria1.Refresh();
            txtPesquisar.Text = "";
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtPesquisar.Text != "")
            {
                SqlConnection con = new SqlConnection(clsDados.DAL.Banco.stringDeConexao);
                DataTable consulta = new DataTable();
                string sql = "SELECT * FROM Materia Where Disciplina like '" + txtPesquisar.Text + "%'";
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                da.Fill(consulta);
                DtgvMateria1.DataSource = consulta;
            }
        }

        private void btnLimpar1_Click(object sender, EventArgs e)
        {
            btnNovo_ButtonClick(sender, e);
        }

        private void FrmMateria_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    btnNovo_ButtonClick(sender, e);
                    break;
                case Keys.F2:
                    btnCadastrar_ButtonClick(sender, e);
                    break;
                case Keys.F3:
                    btnEditar_ButtonClick(sender, e);
                    break;
                case Keys.Delete:
                    btnExcluir_ButtonClick(sender, e);
                    break;
                case Keys.F4:
                    btnSair_ButtonClick(sender, e);
                    break;
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void TxtCodigo1_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void txtDesc1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
