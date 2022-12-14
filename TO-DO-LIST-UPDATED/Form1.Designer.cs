using System.IO;
namespace TO_DO_LIST_UPDATED
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ADD = new System.Windows.Forms.Button();
            this.VIEW = new System.Windows.Forms.Button();
            this.Load = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.combo_Name = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(468, 171);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(330, 42);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ADD
            // 
            this.ADD.Location = new System.Drawing.Point(45, 24);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(134, 51);
            this.ADD.TabIndex = 3;
            this.ADD.Text = "Add";
            this.ADD.UseVisualStyleBackColor = true;
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // VIEW
            // 
            this.VIEW.Location = new System.Drawing.Point(45, 171);
            this.VIEW.Name = "VIEW";
            this.VIEW.Size = new System.Drawing.Size(134, 22);
            this.VIEW.TabIndex = 4;
            this.VIEW.Text = "View";
            this.VIEW.UseVisualStyleBackColor = true;
            this.VIEW.Click += new System.EventHandler(this.VIEW_Click);
            // 
            // Load
            // 
            this.Load.Location = new System.Drawing.Point(45, 292);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(134, 23);
            this.Load.TabIndex = 5;
            this.Load.Text = "Load";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(45, 397);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(134, 23);
            this.Save.TabIndex = 6;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // combo_Name
            // 
            this.combo_Name.FormattingEnabled = true;
            this.combo_Name.Location = new System.Drawing.Point(468, 24);
            this.combo_Name.Name = "combo_Name";
            this.combo_Name.Size = new System.Drawing.Size(330, 23);
            this.combo_Name.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.combo_Name);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.VIEW);
            this.Controls.Add(this.ADD);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button ADD;
        private System.Windows.Forms.Button VIEW;
        public System.Windows.Forms.Button Load;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.ComboBox combo_Name;
    }
}
