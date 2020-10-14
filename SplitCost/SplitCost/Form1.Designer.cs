namespace SplitCost
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTaxFree = new System.Windows.Forms.TextBox();
            this.txtPerson = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblonePerson = new System.Windows.Forms.Label();
            this.lblSplit = new System.Windows.Forms.Label();
            this.btnclc = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "税抜金額";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(385, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "人数";
            // 
            // txtTaxFree
            // 
            this.txtTaxFree.Location = new System.Drawing.Point(61, 99);
            this.txtTaxFree.Name = "txtTaxFree";
            this.txtTaxFree.Size = new System.Drawing.Size(112, 19);
            this.txtTaxFree.TabIndex = 2;
            // 
            // txtPerson
            // 
            this.txtPerson.Location = new System.Drawing.Point(387, 99);
            this.txtPerson.Name = "txtPerson";
            this.txtPerson.Size = new System.Drawing.Size(112, 19);
            this.txtPerson.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "一人あたり";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(385, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "余り";
            // 
            // lblonePerson
            // 
            this.lblonePerson.AutoSize = true;
            this.lblonePerson.Location = new System.Drawing.Point(59, 196);
            this.lblonePerson.Name = "lblonePerson";
            this.lblonePerson.Size = new System.Drawing.Size(23, 12);
            this.lblonePerson.TabIndex = 6;
            this.lblonePerson.Text = "0円";
            // 
            // lblSplit
            // 
            this.lblSplit.AutoSize = true;
            this.lblSplit.Location = new System.Drawing.Point(385, 196);
            this.lblSplit.Name = "lblSplit";
            this.lblSplit.Size = new System.Drawing.Size(23, 12);
            this.lblSplit.TabIndex = 7;
            this.lblSplit.Text = "0円";
            // 
            // btnclc
            // 
            this.btnclc.Location = new System.Drawing.Point(61, 251);
            this.btnclc.Name = "btnclc";
            this.btnclc.Size = new System.Drawing.Size(479, 37);
            this.btnclc.TabIndex = 8;
            this.btnclc.Text = "計算する";
            this.btnclc.UseVisualStyleBackColor = true;
            this.btnclc.Click += new System.EventHandler(this.btnclc_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(179, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 9;
            this.label7.Text = "円";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(505, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 12);
            this.label8.TabIndex = 10;
            this.label8.Text = "人";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnclc);
            this.Controls.Add(this.lblSplit);
            this.Controls.Add(this.lblonePerson);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPerson);
            this.Controls.Add(this.txtTaxFree);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTaxFree;
        private System.Windows.Forms.TextBox txtPerson;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblonePerson;
        private System.Windows.Forms.Label lblSplit;
        private System.Windows.Forms.Button btnclc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

