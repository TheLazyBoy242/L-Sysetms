namespace LSystems
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
            this.test_out_lbl = new System.Windows.Forms.Label();
            this.Run_btn = new System.Windows.Forms.Button();
            this.Clear_btn = new System.Windows.Forms.Button();
            this.posang_txtb = new System.Windows.Forms.TextBox();
            this.posang_lbl = new System.Windows.Forms.Label();
            this.negang_lbl = new System.Windows.Forms.Label();
            this.negang_txtb = new System.Windows.Forms.TextBox();
            this.depth_lbl = new System.Windows.Forms.Label();
            this.Depth_bar = new System.Windows.Forms.TrackBar();
            this.Lenght_lbl = new System.Windows.Forms.Label();
            this.Length_txtb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Depth_bar)).BeginInit();
            this.SuspendLayout();
            // 
            // test_out_lbl
            // 
            this.test_out_lbl.AutoSize = true;
            this.test_out_lbl.Location = new System.Drawing.Point(290, 14);
            this.test_out_lbl.Name = "test_out_lbl";
            this.test_out_lbl.Size = new System.Drawing.Size(0, 13);
            this.test_out_lbl.TabIndex = 0;
            // 
            // Run_btn
            // 
            this.Run_btn.Location = new System.Drawing.Point(12, 14);
            this.Run_btn.Name = "Run_btn";
            this.Run_btn.Size = new System.Drawing.Size(75, 23);
            this.Run_btn.TabIndex = 1;
            this.Run_btn.Text = "Run";
            this.Run_btn.UseVisualStyleBackColor = true;
            this.Run_btn.Click += new System.EventHandler(this.Run_btn_Click);
            // 
            // Clear_btn
            // 
            this.Clear_btn.Location = new System.Drawing.Point(12, 43);
            this.Clear_btn.Name = "Clear_btn";
            this.Clear_btn.Size = new System.Drawing.Size(75, 23);
            this.Clear_btn.TabIndex = 2;
            this.Clear_btn.Text = "Clear";
            this.Clear_btn.UseVisualStyleBackColor = true;
            this.Clear_btn.Click += new System.EventHandler(this.Clear_btn_Click);
            // 
            // posang_txtb
            // 
            this.posang_txtb.Location = new System.Drawing.Point(12, 89);
            this.posang_txtb.Name = "posang_txtb";
            this.posang_txtb.Size = new System.Drawing.Size(75, 20);
            this.posang_txtb.TabIndex = 3;
            this.posang_txtb.TextChanged += new System.EventHandler(this.posang_txtb_TextChanged);
            // 
            // posang_lbl
            // 
            this.posang_lbl.AutoSize = true;
            this.posang_lbl.Location = new System.Drawing.Point(6, 73);
            this.posang_lbl.Name = "posang_lbl";
            this.posang_lbl.Size = new System.Drawing.Size(81, 13);
            this.posang_lbl.TabIndex = 4;
            this.posang_lbl.Text = "Posetive Angle:";
            // 
            // negang_lbl
            // 
            this.negang_lbl.AutoSize = true;
            this.negang_lbl.Location = new System.Drawing.Point(4, 112);
            this.negang_lbl.Name = "negang_lbl";
            this.negang_lbl.Size = new System.Drawing.Size(83, 13);
            this.negang_lbl.TabIndex = 5;
            this.negang_lbl.Text = "Negative Angle:";
            // 
            // negang_txtb
            // 
            this.negang_txtb.Location = new System.Drawing.Point(12, 128);
            this.negang_txtb.Name = "negang_txtb";
            this.negang_txtb.Size = new System.Drawing.Size(75, 20);
            this.negang_txtb.TabIndex = 6;
            this.negang_txtb.TextChanged += new System.EventHandler(this.negang_txtb_TextChanged);
            // 
            // depth_lbl
            // 
            this.depth_lbl.AutoSize = true;
            this.depth_lbl.Location = new System.Drawing.Point(33, 151);
            this.depth_lbl.Name = "depth_lbl";
            this.depth_lbl.Size = new System.Drawing.Size(54, 13);
            this.depth_lbl.TabIndex = 7;
            this.depth_lbl.Text = "Depth = 6";
            // 
            // Depth_bar
            // 
            this.Depth_bar.Location = new System.Drawing.Point(7, 167);
            this.Depth_bar.Minimum = 1;
            this.Depth_bar.Name = "Depth_bar";
            this.Depth_bar.Size = new System.Drawing.Size(80, 45);
            this.Depth_bar.TabIndex = 8;
            this.Depth_bar.Value = 6;
            this.Depth_bar.Scroll += new System.EventHandler(this.Depth_bar_Scroll);
            // 
            // Lenght_lbl
            // 
            this.Lenght_lbl.AutoSize = true;
            this.Lenght_lbl.Location = new System.Drawing.Point(40, 199);
            this.Lenght_lbl.Name = "Lenght_lbl";
            this.Lenght_lbl.Size = new System.Drawing.Size(43, 13);
            this.Lenght_lbl.TabIndex = 9;
            this.Lenght_lbl.Text = "Length:";
            // 
            // Length_txtb
            // 
            this.Length_txtb.Location = new System.Drawing.Point(12, 218);
            this.Length_txtb.Name = "Length_txtb";
            this.Length_txtb.Size = new System.Drawing.Size(75, 20);
            this.Length_txtb.TabIndex = 10;
            this.Length_txtb.Text = "5";
            this.Length_txtb.TextChanged += new System.EventHandler(this.Length_txtb_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 447);
            this.Controls.Add(this.Length_txtb);
            this.Controls.Add(this.Lenght_lbl);
            this.Controls.Add(this.Depth_bar);
            this.Controls.Add(this.depth_lbl);
            this.Controls.Add(this.negang_txtb);
            this.Controls.Add(this.negang_lbl);
            this.Controls.Add(this.posang_lbl);
            this.Controls.Add(this.posang_txtb);
            this.Controls.Add(this.Clear_btn);
            this.Controls.Add(this.Run_btn);
            this.Controls.Add(this.test_out_lbl);
            this.Name = "Form1";
            this.Text = "L System Tree";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Depth_bar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label test_out_lbl;
        private System.Windows.Forms.Button Run_btn;
        private System.Windows.Forms.Button Clear_btn;
        private System.Windows.Forms.TextBox posang_txtb;
        private System.Windows.Forms.Label posang_lbl;
        private System.Windows.Forms.Label negang_lbl;
        private System.Windows.Forms.TextBox negang_txtb;
        private System.Windows.Forms.Label depth_lbl;
        private System.Windows.Forms.TrackBar Depth_bar;
        private System.Windows.Forms.Label Lenght_lbl;
        private System.Windows.Forms.TextBox Length_txtb;
    }
}

