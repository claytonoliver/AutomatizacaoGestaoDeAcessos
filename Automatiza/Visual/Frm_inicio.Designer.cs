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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_inicio));
            pnl_principal = new Panel();
            btnGerarPlanilha = new Button();
            cb_cargoAcesso = new ComboBox();
            PanelSuperior = new Panel();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            TB_identifica = new TextBox();
            cb_AlteraBasePa = new CheckBox();
            tb_BasePA = new TextBox();
            tb_usuarioSisbr = new TextBox();
            cb_revoga = new CheckBox();
            cb_concecao = new CheckBox();
            pnl_principal.SuspendLayout();
            PanelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnl_principal
            // 
            pnl_principal.Controls.Add(btnGerarPlanilha);
            pnl_principal.Controls.Add(cb_cargoAcesso);
            pnl_principal.Controls.Add(PanelSuperior);
            pnl_principal.Controls.Add(label7);
            pnl_principal.Controls.Add(TB_identifica);
            pnl_principal.Controls.Add(cb_AlteraBasePa);
            pnl_principal.Controls.Add(tb_BasePA);
            pnl_principal.Controls.Add(tb_usuarioSisbr);
            pnl_principal.Controls.Add(cb_revoga);
            pnl_principal.Controls.Add(cb_concecao);
            pnl_principal.Dock = DockStyle.Fill;
            pnl_principal.Location = new Point(0, 0);
            pnl_principal.Name = "pnl_principal";
            pnl_principal.Size = new Size(448, 402);
            pnl_principal.TabIndex = 21;
            // 
            // btnGerarPlanilha
            // 
            btnGerarPlanilha.BackColor = Color.FromArgb(64, 64, 64);
            btnGerarPlanilha.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGerarPlanilha.ForeColor = Color.White;
            btnGerarPlanilha.Location = new Point(167, 273);
            btnGerarPlanilha.Name = "btnGerarPlanilha";
            btnGerarPlanilha.Size = new Size(115, 51);
            btnGerarPlanilha.TabIndex = 91;
            btnGerarPlanilha.Text = "Gerar Planilha";
            btnGerarPlanilha.UseVisualStyleBackColor = false;
            btnGerarPlanilha.Click += btnGerarPlanilha_Click;
            // 
            // cb_cargoAcesso
            // 
            cb_cargoAcesso.FormattingEnabled = true;
            cb_cargoAcesso.Location = new Point(112, 100);
            cb_cargoAcesso.Name = "cb_cargoAcesso";
            cb_cargoAcesso.Size = new Size(224, 23);
            cb_cargoAcesso.TabIndex = 89;
            // 
            // PanelSuperior
            // 
            PanelSuperior.BackColor = Color.FromArgb(64, 64, 64);
            PanelSuperior.Controls.Add(label6);
            PanelSuperior.Controls.Add(pictureBox1);
            PanelSuperior.Dock = DockStyle.Top;
            PanelSuperior.Location = new Point(0, 0);
            PanelSuperior.Name = "PanelSuperior";
            PanelSuperior.Size = new Size(448, 42);
            PanelSuperior.TabIndex = 87;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(127, 0);
            label6.Name = "label6";
            label6.Size = new Size(194, 37);
            label6.TabIndex = 0;
            label6.Text = "AUTOMATIZA";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(-52, -86);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(159, 238);
            pictureBox1.TabIndex = 89;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Black;
            label7.Location = new Point(165, 346);
            label7.Name = "label7";
            label7.Size = new Size(118, 15);
            label7.TabIndex = 88;
            label7.Text = "Created by CLAYTON";
            // 
            // TB_identifica
            // 
            TB_identifica.Location = new Point(112, 164);
            TB_identifica.Name = "TB_identifica";
            TB_identifica.PlaceholderText = "Nome Arquivo";
            TB_identifica.Size = new Size(224, 23);
            TB_identifica.TabIndex = 85;
            // 
            // cb_AlteraBasePa
            // 
            cb_AlteraBasePa.AutoSize = true;
            cb_AlteraBasePa.Location = new Point(172, 234);
            cb_AlteraBasePa.Name = "cb_AlteraBasePa";
            cb_AlteraBasePa.Size = new Size(105, 19);
            cb_AlteraBasePa.TabIndex = 81;
            cb_AlteraBasePa.Text = "Alterar Base PA";
            cb_AlteraBasePa.UseVisualStyleBackColor = true;
            cb_AlteraBasePa.CheckedChanged += SelectBase_CheckedChanged;
            // 
            // tb_BasePA
            // 
            tb_BasePA.Location = new Point(112, 196);
            tb_BasePA.Name = "tb_BasePA";
            tb_BasePA.PlaceholderText = "Base PA";
            tb_BasePA.Size = new Size(224, 23);
            tb_BasePA.TabIndex = 77;
            tb_BasePA.Visible = false;
            // 
            // tb_usuarioSisbr
            // 
            tb_usuarioSisbr.Location = new Point(112, 132);
            tb_usuarioSisbr.Name = "tb_usuarioSisbr";
            tb_usuarioSisbr.PlaceholderText = "Usuario";
            tb_usuarioSisbr.Size = new Size(224, 23);
            tb_usuarioSisbr.TabIndex = 76;
            // 
            // cb_revoga
            // 
            cb_revoga.AutoSize = true;
            cb_revoga.Location = new Point(255, 68);
            cb_revoga.Name = "cb_revoga";
            cb_revoga.Size = new Size(84, 19);
            cb_revoga.TabIndex = 43;
            cb_revoga.Text = "Revogação";
            cb_revoga.UseVisualStyleBackColor = true;
            cb_revoga.CheckedChanged += cb_revoga_CheckedChanged;
            // 
            // cb_concecao
            // 
            cb_concecao.AutoSize = true;
            cb_concecao.Location = new Point(112, 68);
            cb_concecao.Name = "cb_concecao";
            cb_concecao.Size = new Size(79, 19);
            cb_concecao.TabIndex = 42;
            cb_concecao.Text = "Conceção";
            cb_concecao.UseVisualStyleBackColor = true;
            cb_concecao.CheckedChanged += cb_concecao_CheckedChanged;
            // 
            // Frm_inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 402);
            Controls.Add(pnl_principal);
            Name = "Frm_inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AUTOMATIZA ";
            pnl_principal.ResumeLayout(false);
            pnl_principal.PerformLayout();
            PanelSuperior.ResumeLayout(false);
            PanelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        public CheckBox cb_AlteraBasePa;
        public TextBox tb_BasePA;
        public TextBox tb_usuarioSisbr;
        public CheckBox cb_revoga;
        public CheckBox cb_concecao;
        public Panel pnl_principal;
        public TextBox TB_identifica;
        private ProgressBar progressBar;
        private Panel PanelSuperior;
        private Label label6;
        private PictureBox pictureBox1;
        private Label label7;
        private ComboBox cb_cargoAcesso;
        private Button btnGerarPlanilha;
    }
}