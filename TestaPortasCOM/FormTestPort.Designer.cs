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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRefreshPort = new System.Windows.Forms.Button();
            this.buttonTestPort = new System.Windows.Forms.Button();
            this.comboBoxPortas = new System.Windows.Forms.ComboBox();
            this.listViewDadosCOM = new System.Windows.Forms.ListView();
            this.serialPortCOM = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
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
            this.buttonRefreshPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefreshPort.Location = new System.Drawing.Point(12, 92);
            this.buttonRefreshPort.Name = "buttonRefreshPort";
            this.buttonRefreshPort.Size = new System.Drawing.Size(98, 34);
            this.buttonRefreshPort.TabIndex = 2;
            this.buttonRefreshPort.Text = "Atualizar";
            this.buttonRefreshPort.UseVisualStyleBackColor = true;
            this.buttonRefreshPort.Click += new System.EventHandler(this.buttonRefreshPort_Click);
            // 
            // buttonTestPort
            // 
            this.buttonTestPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTestPort.Location = new System.Drawing.Point(111, 92);
            this.buttonTestPort.Name = "buttonTestPort";
            this.buttonTestPort.Size = new System.Drawing.Size(98, 34);
            this.buttonTestPort.TabIndex = 3;
            this.buttonTestPort.Text = "Testar";
            this.buttonTestPort.UseVisualStyleBackColor = true;
            this.buttonTestPort.Click += new System.EventHandler(this.buttonTestPort_Click);
            // 
            // comboBoxPortas
            // 
            this.comboBoxPortas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPortas.FormattingEnabled = true;
            this.comboBoxPortas.Location = new System.Drawing.Point(12, 58);
            this.comboBoxPortas.Name = "comboBoxPortas";
            this.comboBoxPortas.Size = new System.Drawing.Size(197, 28);
            this.comboBoxPortas.TabIndex = 4;
            // 
            // listViewDadosCOM
            // 
            this.listViewDadosCOM.HideSelection = false;
            this.listViewDadosCOM.Location = new System.Drawing.Point(16, 152);
            this.listViewDadosCOM.Name = "listViewDadosCOM";
            this.listViewDadosCOM.Size = new System.Drawing.Size(193, 267);
            this.listViewDadosCOM.TabIndex = 5;
            this.listViewDadosCOM.UseCompatibleStateImageBehavior = false;
            // 
            // FormTestPort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 431);
            this.Controls.Add(this.listViewDadosCOM);
            this.Controls.Add(this.comboBoxPortas);
            this.Controls.Add(this.buttonTestPort);
            this.Controls.Add(this.buttonRefreshPort);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTestPort";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TestCOM";
            this.Load += new System.EventHandler(this.FormTestPort_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRefreshPort;
        private System.Windows.Forms.Button buttonTestPort;
        private System.Windows.Forms.ComboBox comboBoxPortas;
        private System.IO.Ports.SerialPort serialPortCOM;
        public System.Windows.Forms.ListView listViewDadosCOM;
    }
}

