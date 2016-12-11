﻿namespace DontStarve.App
{
    partial class F_CookieInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_CookieInfo));
            this.skinSplitContainer1 = new CCWin.SkinControl.SkinSplitContainer();
            this.skinSplitContainer2 = new CCWin.SkinControl.SkinSplitContainer();
            this.labRating = new CCWin.SkinControl.SkinLabel();
            this.labCookieName = new CCWin.SkinControl.SkinLabel();
            this.picCookie = new CCWin.SkinControl.SkinPictureBox();
            this.lbFunc = new CCWin.SkinControl.SkinListBox();
            this.gifBox1 = new CCWin.SkinControl.GifBox();
            this.yyu_PraiseNum1 = new DontStarve.App.Yyu_PraiseNum();
            ((System.ComponentModel.ISupportInitialize)(this.skinSplitContainer1)).BeginInit();
            this.skinSplitContainer1.Panel1.SuspendLayout();
            this.skinSplitContainer1.Panel2.SuspendLayout();
            this.skinSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skinSplitContainer2)).BeginInit();
            this.skinSplitContainer2.Panel1.SuspendLayout();
            this.skinSplitContainer2.Panel2.SuspendLayout();
            this.skinSplitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCookie)).BeginInit();
            this.SuspendLayout();
            // 
            // skinSplitContainer1
            // 
            this.skinSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.skinSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinSplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.skinSplitContainer1.IsSplitterFixed = true;
            this.skinSplitContainer1.LineBack = System.Drawing.Color.Teal;
            this.skinSplitContainer1.Location = new System.Drawing.Point(4, 9);
            this.skinSplitContainer1.Name = "skinSplitContainer1";
            // 
            // skinSplitContainer1.Panel1
            // 
            this.skinSplitContainer1.Panel1.Controls.Add(this.gifBox1);
            // 
            // skinSplitContainer1.Panel2
            // 
            this.skinSplitContainer1.Panel2.Controls.Add(this.skinSplitContainer2);
            this.skinSplitContainer1.Size = new System.Drawing.Size(802, 611);
            this.skinSplitContainer1.SplitterDistance = 316;
            this.skinSplitContainer1.TabIndex = 0;
            this.skinSplitContainer1.CollapseClick += new System.EventHandler(this.skinSplitContainer1_CollapseClick);
            // 
            // skinSplitContainer2
            // 
            this.skinSplitContainer2.Cursor = System.Windows.Forms.Cursors.Default;
            this.skinSplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinSplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.skinSplitContainer2.IsSplitterFixed = true;
            this.skinSplitContainer2.LineBack = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.skinSplitContainer2.Location = new System.Drawing.Point(0, 0);
            this.skinSplitContainer2.Name = "skinSplitContainer2";
            this.skinSplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // skinSplitContainer2.Panel1
            // 
            this.skinSplitContainer2.Panel1.Controls.Add(this.labRating);
            this.skinSplitContainer2.Panel1.Controls.Add(this.yyu_PraiseNum1);
            this.skinSplitContainer2.Panel1.Controls.Add(this.labCookieName);
            this.skinSplitContainer2.Panel1.Controls.Add(this.picCookie);
            // 
            // skinSplitContainer2.Panel2
            // 
            this.skinSplitContainer2.Panel2.Controls.Add(this.lbFunc);
            this.skinSplitContainer2.Size = new System.Drawing.Size(482, 611);
            this.skinSplitContainer2.SplitterDistance = 143;
            this.skinSplitContainer2.SplitterWidth = 10;
            this.skinSplitContainer2.TabIndex = 0;
            // 
            // labRating
            // 
            this.labRating.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labRating.AutoSize = true;
            this.labRating.BackColor = System.Drawing.Color.Transparent;
            this.labRating.BorderColor = System.Drawing.Color.White;
            this.labRating.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labRating.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.labRating.Location = new System.Drawing.Point(57, 118);
            this.labRating.Name = "labRating";
            this.labRating.Size = new System.Drawing.Size(56, 17);
            this.labRating.TabIndex = 3;
            this.labRating.Text = "好评率：";
            // 
            // labCookieName
            // 
            this.labCookieName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labCookieName.AutoSize = true;
            this.labCookieName.BackColor = System.Drawing.Color.Transparent;
            this.labCookieName.BorderColor = System.Drawing.Color.White;
            this.labCookieName.Font = new System.Drawing.Font("楷体", 35F);
            this.labCookieName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labCookieName.Location = new System.Drawing.Point(191, 28);
            this.labCookieName.Name = "labCookieName";
            this.labCookieName.Size = new System.Drawing.Size(164, 47);
            this.labCookieName.TabIndex = 1;
            this.labCookieName.Text = "三鲜煲";
            // 
            // picCookie
            // 
            this.picCookie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picCookie.BackColor = System.Drawing.Color.Transparent;
            this.picCookie.Location = new System.Drawing.Point(17, 3);
            this.picCookie.Name = "picCookie";
            this.picCookie.Size = new System.Drawing.Size(132, 108);
            this.picCookie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCookie.TabIndex = 0;
            this.picCookie.TabStop = false;
            // 
            // lbFunc
            // 
            this.lbFunc.Back = null;
            this.lbFunc.BackColor = System.Drawing.Color.Transparent;
            this.lbFunc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbFunc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbFunc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbFunc.Font = new System.Drawing.Font("华文楷体", 12F);
            this.lbFunc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lbFunc.FormattingEnabled = true;
            this.lbFunc.ImageVisble = false;
            this.lbFunc.ItemHeight = 50;
            this.lbFunc.ItemImageLayout = false;
            this.lbFunc.ItemRadius = 80;
            this.lbFunc.Items.AddRange(new CCWin.SkinControl.SkinListBoxItem[] {
            ((CCWin.SkinControl.SkinListBoxItem)(resources.GetObject("lbFunc.Items"))),
            ((CCWin.SkinControl.SkinListBoxItem)(resources.GetObject("lbFunc.Items1")))});
            this.lbFunc.Location = new System.Drawing.Point(0, 0);
            this.lbFunc.MouseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbFunc.Name = "lbFunc";
            this.lbFunc.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.lbFunc.RowBackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbFunc.RowBackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbFunc.Size = new System.Drawing.Size(482, 458);
            this.lbFunc.TabIndex = 0;
            // 
            // gifBox1
            // 
            this.gifBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gifBox1.BorderColor = System.Drawing.Color.Transparent;
            this.gifBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.gifBox1.Image = ((System.Drawing.Image)(resources.GetObject("gifBox1.Image")));
            this.gifBox1.Location = new System.Drawing.Point(3, 188);
            this.gifBox1.Name = "gifBox1";
            this.gifBox1.Size = new System.Drawing.Size(310, 199);
            this.gifBox1.TabIndex = 0;
            this.gifBox1.Text = "gifBox1";
            this.gifBox1.Click += new System.EventHandler(this.gifBox1_Click);
            // 
            // yyu_PraiseNum1
            // 
            this.yyu_PraiseNum1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.yyu_PraiseNum1.BackColor = System.Drawing.Color.Transparent;
            this.yyu_PraiseNum1.Location = new System.Drawing.Point(367, 101);
            this.yyu_PraiseNum1.Name = "yyu_PraiseNum1";
            this.yyu_PraiseNum1.Size = new System.Drawing.Size(101, 37);
            this.yyu_PraiseNum1.TabIndex = 2;
            // 
            // F_CookieInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CanResize = false;
            this.CaptionHeight = 18;
            this.ClientSize = new System.Drawing.Size(810, 624);
            this.CloseBoxSize = new System.Drawing.Size(32, 27);
            this.Controls.Add(this.skinSplitContainer1);
            this.EffectCaption = CCWin.TitleType.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.InnerBorderColor = System.Drawing.Color.Red;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_CookieInfo";
            this.Radius = 36;
            this.ShadowWidth = 1;
            this.ShowBorder = false;
            this.ShowDrawIcon = false;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.Load += new System.EventHandler(this.F_CookieInfo_Load);
            this.skinSplitContainer1.Panel1.ResumeLayout(false);
            this.skinSplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.skinSplitContainer1)).EndInit();
            this.skinSplitContainer1.ResumeLayout(false);
            this.skinSplitContainer2.Panel1.ResumeLayout(false);
            this.skinSplitContainer2.Panel1.PerformLayout();
            this.skinSplitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.skinSplitContainer2)).EndInit();
            this.skinSplitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCookie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinSplitContainer skinSplitContainer1;
        private CCWin.SkinControl.SkinSplitContainer skinSplitContainer2;
        private CCWin.SkinControl.SkinPictureBox picCookie;
        private CCWin.SkinControl.SkinLabel labCookieName;
        private Yyu_PraiseNum yyu_PraiseNum1;
        private CCWin.SkinControl.SkinListBox lbFunc;
        private CCWin.SkinControl.SkinLabel labRating;
        private CCWin.SkinControl.GifBox gifBox1;
    }
}