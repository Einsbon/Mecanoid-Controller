using OpenJigWare;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Mecanoid_Controller
{
    public partial class Form1 : Form
    {
        private Ojw.C3d c3d = new Ojw.C3d();
        private Ojw.CHerkulex2 motor = new Ojw.CHerkulex2();
        bool walking = false;
        bool mecanumMode = false;

        int mecanumSpd = 1000;
        double mecanumAdd = 1.8;
        double mecanumAdd2 = 2.5;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStandPose_Click(object sender, EventArgs e)
        {
            Ojw.CMessage.Write("선 동작");
            motor.Close();
            c3d.m_CMotor.Connect(port, 115200);
            c3d.m_CMotor.DrvSrv(true, true);
            //c3d.Motion_Play(@"D:\Mecanoid project\motions\stand2Slow.dmt", false);
            c3d.Motion_Play(@"motions\stand2Slow.dmt", false);
            mecanumMode = false;
            buttonHide();
        }

        private void btnWalkStraight_Click(object sender, EventArgs e)
        {/*
            walking = true;
            c3d.Motion_Play(@"D:\Mecanoid project\motions\walkStart.dmt", false);
            while (walking)
            {
                c3d.Motion_Play(@"D:\Mecanoid project\motions\walkWalking.dmt", false);
            }
            c3d.Motion_Play(@"D:\Mecanoid project\motions\walkEnd.dmt", false);
            */
            buttonWorking(false);
            Ojw.CMessage.Write("앞으로 걷기 시작");
            walking = true;
            c3d.Motion_Play(@"motions\walkStartRight2.dmt", false);
            bool rightStep = true;
            while (walking)
            {
                if (rightStep == true)
                {
                    c3d.Motion_Play(@"motions\walkWalkingLeft2.dmt", false);
                    rightStep = false;
                }
                else
                {
                    c3d.Motion_Play(@"motions\walkWalkingRight2.dmt", false);
                    rightStep = true;
                }
            }
            if (rightStep == true)
            {
                c3d.Motion_Play(@"motions\walkEndLeft2.dmt", false);
            }
            else
            {
                c3d.Motion_Play(@"motions\walkEndRight2.dmt", false);
            }//stand2Quick
            c3d.Motion_Play(@"motions\stand2.dmt", false);
            buttonWorking(true);
            Ojw.CMessage.Write("앞으로 걷기 종료");
        }

        private void btnWalkStop_Click(object sender, EventArgs e)
        {
            Ojw.CMessage.Write("걸음 정지");
            walking = false;
        }

        private void btnTrans1_Click(object sender, EventArgs e)
        {
            buttonAllHide();
            Ojw.CMessage.Write("메카넘 모드로 트랜스포밍");
            motor.Close();
            c3d.Motion_Play(@"motions\transformingRightQuick.dmt", true);
            c3d.m_CMotor.DisConnect();
            motor.Open(port, 115200);
            motor.SetTorque(true, true);
            mecanumMode = true;
            buttonHide();
        }

        private void btnTrans2_Click(object sender, EventArgs e)
        {
            buttonAllHide();
            Ojw.CMessage.Write("보행 모드로 트랜스포밍");
            motor.Close(); 
            c3d.m_CMotor.Connect(port, 115200);
            c3d.m_CMotor.DrvSrv(true, true);
            c3d.Motion_Play(@"motions\transformingLeft2.dmt", false);
            c3d.Motion_Play(@"motions\stand2.dmt", false);
            mecanumMode = false;
            buttonHide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //buttonAllHide();
            Ojw.CMessage.Init(textBox1);
            c3d.Init(lbDisp);
            if (c3d.FileOpen(@"ojw files\mecanoid.ojw") == true)
            {
                timer1.Enabled = true;
            }
            else
            {
                MessageBox.Show("모델 불러오기 실패");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            c3d.OjwDraw();
        }

        //앞
        private void btnF_Click(object sender, EventArgs e)
        {
            motor.SetTorque(true, true);

            motor.Set_Turn(30, -mecanumSpd);
            motor.Set_Turn(31, -mecanumSpd);
            motor.Set_Turn(32, mecanumSpd);
            motor.Set_Turn(33, mecanumSpd);
            motor.Set_Flag_Led(30, true, true, false);
            motor.Set_Flag_Led(31, true, true, false);
            motor.Set_Flag_Led(32, true, true, false);
            motor.Set_Flag_Led(33, true, true, false);

            motor.Send_Motor(100);
            Ojw.CMessage.Write("메카넘휠 앞으로");
            motor.Wait_Delay(100);
        }

        //오른쪽
        private void btnR_Click(object sender, EventArgs e)
        {
            motor.SetTorque(true, true);

            motor.Set_Turn(30, mecanumSpd);
            motor.Set_Turn(31, -mecanumSpd);
            motor.Set_Turn(32, -mecanumSpd);
            motor.Set_Turn(33, mecanumSpd);
            motor.Set_Flag_Led(30, true, true, false);
            motor.Set_Flag_Led(31, true, true, false);
            motor.Set_Flag_Led(32, true, true, false);
            motor.Set_Flag_Led(33, true, true, false);

            motor.Send_Motor(100);
            Ojw.CMessage.Write("메카넘휠 오른쪽");
            motor.Wait_Delay(100);
        }

        //뒤
        private void btnB_Click(object sender, EventArgs e)
        {
            motor.SetTorque(true, true);

            motor.Set_Turn(30, mecanumSpd);
            motor.Set_Turn(31, mecanumSpd);
            motor.Set_Turn(32, -mecanumSpd);
            motor.Set_Turn(33, -mecanumSpd);
            motor.Set_Flag_Led(30, true, true, false);
            motor.Set_Flag_Led(31, true, true, false);
            motor.Set_Flag_Led(32, true, true, false);
            motor.Set_Flag_Led(33, true, true, false);

            motor.Send_Motor(100);
            Ojw.CMessage.Write("메카넘휠 뒤로");
            motor.Wait_Delay(100);
        }

        //왼쪽
        private void btnL_Click(object sender, EventArgs e)
        {
            motor.SetTorque(true, true);

            motor.Set_Turn(30, -mecanumSpd);
            motor.Set_Turn(31, mecanumSpd);
            motor.Set_Turn(32, mecanumSpd);
            motor.Set_Turn(33, -mecanumSpd);
            motor.Set_Flag_Led(30, true, true, false);
            motor.Set_Flag_Led(31, true, true, false);
            motor.Set_Flag_Led(32, true, true, false);
            motor.Set_Flag_Led(33, true, true, false);

            motor.Send_Motor(100);
            Ojw.CMessage.Write("메카넘휠 왼쪽");
            motor.Wait_Delay(100);
        }

        private void btnTurnL_Click(object sender, EventArgs e)
        {
            motor.SetTorque(true, true);

            motor.Set_Turn(30, -mecanumSpd);
            motor.Set_Turn(31, -mecanumSpd);
            motor.Set_Turn(32, -mecanumSpd);
            motor.Set_Turn(33, -mecanumSpd);
            motor.Set_Flag_Led(30, true, true, false);
            motor.Set_Flag_Led(31, true, true, false);
            motor.Set_Flag_Led(32, true, true, false);
            motor.Set_Flag_Led(33, true, true, false);

            motor.Send_Motor(100);
            motor.Wait_Delay(100);
        }

        private void btnTurnR_Click(object sender, EventArgs e)
        {
            motor.SetTorque(true, true);

            motor.Set_Turn(30, mecanumSpd);
            motor.Set_Turn(31, mecanumSpd);
            motor.Set_Turn(32, mecanumSpd);
            motor.Set_Turn(33, mecanumSpd);
            motor.Set_Flag_Led(30, true, true, false);
            motor.Set_Flag_Led(31, true, true, false);
            motor.Set_Flag_Led(32, true, true, false);
            motor.Set_Flag_Led(33, true, true, false);

            motor.Send_Motor(100);
            motor.Wait_Delay(100);
        }

        private void btnFL_Click(object sender, EventArgs e)
        {
            motor.SetTorque(true, true);

            motor.Set_Turn(30, -mecanumSpd);
            motor.Set_Turn(31, 0);
            motor.Set_Turn(32, mecanumSpd);
            motor.Set_Turn(33, 0);
            motor.Set_Flag_Led(30, true, true, false);
            motor.Set_Flag_Led(31, true, true, false);
            motor.Set_Flag_Led(32, true, true, false);
            motor.Set_Flag_Led(33, true, true, false);

            motor.Send_Motor(100);
            motor.Wait_Delay(100);
        }

        private void btnFR_Click(object sender, EventArgs e)
        {
            motor.SetTorque(true, true);

            motor.Set_Turn(30, 0);
            motor.Set_Turn(31, -mecanumSpd);
            motor.Set_Turn(32, 0);
            motor.Set_Turn(33, mecanumSpd);
            motor.Set_Flag_Led(30, true, true, false);
            motor.Set_Flag_Led(31, true, true, false);
            motor.Set_Flag_Led(32, true, true, false);
            motor.Set_Flag_Led(33, true, true, false);

            motor.Send_Motor(100);
            motor.Wait_Delay(100);
        }

        private void btnBL_Click(object sender, EventArgs e)
        {
            motor.SetTorque(true, true);

            motor.Set_Turn(30, 0);
            motor.Set_Turn(31, mecanumSpd);
            motor.Set_Turn(32, 0);
            motor.Set_Turn(33, -mecanumSpd);
            motor.Set_Flag_Led(30, true, true, false);
            motor.Set_Flag_Led(31, true, true, false);
            motor.Set_Flag_Led(32, true, true, false);
            motor.Set_Flag_Led(33, true, true, false);

            motor.Send_Motor(100);
            motor.Wait_Delay(100);
        }

        private void btnBR_Click(object sender, EventArgs e)
        {
            motor.SetTorque(true, true);

            motor.Set_Turn(30, mecanumSpd);
            motor.Set_Turn(31, 0);
            motor.Set_Turn(32, -mecanumSpd);
            motor.Set_Turn(33, 0);
            motor.Set_Flag_Led(30, true, true, false);
            motor.Set_Flag_Led(31, true, true, false);
            motor.Set_Flag_Led(32, true, true, false);
            motor.Set_Flag_Led(33, true, true, false);

            motor.Send_Motor(100);
            motor.Wait_Delay(100);
        }

        private void btnStopMecanum_Click(object sender, EventArgs e)
        {
            motor.Set_Turn(30, 0);
            motor.Set_Turn(31, 0);
            motor.Set_Turn(32, 0);
            motor.Set_Turn(33, 0);
            motor.Set_Flag_Led(30, false, false, false);
            motor.Set_Flag_Led(31, false, false, false);
            motor.Set_Flag_Led(32, false, false, false);
            motor.Set_Flag_Led(33, false, false, false);

            motor.Send_Motor(100);
            Ojw.CMessage.Write("메카넘휠 정지");
            motor.Wait_Delay(100);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            motor.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            motor.Close();
            c3d.m_CMotor.DisConnect();

            this.Dispose();
        }

        int port;
        private void btnConnect_Click(object sender, EventArgs e)
        {
            port = Convert.ToInt16(txtPort.Text);
            if (c3d.m_CMotor.Connect(port, 115200) == true)
            {
                Ojw.CMessage.Write("연결 성공");

                c3d.m_CMotor.DrvSrv(true, true);
                mecanumMode = false;
                buttonHide();
                btnStandPose.Enabled = true;
                btnStandTall.Enabled = true;
                btnMecanumPose.Enabled = true;
                btnDisconnect.Enabled = true;
                btnTorqueOn.Enabled = true;
                btnTorqueOff.Enabled = true;
            }
            else
            {
                MessageBox.Show("연결 실패. 연결 상태 또는 포트 번호를 확인하세요.");
            }
            //motor.Open(Convert.ToInt16(txtPort.Text), 115200);
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            c3d.m_CMotor.DrvSrv(false, false);
            motor.SetTorque(true, true);
            motor.Close();
            c3d.m_CMotor.DisConnect();
        }

        private void btnWalkBack_Click(object sender, EventArgs e)
        {
            Ojw.CMessage.Write("뒤로 걷기");
            buttonWorking(false);
            walking = true;
            c3d.Motion_Play(@"motions\walkBackStartR.dmt", false);
            bool rightStep = true;
            while (walking)
            {
                if (rightStep == true)
                {
                    c3d.Motion_Play(@"motions\walkBackWalkingL.dmt", false);
                    rightStep = false;
                }
                else
                {
                    c3d.Motion_Play(@"motions\walkBackWalkingR.dmt", false);
                    rightStep = true;
                }
            }
            if (rightStep == true)
            {
                c3d.Motion_Play(@"motions\walkBackEndL.dmt", false);
            }
            else
            {
                c3d.Motion_Play(@"motions\walkBackEndR.dmt", false);
            }
            c3d.Motion_Play(@"motions\stand2.dmt", false);
            buttonWorking(true);
        }

        private void btnTorqueOn_Click(object sender, EventArgs e)
        {
            c3d.m_CMotor.DrvSrv(true, true);
            motor.SetTorque(true, true);
        }

        private void btnTorqueOff_Click(object sender, EventArgs e)
        {
            c3d.m_CMotor.DrvSrv(false, false);
            motor.SetTorque(false, false);
        }

        private void buttonHide()
        {
            btnB.Enabled = mecanumMode;
            btnBL.Enabled = mecanumMode;
            btnBR.Enabled = mecanumMode;
            btnF.Enabled = mecanumMode;
            btnFL.Enabled = mecanumMode;
            btnFR.Enabled = mecanumMode;
            btnL.Enabled = mecanumMode;
            btnR.Enabled = mecanumMode;
            btnTurnL.Enabled = mecanumMode;
            btnTurnR.Enabled = mecanumMode;
            btnStopMecanum.Enabled = mecanumMode;
            btnTrans2.Enabled = mecanumMode;

            btnTrans1.Enabled = !mecanumMode;
            btnWalkStraight.Enabled = !mecanumMode;
            btnWalkStop.Enabled = !mecanumMode;
            btnWalkLeft.Enabled = !mecanumMode;
            btnWalkRight.Enabled = !mecanumMode;
            btnWalkBack.Enabled = !mecanumMode;

            btnTorqueOff.Enabled = true;
            btnTorqueOn.Enabled = true;
        }

        private void buttonAllHide()
        {
            btnB.Enabled = false;
            btnBL.Enabled = false;
            btnBR.Enabled = false;
            btnF.Enabled = false;
            btnFL.Enabled = false;
            btnFR.Enabled = false;
            btnL.Enabled = false;
            btnR.Enabled = false;
            btnTurnL.Enabled = false;
            btnTurnR.Enabled = false;
            btnTrans1.Enabled = false;
            btnStopMecanum.Enabled = false;
            btnStandTall.Enabled = false;

            btnWalkStraight.Enabled = false;
            btnWalkStop.Enabled = false;
            btnWalkLeft.Enabled = false;
            btnWalkRight.Enabled = false;
            btnWalkBack.Enabled = false;
            btnTrans2.Enabled = false;

            btnTorqueOff.Enabled = false;
            btnTorqueOn.Enabled = false;
            btnStandPose.Enabled = false;
            btnMecanumPose.Enabled = false;
            btnDisconnect.Enabled = false;
        }

        private void buttonJoyHide()
        {
            btnB.Enabled = false;
            btnBL.Enabled = false;
            btnBR.Enabled = false;
            btnF.Enabled = false;
            btnFL.Enabled = false;
            btnFR.Enabled = false;
            btnL.Enabled = false;
            btnR.Enabled = false;
            btnTurnL.Enabled = false;
            btnTurnR.Enabled = false;
            btnTrans1.Enabled = false;
            btnStopMecanum.Enabled = false;
            btnStandTall.Enabled = false;

            btnWalkStraight.Enabled = false;
            btnWalkStop.Enabled = false;
            btnWalkLeft.Enabled = false;
            btnWalkRight.Enabled = false;
            btnWalkBack.Enabled = false;
            btnTrans2.Enabled = false;


            btnStandPose.Enabled = false;
            btnMecanumPose.Enabled = false;
            btnDisconnect.Enabled = false;
        }

        private void buttonWorking(bool aa)
        {
            btnWalkStraight.Enabled = aa;
            btnWalkLeft.Enabled = aa;
            btnWalkRight.Enabled = aa;
            btnWalkBack.Enabled = aa;
            btnStandTall.Enabled = aa;
            btnStandPose.Enabled = aa;
            btnMecanumPose.Enabled = aa;
            btnTrans1.Enabled = aa;
        }

        private void btnMecanumPose_Click(object sender, EventArgs e)
        {
            Ojw.CMessage.Write("메카넘 포즈");
            motor.Close();
            c3d.m_CMotor.Connect(port, 115200);
            c3d.Motion_Play(@"motions\poseMecanum.dmt", false);
            c3d.m_CMotor.DisConnect();
            motor.Open(port, 115200);
            motor.SetTorque(true, true);
            mecanumMode = true;
            buttonHide();
        }

        private void btnWalkRight_Click(object sender, EventArgs e)
        {
            Ojw.CMessage.Write("오른쪽으로 걷기 시작");
            buttonWorking(false);
            walking = true;
            c3d.Motion_Play(@"motions\turnRightStart.dmt", false);
            while (walking)
            {
                c3d.Motion_Play(@"motions\turnRightWalking.dmt", false);
            }
            c3d.Motion_Play(@"motions\turnRightEnd.dmt", false);
            c3d.Motion_Play(@"motions\stand2.dmt", false);
            Ojw.CMessage.Write("오른쪽으로 걷기 종료");
            buttonWorking(true);
        }

        private void btnWalkLeft_Click(object sender, EventArgs e)
        {
            Ojw.CMessage.Write("왼쪽으로 걷기 시작");
            buttonWorking(false);
            walking = true;
            c3d.Motion_Play(@"motions\turnLeftStart.dmt", false);
            while (walking)
            {
                c3d.Motion_Play(@"motions\turnLeftWalking.dmt", false);
            }
            c3d.Motion_Play(@"motions\turnLeftEnd.dmt", false);
            c3d.Motion_Play(@"motions\stand2.dmt", false);
            Ojw.CMessage.Write("왼쪽으로 걷기 종료");
            buttonWorking(true);
        }

        private void btnStandTall_Click(object sender, EventArgs e)
        {
            Ojw.CMessage.Write("선 동작");
            motor.Close();
            c3d.m_CMotor.Connect(port, 115200);
            c3d.m_CMotor.DrvSrv(true, true);
            //c3d.Motion_Play(@"D:\Mecanoid project\motions\stand2Slow.dmt", false);
            c3d.Motion_Play(@"motions\stand3Slow.dmt", false);
            mecanumMode = false;
            buttonHide();
        }

        private Ojw.CJoystick m_CJoy = new Ojw.CJoystick(Ojw.CJoystick._ID_0); // 조이스틱 선언
        private Ojw.CTimer m_CTmr_Joystick = new Ojw.CTimer(); // 조이스틱의 연결을 주기적으로 체크할 타이머

        private void timer2_Tick(object sender, EventArgs e)
        {
            // 조이스틱 정보 갱신
            m_CJoy.Update();
            // 조이스틱이 살아 있는지 체크하는 함수
            FJoystick_Check_Alive();
            if (useJoystck)
            {
                // 조이스틱 데이타 체크
                FJoystick_Check_Data();
            }
        }

        private void FJoystick_Check_Alive()
        {
            #region Joystick Check

            Color m_colorLive = Color.Green; // 살았을 경우의 색
            Color m_colorDead = Color.Gray; // 죽었을 경우의 색
            if (m_CJoy.IsValid == false)
            {
                #region 조이스틱이 연결되지 않았음을 표시
                if (lbJoystick.ForeColor != m_colorDead)
                {
                    lbJoystick.Text = "조이스틱: 연결 안됨";
                    lbJoystick.ForeColor = m_colorDead;
                }
                #endregion 조이스틱이 연결되지 않았음을 표시
                checkBoxGamepad.Checked = false;
                checkBoxGamepad.Enabled = false;
                timer2.Interval = 1000;

                #region 2초마다 다시 재연결을 하려고 시도
                if (m_CTmr_Joystick.Get() > 2000) // Joystic 이 죽어있다면 체크(2초단위)
                {
                    Ojw.CMessage.Write("Joystick Check again");
                    m_CJoy = new Ojw.CJoystick(Ojw.CJoystick._ID_0);

                    if (m_CJoy.IsValid == false)
                    {
                        Ojw.CMessage.Write("But we can't find a joystick device in here. Check your joystick device");
                        m_CTmr_Joystick.Set(); // 타이머의 카운터를 다시 초기화 한다.
                    }
                    else Ojw.CMessage.Write("Joystick is Connected");
                }
                #endregion 3초마다 다시 재연결을 하려고 시도
            }
            else
            {
                #region 연결 되었음을 표시
                if (lbJoystick.ForeColor != m_colorLive)
                {
                    lbJoystick.Text = "조이스틱: 연결 됨";
                    lbJoystick.ForeColor = m_colorLive;
                }
                #endregion 연결 되었음을 표시
                
                checkBoxGamepad.Enabled = true;
                timer2.Interval = 50;
            }
            #endregion Joystick Check
        }

        
        private void FJoystick_Check_Data()
        {
            double mecFB = 0;
            double mecRL = 0;
            double mecT = 0;
            int inside = 0;
            bool light = false;
            if (mecanumMode == true)//메카넘모드일때
            {

                if((m_CJoy.dX1 - 0.5) * (m_CJoy.dX1 - 0.5) + (m_CJoy.dY1 - 0.5) * (m_CJoy.dY1 - 0.5) > 1)
                {
                    //mecFB = (-(m_CJoy.dY1 - 0.5) / Math.Sqrt((m_CJoy.dX1 - 0.5) * (m_CJoy.dX1 - 0.5) + (m_CJoy.dY1 - 0.5) * (m_CJoy.dY1 - 0.5))) * mecanumSpd * mecanumAdd;
                    //mecRL = ((m_CJoy.dX1 - 0.5) / Math.Sqrt((m_CJoy.dX1 - 0.5) * (m_CJoy.dX1 - 0.5) + (m_CJoy.dY1 - 0.5) * (m_CJoy.dY1 - 0.5))) * mecanumSpd * mecanumAdd;
                    //light = true;
                }
                else
                {
                    if (m_CJoy.dY1 > 0.53 | m_CJoy.dY1 < 0.47)
                    {
                        mecFB = -(m_CJoy.dY1 - 0.5) * mecanumSpd * mecanumAdd;
                        light = true;
                    }
                    if (m_CJoy.dX1 > 0.53 | m_CJoy.dX1 < 0.47)
                    {
                        mecRL = (m_CJoy.dX1 - 0.5) * mecanumSpd * mecanumAdd;
                        light = true;
                    }
                }
                /*if (m_CJoy.dX0 > 0.55 | m_CJoy.dX0 < 0.45)
                {
                    mecT = (m_CJoy.dX0 - 0.5) * mecanumSpd * mecanumAdd;
                    light = true;
                }*/
                if (m_CJoy.Slide>0.53 | m_CJoy.Slide < 0.47)
                {
                    mecT = -(m_CJoy.Slide - 0.5) * mecanumSpd * mecanumAdd;
                    light = true;
                }
                if (m_CJoy.dX0 > 0.53 | m_CJoy.dX0 < 0.47| m_CJoy.dY0 > 0.53 | m_CJoy.dY0 < 0.47)
                {
                    mecFB = -(m_CJoy.dY0 - 0.5) * mecanumSpd * mecanumAdd2;
                    mecT = (m_CJoy.dX0 - 0.5) * mecanumSpd * mecanumAdd2;
                    light = true;
                    /*if (mecFB < 0)
                    {
                        mecT = -mecT;
                    }*/
                }

                if (m_CJoy.IsDown(Ojw.CJoystick.PadKey.Button1) == true)
                {
                    // A   보정 기능
                    inside = 150;
                }

                motor.Set_Turn(30, (int)(-mecFB + mecRL + mecT - inside));
                motor.Set_Turn(31, (int)(-mecFB - mecRL + mecT + (2 * inside)));
                motor.Set_Turn(32, (int)(mecFB - mecRL + mecT - (2 * inside)));
                motor.Set_Turn(33, (int)(mecFB + mecRL + mecT + inside));

                motor.Set_Flag_Led(30, light, light, false);
                motor.Set_Flag_Led(31, light, light, false);
                motor.Set_Flag_Led(32, light, light, false);
                motor.Set_Flag_Led(33, light, light, false);

                motor.Send_Motor(10);
                motor.Wait_Delay(10);
            }
            else//걷기모드일때
            {
                if (!walking)
                {
                    if (m_CJoy.IsDown_Event(Ojw.CJoystick.PadKey.POVUp) == true) //위 버튼
                    {
                        btnWalkStraight_Click(null, null);
                    }
                    else if (m_CJoy.IsDown_Event(Ojw.CJoystick.PadKey.POVDown) == true) //아래 버튼
                    {
                        btnWalkBack_Click(null, null);
                    }
                    else if (m_CJoy.IsDown_Event(Ojw.CJoystick.PadKey.POVRight) == true)
                    {
                        btnWalkRight_Click(null, null);
                    }
                    else if (m_CJoy.IsDown_Event(Ojw.CJoystick.PadKey.POVLeft) == true)
                    {
                        btnWalkLeft_Click(null, null);
                    }
                }
                if (m_CJoy.IsDown_Event(Ojw.CJoystick.PadKey.Button2) == true)
                {
                    btnWalkStop_Click(null, null);
                }
            }

            if (m_CJoy.IsDown_Event(Ojw.CJoystick.PadKey.Button5) == true) // 보행 모드
            {
                if (mecanumMode == true) //메카넘 모드일때
                {
                    btnTrans2_Click(null, null);
                }
                else
                {
                    btnStandPose_Click(null, null);
                }
            }

            if (m_CJoy.IsDown_Event(Ojw.CJoystick.PadKey.Button6) == true) // 메카넘 모드 버튼
            {
                if (mecanumMode == false) //보행 모드일때
                {
                    btnTrans1_Click(null, null);
                }
                else
                {
                    btnMecanumPose_Click(null, null);
                }
            }
            if (m_CJoy.IsDown_Event(Ojw.CJoystick.PadKey.Button7) == true)
            {
                // BACK
                c3d.m_CMotor.DrvSrv(false, false);
                motor.SetTorque(false, false);
            }
            if (m_CJoy.IsDown_Event(Ojw.CJoystick.PadKey.Button8) == true)
            {
                // START
                c3d.m_CMotor.DrvSrv(true, true);
                motor.SetTorque(true, true);

            }
        }

        bool useJoystck = false;
        private void checkBoxGamepad_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxGamepad.Checked == true)
            {
                useJoystck = true;
            }
            else
            {
                useJoystck = false;
            }
        }

        private void btnTorqueOff2_Click(object sender, EventArgs e)
        {
            c3d.m_CMotor.DrvSrv(true, false);
            motor.SetTorque(true, false);
        }
    }
}
