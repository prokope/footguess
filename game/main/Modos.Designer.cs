namespace footguess_fecip
{
    partial class Modos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modos));
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.botao_escolher_br = new System.Windows.Forms.Button();
            this.botao_escolher_r11 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bebas Neue", 51.74999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(802, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 83);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timerba_Tick);
            // 
            // botao_escolher_br
            // 
            this.botao_escolher_br.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botao_escolher_br.BackgroundImage")));
            this.botao_escolher_br.FlatAppearance.BorderSize = 0;
            this.botao_escolher_br.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botao_escolher_br.Location = new System.Drawing.Point(875, 544);
            this.botao_escolher_br.Name = "botao_escolher_br";
            this.botao_escolher_br.Size = new System.Drawing.Size(213, 177);
            this.botao_escolher_br.TabIndex = 6;
            this.botao_escolher_br.UseVisualStyleBackColor = true;
            this.botao_escolher_br.Click += new System.EventHandler(this.botao_escolher_br_Click);
            // 
            // botao_escolher_r11
            // 
            this.botao_escolher_r11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botao_escolher_r11.BackgroundImage")));
            this.botao_escolher_r11.FlatAppearance.BorderSize = 0;
            this.botao_escolher_r11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botao_escolher_r11.Location = new System.Drawing.Point(1103, 544);
            this.botao_escolher_r11.Name = "botao_escolher_r11";
            this.botao_escolher_r11.Size = new System.Drawing.Size(212, 177);
            this.botao_escolher_r11.TabIndex = 7;
            this.botao_escolher_r11.UseVisualStyleBackColor = true;
            this.botao_escolher_r11.Click += new System.EventHandler(this.botao_escolher_r11_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(639, 544);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 177);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(1460, 901);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(393, 121);
            this.button3.TabIndex = 10;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Modos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.botao_escolher_r11);
            this.Controls.Add(this.botao_escolher_br);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Modos";
            this.Opacity = 0D;
            this.Text = "Modos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private Button botao_escolher_br;
        private Button botao_escolher_r11;
        private Button button1;
        private Button button3;
    }
}