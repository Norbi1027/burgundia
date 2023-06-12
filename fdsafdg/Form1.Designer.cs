namespace fdsafdg
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
            this.lbl = new System.Windows.Forms.Label();
            this.számolj = new System.Windows.Forms.Button();
            this.kilép = new System.Windows.Forms.Button();
            this.nud1 = new System.Windows.Forms.NumericUpDown();
            this.nud2 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl.Location = new System.Drawing.Point(0, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(800, 72);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "hello";
            // 
            // számolj
            // 
            this.számolj.Location = new System.Drawing.Point(152, 167);
            this.számolj.Name = "számolj";
            this.számolj.Size = new System.Drawing.Size(75, 23);
            this.számolj.TabIndex = 1;
            this.számolj.Text = "számolj";
            this.számolj.UseVisualStyleBackColor = true;
            this.számolj.Click += new System.EventHandler(this.számolj_Click);
            // 
            // kilép
            // 
            this.kilép.Location = new System.Drawing.Point(490, 167);
            this.kilép.Name = "kilép";
            this.kilép.Size = new System.Drawing.Size(75, 23);
            this.kilép.TabIndex = 2;
            this.kilép.Text = "kilép";
            this.kilép.UseVisualStyleBackColor = true;
            this.kilép.Click += new System.EventHandler(this.kilép_Click);
            // 
            // nud1
            // 
            this.nud1.Location = new System.Drawing.Point(152, 113);
            this.nud1.Name = "nud1";
            this.nud1.Size = new System.Drawing.Size(120, 23);
            this.nud1.TabIndex = 3;
            // 
            // nud2
            // 
            this.nud2.Location = new System.Drawing.Point(445, 113);
            this.nud2.Name = "nud2";
            this.nud2.Size = new System.Drawing.Size(120, 23);
            this.nud2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(450, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "osztó";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(155, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "szorzó";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nud2);
            this.Controls.Add(this.nud1);
            this.Controls.Add(this.kilép);
            this.Controls.Add(this.számolj);
            this.Controls.Add(this.lbl);
            this.Name = "Form1";
            this.Text = "első program";
            ((System.ComponentModel.ISupportInitialize)(this.nud1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl;
        private Button számolj;
        private Button kilép;
        private NumericUpDown nud1;
        private NumericUpDown nud2;
        private Label label2;
        private Label label1;
    }
}