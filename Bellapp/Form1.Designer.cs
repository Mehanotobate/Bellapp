namespace Bellapp
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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Scheduelename = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.Insert = new System.Windows.Forms.Button();
            this.Ring1 = new System.Windows.Forms.Button();
            this.EvacuationRing = new System.Windows.Forms.Button();
            this.Chooseport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonabout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Scheduelename
            // 
            this.Scheduelename.AutoSize = true;
            this.Scheduelename.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scheduelename.Location = new System.Drawing.Point(21, 56);
            this.Scheduelename.Name = "Scheduelename";
            this.Scheduelename.Size = new System.Drawing.Size(121, 29);
            this.Scheduelename.TabIndex = 0;
            this.Scheduelename.Text = "Scheduel:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(85, 104);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(128, 228);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(257, 104);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(142, 228);
            this.listBox2.TabIndex = 2;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 16;
            this.listBox3.Location = new System.Drawing.Point(440, 104);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(147, 228);
            this.listBox3.TabIndex = 3;
            this.listBox3.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(625, 104);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(145, 47);
            this.Insert.TabIndex = 4;
            this.Insert.Text = "Insert Scheduel";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // Ring1
            // 
            this.Ring1.Location = new System.Drawing.Point(200, 361);
            this.Ring1.Name = "Ring1";
            this.Ring1.Size = new System.Drawing.Size(145, 48);
            this.Ring1.TabIndex = 5;
            this.Ring1.Text = "Ring for 1 sec";
            this.Ring1.UseVisualStyleBackColor = true;
            this.Ring1.Click += new System.EventHandler(this.Ring1_Click);
            // 
            // EvacuationRing
            // 
            this.EvacuationRing.Location = new System.Drawing.Point(389, 361);
            this.EvacuationRing.Name = "EvacuationRing";
            this.EvacuationRing.Size = new System.Drawing.Size(145, 48);
            this.EvacuationRing.TabIndex = 8;
            this.EvacuationRing.Text = "Evacuation Ring";
            this.EvacuationRing.UseVisualStyleBackColor = true;
            this.EvacuationRing.Click += new System.EventHandler(this.EvacuationRing_Click);
            // 
            // Chooseport
            // 
            this.Chooseport.Location = new System.Drawing.Point(625, 285);
            this.Chooseport.Name = "Chooseport";
            this.Chooseport.Size = new System.Drawing.Size(145, 47);
            this.Chooseport.TabIndex = 9;
            this.Chooseport.Text = "Choose port";
            this.Chooseport.UseVisualStyleBackColor = true;
            this.Chooseport.Click += new System.EventHandler(this.Chooseport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Teacher`s bell:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Student`s bell:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(437, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Dismiss bell:";
            // 
            // buttonabout
            // 
            this.buttonabout.Location = new System.Drawing.Point(1, -2);
            this.buttonabout.Name = "buttonabout";
            this.buttonabout.Size = new System.Drawing.Size(103, 32);
            this.buttonabout.TabIndex = 13;
            this.buttonabout.Text = "About";
            this.buttonabout.UseVisualStyleBackColor = true;
            this.buttonabout.Click += new System.EventHandler(this.buttonabout_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonabout);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Chooseport);
            this.Controls.Add(this.EvacuationRing);
            this.Controls.Add(this.Ring1);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Scheduelename);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Bellprogram";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Scheduelename;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Button Ring1;
        private System.Windows.Forms.Button EvacuationRing;
        private System.Windows.Forms.Button Chooseport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonabout;
    }
}

