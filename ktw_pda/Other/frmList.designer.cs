﻿namespace Other
{
    partial class frmList
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlDetail = new Framework.AlphaPanel();
            this.lblPageInfo = new Framework.LabelEx();
            this.lblPrev = new Framework.LabelEx();
            this.lblNext = new Framework.LabelEx();
            this.F1 = new Framework.ButtonEx();
            this.enter = new Framework.ButtonEx();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grdData = new Framework.GridEx();
            this.tsMain = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.txtBinCode = new Framework.TextEx();
            this.txtBarCode = new Framework.TextEx();
            this.picBack = new Framework.PictureEx();
            this.btnBack = new Framework.ButtonEx();
            this.btnHome = new Framework.ButtonEx();
            this.picHead = new Framework.PictureEx();
            this.pnlDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHead)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDetail
            // 
            this.pnlDetail.BackColor = System.Drawing.Color.White;
            this.pnlDetail.Controls.Add(this.lblPageInfo);
            this.pnlDetail.Controls.Add(this.lblPrev);
            this.pnlDetail.Controls.Add(this.lblNext);
            this.pnlDetail.Controls.Add(this.F1);
            this.pnlDetail.Controls.Add(this.enter);
            this.pnlDetail.Controls.Add(this.grdData);
            this.pnlDetail.Controls.Add(this.txtBinCode);
            this.pnlDetail.Controls.Add(this.txtBarCode);
            this.pnlDetail.Controls.Add(this.picBack);
            this.pnlDetail.Controls.Add(this.btnBack);
            this.pnlDetail.Controls.Add(this.btnHome);
            this.pnlDetail.Controls.Add(this.picHead);
            this.pnlDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetail.Location = new System.Drawing.Point(0, 0);
            this.pnlDetail.Name = "pnlDetail";
            this.pnlDetail.Size = new System.Drawing.Size(238, 295);
            // 
            // lblPageInfo
            // 
            this.lblPageInfo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblPageInfo.Border = false;
            this.lblPageInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPageInfo.Location = new System.Drawing.Point(23, 236);
            this.lblPageInfo.Name = "lblPageInfo";
            this.lblPageInfo.Size = new System.Drawing.Size(187, 23);
            this.lblPageInfo.Text = "{0}-{1}/{2}表示中";
            this.lblPageInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPageInfo.Transparent = false;
            // 
            // lblPrev
            // 
            this.lblPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPrev.Border = false;
            this.lblPrev.Location = new System.Drawing.Point(6, 236);
            this.lblPrev.Name = "lblPrev";
            this.lblPrev.Size = new System.Drawing.Size(51, 23);
            this.lblPrev.Text = "≪";
            this.lblPrev.Transparent = false;
            this.lblPrev.ClickEx += new System.EventHandler(this.lblPrev_ClickEx);
            // 
            // lblNext
            // 
            this.lblNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNext.Border = false;
            this.lblNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNext.Location = new System.Drawing.Point(193, 236);
            this.lblNext.Name = "lblNext";
            this.lblNext.Size = new System.Drawing.Size(37, 23);
            this.lblNext.Text = "≫";
            this.lblNext.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblNext.Transparent = false;
            this.lblNext.ClickEx += new System.EventHandler(this.lblNext_ClickEx);
            // 
            // F1
            // 
            this.F1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.F1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(51)))), ((int)(((byte)(0)))));
            this.F1.BackgroundImage = null;
            this.F1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.F1.HotKey = "keyf1";
            this.F1.Location = new System.Drawing.Point(0, 262);
            this.F1.Name = "F1";
            this.F1.Size = new System.Drawing.Size(99, 33);
            this.F1.TabIndex = 26;
            this.F1.Text = "F1 クリア";
            this.F1.Click += new System.EventHandler(this.F1_Click);
            // 
            // enter
            // 
            this.enter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.enter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(152)))), ((int)(((byte)(203)))));
            this.enter.BackgroundImage = null;
            this.enter.CommitKey = "";
            this.enter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.enter.Location = new System.Drawing.Point(97, 262);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(141, 33);
            this.enter.TabIndex = 25;
            this.enter.Text = "Enter 検索";
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(Other.InventoryInfo);
            // 
            // grdData
            // 
            this.grdData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdData.BackgroundColor = System.Drawing.SystemColors.Window;
            this.grdData.ColumnHeadersVisible = false;
            this.grdData.DataSource = this.bindingSource;
            this.grdData.DoSelectNext = false;
            this.grdData.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
            this.grdData.Location = new System.Drawing.Point(8, 63);
            this.grdData.Name = "grdData";
            this.grdData.RowHeadersVisible = false;
            this.grdData.RowSelectMode = true;
            this.grdData.Size = new System.Drawing.Size(221, 172);
            this.grdData.TabIndex = 2;
            this.grdData.TableStyles.Add(this.tsMain);
            this.grdData.MouseDown += new System.Windows.Forms.MouseEventHandler(this.grdData_MouseDown);
            this.grdData.ShowDetail += new System.EventHandler(this.grdData_ShowDetail);
            this.grdData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdData_KeyDown);
            // 
            // tsMain
            // 
            this.tsMain.GridColumnStyles.Add(this.dataGridTextBoxColumn1);
            this.tsMain.GridColumnStyles.Add(this.dataGridTextBoxColumn2);
            this.tsMain.MappingName = "InventoryInfo";
            // 
            // dataGridTextBoxColumn1
            // 
            this.dataGridTextBoxColumn1.Format = "";
            this.dataGridTextBoxColumn1.FormatInfo = null;
            this.dataGridTextBoxColumn1.MappingName = "Num";
            this.dataGridTextBoxColumn1.NullText = "";
            // 
            // dataGridTextBoxColumn2
            // 
            this.dataGridTextBoxColumn2.Format = "";
            this.dataGridTextBoxColumn2.FormatInfo = null;
            this.dataGridTextBoxColumn2.MappingName = "Content";
            this.dataGridTextBoxColumn2.NullText = "";
            // 
            // txtBinCode
            // 
            this.txtBinCode.BorderColor = System.Drawing.Color.Empty;
            this.txtBinCode.CommitKey = null;
            this.txtBinCode.Field = "binCode";
            this.txtBinCode.Location = new System.Drawing.Point(120, 34);
            this.txtBinCode.Name = "txtBinCode";
            this.txtBinCode.Pattern = null;
            this.txtBinCode.Size = new System.Drawing.Size(109, 25);
            this.txtBinCode.TabIndex = 1;
            this.txtBinCode.Tip = "棚番入力";
            this.txtBinCode.ValidsCommit = null;
            this.txtBinCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBinCode_KeyDown);
            // 
            // txtBarCode
            // 
            this.txtBarCode.BorderColor = System.Drawing.Color.Empty;
            this.txtBarCode.CommitKey = null;
            this.txtBarCode.DoSelectNext = false;
            this.txtBarCode.Field = "barCode";
            this.txtBarCode.Location = new System.Drawing.Point(8, 34);
            this.txtBarCode.MustInput = true;
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.Pattern = null;
            this.txtBarCode.Size = new System.Drawing.Size(109, 25);
            this.txtBarCode.TabIndex = 0;
            this.txtBarCode.Tip = "商品バーコード入力";
            this.txtBarCode.ValidsCommit = null;
            this.txtBarCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarCode_KeyDown);
            // 
            // picBack
            // 
            this.picBack.ImageName = "WMSPDA.Images.back2.gif";
            this.picBack.Location = new System.Drawing.Point(10, 8);
            this.picBack.Name = "picBack";
            this.picBack.Size = new System.Drawing.Size(13, 10);
            this.picBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBack.TextColor = System.Drawing.Color.Empty;
            this.picBack.TextFont = null;
            this.picBack.TitleText = null;
            this.picBack.TransparentColor = System.Drawing.Color.White;
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = null;
            this.btnBack.CommitKey = null;
            this.btnBack.HotKey = null;
            this.btnBack.ImageName = "WMSPDA.Images.back1.png";
            this.btnBack.Location = new System.Drawing.Point(3, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.RoundButton = false;
            this.btnBack.Size = new System.Drawing.Size(26, 17);
            this.btnBack.TabIndex = 4;
            this.btnBack.TransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnHome
            // 
            this.btnHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHome.BackgroundImage = null;
            this.btnHome.CommitKey = null;
            this.btnHome.HotKey = null;
            this.btnHome.ImageName = "WMSPDA.Images.home.png";
            this.btnHome.Location = new System.Drawing.Point(209, 1);
            this.btnHome.Name = "btnHome";
            this.btnHome.RoundButton = false;
            this.btnHome.Size = new System.Drawing.Size(26, 26);
            this.btnHome.TabIndex = 5;
            this.btnHome.TransparentColor = System.Drawing.Color.White;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // picHead
            // 
            this.picHead.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(152)))), ((int)(((byte)(203)))));
            this.picHead.ImageName = "";
            this.picHead.Location = new System.Drawing.Point(0, 0);
            this.picHead.Name = "picHead";
            this.picHead.Size = new System.Drawing.Size(240, 29);
            this.picHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHead.TextColor = System.Drawing.Color.White;
            this.picHead.TextFont = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.picHead.TitleText = "在庫照会";
            this.picHead.TransparentColor = System.Drawing.Color.White;
            // 
            // frmList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(238, 295);
            this.Controls.Add(this.pnlDetail);
            this.Name = "frmList";
            this.Text = "在庫照会";
            this.pnlDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHead)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Framework.AlphaPanel pnlDetail;
        private Framework.ButtonEx btnHome;
        private Framework.PictureEx picHead;
        private Framework.PictureEx picBack;
        private Framework.ButtonEx btnBack;
        private Framework.TextEx txtBinCode;
        private Framework.TextEx txtBarCode;
        private Framework.ButtonEx F1;
        private Framework.ButtonEx enter;
        private Framework.LabelEx lblPageInfo;
        private Framework.LabelEx lblPrev;
        private Framework.LabelEx lblNext;
        private Framework.GridEx grdData;
        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.DataGridTableStyle tsMain;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;

    }
}
