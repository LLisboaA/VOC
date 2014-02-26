namespace Voice_O_Clock_2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblAtual = new System.Windows.Forms.Label();
            this.lblDesp = new System.Windows.Forms.Label();
            this.horaAtual = new System.Windows.Forms.Timer(this.components);
            this.horaDesp = new System.Windows.Forms.Timer(this.components);
            this.playerMusica = new AxWMPLib.AxWindowsMediaPlayer();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.playerMusica)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAtual
            // 
            this.lblAtual.AutoSize = true;
            this.lblAtual.BackColor = System.Drawing.Color.Transparent;
            this.lblAtual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAtual.Font = new System.Drawing.Font("Digital Readout Expanded", 95F);
            this.lblAtual.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblAtual.Location = new System.Drawing.Point(14, 93);
            this.lblAtual.Margin = new System.Windows.Forms.Padding(0);
            this.lblAtual.Name = "lblAtual";
            this.lblAtual.Size = new System.Drawing.Size(689, 109);
            this.lblAtual.TabIndex = 0;
            this.lblAtual.Text = "00:00:00";
            this.lblAtual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAtual.Click += new System.EventHandler(this.lblAtual_Click_1);
            // 
            // lblDesp
            // 
            this.lblDesp.AutoSize = true;
            this.lblDesp.BackColor = System.Drawing.Color.Transparent;
            this.lblDesp.Font = new System.Drawing.Font("Digital Readout Expanded", 30F);
            this.lblDesp.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblDesp.Location = new System.Drawing.Point(455, 298);
            this.lblDesp.Name = "lblDesp";
            this.lblDesp.Size = new System.Drawing.Size(217, 34);
            this.lblDesp.TabIndex = 1;
            this.lblDesp.Text = "__:__:__";
            this.lblDesp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // horaAtual
            // 
            this.horaAtual.Enabled = true;
            this.horaAtual.Interval = 1000;
            this.horaAtual.Tick += new System.EventHandler(this.horaAtual_Tick_1);
            // 
            // horaDesp
            // 
            this.horaDesp.Tick += new System.EventHandler(this.horaDesp_Tick_1);
            // 
            // playerMusica
            // 
            this.playerMusica.Enabled = true;
            this.playerMusica.Location = new System.Drawing.Point(657, 416);
            this.playerMusica.Name = "playerMusica";
            this.playerMusica.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("playerMusica.OcxState")));
            this.playerMusica.Size = new System.Drawing.Size(75, 23);
            this.playerMusica.TabIndex = 2;
            this.playerMusica.Visible = false;
            // 
            // button1
            // 
            this.button1.AutoEllipsis = true;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Rockwell", 14F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(659, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 10);
            this.button1.TabIndex = 0;
            this.button1.TabStop = false;
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(722, 451);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.playerMusica);
            this.Controls.Add(this.lblDesp);
            this.Controls.Add(this.lblAtual);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.playerMusica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDesp;
        private System.Windows.Forms.Timer horaAtual;
        private System.Windows.Forms.Timer horaDesp;
        private AxWMPLib.AxWindowsMediaPlayer playerMusica;
        private System.Windows.Forms.Label lblAtual;
        private System.Windows.Forms.Button button1;
    }
}

