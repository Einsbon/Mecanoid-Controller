namespace Mecanoid_Controller
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnF = new System.Windows.Forms.Button();
            this.btnL = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.btnFL = new System.Windows.Forms.Button();
            this.btnFR = new System.Windows.Forms.Button();
            this.btnBL = new System.Windows.Forms.Button();
            this.btnBR = new System.Windows.Forms.Button();
            this.btnStopMecanum = new System.Windows.Forms.Button();
            this.btnTurnL = new System.Windows.Forms.Button();
            this.btnTurnR = new System.Windows.Forms.Button();
            this.btnWalkStraight = new System.Windows.Forms.Button();
            this.btnWalkStop = new System.Windows.Forms.Button();
            this.btnWalkLeft = new System.Windows.Forms.Button();
            this.btnWalkRight = new System.Windows.Forms.Button();
            this.btnTrans1 = new System.Windows.Forms.Button();
            this.lbDisp = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnTrans2 = new System.Windows.Forms.Button();
            this.btnWalkBack = new System.Windows.Forms.Button();
            this.btnStandPose = new System.Windows.Forms.Button();
            this.btnTorqueOn = new System.Windows.Forms.Button();
            this.btnTorqueOff = new System.Windows.Forms.Button();
            this.btnMecanumPose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnF
            // 
            this.btnF.Location = new System.Drawing.Point(793, 13);
            this.btnF.Margin = new System.Windows.Forms.Padding(4);
            this.btnF.Name = "btnF";
            this.btnF.Size = new System.Drawing.Size(90, 90);
            this.btnF.TabIndex = 0;
            this.btnF.Text = "앞";
            this.btnF.UseVisualStyleBackColor = true;
            this.btnF.Click += new System.EventHandler(this.btnF_Click);
            // 
            // btnL
            // 
            this.btnL.Location = new System.Drawing.Point(695, 111);
            this.btnL.Margin = new System.Windows.Forms.Padding(4);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(90, 90);
            this.btnL.TabIndex = 1;
            this.btnL.Text = "왼쪽";
            this.btnL.UseVisualStyleBackColor = true;
            this.btnL.Click += new System.EventHandler(this.btnL_Click);
            // 
            // btnB
            // 
            this.btnB.Location = new System.Drawing.Point(793, 209);
            this.btnB.Margin = new System.Windows.Forms.Padding(4);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(90, 90);
            this.btnB.TabIndex = 2;
            this.btnB.Text = "뒤";
            this.btnB.UseVisualStyleBackColor = true;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnR
            // 
            this.btnR.Location = new System.Drawing.Point(891, 111);
            this.btnR.Margin = new System.Windows.Forms.Padding(4);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(90, 90);
            this.btnR.TabIndex = 3;
            this.btnR.Text = "오른쪽";
            this.btnR.UseVisualStyleBackColor = true;
            this.btnR.Click += new System.EventHandler(this.btnR_Click);
            // 
            // btnFL
            // 
            this.btnFL.Location = new System.Drawing.Point(695, 13);
            this.btnFL.Margin = new System.Windows.Forms.Padding(4);
            this.btnFL.Name = "btnFL";
            this.btnFL.Size = new System.Drawing.Size(90, 90);
            this.btnFL.TabIndex = 4;
            this.btnFL.Text = "대각선";
            this.btnFL.UseVisualStyleBackColor = true;
            this.btnFL.Click += new System.EventHandler(this.btnFL_Click);
            // 
            // btnFR
            // 
            this.btnFR.Location = new System.Drawing.Point(891, 13);
            this.btnFR.Margin = new System.Windows.Forms.Padding(4);
            this.btnFR.Name = "btnFR";
            this.btnFR.Size = new System.Drawing.Size(90, 90);
            this.btnFR.TabIndex = 5;
            this.btnFR.Text = "대각선";
            this.btnFR.UseVisualStyleBackColor = true;
            this.btnFR.Click += new System.EventHandler(this.btnFR_Click);
            // 
            // btnBL
            // 
            this.btnBL.Location = new System.Drawing.Point(695, 209);
            this.btnBL.Margin = new System.Windows.Forms.Padding(4);
            this.btnBL.Name = "btnBL";
            this.btnBL.Size = new System.Drawing.Size(90, 90);
            this.btnBL.TabIndex = 6;
            this.btnBL.Text = "대각선";
            this.btnBL.UseVisualStyleBackColor = true;
            this.btnBL.Click += new System.EventHandler(this.btnBL_Click);
            // 
            // btnBR
            // 
            this.btnBR.Location = new System.Drawing.Point(891, 209);
            this.btnBR.Margin = new System.Windows.Forms.Padding(4);
            this.btnBR.Name = "btnBR";
            this.btnBR.Size = new System.Drawing.Size(90, 90);
            this.btnBR.TabIndex = 7;
            this.btnBR.Text = "대각선";
            this.btnBR.UseVisualStyleBackColor = true;
            this.btnBR.Click += new System.EventHandler(this.btnBR_Click);
            // 
            // btnStopMecanum
            // 
            this.btnStopMecanum.Location = new System.Drawing.Point(793, 111);
            this.btnStopMecanum.Margin = new System.Windows.Forms.Padding(4);
            this.btnStopMecanum.Name = "btnStopMecanum";
            this.btnStopMecanum.Size = new System.Drawing.Size(90, 90);
            this.btnStopMecanum.TabIndex = 10;
            this.btnStopMecanum.Text = "정지";
            this.btnStopMecanum.UseVisualStyleBackColor = true;
            this.btnStopMecanum.Click += new System.EventHandler(this.btnStopMecanum_Click);
            // 
            // btnTurnL
            // 
            this.btnTurnL.Location = new System.Drawing.Point(695, 308);
            this.btnTurnL.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTurnL.Name = "btnTurnL";
            this.btnTurnL.Size = new System.Drawing.Size(138, 74);
            this.btnTurnL.TabIndex = 8;
            this.btnTurnL.Text = "반시계방향 회전";
            this.btnTurnL.UseVisualStyleBackColor = true;
            this.btnTurnL.Click += new System.EventHandler(this.btnTurnL_Click);
            // 
            // btnTurnR
            // 
            this.btnTurnR.Location = new System.Drawing.Point(843, 308);
            this.btnTurnR.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTurnR.Name = "btnTurnR";
            this.btnTurnR.Size = new System.Drawing.Size(138, 73);
            this.btnTurnR.TabIndex = 9;
            this.btnTurnR.Text = "시계방향 회전";
            this.btnTurnR.UseVisualStyleBackColor = true;
            this.btnTurnR.Click += new System.EventHandler(this.btnTurnR_Click);
            // 
            // btnWalkStraight
            // 
            this.btnWalkStraight.Location = new System.Drawing.Point(103, 132);
            this.btnWalkStraight.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnWalkStraight.Name = "btnWalkStraight";
            this.btnWalkStraight.Size = new System.Drawing.Size(122, 69);
            this.btnWalkStraight.TabIndex = 11;
            this.btnWalkStraight.Text = "앞으로 걷기";
            this.btnWalkStraight.UseVisualStyleBackColor = true;
            this.btnWalkStraight.Click += new System.EventHandler(this.btnWalkStraight_Click);
            // 
            // btnWalkStop
            // 
            this.btnWalkStop.Location = new System.Drawing.Point(119, 209);
            this.btnWalkStop.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnWalkStop.Name = "btnWalkStop";
            this.btnWalkStop.Size = new System.Drawing.Size(90, 69);
            this.btnWalkStop.TabIndex = 12;
            this.btnWalkStop.Text = "걸음 정지";
            this.btnWalkStop.UseVisualStyleBackColor = true;
            this.btnWalkStop.Click += new System.EventHandler(this.btnWalkStop_Click);
            // 
            // btnWalkLeft
            // 
            this.btnWalkLeft.Location = new System.Drawing.Point(217, 209);
            this.btnWalkLeft.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnWalkLeft.Name = "btnWalkLeft";
            this.btnWalkLeft.Size = new System.Drawing.Size(98, 69);
            this.btnWalkLeft.TabIndex = 13;
            this.btnWalkLeft.Text = "왼쪽으로\r\n걷기";
            this.btnWalkLeft.UseVisualStyleBackColor = true;
            // 
            // btnWalkRight
            // 
            this.btnWalkRight.Location = new System.Drawing.Point(13, 209);
            this.btnWalkRight.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnWalkRight.Name = "btnWalkRight";
            this.btnWalkRight.Size = new System.Drawing.Size(98, 69);
            this.btnWalkRight.TabIndex = 14;
            this.btnWalkRight.Text = "오른쪽으로\r\n걷기";
            this.btnWalkRight.UseVisualStyleBackColor = true;
            // 
            // btnTrans1
            // 
            this.btnTrans1.Location = new System.Drawing.Point(386, 284);
            this.btnTrans1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTrans1.Name = "btnTrans1";
            this.btnTrans1.Size = new System.Drawing.Size(164, 60);
            this.btnTrans1.TabIndex = 15;
            this.btnTrans1.Text = "--> 트랜스포밍 -->";
            this.btnTrans1.UseVisualStyleBackColor = true;
            this.btnTrans1.Click += new System.EventHandler(this.btnTrans1_Click);
            // 
            // lbDisp
            // 
            this.lbDisp.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbDisp.Location = new System.Drawing.Point(330, 9);
            this.lbDisp.Name = "lbDisp";
            this.lbDisp.Size = new System.Drawing.Size(347, 265);
            this.lbDisp.TabIndex = 17;
            this.lbDisp.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("D2Coding", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.Location = new System.Drawing.Point(12, 432);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(970, 281);
            this.textBox1.TabIndex = 16;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(21, 13);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(63, 27);
            this.txtPort.TabIndex = 20;
            this.txtPort.Text = "10";
            this.txtPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(90, 13);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(72, 27);
            this.btnConnect.TabIndex = 21;
            this.btnConnect.Text = "연결";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(168, 13);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(86, 27);
            this.btnDisconnect.TabIndex = 22;
            this.btnDisconnect.Text = "연결 해제";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnTrans2
            // 
            this.btnTrans2.Location = new System.Drawing.Point(386, 353);
            this.btnTrans2.Name = "btnTrans2";
            this.btnTrans2.Size = new System.Drawing.Size(164, 60);
            this.btnTrans2.TabIndex = 23;
            this.btnTrans2.Text = "<-- 트랜스포밍 <--";
            this.btnTrans2.UseVisualStyleBackColor = true;
            this.btnTrans2.Click += new System.EventHandler(this.btnTrans2_Click);
            // 
            // btnWalkBack
            // 
            this.btnWalkBack.Location = new System.Drawing.Point(103, 287);
            this.btnWalkBack.Name = "btnWalkBack";
            this.btnWalkBack.Size = new System.Drawing.Size(122, 69);
            this.btnWalkBack.TabIndex = 24;
            this.btnWalkBack.Text = "뒤로 걷기";
            this.btnWalkBack.UseVisualStyleBackColor = true;
            this.btnWalkBack.Click += new System.EventHandler(this.btnWalkBack_Click);
            // 
            // btnStandPose
            // 
            this.btnStandPose.Location = new System.Drawing.Point(277, 318);
            this.btnStandPose.Name = "btnStandPose";
            this.btnStandPose.Size = new System.Drawing.Size(101, 60);
            this.btnStandPose.TabIndex = 25;
            this.btnStandPose.Text = "선 동작";
            this.btnStandPose.UseVisualStyleBackColor = true;
            this.btnStandPose.Click += new System.EventHandler(this.btnStandPose_Click);
            // 
            // btnTorqueOn
            // 
            this.btnTorqueOn.Location = new System.Drawing.Point(51, 59);
            this.btnTorqueOn.Name = "btnTorqueOn";
            this.btnTorqueOn.Size = new System.Drawing.Size(93, 55);
            this.btnTorqueOn.TabIndex = 27;
            this.btnTorqueOn.Text = "토크 온";
            this.btnTorqueOn.UseVisualStyleBackColor = true;
            this.btnTorqueOn.Click += new System.EventHandler(this.btnTorqueOn_Click);
            // 
            // btnTorqueOff
            // 
            this.btnTorqueOff.Location = new System.Drawing.Point(150, 59);
            this.btnTorqueOff.Name = "btnTorqueOff";
            this.btnTorqueOff.Size = new System.Drawing.Size(93, 55);
            this.btnTorqueOff.TabIndex = 28;
            this.btnTorqueOff.Text = "토크 오프";
            this.btnTorqueOff.UseVisualStyleBackColor = true;
            this.btnTorqueOff.Click += new System.EventHandler(this.btnTorqueOff_Click);
            // 
            // btnMecanumPose
            // 
            this.btnMecanumPose.Location = new System.Drawing.Point(558, 318);
            this.btnMecanumPose.Name = "btnMecanumPose";
            this.btnMecanumPose.Size = new System.Drawing.Size(101, 60);
            this.btnMecanumPose.TabIndex = 30;
            this.btnMecanumPose.Text = "메카넘 포즈";
            this.btnMecanumPose.UseVisualStyleBackColor = true;
            this.btnMecanumPose.Click += new System.EventHandler(this.btnMecanumPose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 725);
            this.Controls.Add(this.btnMecanumPose);
            this.Controls.Add(this.btnTorqueOff);
            this.Controls.Add(this.btnTorqueOn);
            this.Controls.Add(this.btnStandPose);
            this.Controls.Add(this.btnWalkBack);
            this.Controls.Add(this.btnTrans2);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.lbDisp);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnTrans1);
            this.Controls.Add(this.btnWalkRight);
            this.Controls.Add(this.btnWalkLeft);
            this.Controls.Add(this.btnWalkStop);
            this.Controls.Add(this.btnWalkStraight);
            this.Controls.Add(this.btnStopMecanum);
            this.Controls.Add(this.btnTurnR);
            this.Controls.Add(this.btnTurnL);
            this.Controls.Add(this.btnBR);
            this.Controls.Add(this.btnBL);
            this.Controls.Add(this.btnFR);
            this.Controls.Add(this.btnFL);
            this.Controls.Add(this.btnR);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnL);
            this.Controls.Add(this.btnF);
            this.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Form1";
            this.Text = "Mecanoid controller";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnF;
        private System.Windows.Forms.Button btnL;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.Button btnFL;
        private System.Windows.Forms.Button btnFR;
        private System.Windows.Forms.Button btnBL;
        private System.Windows.Forms.Button btnBR;
        private System.Windows.Forms.Button btnStopMecanum;
        private System.Windows.Forms.Button btnTurnL;
        private System.Windows.Forms.Button btnTurnR;
        private System.Windows.Forms.Button btnWalkStraight;
        private System.Windows.Forms.Button btnWalkStop;
        private System.Windows.Forms.Button btnWalkLeft;
        private System.Windows.Forms.Button btnWalkRight;
        private System.Windows.Forms.Button btnTrans1;
        private System.Windows.Forms.Label lbDisp;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnTrans2;
        private System.Windows.Forms.Button btnWalkBack;
        private System.Windows.Forms.Button btnStandPose;
        private System.Windows.Forms.Button btnTorqueOn;
        private System.Windows.Forms.Button btnTorqueOff;
        private System.Windows.Forms.Button btnMecanumPose;
    }
}

