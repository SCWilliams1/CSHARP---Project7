namespace Project7
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
            this.btnR = new System.Windows.Forms.Button();
            this.btnM = new System.Windows.Forms.Button();
            this.btnL = new System.Windows.Forms.Button();
            this.btnSpin = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbWin = new System.Windows.Forms.Label();
            this.lbResTitle = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.picSlotL = new System.Windows.Forms.PictureBox();
            this.picSlotM = new System.Windows.Forms.PictureBox();
            this.picSlotR = new System.Windows.Forms.PictureBox();
            this.gbResults = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbRT1 = new System.Windows.Forms.Label();
            this.lbRT2 = new System.Windows.Forms.Label();
            this.lbRT3 = new System.Windows.Forms.Label();
            this.ti1 = new System.Windows.Forms.Timer(this.components);
            this.ti2 = new System.Windows.Forms.Timer(this.components);
            this.ti3 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picSlotL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSlotM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSlotR)).BeginInit();
            this.gbResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnR
            // 
            this.btnR.Location = new System.Drawing.Point(858, 289);
            this.btnR.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(144, 53);
            this.btnR.TabIndex = 0;
            this.btnR.Text = "STOP!";
            this.btnR.UseVisualStyleBackColor = true;
            this.btnR.Click += new System.EventHandler(this.btnR_Click);
            // 
            // btnM
            // 
            this.btnM.Location = new System.Drawing.Point(583, 289);
            this.btnM.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnM.Name = "btnM";
            this.btnM.Size = new System.Drawing.Size(144, 53);
            this.btnM.TabIndex = 1;
            this.btnM.Text = "STOP!";
            this.btnM.UseVisualStyleBackColor = true;
            this.btnM.Click += new System.EventHandler(this.btnM_Click);
            // 
            // btnL
            // 
            this.btnL.Location = new System.Drawing.Point(321, 289);
            this.btnL.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(144, 53);
            this.btnL.TabIndex = 2;
            this.btnL.Text = "STOP!";
            this.btnL.UseVisualStyleBackColor = true;
            this.btnL.Click += new System.EventHandler(this.btnL_Click);
            // 
            // btnSpin
            // 
            this.btnSpin.Location = new System.Drawing.Point(35, 260);
            this.btnSpin.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSpin.Name = "btnSpin";
            this.btnSpin.Size = new System.Drawing.Size(199, 82);
            this.btnSpin.TabIndex = 3;
            this.btnSpin.Text = "SPIN TO WIN!";
            this.btnSpin.UseVisualStyleBackColor = true;
            this.btnSpin.Click += new System.EventHandler(this.btnSpin_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.Location = new System.Drawing.Point(218, 103);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(471, 35);
            this.txtOutput.TabIndex = 4;
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(58, 194);
            this.txtInput.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(176, 35);
            this.txtInput.TabIndex = 5;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 163);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "PLACE YOUR WAGER!";
            // 
            // lbWin
            // 
            this.lbWin.AutoSize = true;
            this.lbWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWin.Location = new System.Drawing.Point(211, 37);
            this.lbWin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbWin.Name = "lbWin";
            this.lbWin.Size = new System.Drawing.Size(81, 42);
            this.lbWin.TabIndex = 7;
            this.lbWin.Text = "nop";
            // 
            // lbResTitle
            // 
            this.lbResTitle.AutoSize = true;
            this.lbResTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResTitle.Location = new System.Drawing.Point(75, 110);
            this.lbResTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbResTitle.Name = "lbResTitle";
            this.lbResTitle.Size = new System.Drawing.Size(139, 24);
            this.lbResTitle.TabIndex = 8;
            this.lbResTitle.Text = "Your Winnings:";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(346, 24);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(370, 39);
            this.lbTitle.TabIndex = 9;
            this.lbTitle.Text = "Chance\'s Slot Machine";
            // 
            // picSlotL
            // 
            this.picSlotL.Image = ((System.Drawing.Image)(resources.GetObject("picSlotL.Image")));
            this.picSlotL.Location = new System.Drawing.Point(294, 84);
            this.picSlotL.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.picSlotL.Name = "picSlotL";
            this.picSlotL.Size = new System.Drawing.Size(199, 199);
            this.picSlotL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSlotL.TabIndex = 10;
            this.picSlotL.TabStop = false;
            // 
            // picSlotM
            // 
            this.picSlotM.Image = ((System.Drawing.Image)(resources.GetObject("picSlotM.Image")));
            this.picSlotM.Location = new System.Drawing.Point(556, 84);
            this.picSlotM.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.picSlotM.Name = "picSlotM";
            this.picSlotM.Size = new System.Drawing.Size(199, 199);
            this.picSlotM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSlotM.TabIndex = 11;
            this.picSlotM.TabStop = false;
            // 
            // picSlotR
            // 
            this.picSlotR.Image = ((System.Drawing.Image)(resources.GetObject("picSlotR.Image")));
            this.picSlotR.Location = new System.Drawing.Point(831, 84);
            this.picSlotR.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.picSlotR.Name = "picSlotR";
            this.picSlotR.Size = new System.Drawing.Size(199, 199);
            this.picSlotR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSlotR.TabIndex = 12;
            this.picSlotR.TabStop = false;
            // 
            // gbResults
            // 
            this.gbResults.Controls.Add(this.lbWin);
            this.gbResults.Controls.Add(this.txtOutput);
            this.gbResults.Controls.Add(this.lbResTitle);
            this.gbResults.Location = new System.Drawing.Point(294, 368);
            this.gbResults.Name = "gbResults";
            this.gbResults.Size = new System.Drawing.Size(736, 165);
            this.gbResults.TabIndex = 13;
            this.gbResults.TabStop = false;
            this.gbResults.Text = "Results";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 31);
            this.label2.TabIndex = 14;
            this.label2.Text = "$";
            // 
            // lbRT1
            // 
            this.lbRT1.Location = new System.Drawing.Point(350, 345);
            this.lbRT1.Name = "lbRT1";
            this.lbRT1.Size = new System.Drawing.Size(100, 23);
            this.lbRT1.TabIndex = 15;
            this.lbRT1.Text = "Test";
            this.lbRT1.Visible = false;
            // 
            // lbRT2
            // 
            this.lbRT2.Location = new System.Drawing.Point(602, 345);
            this.lbRT2.Name = "lbRT2";
            this.lbRT2.Size = new System.Drawing.Size(100, 23);
            this.lbRT2.TabIndex = 16;
            this.lbRT2.Text = "Test";
            this.lbRT2.Visible = false;
            // 
            // lbRT3
            // 
            this.lbRT3.Location = new System.Drawing.Point(884, 345);
            this.lbRT3.Name = "lbRT3";
            this.lbRT3.Size = new System.Drawing.Size(100, 23);
            this.lbRT3.TabIndex = 17;
            this.lbRT3.Text = "Test";
            this.lbRT3.Visible = false;
            // 
            // ti1
            // 
            this.ti1.Tick += new System.EventHandler(this.ti1_Tick_1);
            // 
            // ti2
            // 
            this.ti2.Tick += new System.EventHandler(this.ti2_Tick);
            // 
            // ti3
            // 
            this.ti3.Tick += new System.EventHandler(this.ti3_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1074, 546);
            this.Controls.Add(this.lbRT3);
            this.Controls.Add(this.lbRT2);
            this.Controls.Add(this.lbRT1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picSlotR);
            this.Controls.Add(this.picSlotM);
            this.Controls.Add(this.picSlotL);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnSpin);
            this.Controls.Add(this.btnL);
            this.Controls.Add(this.btnM);
            this.Controls.Add(this.btnR);
            this.Controls.Add(this.gbResults);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Chance\'s Slot Machine";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSlotL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSlotM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSlotR)).EndInit();
            this.gbResults.ResumeLayout(false);
            this.gbResults.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.Button btnM;
        private System.Windows.Forms.Button btnL;
        private System.Windows.Forms.Button btnSpin;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbWin;
        private System.Windows.Forms.Label lbResTitle;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.PictureBox picSlotL;
        private System.Windows.Forms.PictureBox picSlotM;
        private System.Windows.Forms.PictureBox picSlotR;
        private System.Windows.Forms.GroupBox gbResults;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbRT1;
        private System.Windows.Forms.Label lbRT2;
        private System.Windows.Forms.Label lbRT3;
        private System.Windows.Forms.Timer ti1;
        private System.Windows.Forms.Timer ti2;
        private System.Windows.Forms.Timer ti3;
    }
}

