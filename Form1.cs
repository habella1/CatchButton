using System.Security.Cryptography.Xml;
using System.Media; //효과음

namespace CatchButton
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 잡았을 때 효과음
            SystemSounds.Asterisk.Play();

            // 메시지 박스
            MessageBox.Show("축하합니다~!");
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

            //새로운 위치 값 세팅
            int x_position = 100;
            int y_position = 150;

            // 버튼을 새로운 위치로 옮김 (새로운 Point 객체 생성)
            ButtonRun.Location = new Point(x_position, y_position);
            
            //랜덤 좌표 ( 0 ~ 최대 이동 가능 좌표)
            int x = rd.Next(0, maxX);
            int y = rd.Next(0, maxY);

            //버튼 위치 이동
            ButtonRun.Location = new Point(x, y);

            //좌표 출력
            this.Text = "버튼 위치 (" + x + ", " + y + ")";

            // *2단계 - 도망갈 때 효과음
            SystemSounds.Beep.Play();


        }
    }
}
