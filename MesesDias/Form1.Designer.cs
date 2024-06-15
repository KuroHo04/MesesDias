namespace MesesDias
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
            FrmMesesdias = new Button();
            SuspendLayout();
            // 
            // FrmMesesdias
            // 
            FrmMesesdias.Location = new Point(315, 173);
            FrmMesesdias.Name = "FrmMesesdias";
            FrmMesesdias.Size = new Size(126, 29);
            FrmMesesdias.TabIndex = 0;
            FrmMesesdias.Text = "meses de año";
            FrmMesesdias.UseVisualStyleBackColor = true;
            FrmMesesdias.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(FrmMesesdias);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button FrmMesesdias;
    }
}
