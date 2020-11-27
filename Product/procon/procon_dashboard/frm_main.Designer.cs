namespace procon_dashboard
{
    partial class frm_main
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_host = new System.Windows.Forms.TextBox();
            this.txt_token = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_ping = new System.Windows.Forms.Button();
            this.btn_matches = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Host";
            // 
            // txt_host
            // 
            this.txt_host.Location = new System.Drawing.Point(65, 55);
            this.txt_host.Name = "txt_host";
            this.txt_host.Size = new System.Drawing.Size(276, 26);
            this.txt_host.TabIndex = 1;
            this.txt_host.Text = "http://112.137.129.202:8003/";
            this.txt_host.TextChanged += new System.EventHandler(this.txt_host_TextChanged);
            // 
            // txt_token
            // 
            this.txt_token.Location = new System.Drawing.Point(65, 112);
            this.txt_token.Multiline = true;
            this.txt_token.Name = "txt_token";
            this.txt_token.Size = new System.Drawing.Size(276, 178);
            this.txt_token.TabIndex = 3;
            this.txt_token.Text = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJkYXRhIjoiZHR1MDEiLCJpYXQiOjE2MDY0NjY2NDQs" +
    "ImV4cCI6MTYwNjU1MzA0NH0.dUBHa6OZk6nqm_Mx6Zn4kBXvorEOuvbpBikg8Ws5bvI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Token";
            // 
            // btn_ping
            // 
            this.btn_ping.Location = new System.Drawing.Point(65, 332);
            this.btn_ping.Name = "btn_ping";
            this.btn_ping.Size = new System.Drawing.Size(115, 30);
            this.btn_ping.TabIndex = 4;
            this.btn_ping.Text = "Ping";
            this.btn_ping.UseVisualStyleBackColor = true;
            this.btn_ping.Click += new System.EventHandler(this.btn_ping_Click);
            // 
            // btn_matches
            // 
            this.btn_matches.Enabled = false;
            this.btn_matches.Location = new System.Drawing.Point(226, 332);
            this.btn_matches.Name = "btn_matches";
            this.btn_matches.Size = new System.Drawing.Size(115, 30);
            this.btn_matches.TabIndex = 4;
            this.btn_matches.Text = "Matchs";
            this.btn_matches.UseVisualStyleBackColor = true;
            this.btn_matches.Click += new System.EventHandler(this.btn_matches_Click);
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 412);
            this.Controls.Add(this.btn_matches);
            this.Controls.Add(this.btn_ping);
            this.Controls.Add(this.txt_token);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_host);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_main";
            this.Text = "Dash Board";
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_host;
        private System.Windows.Forms.TextBox txt_token;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_ping;
        private System.Windows.Forms.Button btn_matches;
    }
}

