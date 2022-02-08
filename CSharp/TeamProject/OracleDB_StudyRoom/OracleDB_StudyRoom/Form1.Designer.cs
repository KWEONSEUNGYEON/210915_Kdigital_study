namespace OracleDB_StudyRoom
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_usetime = new System.Windows.Forms.TextBox();
            this.textBox_phonenumber = new System.Windows.Forms.TextBox();
            this.textBox_regisname = new System.Windows.Forms.TextBox();
            this.textBox_seatspot = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_out = new System.Windows.Forms.Button();
            this.button_in = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_seatspot_manager = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView_studyroom = new System.Windows.Forms.DataGridView();
            this.seatSpotDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regisNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.useTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regisTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studyRoomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_studyroom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studyRoomBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.textBox_usetime);
            this.panel1.Controls.Add(this.textBox_phonenumber);
            this.panel1.Controls.Add(this.textBox_regisname);
            this.panel1.Controls.Add(this.textBox_seatspot);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button_out);
            this.panel1.Controls.Add(this.button_in);
            this.panel1.Location = new System.Drawing.Point(61, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(617, 452);
            this.panel1.TabIndex = 0;
            // 
            // textBox_usetime
            // 
            this.textBox_usetime.Location = new System.Drawing.Point(210, 335);
            this.textBox_usetime.Name = "textBox_usetime";
            this.textBox_usetime.Size = new System.Drawing.Size(188, 28);
            this.textBox_usetime.TabIndex = 9;
            // 
            // textBox_phonenumber
            // 
            this.textBox_phonenumber.Location = new System.Drawing.Point(210, 251);
            this.textBox_phonenumber.Name = "textBox_phonenumber";
            this.textBox_phonenumber.Size = new System.Drawing.Size(188, 28);
            this.textBox_phonenumber.TabIndex = 8;
            // 
            // textBox_regisname
            // 
            this.textBox_regisname.Location = new System.Drawing.Point(210, 163);
            this.textBox_regisname.Name = "textBox_regisname";
            this.textBox_regisname.Size = new System.Drawing.Size(188, 28);
            this.textBox_regisname.TabIndex = 7;
            // 
            // textBox_seatspot
            // 
            this.textBox_seatspot.Location = new System.Drawing.Point(210, 79);
            this.textBox_seatspot.Name = "textBox_seatspot";
            this.textBox_seatspot.Size = new System.Drawing.Size(188, 28);
            this.textBox_seatspot.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(82, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 30);
            this.label4.TabIndex = 5;
            this.label4.Text = "사용시간";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "전화번호";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "성명";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "좌석번호";
            // 
            // button_out
            // 
            this.button_out.Location = new System.Drawing.Point(467, 136);
            this.button_out.Name = "button_out";
            this.button_out.Size = new System.Drawing.Size(101, 46);
            this.button_out.TabIndex = 1;
            this.button_out.Text = "퇴실";
            this.button_out.UseVisualStyleBackColor = true;
            // 
            // button_in
            // 
            this.button_in.Location = new System.Drawing.Point(467, 61);
            this.button_in.Name = "button_in";
            this.button_in.Size = new System.Drawing.Size(101, 46);
            this.button_in.TabIndex = 0;
            this.button_in.Text = "입실";
            this.button_in.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.textBox_seatspot_manager);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.button_delete);
            this.panel2.Controls.Add(this.button_add);
            this.panel2.Location = new System.Drawing.Point(719, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(617, 452);
            this.panel2.TabIndex = 1;
            // 
            // textBox_seatspot_manager
            // 
            this.textBox_seatspot_manager.Location = new System.Drawing.Point(246, 79);
            this.textBox_seatspot_manager.Name = "textBox_seatspot_manager";
            this.textBox_seatspot_manager.Size = new System.Drawing.Size(138, 28);
            this.textBox_seatspot_manager.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(110, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "좌석번호";
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(435, 136);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(101, 46);
            this.button_delete.TabIndex = 3;
            this.button_delete.Text = "좌석삭제";
            this.button_delete.UseVisualStyleBackColor = true;
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(435, 61);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(101, 46);
            this.button_add.TabIndex = 2;
            this.button_add.Text = "좌석추가";
            this.button_add.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Controls.Add(this.dataGridView_studyroom);
            this.panel3.Location = new System.Drawing.Point(21, 540);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1397, 349);
            this.panel3.TabIndex = 2;
            // 
            // dataGridView_studyroom
            // 
            this.dataGridView_studyroom.AllowUserToAddRows = false;
            this.dataGridView_studyroom.AllowUserToDeleteRows = false;
            this.dataGridView_studyroom.AutoGenerateColumns = false;
            this.dataGridView_studyroom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_studyroom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.seatSpotDataGridViewTextBoxColumn,
            this.regisNameDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.useTimeDataGridViewTextBoxColumn,
            this.regisTimeDataGridViewTextBoxColumn,
            this.endTimeDataGridViewTextBoxColumn});
            this.dataGridView_studyroom.DataSource = this.studyRoomBindingSource;
            this.dataGridView_studyroom.Location = new System.Drawing.Point(14, 18);
            this.dataGridView_studyroom.Name = "dataGridView_studyroom";
            this.dataGridView_studyroom.ReadOnly = true;
            this.dataGridView_studyroom.RowHeadersWidth = 62;
            this.dataGridView_studyroom.RowTemplate.Height = 30;
            this.dataGridView_studyroom.Size = new System.Drawing.Size(1365, 312);
            this.dataGridView_studyroom.TabIndex = 0;
            // 
            // seatSpotDataGridViewTextBoxColumn
            // 
            this.seatSpotDataGridViewTextBoxColumn.DataPropertyName = "SeatSpot";
            this.seatSpotDataGridViewTextBoxColumn.HeaderText = "SeatSpot";
            this.seatSpotDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.seatSpotDataGridViewTextBoxColumn.Name = "seatSpotDataGridViewTextBoxColumn";
            this.seatSpotDataGridViewTextBoxColumn.ReadOnly = true;
            this.seatSpotDataGridViewTextBoxColumn.Width = 150;
            // 
            // regisNameDataGridViewTextBoxColumn
            // 
            this.regisNameDataGridViewTextBoxColumn.DataPropertyName = "RegisName";
            this.regisNameDataGridViewTextBoxColumn.HeaderText = "RegisName";
            this.regisNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.regisNameDataGridViewTextBoxColumn.Name = "regisNameDataGridViewTextBoxColumn";
            this.regisNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.regisNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            this.phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.phoneNumberDataGridViewTextBoxColumn.Width = 150;
            // 
            // useTimeDataGridViewTextBoxColumn
            // 
            this.useTimeDataGridViewTextBoxColumn.DataPropertyName = "UseTime";
            this.useTimeDataGridViewTextBoxColumn.HeaderText = "UseTime";
            this.useTimeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.useTimeDataGridViewTextBoxColumn.Name = "useTimeDataGridViewTextBoxColumn";
            this.useTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.useTimeDataGridViewTextBoxColumn.Width = 150;
            // 
            // regisTimeDataGridViewTextBoxColumn
            // 
            this.regisTimeDataGridViewTextBoxColumn.DataPropertyName = "RegisTime";
            this.regisTimeDataGridViewTextBoxColumn.HeaderText = "RegisTime";
            this.regisTimeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.regisTimeDataGridViewTextBoxColumn.Name = "regisTimeDataGridViewTextBoxColumn";
            this.regisTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.regisTimeDataGridViewTextBoxColumn.Width = 150;
            // 
            // endTimeDataGridViewTextBoxColumn
            // 
            this.endTimeDataGridViewTextBoxColumn.DataPropertyName = "EndTime";
            this.endTimeDataGridViewTextBoxColumn.HeaderText = "EndTime";
            this.endTimeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.endTimeDataGridViewTextBoxColumn.Name = "endTimeDataGridViewTextBoxColumn";
            this.endTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.endTimeDataGridViewTextBoxColumn.Width = 150;
            // 
            // studyRoomBindingSource
            // 
            this.studyRoomBindingSource.DataSource = typeof(OracleDB_StudyRoom.StudyRoom);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1433, 915);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_studyroom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studyRoomBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_out;
        private System.Windows.Forms.Button button_in;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_usetime;
        private System.Windows.Forms.TextBox textBox_phonenumber;
        private System.Windows.Forms.TextBox textBox_regisname;
        private System.Windows.Forms.TextBox textBox_seatspot;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_seatspot_manager;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView_studyroom;
        private System.Windows.Forms.DataGridViewTextBoxColumn seatSpotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regisNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn useTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regisTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource studyRoomBindingSource;
    }
}

