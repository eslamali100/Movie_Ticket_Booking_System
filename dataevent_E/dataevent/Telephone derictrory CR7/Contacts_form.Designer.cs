namespace Final_project_in_Event
{
    partial class Contacts_form
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
            this.txt_Data = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.exit_Button = new ePOSOne.btnProduct.Button_WOC();
            this.updata_Button = new ePOSOne.btnProduct.Button_WOC();
            this.delete_Button = new ePOSOne.btnProduct.Button_WOC();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Category = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Data
            // 
            this.txt_Data.BackColor = System.Drawing.Color.Black;
            this.txt_Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Data.ForeColor = System.Drawing.Color.White;
            this.txt_Data.Location = new System.Drawing.Point(171, 109);
            this.txt_Data.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Data.Name = "txt_Data";
            this.txt_Data.Size = new System.Drawing.Size(199, 41);
            this.txt_Data.TabIndex = 22;
            this.txt_Data.TextChanged += new System.EventHandler(this.txt_DATA_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 174);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(734, 442);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 39);
            this.label1.TabIndex = 24;
            this.label1.Text = "Search";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(257, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 39);
            this.label2.TabIndex = 25;
            this.label2.Text = "PHONE BOOK";
            // 
            // exit_Button
            // 
            this.exit_Button.BorderColor = System.Drawing.Color.White;
            this.exit_Button.ButtonColor = System.Drawing.Color.Black;
            this.exit_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_Button.Location = new System.Drawing.Point(543, 664);
            this.exit_Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exit_Button.Name = "exit_Button";
            this.exit_Button.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.exit_Button.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.exit_Button.OnHoverTextColor = System.Drawing.Color.Gray;
            this.exit_Button.Size = new System.Drawing.Size(162, 66);
            this.exit_Button.TabIndex = 21;
            this.exit_Button.Text = "EXIT";
            this.exit_Button.TextColor = System.Drawing.Color.White;
            this.exit_Button.UseVisualStyleBackColor = true;
            this.exit_Button.Click += new System.EventHandler(this.exit_BUTTON_Click);
            // 
            // updata_Button
            // 
            this.updata_Button.BorderColor = System.Drawing.Color.White;
            this.updata_Button.ButtonColor = System.Drawing.Color.Black;
            this.updata_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updata_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updata_Button.Location = new System.Drawing.Point(301, 666);
            this.updata_Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.updata_Button.Name = "updata_Button";
            this.updata_Button.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.updata_Button.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.updata_Button.OnHoverTextColor = System.Drawing.Color.Gray;
            this.updata_Button.Size = new System.Drawing.Size(147, 66);
            this.updata_Button.TabIndex = 19;
            this.updata_Button.Text = "UPDATA";
            this.updata_Button.TextColor = System.Drawing.Color.White;
            this.updata_Button.UseVisualStyleBackColor = true;
            this.updata_Button.Click += new System.EventHandler(this.updata_BUTTON_Click);
            // 
            // delete_Button
            // 
            this.delete_Button.BorderColor = System.Drawing.Color.White;
            this.delete_Button.ButtonColor = System.Drawing.Color.Black;
            this.delete_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_Button.Location = new System.Drawing.Point(43, 666);
            this.delete_Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.delete_Button.Name = "delete_Button";
            this.delete_Button.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.delete_Button.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.delete_Button.OnHoverTextColor = System.Drawing.Color.Gray;
            this.delete_Button.Size = new System.Drawing.Size(162, 64);
            this.delete_Button.TabIndex = 18;
            this.delete_Button.Text = "DELETE";
            this.delete_Button.TextColor = System.Drawing.Color.White;
            this.delete_Button.UseVisualStyleBackColor = true;
            this.delete_Button.Click += new System.EventHandler(this.delete_BUTTON_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(441, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 34);
            this.label3.TabIndex = 27;
            this.label3.Text = "Caregory";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_Category
            // 
            this.txt_Category.BackColor = System.Drawing.Color.Black;
            this.txt_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Category.ForeColor = System.Drawing.Color.White;
            this.txt_Category.Location = new System.Drawing.Point(600, 113);
            this.txt_Category.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Category.Name = "txt_Category";
            this.txt_Category.Size = new System.Drawing.Size(119, 38);
            this.txt_Category.TabIndex = 26;
            this.txt_Category.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Contacts_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(771, 786);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Category);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_Data);
            this.Controls.Add(this.exit_Button);
            this.Controls.Add(this.updata_Button);
            this.Controls.Add(this.delete_Button);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Contacts_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Contacts_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ePOSOne.btnProduct.Button_WOC delete_Button;
        private ePOSOne.btnProduct.Button_WOC updata_Button;
        private ePOSOne.btnProduct.Button_WOC exit_Button;
        private System.Windows.Forms.TextBox txt_Data;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Category;
    }
}