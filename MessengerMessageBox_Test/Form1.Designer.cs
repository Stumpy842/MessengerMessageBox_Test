namespace MessengerMessageBox_Test
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btOK = new Button();
            groupBox1 = new GroupBox();
            btCancelTryContinue = new Button();
            btRetryCancel = new Button();
            btYesNo = new Button();
            btYesNoCancel = new Button();
            btAbortRetryIgnore = new Button();
            btOKCancel = new Button();
            groupBox2 = new GroupBox();
            btmCancelTryContinue = new Button();
            button2 = new Button();
            btmRetryCancel = new Button();
            btmYesNo = new Button();
            btmYesNoCancel = new Button();
            btmAbortRetryIgnore = new Button();
            btmOKCancel = new Button();
            btmOK = new Button();
            groupBox3 = new GroupBox();
            rbFour = new RadioButton();
            rbThree = new RadioButton();
            rbTwo = new RadioButton();
            rbOne = new RadioButton();
            label1 = new Label();
            tbTitle = new TextBox();
            label2 = new Label();
            tbMessage = new TextBox();
            label3 = new Label();
            lbResult = new Label();
            groupBox4 = new GroupBox();
            rbLight = new RadioButton();
            rbDark = new RadioButton();
            rbSystem = new RadioButton();
            groupBox5 = new GroupBox();
            rbAsterisk = new RadioButton();
            rbExclamation = new RadioButton();
            rbQuestion = new RadioButton();
            rbHand = new RadioButton();
            rbNone = new RadioButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // btOK
            // 
            btOK.Location = new Point(6, 22);
            btOK.Name = "btOK";
            btOK.Size = new Size(137, 37);
            btOK.TabIndex = 0;
            btOK.Text = "OK";
            btOK.UseVisualStyleBackColor = true;
            btOK.Click += btOK_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btCancelTryContinue);
            groupBox1.Controls.Add(btRetryCancel);
            groupBox1.Controls.Add(btYesNo);
            groupBox1.Controls.Add(btYesNoCancel);
            groupBox1.Controls.Add(btAbortRetryIgnore);
            groupBox1.Controls.Add(btOKCancel);
            groupBox1.Controls.Add(btOK);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1012, 77);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "WinForms MessageBox";
            // 
            // btCancelTryContinue
            // 
            btCancelTryContinue.Location = new Point(864, 22);
            btCancelTryContinue.Name = "btCancelTryContinue";
            btCancelTryContinue.Size = new Size(137, 37);
            btCancelTryContinue.TabIndex = 6;
            btCancelTryContinue.Text = "CancelTryContinue";
            btCancelTryContinue.UseVisualStyleBackColor = true;
            btCancelTryContinue.Click += btCancelTryContinue_Click;
            // 
            // btRetryCancel
            // 
            btRetryCancel.Location = new Point(721, 22);
            btRetryCancel.Name = "btRetryCancel";
            btRetryCancel.Size = new Size(137, 37);
            btRetryCancel.TabIndex = 5;
            btRetryCancel.Text = "RetryCancel";
            btRetryCancel.UseVisualStyleBackColor = true;
            btRetryCancel.Click += btRetryCancel_Click;
            // 
            // btYesNo
            // 
            btYesNo.Location = new Point(578, 22);
            btYesNo.Name = "btYesNo";
            btYesNo.Size = new Size(137, 37);
            btYesNo.TabIndex = 4;
            btYesNo.Text = "YesNo";
            btYesNo.UseVisualStyleBackColor = true;
            btYesNo.Click += btYesNo_Click;
            // 
            // btYesNoCancel
            // 
            btYesNoCancel.Location = new Point(435, 22);
            btYesNoCancel.Name = "btYesNoCancel";
            btYesNoCancel.Size = new Size(137, 37);
            btYesNoCancel.TabIndex = 3;
            btYesNoCancel.Text = "YesNoCancel";
            btYesNoCancel.UseVisualStyleBackColor = true;
            btYesNoCancel.Click += btYesNoCancel_Click;
            // 
            // btAbortRetryIgnore
            // 
            btAbortRetryIgnore.Location = new Point(292, 22);
            btAbortRetryIgnore.Name = "btAbortRetryIgnore";
            btAbortRetryIgnore.Size = new Size(137, 37);
            btAbortRetryIgnore.TabIndex = 2;
            btAbortRetryIgnore.Text = "AbortRetryIgnore";
            btAbortRetryIgnore.UseVisualStyleBackColor = true;
            btAbortRetryIgnore.Click += btAbortRetryIgnore_Click;
            // 
            // btOKCancel
            // 
            btOKCancel.Location = new Point(149, 22);
            btOKCancel.Name = "btOKCancel";
            btOKCancel.Size = new Size(137, 37);
            btOKCancel.TabIndex = 1;
            btOKCancel.Text = "OKCancel";
            btOKCancel.UseVisualStyleBackColor = true;
            btOKCancel.Click += btOKCancel_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btmCancelTryContinue);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(btmRetryCancel);
            groupBox2.Controls.Add(btmYesNo);
            groupBox2.Controls.Add(btmYesNoCancel);
            groupBox2.Controls.Add(btmAbortRetryIgnore);
            groupBox2.Controls.Add(btmOKCancel);
            groupBox2.Controls.Add(btmOK);
            groupBox2.Location = new Point(12, 95);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1012, 77);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Messenger.MessageBox";
            // 
            // btmCancelTryContinue
            // 
            btmCancelTryContinue.Location = new Point(864, 22);
            btmCancelTryContinue.Name = "btmCancelTryContinue";
            btmCancelTryContinue.Size = new Size(137, 37);
            btmCancelTryContinue.TabIndex = 6;
            btmCancelTryContinue.Text = "CancelTryContinue";
            btmCancelTryContinue.UseVisualStyleBackColor = true;
            btmCancelTryContinue.Click += btmCancelTryContinue_Click;
            // 
            // button2
            // 
            button2.Location = new Point(864, 22);
            button2.Name = "button2";
            button2.Size = new Size(137, 37);
            button2.TabIndex = 0;
            button2.Text = "OK";
            button2.UseVisualStyleBackColor = true;
            // 
            // btmRetryCancel
            // 
            btmRetryCancel.Location = new Point(721, 22);
            btmRetryCancel.Name = "btmRetryCancel";
            btmRetryCancel.Size = new Size(137, 37);
            btmRetryCancel.TabIndex = 5;
            btmRetryCancel.Text = "RetryCancel";
            btmRetryCancel.UseVisualStyleBackColor = true;
            btmRetryCancel.Click += btmRetryCancel_Click;
            // 
            // btmYesNo
            // 
            btmYesNo.Location = new Point(578, 22);
            btmYesNo.Name = "btmYesNo";
            btmYesNo.Size = new Size(137, 37);
            btmYesNo.TabIndex = 4;
            btmYesNo.Text = "YesNo";
            btmYesNo.UseVisualStyleBackColor = true;
            btmYesNo.Click += btmYesNo_Click;
            // 
            // btmYesNoCancel
            // 
            btmYesNoCancel.Location = new Point(435, 22);
            btmYesNoCancel.Name = "btmYesNoCancel";
            btmYesNoCancel.Size = new Size(137, 37);
            btmYesNoCancel.TabIndex = 3;
            btmYesNoCancel.Text = "YesNoCancel";
            btmYesNoCancel.UseVisualStyleBackColor = true;
            btmYesNoCancel.Click += btmYesNoCancel_Click;
            // 
            // btmAbortRetryIgnore
            // 
            btmAbortRetryIgnore.Location = new Point(292, 22);
            btmAbortRetryIgnore.Name = "btmAbortRetryIgnore";
            btmAbortRetryIgnore.Size = new Size(137, 37);
            btmAbortRetryIgnore.TabIndex = 2;
            btmAbortRetryIgnore.Text = "AbortRetryIgnore";
            btmAbortRetryIgnore.UseVisualStyleBackColor = true;
            btmAbortRetryIgnore.Click += btmAbortRetryIgnore_Click;
            // 
            // btmOKCancel
            // 
            btmOKCancel.Location = new Point(149, 22);
            btmOKCancel.Name = "btmOKCancel";
            btmOKCancel.Size = new Size(137, 37);
            btmOKCancel.TabIndex = 1;
            btmOKCancel.Text = "OKCancel";
            btmOKCancel.UseVisualStyleBackColor = true;
            btmOKCancel.Click += btmOKCancel_Click;
            // 
            // btmOK
            // 
            btmOK.Location = new Point(6, 22);
            btmOK.Name = "btmOK";
            btmOK.Size = new Size(137, 37);
            btmOK.TabIndex = 0;
            btmOK.Text = "OK";
            btmOK.UseVisualStyleBackColor = true;
            btmOK.Click += btmOK_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(rbFour);
            groupBox3.Controls.Add(rbThree);
            groupBox3.Controls.Add(rbTwo);
            groupBox3.Controls.Add(rbOne);
            groupBox3.Location = new Point(12, 197);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(105, 126);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Default Button";
            // 
            // rbFour
            // 
            rbFour.AutoSize = true;
            rbFour.Location = new Point(6, 97);
            rbFour.Name = "rbFour";
            rbFour.Size = new Size(49, 19);
            rbFour.TabIndex = 3;
            rbFour.TabStop = true;
            rbFour.Text = "Four";
            rbFour.UseVisualStyleBackColor = true;
            rbFour.CheckedChanged += rbOne_CheckedChanged;
            // 
            // rbThree
            // 
            rbThree.AutoSize = true;
            rbThree.Location = new Point(6, 72);
            rbThree.Name = "rbThree";
            rbThree.Size = new Size(54, 19);
            rbThree.TabIndex = 2;
            rbThree.Text = "Three";
            rbThree.UseVisualStyleBackColor = true;
            rbThree.CheckedChanged += rbOne_CheckedChanged;
            // 
            // rbTwo
            // 
            rbTwo.AutoSize = true;
            rbTwo.Location = new Point(6, 47);
            rbTwo.Name = "rbTwo";
            rbTwo.Size = new Size(46, 19);
            rbTwo.TabIndex = 1;
            rbTwo.Text = "Two";
            rbTwo.UseVisualStyleBackColor = true;
            rbTwo.CheckedChanged += rbOne_CheckedChanged;
            // 
            // rbOne
            // 
            rbOne.AutoSize = true;
            rbOne.Checked = true;
            rbOne.Location = new Point(6, 22);
            rbOne.Name = "rbOne";
            rbOne.Size = new Size(47, 19);
            rbOne.TabIndex = 0;
            rbOne.TabStop = true;
            rbOne.Text = "One";
            rbOne.UseVisualStyleBackColor = true;
            rbOne.CheckedChanged += rbOne_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(487, 214);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 4;
            label1.Text = "Title";
            // 
            // tbTitle
            // 
            tbTitle.Location = new Point(549, 211);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(464, 23);
            tbTitle.TabIndex = 5;
            tbTitle.Text = "MessageBox Title";
            tbTitle.TextChanged += tbTitle_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(487, 259);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 6;
            label2.Text = "Message";
            // 
            // tbMessage
            // 
            tbMessage.Location = new Point(549, 256);
            tbMessage.Name = "tbMessage";
            tbMessage.Size = new Size(464, 23);
            tbMessage.TabIndex = 7;
            tbMessage.Text = "MessageBox Message";
            tbMessage.TextChanged += tbMessage_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(487, 315);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 8;
            label3.Text = "Result";
            // 
            // lbResult
            // 
            lbResult.AutoSize = true;
            lbResult.Location = new Point(549, 315);
            lbResult.Name = "lbResult";
            lbResult.Size = new Size(49, 15);
            lbResult.TabIndex = 9;
            lbResult.Text = "lbResult";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(rbLight);
            groupBox4.Controls.Add(rbDark);
            groupBox4.Controls.Add(rbSystem);
            groupBox4.Location = new Point(145, 197);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(126, 126);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Dark Mode";
            // 
            // rbLight
            // 
            rbLight.AutoSize = true;
            rbLight.Location = new Point(6, 72);
            rbLight.Name = "rbLight";
            rbLight.Size = new Size(52, 19);
            rbLight.TabIndex = 2;
            rbLight.Text = "Light";
            rbLight.UseVisualStyleBackColor = true;
            rbLight.CheckedChanged += rbSystem_CheckedChanged;
            // 
            // rbDark
            // 
            rbDark.AutoSize = true;
            rbDark.Location = new Point(6, 47);
            rbDark.Name = "rbDark";
            rbDark.Size = new Size(49, 19);
            rbDark.TabIndex = 1;
            rbDark.Text = "Dark";
            rbDark.UseVisualStyleBackColor = true;
            rbDark.CheckedChanged += rbSystem_CheckedChanged;
            // 
            // rbSystem
            // 
            rbSystem.AutoSize = true;
            rbSystem.Checked = true;
            rbSystem.Location = new Point(6, 22);
            rbSystem.Name = "rbSystem";
            rbSystem.Size = new Size(63, 19);
            rbSystem.TabIndex = 0;
            rbSystem.TabStop = true;
            rbSystem.Text = "System";
            rbSystem.UseVisualStyleBackColor = true;
            rbSystem.CheckedChanged += rbSystem_CheckedChanged;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(rbAsterisk);
            groupBox5.Controls.Add(rbExclamation);
            groupBox5.Controls.Add(rbQuestion);
            groupBox5.Controls.Add(rbHand);
            groupBox5.Controls.Add(rbNone);
            groupBox5.Location = new Point(304, 197);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(132, 172);
            groupBox5.TabIndex = 10;
            groupBox5.TabStop = false;
            groupBox5.Text = "Icon";
            // 
            // rbAsterisk
            // 
            rbAsterisk.AutoSize = true;
            rbAsterisk.Location = new Point(6, 122);
            rbAsterisk.Name = "rbAsterisk";
            rbAsterisk.Size = new Size(66, 19);
            rbAsterisk.TabIndex = 0;
            rbAsterisk.Text = "Asterisk";
            rbAsterisk.UseVisualStyleBackColor = true;
            rbAsterisk.CheckedChanged += rbNone_CheckedChanged;
            // 
            // rbExclamation
            // 
            rbExclamation.AutoSize = true;
            rbExclamation.Location = new Point(6, 97);
            rbExclamation.Name = "rbExclamation";
            rbExclamation.Size = new Size(90, 19);
            rbExclamation.TabIndex = 0;
            rbExclamation.Text = "Exclamation";
            rbExclamation.UseVisualStyleBackColor = true;
            rbExclamation.CheckedChanged += rbNone_CheckedChanged;
            // 
            // rbQuestion
            // 
            rbQuestion.AutoSize = true;
            rbQuestion.Location = new Point(6, 72);
            rbQuestion.Name = "rbQuestion";
            rbQuestion.Size = new Size(73, 19);
            rbQuestion.TabIndex = 0;
            rbQuestion.Text = "Question";
            rbQuestion.UseVisualStyleBackColor = true;
            rbQuestion.CheckedChanged += rbNone_CheckedChanged;
            // 
            // rbHand
            // 
            rbHand.AutoSize = true;
            rbHand.Location = new Point(6, 47);
            rbHand.Name = "rbHand";
            rbHand.Size = new Size(54, 19);
            rbHand.TabIndex = 0;
            rbHand.Text = "Hand";
            rbHand.UseVisualStyleBackColor = true;
            rbHand.CheckedChanged += rbNone_CheckedChanged;
            // 
            // rbNone
            // 
            rbNone.AutoSize = true;
            rbNone.Checked = true;
            rbNone.Location = new Point(6, 22);
            rbNone.Name = "rbNone";
            rbNone.Size = new Size(54, 19);
            rbNone.TabIndex = 0;
            rbNone.TabStop = true;
            rbNone.Text = "None";
            rbNone.UseVisualStyleBackColor = true;
            rbNone.CheckedChanged += rbNone_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1041, 450);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(lbResult);
            Controls.Add(label3);
            Controls.Add(tbMessage);
            Controls.Add(tbTitle);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Messenger.MessageBox Test";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btOK;
        private GroupBox groupBox1;
        private Button btRetryCancel;
        private Button btYesNo;
        private Button btYesNoCancel;
        private Button btAbortRetryIgnore;
        private Button btOKCancel;
        private GroupBox groupBox2;
        private Button btmRetryCancel;
        private Button btmYesNo;
        private Button btmYesNoCancel;
        private Button btmAbortRetryIgnore;
        private Button btmOKCancel;
        private Button btmOK;
        private Button btCancelTryContinue;
        private Button btmCancelTryContinue;
        private Button button2;
        private GroupBox groupBox3;
        private RadioButton rbThree;
        private RadioButton rbTwo;
        private RadioButton rbOne;
        private Label label1;
        private TextBox tbTitle;
        private Label label2;
        private TextBox tbMessage;
        private RadioButton rbFour;
        private Label label3;
        private Label lbResult;
        private GroupBox groupBox4;
        private RadioButton rbLight;
        private RadioButton rbDark;
        private RadioButton rbSystem;
        private GroupBox groupBox5;
        private RadioButton rbAsterisk;
        private RadioButton rbExclamation;
        private RadioButton rbQuestion;
        private RadioButton rbHand;
        private RadioButton rbNone;
    }
}
