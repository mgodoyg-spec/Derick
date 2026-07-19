namespace Derick
{
    partial class Form_invnt
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
            panel2 = new Panel();
            lbl_invt = new Label();
            panel3 = new Panel();
            lbl_tsct = new Label();
            panel4 = new Panel();
            lbl_psct = new Label();
            panel5 = new Panel();
            lbl1_stock = new Label();
            panel6 = new Panel();
            lbl_scrl = new Label();
            pnl_rgst = new FlowLayoutPanel();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lbl_invt);
            panel2.Location = new Point(12, 33);
            panel2.Name = "panel2";
            panel2.Size = new Size(225, 143);
            panel2.TabIndex = 2;
            // 
            // lbl_invt
            // 
            lbl_invt.Location = new Point(101, 16);
            lbl_invt.Name = "lbl_invt";
            lbl_invt.Size = new Size(108, 44);
            lbl_invt.TabIndex = 1;
            lbl_invt.Text = "Productos\r\nRegistrados";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(lbl_tsct);
            panel3.Location = new Point(243, 33);
            panel3.Name = "panel3";
            panel3.Size = new Size(225, 143);
            panel3.TabIndex = 3;
            // 
            // lbl_tsct
            // 
            lbl_tsct.Location = new Point(107, 6);
            lbl_tsct.Name = "lbl_tsct";
            lbl_tsct.Size = new Size(101, 68);
            lbl_tsct.TabIndex = 1;
            lbl_tsct.Text = "Stock\r\nTotal del inventario";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(lbl_psct);
            panel4.Location = new Point(474, 33);
            panel4.Name = "panel4";
            panel4.Size = new Size(225, 143);
            panel4.TabIndex = 4;
            // 
            // lbl_psct
            // 
            lbl_psct.Location = new Point(99, 6);
            lbl_psct.Name = "lbl_psct";
            lbl_psct.Size = new Size(108, 68);
            lbl_psct.TabIndex = 1;
            lbl_psct.Text = "Productos\r\nCon poco Stock";
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(lbl1_stock);
            panel5.Location = new Point(705, 33);
            panel5.Name = "panel5";
            panel5.Size = new Size(225, 143);
            panel5.TabIndex = 5;
            // 
            // lbl1_stock
            // 
            lbl1_stock.Location = new Point(95, 16);
            lbl1_stock.Name = "lbl1_stock";
            lbl1_stock.Size = new Size(108, 44);
            lbl1_stock.TabIndex = 1;
            lbl1_stock.Text = "Productos\r\nSin Stock";
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(lbl_scrl);
            panel6.Location = new Point(936, 33);
            panel6.Name = "panel6";
            panel6.Size = new Size(225, 143);
            panel6.TabIndex = 6;
            // 
            // lbl_scrl
            // 
            lbl_scrl.Location = new Point(100, 16);
            lbl_scrl.Name = "lbl_scrl";
            lbl_scrl.Size = new Size(108, 44);
            lbl_scrl.TabIndex = 1;
            lbl_scrl.Text = "Sucursales \r\nRegistradas";
            // 
            // pnl_rgst
            // 
            pnl_rgst.BorderStyle = BorderStyle.FixedSingle;
            pnl_rgst.Location = new Point(12, 237);
            pnl_rgst.Name = "pnl_rgst";
            pnl_rgst.Size = new Size(1176, 348);
            pnl_rgst.TabIndex = 7;
            // 
            // Form_invnt
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1200, 700);
            Controls.Add(panel2);
            Controls.Add(pnl_rgst);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Font = new Font("Modern No. 20", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form_invnt";
            Text = "Form_invnt";
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Label lbl_invt;
        private Panel panel3;
        private Label lbl_tsct;
        private Panel panel4;
        private Label lbl_psct;
        private Panel panel5;
        private Label lbl1_stock;
        private Panel panel6;
        private Label lbl_scrl;
        private FlowLayoutPanel pnl_rgst;
    }
}