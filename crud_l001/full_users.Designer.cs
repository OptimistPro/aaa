namespace crud_l001
{
    partial class full_users
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.new_user = new System.Windows.Forms.Button();
            this.data_users = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obnov = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delet = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.data_users)).BeginInit();
            this.SuspendLayout();
            // 
            // new_user
            // 
            this.new_user.Location = new System.Drawing.Point(18, 48);
            this.new_user.Name = "new_user";
            this.new_user.Size = new System.Drawing.Size(150, 32);
            this.new_user.TabIndex = 0;
            this.new_user.Text = "Новый пользователь";
            this.new_user.UseVisualStyleBackColor = true;
            this.new_user.Click += new System.EventHandler(this.new_user_Click);
            // 
            // data_users
            // 
            this.data_users.AllowUserToAddRows = false;
            this.data_users.AllowUserToDeleteRows = false;
            this.data_users.AllowUserToResizeColumns = false;
            this.data_users.AllowUserToResizeRows = false;
            this.data_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_users.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.login,
            this.password,
            this.name,
            this.obnov,
            this.delet});
            this.data_users.Location = new System.Drawing.Point(18, 86);
            this.data_users.Name = "data_users";
            this.data_users.Size = new System.Drawing.Size(767, 348);
            this.data_users.TabIndex = 1;
            this.data_users.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_users_CellClick);
            this.data_users.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_users_CellContentClick);
            // 
            // id
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Silver;
            this.id.DefaultCellStyle = dataGridViewCellStyle1;
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.id.Visible = false;
            this.id.Width = 5;
            // 
            // login
            // 
            this.login.HeaderText = "login";
            this.login.Name = "login";
            this.login.Width = 150;
            // 
            // password
            // 
            this.password.HeaderText = "password";
            this.password.Name = "password";
            this.password.Width = 150;
            // 
            // name
            // 
            this.name.HeaderText = "Имя";
            this.name.Name = "name";
            this.name.Width = 150;
            // 
            // obnov
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray;
            this.obnov.DefaultCellStyle = dataGridViewCellStyle2;
            this.obnov.HeaderText = "Изменить";
            this.obnov.Name = "obnov";
            this.obnov.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.obnov.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.obnov.Text = "Изменить";
            this.obnov.UseColumnTextForButtonValue = true;
            this.obnov.Width = 125;
            // 
            // delet
            // 
            this.delet.HeaderText = "Удалить";
            this.delet.Name = "delet";
            this.delet.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.delet.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.delet.Text = "Удалить";
            this.delet.UseColumnTextForButtonValue = true;
            this.delet.Width = 125;
            // 
            // full_users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.data_users);
            this.Controls.Add(this.new_user);
            this.Name = "full_users";
            this.Size = new System.Drawing.Size(800, 450);
            this.Load += new System.EventHandler(this.full_users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_users)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button new_user;
        private System.Windows.Forms.DataGridView data_users;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn login;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewButtonColumn obnov;
        private System.Windows.Forms.DataGridViewButtonColumn delet;
    }
}
