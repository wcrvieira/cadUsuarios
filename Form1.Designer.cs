namespace Estruturas
{
    partial class frmOperadores
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
            btnAbrir = new Button();
            btnGoogle = new Button();
            btnPainel = new Button();
            btnVSCode = new Button();
            btnFechar = new Button();
            btnApresenta = new Button();
            lsbMostra = new ListBox();
            btnLimpar = new Button();
            SuspendLayout();
            // 
            // btnAbrir
            // 
            btnAbrir.BackColor = SystemColors.GradientActiveCaption;
            btnAbrir.ForeColor = SystemColors.ControlLightLight;
            btnAbrir.Location = new Point(22, 24);
            btnAbrir.Name = "btnAbrir";
            btnAbrir.Size = new Size(180, 40);
            btnAbrir.TabIndex = 0;
            btnAbrir.Text = "Calculadora";
            btnAbrir.UseVisualStyleBackColor = false;
            btnAbrir.Click += btn_Click;
            // 
            // btnGoogle
            // 
            btnGoogle.BackColor = Color.Orange;
            btnGoogle.ForeColor = SystemColors.ControlLightLight;
            btnGoogle.Location = new Point(22, 84);
            btnGoogle.Name = "btnGoogle";
            btnGoogle.Size = new Size(180, 40);
            btnGoogle.TabIndex = 1;
            btnGoogle.Text = "Google Chrome";
            btnGoogle.UseVisualStyleBackColor = false;
            btnGoogle.Click += btnGoogle_Click;
            // 
            // btnPainel
            // 
            btnPainel.BackColor = Color.FromArgb(0, 192, 0);
            btnPainel.ForeColor = SystemColors.ControlLightLight;
            btnPainel.Location = new Point(22, 142);
            btnPainel.Name = "btnPainel";
            btnPainel.Size = new Size(180, 40);
            btnPainel.TabIndex = 2;
            btnPainel.Text = "Painel de controle";
            btnPainel.UseVisualStyleBackColor = false;
            btnPainel.Click += btnPainel_Click;
            // 
            // btnVSCode
            // 
            btnVSCode.BackColor = Color.Olive;
            btnVSCode.ForeColor = SystemColors.ControlLightLight;
            btnVSCode.Location = new Point(22, 198);
            btnVSCode.Name = "btnVSCode";
            btnVSCode.Size = new Size(180, 40);
            btnVSCode.TabIndex = 3;
            btnVSCode.Text = "Visual Studio Code";
            btnVSCode.UseVisualStyleBackColor = false;
            btnVSCode.Click += btnVSCode_Click;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.Red;
            btnFechar.ForeColor = SystemColors.ControlLightLight;
            btnFechar.Location = new Point(22, 257);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(180, 40);
            btnFechar.TabIndex = 4;
            btnFechar.Text = "Fechar aplicação";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // btnApresenta
            // 
            btnApresenta.BackColor = SystemColors.HotTrack;
            btnApresenta.ForeColor = SystemColors.ControlLightLight;
            btnApresenta.Location = new Point(220, 24);
            btnApresenta.Name = "btnApresenta";
            btnApresenta.Size = new Size(177, 40);
            btnApresenta.TabIndex = 6;
            btnApresenta.Text = "Apresentação pessoal";
            btnApresenta.UseVisualStyleBackColor = false;
            btnApresenta.Click += btnApresenta_Click;
            // 
            // lsbMostra
            // 
            lsbMostra.FormattingEnabled = true;
            lsbMostra.ItemHeight = 15;
            lsbMostra.Location = new Point(220, 84);
            lsbMostra.Name = "lsbMostra";
            lsbMostra.Size = new Size(274, 214);
            lsbMostra.TabIndex = 7;
            lsbMostra.SelectedIndexChanged += lsbMostra_SelectedIndexChanged;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = SystemColors.ControlDark;
            btnLimpar.ForeColor = SystemColors.ControlLightLight;
            btnLimpar.Location = new Point(411, 24);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(83, 40);
            btnLimpar.TabIndex = 8;
            btnLimpar.Text = "Limpar texto";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // frmOperadores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(506, 332);
            Controls.Add(btnLimpar);
            Controls.Add(lsbMostra);
            Controls.Add(btnApresenta);
            Controls.Add(btnFechar);
            Controls.Add(btnVSCode);
            Controls.Add(btnPainel);
            Controls.Add(btnGoogle);
            Controls.Add(btnAbrir);
            Name = "frmOperadores";
            Text = "Gerenciador de processos";
            Load += frmOperadores_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnAbrir;
        private Button btnGoogle;
        private Button btnPainel;
        private Button btnVSCode;
        private Button btnFechar;
        private Button btnApresenta;
        private ListBox lsbMostra;
        private Button btnLimpar;
    }
}
