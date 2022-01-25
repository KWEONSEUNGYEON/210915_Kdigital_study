namespace OracleDB_StudyCafe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_regismonth = new System.Windows.Forms.TextBox();
            this.textBox_seatspot = new System.Windows.Forms.TextBox();
            this.textBox_phonenumber = new System.Windows.Forms.TextBox();
            this.textBox_regisname = new System.Windows.Forms.TextBox();
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
            this.button_seatmap = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.studyCafeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studyCafeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView_studycafe = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studyCafeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studyCafeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_studycafe)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.textBox_regismonth);
            this.panel1.Controls.Add(this.textBox_seatspot);
            this.panel1.Controls.Add(this.textBox_phonenumber);
            this.panel1.Controls.Add(this.textBox_regisname);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button_out);
            this.panel1.Controls.Add(this.button_in);
            this.panel1.Location = new System.Drawing.Point(89, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 392);
            this.panel1.TabIndex = 0;
            // 
            // textBox_regismonth
            // 
            this.textBox_regismonth.Location = new System.Drawing.Point(200, 211);
            this.textBox_regismonth.Name = "textBox_regismonth";
            this.textBox_regismonth.Size = new System.Drawing.Size(164, 28);
            this.textBox_regismonth.TabIndex = 11;
            // 
            // textBox_seatspot
            // 
            this.textBox_seatspot.Location = new System.Drawing.Point(200, 270);
            this.textBox_seatspot.Name = "textBox_seatspot";
            this.textBox_seatspot.Size = new System.Drawing.Size(164, 28);
            this.textBox_seatspot.TabIndex = 10;
            // 
            // textBox_phonenumber
            // 
            this.textBox_phonenumber.Location = new System.Drawing.Point(200, 152);
            this.textBox_phonenumber.Name = "textBox_phonenumber";
            this.textBox_phonenumber.Size = new System.Drawing.Size(164, 28);
            this.textBox_phonenumber.TabIndex = 9;
            // 
            // textBox_regisname
            // 
            this.textBox_regisname.Location = new System.Drawing.Point(200, 93);
            this.textBox_regisname.Name = "textBox_regisname";
            this.textBox_regisname.Size = new System.Drawing.Size(164, 28);
            this.textBox_regisname.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(86, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "좌석번호";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "등록개월";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "전화번호";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "성명";
            // 
            // button_out
            // 
            this.button_out.FlatAppearance.BorderSize = 0;
            this.button_out.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_out.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_out.Image = ((System.Drawing.Image)(resources.GetObject("button_out.Image")));
            this.button_out.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_out.Location = new System.Drawing.Point(409, 146);
            this.button_out.Name = "button_out";
            this.button_out.Size = new System.Drawing.Size(121, 60);
            this.button_out.TabIndex = 3;
            this.button_out.Text = "  해지";
            this.button_out.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_out.UseVisualStyleBackColor = true;
            this.button_out.Click += new System.EventHandler(this.button_out_Click);
            // 
            // button_in
            // 
            this.button_in.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button_in.FlatAppearance.BorderSize = 0;
            this.button_in.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_in.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_in.Image = ((System.Drawing.Image)(resources.GetObject("button_in.Image")));
            this.button_in.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_in.Location = new System.Drawing.Point(409, 80);
            this.button_in.Name = "button_in";
            this.button_in.Size = new System.Drawing.Size(121, 60);
            this.button_in.TabIndex = 2;
            this.button_in.Text = "  등록";
            this.button_in.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_in.UseVisualStyleBackColor = false;
            this.button_in.Click += new System.EventHandler(this.button_in_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.textBox_seatspot_manager);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.button_delete);
            this.panel2.Controls.Add(this.button_add);
            this.panel2.Location = new System.Drawing.Point(661, 130);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(532, 392);
            this.panel2.TabIndex = 1;
            // 
            // textBox_seatspot_manager
            // 
            this.textBox_seatspot_manager.Location = new System.Drawing.Point(165, 126);
            this.textBox_seatspot_manager.Name = "textBox_seatspot_manager";
            this.textBox_seatspot_manager.Size = new System.Drawing.Size(176, 28);
            this.textBox_seatspot_manager.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(63, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 28);
            this.label5.TabIndex = 8;
            this.label5.Text = "좌석번호";
            // 
            // button_delete
            // 
            this.button_delete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.Location = new System.Drawing.Point(362, 146);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(103, 45);
            this.button_delete.TabIndex = 5;
            this.button_delete.Text = "삭제";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_add
            // 
            this.button_add.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.Location = new System.Drawing.Point(362, 80);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(103, 45);
            this.button_add.TabIndex = 4;
            this.button_add.Text = "선택";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_seatmap
            // 
            this.button_seatmap.FlatAppearance.BorderSize = 0;
            this.button_seatmap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_seatmap.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_seatmap.Image = ((System.Drawing.Image)(resources.GetObject("button_seatmap.Image")));
            this.button_seatmap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_seatmap.Location = new System.Drawing.Point(661, 54);
            this.button_seatmap.Name = "button_seatmap";
            this.button_seatmap.Size = new System.Drawing.Size(274, 70);
            this.button_seatmap.TabIndex = 2;
            this.button_seatmap.Text = "  좌석배치도 보기";
            this.button_seatmap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_seatmap.UseVisualStyleBackColor = true;
            this.button_seatmap.Click += new System.EventHandler(this.button_seatmap_Click);
            // 
            // button_close
            // 
            this.button_close.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_close.Location = new System.Drawing.Point(1179, 12);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(110, 63);
            this.button_close.TabIndex = 3;
            this.button_close.Text = "닫기";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView_studycafe);
            this.panel3.Location = new System.Drawing.Point(-4, 528);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1411, 383);
            this.panel3.TabIndex = 4;
            // 
            // studyCafeBindingSource1
            // 
            this.studyCafeBindingSource1.DataSource = typeof(OracleDB_StudyCafe.StudyCafe);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "EndDate";
            this.dataGridViewTextBoxColumn6.HeaderText = "EndDate";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "RegisDate";
            this.dataGridViewTextBoxColumn5.HeaderText = "RegisDate";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "RegisMonth";
            this.dataGridViewTextBoxColumn4.HeaderText = "RegisMonth";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PhoneNumber";
            this.dataGridViewTextBoxColumn3.HeaderText = "PhoneNumber";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "RegisName";
            this.dataGridViewTextBoxColumn2.HeaderText = "RegisName";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SeatSpot";
            this.dataGridViewTextBoxColumn1.HeaderText = "SeatSpot";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridView_studycafe
            // 
            this.dataGridView_studycafe.AllowUserToAddRows = false;
            this.dataGridView_studycafe.AllowUserToDeleteRows = false;
            this.dataGridView_studycafe.AutoGenerateColumns = false;
            this.dataGridView_studycafe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_studycafe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridView_studycafe.DataSource = this.studyCafeBindingSource1;
            this.dataGridView_studycafe.Location = new System.Drawing.Point(16, 22);
            this.dataGridView_studycafe.Name = "dataGridView_studycafe";
            this.dataGridView_studycafe.ReadOnly = true;
            this.dataGridView_studycafe.RowHeadersWidth = 62;
            this.dataGridView_studycafe.RowTemplate.Height = 30;
            this.dataGridView_studycafe.Size = new System.Drawing.Size(1375, 267);
            this.dataGridView_studycafe.TabIndex = 0;
            this.dataGridView_studycafe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_studycafe_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 916);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_seatmap);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studyCafeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studyCafeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_studycafe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_seatspot;
        private System.Windows.Forms.TextBox textBox_phonenumber;
        private System.Windows.Forms.TextBox textBox_regisname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_out;
        private System.Windows.Forms.Button button_in;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox_seatspot_manager;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_seatmap;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.BindingSource studyCafeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn seatSpotDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regisNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regisMonthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regisDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox_regismonth;
        private System.Windows.Forms.BindingSource studyCafeBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView_studycafe;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}

