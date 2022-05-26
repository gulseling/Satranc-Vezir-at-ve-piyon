
namespace WinFormsApp3
{
    partial class Form1
    {

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
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.beyazlar = new System.Windows.Forms.ImageList(this.components);
            this.siyahlar = new System.Windows.Forms.ImageList(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 9;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.listBox1, 8, 2);
            this.tableLayoutPanel1.Controls.Add(this.listBox2, 8, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(531, 115);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 49);
            this.listBox1.TabIndex = 2;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(531, 59);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 49);
            this.listBox2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            // 
            // beyazlar
            // 
            this.beyazlar.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.beyazlar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("beyazlar.ImageStream")));
            this.beyazlar.TransparentColor = System.Drawing.Color.Transparent;
            this.beyazlar.Images.SetKeyName(0, "ab.png");
            this.beyazlar.Images.SetKeyName(1, "fb.png");
            this.beyazlar.Images.SetKeyName(2, "kb.png");
            this.beyazlar.Images.SetKeyName(3, "pb.png");
            this.beyazlar.Images.SetKeyName(4, "sb.png");
            this.beyazlar.Images.SetKeyName(5, "vb.png");
            // 
            // siyahlar
            // 
            this.siyahlar.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.siyahlar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("siyahlar.ImageStream")));
            this.siyahlar.TransparentColor = System.Drawing.Color.Transparent;
            this.siyahlar.Images.SetKeyName(0, "as.png");
            this.siyahlar.Images.SetKeyName(1, "fs.png");
            this.siyahlar.Images.SetKeyName(2, "ks.png");
            this.siyahlar.Images.SetKeyName(3, "ps.png");
            this.siyahlar.Images.SetKeyName(4, "ss.png");
            this.siyahlar.Images.SetKeyName(5, "vs.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.ListBox listBox1;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.Button button5;
        public System.Windows.Forms.Button button6;
        public System.Windows.Forms.Button button7;
        public System.Windows.Forms.Button button8;
        public System.Windows.Forms.Button button9;
        public System.Windows.Forms.Button button10;
        public System.Windows.Forms.Button button11;
        public System.Windows.Forms.Button button12;
        public System.Windows.Forms.Button button13;
        public System.Windows.Forms.Button button14;
        public System.Windows.Forms.Button button15;
        public System.Windows.Forms.Button button16;
        public System.Windows.Forms.Button button17;
        public System.Windows.Forms.Button button18;
        public System.Windows.Forms.Button button19;
        public System.Windows.Forms.Button button20;
        public System.Windows.Forms.Button button21;
        public System.Windows.Forms.Button button22;
        public System.Windows.Forms.Button button23;
        public System.Windows.Forms.Button button24;
        public System.Windows.Forms.Button button25;
        public System.Windows.Forms.Button button26;
        public System.Windows.Forms.Button button27;
        public System.Windows.Forms.Button button28;
        public System.Windows.Forms.Button button29;
        public System.Windows.Forms.Button button30;
        public System.Windows.Forms.Button button31;
        public System.Windows.Forms.Button button32;
        public System.Windows.Forms.Button button33;
        public System.Windows.Forms.Button button34;
        public System.Windows.Forms.Button button35;
        public System.Windows.Forms.Button button36;
        public System.Windows.Forms.Button button37;
        public System.Windows.Forms.Button button39;
        public System.Windows.Forms.Button button40;
        public System.Windows.Forms.Button button41;
        public System.Windows.Forms.Button button42;
        public System.Windows.Forms.Button button43;
        public System.Windows.Forms.Button button45;
        public System.Windows.Forms.Button button46;
        public System.Windows.Forms.Button button47;
        public System.Windows.Forms.Button button48;
        public System.Windows.Forms.Button button49;
        public System.Windows.Forms.Button button50;
        public System.Windows.Forms.Button button51;
        public System.Windows.Forms.Button button53;
        public System.Windows.Forms.Button button54;
        public System.Windows.Forms.Button button55;
        public System.Windows.Forms.Button button56;
        public System.Windows.Forms.Button button57;
        public System.Windows.Forms.Button button58;
        public System.Windows.Forms.Button button59;
        public System.Windows.Forms.Button button60;
        public System.Windows.Forms.Button button61;
        public System.Windows.Forms.Button button62;
        public System.Windows.Forms.Button button63;
        public System.Windows.Forms.Button button64;
        public System.Windows.Forms.Button button44;
        public System.Windows.Forms.Button button52;
        public System.Windows.Forms.Button button38;
        public System.Windows.Forms.ListBox listBox2;
        public System.Windows.Forms.ImageList beyazlar;
        public System.Windows.Forms.ImageList siyahlar;
        private System.ComponentModel.IContainer components;
    }
}

