using System.Security.Cryptography.Xml;
using System.Media; //효과음

namespace CatchButton
{
    public partial class Form1 : Form
    {
        //3단계 - 점수 계산 변수
        int score = 0;

        // *4단계 - 게임 오버 출력을 위한 변수(20번 놓쳤을 때)
        int count = 0;

        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
            ButtonReset.Enabled = false;   // 처음에는 다시 시작 버튼 비활성화
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // *3단계 - 점수 계산
            score += 100; // 버튼 잡았을 때 점수 증가

            // *3단계 - 클릭 성공할 때마다 크기 10%씩 감소
            ButtonRun.Width = (int)(ButtonRun.Width * 0.9);
            ButtonRun.Height = (int)(ButtonRun.Height * 0.9);

            // *2단계 - 잡았을 때 효과음
            SystemSounds.Asterisk.Play();

            // *2단계 - 버튼 잡았을 때 축하 메시지 출력
            MessageBox.Show("축하합니다~!");

            //점수 출력
            this.Text = "점수 : " + score + ", 놓친 횟수 : " + count;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            // *1단계 - 기본 도망 기능
            //난수 생성기
            Random rd = new Random();


            //최대 이동 가능 좌표 계산
            //ClientSize는 폼의 타이틀 바와 테두리를 제외한 실제 흰 도화지 영역.
            int maxX = this.ClientSize.Width - ButtonRun.Width;
            int maxY = this.ClientSize.Height - ButtonRun.Height;

            //버튼의 새로운 위치 값 세팅
            int x_position = 100;
            int y_position = 150;

            // 버튼을 새로운 위치로 옮김 (새로운 Point 객체 생성)
            ButtonRun.Location = new Point(x_position, y_position);

            //랜덤 좌표 생성( 0 ~ 최대 이동 가능 좌표)
            int x = rd.Next(0, maxX);
            int y = rd.Next(0, maxY);

            ButtonRun.Location = new Point(x, y);   //버튼 위치 랜덤 이동

            score -= 10;    // *3단계
            count++;        // *4단계 - 놓친 횟수 증가

            this.Text = "버튼 위치 (" + x + ", " + y + ")";     //좌표 출력

            // *2단계 - 도망갈 때 효과음
            SystemSounds.Beep.Play();

            // *4단계 - 20번 놓치면 게임 오버 출력
            if (count >= 20)
            {
                MessageBox.Show("Game Over");

                ButtonRun.Enabled = false;
                ButtonReset.Enabled = true; //다시 시작 버튼 활성화
            }
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            score = 0; //점수 초기화
            count = 0; //놓친 횟수 초기화

            //버튼 크기 초기화 336 147
            ButtonRun.Width = 336;
            ButtonRun.Height = 147;

            
            ButtonRun.Enabled = true; //잡기 버튼 활성화
            ButtonReset.Enabled = false;   // 다시 시작 버튼 다시 비활성화

            ButtonRun.Location = new Point(100, 150); //버튼 위치 초기화

            this.Text = "점수: " + 0 + ", 놓친 횟수: " + 0;
        }
    }
}
