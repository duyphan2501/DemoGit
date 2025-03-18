namespace DemoGit
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Chip1 = new Guna.UI2.WinForms.Guna2Chip();
            SuspendLayout();
            // 
            // guna2Chip1
            // 
            guna2Chip1.CustomizableEdges = customizableEdges1;
            guna2Chip1.Font = new Font("Segoe UI", 9.5F);
            guna2Chip1.ForeColor = Color.White;
            guna2Chip1.Location = new Point(451, 125);
            guna2Chip1.Name = "guna2Chip1";
            guna2Chip1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Chip1.Size = new Size(162, 50);
            guna2Chip1.TabIndex = 0;
            guna2Chip1.Text = "guna2Chip1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(guna2Chip1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Chip guna2Chip1;
    }
}
