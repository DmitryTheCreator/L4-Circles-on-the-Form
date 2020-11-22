namespace L4_Circles_on_the_Form
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelR = new System.Windows.Forms.Panel();
            this.panelB = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelR
            // 
            this.panelR.BackColor = System.Drawing.Color.Coral;
            this.panelR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelR.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelR.Location = new System.Drawing.Point(686, 0);
            this.panelR.Name = "panelR";
            this.panelR.Size = new System.Drawing.Size(236, 548);
            this.panelR.TabIndex = 0;
            // 
            // panelB
            // 
            this.panelB.BackColor = System.Drawing.Color.Salmon;
            this.panelB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelB.Location = new System.Drawing.Point(0, 448);
            this.panelB.Name = "panelB";
            this.panelB.Size = new System.Drawing.Size(686, 100);
            this.panelB.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 548);
            this.Controls.Add(this.panelB);
            this.Controls.Add(this.panelR);
            this.MaximumSize = new System.Drawing.Size(944, 604);
            this.MinimumSize = new System.Drawing.Size(944, 604);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "L4 Circles on the Form";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelR;
        private System.Windows.Forms.Panel panelB;
    }
}

