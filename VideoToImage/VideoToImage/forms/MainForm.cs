using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoToImage.modules;

namespace VideoToImage.forms
{
    public partial class main_form : Form
    {
        List<FileInfo> _videoInfoList = null;

        bool _isPlayer = false;                    // 플레이 버튼 체크 변수
        Bitmap[] _playButtonImage = new Bitmap[2]; // 플레이 버튼 이미지 저장 변수

        VideoCapture _video = null;                // 현재 비디오
        int _nowFrame = 0;                         // 현재 표출되는 프레임

        int[] _clipFrame = {-1, -1};               // {시작 프레임, 종료 프레임}
        int _getFrame = -1;                        // 추출 프레임

        int progressValue = 0;                     // 상태바의 값

        bool isGetFile = false;                    // 파일 탐색기 사용 여부

        public main_form()
        {
            InitializeComponent();
            // 버튼 이미지 세팅
            initButtonImage();
            initForm();

        }

        /// <summary>
        ///  포커스 이동을 막음.
        /// </summary>
        private void Control1_GotFocus(Object sender, EventArgs e)
        {
            pic_preview.Focus();
        }
        #region init
        /// <summary>
        ///  init 함수.
        /// </summary>
        public void initForm()
        {
            this.MaximizeBox = false;
            timer_prog_state.Start();
            prgb_state.Value = 0;
            prgb_state.Maximum = 0;

            // 포커스 이벤트 
            this.btn_1second_back_play.GotFocus += Control1_GotFocus;
            this.btn_1frame_back_play.GotFocus  += Control1_GotFocus;
            this.btn_playerReset.GotFocus       += Control1_GotFocus;
            this.btn_play.GotFocus              += Control1_GotFocus;
            this.btn_1frame_play.GotFocus       += Control1_GotFocus;
            this.btn_1second_play.GotFocus      += Control1_GotFocus;
            this.tcb_videoPlayer.GotFocus       += Control1_GotFocus;
            this.btn_make_jpg.GotFocus          += Control1_GotFocus;
            this.btn_set_start.GotFocus         += Control1_GotFocus;
            this.btn_set_end.GotFocus           += Control1_GotFocus;
            this.btn_make_clip.GotFocus         += Control1_GotFocus;
            this.ActiveControl = pic_preview;

            // 툴팁
            toolTip1.SetToolTip(btn_1second_back_play , "ctrl + left");
            toolTip1.SetToolTip(btn_1frame_back_play  , "left");
            toolTip1.SetToolTip(btn_play              , "space");
            toolTip1.SetToolTip(btn_1frame_play       , "right");
            toolTip1.SetToolTip(btn_1second_play      , "ctrl + right");
            toolTip1.SetToolTip(btn_make_jpg          , "enter");
        }
        /// <summary>
        ///  버튼 이미지 세팅 함수.
        /// </summary>
        public Boolean initButtonImage()
        {
            try
            {
                // 비디오 불러오기 버튼 세팅
                this.btn_import_video.Image = new Bitmap(Properties.Resources.import_icon, 25, 25);

                // 비디오 정지 버튼 세팅
                this.btn_playerReset.Image = new Bitmap(Properties.Resources.stop_icon, 20, 20);

                // 비디오 플레이 정지 버튼 세팅
                this.btn_playerReset.Image = new Bitmap(Properties.Resources.stop_icon, 20, 20);

                // 비디오 플레이 버튼 세팅
                _playButtonImage[0] = new Bitmap(Properties.Resources.play_icon, 20, 20);
                _playButtonImage[1] = new Bitmap(Properties.Resources.pause_icon, 20, 20);
                this.btn_play.Image = _playButtonImage[0];
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return true;
            }
            return false;
        }
        #endregion
        #region 파일 불러오기

