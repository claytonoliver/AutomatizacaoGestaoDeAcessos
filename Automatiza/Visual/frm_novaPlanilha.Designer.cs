namespace Automatiza
{
    partial class novaPlanilha
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            tb_loginn = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tb_bspan = new TextBox();
            Bt_cria = new Button();
            cb_revoga = new CheckBox();
            cb_concecao = new CheckBox();
            label3 = new Label();
            tb_fluxo = new TextBox();
            label4 = new Label();
            tb_nomearq = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // tb_loginn
            // 
            tb_loginn.Location = new Point(199, 152);
            tb_loginn.Name = "tb_loginn";
            tb_loginn.Size = new Size(135, 23);
            tb_loginn.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 155);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 3;
            label1.Text = "login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 199);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 5;
            label2.Text = "base";
            // 
            // tb_bspan
            // 
            tb_bspan.Location = new Point(199, 196);
            tb_bspan.Name = "tb_bspan";
            tb_bspan.Size = new Size(135, 23);
            tb_bspan.TabIndex = 4;
            // 
            // Bt_cria
            // 
            Bt_cria.Location = new Point(80, 333);
            Bt_cria.Name = "Bt_cria";
            Bt_cria.Size = new Size(254, 92);
            Bt_cria.TabIndex = 6;
            Bt_cria.Text = "criar";
            Bt_cria.UseVisualStyleBackColor = true;
            Bt_cria.Click += Bt_cria_Click;
            // 
            // cb_revoga
            // 
            cb_revoga.AutoSize = true;
            cb_revoga.Location = new Point(253, 12);
            cb_revoga.Name = "cb_revoga";
            cb_revoga.Size = new Size(81, 19);
            cb_revoga.TabIndex = 45;
            cb_revoga.Text = "revogação";
            cb_revoga.UseVisualStyleBackColor = true;
            // 
            // cb_concecao
            // 
            cb_concecao.AutoSize = true;
            cb_concecao.Location = new Point(80, 12);
            cb_concecao.Name = "cb_concecao";
            cb_concecao.Size = new Size(77, 19);
            cb_concecao.TabIndex = 44;
            cb_concecao.Text = "conceção";
            cb_concecao.UseVisualStyleBackColor = true;
            cb_concecao.CheckedChanged += cb_concecao_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(80, 240);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 47;
            label3.Text = "Fluxo";
            // 
            // tb_fluxo
            // 
            tb_fluxo.Location = new Point(199, 237);
            tb_fluxo.Name = "tb_fluxo";
            tb_fluxo.Size = new Size(135, 23);
            tb_fluxo.TabIndex = 46;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(80, 278);
            label4.Name = "label4";
            label4.Size = new Size(100, 15);
            label4.TabIndex = 49;
            label4.Text = "Nome do arquivo";
            // 
            // tb_nomearq
            // 
            tb_nomearq.Location = new Point(199, 275);
            tb_nomearq.Name = "tb_nomearq";
            tb_nomearq.Size = new Size(135, 23);
            tb_nomearq.TabIndex = 50;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(97, 76);
            label5.Name = "label5";
            label5.Size = new Size(224, 30);
            label5.TabIndex = 52;
            label5.Text = "Atenção: ao utilizar este formaulário sera \r\npossivel solicitar apenas um unico fluxo";
            // 
            // novaPlanilha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 450);
            Controls.Add(label5);
            Controls.Add(tb_nomearq);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(tb_fluxo);
            Controls.Add(cb_revoga);
            Controls.Add(cb_concecao);
            Controls.Add(Bt_cria);
            Controls.Add(label2);
            Controls.Add(tb_bspan);
            Controls.Add(label1);
            Controls.Add(tb_loginn);
            Name = "novaPlanilha";
            Text = "novaPlanilha";
            Load += novaPlanilha_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private TextBox tb_loginn;
        private Label label1;
        private Label label2;
        private TextBox tb_bspan;
        private Button Bt_cria;
        private CheckBox cb_revoga;
        private CheckBox cb_concecao;
        private Label label3;
        private TextBox tb_fluxo;
        private Label label4;
        private TextBox tb_nomearq;
        private Label label5;
    }
}