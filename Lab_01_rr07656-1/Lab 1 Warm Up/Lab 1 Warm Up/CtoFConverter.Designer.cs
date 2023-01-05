namespace Lab_1_Warm_Up
{
    partial class CtoFConverter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtoFConverter));
            this.label1 = new System.Windows.Forms.Label();
            this.btnClickThis = new System.Windows.Forms.Button();
            this.textTempInC = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnClickThis
            // 
            resources.ApplyResources(this.btnClickThis, "btnClickThis");
            this.btnClickThis.Name = "btnClickThis";
            this.btnClickThis.UseVisualStyleBackColor = true;
            this.btnClickThis.Click += new System.EventHandler(this.btnClickThis_Click);
            // 
            // textTempInC
            // 
            resources.ApplyResources(this.textTempInC, "textTempInC");
            this.textTempInC.Name = "textTempInC";
            this.textTempInC.TextChanged += new System.EventHandler(this.textTempInC_TextChanged);
            // 
            // resultLabel
            // 
            resources.ApplyResources(this.resultLabel, "resultLabel");
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // CtoFConverter
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.textTempInC);
            this.Controls.Add(this.btnClickThis);
            this.Controls.Add(this.label1);
            this.Name = "CtoFConverter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClickThis;
        private System.Windows.Forms.TextBox textTempInC;
        private System.Windows.Forms.Label resultLabel;
    }
}