        /// <summary>
        ///  동영상 파일을 불러오는 탐색기 기능.
        /// </summary>
        private void btn_import_video_Click(object sender, EventArgs e)
        {
            if(isGetFile)
            {
                MessageBox.Show("진행중인 작업이 있습니다.");
                return;
            }

            FileDialogModule fileDialogModule = new FileDialogModule();

            // 파일 탐색기를 열고 선택한 동영상의 주소값을 반환.
            _videoInfoList = fileDialogModule.getVideoPathInFolder();
            // 동영상 파일이 없다면 종료
            if (_videoInfoList == null) return;

            _video = new VideoCapture(_videoInfoList[0].FullName);
 
            Mat frame = new Mat();

            tcb_videoPlayer.Maximum = _video.FrameCount - 1;

            changePreview();

            btn_play.Focus();

            grd_videoFileList.Rows.Clear();
            foreach (FileInfo videoInfo in _videoInfoList)
                grd_videoFileList.Rows.Add(videoInfo.Name);

            txt_import_video.Text = _videoInfoList[0].DirectoryName;
        }
        #endregion
        #region 플레이어 기능.
        /// <summary>
        ///  뒤로 한 프레임 이동.
        /// </summary>
        private void btn_1frame_back_play_Click(object sender, EventArgs e)
        {
            // 선택된 비디오다면 종료
            if (_video == null) return;

            int move = -1;

            if (_nowFrame <= 0) return;

            moveFrame(move);
        }
        /// <summary>
        /// 플레이 버튼. timer_player를 실행한다.
        /// </summary>
        private void btn_play_Click(object sender, EventArgs e)
        {
            // 선택된 비디오다면 종료
            if (_video == null) return;

            _isPlayer = !_isPlayer;

            if (_isPlayer)
            {
                timer_player.Start();
                this.btn_play.Image = _playButtonImage[1];
            }
        }

        private void btn_1second_back_play_Click(object sender, EventArgs e)
        {
            // 선택된 비디오다면 종료
            if (_video == null) return;

            int move = -60;

            if (_nowFrame + move <= 0) move = _nowFrame * -1;

            moveFrame(move);
        }

        private void btn_1second_play_Click(object sender, EventArgs e)
        {
            // 선택된 비디오다면 종료
            if (_video == null) return;

            int move = 60;

            if (_nowFrame + move >= _video.FrameCount - 1) move = _video.FrameCount - 1 - _nowFrame;

            moveFrame(move);
        }
        /// <summary>
        /// 플레이 버튼에 의해 실행. _video 변수의 영상을 플레이한다.
        /// </summary>
        private void timer_player_Tick(object sender, EventArgs e)
        {
            if(_video.PosFrames == _video.FrameCount || !_isPlayer)
            {
                timer_player.Stop();
                this.btn_play.Image = _playButtonImage[0];
                return;
            }

            _nowFrame = _video.PosFrames;
            tcb_videoPlayer.Value = _nowFrame;

            changePreview();
        }
        /// <summary>
        /// 앞으로 한 프레임 이동.
        /// </summary>
        private void btn_1frame_play_Click(object sender, EventArgs e)
        {
            // 선택된 비디오다면 종료
            if (_video == null) return;

            int move = 1;

            if (_nowFrame >= _video.FrameCount - move) return;

            moveFrame(move);
        }

        /// <summary>
        /// 처음으로.
        /// </summary>
        private void btn_playerReset_Click(object sender, EventArgs e)
        {
            // 선택된 비디오가 없다면 종료
            if (_video == null) return;

            _isPlayer = false;
            _nowFrame = 0;
            _video.PosFrames = _nowFrame;
            tcb_videoPlayer.Value = _nowFrame;

            changePreview();
        }

        /// <summary>
        /// 스크롤 이동으로 프레임 전환
        /// </summary>
        private void tcb_videoPlayer_Scroll(object sender, EventArgs e)
        {
            // 선택된 비디오다면 종료
            if (_video == null) return;

            _nowFrame = tcb_videoPlayer.Value;
            _video.PosFrames = _nowFrame;

        }
        
        /// <summary>
        /// 프리뷰의 이미지를 현재 위치로 표출.
        /// </summary>
        public void changePreview()
        {
            lb_now_frame_value.Text = _nowFrame.ToString();

            Mat frame = new Mat();
            _video.Read(frame);

            if (pic_preview.Image != null)
                pic_preview.Image.Dispose();

            Cv2.Resize(frame, frame, new OpenCvSharp.Size(this.pic_preview.Width, this.pic_preview.Height));
            pic_preview.Image = OpenCvSharp.Extensions.BitmapConverter.ToBitmap(frame);

            frame.Dispose();
        }
        /// <summary>
        ///  선택된 위치로 프리뷰 출력.
        /// </summary>
        private void tcb_videoPlayer_MouseUp(object sender, MouseEventArgs e)
        {
            // 선택된 비디오다면 종료
            if (_video == null) return;

            _nowFrame = tcb_videoPlayer.Value;
            _video.PosFrames = _nowFrame;

            changePreview();
        }

        /// <summary>
        /// move 만큼 프레임 이동.
        /// </summary>
        public void moveFrame(int move)
        {
            // 선택된 비디오가 없거나 백플레이가 실행중이라면 종료
            if (_video == null) return;

            _nowFrame += move;
            _video.PosFrames = _nowFrame;
            tcb_videoPlayer.Value = _nowFrame;

            changePreview();
        }

