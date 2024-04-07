namespace eulerproblem
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.list_problem = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_solution = new System.Windows.Forms.TextBox();
            this.btn_solve = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_status = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.txt_problem = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // list_problem
            // 
            this.list_problem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.list_problem.BackColor = System.Drawing.Color.Black;
            this.list_problem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.list_problem.ForeColor = System.Drawing.Color.White;
            this.list_problem.FormattingEnabled = true;
            this.list_problem.ItemHeight = 31;
            this.list_problem.Items.AddRange(new object[] {
            "Problem 1",
            "Problem 2",
            "Problem 3",
            "Problem 4",
            "Problem 5",
            "Problem 6",
            "Problem 7",
            "Problem 8",
            "Problem 9",
            "Problem 10",
            "Problem 11",
            "Problem 12",
            "Problem 13",
            "Problem 14",
            "Problem 16",
            "Problem 17",
            "Problem 18",
            "Problem 19",
            "Problem 20",
            "Problem 21",
            "Problem 22",
            "Problem 23",
            "Problem 24",
            "Problem 25",
            "Problem 26",
            "Problem 27",
            "Problem 28",
            "Problem 29",
            "Problem 30",
            "Problem 31"});
            this.list_problem.Location = new System.Drawing.Point(12, 75);
            this.list_problem.MinimumSize = new System.Drawing.Size(4, 50);
            this.list_problem.Name = "list_problem";
            this.list_problem.Size = new System.Drawing.Size(186, 655);
            this.list_problem.TabIndex = 1;
            this.list_problem.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Problem:";
            // 
            // txt_solution
            // 
            this.txt_solution.BackColor = System.Drawing.Color.Black;
            this.txt_solution.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txt_solution.ForeColor = System.Drawing.Color.White;
            this.txt_solution.Location = new System.Drawing.Point(209, 788);
            this.txt_solution.Name = "txt_solution";
            this.txt_solution.Size = new System.Drawing.Size(817, 36);
            this.txt_solution.TabIndex = 4;
            // 
            // btn_solve
            // 
            this.btn_solve.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_solve.BackColor = System.Drawing.Color.Black;
            this.btn_solve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btn_solve.ForeColor = System.Drawing.Color.Lime;
            this.btn_solve.Location = new System.Drawing.Point(912, 852);
            this.btn_solve.Name = "btn_solve";
            this.btn_solve.Size = new System.Drawing.Size(114, 40);
            this.btn_solve.TabIndex = 6;
            this.btn_solve.Text = "Solve";
            this.btn_solve.UseVisualStyleBackColor = false;
            this.btn_solve.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(204, 760);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Solution:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_status
            // 
            this.txt_status.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_status.BackColor = System.Drawing.Color.Black;
            this.txt_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txt_status.ForeColor = System.Drawing.Color.White;
            this.txt_status.Location = new System.Drawing.Point(1032, 788);
            this.txt_status.Name = "txt_status";
            this.txt_status.ReadOnly = true;
            this.txt_status.Size = new System.Drawing.Size(842, 36);
            this.txt_status.TabIndex = 9;
            this.txt_status.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1032, 756);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 27);
            this.label2.TabIndex = 7;
            this.label2.Text = "Status:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_clear.BackColor = System.Drawing.Color.Black;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btn_clear.ForeColor = System.Drawing.Color.Yellow;
            this.btn_clear.Location = new System.Drawing.Point(1032, 852);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(114, 40);
            this.btn_clear.TabIndex = 10;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // txt_problem
            // 
            this.txt_problem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_problem.BackColor = System.Drawing.Color.Black;
            this.txt_problem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txt_problem.ForeColor = System.Drawing.Color.Lime;
            this.txt_problem.Location = new System.Drawing.Point(209, 28);
            this.txt_problem.Name = "txt_problem";
            this.txt_problem.ReadOnly = true;
            this.txt_problem.Size = new System.Drawing.Size(1665, 693);
            this.txt_problem.TabIndex = 11;
            this.txt_problem.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1924, 940);
            this.Controls.Add(this.txt_problem);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_solve);
            this.Controls.Add(this.txt_status);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.list_problem);
            this.Controls.Add(this.txt_solution);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "Form1";
            this.Text = "Problem";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox list_problem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_solution;
        private System.Windows.Forms.Button btn_solve;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txt_status;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.RichTextBox txt_problem;
    }
}

