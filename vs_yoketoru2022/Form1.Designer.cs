
namespace vs_yoketoru2022
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.timeL = new System.Windows.Forms.Label();
            this.scoreL = new System.Windows.Forms.Label();
            this.titieBt = new System.Windows.Forms.Button();
            this.crL = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.overBt = new System.Windows.Forms.Button();
            this.overL = new System.Windows.Forms.Label();
            this.titieLb = new System.Windows.Forms.Label();
            this.clearL = new System.Windows.Forms.Label();
            this.overLb = new System.Windows.Forms.Label();
            this.tempL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timeL
            // 
            this.timeL.AutoSize = true;
            this.timeL.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timeL.Location = new System.Drawing.Point(662, 9);
            this.timeL.Name = "timeL";
            this.timeL.Size = new System.Drawing.Size(54, 28);
            this.timeL.TabIndex = 2;
            this.timeL.Text = "Time";
            // 
            // scoreL
            // 
            this.scoreL.AutoSize = true;
            this.scoreL.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scoreL.Location = new System.Drawing.Point(12, 9);
            this.scoreL.Name = "scoreL";
            this.scoreL.Size = new System.Drawing.Size(58, 28);
            this.scoreL.TabIndex = 3;
            this.scoreL.Text = "score";
            // 
            // titieBt
            // 
            this.titieBt.Font = new System.Drawing.Font("Yu Gothic UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titieBt.Location = new System.Drawing.Point(369, 293);
            this.titieBt.Name = "titieBt";
            this.titieBt.Size = new System.Drawing.Size(66, 41);
            this.titieBt.TabIndex = 4;
            this.titieBt.Text = "start";
            this.titieBt.UseVisualStyleBackColor = true;
            this.titieBt.Click += new System.EventHandler(this.titleBt_Click);
            // 
            // crL
            // 
            this.crL.AutoSize = true;
            this.crL.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.crL.Location = new System.Drawing.Point(273, 413);
            this.crL.Name = "crL";
            this.crL.Size = new System.Drawing.Size(259, 28);
            this.crL.TabIndex = 5;
            this.crL.Text = "copyright©2022　○○○○";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // overBt
            // 
            this.overBt.Font = new System.Drawing.Font("Yu Gothic UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.overBt.Location = new System.Drawing.Point(369, 293);
            this.overBt.Name = "overBt";
            this.overBt.Size = new System.Drawing.Size(66, 41);
            this.overBt.TabIndex = 6;
            this.overBt.Text = "title";
            this.overBt.UseVisualStyleBackColor = true;
            // 
            // overL
            // 
            this.overL.AutoSize = true;
            this.overL.Font = new System.Drawing.Font("Yu Gothic UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.overL.Location = new System.Drawing.Point(355, 203);
            this.overL.Name = "overL";
            this.overL.Size = new System.Drawing.Size(0, 37);
            this.overL.TabIndex = 8;
            // 
            // titieLb
            // 
            this.titieLb.AutoSize = true;
            this.titieLb.Font = new System.Drawing.Font("Yu Gothic UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titieLb.Location = new System.Drawing.Point(284, 121);
            this.titieLb.Name = "titieLb";
            this.titieLb.Size = new System.Drawing.Size(226, 46);
            this.titieLb.TabIndex = 9;
            this.titieLb.Text = "Yoketoru2022";
            // 
            // clearL
            // 
            this.clearL.AutoSize = true;
            this.clearL.Font = new System.Drawing.Font("Yu Gothic UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clearL.Location = new System.Drawing.Point(355, 220);
            this.clearL.Name = "clearL";
            this.clearL.Size = new System.Drawing.Size(94, 37);
            this.clearL.TabIndex = 10;
            this.clearL.Text = "CLEAR";
            // 
            // overLb
            // 
            this.overLb.AutoSize = true;
            this.overLb.Font = new System.Drawing.Font("Yu Gothic UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.overLb.Location = new System.Drawing.Point(326, 220);
            this.overLb.Name = "overLb";
            this.overLb.Size = new System.Drawing.Size(158, 37);
            this.overLb.TabIndex = 11;
            this.overLb.Text = "GAMEOVER";
            // 
            // tempL
            // 
            this.tempL.AutoSize = true;
            this.tempL.Location = new System.Drawing.Point(89, 183);
            this.tempL.Name = "tempL";
            this.tempL.Size = new System.Drawing.Size(38, 15);
            this.tempL.TabIndex = 12;
            this.tempL.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tempL);
            this.Controls.Add(this.overLb);
            this.Controls.Add(this.clearL);
            this.Controls.Add(this.titieLb);
            this.Controls.Add(this.overL);
            this.Controls.Add(this.overBt);
            this.Controls.Add(this.crL);
            this.Controls.Add(this.titieBt);
            this.Controls.Add(this.scoreL);
            this.Controls.Add(this.timeL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label timeL;
        private System.Windows.Forms.Label scoreL;
        private System.Windows.Forms.Button titieBt;
        private System.Windows.Forms.Label crL;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button overBt;
        private System.Windows.Forms.Label overL;
        private System.Windows.Forms.Label titieLb;
        private System.Windows.Forms.Label clearL;
        private System.Windows.Forms.Label overLb;
        private System.Windows.Forms.Label tempL;
    }
}