        /// <summary>
        /// 선택한 비디오로 프리뷰 전환.
        /// </summary>
        private void grd_videoFileList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex.Equals(-1)) return;

            _video.Release();
            _video = new VideoCapture(_videoInfoList[e.RowIndex].FullName);

            tcb_videoPlayer.Maximum = _video.FrameCount - 1;

            if (_video.FrameCount < _nowFrame) _nowFrame = _video.FrameCount - 1;

            if (_clipFrame[1] > -1)
            {
                _clipFrame[1] = _nowFrame;
                if (_clipFrame[1] > -1) this.lb_end_frame_value.Text = _clipFrame[1].ToString();
            }

            _video.PosFrames = _nowFrame;
            changePreview();
        }
        #endregion
        #region 한 프레임 jpg 추출.
        /// <summary>
        /// 프레임 추출 버튼. 현재 위치의 프레임을 추출한다.
        /// </summary>
        private void btn_make_jpg_Click(object sender, EventArgs e)
        {
            if (_video == null || _nowFrame < 0) return;

            _getFrame = _nowFrame;

            prgb_state.Maximum += _videoInfoList.Count * 2;

            foreach (FileInfo videoInfo in _videoInfoList)
            {
                progressValue++;
                Task.Run(() =>
                {
                    Task task = getFrame(videoInfo);
                });
            }
            setInfoText(_videoInfoList[0].DirectoryName + '\\' + "FrameInfo.txt", _getFrame.ToString());
            isGetFile = true;
        }
        /// <summary>
        /// 현재 위치의 프레임을 추출하는 비동기 메서드.
        /// </summary>
        private async Task getFrame(FileInfo videoInfo)
        {
            try
            {
                VideoCapture videoCapture = new VideoCapture(videoInfo.FullName);
                videoCapture.PosFrames = _getFrame;

                Mat frame = new Mat(); ;
                videoCapture.Read(frame);
                string[] videoName = videoInfo.Name.Split('.');
                frame.SaveImage(videoInfo.DirectoryName + '\\' + _getFrame + "_" + videoName[0] + ".jpg");

                frame.Dispose();
                videoCapture.Release();
            }catch(Exception e)
            {
                MessageBox.Show(videoInfo.Name + "의 " + _getFrame + "번 프레임 jpg 생성 실패");
            }
            finally
            {
                progressValue++;
            }
        }

        /// <summary>
        /// 파일 정보 쓰기 메서드
        /// </summary>
        /// <param name="path">저장 주소</param>
        /// <param name="word">텍스트 내용</param>
        private void setInfoText(string path, string word)
        {
            if (!File.Exists(path))
                using (File.Create(path));

            StreamWriter writer;
            writer = File.AppendText(path);
            writer.WriteLine(word);
            writer.Close();
        }

        #endregion
        #region 클립 생성 기능.
        /// <summary>
        /// 클립 생성을 위한 시작점 저장.
        /// </summary>
        private void btn_set_start_Click(object sender, EventArgs e)
        {
            // 선택된 비디오가 없으면 종료
            if (_video == null) return;

            _clipFrame[0] = _nowFrame;
            this.lb_start_frame_value.Text = _clipFrame[0].ToString();
        }
        /// <summary>
        /// 클립 생성을 위한 종료점 저장.
        /// </summary>
        private void btn_set_end_Click(object sender, EventArgs e)
        {
            // 선택된 비디오가 없으면 종료
            if (_video == null) return;

            _clipFrame[1] = _nowFrame;
            this.lb_end_frame_value.Text = _clipFrame[1].ToString();
        }
        /// <summary>
        /// 클립 생성 버튼. 시작점부터 종료점까지의 클립 영상 생성.
        /// </summary>
        private void btn_make_clip_Click(object sender, EventArgs e)
        {
            // 선택된 비디오가 없으면 종료
            if (_video == null) return;


            if (_clipFrame[1] < _clipFrame[0])
            {
                MessageBox.Show("클립 시작점과 종료점을 확인하세요.");
                return;
            }

            if (_clipFrame[0] < 0 || _clipFrame[1] < 0 || _clipFrame[0] > _clipFrame[1])
            {
                MessageBox.Show("시작 프레임과 종료 프레임을 확인하세요.");
                return;
            }

            prgb_state.Maximum += _videoInfoList.Count * 2;
            foreach (FileInfo videoInfo in _videoInfoList)
            {
                progressValue++;
                Task.Run(() =>
                {
                    Task task = makeClip(videoInfo);
                });
            }

            isGetFile = true;
        }

        /// <summary>
        /// 시작점부터 종료점까지의 클립 영상 생성.
        /// </summary>
        private async Task makeClip(FileInfo videoInfo)
        {
            /*
                • filename : 비디오 파일 이름 (e.g. 'video.mp4')

                • fourcc : fourcc (e.g. cv2.VideoWriter_fourcc(*'DIVX'))

                • fps : 초당 프레임 수 (e.g. 30)

                • frameSize : 프레임 크기. (width, height) 튜플.

                • isColor : 컬러 영상이면 True, 그렇지않으면 False. 기본값은 True입니다.

                • retval : cv2.VideoWriter 객체
             */
            using (VideoWriter videoWriter = new VideoWriter(videoInfo.DirectoryName + "\\" + _clipFrame[0] + "_" + _clipFrame[1] + "_" + videoInfo.Name, FourCC.DIVX, 60, new OpenCvSharp.Size(_video.FrameWidth, _video.FrameHeight), true))
            {
                VideoCapture videoCapture = new VideoCapture(videoInfo.FullName);
                videoCapture.PosFrames = _clipFrame[0];
                for (int j = _clipFrame[0]; j < _clipFrame[1]; j++)
                {
                    Mat frame = new Mat();
                    videoCapture.Read(frame);
                    videoWriter.Write(frame);
                    frame.Dispose();
                }
                videoCapture.Release();
                videoWriter.Release();
            }
            progressValue++;
        }
        #endregion
        #region 상태 게이지
        /// <summary>
        /// 작업 상태 게이지를 통해 현재 진행률 표출.
        /// </summary>
        private void timer_prog_state_Tick(object sender, EventArgs e)
        {
            if (this.prgb_state.Value == this.prgb_state.Maximum && this.prgb_state.Value != 0)
            {
                progressValue = 0;
                this.prgb_state.Maximum = progressValue;

                isGetFile = false;
            }

            this.prgb_state.Value = progressValue;
        }

        #endregion

        #region 키보드 이벤트
        /// <summary>
        /// 키보드 작업 이벤트.
        /// </summary>
        private void getFrameForm_KeyDown(object sender, KeyEventArgs e)
        {

            // 선택된 비디오다면 종료
            if (_video == null) return;
            if (this.Focus()) Console.WriteLine(this.Name);
            
            if (e.Control && e.KeyCode == Keys.Left)
            {            
                int move = -60;

                if (_nowFrame + move <= 0) move = _nowFrame * -1;

                moveFrame(move);
            }
            if (e.Control && e.KeyCode == Keys.Right)
            {
                int move = 60;

                if (_nowFrame + move >= _video.FrameCount - 1) move = _video.FrameCount - 1 - _nowFrame;

                moveFrame(move);
            }
            else if (e.KeyCode == Keys.Left)
            {
                int move = -1;

                if (_nowFrame <= 0) return;

                moveFrame(move);
            }
            else if(e.KeyCode == Keys.Right)
            {
                int move = 1;

                if (_nowFrame >= _video.FrameCount - move) return;

                moveFrame(move);
            }
            else if (e.KeyCode.Equals(Keys.Space))
            {
                _isPlayer = !_isPlayer;

                if (_isPlayer)
                {
                    timer_player.Start();
                    this.btn_play.Image = _playButtonImage[1];
                }
            }
            else if (e.KeyCode.Equals(Keys.Enter))
            {
                if (_nowFrame < 0) return;

                _getFrame = _nowFrame;

                prgb_state.Maximum += _videoInfoList.Count * 2;

                foreach (FileInfo videoInfo in _videoInfoList)
                {
                    progressValue++;
                    Task.Run(() =>
                    {
                        Task task = getFrame(videoInfo);
                    });
                }
                setInfoText(_videoInfoList[0].DirectoryName + '\\' + "FrameInfo.txt", _getFrame.ToString());
                isGetFile = true;
            }
        }

        /// <summary>
        /// grid의 셀 이동을 막는다.
        /// </summary>
        private void grd_videoFileList_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter || e.KeyData == Keys.Up || e.KeyData == Keys.Down)
            {
                int column = grd_videoFileList.CurrentCell.ColumnIndex;
                int row = grd_videoFileList.CurrentCell.RowIndex;
                grd_videoFileList.CurrentCell = grd_videoFileList[column, row];
                e.Handled = true;
            }
        }
        #endregion
    }
}




