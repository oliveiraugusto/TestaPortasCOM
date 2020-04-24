namespace TestaPortasCOM
{
    partial class FormReceiveData
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
            this.listViewDataCOM = new System.Windows.Forms.ListView();
            this.labelTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewDataCOM
            // 
            this.listViewDataCOM.HideSelection = false;
            this.listViewDataCOM.Location = new System.Drawing.Point(12, 49);
            this.listViewDataCOM.Name = "listViewDataCOM";
            this.listViewDataCOM.Size = new System.Drawing.Size(296, 459);
            this.listViewDataCOM.TabIndex = 0;
            this.listViewDataCOM.UseCompatibleStateImageBehavior = false;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(12, 16);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(0, 20);
            this.labelTitle.TabIndex = 1;
            // 
            // FormReceiveData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 520);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.listViewDataCOM);
            this.MaximizeBox = false;
            this.Name = "FormReceiveData";
            this.Text = "Recebendo dados...";
            this.Load += new System.EventHandler(this.FormReceiveData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewDataCOM;
        private System.Windows.Forms.Label labelTitle;
    }
}