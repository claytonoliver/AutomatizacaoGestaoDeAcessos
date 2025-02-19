namespace Automatiza.Visual
{
    partial class Frm_Solicitacao
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
            Send = new Button();
            TB_identifica = new TextBox();
            label2 = new Label();
            CB_Aprova = new CheckBox();
            SelectBase = new CheckBox();
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
            SuspendLayout();
            // 
            // Send
            // 
            Send.BackColor = SystemColors.Control;
            Send.Location = new Point(353, 368);
            Send.Name = "Send";
            Send.Size = new Size(166, 62);
            Send.TabIndex = 109;
            Send.Text = "Enviar mensagem agora";
            Send.UseVisualStyleBackColor = false;
            // 
            // TB_identifica
            // 
            TB_identifica.Location = new Point(282, 238);
            TB_identifica.Name = "TB_identifica";
            TB_identifica.Size = new Size(100, 23);
            TB_identifica.TabIndex = 108;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(207, 242);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 107;
            label2.Text = "Identificador";
            // 
            // CB_Aprova
            // 
            CB_Aprova.AutoSize = true;
            CB_Aprova.Location = new Point(355, 316);
            CB_Aprova.Name = "CB_Aprova";
            CB_Aprova.Size = new Size(164, 19);
            CB_Aprova.TabIndex = 106;
            CB_Aprova.Text = "Aprovação de Grupos CTA";
            CB_Aprova.UseVisualStyleBackColor = true;
            // 
            // SelectBase
            // 
            SelectBase.AutoSize = true;
            SelectBase.Location = new Point(124, 316);
            SelectBase.Name = "SelectBase";
            SelectBase.Size = new Size(141, 19);
            SelectBase.TabIndex = 105;
            SelectBase.Text = "Selecionar Base do PA";
            SelectBase.UseVisualStyleBackColor = true;
            // 
            // TB_base
            // 
            TB_base.Location = new Point(282, 275);
            TB_base.Name = "TB_base";
            TB_base.Size = new Size(100, 23);
            TB_base.TabIndex = 102;
            TB_base.Visible = false;
            // 
            // TB_name
            // 
            TB_name.Location = new Point(282, 201);
            TB_name.Name = "TB_name";
            TB_name.Size = new Size(100, 23);
            TB_name.TabIndex = 101;
            // 
            // LB_base
            // 
            LB_base.AutoSize = true;
            LB_base.Location = new Point(207, 279);
            LB_base.Name = "LB_base";
            LB_base.Size = new Size(48, 15);
            LB_base.TabIndex = 100;
            LB_base.Text = "Base PA";
            LB_base.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(207, 205);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 99;
            label1.Text = "Login SISBR";
            // 
            // RB_8
            // 
            RB_8.AutoSize = true;
            RB_8.Location = new Point(353, 120);
            RB_8.Name = "RB_8";
            RB_8.Size = new Size(120, 19);
            RB_8.TabIndex = 98;
            RB_8.Text = "Gerente de contas";
            RB_8.UseVisualStyleBackColor = true;
            // 
            // RB_7
            // 
            RB_7.AutoSize = true;
            RB_7.Location = new Point(353, 95);
            RB_7.Name = "RB_7";
            RB_7.Size = new Size(83, 19);
            RB_7.TabIndex = 97;
            RB_7.Text = "Gerente PA";
            RB_7.UseVisualStyleBackColor = true;
            // 
            // RB_5
            // 
            RB_5.AutoSize = true;
            RB_5.Location = new Point(353, 145);
            RB_5.Name = "RB_5";
            RB_5.Size = new Size(147, 19);
            RB_5.TabIndex = 96;
            RB_5.Text = "Gerente Administrativo";
            RB_5.UseVisualStyleBackColor = true;
            // 
            // RB_4
            // 
            RB_4.AutoSize = true;
            RB_4.Location = new Point(124, 169);
            RB_4.Name = "RB_4";
            RB_4.Size = new Size(76, 19);
            RB_4.TabIndex = 95;
            RB_4.Text = "Estagiário";
            RB_4.UseVisualStyleBackColor = true;
            // 
            // RB_3
            // 
            RB_3.AutoSize = true;
            RB_3.Location = new Point(124, 144);
            RB_3.Name = "RB_3";
            RB_3.Size = new Size(54, 19);
            RB_3.TabIndex = 94;
            RB_3.Text = "Caixa";
            RB_3.UseVisualStyleBackColor = true;
            // 
            // RB_2
            // 
            RB_2.AutoSize = true;
            RB_2.Location = new Point(124, 119);
            RB_2.Name = "RB_2";
            RB_2.Size = new Size(111, 19);
            RB_2.TabIndex = 92;
            RB_2.Text = "Caixa Tesoureiro";
            RB_2.UseVisualStyleBackColor = true;
            // 
            // RB_1
            // 
            RB_1.AutoSize = true;
            RB_1.Location = new Point(124, 94);
            RB_1.Name = "RB_1";
            RB_1.Size = new Size(167, 19);
            RB_1.TabIndex = 91;
            RB_1.Text = "Assistente de Atendimento";
            RB_1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(261, 55);
            label4.Name = "label4";
            label4.Size = new Size(103, 15);
            label4.TabIndex = 90;
            label4.Text = "Planilha de acesso\r\n";
            // 
            // cb_revoga
            // 
            cb_revoga.AutoSize = true;
            cb_revoga.Location = new Point(355, 21);
            cb_revoga.Name = "cb_revoga";
            cb_revoga.Size = new Size(81, 19);
            cb_revoga.TabIndex = 89;
            cb_revoga.Text = "revogação";
            cb_revoga.UseVisualStyleBackColor = true;
            // 
            // cb_concecao
            // 
            cb_concecao.AutoSize = true;
            cb_concecao.Location = new Point(188, 21);
            cb_concecao.Name = "cb_concecao";
            cb_concecao.Size = new Size(77, 19);
            cb_concecao.TabIndex = 88;
            cb_concecao.Text = "conceção";
            cb_concecao.UseVisualStyleBackColor = true;
            // 
            // BTN_start
            // 
            BTN_start.BackColor = SystemColors.Control;
            BTN_start.Cursor = Cursors.Hand;
            BTN_start.FlatStyle = FlatStyle.Flat;
            BTN_start.Location = new Point(116, 368);
            BTN_start.Name = "BTN_start";
            BTN_start.Size = new Size(166, 62);
            BTN_start.TabIndex = 87;
            BTN_start.Text = "Iniciar";
            BTN_start.TextImageRelation = TextImageRelation.TextBeforeImage;
            BTN_start.UseVisualStyleBackColor = false;
            // 
            // Frm_Solicitacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(624, 441);
            ControlBox = false;
            Controls.Add(Send);
            Controls.Add(TB_identifica);
            Controls.Add(label2);
            Controls.Add(CB_Aprova);
            Controls.Add(SelectBase);
            Controls.Add(TB_base);
            Controls.Add(TB_name);
            Controls.Add(LB_base);
            Controls.Add(label1);
            Controls.Add(RB_8);
            Controls.Add(RB_7);
            Controls.Add(RB_5);
            Controls.Add(RB_4);
            Controls.Add(RB_3);
            Controls.Add(RB_2);
            Controls.Add(RB_1);
            Controls.Add(label4);
            Controls.Add(cb_revoga);
            Controls.Add(cb_concecao);
            Controls.Add(BTN_start);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Frm_Solicitacao";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Frm_Solicitacao";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Send;
        public TextBox TB_identifica;
        private Label label2;
        public CheckBox CB_Aprova;
        public CheckBox SelectBase;
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
    }
}