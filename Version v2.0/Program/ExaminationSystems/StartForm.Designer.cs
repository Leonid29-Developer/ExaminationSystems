namespace ExaminationSystems
{
    partial class StartForm
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
            this.Create_Button = new System.Windows.Forms.Label();
            this.Enter_Button = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Create_Button
            // 
            this.Create_Button.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Create_Button.Location = new System.Drawing.Point(38, 27);
            this.Create_Button.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Create_Button.Name = "Create_Button";
            this.Create_Button.Size = new System.Drawing.Size(316, 49);
            this.Create_Button.TabIndex = 0;
            this.Create_Button.Text = "Создать заявку на экспертизу";
            this.Create_Button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Create_Button.Click += new System.EventHandler(this.Create_Button_Click);
            // 
            // Enter_Button
            // 
            this.Enter_Button.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Enter_Button.Location = new System.Drawing.Point(38, 101);
            this.Enter_Button.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Enter_Button.Name = "Enter_Button";
            this.Enter_Button.Size = new System.Drawing.Size(316, 49);
            this.Enter_Button.TabIndex = 1;
            this.Enter_Button.Text = "Авторизоваться, как сотрудник";
            this.Enter_Button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Enter_Button.Click += new System.EventHandler(this.Enter_Button_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 183);
            this.Controls.Add(this.Enter_Button);
            this.Controls.Add(this.Create_Button);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "StartForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Create_Button;
        private System.Windows.Forms.Label Enter_Button;
    }
}