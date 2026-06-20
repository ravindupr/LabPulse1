namespace LabPulse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            menuStrip1 = new MenuStrip();
            aboutUsToolStripMenuItem = new ToolStripMenuItem();
            categoryToolStripMenuItem = new ToolStripMenuItem();
            chemistryToolStripMenuItem = new ToolStripMenuItem();
            physicsToolStripMenuItem = new ToolStripMenuItem();
            biologyToolStripMenuItem = new ToolStripMenuItem();
            mapToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(26, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(209, 118);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(241, 75);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(272, 90);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { aboutUsToolStripMenuItem, categoryToolStripMenuItem, mapToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1150, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // aboutUsToolStripMenuItem
            // 
            aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            aboutUsToolStripMenuItem.Size = new Size(84, 24);
            aboutUsToolStripMenuItem.Text = "About Us";
            // 
            // categoryToolStripMenuItem
            // 
            categoryToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { chemistryToolStripMenuItem, physicsToolStripMenuItem, biologyToolStripMenuItem });
            categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            categoryToolStripMenuItem.Size = new Size(83, 24);
            categoryToolStripMenuItem.Text = "Category";
            // 
            // chemistryToolStripMenuItem
            // 
            chemistryToolStripMenuItem.Name = "chemistryToolStripMenuItem";
            chemistryToolStripMenuItem.Size = new Size(157, 26);
            chemistryToolStripMenuItem.Text = "Chemistry";
            // 
            // physicsToolStripMenuItem
            // 
            physicsToolStripMenuItem.Name = "physicsToolStripMenuItem";
            physicsToolStripMenuItem.Size = new Size(157, 26);
            physicsToolStripMenuItem.Text = "Physics";
            // 
            // biologyToolStripMenuItem
            // 
            biologyToolStripMenuItem.Name = "biologyToolStripMenuItem";
            biologyToolStripMenuItem.Size = new Size(157, 26);
            biologyToolStripMenuItem.Text = "Biology";
            // 
            // mapToolStripMenuItem
            // 
            mapToolStripMenuItem.Name = "mapToolStripMenuItem";
            mapToolStripMenuItem.Size = new Size(53, 24);
            mapToolStripMenuItem.Text = "Map";
            // 
            // button1
            // 
            button1.Location = new Point(975, 75);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(975, 147);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 4;
            button2.Text = "Register";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1150, 643);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem aboutUsToolStripMenuItem;
        private ToolStripMenuItem categoryToolStripMenuItem;
        private ToolStripMenuItem chemistryToolStripMenuItem;
        private ToolStripMenuItem physicsToolStripMenuItem;
        private ToolStripMenuItem biologyToolStripMenuItem;
        private ToolStripMenuItem mapToolStripMenuItem;
        private Button button1;
        private Button button2;
    }
}
