namespace Escola
{
    partial class FrmPMateria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPMateria));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.btnNovo = new System.Windows.Forms.ToolStripSplitButton();
            this.btnCadastrar = new System.Windows.Forms.ToolStripSplitButton();
            this.btnEditar = new System.Windows.Forms.ToolStripSplitButton();
            this.btnExcluir = new System.Windows.Forms.ToolStripSplitButton();
            this.btnSair = new System.Windows.Forms.ToolStripSplitButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbProf = new System.Windows.Forms.ComboBox();
            this.btnLimpar1 = new System.Windows.Forms.Button();
            this.TxtCodigo1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDesc1 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnLimparr = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DtgvMateria1 = new System.Windows.Forms.DataGridView();
            this.groupBox8.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgvMateria1)).BeginInit();
            this.SuspendLayout();
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
            this.groupBox8.Location = new System.Drawing.Point(4, 547);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(304, 50);
            this.groupBox8.TabIndex = 64;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Teclas de Atalho";
            this.groupBox8.Enter += new System.EventHandler(this.groupBox8_Enter);
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
            this.label23.Click += new System.EventHandler(this.label23_Click);
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
            this.label21.Click += new System.EventHandler(this.label21_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(119, 21);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(55, 13);
            this.label20.TabIndex = 55;
            this.label20.Text = "Alterar(F3)";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(58, 21);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(55, 13);
            this.label18.TabIndex = 54;
            this.label18.Text = "Salvar(F2)";
            this.label18.Click += new System.EventHandler(this.label18_Click);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 600);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(618, 46);
            this.statusStrip1.TabIndex = 63;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
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
            this.btnNovo.ButtonClick += new System.EventHandler(this.btnNovo_ButtonClick);
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
            this.btnCadastrar.ButtonClick += new System.EventHandler(this.btnCadastrar_ButtonClick);
            // 
            // btnEditar
            // 
            this.btnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(56, 44);
            this.btnEditar.Text = "toolStripSplitButton2";
            this.btnEditar.ButtonClick += new System.EventHandler(this.btnEditar_ButtonClick);
            // 
            // btnExcluir
            // 
            this.btnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(56, 44);
            this.btnExcluir.Text = "toolStripSplitButton3";
            this.btnExcluir.ButtonClick += new System.EventHandler(this.btnExcluir_ButtonClick);
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
            this.btnSair.ButtonClick += new System.EventHandler(this.btnSair_ButtonClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(623, 541);
            this.tabControl1.TabIndex = 62;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tabControl2);
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(615, 515);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consultar e Editar Disciplinas";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Location = new System.Drawing.Point(8, 4);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(598, 247);
            this.tabControl2.TabIndex = 29;
            this.tabControl2.SelectedIndexChanged += new System.EventHandler(this.tabControl2_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(590, 221);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro de Disciplina";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.cbProf);
            this.groupBox4.Controls.Add(this.btnLimpar1);
            this.groupBox4.Controls.Add(this.TxtCodigo1);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.txtDesc1);
            this.groupBox4.Controls.Add(this.label15);
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
            // cbProf
            // 
            this.cbProf.FormattingEnabled = true;
            this.cbProf.Location = new System.Drawing.Point(79, 110);
            this.cbProf.Name = "cbProf";
            this.cbProf.Size = new System.Drawing.Size(121, 21);
            this.cbProf.TabIndex = 47;
            this.cbProf.DropDown += new System.EventHandler(this.cbProf_DropDown);
            this.cbProf.SelectedIndexChanged += new System.EventHandler(this.cbProf_SelectedIndexChanged);
            // 
            // btnLimpar1
            // 
            this.btnLimpar1.AutoSize = true;
            this.btnLimpar1.BackColor = System.Drawing.Color.White;
            this.btnLimpar1.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar1.Image")));
            this.btnLimpar1.Location = new System.Drawing.Point(79, 170);
            this.btnLimpar1.Name = "btnLimpar1";
            this.btnLimpar1.Size = new System.Drawing.Size(65, 51);
            this.btnLimpar1.TabIndex = 46;
            this.btnLimpar1.Text = "Limpar";
            this.btnLimpar1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimpar1.UseVisualStyleBackColor = false;
            this.btnLimpar1.Click += new System.EventHandler(this.btnLimpar1_Click);
            // 
            // TxtCodigo1
            // 
            this.TxtCodigo1.AutoSize = true;
            this.TxtCodigo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigo1.ForeColor = System.Drawing.Color.Black;
            this.TxtCodigo1.Location = new System.Drawing.Point(76, 44);
            this.TxtCodigo1.Name = "TxtCodigo1";
            this.TxtCodigo1.Size = new System.Drawing.Size(16, 15);
            this.TxtCodigo1.TabIndex = 45;
            this.TxtCodigo1.Text = "...";
            this.TxtCodigo1.Click += new System.EventHandler(this.TxtCodigo1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(13, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 15);
            this.label12.TabIndex = 44;
            this.label12.Text = "Codigo:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // txtDesc1
            // 
            this.txtDesc1.ForeColor = System.Drawing.Color.Purple;
            this.txtDesc1.Location = new System.Drawing.Point(79, 75);
            this.txtDesc1.Name = "txtDesc1";
            this.txtDesc1.Size = new System.Drawing.Size(346, 20);
            this.txtDesc1.TabIndex = 38;
            this.txtDesc1.TextChanged += new System.EventHandler(this.txtDesc1_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(12, 111);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 15);
            this.label15.TabIndex = 3;
            this.label15.Text = "Professor:";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(13, 76);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 15);
            this.label16.TabIndex = 1;
            this.label16.Text = "Disciplina:";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Transparent;
            this.groupBox6.Controls.Add(this.btnLimparr);
            this.groupBox6.Controls.Add(this.btnPesquisar);
            this.groupBox6.Controls.Add(this.txtPesquisar);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.DtgvMateria1);
            this.groupBox6.Location = new System.Drawing.Point(7, 257);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(599, 263);
            this.groupBox6.TabIndex = 28;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Cliente(s) Cadastrados no sistema";
            this.groupBox6.Enter += new System.EventHandler(this.groupBox6_Enter);
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
            this.btnLimparr.Click += new System.EventHandler(this.btnLimparr_Click);
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
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtPesquisar.Location = new System.Drawing.Point(190, 32);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(200, 21);
            this.txtPesquisar.TabIndex = 49;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label8.Location = new System.Drawing.Point(27, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Informe da Disciplina:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // DtgvMateria1
            // 
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.DtgvMateria1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DtgvMateria1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.DtgvMateria1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DtgvMateria1.DefaultCellStyle = dataGridViewCellStyle4;
            this.DtgvMateria1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.DtgvMateria1.Location = new System.Drawing.Point(10, 72);
            this.DtgvMateria1.Name = "DtgvMateria1";
            this.DtgvMateria1.Size = new System.Drawing.Size(583, 185);
            this.DtgvMateria1.TabIndex = 7;
            this.DtgvMateria1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgvMateria1_CellContentClick);
            // 
            // FrmPMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(618, 646);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmPMateria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Materias";
            this.Load += new System.EventHandler(this.FrmMateria_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMateria_KeyDown);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgvMateria1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripSplitButton btnNovo;
        private System.Windows.Forms.ToolStripSplitButton btnCadastrar;
        private System.Windows.Forms.ToolStripSplitButton btnEditar;
        private System.Windows.Forms.ToolStripSplitButton btnExcluir;
        private System.Windows.Forms.ToolStripSplitButton btnSair;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnLimparr;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView DtgvMateria1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbProf;
        private System.Windows.Forms.Button btnLimpar1;
        private System.Windows.Forms.Label TxtCodigo1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDesc1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}