namespace Automatiza
{
    partial class frm_substituicao
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
            Pnl_subs = new Panel();
            Send = new Button();
            CB_Aprova = new CheckBox();
            TB_identifica = new TextBox();
            label2 = new Label();
            menuStrip1 = new MenuStrip();
            BtInicio = new ToolStripMenuItem();
            usuáriosToolStripMenuItem = new ToolStripMenuItem();
            importarCargaToolStripMenuItem = new ToolStripMenuItem();
            novaPlanilhaToolStripMenuItem = new ToolStripMenuItem();
            substituiçãoToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            SelectBase = new CheckBox();
            label3 = new Label();
            TbAmostra = new TextBox();
            label5 = new Label();
            TB_base = new TextBox();
            TB_name = new TextBox();
            LB_base = new Label();
            label1 = new Label();
            cb_revogacao = new CheckBox();
            cb_concecao = new CheckBox();
            RB_3 = new RadioButton();
            RB_2 = new RadioButton();
            RB_1 = new RadioButton();
            label4 = new Label();
            progressBar = new ProgressBar();
            Pnl_subs.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // Pnl_subs
            // 
            Pnl_subs.Controls.Add(progressBar);
            Pnl_subs.Controls.Add(Send);
            Pnl_subs.Controls.Add(CB_Aprova);
            Pnl_subs.Controls.Add(TB_identifica);
            Pnl_subs.Controls.Add(label2);
            Pnl_subs.Controls.Add(menuStrip1);
            Pnl_subs.Controls.Add(button1);
            Pnl_subs.Controls.Add(SelectBase);
            Pnl_subs.Controls.Add(label3);
            Pnl_subs.Controls.Add(TbAmostra);
            Pnl_subs.Controls.Add(label5);
            Pnl_subs.Controls.Add(TB_base);
            Pnl_subs.Controls.Add(TB_name);
            Pnl_subs.Controls.Add(LB_base);
            Pnl_subs.Controls.Add(label1);
            Pnl_subs.Controls.Add(cb_revogacao);
            Pnl_subs.Controls.Add(cb_concecao);
            Pnl_subs.Controls.Add(RB_3);
            Pnl_subs.Controls.Add(RB_2);
            Pnl_subs.Controls.Add(RB_1);
            Pnl_subs.Controls.Add(label4);
            Pnl_subs.Location = new Point(0, 0);
            Pnl_subs.Name = "Pnl_subs";
            Pnl_subs.Size = new Size(802, 451);
            Pnl_subs.TabIndex = 0;
            // 
            // Send
            // 
            Send.Location = new Point(545, 358);
            Send.Name = "Send";
            Send.Size = new Size(133, 49);
            Send.TabIndex = 138;
            Send.Text = "Enviar mensagem agora";
            Send.UseVisualStyleBackColor = true;
            Send.Click += Send_Click;
            // 
            // CB_Aprova
            // 
            CB_Aprova.AutoSize = true;
            CB_Aprova.Location = new Point(163, 290);
            CB_Aprova.Name = "CB_Aprova";
            CB_Aprova.Size = new Size(164, 19);
            CB_Aprova.TabIndex = 137;
            CB_Aprova.Text = "Aprovação de Grupos CTA";
            CB_Aprova.UseVisualStyleBackColor = true;
            // 
            // TB_identifica
            // 
            TB_identifica.Location = new Point(238, 189);
            TB_identifica.Name = "TB_identifica";
            TB_identifica.Size = new Size(100, 23);
            TB_identifica.TabIndex = 136;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(163, 192);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 135;
            label2.Text = "Identificador";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { BtInicio, novaPlanilhaToolStripMenuItem, substituiçãoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(802, 24);
            menuStrip1.TabIndex = 134;
            menuStrip1.Text = "menuStrip1";
            // 
            // BtInicio
            // 
            BtInicio.DropDownItems.AddRange(new ToolStripItem[] { usuáriosToolStripMenuItem, importarCargaToolStripMenuItem });
            BtInicio.Name = "BtInicio";
            BtInicio.Size = new Size(48, 20);
            BtInicio.Text = "Inicio";
            BtInicio.Click += BtInicio_Click_1;
            // 
            // usuáriosToolStripMenuItem
            // 
            usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            usuáriosToolStripMenuItem.Size = new Size(154, 22);
            usuáriosToolStripMenuItem.Text = "Usuários";
            // 
            // importarCargaToolStripMenuItem
            // 
            importarCargaToolStripMenuItem.Name = "importarCargaToolStripMenuItem";
            importarCargaToolStripMenuItem.Size = new Size(154, 22);
            importarCargaToolStripMenuItem.Text = "Importar Carga";
            // 
            // novaPlanilhaToolStripMenuItem
            // 
            novaPlanilhaToolStripMenuItem.Name = "novaPlanilhaToolStripMenuItem";
            novaPlanilhaToolStripMenuItem.Size = new Size(90, 20);
            novaPlanilhaToolStripMenuItem.Text = "Acesso Unico";
            novaPlanilhaToolStripMenuItem.Click += novaPlanilhaToolStripMenuItem_Click;
            // 
            // substituiçãoToolStripMenuItem
            // 
            substituiçãoToolStripMenuItem.Name = "substituiçãoToolStripMenuItem";
            substituiçãoToolStripMenuItem.Size = new Size(84, 20);
            substituiçãoToolStripMenuItem.Text = "Substituição";
            // 
            // button1
            // 
            button1.Location = new Point(328, 352);
            button1.Name = "button1";
            button1.Size = new Size(133, 60);
            button1.TabIndex = 133;
            button1.Text = "Iniciar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // SelectBase
            // 
            SelectBase.AutoSize = true;
            SelectBase.Location = new Point(163, 251);
            SelectBase.Name = "SelectBase";
            SelectBase.Size = new Size(141, 19);
            SelectBase.TabIndex = 132;
            SelectBase.Text = "Selecionar Base do PA";
            SelectBase.UseVisualStyleBackColor = true;
            SelectBase.CheckedChanged += SelectBase_CheckedChanged_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(404, 247);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 131;
            label3.Text = "Saida:";
            // 
            // TbAmostra
            // 
            TbAmostra.Location = new Point(461, 244);
            TbAmostra.Name = "TbAmostra";
            TbAmostra.RightToLeft = RightToLeft.No;
            TbAmostra.Size = new Size(100, 23);
            TbAmostra.TabIndex = 125;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(404, 270);
            label5.Name = "label5";
            label5.Size = new Size(236, 30);
            label5.TabIndex = 130;
            label5.Text = "Verifique de se escolheu as opções corretas \r\nantes de iniciar.\r\n";
            // 
            // TB_base
            // 
            TB_base.Location = new Point(238, 218);
            TB_base.Name = "TB_base";
            TB_base.Size = new Size(100, 23);
            TB_base.TabIndex = 129;
            TB_base.Visible = false;
            // 
            // TB_name
            // 
            TB_name.Location = new Point(238, 158);
            TB_name.Name = "TB_name";
            TB_name.Size = new Size(100, 23);
            TB_name.TabIndex = 128;
            // 
            // LB_base
            // 
            LB_base.AutoSize = true;
            LB_base.Location = new Point(163, 221);
            LB_base.Name = "LB_base";
            LB_base.Size = new Size(48, 15);
            LB_base.TabIndex = 127;
            LB_base.Text = "Base PA";
            LB_base.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(163, 161);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 126;
            label1.Text = "Login SISBR";
            // 
            // cb_revogacao
            // 
            cb_revogacao.AutoSize = true;
            cb_revogacao.Location = new Point(409, 105);
            cb_revogacao.Name = "cb_revogacao";
            cb_revogacao.Size = new Size(81, 19);
            cb_revogacao.TabIndex = 124;
            cb_revogacao.Text = "revogação";
            cb_revogacao.UseVisualStyleBackColor = true;
            // 
            // cb_concecao
            // 
            cb_concecao.AutoSize = true;
            cb_concecao.Location = new Point(299, 105);
            cb_concecao.Name = "cb_concecao";
            cb_concecao.Size = new Size(77, 19);
            cb_concecao.TabIndex = 123;
            cb_concecao.Text = "conceção";
            cb_concecao.UseVisualStyleBackColor = true;
            // 
            // RB_3
            // 
            RB_3.AutoSize = true;
            RB_3.Location = new Point(416, 205);
            RB_3.Name = "RB_3";
            RB_3.Size = new Size(122, 19);
            RB_3.TabIndex = 122;
            RB_3.TabStop = true;
            RB_3.Text = "Caixa > Tesoureiro";
            RB_3.UseVisualStyleBackColor = true;
            // 
            // RB_2
            // 
            RB_2.AutoSize = true;
            RB_2.Location = new Point(416, 180);
            RB_2.Name = "RB_2";
            RB_2.Size = new Size(208, 19);
            RB_2.TabIndex = 121;
            RB_2.Text = "Gerente de contas > Gerente de PA";
            RB_2.UseVisualStyleBackColor = true;
            // 
            // RB_1
            // 
            RB_1.AutoSize = true;
            RB_1.Location = new Point(416, 155);
            RB_1.Name = "RB_1";
            RB_1.Size = new Size(215, 19);
            RB_1.TabIndex = 120;
            RB_1.Text = "Tesoureiro > Gerente Administrativo";
            RB_1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(328, 41);
            label4.Name = "label4";
            label4.Size = new Size(144, 32);
            label4.TabIndex = 119;
            label4.Text = "Substituição";
            // 
            // progressBar
            // 
            progressBar.Location = new Point(644, 41);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(129, 23);
            progressBar.Step = 20;
            progressBar.Style = ProgressBarStyle.Continuous;
            progressBar.TabIndex = 139;
            // 
            // frm_substituicao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Pnl_subs);
            Name = "frm_substituicao";
            Text = "Substituição";
            Load += frm_substituicao_Load;
            Pnl_subs.ResumeLayout(false);
            Pnl_subs.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        public CheckBox SelectBase;
        private Label label3;
        public TextBox TbAmostra;
        private Label label5;
        public TextBox TB_base;
        public TextBox TB_name;
        public Label LB_base;
        private Label label1;
        public CheckBox cb_revogacao;
        public CheckBox cb_concecao;
        public RadioButton RB_3;
        public RadioButton RB_2;
        public RadioButton RB_1;
        private Label label4;
        public Panel Pnl_subs;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem BtInicio;
        private ToolStripMenuItem usuáriosToolStripMenuItem;
        private ToolStripMenuItem importarCargaToolStripMenuItem;
        private ToolStripMenuItem novaPlanilhaToolStripMenuItem;
        private ToolStripMenuItem substituiçãoToolStripMenuItem;
        public TextBox TB_identifica;
        private Label label2;
        public CheckBox CB_Aprova;
        private Button Send;
        private ProgressBar progressBar;
    }
}