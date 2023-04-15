namespace Flappy_Bird
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    
        int gravity = 10;//trọng lực của con chim
        int score = 0;//điểm 
        int speed = 20;//tốc độ 

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {        
            if(e.KeyCode == Keys.Space)//khi nhả nút space
            {
                gravity = 20;//lúc này con chim rơi xuống
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            timer1.Start();//bắt đầu trò chơi
            if (e.KeyCode==Keys.Space)//khi nhấn nút space (không nhả ra)
            {
                gravity = -20;//lúc này com chim bay lên
            }
          
        }
        Random rnd= new Random();   
        private void timer1_Tick(object sender, EventArgs e)
        {
            bird.Top += gravity;//con chim sẽ đi lên hoặc xuống

            //dùng "Left" để dịch chuyển ảnh sang trái
             pipeDown.Left -= speed;
            pipeTop.Left-= speed;
            weather.Left-= speed;

            //Tăng điểm 
            lblScore.Text = $"Score: {score}";
           
            int x = rnd.Next(400,800);
            if (pipeDown.Left < -(82 + 75))//nếu dịch trái mà <(kích thước bird + pipe)           
            {               
                pipeDown.Left = x;//tạo ra pipeDown ngẫu nhiên
                weather.Left = rnd.Next(Math.Min(x+100,200),Math.Max(x+100,200));
                score++;
            }

            if (pipeTop.Left < -(82 + 75))
            {               
                pipeTop.Left = x ;
                score++;    
            }

            //Điểm lớn hơn 5 tăng tốc độ lên
            if (score > 5) speed += 2;

            //End game: 
            /*
             * khi chạm pipeTop or pipeDown, chạm ground, bay lên nóc
             */
            if(bird.Bounds.IntersectsWith(pipeDown.Bounds)||
                bird.Bounds.IntersectsWith(pipeTop.Bounds)||
                bird.Bounds.IntersectsWith(ground.Bounds)||
                bird.Top<-25)
            {
                timer1.Stop();//dừng game
                MessageBox.Show($"Score: {score} Game Over");//thông báo ra điểm 
            }
        }
    }
}