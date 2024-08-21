using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace UpdateDataPLC
{
    partial class FdataUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FdataUpdate));
            btnConnect = new Button();
            textStaNO = new TextBox();
            btnDisconnect = new Button();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            setingToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem1 = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            picturePLCRun = new PictureBox();
            picturePLCStop = new PictureBox();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            listBoxDisplay = new ListBox();
            btnClearDisplay = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picturePLCRun).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picturePLCStop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(12, 223);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(94, 29);
            btnConnect.TabIndex = 560;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click_1;
            // 
            // textStaNO
            // 
            textStaNO.Location = new Point(148, 180);
            textStaNO.Name = "textStaNO";
            textStaNO.Size = new Size(44, 27);
            textStaNO.TabIndex = 564;
            textStaNO.Text = "1";
            // 
            // btnDisconnect
            // 
            btnDisconnect.Location = new Point(112, 223);
            btnDisconnect.Name = "btnDisconnect";
            btnDisconnect.Size = new Size(94, 29);
            btnDisconnect.TabIndex = 561;
            btnDisconnect.Text = "DisConnect";
            btnDisconnect.UseVisualStyleBackColor = true;
            btnDisconnect.Click += btnDisconnect_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, viewToolStripMenuItem, setingToolStripMenuItem, aboutToolStripMenuItem, aboutToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(368, 28);
            menuStrip1.TabIndex = 566;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(55, 24);
            viewToolStripMenuItem.Text = "View";
            // 
            // setingToolStripMenuItem
            // 
            setingToolStripMenuItem.Name = "setingToolStripMenuItem";
            setingToolStripMenuItem.Size = new Size(70, 24);
            setingToolStripMenuItem.Text = "Setting";
            setingToolStripMenuItem.Click += setingToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(55, 24);
            aboutToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem1
            // 
            aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            aboutToolStripMenuItem1.Size = new Size(64, 24);
            aboutToolStripMenuItem1.Text = "About";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Lime;
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(14, 84);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(152, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 567;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new System.Drawing.Font("Segoe UI", 14F);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(12, 44);
            label1.Name = "label1";
            label1.Size = new Size(185, 32);
            label1.TabIndex = 568;
            label1.Text = "PLC MITSUBISHI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            label2.Location = new Point(194, 95);
            label2.Name = "label2";
            label2.Size = new Size(40, 23);
            label2.TabIndex = 569;
            label2.Text = "Run";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            label3.Location = new Point(194, 117);
            label3.Name = "label3";
            label3.Size = new Size(44, 23);
            label3.TabIndex = 570;
            label3.Text = "Stop";
            // 
            // picturePLCRun
            // 
            picturePLCRun.BackColor = Color.Silver;
            picturePLCRun.Location = new Point(267, 100);
            picturePLCRun.Name = "picturePLCRun";
            picturePLCRun.Size = new Size(41, 14);
            picturePLCRun.TabIndex = 571;
            picturePLCRun.TabStop = false;
            // 
            // picturePLCStop
            // 
            picturePLCStop.BackColor = Color.Silver;
            picturePLCStop.Location = new Point(267, 126);
            picturePLCStop.Name = "picturePLCStop";
            picturePLCStop.Size = new Size(41, 14);
            picturePLCStop.TabIndex = 572;
            picturePLCStop.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Silver;
            pictureBox2.Location = new Point(267, 149);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(41, 14);
            pictureBox2.TabIndex = 574;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            label4.Location = new Point(194, 140);
            label4.Name = "label4";
            label4.Size = new Size(74, 23);
            label4.TabIndex = 573;
            label4.Text = "Warning";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            label5.Location = new Point(32, 181);
            label5.Name = "label5";
            label5.Size = new Size(90, 23);
            label5.TabIndex = 575;
            label5.Text = "No.Station";
            // 
            // listBoxDisplay
            // 
            listBoxDisplay.FormattingEnabled = true;
            listBoxDisplay.Location = new Point(12, 258);
            listBoxDisplay.Name = "listBoxDisplay";
            listBoxDisplay.Size = new Size(305, 104);
            listBoxDisplay.TabIndex = 576;
            // 
            // btnClearDisplay
            // 
            btnClearDisplay.Location = new Point(219, 369);
            btnClearDisplay.Name = "btnClearDisplay";
            btnClearDisplay.Size = new Size(94, 29);
            btnClearDisplay.TabIndex = 577;
            btnClearDisplay.Text = "Clear ALL";
            btnClearDisplay.UseVisualStyleBackColor = true;
            btnClearDisplay.Click += btnClearDisplay_Click;
            // 
            // FdataUpdate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 404);
            Controls.Add(btnClearDisplay);
            Controls.Add(listBoxDisplay);
            Controls.Add(label5);
            Controls.Add(pictureBox2);
            Controls.Add(label4);
            Controls.Add(picturePLCStop);
            Controls.Add(picturePLCRun);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnConnect);
            Controls.Add(textStaNO);
            Controls.Add(btnDisconnect);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FdataUpdate";
            Text = "PLC Connect";
            FormClosing += FdataUpdate_FormClosing;
            Load += FdataUpdate_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picturePLCRun).EndInit();
            ((System.ComponentModel.ISupportInitialize)picturePLCStop).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnConnect; 
        private TextBox textStaNO;

        private Button btnDisconnect;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem setingToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox picturePLCRun;
        private PictureBox picturePLCStop;
        private PictureBox pictureBox2;
        private Label label4;
        private Label label5;
        private ListBox listBoxDisplay;
        private Button btnClearDisplay;
    }
}