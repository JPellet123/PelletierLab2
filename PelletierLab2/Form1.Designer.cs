namespace PelletierLab2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gbxMult = new System.Windows.Forms.GroupBox();
            this.btnRes = new System.Windows.Forms.Button();
            this.btnCal = new System.Windows.Forms.Button();
            this.lblAns2 = new System.Windows.Forms.Label();
            this.lblMult = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblRes = new System.Windows.Forms.Label();
            this.txtMul = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.gbxInfo = new System.Windows.Forms.GroupBox();
            this.btnExi = new System.Windows.Forms.Button();
            this.btnHid = new System.Windows.Forms.Button();
            this.btnDat = new System.Windows.Forms.Button();
            this.btnPic = new System.Windows.Forms.Button();
            this.lblRel = new System.Windows.Forms.Label();
            this.lblDat = new System.Windows.Forms.Label();
            this.picRel = new System.Windows.Forms.PictureBox();
            this.gbxMult.SuspendLayout();
            this.gbxInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRel)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxMult
            // 
            this.gbxMult.Controls.Add(this.btnRes);
            this.gbxMult.Controls.Add(this.btnCal);
            this.gbxMult.Controls.Add(this.lblAns2);
            this.gbxMult.Controls.Add(this.lblMult);
            this.gbxMult.Controls.Add(this.lblNumber);
            this.gbxMult.Controls.Add(this.lblRes);
            this.gbxMult.Controls.Add(this.txtMul);
            this.gbxMult.Controls.Add(this.txtNum);
            this.gbxMult.Location = new System.Drawing.Point(12, 12);
            this.gbxMult.Name = "gbxMult";
            this.gbxMult.Size = new System.Drawing.Size(287, 328);
            this.gbxMult.TabIndex = 0;
            this.gbxMult.TabStop = false;
            this.gbxMult.Text = "Multiplier";
            // 
            // btnRes
            // 
            this.btnRes.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRes.Location = new System.Drawing.Point(164, 274);
            this.btnRes.Name = "btnRes";
            this.btnRes.Size = new System.Drawing.Size(75, 33);
            this.btnRes.TabIndex = 3;
            this.btnRes.Text = "&Reset";
            this.btnRes.UseVisualStyleBackColor = true;
            this.btnRes.Click += new System.EventHandler(this.btnRes_Click);
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(42, 274);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(75, 33);
            this.btnCal.TabIndex = 2;
            this.btnCal.Text = "&Calculate";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // lblAns2
            // 
            this.lblAns2.AutoSize = true;
            this.lblAns2.Location = new System.Drawing.Point(39, 201);
            this.lblAns2.Name = "lblAns2";
            this.lblAns2.Size = new System.Drawing.Size(46, 16);
            this.lblAns2.TabIndex = 5;
            this.lblAns2.Text = "Answer:";
            // 
            // lblMult
            // 
            this.lblMult.AutoSize = true;
            this.lblMult.Location = new System.Drawing.Point(39, 125);
            this.lblMult.Name = "lblMult";
            this.lblMult.Size = new System.Drawing.Size(51, 16);
            this.lblMult.TabIndex = 4;
            this.lblMult.Text = "Multiplier:";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(42, 45);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(48, 16);
            this.lblNumber.TabIndex = 3;
            this.lblNumber.Text = "Number:";
            // 
            // lblRes
            // 
            this.lblRes.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblRes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRes.Location = new System.Drawing.Point(139, 201);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(100, 25);
            this.lblRes.TabIndex = 2;
            this.lblRes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMul
            // 
            this.txtMul.Location = new System.Drawing.Point(139, 122);
            this.txtMul.Name = "txtMul";
            this.txtMul.Size = new System.Drawing.Size(100, 22);
            this.txtMul.TabIndex = 1;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(139, 39);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 22);
            this.txtNum.TabIndex = 0;
            // 
            // gbxInfo
            // 
            this.gbxInfo.Controls.Add(this.btnExi);
            this.gbxInfo.Controls.Add(this.btnHid);
            this.gbxInfo.Controls.Add(this.btnDat);
            this.gbxInfo.Controls.Add(this.btnPic);
            this.gbxInfo.Controls.Add(this.lblRel);
            this.gbxInfo.Controls.Add(this.picRel);
            this.gbxInfo.Controls.Add(this.lblDat);
            this.gbxInfo.Location = new System.Drawing.Point(305, 12);
            this.gbxInfo.Name = "gbxInfo";
            this.gbxInfo.Size = new System.Drawing.Size(483, 328);
            this.gbxInfo.TabIndex = 1;
            this.gbxInfo.TabStop = false;
            this.gbxInfo.Text = "Information";
            // 
            // btnExi
            // 
            this.btnExi.Location = new System.Drawing.Point(313, 274);
            this.btnExi.Name = "btnExi";
            this.btnExi.Size = new System.Drawing.Size(75, 33);
            this.btnExi.TabIndex = 3;
            this.btnExi.Text = "&Exit";
            this.btnExi.UseVisualStyleBackColor = true;
            this.btnExi.Click += new System.EventHandler(this.btnExi_Click);
            // 
            // btnHid
            // 
            this.btnHid.Location = new System.Drawing.Point(213, 274);
            this.btnHid.Name = "btnHid";
            this.btnHid.Size = new System.Drawing.Size(75, 33);
            this.btnHid.TabIndex = 2;
            this.btnHid.Text = "&Hide";
            this.btnHid.UseVisualStyleBackColor = true;
            this.btnHid.Click += new System.EventHandler(this.btnHid_Click);
            // 
            // btnDat
            // 
            this.btnDat.Location = new System.Drawing.Point(117, 274);
            this.btnDat.Name = "btnDat";
            this.btnDat.Size = new System.Drawing.Size(75, 33);
            this.btnDat.TabIndex = 1;
            this.btnDat.Text = "&Data";
            this.btnDat.UseVisualStyleBackColor = true;
            this.btnDat.Click += new System.EventHandler(this.btnDat_Click);
            // 
            // btnPic
            // 
            this.btnPic.Location = new System.Drawing.Point(24, 274);
            this.btnPic.Name = "btnPic";
            this.btnPic.Size = new System.Drawing.Size(75, 33);
            this.btnPic.TabIndex = 0;
            this.btnPic.Text = "&Picture";
            this.btnPic.UseVisualStyleBackColor = true;
            this.btnPic.Click += new System.EventHandler(this.btnPic_Click);
            // 
            // lblRel
            // 
            this.lblRel.AutoSize = true;
            this.lblRel.Location = new System.Drawing.Point(172, 18);
            this.lblRel.Name = "lblRel";
            this.lblRel.Size = new System.Drawing.Size(30, 16);
            this.lblRel.TabIndex = 0;
            this.lblRel.Text = "Relic";
            // 
            // lblDat
            // 
            this.lblDat.Location = new System.Drawing.Point(24, 39);
            this.lblDat.Name = "lblDat";
            this.lblDat.Size = new System.Drawing.Size(378, 227);
            this.lblDat.TabIndex = 6;
            this.lblDat.Text = "label2";
            this.lblDat.Visible = false;
            // 
            // picRel
            // 
            this.picRel.Image = ((System.Drawing.Image)(resources.GetObject("picRel.Image")));
            this.picRel.Location = new System.Drawing.Point(24, 37);
            this.picRel.Name = "picRel";
            this.picRel.Size = new System.Drawing.Size(378, 229);
            this.picRel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRel.TabIndex = 5;
            this.picRel.TabStop = false;
            this.picRel.Visible = false;
            this.picRel.Click += new System.EventHandler(this.picRel_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnPic;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnRes;
            this.ClientSize = new System.Drawing.Size(719, 331);
            this.Controls.Add(this.gbxInfo);
            this.Controls.Add(this.gbxMult);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab 2 By Jared Pelletier";
            this.gbxMult.ResumeLayout(false);
            this.gbxMult.PerformLayout();
            this.gbxInfo.ResumeLayout(false);
            this.gbxInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxMult;
        private System.Windows.Forms.GroupBox gbxInfo;
        private System.Windows.Forms.Button btnRes;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Label lblAns2;
        private System.Windows.Forms.Label lblMult;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.TextBox txtMul;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.PictureBox picRel;
        private System.Windows.Forms.Button btnExi;
        private System.Windows.Forms.Button btnHid;
        private System.Windows.Forms.Button btnDat;
        private System.Windows.Forms.Button btnPic;
        private System.Windows.Forms.Label lblRel;
        private System.Windows.Forms.Label lblDat;
    }
}

