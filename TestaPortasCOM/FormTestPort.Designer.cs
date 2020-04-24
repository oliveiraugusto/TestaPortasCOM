namespace TestaPortasCOM
{
    partial class FormTestPort
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
            this.listViewComPorts = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRefreshPort = new System.Windows.Forms.Button();
            this.buttonTestPort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewComPorts
            // 
            this.listViewComPorts.HideSelection = false;
            this.listViewComPorts.Location = new System.Drawing.Point(16, 46);
            this.listViewComPorts.Name = "listViewComPorts";
            this.listViewComPorts.Size = new System.Drawing.Size(197, 250);
            this.listViewComPorts.TabIndex = 0;
            this.listViewComPorts.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Relação de Portas COM";
            // 
            // buttonRefreshPort
            // 
            this.buttonRefreshPort.Location = new System.Drawing.Point(16, 312);
            this.buttonRefreshPort.Name = "buttonRefreshPort";
            this.buttonRefreshPort.Size = new System.Drawing.Size(90, 23);
            this.buttonRefreshPort.TabIndex = 2;
            this.buttonRefreshPort.Text = "Atualizar";
            this.buttonRefreshPort.UseVisualStyleBackColor = true;
            this.buttonRefreshPort.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonTestPort
            // 
            this.buttonTestPort.Location = new System.Drawing.Point(112, 312);
            this.buttonTestPort.Name = "buttonTestPort";
            this.buttonTestPort.Size = new System.Drawing.Size(101, 23);
            this.buttonTestPort.TabIndex = 3;
            this.buttonTestPort.Text = "Testar Porta";
            this.buttonTestPort.UseVisualStyleBackColor = true;
            this.buttonTestPort.Click += new System.EventHandler(this.buttonTestPort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 347);
            this.Controls.Add(this.buttonTestPort);
            this.Controls.Add(this.buttonRefreshPort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewComPorts);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TestCOM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewComPorts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRefreshPort;
        private System.Windows.Forms.Button buttonTestPort;
    }
}

