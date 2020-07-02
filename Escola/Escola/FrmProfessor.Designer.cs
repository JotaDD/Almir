namespace Escola
{
    partial class FrmProfessor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProfessor));
            this.DtgvProfessor1 = new System.Windows.Forms.DataGridView();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCadastroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.professorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.escolaDataSet = new Escola.EscolaDataSet();
            this.label23 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MtxtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLimpar1 = new System.Windows.Forms.Button();
            this.TxtCodigo1 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.MtxtCpf1 = new System.Windows.Forms.MaskedTextBox();
            this.txtNome1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.btnNovo = new System.Windows.Forms.ToolStripSplitButton();
            this.btnCadastrar = new System.Windows.Forms.ToolStripSplitButton();
            this.btnEditar = new System.Windows.Forms.ToolStripSplitButton();
            this.btnExcluir = new System.Windows.Forms.ToolStripSplitButton();
            this.btnSair = new System.Windows.Forms.ToolStripSplitButton();
            this.btnLimparr = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dTCadastro2 = new System.Windows.Forms.DateTimePicker();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.professorTableAdapter = new Escola.EscolaDataSetTableAdapters.ProfessorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DtgvProfessor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.professorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.escolaDataSet)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DtgvProfessor1
            // 
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.DtgvProfessor1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DtgvProfessor1.AutoGenerateColumns = false;
            this.DtgvProfessor1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.DtgvProfessor1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgvProfessor1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.dataCadastroDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.cpfDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn});
            this.DtgvProfessor1.DataSource = this.professorBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DtgvProfessor1.DefaultCellStyle = dataGridViewCellStyle2;
            this.DtgvProfessor1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.DtgvProfessor1.Location = new System.Drawing.Point(10, 72);
            this.DtgvProfessor1.Name = "DtgvProfessor1";
            this.DtgvProfessor1.Size = new System.Drawing.Size(583, 185);
            this.DtgvProfessor1.TabIndex = 7;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataCadastroDataGridViewTextBoxColumn
            // 
            this.dataCadastroDataGridViewTextBoxColumn.DataPropertyName = "DataCadastro";
            this.dataCadastroDataGridViewTextBoxColumn.HeaderText = "DataCadastro";
            this.dataCadastroDataGridViewTextBoxColumn.Name = "dataCadastroDataGridViewTextBoxColumn";
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // cpfDataGridViewTextBoxColumn
            // 
            this.cpfDataGridViewTextBoxColumn.DataPropertyName = "Cpf";
            this.cpfDataGridViewTextBoxColumn.HeaderText = "Cpf";
            this.cpfDataGridViewTextBoxColumn.Name = "cpfDataGridViewTextBoxColumn";
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            // 
            // professorBindingSource
            // 
            this.professorBindingSource.DataMember = "Professor";
            this.professorBindingSource.DataSource = this.escolaDataSet;
            // 
            // escolaDataSet
            // 
            this.escolaDataSet.DataSetName = "EscolaDataSet";
            this.escolaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.White;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.Location = new System.Drawing.Point(255, 21);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(43, 13);
            this.label23.TabIndex = 58;
            this.label23.Text = "Sair(F4)";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.White;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(184, 21);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(63, 13);
            this.label21.TabIndex = 56;
            this.label21.Text = "Apagar(Del)";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(119, 21);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(55, 13);
            this.label20.TabIndex = 55;
            this.label20.Text = "Alterar(F3)";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(58, 21);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(55, 13);
            this.label18.TabIndex = 54;
            this.label18.Text = "Salvar(F2)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "...";
            // 
            // MtxtTelefone
            // 
            this.MtxtTelefone.ForeColor = System.Drawing.Color.Purple;
            this.MtxtTelefone.Location = new System.Drawing.Point(79, 106);
            this.MtxtTelefone.Mask = "(00)0000-0000";
            this.MtxtTelefone.Name = "MtxtTelefone";
            this.MtxtTelefone.Size = new System.Drawing.Size(100, 20);
            this.MtxtTelefone.TabIndex = 60;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(12, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 59;
            this.label5.Text = "Telefone:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(117, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "Data de Cadastro:";
            // 
            // btnLimpar1
            // 
            this.btnLimpar1.AutoSize = true;
            this.btnLimpar1.BackColor = System.Drawing.Color.White;
            this.btnLimpar1.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar1.Image")));
            this.btnLimpar1.Location = new System.Drawing.Point(79, 159);
            this.btnLimpar1.Name = "btnLimpar1";
            this.btnLimpar1.Size = new System.Drawing.Size(65, 51);
            this.btnLimpar1.TabIndex = 46;
            this.btnLimpar1.Text = "Limpar";
            this.btnLimpar1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpar1.UseVisualStyleBackColor = false;
            // 
            // TxtCodigo1
            // 
            this.TxtCodigo1.AutoSize = true;
            this.TxtCodigo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigo1.ForeColor = System.Drawing.Color.Black;
            this.TxtCodigo1.Location = new System.Drawing.Point(76, 19);
            this.TxtCodigo1.Name = "TxtCodigo1";
            this.TxtCodigo1.Size = new System.Drawing.Size(16, 15);
            this.TxtCodigo1.TabIndex = 45;
            this.TxtCodigo1.Text = "...";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(5, 20);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(51, 13);
            this.label17.TabIndex = 53;
            this.label17.Text = "Novo(F1)";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(13, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 15);
            this.label12.TabIndex = 44;
            this.label12.Text = "Codigo:";
            // 
            // MtxtCpf1
            // 
            this.MtxtCpf1.ForeColor = System.Drawing.Color.Purple;
            this.MtxtCpf1.Location = new System.Drawing.Point(79, 80);
            this.MtxtCpf1.Mask = "000.000.000-00";
            this.MtxtCpf1.Name = "MtxtCpf1";
            this.MtxtCpf1.Size = new System.Drawing.Size(100, 20);
            this.MtxtCpf1.TabIndex = 40;
            // 
            // txtNome1
            // 
            this.txtNome1.ForeColor = System.Drawing.Color.Purple;
            this.txtNome1.Location = new System.Drawing.Point(79, 46);
            this.txtNome1.Name = "txtNome1";
            this.txtNome1.Size = new System.Drawing.Size(346, 20);
            this.txtNome1.TabIndex = 38;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(37, 85);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 15);
            this.label14.TabIndex = 5;
            this.label14.Text = "CPF:";
            // 
            // groupBox8
            // 
            this.groupBox8.AutoSize = true;
            this.groupBox8.BackColor = System.Drawing.Color.White;
            this.groupBox8.Controls.Add(this.label23);
            this.groupBox8.Controls.Add(this.label21);
            this.groupBox8.Controls.Add(this.label20);
            this.groupBox8.Controls.Add(this.label18);
            this.groupBox8.Controls.Add(this.label17);
            this.groupBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.ForeColor = System.Drawing.Color.Black;
            this.groupBox8.Location = new System.Drawing.Point(5, 543);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(304, 50);
            this.groupBox8.TabIndex = 66;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Teclas de Atalho";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 12.75F);
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNovo,
            this.btnCadastrar,
            this.btnEditar,
            this.btnExcluir,
            this.btnSair});
            this.statusStrip1.Location = new System.Drawing.Point(0, 605);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(623, 46);
            this.statusStrip1.TabIndex = 65;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // btnNovo
            // 
            this.btnNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(56, 44);
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(56, 44);
            this.btnCadastrar.Text = "F1";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnEditar
            // 
            this.btnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(56, 44);
            this.btnEditar.Text = "toolStripSplitButton2";
            // 
            // btnExcluir
            // 
            this.btnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(56, 44);
            this.btnExcluir.Text = "toolStripSplitButton3";
            // 
            // btnSair
            // 
            this.btnSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(48, 44);
            this.btnSair.Text = "toolStripSplitButton5";
            // 
            // btnLimparr
            // 
            this.btnLimparr.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLimparr.Image = ((System.Drawing.Image)(resources.GetObject("btnLimparr.Image")));
            this.btnLimparr.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLimparr.Location = new System.Drawing.Point(489, 17);
            this.btnLimparr.Name = "btnLimparr";
            this.btnLimparr.Size = new System.Drawing.Size(75, 49);
            this.btnLimparr.TabIndex = 51;
            this.btnLimparr.Text = "\r\n&Limpar";
            this.btnLimparr.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimparr.UseVisualStyleBackColor = false;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.White;
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(408, 17);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 49);
            this.btnPesquisar.TabIndex = 50;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtPesquisar.Location = new System.Drawing.Point(190, 32);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(200, 21);
            this.txtPesquisar.TabIndex = 49;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Transparent;
            this.groupBox6.Controls.Add(this.btnLimparr);
            this.groupBox6.Controls.Add(this.btnPesquisar);
            this.groupBox6.Controls.Add(this.txtPesquisar);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.DtgvProfessor1);
            this.groupBox6.Location = new System.Drawing.Point(7, 257);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(599, 263);
            this.groupBox6.TabIndex = 28;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Cliente(s) Cadastrados no sistema";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label8.Location = new System.Drawing.Point(15, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Informe o Nome do Professor:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(22, 51);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 15);
            this.label16.TabIndex = 1;
            this.label16.Text = "Nome:";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(590, 225);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro do Professor";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.MtxtTelefone);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.dTCadastro2);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.btnLimpar1);
            this.groupBox4.Controls.Add(this.TxtCodigo1);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.MtxtCpf1);
            this.groupBox4.Controls.Add(this.txtNome1);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox4.Location = new System.Drawing.Point(-2, -11);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(597, 236);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Hospede";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // dTCadastro2
            // 
            this.dTCadastro2.Enabled = false;
            this.dTCadastro2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTCadastro2.Location = new System.Drawing.Point(217, 19);
            this.dTCadastro2.Name = "dTCadastro2";
            this.dTCadastro2.Size = new System.Drawing.Size(104, 20);
            this.dTCadastro2.TabIndex = 49;
            this.dTCadastro2.Value = new System.DateTime(2020, 7, 2, 0, 0, 0, 0);
            this.dTCadastro2.ValueChanged += new System.EventHandler(this.dTCadastro2_ValueChanged);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Location = new System.Drawing.Point(8, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(598, 251);
            this.tabControl2.TabIndex = 29;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tabControl2);
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(615, 515);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consultar e Editar Professor";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(623, 541);
            this.tabControl1.TabIndex = 64;
            // 
            // professorTableAdapter
            // 
            this.professorTableAdapter.ClearBeforeFill = true;
            // 
            // FrmProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 651);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmProfessor";
            this.Text = "FrmProfessor";
            this.Load += new System.EventHandler(this.FrmProfessor_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.DtgvProfessor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.professorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.escolaDataSet)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DtgvProfessor1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox MtxtTelefone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnLimpar1;
        private System.Windows.Forms.Label TxtCodigo1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox MtxtCpf1;
        private System.Windows.Forms.TextBox txtNome1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripSplitButton btnNovo;
        private System.Windows.Forms.ToolStripSplitButton btnCadastrar;
        private System.Windows.Forms.ToolStripSplitButton btnEditar;
        private System.Windows.Forms.ToolStripSplitButton btnExcluir;
        private System.Windows.Forms.ToolStripSplitButton btnSair;
        private System.Windows.Forms.Button btnLimparr;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.DateTimePicker dTCadastro2;
        private EscolaDataSet escolaDataSet;
        private System.Windows.Forms.BindingSource professorBindingSource;
        private EscolaDataSetTableAdapters.ProfessorTableAdapter professorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCadastroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
    }
}