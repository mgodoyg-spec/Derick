namespace Derick
{
    partial class InicioGerente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioGerente));
            lblSalir = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblSalir
            // 
            lblSalir.AutoSize = true;
            lblSalir.Cursor = Cursors.Hand;
            lblSalir.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSalir.ForeColor = Color.Red;
            lblSalir.Location = new Point(1163, 9);
            lblSalir.Name = "lblSalir";
            lblSalir.Size = new Size(25, 24);
            lblSalir.TabIndex = 6;
            lblSalir.Text = "X";
            lblSalir.Click += lblSalir_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 10);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // InicioGerente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1200, 641);
            Controls.Add(button1);
            Controls.Add(lblSalir);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "InicioGerente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InicioGerente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSalir;
        private Button button1;
    }
}