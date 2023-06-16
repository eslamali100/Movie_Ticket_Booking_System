namespace Final_project_in_Event
{
    partial class SAVE_FORM
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Yes = new ePOSOne.btnProduct.Button_WOC();
            this.button_No = new ePOSOne.btnProduct.Button_WOC();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(43, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "If you are sure that you want to save ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(52, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "the data, click YES, if not click NO";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button_Yes
            // 
            this.button_Yes.BorderColor = System.Drawing.Color.White;
            this.button_Yes.ButtonColor = System.Drawing.Color.Black;
            this.button_Yes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Yes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Yes.Location = new System.Drawing.Point(217, 83);
            this.button_Yes.Margin = new System.Windows.Forms.Padding(4);
            this.button_Yes.Name = "button_Yes";
            this.button_Yes.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.button_Yes.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.button_Yes.OnHoverTextColor = System.Drawing.Color.Gray;
            this.button_Yes.Size = new System.Drawing.Size(88, 39);
            this.button_Yes.TabIndex = 2;
            this.button_Yes.Text = "YES";
            this.button_Yes.TextColor = System.Drawing.Color.White;
            this.button_Yes.UseVisualStyleBackColor = true;
            this.button_Yes.Click += new System.EventHandler(this.button_YES_Click);
            // 
            // button_No
            // 
            this.button_No.BorderColor = System.Drawing.Color.White;
            this.button_No.ButtonColor = System.Drawing.Color.Black;
            this.button_No.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_No.Location = new System.Drawing.Point(95, 83);
            this.button_No.Margin = new System.Windows.Forms.Padding(4);
            this.button_No.Name = "button_No";
            this.button_No.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.button_No.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.button_No.OnHoverTextColor = System.Drawing.Color.Gray;
            this.button_No.Size = new System.Drawing.Size(88, 39);
            this.button_No.TabIndex = 3;
            this.button_No.Text = "NO";
            this.button_No.TextColor = System.Drawing.Color.White;
            this.button_No.UseVisualStyleBackColor = true;
            this.button_No.Click += new System.EventHandler(this.button_NO_Click);
            // 
            // SAVE_FORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(408, 135);
            this.ControlBox = false;
            this.Controls.Add(this.button_No);
            this.Controls.Add(this.button_Yes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SAVE_FORM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.SAVE_FORM_Load);
            this.Resize += new System.EventHandler(this.SAVE_FORM_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ePOSOne.btnProduct.Button_WOC button_Yes;
        private ePOSOne.btnProduct.Button_WOC button_No;
    }
}