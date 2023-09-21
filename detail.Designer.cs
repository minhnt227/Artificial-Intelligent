namespace Graph_Coloring
{
    partial class detail
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
            this.txtNameD = new System.Windows.Forms.TextBox();
            this.txtcolorD = new System.Windows.Forms.TextBox();
            this.checkNeighbor = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNameD
            // 
            this.txtNameD.Location = new System.Drawing.Point(126, 40);
            this.txtNameD.Name = "txtNameD";
            this.txtNameD.Size = new System.Drawing.Size(160, 26);
            this.txtNameD.TabIndex = 0;
            // 
            // txtcolorD
            // 
            this.txtcolorD.Location = new System.Drawing.Point(126, 90);
            this.txtcolorD.Name = "txtcolorD";
            this.txtcolorD.Size = new System.Drawing.Size(160, 26);
            this.txtcolorD.TabIndex = 1;
            // 
            // checkNeighbor
            // 
            this.checkNeighbor.FormattingEnabled = true;
            this.checkNeighbor.Location = new System.Drawing.Point(126, 154);
            this.checkNeighbor.Name = "checkNeighbor";
            this.checkNeighbor.Size = new System.Drawing.Size(282, 142);
            this.checkNeighbor.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "color";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "neighbor";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(108, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 48);
            this.button1.TabIndex = 4;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 439);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkNeighbor);
            this.Controls.Add(this.txtcolorD);
            this.Controls.Add(this.txtNameD);
            this.Name = "detail";
            this.Text = "detail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNameD;
        private System.Windows.Forms.TextBox txtcolorD;
        private System.Windows.Forms.CheckedListBox checkNeighbor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}