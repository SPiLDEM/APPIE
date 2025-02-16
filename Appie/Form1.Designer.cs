namespace Appie
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            TRANSFER = new Label();
            pictureBox1 = new PictureBox();
            FileLocationPanel = new Panel();
            fltrans = new Button();
            FileLocation = new PictureBox();
            label2 = new Label();
            flnwloc = new TextBox();
            label1 = new Label();
            flsrc = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            Header = new Panel();
            Minimize = new PictureBox();
            Close = new PictureBox();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            FileLocationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FileLocation).BeginInit();
            Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Minimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Close).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // TRANSFER
            // 
            TRANSFER.AutoSize = true;
            TRANSFER.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TRANSFER.ForeColor = SystemColors.Control;
            TRANSFER.Location = new Point(450, 570);
            TRANSFER.Name = "TRANSFER";
            TRANSFER.Size = new Size(248, 22);
            TRANSFER.TabIndex = 0;
            TRANSFER.Text = "←START TRANSFERING→";
            TRANSFER.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.BAPPIE_Logo;
            pictureBox1.Location = new Point(254, 114);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(676, 542);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // FileLocationPanel
            // 
            FileLocationPanel.Controls.Add(fltrans);
            FileLocationPanel.Controls.Add(FileLocation);
            FileLocationPanel.Controls.Add(label2);
            FileLocationPanel.Controls.Add(flnwloc);
            FileLocationPanel.Controls.Add(label1);
            FileLocationPanel.Controls.Add(flsrc);
            FileLocationPanel.Location = new Point(0, 165);
            FileLocationPanel.Name = "FileLocationPanel";
            FileLocationPanel.Size = new Size(80, 554);
            FileLocationPanel.TabIndex = 2;
            // 
            // fltrans
            // 
            fltrans.Location = new Point(808, 306);
            fltrans.Name = "fltrans";
            fltrans.Size = new Size(75, 23);
            fltrans.TabIndex = 5;
            fltrans.Text = "Transfer";
            fltrans.UseVisualStyleBackColor = true;
            fltrans.Click += fltrans_Click;
            // 
            // FileLocation
            // 
            FileLocation.Dock = DockStyle.Right;
            FileLocation.Image = Properties.Resources.FILE_LOV_TEXT;
            FileLocation.Location = new Point(9, 0);
            FileLocation.Name = "FileLocation";
            FileLocation.Size = new Size(71, 554);
            FileLocation.TabIndex = 0;
            FileLocation.TabStop = false;
            FileLocation.Click += FileLocation_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(315, 240);
            label2.Name = "label2";
            label2.Size = new Size(135, 22);
            label2.TabIndex = 4;
            label2.Text = "New Location";
            // 
            // flnwloc
            // 
            flnwloc.Location = new Point(315, 265);
            flnwloc.Name = "flnwloc";
            flnwloc.Size = new Size(568, 23);
            flnwloc.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(315, 177);
            label1.Name = "label1";
            label1.Size = new Size(163, 22);
            label1.TabIndex = 2;
            label1.Text = "Source Location";
            // 
            // flsrc
            // 
            flsrc.Location = new Point(315, 202);
            flsrc.Name = "flsrc";
            flsrc.Size = new Size(568, 23);
            flsrc.TabIndex = 1;
            // 
            // timer1
            // 
            timer1.Interval = 50;
            timer1.Tick += timer1_Tick;
            // 
            // Header
            // 
            Header.Controls.Add(Minimize);
            Header.Controls.Add(Close);
            Header.Controls.Add(pictureBox2);
            Header.Controls.Add(panel2);
            Header.Dock = DockStyle.Top;
            Header.Location = new Point(0, 0);
            Header.Name = "Header";
            Header.Size = new Size(1200, 118);
            Header.TabIndex = 3;
            // 
            // Minimize
            // 
            Minimize.Image = (Image)resources.GetObject("Minimize.Image");
            Minimize.Location = new Point(1065, 33);
            Minimize.Name = "Minimize";
            Minimize.Size = new Size(46, 43);
            Minimize.SizeMode = PictureBoxSizeMode.Zoom;
            Minimize.TabIndex = 4;
            Minimize.TabStop = false;
            Minimize.Click += Minimize_Click;
            // 
            // Close
            // 
            Close.Image = Properties.Resources.wcloese;
            Close.Location = new Point(1117, 33);
            Close.Name = "Close";
            Close.Size = new Size(46, 43);
            Close.SizeMode = PictureBoxSizeMode.Zoom;
            Close.TabIndex = 3;
            Close.TabStop = false;
            Close.Click += Close_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Left;
            pictureBox2.Image = Properties.Resources.APPIE_TEXT;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(228, 108);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 108);
            panel2.Name = "panel2";
            panel2.Size = new Size(1200, 10);
            panel2.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1200, 720);
            Controls.Add(Header);
            Controls.Add(FileLocationPanel);
            Controls.Add(TRANSFER);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            FileLocationPanel.ResumeLayout(false);
            FileLocationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)FileLocation).EndInit();
            Header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Minimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)Close).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TRANSFER;
        private PictureBox pictureBox1;
        private Panel FileLocationPanel;
        private PictureBox FileLocation;
        private System.Windows.Forms.Timer timer1;
        private Panel Header;
        private PictureBox pictureBox2;
        private Panel panel2;
        private PictureBox Minimize;
        private PictureBox Close;
        private Label label1;
        private TextBox flsrc;
        private Label label2;
        private TextBox flnwloc;
        private Button fltrans;
    }
}
