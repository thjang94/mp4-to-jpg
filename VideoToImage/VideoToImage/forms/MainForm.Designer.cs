
namespace VideoToImage.forms
{
    partial class main_form
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pic_preview = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_1second_play = new System.Windows.Forms.Button();
            this.lb_now_frame = new System.Windows.Forms.Label();
            this.btn_1second_back_play = new System.Windows.Forms.Button();
            this.tcb_videoPlayer = new System.Windows.Forms.TrackBar();
            this.btn_1frame_back_play = new System.Windows.Forms.Button();
            this.btn_1frame_play = new System.Windows.Forms.Button();
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_playerReset = new System.Windows.Forms.Button();
            this.lb_now_frame_value = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lb_import_video = new System.Windows.Forms.Label();
            this.txt_import_video = new System.Windows.Forms.TextBox();
            this.btn_import_video = new System.Windows.Forms.Button();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.prgb_state = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.grd_videoFileList = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_make_jpg = new System.Windows.Forms.Button();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_set_end = new System.Windows.Forms.Button();
            this.btn_set_start = new System.Windows.Forms.Button();
            this.btn_make_clip = new System.Windows.Forms.Button();
            this.lb_start_frame_value = new System.Windows.Forms.Label();
            this.lb_end_frame_value = new System.Windows.Forms.Label();
            this.timer_player = new System.Windows.Forms.Timer(this.components);
            this.timer_prog_state = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.main = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_preview)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcb_videoPlayer)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_videoFileList)).BeginInit();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 960F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1262, 582);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.TabStop = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.pic_preview, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 540F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(960, 582);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // pic_preview
            // 
            this.pic_preview.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pic_preview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_preview.Location = new System.Drawing.Point(1, 1);
            this.pic_preview.Margin = new System.Windows.Forms.Padding(0);
            this.pic_preview.Name = "pic_preview";
            this.pic_preview.Size = new System.Drawing.Size(958, 540);
            this.pic_preview.TabIndex = 0;
            this.pic_preview.TabStop = false;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 9;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel5.Controls.Add(this.btn_1second_play, 5, 0);
            this.tableLayoutPanel5.Controls.Add(this.lb_now_frame, 8, 0);
            this.tableLayoutPanel5.Controls.Add(this.btn_1second_back_play, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.tcb_videoPlayer, 6, 0);
            this.tableLayoutPanel5.Controls.Add(this.btn_1frame_back_play, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.btn_1frame_play, 4, 0);
            this.tableLayoutPanel5.Controls.Add(this.btn_play, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.btn_playerReset, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.lb_now_frame_value, 7, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(1, 542);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(958, 39);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // btn_1second_play
            // 
            this.btn_1second_play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_1second_play.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_1second_play.Location = new System.Drawing.Point(238, 6);
            this.btn_1second_play.Name = "btn_1second_play";
            this.btn_1second_play.Size = new System.Drawing.Size(41, 30);
            this.btn_1second_play.TabIndex = 0;
            this.btn_1second_play.TabStop = false;
            this.btn_1second_play.Text = ">>";
            this.btn_1second_play.UseVisualStyleBackColor = true;
            this.btn_1second_play.Click += new System.EventHandler(this.btn_1second_play_Click);
            // 
            // lb_now_frame
            // 
            this.lb_now_frame.AutoSize = true;
            this.lb_now_frame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_now_frame.Location = new System.Drawing.Point(907, 3);
            this.lb_now_frame.Name = "lb_now_frame";
            this.lb_now_frame.Size = new System.Drawing.Size(48, 36);
            this.lb_now_frame.TabIndex = 0;
            this.lb_now_frame.Text = "Frame";
            this.lb_now_frame.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_1second_back_play
            // 
            this.btn_1second_back_play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_1second_back_play.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_1second_back_play.Location = new System.Drawing.Point(3, 6);
            this.btn_1second_back_play.Name = "btn_1second_back_play";
            this.btn_1second_back_play.Size = new System.Drawing.Size(41, 30);
            this.btn_1second_back_play.TabIndex = 0;
            this.btn_1second_back_play.TabStop = false;
            this.btn_1second_back_play.Text = "<<";
            this.btn_1second_back_play.UseVisualStyleBackColor = true;
            this.btn_1second_back_play.Click += new System.EventHandler(this.btn_1second_back_play_Click);
            // 
            // tcb_videoPlayer
            // 
            this.tcb_videoPlayer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tcb_videoPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcb_videoPlayer.Location = new System.Drawing.Point(285, 6);
            this.tcb_videoPlayer.Maximum = 0;
            this.tcb_videoPlayer.Name = "tcb_videoPlayer";
            this.tcb_videoPlayer.Size = new System.Drawing.Size(559, 30);
            this.tcb_videoPlayer.TabIndex = 0;
            this.tcb_videoPlayer.TabStop = false;
            this.tcb_videoPlayer.TickFrequency = 30;
            this.tcb_videoPlayer.Scroll += new System.EventHandler(this.tcb_videoPlayer_Scroll);
            this.tcb_videoPlayer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tcb_videoPlayer_MouseUp);
            // 
            // btn_1frame_back_play
            // 
            this.btn_1frame_back_play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_1frame_back_play.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_1frame_back_play.Location = new System.Drawing.Point(50, 6);
            this.btn_1frame_back_play.Name = "btn_1frame_back_play";
            this.btn_1frame_back_play.Size = new System.Drawing.Size(41, 30);
            this.btn_1frame_back_play.TabIndex = 0;
            this.btn_1frame_back_play.TabStop = false;
            this.btn_1frame_back_play.Text = "<";
            this.btn_1frame_back_play.UseVisualStyleBackColor = true;
            this.btn_1frame_back_play.Click += new System.EventHandler(this.btn_1frame_back_play_Click);
            // 
            // btn_1frame_play
            // 
            this.btn_1frame_play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_1frame_play.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_1frame_play.Location = new System.Drawing.Point(191, 6);
            this.btn_1frame_play.Name = "btn_1frame_play";
            this.btn_1frame_play.Size = new System.Drawing.Size(41, 30);
            this.btn_1frame_play.TabIndex = 0;
            this.btn_1frame_play.TabStop = false;
            this.btn_1frame_play.Text = ">";
            this.btn_1frame_play.UseVisualStyleBackColor = true;
            this.btn_1frame_play.Click += new System.EventHandler(this.btn_1frame_play_Click);
            // 
            // btn_play
            // 
            this.btn_play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_play.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_play.Location = new System.Drawing.Point(144, 6);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(41, 30);
            this.btn_play.TabIndex = 0;
            this.btn_play.TabStop = false;
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // btn_playerReset
            // 
            this.btn_playerReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_playerReset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_playerReset.Location = new System.Drawing.Point(97, 6);
            this.btn_playerReset.Name = "btn_playerReset";
            this.btn_playerReset.Size = new System.Drawing.Size(41, 30);
            this.btn_playerReset.TabIndex = 0;
            this.btn_playerReset.TabStop = false;
            this.btn_playerReset.UseVisualStyleBackColor = true;
            this.btn_playerReset.Click += new System.EventHandler(this.btn_playerReset_Click);
            // 
            // lb_now_frame_value
            // 
            this.lb_now_frame_value.AutoSize = true;
            this.lb_now_frame_value.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_now_frame_value.Location = new System.Drawing.Point(850, 3);
            this.lb_now_frame_value.Name = "lb_now_frame_value";
            this.lb_now_frame_value.Size = new System.Drawing.Size(51, 36);
            this.lb_now_frame_value.TabIndex = 0;
            this.lb_now_frame_value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel6, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel7, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(960, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(302, 582);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 194F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel4.Controls.Add(this.lb_import_video, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.txt_import_video, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_import_video, 2, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(302, 36);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // lb_import_video
            // 
            this.lb_import_video.AutoSize = true;
            this.lb_import_video.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_import_video.Location = new System.Drawing.Point(3, 0);
            this.lb_import_video.Name = "lb_import_video";
            this.lb_import_video.Size = new System.Drawing.Size(56, 36);
            this.lb_import_video.TabIndex = 0;
            this.lb_import_video.Text = "영상선택";
            this.lb_import_video.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_import_video
            // 
            this.txt_import_video.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_import_video.Location = new System.Drawing.Point(65, 7);
            this.txt_import_video.Name = "txt_import_video";
            this.txt_import_video.ReadOnly = true;
            this.txt_import_video.Size = new System.Drawing.Size(188, 21);
            this.txt_import_video.TabIndex = 0;
            this.txt_import_video.TabStop = false;
            // 
            // btn_import_video
            // 
            this.btn_import_video.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_import_video.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_import_video.Location = new System.Drawing.Point(259, 3);
            this.btn_import_video.Name = "btn_import_video";
            this.btn_import_video.Size = new System.Drawing.Size(40, 30);
            this.btn_import_video.TabIndex = 0;
            this.btn_import_video.TabStop = false;
            this.btn_import_video.UseVisualStyleBackColor = true;
            this.btn_import_video.Click += new System.EventHandler(this.btn_import_video_Click);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.96321F));
            this.tableLayoutPanel6.Controls.Add(this.prgb_state, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 554);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(302, 28);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // prgb_state
            // 
            this.prgb_state.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prgb_state.Location = new System.Drawing.Point(0, 0);
            this.prgb_state.Margin = new System.Windows.Forms.Padding(0);
            this.prgb_state.Name = "prgb_state";
            this.prgb_state.Size = new System.Drawing.Size(302, 28);
            this.prgb_state.Step = 1;
            this.prgb_state.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgb_state.TabIndex = 0;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel8, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 36);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(302, 518);
            this.tableLayoutPanel7.TabIndex = 2;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel9, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel10, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel11, 0, 2);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 3;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.81818F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(302, 518);
            this.tableLayoutPanel8.TabIndex = 1;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Controls.Add(this.grd_videoFileList, 0, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel9.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(302, 423);
            this.tableLayoutPanel9.TabIndex = 1;
            // 
            // grd_videoFileList
            // 
            this.grd_videoFileList.AllowUserToAddRows = false;
            this.grd_videoFileList.AllowUserToDeleteRows = false;
            this.grd_videoFileList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_videoFileList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.main});
            this.grd_videoFileList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_videoFileList.Location = new System.Drawing.Point(3, 3);
            this.grd_videoFileList.MultiSelect = false;
            this.grd_videoFileList.Name = "grd_videoFileList";
            this.grd_videoFileList.RowHeadersVisible = false;
            this.grd_videoFileList.RowTemplate.Height = 23;
            this.grd_videoFileList.Size = new System.Drawing.Size(296, 417);
            this.grd_videoFileList.TabIndex = 0;
            this.grd_videoFileList.TabStop = false;
            this.grd_videoFileList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_videoFileList_CellClick);
            this.grd_videoFileList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grd_videoFileList_KeyDown);
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 3;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.74834F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.45033F));
            this.tableLayoutPanel10.Controls.Add(this.btn_make_jpg, 2, 0);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(0, 423);
            this.tableLayoutPanel10.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 1;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(302, 47);
            this.tableLayoutPanel10.TabIndex = 2;
            // 
            // btn_make_jpg
            // 
            this.btn_make_jpg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_make_jpg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_make_jpg.Location = new System.Drawing.Point(206, 3);
            this.btn_make_jpg.Name = "btn_make_jpg";
            this.btn_make_jpg.Size = new System.Drawing.Size(93, 41);
            this.btn_make_jpg.TabIndex = 0;
            this.btn_make_jpg.TabStop = false;
            this.btn_make_jpg.Text = "Export Frame";
            this.btn_make_jpg.UseVisualStyleBackColor = true;
            this.btn_make_jpg.Click += new System.EventHandler(this.btn_make_jpg_Click);
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 5;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel11.Controls.Add(this.btn_set_end, 2, 0);
            this.tableLayoutPanel11.Controls.Add(this.btn_set_start, 0, 0);
            this.tableLayoutPanel11.Controls.Add(this.btn_make_clip, 4, 0);
            this.tableLayoutPanel11.Controls.Add(this.lb_start_frame_value, 1, 0);
            this.tableLayoutPanel11.Controls.Add(this.lb_end_frame_value, 3, 0);
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(3, 473);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 1;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(296, 42);
            this.tableLayoutPanel11.TabIndex = 3;
            // 
            // btn_set_end
            // 
            this.btn_set_end.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_set_end.Location = new System.Drawing.Point(121, 3);
            this.btn_set_end.Name = "btn_set_end";
            this.btn_set_end.Size = new System.Drawing.Size(53, 36);
            this.btn_set_end.TabIndex = 0;
            this.btn_set_end.TabStop = false;
            this.btn_set_end.Text = "끝점";
            this.btn_set_end.UseVisualStyleBackColor = true;
            this.btn_set_end.Visible = false;
            this.btn_set_end.Click += new System.EventHandler(this.btn_set_end_Click);
            // 
            // btn_set_start
            // 
            this.btn_set_start.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_set_start.Location = new System.Drawing.Point(3, 3);
            this.btn_set_start.Name = "btn_set_start";
            this.btn_set_start.Size = new System.Drawing.Size(53, 36);
            this.btn_set_start.TabIndex = 0;
            this.btn_set_start.TabStop = false;
            this.btn_set_start.Text = "시작점";
            this.btn_set_start.UseVisualStyleBackColor = true;
            this.btn_set_start.Visible = false;
            this.btn_set_start.Click += new System.EventHandler(this.btn_set_start_Click);
            // 
            // btn_make_clip
            // 
            this.btn_make_clip.Location = new System.Drawing.Point(239, 3);
            this.btn_make_clip.Name = "btn_make_clip";
            this.btn_make_clip.Size = new System.Drawing.Size(54, 36);
            this.btn_make_clip.TabIndex = 0;
            this.btn_make_clip.TabStop = false;
            this.btn_make_clip.Text = "클립";
            this.btn_make_clip.UseVisualStyleBackColor = true;
            this.btn_make_clip.Visible = false;
            this.btn_make_clip.Click += new System.EventHandler(this.btn_make_clip_Click);
            // 
            // lb_start_frame_value
            // 
            this.lb_start_frame_value.AutoSize = true;
            this.lb_start_frame_value.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_start_frame_value.Location = new System.Drawing.Point(62, 0);
            this.lb_start_frame_value.Name = "lb_start_frame_value";
            this.lb_start_frame_value.Size = new System.Drawing.Size(53, 42);
            this.lb_start_frame_value.TabIndex = 0;
            this.lb_start_frame_value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lb_start_frame_value.Visible = false;
            // 
            // lb_end_frame_value
            // 
            this.lb_end_frame_value.AutoSize = true;
            this.lb_end_frame_value.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_end_frame_value.Location = new System.Drawing.Point(180, 0);
            this.lb_end_frame_value.Name = "lb_end_frame_value";
            this.lb_end_frame_value.Size = new System.Drawing.Size(53, 42);
            this.lb_end_frame_value.TabIndex = 0;
            this.lb_end_frame_value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lb_end_frame_value.Visible = false;
            // 
            // timer_player
            // 
            this.timer_player.Interval = 10;
            this.timer_player.Tick += new System.EventHandler(this.timer_player_Tick);
            // 
            // timer_prog_state
            // 
            this.timer_prog_state.Interval = 2000;
            this.timer_prog_state.Tick += new System.EventHandler(this.timer_prog_state_Tick);
            // 
            // main
            // 
            this.main.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.main.HeaderText = "파일이름";
            this.main.Name = "main";
            this.main.ReadOnly = true;
            this.main.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.main.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1262, 582);
            this.Controls.Add(this.tableLayoutPanel1);
            this.KeyPreview = true;
            this.Name = "main_form";
            this.Text = "EXPORT JPG";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.getFrameForm_KeyDown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_preview)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcb_videoPlayer)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_videoFileList)).EndInit();
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel11.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pic_preview;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lb_import_video;
        private System.Windows.Forms.TextBox txt_import_video;
        private System.Windows.Forms.Button btn_import_video;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TrackBar tcb_videoPlayer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.ProgressBar prgb_state;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Timer timer_player;
        private System.Windows.Forms.Button btn_playerReset;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Button btn_make_jpg;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.DataGridView grd_videoFileList;
        private System.Windows.Forms.Button btn_1frame_back_play;
        private System.Windows.Forms.Button btn_1frame_play;
        private System.Windows.Forms.Label lb_start_frame_value;
        private System.Windows.Forms.Label lb_now_frame_value;
        private System.Windows.Forms.Label lb_now_frame;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.Button btn_set_end;
        private System.Windows.Forms.Button btn_set_start;
        private System.Windows.Forms.Button btn_make_clip;
        private System.Windows.Forms.Label lb_end_frame_value;
        private System.Windows.Forms.Timer timer_prog_state;
        private System.Windows.Forms.Button btn_1second_play;
        private System.Windows.Forms.Button btn_1second_back_play;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn main;
    }
}