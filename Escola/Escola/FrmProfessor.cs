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
    public partial class FrmProfessor : Form
    {
        clsDados.Model.Professor oProf = new clsDados.Model.Professor();
        clsDados.DAL.Professor dalProf = new clsDados.DAL.Professor();
        clsDados.BLL.Professor bllProf = new clsDados.BLL.Professor();

        public FrmProfessor()
        {
            InitializeComponent();
        }

        private void btnSair_ButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmProfessor_Load(object sender, EventArgs e)
        {
            DtgvProfessor1.DataSource = dalProf.Select();
            DtgvProfessor1.Refresh();
            dTCadastro2.Text = DateTime.Now.ToShortDateString();
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtPesquisar.Text != "")
            {
                SqlConnection con = new SqlConnection(clsDados.DAL.Banco.stringDeConexao);
                DataTable consulta = new DataTable();
                string sql = "SELECT * FROM Professor Where Nome like '" + txtPesquisar.Text + "%'";
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                da.Fill(consulta);
                DtgvProfessor1.DataSource = consulta;
            }
        }
        private void selecionarProfessor()
        {
            TxtCodigo1.Text = DtgvProfessor1[0, DtgvProfessor1.CurrentRow.Index].Value.ToString();
            dTCadastro2.Text = DtgvProfessor1[1, DtgvProfessor1.CurrentRow.Index].Value.ToString();
            txtNome1.Text = DtgvProfessor1[2, DtgvProfessor1.CurrentRow.Index].Value.ToString();
            MtxtCpf1.Text = DtgvProfessor1[4, DtgvProfessor1.CurrentRow.Index].Value.ToString();
            MtxtTelefone.Text = DtgvProfessor1[5, DtgvProfessor1.CurrentRow.Index].Value.ToString();

        }
        private void btnExcluir_ButtonClick(object sender, EventArgs e)
        {
            if (TxtCodigo1.Text != "")
            {

                DialogResult result;
                string msg = "Deseja remover o Codigo: " + TxtCodigo1.Text.ToString() + " ?";
                result = MessageBox.Show(msg, "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    clsDados.Model.Professor oProf = new clsDados.Model.Professor();
                    clsDados.DAL.Professor dalProf = new clsDados.DAL.Professor();
                    clsDados.BLL.Professor bllProf = new clsDados.BLL.Professor();
                    oProf.Codigo = int.Parse(TxtCodigo1.Text);
                    bllProf.Delete(oProf);
                    MessageBox.Show(" Foi excluido com sucesso!!");
                    DtgvProfessor1.DataSource = dalProf.Select();
                    DtgvProfessor1.Refresh();

                }
                if (result == DialogResult.No)
                {
                    MessageBox.Show("Operação cancelada!!");
                    DtgvProfessor1.DataSource = dalProf.Select();
                    DtgvProfessor1.Refresh();
                }
            }
            else MessageBox.Show("Codigo Invalido", "Remover", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEditar_ButtonClick(object sender, EventArgs e)
        {
            clsDados.Model.Professor oProf = new clsDados.Model.Professor();
            clsDados.DAL.Professor dalProf = new clsDados.DAL.Professor();
            clsDados.BLL.Professor bllProf = new clsDados.BLL.Professor();

            string n = txtNome1.Text;
            n = n.ToUpper();
            txtNome1.Text = n;


            if (TxtCodigo1.Text != "" && txtNome1.Text != "" && MtxtCpf1.Text != "" && MtxtTelefone.Text != "")
            {
                DialogResult result;
                string msg = "Deseja alterar o Professor: " + txtNome1.Text.ToString() + " ?";
                result = MessageBox.Show(msg, "Alterar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    oProf.Codigo = int.Parse(TxtCodigo1.Text);
                    oProf.Nome = txtNome1.Text;
                    oProf.Cpf = MtxtCpf1.Text;
                    oProf.Telefone = MtxtTelefone.Text;
                    oProf.DataCadastro = dTCadastro2.Value;
                    bllProf.Update(oProf);
                    MessageBox.Show(" Foi alterado com sucesso!!");
                    DtgvProfessor1.DataSource = dalProf.Select();
                    DtgvProfessor1.Refresh();
                }
                if (result == DialogResult.No)
                {
                    MessageBox.Show("Operação cancelada!");
                    DtgvProfessor1.DataSource = dalProf.Select();
                    DtgvProfessor1.Refresh();
                }
            }
            else
            {
                MessageBox.Show("Codigo inválido -\n Atribua valores aos campos!! ", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                label1.Text = "Verifique se o email está no formato Exemplo@Exemplo.com";
            }
        }

        private void btnCadastrar_ButtonClick(object sender, EventArgs e)
        {
            clsDados.Model.Professor oProf = new clsDados.Model.Professor();
            clsDados.DAL.Professor dalProf = new clsDados.DAL.Professor();
            clsDados.BLL.Professor bllProf = new clsDados.BLL.Professor();



            string n = txtNome1.Text;
            n = n.ToUpper();
            txtNome1.Text = n;


            if (TxtCodigo1.Text != "" && txtNome1.Text != "" && MtxtCpf1.Text != "" && MtxtTelefone.Text != "")
            {
                DialogResult result;
                string msg = "Deseja salvar o Aluno: " + txtNome1.Text.ToString() + " ?";
                result = MessageBox.Show(msg, "Salvar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    //                    oAluno.Codigo = int.Parse(TxtCodigo1.Text);
                    oProf.Nome = txtNome1.Text;
                    oProf.Cpf = MtxtCpf1.Text;
                    oProf.Telefone = MtxtTelefone.Text;
                    oProf.DataCadastro = dTCadastro2.Value;
                    bllProf.Insert(oProf);
                    MessageBox.Show(" Foi cadastrado com sucesso!!");
                    DtgvProfessor1.DataSource = dalProf.Select();
                    DtgvProfessor1.Refresh();
                }
                if (result == DialogResult.No)
                {
                    MessageBox.Show("Operação cancelada!");
                    DtgvProfessor1.DataSource = dalProf.Select();
                    DtgvProfessor1.Refresh();
                }
            }
            else
            {
                MessageBox.Show("Codigo inválido -\n Atribua valores aos campos!! ", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    

        private void DtgvProfessor1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selecionarProfessor();
        }

        private void btnLimparr_Click(object sender, EventArgs e)
        {
            txtPesquisar.Text = "";
            DtgvProfessor1.DataSource = dalProf.Select();
            DtgvProfessor1.Refresh();
        }

        private void btnNovo_ButtonClick(object sender, EventArgs e)
        {
            TxtCodigo1.Text = "0";
            txtNome1.Text = "";
            MtxtCpf1.Text = "";
            MtxtTelefone.Text = "";

        }

        private void btnLimpar1_Click(object sender, EventArgs e)
        {
            btnNovo_ButtonClick(sender, e);
        }

        private void FrmProfessor_KeyDown(object sender, KeyEventArgs e)
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
        private void dTCadastro2_ValueChanged(object sender, EventArgs e)
        {
             
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void FrmProfessor_Load_1(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'escolaDataSet.Professor'. Você pode movê-la ou removê-la conforme necessário.
            this.professorTableAdapter.Fill(this.escolaDataSet.Professor);

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }
    }
}
