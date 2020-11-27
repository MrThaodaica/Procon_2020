namespace procon_dashboard
{
    partial class frm_map
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lb_tilePointDich = new System.Windows.Forms.Label();
            this.lb_areaPointDich = new System.Windows.Forms.Label();
            this.lb_teamIDDich = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lb_tilePointTa = new System.Windows.Forms.Label();
            this.lb_areaPointTa = new System.Windows.Forms.Label();
            this.lb_teamIDTa = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_currentTurn = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_jsonSubmit = new System.Windows.Forms.TextBox();
            this.panel_map = new System.Windows.Forms.Panel();
            this.lb_titleID = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_intervalMillis = new System.Windows.Forms.Label();
            this.lb_intervalMillis_ht = new System.Windows.Forms.Label();
            this.lb_turnMillis = new System.Windows.Forms.Label();
            this.lb_turns = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lb_matchTo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_idTeam = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.autoRefreshTimer = new System.Windows.Forms.Timer(this.components);
            this.lblCountDown = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_submit);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.lb_currentTurn);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(518, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(209, 357);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Trận Hiện Tại";
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(10, 757);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(96, 36);
            this.btn_submit.TabIndex = 4;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lb_tilePointDich);
            this.groupBox4.Controls.Add(this.lb_areaPointDich);
            this.groupBox4.Controls.Add(this.lb_teamIDDich);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.ForeColor = System.Drawing.Color.Red;
            this.groupBox4.Location = new System.Drawing.Point(10, 213);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(235, 150);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Enemy Army";
            // 
            // lb_tilePointDich
            // 
            this.lb_tilePointDich.AutoSize = true;
            this.lb_tilePointDich.Location = new System.Drawing.Point(121, 103);
            this.lb_tilePointDich.Name = "lb_tilePointDich";
            this.lb_tilePointDich.Size = new System.Drawing.Size(53, 19);
            this.lb_tilePointDich.TabIndex = 3;
            this.lb_tilePointDich.Text = "label15";
            // 
            // lb_areaPointDich
            // 
            this.lb_areaPointDich.AutoSize = true;
            this.lb_areaPointDich.Location = new System.Drawing.Point(121, 68);
            this.lb_areaPointDich.Name = "lb_areaPointDich";
            this.lb_areaPointDich.Size = new System.Drawing.Size(53, 19);
            this.lb_areaPointDich.TabIndex = 3;
            this.lb_areaPointDich.Text = "label15";
            // 
            // lb_teamIDDich
            // 
            this.lb_teamIDDich.AutoSize = true;
            this.lb_teamIDDich.Location = new System.Drawing.Point(122, 34);
            this.lb_teamIDDich.Name = "lb_teamIDDich";
            this.lb_teamIDDich.Size = new System.Drawing.Size(53, 19);
            this.lb_teamIDDich.TabIndex = 3;
            this.lb_teamIDDich.Text = "label15";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 68);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 19);
            this.label13.TabIndex = 2;
            this.label13.Text = "Area Point";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 19);
            this.label12.TabIndex = 1;
            this.label12.Text = "teamID";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 103);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 19);
            this.label14.TabIndex = 2;
            this.label14.Text = "Tile Point";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.lb_tilePointTa);
            this.groupBox3.Controls.Add(this.lb_areaPointTa);
            this.groupBox3.Controls.Add(this.lb_teamIDTa);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox3.Location = new System.Drawing.Point(10, 65);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(235, 142);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "My Army";
            // 
            // lb_tilePointTa
            // 
            this.lb_tilePointTa.AutoSize = true;
            this.lb_tilePointTa.Location = new System.Drawing.Point(121, 103);
            this.lb_tilePointTa.Name = "lb_tilePointTa";
            this.lb_tilePointTa.Size = new System.Drawing.Size(54, 19);
            this.lb_tilePointTa.TabIndex = 3;
            this.lb_tilePointTa.Text = "teamID";
            // 
            // lb_areaPointTa
            // 
            this.lb_areaPointTa.AutoSize = true;
            this.lb_areaPointTa.Location = new System.Drawing.Point(121, 68);
            this.lb_areaPointTa.Name = "lb_areaPointTa";
            this.lb_areaPointTa.Size = new System.Drawing.Size(54, 19);
            this.lb_areaPointTa.TabIndex = 3;
            this.lb_areaPointTa.Text = "teamID";
            // 
            // lb_teamIDTa
            // 
            this.lb_teamIDTa.AutoSize = true;
            this.lb_teamIDTa.Location = new System.Drawing.Point(121, 34);
            this.lb_teamIDTa.Name = "lb_teamIDTa";
            this.lb_teamIDTa.Size = new System.Drawing.Size(54, 19);
            this.lb_teamIDTa.TabIndex = 3;
            this.lb_teamIDTa.Text = "teamID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 19);
            this.label11.TabIndex = 2;
            this.label11.Text = "Tile Point";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 19);
            this.label9.TabIndex = 2;
            this.label9.Text = "Area Point";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "teamID";
            // 
            // lb_currentTurn
            // 
            this.lb_currentTurn.AutoSize = true;
            this.lb_currentTurn.Location = new System.Drawing.Point(90, 42);
            this.lb_currentTurn.Name = "lb_currentTurn";
            this.lb_currentTurn.Size = new System.Drawing.Size(36, 19);
            this.lb_currentTurn.TabIndex = 1;
            this.lb_currentTurn.Text = "Turn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Turn";
            // 
            // txt_jsonSubmit
            // 
            this.txt_jsonSubmit.Location = new System.Drawing.Point(745, 270);
            this.txt_jsonSubmit.Multiline = true;
            this.txt_jsonSubmit.Name = "txt_jsonSubmit";
            this.txt_jsonSubmit.Size = new System.Drawing.Size(187, 271);
            this.txt_jsonSubmit.TabIndex = 5;
            // 
            // panel_map
            // 
            this.panel_map.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_map.Location = new System.Drawing.Point(12, 41);
            this.panel_map.Name = "panel_map";
            this.panel_map.Size = new System.Drawing.Size(500, 500);
            this.panel_map.TabIndex = 8;
            this.panel_map.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_map_Paint);
            // 
            // lb_titleID
            // 
            this.lb_titleID.AutoSize = true;
            this.lb_titleID.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titleID.Location = new System.Drawing.Point(501, 9);
            this.lb_titleID.Name = "lb_titleID";
            this.lb_titleID.Size = new System.Drawing.Size(53, 21);
            this.lb_titleID.TabIndex = 10;
            this.lb_titleID.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_intervalMillis);
            this.groupBox1.Controls.Add(this.lb_intervalMillis_ht);
            this.groupBox1.Controls.Add(this.lb_turnMillis);
            this.groupBox1.Controls.Add(this.lb_turns);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lb_matchTo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lb_idTeam);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(745, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 212);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi Tiết Các Trận";
            // 
            // lb_intervalMillis
            // 
            this.lb_intervalMillis.AutoSize = true;
            this.lb_intervalMillis.Location = new System.Drawing.Point(96, 183);
            this.lb_intervalMillis.Name = "lb_intervalMillis";
            this.lb_intervalMillis.Size = new System.Drawing.Size(63, 13);
            this.lb_intervalMillis.TabIndex = 14;
            this.lb_intervalMillis.Text = "intervalMillis";
            // 
            // lb_intervalMillis_ht
            // 
            this.lb_intervalMillis_ht.AutoSize = true;
            this.lb_intervalMillis_ht.Location = new System.Drawing.Point(6, 183);
            this.lb_intervalMillis_ht.Name = "lb_intervalMillis_ht";
            this.lb_intervalMillis_ht.Size = new System.Drawing.Size(63, 13);
            this.lb_intervalMillis_ht.TabIndex = 13;
            this.lb_intervalMillis_ht.Text = "intervalMillis";
            // 
            // lb_turnMillis
            // 
            this.lb_turnMillis.AutoSize = true;
            this.lb_turnMillis.Location = new System.Drawing.Point(96, 111);
            this.lb_turnMillis.Name = "lb_turnMillis";
            this.lb_turnMillis.Size = new System.Drawing.Size(54, 13);
            this.lb_turnMillis.TabIndex = 12;
            this.lb_turnMillis.Text = "Turn Millis";
            // 
            // lb_turns
            // 
            this.lb_turns.AutoSize = true;
            this.lb_turns.Location = new System.Drawing.Point(96, 149);
            this.lb_turns.Name = "lb_turns";
            this.lb_turns.Size = new System.Drawing.Size(34, 13);
            this.lb_turns.TabIndex = 11;
            this.lb_turns.Text = "Turns";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 149);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Turns";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Turn Millis";
            // 
            // lb_matchTo
            // 
            this.lb_matchTo.AutoSize = true;
            this.lb_matchTo.Location = new System.Drawing.Point(96, 71);
            this.lb_matchTo.Name = "lb_matchTo";
            this.lb_matchTo.Size = new System.Drawing.Size(53, 13);
            this.lb_matchTo.TabIndex = 10;
            this.lb_matchTo.Text = "Match To";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Match To";
            // 
            // lb_idTeam
            // 
            this.lb_idTeam.AutoSize = true;
            this.lb_idTeam.Location = new System.Drawing.Point(96, 30);
            this.lb_idTeam.Name = "lb_idTeam";
            this.lb_idTeam.Size = new System.Drawing.Size(48, 13);
            this.lb_idTeam.TabIndex = 8;
            this.lb_idTeam.Text = "ID Team";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "ID Team";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(552, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 53);
            this.button1.TabIndex = 6;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(552, 478);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 48);
            this.button2.TabIndex = 6;
            this.button2.Text = "Submit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // autoRefreshTimer
            // 
            this.autoRefreshTimer.Interval = 1000;
            this.autoRefreshTimer.Tick += new System.EventHandler(this.autoRefreshTimer_Tick);
            // 
            // lblCountDown
            // 
            this.lblCountDown.AutoSize = true;
            this.lblCountDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountDown.ForeColor = System.Drawing.Color.Red;
            this.lblCountDown.Location = new System.Drawing.Point(194, 1);
            this.lblCountDown.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCountDown.Name = "lblCountDown";
            this.lblCountDown.Size = new System.Drawing.Size(162, 37);
            this.lblCountDown.TabIndex = 12;
            this.lblCountDown.Text = "Count Down";
            this.lblCountDown.UseCompatibleTextRendering = true;
            // 
            // frm_map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 560);
            this.Controls.Add(this.lblCountDown);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt_jsonSubmit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lb_titleID);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel_map);
            this.Name = "frm_map";
            this.Text = "Procon";
            this.Load += new System.EventHandler(this.frm_map_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_jsonSubmit;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lb_tilePointDich;
        private System.Windows.Forms.Label lb_areaPointDich;
        private System.Windows.Forms.Label lb_teamIDDich;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lb_tilePointTa;
        private System.Windows.Forms.Label lb_areaPointTa;
        private System.Windows.Forms.Label lb_teamIDTa;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_currentTurn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel_map;
        private System.Windows.Forms.Label lb_titleID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_intervalMillis;
        private System.Windows.Forms.Label lb_intervalMillis_ht;
        private System.Windows.Forms.Label lb_turnMillis;
        private System.Windows.Forms.Label lb_turns;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lb_matchTo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_idTeam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer autoRefreshTimer;
        private System.Windows.Forms.Label lblCountDown;
    }
}