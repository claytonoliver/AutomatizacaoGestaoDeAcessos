namespace Automatiza
{
    partial class Frm_inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnl_principal = new Panel();
            Send = new Button();
            TB_identifica = new TextBox();
            label2 = new Label();
            CB_Aprova = new CheckBox();
            menuStrip1 = new MenuStrip();
            BtInicio = new ToolStripMenuItem();
            usuáriosToolStripMenuItem = new ToolStripMenuItem();
            importarCargaToolStripMenuItem = new ToolStripMenuItem();
            novaPlanilhaToolStripMenuItem = new ToolStripMenuItem();
            substituiçãoToolStripMenuItem = new ToolStripMenuItem();
            SelectBase = new CheckBox();
            label3 = new Label();
            TbAmostra = new TextBox();
            label5 = new Label();
            TB_base = new TextBox();
            TB_name = new TextBox();
            LB_base = new Label();
            label1 = new Label();
            RB_8 = new RadioButton();
            RB_7 = new RadioButton();
            RB_5 = new RadioButton();
            RB_4 = new RadioButton();
            RB_3 = new RadioButton();
            RB_2 = new RadioButton();
            RB_1 = new RadioButton();
            label4 = new Label();
            cb_revoga = new CheckBox();
            cb_concecao = new CheckBox();
            BTN_start = new Button();
            pnl_principal.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_principal
            // 
            pnl_principal.Controls.Add(Send);
            pnl_principal.Controls.Add(TB_identifica);
            pnl_principal.Controls.Add(label2);
            pnl_principal.Controls.Add(CB_Aprova);
            pnl_principal.Controls.Add(menuStrip1);
            pnl_principal.Controls.Add(SelectBase);
            pnl_principal.Controls.Add(label3);
            pnl_principal.Controls.Add(TbAmostra);
            pnl_principal.Controls.Add(label5);
            pnl_principal.Controls.Add(TB_base);
            pnl_principal.Controls.Add(TB_name);
            pnl_principal.Controls.Add(LB_base);
            pnl_principal.Controls.Add(label1);
            pnl_principal.Controls.Add(RB_8);
            pnl_principal.Controls.Add(RB_7);
            pnl_principal.Controls.Add(RB_5);
            pnl_principal.Controls.Add(RB_4);
            pnl_principal.Controls.Add(RB_3);
            pnl_principal.Controls.Add(RB_2);
            pnl_principal.Controls.Add(RB_1);
            pnl_principal.Controls.Add(label4);
            pnl_principal.Controls.Add(cb_revoga);
            pnl_principal.Controls.Add(cb_concecao);
            pnl_principal.Controls.Add(BTN_start);
            pnl_principal.Location = new Point(0, 0);
            pnl_principal.Name = "pnl_principal";
            pnl_principal.Size = new Size(794, 477);
            pnl_principal.TabIndex = 21;
            // 
            // Send
            // 
            Send.Location = new Point(546, 380);
            Send.Name = "Send";
            Send.Size = new Size(133, 49);
            Send.TabIndex = 86;
            Send.Text = "Enviar mensagem agora";
            Send.UseVisualStyleBackColor = true;
            Send.Click += Send_Click;
            // 
            // TB_identifica
            // 
            TB_identifica.Location = new Point(238, 283);
            TB_identifica.Name = "TB_identifica";
            TB_identifica.Size = new Size(100, 23);
            TB_identifica.TabIndex = 85;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(163, 286);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 84;
            label2.Text = "Identificador";
            // 
            // CB_Aprova
            // 
            CB_Aprova.AutoSize = true;
            CB_Aprova.Location = new Point(396, 316);
            CB_Aprova.Name = "CB_Aprova";
            CB_Aprova.Size = new Size(164, 19);
            CB_Aprova.TabIndex = 83;
            CB_Aprova.Text = "Aprovação de Grupos CTA";
            CB_Aprova.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { BtInicio, novaPlanilhaToolStripMenuItem, substituiçãoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(794, 24);
            menuStrip1.TabIndex = 82;
            menuStrip1.Text = "menuStrip1";
            // 
            // BtInicio
            // 
            BtInicio.DropDownItems.AddRange(new ToolStripItem[] { usuáriosToolStripMenuItem, importarCargaToolStripMenuItem });
            BtInicio.Name = "BtInicio";
            BtInicio.Size = new Size(48, 20);
            BtInicio.Text = "Inicio";
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
            novaPlanilhaToolStripMenuItem.Click += novaPlanilhaToolStripMenuItem_Click_1;
            // 
            // substituiçãoToolStripMenuItem
            // 
            substituiçãoToolStripMenuItem.Name = "substituiçãoToolStripMenuItem";
            substituiçãoToolStripMenuItem.Size = new Size(84, 20);
            substituiçãoToolStripMenuItem.Text = "Substituição";
            substituiçãoToolStripMenuItem.Click += substituiçãoToolStripMenuItem_Click_1;
            // 
            // SelectBase
            // 
            SelectBase.AutoSize = true;
            SelectBase.Location = new Point(158, 349);
            SelectBase.Name = "SelectBase";
            SelectBase.Size = new Size(141, 19);
            SelectBase.TabIndex = 81;
            SelectBase.Text = "Selecionar Base do PA";
            SelectBase.UseVisualStyleBackColor = true;
            SelectBase.CheckedChanged += SelectBase_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(392, 257);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 80;
            label3.Text = "Saida:";
            // 
            // TbAmostra
            // 
            TbAmostra.Location = new Point(436, 254);
            TbAmostra.Name = "TbAmostra";
            TbAmostra.RightToLeft = RightToLeft.No;
            TbAmostra.Size = new Size(100, 23);
            TbAmostra.TabIndex = 67;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(396, 283);
            label5.Name = "label5";
            label5.Size = new Size(236, 30);
            label5.TabIndex = 78;
            label5.Text = "Verifique de se escolheu as opções corretas \r\nantes de iniciar.\r\n";
            // 
            // TB_base
            // 
            TB_base.Location = new Point(238, 312);
            TB_base.Name = "TB_base";
            TB_base.Size = new Size(100, 23);
            TB_base.TabIndex = 77;
            TB_base.Visible = false;
            // 
            // TB_name
            // 
            TB_name.Location = new Point(238, 254);
            TB_name.Name = "TB_name";
            TB_name.Size = new Size(100, 23);
            TB_name.TabIndex = 76;
            // 
            // LB_base
            // 
            LB_base.AutoSize = true;
            LB_base.Location = new Point(163, 315);
            LB_base.Name = "LB_base";
            LB_base.Size = new Size(48, 15);
            LB_base.TabIndex = 75;
            LB_base.Text = "Base PA";
            LB_base.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(163, 257);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 74;
            label1.Text = "Login SISBR";
            // 
            // RB_8
            // 
            RB_8.AutoSize = true;
            RB_8.Location = new Point(438, 126);
            RB_8.Name = "RB_8";
            RB_8.Size = new Size(120, 19);
            RB_8.TabIndex = 73;
            RB_8.Text = "Gerente de contas";
            RB_8.UseVisualStyleBackColor = true;
            // 
            // RB_7
            // 
            RB_7.AutoSize = true;
            RB_7.Location = new Point(438, 101);
            RB_7.Name = "RB_7";
            RB_7.Size = new Size(83, 19);
            RB_7.TabIndex = 72;
            RB_7.Text = "Gerente PA";
            RB_7.UseVisualStyleBackColor = true;
            // 
            // RB_5
            // 
            RB_5.AutoSize = true;
            RB_5.Location = new Point(438, 151);
            RB_5.Name = "RB_5";
            RB_5.Size = new Size(147, 19);
            RB_5.TabIndex = 70;
            RB_5.Text = "Gerente Administrativo";
            RB_5.UseVisualStyleBackColor = true;
            // 
            // RB_4
            // 
            RB_4.AutoSize = true;
            RB_4.Location = new Point(209, 175);
            RB_4.Name = "RB_4";
            RB_4.Size = new Size(76, 19);
            RB_4.TabIndex = 69;
            RB_4.Text = "Estagiário";
            RB_4.UseVisualStyleBackColor = true;
            // 
            // RB_3
            // 
            RB_3.AutoSize = true;
            RB_3.Location = new Point(209, 150);
            RB_3.Name = "RB_3";
            RB_3.Size = new Size(54, 19);
            RB_3.TabIndex = 68;
            RB_3.Text = "Caixa";
            RB_3.UseVisualStyleBackColor = true;
            // 
            // RB_2
            // 
            RB_2.AutoSize = true;
            RB_2.Location = new Point(209, 125);
            RB_2.Name = "RB_2";
            RB_2.Size = new Size(111, 19);
            RB_2.TabIndex = 66;
            RB_2.Text = "Caixa Tesoureiro";
            RB_2.UseVisualStyleBackColor = true;
            // 
            // RB_1
            // 
            RB_1.AutoSize = true;
            RB_1.Location = new Point(209, 100);
            RB_1.Name = "RB_1";
            RB_1.Size = new Size(167, 19);
            RB_1.TabIndex = 65;
            RB_1.Text = "Assistente de Atendimento";
            RB_1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(346, 61);
            label4.Name = "label4";
            label4.Size = new Size(103, 15);
            label4.TabIndex = 64;
            label4.Text = "Planilha de acesso\r\n";
            // 
            // cb_revoga
            // 
            cb_revoga.AutoSize = true;
            cb_revoga.Location = new Point(440, 27);
            cb_revoga.Name = "cb_revoga";
            cb_revoga.Size = new Size(81, 19);
            cb_revoga.TabIndex = 43;
            cb_revoga.Text = "revogação";
            cb_revoga.UseVisualStyleBackColor = true;
            cb_revoga.CheckedChanged += cb_revoga_CheckedChanged;
            // 
            // cb_concecao
            // 
            cb_concecao.AutoSize = true;
            cb_concecao.Location = new Point(273, 27);
            cb_concecao.Name = "cb_concecao";
            cb_concecao.Size = new Size(77, 19);
            cb_concecao.TabIndex = 42;
            cb_concecao.Text = "conceção";
            cb_concecao.UseVisualStyleBackColor = true;
            cb_concecao.CheckedChanged += cb_concecao_CheckedChanged;
            // 
            // BTN_start
            // 
            BTN_start.Cursor = Cursors.Hand;
            BTN_start.FlatStyle = FlatStyle.Flat;
            BTN_start.Location = new Point(273, 373);
            BTN_start.Name = "BTN_start";
            BTN_start.Size = new Size(166, 62);
            BTN_start.TabIndex = 29;
            BTN_start.Text = "Iniciar";
            BTN_start.TextImageRelation = TextImageRelation.TextBeforeImage;
            BTN_start.UseVisualStyleBackColor = true;
            BTN_start.Click += BTN_start_Click_1;
            // 
            // Frm_inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 477);
            Controls.Add(pnl_principal);
            Name = "Frm_inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            pnl_principal.ResumeLayout(false);
            pnl_principal.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        public CheckBox SelectBase;
        private Label label3;
        public TextBox TbAmostra;
        private Label label5;
        public TextBox TB_base;
        public TextBox TB_name;
        public Label LB_base;
        private Label label1;
        public RadioButton RB_8;
        public RadioButton RB_7;
        public RadioButton RB_5;
        public RadioButton RB_4;
        public RadioButton RB_3;
        public RadioButton RB_2;
        public RadioButton RB_1;
        private Label label4;
        public CheckBox cb_revoga;
        public CheckBox cb_concecao;
        private Button BTN_start;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem BtInicio;
        private ToolStripMenuItem usuáriosToolStripMenuItem;
        private ToolStripMenuItem importarCargaToolStripMenuItem;
        private ToolStripMenuItem novaPlanilhaToolStripMenuItem;
        private ToolStripMenuItem substituiçãoToolStripMenuItem;
        public Panel pnl_principal;
        public CheckBox CB_Aprova;
        private Label label2;
        public TextBox TB_identifica;
        private Button Send;
        private ProgressBar progressBar;
    }
}