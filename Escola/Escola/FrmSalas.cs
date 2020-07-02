using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Escola
{
    public partial class FrmSalas : Form
    {
        clsDados.Model.Salas oSa = new clsDados.Model.Salas();
        clsDados.DAL.Salas dalSa = new clsDados.DAL.Salas();
        clsDados.BLL.Salas bllSa = new clsDados.BLL.Salas();
        public FrmSalas()
        {
            InitializeComponent();
        }

        private void btnSair_ButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmSalas_Load(object sender, EventArgs e)
        {
            btnNovo_ButtonClick(sender, e);
            DtgvSalas1.DataSource = dalSa.Select();
            DtgvSalas1.Refresh();

        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtPesquisar.Text != "")
            {
                SqlConnection con = new SqlConnection(clsDados.DAL.Banco.stringDeConexao);
                DataTable consulta = new DataTable();
                string sql = "SELECT * FROM Salas Where Serie like '" + txtPesquisar.Text + "%'";
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                da.Fill(consulta);
                DtgvSalas1.DataSource = consulta;
            }
        }
        private void selecionarSalas()
        {
            TxtCodigo1.Text = DtgvSalas1[0, DtgvSalas1.CurrentRow.Index].Value.ToString();
            txtAluno.Text = DtgvSalas1[1, DtgvSalas1.CurrentRow.Index].Value.ToString();
            cbSerie.Text = DtgvSalas1[2, DtgvSalas1.CurrentRow.Index].Value.ToString();
            cbPeriodo.Text = DtgvSalas1[3, DtgvSalas1.CurrentRow.Index].Value.ToString();
            txtTurma.Text = DtgvSalas1[4, DtgvSalas1.CurrentRow.Index].Value.ToString();

        }
        private void btnExcluir_ButtonClick(object sender, EventArgs e)
        {
            if (TxtCodigo1.Text != "")
            {
                clsDados.Model.Salas oSa = new clsDados.Model.Salas();
                clsDados.DAL.Salas dalSa = new clsDados.DAL.Salas();
                clsDados.BLL.Salas bllSa = new clsDados.BLL.Salas();

                DialogResult result;
                string msg = "Deseja remover o aluno desta sala: " + TxtCodigo1.Text.ToString() + " ?";
                result = MessageBox.Show(msg, "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {

                    oSa.Codigo = int.Parse(TxtCodigo1.Text);
                    bllSa.Delete(oSa);
                    MessageBox.Show(" Foi excluido com sucesso!!");
                    DtgvSalas1.DataSource = dalSa.Select();
                    DtgvSalas1.Refresh();

                }
                if (result == DialogResult.No)
                {
                    MessageBox.Show("Operação cancelada!!");
                    DtgvSalas1.DataSource = dalSa.Select();
                    DtgvSalas1.Refresh();
                }
            }
            else MessageBox.Show("Codigo Invalido", "Remover", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEditar_ButtonClick(object sender, EventArgs e)
        {
            clsDados.Model.Salas oSa = new clsDados.Model.Salas();
            clsDados.DAL.Salas dalSa = new clsDados.DAL.Salas();
            clsDados.BLL.Salas bllSa = new clsDados.BLL.Salas();

            string n = txtAluno.Text;
            n = n.ToUpper();
            txtAluno.Text = n;


            if (TxtCodigo1.Text != "" && txtAluno.Text != "" && cbSerie.Text != "" && cbPeriodo.Text != "" && txtTurma.Text != "")
            {
                DialogResult result;
                string msg = "Deseja alterar o Aluno: " + txtAluno.Text.ToString() + " ?";
                result = MessageBox.Show(msg, "Alterar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    oSa.Codigo = int.Parse(TxtCodigo1.Text);
                    oSa.Aluno = txtAluno.Text;
                    oSa.Serie = cbSerie.Text;
                    oSa.Periodo = cbPeriodo.Text;
                    oSa.Turma = txtTurma.Text;
                    bllSa.Update(oSa);
                    MessageBox.Show(" Foi alterado com sucesso!!");
                    DtgvSalas1.DataSource = dalSa.Select();
                    DtgvSalas1.Refresh();
                }
                if (result == DialogResult.No)
                {
                    MessageBox.Show("Operação cancelada!");
                    DtgvSalas1.DataSource = dalSa.Select();
                    DtgvSalas1.Refresh();
                }
            }
            else
            {
                MessageBox.Show("Codigo inválido -\n Atribua valores aos campos!! ", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCadastrar_ButtonClick(object sender, EventArgs e)
        {
            clsDados.Model.Salas oSa = new clsDados.Model.Salas();
            clsDados.DAL.Salas dalSa = new clsDados.DAL.Salas();
            clsDados.BLL.Salas bllSa = new clsDados.BLL.Salas();

            string n = txtAluno.Text;
            n = n.ToUpper();
            txtAluno.Text = n;

            if (TxtCodigo1.Text != "" && txtAluno.Text != "" && cbSerie.Text != "" && cbPeriodo.Text != "" && txtTurma.Text != "")
            {
                DialogResult result;
                string msg = "Deseja salvar o Aluno: " + txtAluno.Text.ToString() + " ?";
                result = MessageBox.Show(msg, "Salvar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {

                    //oSa.Codigo = int.Parse(TxtCodigo1.Text);
                    oSa.Aluno = txtAluno.Text;
                    oSa.Serie = cbSerie.Text;
                    oSa.Periodo = cbPeriodo.Text;
                    oSa.Turma = txtTurma.Text;
                    bllSa.Insert(oSa);
                    MessageBox.Show(" Foi cadastrado com sucesso!!");
                    DtgvSalas1.DataSource = dalSa.Select();
                    DtgvSalas1.Refresh();
                }
                if (result == DialogResult.No)
                {
                    MessageBox.Show("Operação cancelada!");
                    DtgvSalas1.DataSource = dalSa.Select();
                    DtgvSalas1.Refresh();
                }
            }
            else
            {
                MessageBox.Show("Codigo inválido -\n Atribua valores aos campos!! ", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbSerie_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbSerie.Text = cbSerie.SelectedValue.ToString();
        }

        private void cbPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbPeriodo.Text = cbPeriodo.SelectedItem.ToString();
        }

        private void btnNovo_ButtonClick(object sender, EventArgs e)
        {
            TxtCodigo1.Text = "0";
            txtAluno.Text = "";
            cbSerie.Text = "Seleciona uma serie";
            cbPeriodo.Text = "Selecione um periodo";
            txtTurma.Text = "";

        }

        private void DtgvSalas1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selecionarSalas();
        }

        private void cbSerie_DropDown(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(clsDados.DAL.Banco.stringDeConexao);
            DataTable Serie = new DataTable();
            string sql = "select Descricao from Serie ";
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(Serie);
            cbSerie.DataSource = Serie;
            cbSerie.DisplayMember = "Descricao";
            cbSerie.DisplayMember = "Descricao";
            con.Close();
        }

        private void btbPesquisar1_Click(object sender, EventArgs e)
        {
            FrmAluno frm = new FrmAluno();
            frm.ShowDialog();

            txtAluno.Text = frm.txtNome1.Text;
        }

        private void cbQtde_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cbQtde.Text = cbQtde.SelectedText;
        }

        private void cbLA_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cbLA.Text = cbLA.SelectedText;
        }

        private void btnLimparr_Click(object sender, EventArgs e)
        {
            DtgvSalas1.DataSource = dalSa.Select();
            DtgvSalas1.Refresh();
            txtPesquisar.Text = "";
        }

        private void FrmSalas_KeyDown(object sender, KeyEventArgs e)
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

        private void btnLimpar1_Click(object sender, EventArgs e)
        {
            btnNovo_ButtonClick(sender, e);
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

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtTurma_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtAluno_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TxtCodigo1_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
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

        private void FrmSalas_Load_1(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'escolaDataSet.Salas'. Você pode movê-la ou removê-la conforme necessário.
            this.salasTableAdapter.Fill(this.escolaDataSet.Salas);

        }

        private void DtgvSalas1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
