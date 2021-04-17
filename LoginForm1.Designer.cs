namespace ExampleSQLApp
{
    partial class LoginForm1
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
            this.GreyPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.PassField = new System.Windows.Forms.TextBox();
            this.LoginField = new System.Windows.Forms.TextBox();
            this.BluePanel = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GreyPanel.SuspendLayout();
            this.BluePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // GreyPanel
            // 
            this.GreyPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GreyPanel.Controls.Add(this.label3);
            this.GreyPanel.Controls.Add(this.label2);
            this.GreyPanel.Controls.Add(this.button1);
            this.GreyPanel.Controls.Add(this.PassField);
            this.GreyPanel.Controls.Add(this.LoginField);
            this.GreyPanel.Controls.Add(this.BluePanel);
            this.GreyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GreyPanel.Location = new System.Drawing.Point(0, 0);
            this.GreyPanel.Name = "GreyPanel";
            this.GreyPanel.Size = new System.Drawing.Size(341, 474);
            this.GreyPanel.TabIndex = 0;
            this.GreyPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GreyPanel_MouseDown);
            this.GreyPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GreyPanel_MouseMove);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(27, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Логин";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(89, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 93);
            this.button1.TabIndex = 5;
            this.button1.Text = "Войти";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // PassField
            // 
            this.PassField.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassField.Location = new System.Drawing.Point(150, 232);
            this.PassField.Multiline = true;
            this.PassField.Name = "PassField";
            this.PassField.Size = new System.Drawing.Size(179, 50);
            this.PassField.TabIndex = 4;
            this.PassField.UseSystemPasswordChar = true;
            // 
            // LoginField
            // 
            this.LoginField.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginField.Location = new System.Drawing.Point(150, 176);
            this.LoginField.Multiline = true;
            this.LoginField.Name = "LoginField";
            this.LoginField.Size = new System.Drawing.Size(179, 50);
            this.LoginField.TabIndex = 2;
            // 
            // BluePanel
            // 
            this.BluePanel.BackColor = System.Drawing.SystemColors.Highlight;
            this.BluePanel.Controls.Add(this.CloseButton);
            this.BluePanel.Controls.Add(this.label1);
            this.BluePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BluePanel.Location = new System.Drawing.Point(0, 0);
            this.BluePanel.Name = "BluePanel";
            this.BluePanel.Size = new System.Drawing.Size(341, 100);
            this.BluePanel.TabIndex = 0;
            this.BluePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.BluePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BluePanel_MouseDown);
            this.BluePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BluePanel_MouseMove);
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Location = new System.Drawing.Point(315, 9);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(14, 13);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "X";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(45, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Авторизация";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // LoginForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 474);
            this.Controls.Add(this.GreyPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm1";
            this.Text = "LoginForm1";
            this.GreyPanel.ResumeLayout(false);
            this.GreyPanel.PerformLayout();
            this.BluePanel.ResumeLayout(false);
            this.BluePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel GreyPanel;
        private System.Windows.Forms.Panel BluePanel;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PassField;
        private System.Windows.Forms.TextBox LoginField;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}