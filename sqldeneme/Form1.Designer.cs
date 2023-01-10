namespace sqldeneme
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tboxad = new System.Windows.Forms.TextBox();
            this.tboxnum = new System.Windows.Forms.TextBox();
            this.tboxdate = new System.Windows.Forms.TextBox();
            this.register = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.tboxdelete = new System.Windows.Forms.TextBox();
            this.tboxuplan = new System.Windows.Forms.TextBox();
            this.tboxupdeger = new System.Windows.Forms.TextBox();
            this.tboxuptdeg = new System.Windows.Forms.TextBox();
            this.btnupd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-5, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(817, 200);
            this.dataGridView1.TabIndex = 0;
            // 
            // tboxad
            // 
            this.tboxad.Location = new System.Drawing.Point(28, 216);
            this.tboxad.Name = "tboxad";
            this.tboxad.Size = new System.Drawing.Size(125, 27);
            this.tboxad.TabIndex = 1;
            // 
            // tboxnum
            // 
            this.tboxnum.Location = new System.Drawing.Point(27, 262);
            this.tboxnum.Name = "tboxnum";
            this.tboxnum.Size = new System.Drawing.Size(125, 27);
            this.tboxnum.TabIndex = 2;
            // 
            // tboxdate
            // 
            this.tboxdate.Location = new System.Drawing.Point(27, 306);
            this.tboxdate.Name = "tboxdate";
            this.tboxdate.Size = new System.Drawing.Size(125, 27);
            this.tboxdate.TabIndex = 3;
            // 
            // register
            // 
            this.register.Location = new System.Drawing.Point(43, 357);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(94, 29);
            this.register.TabIndex = 4;
            this.register.Text = "register";
            this.register.UseVisualStyleBackColor = true;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(259, 306);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(94, 29);
            this.delete.TabIndex = 5;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // tboxdelete
            // 
            this.tboxdelete.Location = new System.Drawing.Point(244, 237);
            this.tboxdelete.Name = "tboxdelete";
            this.tboxdelete.Size = new System.Drawing.Size(125, 27);
            this.tboxdelete.TabIndex = 6;
            // 
            // tboxuplan
            // 
            this.tboxuplan.Location = new System.Drawing.Point(603, 251);
            this.tboxuplan.Name = "tboxuplan";
            this.tboxuplan.Size = new System.Drawing.Size(125, 27);
            this.tboxuplan.TabIndex = 7;
            // 
            // tboxupdeger
            // 
            this.tboxupdeger.Location = new System.Drawing.Point(603, 284);
            this.tboxupdeger.Name = "tboxupdeger";
            this.tboxupdeger.Size = new System.Drawing.Size(125, 27);
            this.tboxupdeger.TabIndex = 8;
            // 
            // tboxuptdeg
            // 
            this.tboxuptdeg.Location = new System.Drawing.Point(603, 317);
            this.tboxuptdeg.Name = "tboxuptdeg";
            this.tboxuptdeg.Size = new System.Drawing.Size(125, 27);
            this.tboxuptdeg.TabIndex = 9;
            // 
            // btnupd
            // 
            this.btnupd.Location = new System.Drawing.Point(618, 357);
            this.btnupd.Name = "btnupd";
            this.btnupd.Size = new System.Drawing.Size(94, 29);
            this.btnupd.TabIndex = 10;
            this.btnupd.Text = "update";
            this.btnupd.UseVisualStyleBackColor = true;
            this.btnupd.Click += new System.EventHandler(this.btnupd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnupd);
            this.Controls.Add(this.tboxuptdeg);
            this.Controls.Add(this.tboxupdeger);
            this.Controls.Add(this.tboxuplan);
            this.Controls.Add(this.tboxdelete);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.register);
            this.Controls.Add(this.tboxdate);
            this.Controls.Add(this.tboxnum);
            this.Controls.Add(this.tboxad);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox tboxad;
        private TextBox tboxnum;
        private TextBox tboxdate;
        private Button register;
        private Button delete;
        private TextBox tboxdelete;
        private TextBox tboxuplan;
        private TextBox tboxupdeger;
        private TextBox tboxuptdeg;
        private Button btnupd;
    }
}