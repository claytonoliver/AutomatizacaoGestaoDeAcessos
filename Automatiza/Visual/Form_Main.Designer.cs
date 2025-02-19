namespace Automatiza.Visual
{
    partial class Form_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            PanelSuperior = new Panel();
            Pnl_lateral = new Panel();
            btn_IniciarSoliciacao = new Button();
            Pnl_lateral.SuspendLayout();
            SuspendLayout();
            // 
            // PanelSuperior
            // 
            PanelSuperior.BackColor = Color.DodgerBlue;
            PanelSuperior.Dock = DockStyle.Top;
            PanelSuperior.Location = new Point(0, 0);
            PanelSuperior.Name = "PanelSuperior";
            PanelSuperior.Size = new Size(828, 42);
            PanelSuperior.TabIndex = 0;
            // 
            // Pnl_lateral
            // 
            Pnl_lateral.BackColor = Color.SteelBlue;
            Pnl_lateral.Controls.Add(btn_IniciarSoliciacao);
            Pnl_lateral.Dock = DockStyle.Left;
            Pnl_lateral.Location = new Point(0, 42);
            Pnl_lateral.Name = "Pnl_lateral";
            Pnl_lateral.Size = new Size(200, 452);
            Pnl_lateral.TabIndex = 1;
            // 
            // btn_IniciarSoliciacao
            // 
            btn_IniciarSoliciacao.BackgroundImage = (Image)resources.GetObject("btn_IniciarSoliciacao.BackgroundImage");
            btn_IniciarSoliciacao.BackgroundImageLayout = ImageLayout.Zoom;
            btn_IniciarSoliciacao.Location = new Point(59, 36);
            btn_IniciarSoliciacao.Name = "btn_IniciarSoliciacao";
            btn_IniciarSoliciacao.Size = new Size(62, 62);
            btn_IniciarSoliciacao.TabIndex = 0;
            btn_IniciarSoliciacao.UseVisualStyleBackColor = true;
            btn_IniciarSoliciacao.Click += btn_IniciarSoliciacao_Click;
            // 
            // Form_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(828, 494);
            Controls.Add(Pnl_lateral);
            Controls.Add(PanelSuperior);
            IsMdiContainer = true;
            Name = "Form_Main";
            Text = "Automatização Gestão de Acessos";
            Pnl_lateral.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelSuperior;
        private Panel Pnl_lateral;
        private Button btn_IniciarSoliciacao;
    }
}