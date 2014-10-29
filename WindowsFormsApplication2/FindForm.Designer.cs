namespace WindowsFormsApplication2
{
    partial class FindForm
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
            this.txtFind = new System.Windows.Forms.TextBox();
            this.MatchCase = new System.Windows.Forms.CheckBox();
            this.MatchWhole = new System.Windows.Forms.CheckBox();
            this.OK = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(21, 12);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(188, 20);
            this.txtFind.TabIndex = 0;
            // 
            // MatchCase
            // 
            this.MatchCase.AutoSize = true;
            this.MatchCase.Location = new System.Drawing.Point(22, 42);
            this.MatchCase.Name = "MatchCase";
            this.MatchCase.Size = new System.Drawing.Size(153, 17);
            this.MatchCase.TabIndex = 2;
            this.MatchCase.Text = "Найти с учётом регистра";
            this.MatchCase.UseVisualStyleBackColor = true;
            // 
            // MatchWhole
            // 
            this.MatchWhole.AutoSize = true;
            this.MatchWhole.Location = new System.Drawing.Point(21, 65);
            this.MatchWhole.Name = "MatchWhole";
            this.MatchWhole.Size = new System.Drawing.Size(104, 17);
            this.MatchWhole.TabIndex = 3;
            this.MatchWhole.Text = "Слово целиком";
            this.MatchWhole.UseVisualStyleBackColor = true;
            // 
            // OK
            // 
            this.OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK.Location = new System.Drawing.Point(227, 14);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(72, 30);
            this.OK.TabIndex = 1;
            this.OK.Text = "ОК";
            this.OK.UseVisualStyleBackColor = true;
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(227, 50);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(71, 30);
            this.Cancel.TabIndex = 4;
            this.Cancel.Text = "Выход";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // FindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(322, 91);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.MatchWhole);
            this.Controls.Add(this.MatchCase);
            this.Controls.Add(this.txtFind);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FindForm";
            this.Text = "Поиск";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.CheckBox MatchCase;
        private System.Windows.Forms.CheckBox MatchWhole;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Cancel;
    }
}