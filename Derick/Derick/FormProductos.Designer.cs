namespace Derick
{
    partial class FormProductos
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
            boton_producto1 = new Button();
            boton_producto2 = new Button();
            SuspendLayout();
            // 
            // boton_producto1
            // 
            boton_producto1.Location = new Point(12, 12);
            boton_producto1.Name = "boton_producto1";
            boton_producto1.Size = new Size(94, 29);
            boton_producto1.TabIndex = 0;
            boton_producto1.Text = "button1";
            boton_producto1.UseVisualStyleBackColor = true;
            // 
            // boton_producto2
            // 
            boton_producto2.Location = new Point(1076, 12);
            boton_producto2.Name = "boton_producto2";
            boton_producto2.Size = new Size(94, 29);
            boton_producto2.TabIndex = 1;
            boton_producto2.Text = "button2";
            boton_producto2.UseVisualStyleBackColor = true;
            // 
            // FormProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1182, 653);
            Controls.Add(boton_producto2);
            Controls.Add(boton_producto1);
            Name = "FormProductos";
            Text = "FormProductos";
            ResumeLayout(false);
        }

        #endregion

        private Button boton_producto1;
        private Button boton_producto2;
    }
}