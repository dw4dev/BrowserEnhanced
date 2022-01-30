namespace BrowserEnhanced
{
    partial class fMain
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnREG = new System.Windows.Forms.Button();
            this.btnUnreg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnREG
            // 
            this.btnREG.BackColor = System.Drawing.Color.Green;
            this.btnREG.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnREG.ForeColor = System.Drawing.Color.Yellow;
            this.btnREG.Location = new System.Drawing.Point(15, 53);
            this.btnREG.Name = "btnREG";
            this.btnREG.Size = new System.Drawing.Size(206, 54);
            this.btnREG.TabIndex = 0;
            this.btnREG.Text = "瀏覽器特性註冊";
            this.btnREG.UseVisualStyleBackColor = false;
            this.btnREG.Click += new System.EventHandler(this.btnREG_Click);
            // 
            // btnUnreg
            // 
            this.btnUnreg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnUnreg.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnUnreg.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnUnreg.Location = new System.Drawing.Point(239, 53);
            this.btnUnreg.Name = "btnUnreg";
            this.btnUnreg.Size = new System.Drawing.Size(206, 54);
            this.btnUnreg.TabIndex = 1;
            this.btnUnreg.Text = "取消註冊(清除)";
            this.btnUnreg.UseVisualStyleBackColor = false;
            this.btnUnreg.Click += new System.EventHandler(this.btnUnreg_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 119);
            this.Controls.Add(this.btnUnreg);
            this.Controls.Add(this.btnREG);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".Net Web Browser Emulation Feature Enhanced";
            this.Load += new System.EventHandler(this.fMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnREG;
        private System.Windows.Forms.Button btnUnreg;
    }
}

