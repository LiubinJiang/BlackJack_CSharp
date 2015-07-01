namespace Assign_final
{
    partial class aNewPlayer
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Octupus", "head01.jpg");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("StarwBerry", "head02.jpg");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Girl", "head03.jpg");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Alligator", "head04.jpg");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aNewPlayer));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.begin_btn = new System.Windows.Forms.Button();
            this.return_btn = new System.Windows.Forms.Button();
            this.name_text = new System.Windows.Forms.TextBox();
            this.head_list = new System.Windows.Forms.ListView();
            this.head_init = new System.Windows.Forms.ImageList(this.components);
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "名纸";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "头像";
            // 
            // begin_btn
            // 
            this.begin_btn.Location = new System.Drawing.Point(244, 54);
            this.begin_btn.Name = "begin_btn";
            this.begin_btn.Size = new System.Drawing.Size(149, 63);
            this.begin_btn.TabIndex = 2;
            this.begin_btn.Text = "开始";
            this.begin_btn.UseVisualStyleBackColor = true;
            this.begin_btn.Click += new System.EventHandler(this.begin_btn_Click);
            // 
            // return_btn
            // 
            this.return_btn.Location = new System.Drawing.Point(244, 138);
            this.return_btn.Name = "return_btn";
            this.return_btn.Size = new System.Drawing.Size(149, 67);
            this.return_btn.TabIndex = 3;
            this.return_btn.Text = "返回";
            this.return_btn.UseVisualStyleBackColor = true;
            // 
            // name_text
            // 
            this.name_text.Location = new System.Drawing.Point(116, 54);
            this.name_text.Name = "name_text";
            this.name_text.Size = new System.Drawing.Size(100, 21);
            this.name_text.TabIndex = 4;
            // 
            // head_list
            // 
            this.head_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.head_list.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.head_list.LargeImageList = this.head_init;
            this.head_list.Location = new System.Drawing.Point(116, 115);
            this.head_list.Name = "head_list";
            this.head_list.Size = new System.Drawing.Size(100, 90);
            this.head_list.SmallImageList = this.head_init;
            this.head_list.TabIndex = 5;
            this.head_list.UseCompatibleStateImageBehavior = false;
            this.head_list.View = System.Windows.Forms.View.List;
            // 
            // head_init
            // 
            this.head_init.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("head_init.ImageStream")));
            this.head_init.TransparentColor = System.Drawing.Color.Transparent;
            this.head_init.Images.SetKeyName(0, "head01.jpg");
            this.head_init.Images.SetKeyName(1, "head02.jpg");
            this.head_init.Images.SetKeyName(2, "head03.jpg");
            this.head_init.Images.SetKeyName(3, "head04.jpg");
            // 
            // aNewPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 263);
            this.Controls.Add(this.head_list);
            this.Controls.Add(this.name_text);
            this.Controls.Add(this.return_btn);
            this.Controls.Add(this.begin_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "aNewPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "aNewPlayer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button begin_btn;
        private System.Windows.Forms.Button return_btn;
        private System.Windows.Forms.TextBox name_text;
        private System.Windows.Forms.ListView head_list;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ImageList head_init;
    }
}