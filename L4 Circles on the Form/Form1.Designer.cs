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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.lblBlue = new System.Windows.Forms.Label();
            this.lblPink = new System.Windows.Forms.Label();
            this.lblRed = new System.Windows.Forms.Label();
            this.lblOrange = new System.Windows.Forms.Label();
            this.lblBlueText = new System.Windows.Forms.Label();
            this.lblPinkText = new System.Windows.Forms.Label();
            this.lblOrangeText = new System.Windows.Forms.Label();
            this.lblRedText = new System.Windows.Forms.Label();
            this.panelR.SuspendLayout();
            this.panelB.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelR
            // 
            this.panelR.BackColor = System.Drawing.Color.Coral;
            this.panelR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelR.Controls.Add(this.btnShow);
            this.panelR.Controls.Add(this.btnClear);
            this.panelR.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelR.Location = new System.Drawing.Point(686, 0);
            this.panelR.Name = "panelR";
            this.panelR.Size = new System.Drawing.Size(236, 548);
            this.panelR.TabIndex = 0;
            // 
            // panelB
            // 
            this.panelB.BackColor = System.Drawing.Color.Bisque;
            this.panelB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelB.Controls.Add(this.lblRedText);
            this.panelB.Controls.Add(this.lblOrangeText);
            this.panelB.Controls.Add(this.lblPinkText);
            this.panelB.Controls.Add(this.lblBlueText);
            this.panelB.Controls.Add(this.lblOrange);
            this.panelB.Controls.Add(this.lblRed);
            this.panelB.Controls.Add(this.lblPink);
            this.panelB.Controls.Add(this.lblBlue);
            this.panelB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelB.Location = new System.Drawing.Point(0, 448);
            this.panelB.Name = "panelB";
            this.panelB.Size = new System.Drawing.Size(686, 100);
            this.panelB.TabIndex = 1;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.SandyBrown;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnClear.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClear.Location = new System.Drawing.Point(3, 86);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(228, 122);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Очистить экран";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.SandyBrown;
            this.btnShow.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnShow.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShow.ForeColor = System.Drawing.SystemColors.Control;
            this.btnShow.Location = new System.Drawing.Point(3, 214);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(228, 122);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "Отобразить объекты из хранилища";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.BackColor = System.Drawing.Color.Bisque;
            this.lblBlue.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBlue.ForeColor = System.Drawing.Color.Blue;
            this.lblBlue.Location = new System.Drawing.Point(11, 11);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(78, 29);
            this.lblBlue.TabIndex = 0;
            this.lblBlue.Text = "Синий";
            // 
            // lblPink
            // 
            this.lblPink.AutoSize = true;
            this.lblPink.BackColor = System.Drawing.Color.Bisque;
            this.lblPink.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPink.ForeColor = System.Drawing.Color.DeepPink;
            this.lblPink.Location = new System.Drawing.Point(11, 55);
            this.lblPink.Name = "lblPink";
            this.lblPink.Size = new System.Drawing.Size(104, 29);
            this.lblPink.TabIndex = 1;
            this.lblPink.Text = "Розовый";
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.BackColor = System.Drawing.Color.Bisque;
            this.lblRed.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRed.ForeColor = System.Drawing.Color.Red;
            this.lblRed.Location = new System.Drawing.Point(290, 11);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(105, 29);
            this.lblRed.TabIndex = 2;
            this.lblRed.Text = "Красный";
            // 
            // lblOrange
            // 
            this.lblOrange.AutoSize = true;
            this.lblOrange.BackColor = System.Drawing.Color.Bisque;
            this.lblOrange.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOrange.ForeColor = System.Drawing.Color.Orange;
            this.lblOrange.Location = new System.Drawing.Point(290, 55);
            this.lblOrange.Name = "lblOrange";
            this.lblOrange.Size = new System.Drawing.Size(139, 29);
            this.lblOrange.TabIndex = 3;
            this.lblOrange.Text = "Оранжевый";
            // 
            // lblBlueText
            // 
            this.lblBlueText.AutoSize = true;
            this.lblBlueText.BackColor = System.Drawing.Color.Bisque;
            this.lblBlueText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBlueText.ForeColor = System.Drawing.Color.Black;
            this.lblBlueText.Location = new System.Drawing.Point(85, 11);
            this.lblBlueText.Name = "lblBlueText";
            this.lblBlueText.Size = new System.Drawing.Size(114, 29);
            this.lblBlueText.TabIndex = 4;
            this.lblBlueText.Text = "- текущий";
            // 
            // lblPinkText
            // 
            this.lblPinkText.AutoSize = true;
            this.lblPinkText.BackColor = System.Drawing.Color.Bisque;
            this.lblPinkText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPinkText.ForeColor = System.Drawing.Color.Black;
            this.lblPinkText.Location = new System.Drawing.Point(111, 55);
            this.lblPinkText.Name = "lblPinkText";
            this.lblPinkText.Size = new System.Drawing.Size(161, 29);
            this.lblPinkText.TabIndex = 5;
            this.lblPinkText.Text = "- выделенный";
            // 
            // lblOrangeText
            // 
            this.lblOrangeText.AutoSize = true;
            this.lblOrangeText.BackColor = System.Drawing.Color.Bisque;
            this.lblOrangeText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOrangeText.ForeColor = System.Drawing.Color.Black;
            this.lblOrangeText.Location = new System.Drawing.Point(424, 55);
            this.lblOrangeText.Name = "lblOrangeText";
            this.lblOrangeText.Size = new System.Drawing.Size(255, 29);
            this.lblOrangeText.TabIndex = 6;
            this.lblOrangeText.Text = "- текущий выделенный";
            // 
            // lblRedText
            // 
            this.lblRedText.AutoSize = true;
            this.lblRedText.BackColor = System.Drawing.Color.Bisque;
            this.lblRedText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRedText.ForeColor = System.Drawing.Color.Black;
            this.lblRedText.Location = new System.Drawing.Point(386, 11);
            this.lblRedText.Name = "lblRedText";
            this.lblRedText.Size = new System.Drawing.Size(123, 29);
            this.lblRedText.TabIndex = 7;
            this.lblRedText.Text = "- обычный";
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
            this.panelR.ResumeLayout(false);
            this.panelB.ResumeLayout(false);
            this.panelB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelR;
        private System.Windows.Forms.Panel panelB;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.Label lblPinkText;
        private System.Windows.Forms.Label lblBlueText;
        private System.Windows.Forms.Label lblOrange;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label lblPink;
        private System.Windows.Forms.Label lblOrangeText;
        private System.Windows.Forms.Label lblRedText;
    }
}

