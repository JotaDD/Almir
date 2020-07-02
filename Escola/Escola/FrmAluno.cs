using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Escola
{
    public partial class FrmAluno : Form
    {
        clsDados.Model.Aluno oAluno = new clsDados.Model.Aluno();
        clsDados.DAL.Aluno dalAluno = new clsDados.DAL.Aluno();
        clsDados.BLL.Aluno bllAluno = new clsDados.BLL.Aluno();
        public FrmAluno()
        {
            InitializeComponent();
        }

        private void FrmAluno_Load(object sender, EventArgs e)
        {
            DtgvAluno1.DataSource = dalAluno.Select();
            DtgvAluno1.Refresh();
            dTCadastro2.Text = DateTime.Now.ToShortDateString();
        }
        private void selecionarAluno()
        {
            TxtCodigo1.Text = DtgvAluno1[0, DtgvAluno1.CurrentRow.Index].Value.ToString();
            dTCadastro2.Text = DtgvAluno1[1, DtgvAluno1.CurrentRow.Index].Value.ToString();
            txtNome1.Text = DtgvAluno1[2, DtgvAluno1.CurrentRow.Index].Value.ToString();
            MtxtRg1.Text = DtgvAluno1[3, DtgvAluno1.CurrentRow.Index].Value.ToString();
            MtxtCpf1.Text = DtgvAluno1[4, DtgvAluno1.CurrentRow.Index].Value.ToString();
            txtResponsavel1.Text = DtgvAluno1[6, DtgvAluno1.CurrentRow.Index].Value.ToString();
            MtxtTelefone.Text = DtgvAluno1[7, DtgvAluno1.CurrentRow.Index].Value.ToString();
       

        }
        private void btnExcluir_ButtonClick(object sender, EventArgs e)
        {
            if (TxtCodigo1.Text != "")
            {
                clsDados.Model.Aluno oAluno = new clsDados.Model.Aluno();
                oAluno.Codigo = int.Parse(TxtCodigo1.Text);
                clsDados.DAL.Aluno dalAluno = new clsDados.DAL.Aluno();
                clsDados.BLL.Aluno bllAluno = new clsDados.BLL.Aluno();
                DialogResult result;
                string msg = "Deseja remover o Codigo: " + TxtCodigo1.Text.ToString() + " ?";
                result = MessageBox.Show(msg, "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    bllAluno.Delete(oAluno);
                    MessageBox.Show(" Foi excluido com sucesso!!");
                    DtgvAluno1.DataSource = dalAluno.Select();
                    DtgvAluno1.Refresh();

                }
                if (result == DialogResult.No)
                {
                    MessageBox.Show("Operação cancelada!!");
                    DtgvAluno1.DataSource = dalAluno.Select();
                    DtgvAluno1.Refresh();
                }
            }
            else MessageBox.Show("Codigo Invalido", "Remover", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEditar_ButtonClick(object sender, EventArgs e)
        {
            clsDados.Model.Aluno oAluno = new clsDados.Model.Aluno();
            clsDados.DAL.Aluno dalAluno = new clsDados.DAL.Aluno();
            clsDados.BLL.Aluno bllAluno = new clsDados.BLL.Aluno();

            string n = txtNome1.Text;
            n = n.ToUpper();
            txtNome1.Text = n;


            if (TxtCodigo1.Text != "" && txtNome1.Text != "" && MtxtRg1.Text != "" && MtxtCpf1.Text != "" && MtxtTelefone.Text != "" )
            {
                DialogResult result;
                string msg = "Deseja alterar o Aluno: " + txtNome1.Text.ToString() + " ?";
                result = MessageBox.Show(msg, "Alterar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    oAluno.Codigo = int.Parse(TxtCodigo1.Text);
                    oAluno.Nome = txtNome1.Text;
                    oAluno.Rg = MtxtRg1.Text;
                    oAluno.Cpf = MtxtCpf1.Text;
                    oAluno.Telefone = MtxtTelefone.Text;
                    oAluno.Responsavel = txtResponsavel1.Text;
                    oAluno.DataCadastro = dTCadastro2.Value;
                    bllAluno.Update(oAluno);
                    MessageBox.Show(" Foi alterado com sucesso!!");
                    DtgvAluno1.DataSource = dalAluno.Select();
                    DtgvAluno1.Refresh();
                }
                if (result == DialogResult.No)
                {
                    MessageBox.Show("Operação cancelada!");
                    DtgvAluno1.DataSource = dalAluno.Select();
                    DtgvAluno1.Refresh();
                }
            }
            else
            {
                MessageBox.Show("Codigo inválido -\n Atribua valores aos campos!! ", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);          
            }
        }

        private void btnCadastrar_ButtonClick(object sender, EventArgs e)
        {
            clsDados.Model.Aluno oAluno = new clsDados.Model.Aluno();
            clsDados.DAL.Aluno dalAluno = new clsDados.DAL.Aluno();
            clsDados.BLL.Aluno bllAluno = new clsDados.BLL.Aluno();

            dTCadastro2.Text = DateTime.Now.ToShortDateString();

            string n = txtNome1.Text;
            n = n.ToUpper();
            txtNome1.Text = n;

            if (TxtCodigo1.Text != "" && txtNome1.Text != "" && MtxtRg1.Text != "" && MtxtCpf1.Text != "" && MtxtTelefone.Text != "")
            {
                DialogResult result;
                string msg = "Deseja salvar o Aluno: " + txtNome1.Text.ToString() + " ?";
                result = MessageBox.Show(msg, "Salvar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    //                    oAluno.Codigo = int.Parse(TxtCodigo1.Text);
                    oAluno.Nome = txtNome1.Text;
                    oAluno.Rg = MtxtRg1.Text;
                    oAluno.Cpf = MtxtCpf1.Text;
                    oAluno.Telefone = MtxtTelefone.Text;
                    oAluno.Responsavel = txtResponsavel1.Text;
                    oAluno.DataCadastro = dTCadastro2.Value;
                    bllAluno.Insert(oAluno);
                    MessageBox.Show(" Foi cadastrado com sucesso!!");
                    DtgvAluno1.DataSource = dalAluno.Select();
                    DtgvAluno1.Refresh();
                }
                if (result == DialogResult.No)
                {
                    MessageBox.Show("Operação cancelada!");
                    DtgvAluno1.DataSource = dalAluno.Select();
                    DtgvAluno1.Refresh();
                }
            }
            else
            {
                MessageBox.Show("Codigo inválido -\n Atribua valores aos campos!! ", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

 


        private void btnSair_ButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DtgvAluno1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selecionarAluno();
        }

        private void btnNovo_ButtonClick(object sender, EventArgs e)
        {
            TxtCodigo1.Text = "0";
            txtNome1.Text = "";
            MtxtRg1.Text = "";
            MtxtCpf1.Text = "";
            MtxtTelefone.Text = "";
            txtResponsavel1.Text = "";
            txtNome1.Focus();
        }

        private void btnLimpar1_Click(object sender, EventArgs e)
        {
            btnNovo_ButtonClick(sender, e);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtPesquisar.Text != "")
            {
                SqlConnection con = new SqlConnection(clsDados.DAL.Banco.stringDeConexao);
                DataTable consulta = new DataTable();
                string sql = "SELECT * FROM Aluno Where Nome like '" + txtPesquisar.Text + "%'";
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                da.Fill(consulta);
                DtgvAluno1.DataSource = consulta;
            }
        }

        private void btnLimparr_Click(object sender, EventArgs e)
        {
            DtgvAluno1.DataSource = dalAluno.Select();
            DtgvAluno1.Refresh();
            txtPesquisar.Text = "";
        }

        private void FrmAluno_KeyDown(object sender, KeyEventArgs e)
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



        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void alunoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
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

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dTCadastro2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void TxtCodigo1_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail1_TextChanged(object sender, EventArgs e)
        {

        }

        private void MtxtCpf1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void MtxtRg1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtNome1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtRua1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail2_TextChanged(object sender, EventArgs e)
        {

        }

        private void MtxtTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtResponsavel1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter_1(object sender, EventArgs e)
        {

        }

        private void FrmAluno_Load_1(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'escolaDataSet.Aluno'. Você pode movê-la ou removê-la conforme necessário.
            this.alunoTableAdapter.Fill(this.escolaDataSet.Aluno);

        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }
    }
}

