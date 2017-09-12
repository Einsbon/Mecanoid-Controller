using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using OpenJigWare;

namespace Mecanoid_Controller
{
    public partial class Form1 : Form
    {
        private Ojw.C3d c3d = new Ojw.C3d();
        private Ojw.CHerkulex2 motor = new Ojw.CHerkulex2();
        bool walking = false;
        bool mecanumMode = false;

        int mecanumSpd = 800;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStandPose_Click(object sender, EventArgs e)
        {
            motor.Close();
            c3d.m_CMotor.Connect(port, 115200);
            c3d.m_CMotor.DrvSrv(true, true);
            c3d.Motion_Play(@"D:\Mecanoid project\motions\stand.dmt", false);
            c3d.m_CMotor.DisConnect();
            mecanumMode = false;
            buttonHide();
        }

        private void btnWalkStraight_Click(object sender, EventArgs e)
        {
            //motor.Close();
            /*
            if (c3d.m_CMotor.Connect(10, 115200) == true)
            {
                c3d.m_CMotor.DrvSrv(true, true);
                walking = true;
                c3d.Motion_Play(@"D:\Mecanoid project\motions\walk_straight_start.dmt", true);
                while (walking)
                {
                    c3d.Motion_Play(@"D:\Mecanoid project\motions\walk_straight_walking.dmt", true);
                }
                c3d.Motion_Play(@"D:\Mecanoid project\motions\walk_straight_end.dmt", true);
                c3d.m_CMotor.DisConnect();
            }*/
            c3d.Motion_Play(@"D:\Mecanoid project\motions\walkStart.dmt", false);
            while (walking)
            {
                c3d.Motion_Play(@"D:\Mecanoid project\motions\walkWalking.dmt", false);
            }
            c3d.Motion_Play(@"D:\Mecanoid project\motions\walkEnd.dmt", false);
            //motor.Open(10, 115200);
        }

        private void btnWalkStop_Click(object sender, EventArgs e)
        {
            walking = false;
        }

        private void btnTrans1_Click(object sender, EventArgs e)
        {
            motor.Close();
            c3d.Motion_Play(@"D:\Mecanoid project\motions\transformingRight.dmt", false);
            c3d.m_CMotor.DisConnect();
            motor.Open(port, 115200);
            motor.SetTorque(true, true);
            mecanumMode = true;
            buttonHide();
        }

        private void btnTrans2_Click(object sender, EventArgs e)
        {
            motor.Close();
            c3d.m_CMotor.Connect(port, 115200);
            c3d.m_CMotor.DrvSrv(true, true);
            c3d.Motion_Play(@"D:\Mecanoid project\motions\transformingLeft2.dmt", false);
            mecanumMode = false;
            buttonHide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ojw.CMessage.Init(textBox1);
            c3d.Init(lbDisp);
            if(c3d.FileOpen(@"D:\Mecanoid project\ojw files\인버스 미완성 2.ojw") == true)
            {
                timer1.Enabled = true;
            }
            //motor.Open(10, 115200);
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
            motor.Set_Turn(32, mecanumSpd);
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

            motor.Set_Turn(31, -mecanumSpd);
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

            motor.Set_Turn(31, mecanumSpd);
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
            motor.Set_Turn(32, -mecanumSpd);
            motor.Set_Flag_Led(30, true, true, false);
            motor.Set_Flag_Led(31, true, true, false);
            motor.Set_Flag_Led(32, true, true, false);
            motor.Set_Flag_Led(33, true, true, false);

            motor.Send_Motor(100);
            motor.Wait_Delay(100);
        }

        private void btnStopMecanum_Click(object sender, EventArgs e)
        {
            c3d.m_CMotor2.Set_Turn(30, 0);
            c3d.m_CMotor2.Set_Turn(31, 0);
            c3d.m_CMotor2.Set_Turn(32, 0);
            c3d.m_CMotor2.Set_Turn(33, 0);
            c3d.m_CMotor2.Send_Motor(100);
            c3d.m_CMotor2.Wait_Delay(100);
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
            motor.SetTorque(false, false);
            motor.Close();
            c3d.m_CMotor.DisConnect();

            this.Dispose();
        }

        int port;
        private void btnConnect_Click(object sender, EventArgs e)
        {
            port = Convert.ToInt16(txtPort.Text);
            if(c3d.m_CMotor.Connect(port, 115200) == true)
            {
                c3d.m_CMotor.DrvSrv(true, true);
                mecanumMode = false;
                buttonHide();
            }
            else
            {
                MessageBox.Show("연결 실패. 연결 상태 또는 포트 번호를 확인하세요.");
            }
            //motor.Open(Convert.ToInt16(txtPort.Text), 115200);
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            motor.Close();
            c3d.m_CMotor.DisConnect();
        }

        private void btnWalkBack_Click(object sender, EventArgs e)
        {

        }

        private void btnTorqueOn_Click(object sender, EventArgs e)
        {
            c3d.m_CMotor.DrvSrv(true, true);
            motor.SetTorque(true, true);
        }

        private void btnTorqueOff_Click(object sender, EventArgs e)
        {
            c3d.m_CMotor.DrvSrv(false, false);
            motor.SetTorque(true, true);
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
            btnTrans1.Enabled = !mecanumMode;
            btnStopMecanum.Enabled = mecanumMode;

            btnWalkStraight.Enabled = !mecanumMode;
            btnWalkStop.Enabled = !mecanumMode;
            btnWalkLeft.Enabled = !mecanumMode;
            btnWalkRight.Enabled = !mecanumMode;
            btnWalkBack.Enabled = !mecanumMode;
            btnTrans2.Enabled = mecanumMode;
        }

        private void btnMecanumPose_Click(object sender, EventArgs e)
        {
            motor.Close();
            c3d.m_CMotor.Connect(port, 115200);
            c3d.Motion_Play(@"D:\Mecanoid project\motions\poseMecanum.dmt", false);
            c3d.m_CMotor.DisConnect();
            motor.Open(port, 115200);
            motor.SetTorque(true, true);
            mecanumMode = true;
            buttonHide();
        }
    }
}
