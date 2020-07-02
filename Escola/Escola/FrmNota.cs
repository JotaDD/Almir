using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Escola
{
    public partial class FrmNota : Form
    {
        public FrmNota()
        {
            InitializeComponent();
        }

        private void btnPesqAluno_Click(object sender, EventArgs e)
        {
            FrmAluno frm = new FrmAluno();
            frm.ShowDialog();
            txtAluno.Text = frm.txtNome1.Text;
            Pesquisar(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float n1 = float.Parse(txtN1.Text);
            float n2 = float.Parse(txtN2.Text);

            float s = (n1 + n2) / 2;
            //string compara= "7,00";            
            string soma = s.ToString();
            //bool resultado;
            //bool resultado1;
            if (s > 7.00 || s == 7.00 || s == 6.75)
            {
                txtSituacao.Text = "Aprovado";
            }
            else { txtSituacao.Text = "Reprovado"; }
        }

        private void btnSair_ButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void cbDisciplina_DropDown(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(clsDados.DAL.Banco.stringDeConexao);
            DataTable Serie = new DataTable();
            string sql = "select Disciplina from Materia_Aluno Where Aluno like '" + txtAluno.Text + "%'";
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(Serie);
            cbDisciplina.DataSource = Serie;
            cbDisciplina.DisplayMember = "Disciplina";
            cbDisciplina.ValueMember = "Disciplina";
            con.Close();
        }

        private void Pesquisar(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(clsDados.DAL.Banco.stringDeConexao);
            DataTable Serie = new DataTable();
            string sql = "select * from Nota Where Aluno like '" + txtAluno.Text + "%'";
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(Serie);
            DtgvNota1.DataSource = Serie;
            DtgvNota1.Refresh();
            con.Close();
        }

        private void btnCadastrar_ButtonClick(object sender, EventArgs e)
        {
            clsDados.Model.Nota oNo = new clsDados.Model.Nota();
            clsDados.DAL.Nota dalNota = new clsDados.DAL.Nota();
            clsDados.BLL.Nota bllNota = new clsDados.BLL.Nota();


            if (TxtCodigo1.Text != "" && txtAluno.Text != "" && cbDisciplina.Text != "")
            {
                DialogResult result;
                string msg = "Deseja salvar Nota: " + txtAluno.Text.ToString() + " ?";
                result = MessageBox.Show(msg, "Salvar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    //                    oAluno.Codigo = int.Parse(TxtCodigo1.Text);
                    oNo.Disciplina = cbDisciplina.Text;
                    oNo.Aluno = txtAluno.Text;
                    oNo.Nota1 = float.Parse(txtN1.Text);
                    oNo.Total1 = int.Parse(txtF1.Text);
                    oNo.Nota2 = float.Parse(txtN2.Text);
                    oNo.Total2 = int.Parse(txtF2.Text);
                    oNo.Situacao = txtSituacao.Text;
                    bllNota.Insert(oNo);
                    MessageBox.Show(" Foi cadastrado com sucesso!!");
                    Pesquisar(sender, e);
                }
                if (result == DialogResult.No)
                {
                    MessageBox.Show("Operação cancelada!");
                    Pesquisar(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Codigo inválido -\n Atribua valores aos campos!! ", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_ButtonClick(object sender, EventArgs e)
        {
            clsDados.Model.Nota oNo = new clsDados.Model.Nota();
            clsDados.DAL.Nota dalNota = new clsDados.DAL.Nota();
            clsDados.BLL.Nota bllNota = new clsDados.BLL.Nota();


            if (TxtCodigo1.Text != "" && txtAluno.Text != "" && cbDisciplina.Text != "")
            {
                DialogResult result;
                string msg = "Deseja Alterar Nota: " + txtAluno.Text.ToString() + " ?";
                result = MessageBox.Show(msg, "Alterar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    oNo.Codigo = int.Parse(TxtCodigo1.Text);
                    oNo.Disciplina = cbDisciplina.Text;
                    oNo.Aluno = txtAluno.Text;
                    oNo.Nota1 = float.Parse(txtN1.Text);
                    oNo.Total1 = int.Parse(txtF1.Text);
                    oNo.Nota2 = float.Parse(txtN2.Text);
                    oNo.Total2 = int.Parse(txtF2.Text);
                    oNo.Situacao = txtSituacao.Text;
                    bllNota.Update(oNo);
                    MessageBox.Show(" Foi alterado com sucesso!!");
                    Pesquisar(sender, e);
                }
                if (result == DialogResult.No)
                {
                    MessageBox.Show("Operação cancelada!");
                    Pesquisar(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Codigo inválido -\n Atribua valores aos campos!! ", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_ButtonClick(object sender, EventArgs e)
        {
            clsDados.Model.Nota oNo = new clsDados.Model.Nota();
            clsDados.DAL.Nota dalNota = new clsDados.DAL.Nota();
            clsDados.BLL.Nota bllNota = new clsDados.BLL.Nota();


            if (TxtCodigo1.Text != "")
            {
                DialogResult result;
                string msg = "Deseja Excluir Nota: " + txtAluno.Text.ToString() + " ?";
                result = MessageBox.Show(msg, "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    oNo.Codigo = int.Parse(TxtCodigo1.Text);
                    bllNota.Delete(oNo);
                    MessageBox.Show(" Foi excluido com sucesso!!");
                    Pesquisar(sender, e);
                }
                if (result == DialogResult.No)
                {
                    MessageBox.Show("Operação cancelada!");
                    Pesquisar(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Codigo inválido -\n Atribua valores aos campos!! ", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmNota_KeyDown(object sender, KeyEventArgs e)
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

        private void btnNovo_ButtonClick(object sender, EventArgs e)
        {
            TxtCodigo1.Text = "0";
            txtAluno.Text = "";
            cbDisciplina.Text = "";
            txtN1.Text = "";
            txtF1.Text = "";
            txtN2.Text = "";
            txtF2.Text = "";
            txtSituacao.Text = "";
        }

        private void selecionarNota()
        {
            TxtCodigo1.Text = DtgvNota1[0, DtgvNota1.CurrentRow.Index].Value.ToString();
            cbDisciplina.Text = DtgvNota1[1, DtgvNota1.CurrentRow.Index].Value.ToString();
            txtAluno.Text = DtgvNota1[2, DtgvNota1.CurrentRow.Index].Value.ToString();
            txtN1.Text = DtgvNota1[3, DtgvNota1.CurrentRow.Index].Value.ToString();
            txtF1.Text = DtgvNota1[4, DtgvNota1.CurrentRow.Index].Value.ToString();
            txtN2.Text = DtgvNota1[5, DtgvNota1.CurrentRow.Index].Value.ToString();
            txtF2.Text = DtgvNota1[6, DtgvNota1.CurrentRow.Index].Value.ToString();
            txtSituacao.Text = DtgvNota1[7, DtgvNota1.CurrentRow.Index].Value.ToString();
        }
        private void FrmNota_Load(object sender, EventArgs e)
        {
            btnNovo_ButtonClick(sender, e);
        }

        private void DtgvNota1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selecionarNota();
        }

        private void btnLimpar1_Click(object sender, EventArgs e)
        {
            TxtCodigo1.Text = "0";
            cbDisciplina.Text = "";
            txtAluno.Text = "";
            txtN1.Text = "";
            txtF1.Text = "";
            txtN2.Text = "";
            txtF2.Text = "";
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

        private void cbDisciplina_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSituacao_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtF2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtN2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtF1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtN1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
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

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }
    }
}