
namespace Mona
{
    partial class Mona
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mona));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.kryptonDataGridView1 = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.PasswordId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailorUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConfirmPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Url = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfCreation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Copy = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewButtonColumn();
            this.Edit = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewButtonColumn();
            this.Delete = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnLogOut = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnAbout = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnAcc = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnLockOpt = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnBroswerPass = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnaddPass = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 561);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.kryptonDataGridView1);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.lblSearch);
            this.panel5.Controls.Add(this.txtSearch);
            this.panel5.Location = new System.Drawing.Point(269, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(615, 555);
            this.panel5.TabIndex = 2;
            // 
            // kryptonDataGridView1
            // 
            this.kryptonDataGridView1.AllowUserToAddRows = false;
            this.kryptonDataGridView1.AllowUserToDeleteRows = false;
            this.kryptonDataGridView1.AllowUserToResizeColumns = false;
            this.kryptonDataGridView1.AllowUserToResizeRows = false;
            this.kryptonDataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.kryptonDataGridView1.ColumnHeadersHeight = 38;
            this.kryptonDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.kryptonDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PasswordId,
            this.EmailorUsername,
            this.Password,
            this.ConfirmPassword,
            this.Url,
            this.DateOfCreation,
            this.Copy,
            this.Edit,
            this.Delete});
            this.kryptonDataGridView1.Location = new System.Drawing.Point(0, 45);
            this.kryptonDataGridView1.Name = "kryptonDataGridView1";
            this.kryptonDataGridView1.ReadOnly = true;
            this.kryptonDataGridView1.RowHeadersVisible = false;
            this.kryptonDataGridView1.RowHeadersWidth = 4;
            this.kryptonDataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.kryptonDataGridView1.RowTemplate.Height = 45;
            this.kryptonDataGridView1.RowTemplate.ReadOnly = true;
            this.kryptonDataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.kryptonDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.kryptonDataGridView1.Size = new System.Drawing.Size(615, 516);
            this.kryptonDataGridView1.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(43)))));
            this.kryptonDataGridView1.StateCommon.Background.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(43)))));
            this.kryptonDataGridView1.StateCommon.Background.ColorAngle = 45F;
            this.kryptonDataGridView1.StateCommon.Background.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonDataGridView1.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.kryptonDataGridView1.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(43)))));
            this.kryptonDataGridView1.StateCommon.DataCell.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(113)))));
            this.kryptonDataGridView1.StateCommon.DataCell.Back.ColorAngle = 45F;
            this.kryptonDataGridView1.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(113)))));
            this.kryptonDataGridView1.StateCommon.DataCell.Border.Color2 = System.Drawing.Color.Black;
            this.kryptonDataGridView1.StateCommon.DataCell.Border.ColorAngle = 45F;
            this.kryptonDataGridView1.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonDataGridView1.StateCommon.DataCell.Border.Rounding = 10;
            this.kryptonDataGridView1.StateCommon.DataCell.Content.Color1 = System.Drawing.Color.White;
            this.kryptonDataGridView1.StateCommon.DataCell.Content.Color2 = System.Drawing.Color.White;
            this.kryptonDataGridView1.StateCommon.DataCell.Content.ColorAngle = 45F;
            this.kryptonDataGridView1.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonDataGridView1.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.kryptonDataGridView1.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(113)))));
            this.kryptonDataGridView1.StateCommon.HeaderColumn.Back.ColorAngle = 45F;
            this.kryptonDataGridView1.StateCommon.HeaderColumn.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonDataGridView1.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(113)))));
            this.kryptonDataGridView1.StateCommon.HeaderColumn.Border.Color2 = System.Drawing.Color.Black;
            this.kryptonDataGridView1.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonDataGridView1.StateCommon.HeaderColumn.Border.Rounding = 10;
            this.kryptonDataGridView1.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.kryptonDataGridView1.StateCommon.HeaderColumn.Content.Color2 = System.Drawing.Color.White;
            this.kryptonDataGridView1.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonDataGridView1.StateCommon.HeaderRow.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.kryptonDataGridView1.StateCommon.HeaderRow.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(113)))));
            this.kryptonDataGridView1.StateCommon.HeaderRow.Back.ColorAngle = 45F;
            this.kryptonDataGridView1.StateCommon.HeaderRow.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonDataGridView1.StateCommon.HeaderRow.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(113)))));
            this.kryptonDataGridView1.StateCommon.HeaderRow.Border.Color2 = System.Drawing.Color.Black;
            this.kryptonDataGridView1.StateCommon.HeaderRow.Border.ColorAngle = 45F;
            this.kryptonDataGridView1.StateCommon.HeaderRow.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonDataGridView1.StateCommon.HeaderRow.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonDataGridView1.StateCommon.HeaderRow.Border.Rounding = 10;
            this.kryptonDataGridView1.StateCommon.HeaderRow.Content.Color1 = System.Drawing.Color.White;
            this.kryptonDataGridView1.StateCommon.HeaderRow.Content.Color2 = System.Drawing.Color.White;
            this.kryptonDataGridView1.StateCommon.HeaderRow.Content.ColorAngle = 45F;
            this.kryptonDataGridView1.TabIndex = 0;
            this.kryptonDataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kryptonDataGridView1_CellClick);
            this.kryptonDataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.kryptonDataGridView1_CellFormatting);
            this.kryptonDataGridView1.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonDataGridView1_Paint);
            // 
            // PasswordId
            // 
            this.PasswordId.DataPropertyName = "PasswordId";
            this.PasswordId.FillWeight = 50F;
            this.PasswordId.HeaderText = "PasswordId";
            this.PasswordId.Name = "PasswordId";
            this.PasswordId.ReadOnly = true;
            // 
            // EmailorUsername
            // 
            this.EmailorUsername.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EmailorUsername.DataPropertyName = "EmailorUsername";
            this.EmailorUsername.HeaderText = "Username / Email";
            this.EmailorUsername.Name = "EmailorUsername";
            this.EmailorUsername.ReadOnly = true;
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            this.Password.FillWeight = 50F;
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            // 
            // ConfirmPassword
            // 
            this.ConfirmPassword.DataPropertyName = "ConfirmPassword";
            this.ConfirmPassword.HeaderText = "ConfirmPassword";
            this.ConfirmPassword.Name = "ConfirmPassword";
            this.ConfirmPassword.ReadOnly = true;
            // 
            // Url
            // 
            this.Url.DataPropertyName = "Url";
            this.Url.FillWeight = 50F;
            this.Url.HeaderText = "Url";
            this.Url.Name = "Url";
            this.Url.ReadOnly = true;
            // 
            // DateOfCreation
            // 
            this.DateOfCreation.DataPropertyName = "DateofRegistration";
            this.DateOfCreation.FillWeight = 50F;
            this.DateOfCreation.HeaderText = "Date Of Creation";
            this.DateOfCreation.Name = "DateOfCreation";
            this.DateOfCreation.ReadOnly = true;
            // 
            // Copy
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Quicksand", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.Copy.DefaultCellStyle = dataGridViewCellStyle1;
            this.Copy.FillWeight = 50F;
            this.Copy.HeaderText = "Copy";
            this.Copy.Name = "Copy";
            this.Copy.ReadOnly = true;
            this.Copy.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Copy.Text = "Copy";
            this.Copy.UseColumnTextForButtonValue = true;
            // 
            // Edit
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Teal;
            this.Edit.DefaultCellStyle = dataGridViewCellStyle2;
            this.Edit.FillWeight = 50F;
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.Delete.DefaultCellStyle = dataGridViewCellStyle3;
            this.Delete.FillWeight = 50F;
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(226, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 24);
            this.label1.TabIndex = 27;
            this.label1.Text = "Passwords";
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Quicksand", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblSearch.Location = new System.Drawing.Point(353, 11);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(58, 23);
            this.lblSearch.TabIndex = 26;
            this.lblSearch.Text = "Search";
            this.lblSearch.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(417, 6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(186, 33);
            this.txtSearch.StateCommon.Back.Color1 = System.Drawing.Color.DarkSlateGray;
            this.txtSearch.StateCommon.Border.Color1 = System.Drawing.Color.DarkSlateGray;
            this.txtSearch.StateCommon.Border.Color2 = System.Drawing.Color.DarkSlateGray;
            this.txtSearch.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSearch.StateCommon.Border.Rounding = 10;
            this.txtSearch.StateCommon.Content.Color1 = System.Drawing.Color.White;
            this.txtSearch.StateCommon.Content.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.TabIndex = 25;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(260, 564);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Location = new System.Drawing.Point(3, -3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(257, 152);
            this.panel4.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(-3, 6);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(263, 141);
            this.panel6.TabIndex = 4;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(42)))), ((int)(((byte)(47)))));
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Location = new System.Drawing.Point(17, 15);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(230, 109);
            this.panel7.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(31)))), ((int)(((byte)(34)))));
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Location = new System.Drawing.Point(20, 15);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(192, 80);
            this.panel8.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(13)))), ((int)(((byte)(14)))));
            this.panel9.Controls.Add(this.pictureBox1);
            this.panel9.Location = new System.Drawing.Point(21, 14);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(154, 53);
            this.panel9.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnLogOut);
            this.panel3.Controls.Add(this.btnAbout);
            this.panel3.Controls.Add(this.btnAcc);
            this.panel3.Controls.Add(this.btnLockOpt);
            this.panel3.Controls.Add(this.btnBroswerPass);
            this.panel3.Controls.Add(this.btnaddPass);
            this.panel3.Location = new System.Drawing.Point(3, 150);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(257, 414);
            this.panel3.TabIndex = 4;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(14, 347);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.btnLogOut.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(113)))));
            this.btnLogOut.OverrideDefault.Back.ColorAngle = 180F;
            this.btnLogOut.OverrideDefault.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnLogOut.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(113)))));
            this.btnLogOut.OverrideDefault.Border.Color2 = System.Drawing.Color.Black;
            this.btnLogOut.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnLogOut.OverrideDefault.Border.Rounding = 12;
            this.btnLogOut.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnLogOut.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnLogOut.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Quicksand", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnLogOut.Size = new System.Drawing.Size(230, 49);
            this.btnLogOut.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.btnLogOut.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(113)))));
            this.btnLogOut.StateCommon.Back.ColorAngle = 180F;
            this.btnLogOut.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(113)))));
            this.btnLogOut.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.btnLogOut.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnLogOut.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnLogOut.StateCommon.Border.Rounding = 12;
            this.btnLogOut.StateCommon.Border.Width = 1;
            this.btnLogOut.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnLogOut.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Gray;
            this.btnLogOut.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Quicksand", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.btnLogOut.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(113)))));
            this.btnLogOut.StatePressed.Back.ColorAngle = 90F;
            this.btnLogOut.StatePressed.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnLogOut.StatePressed.Border.Color1 = System.Drawing.Color.Black;
            this.btnLogOut.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(113)))));
            this.btnLogOut.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnLogOut.StatePressed.Border.Rounding = 12;
            this.btnLogOut.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnLogOut.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnLogOut.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Quicksand", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.btnLogOut.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(113)))));
            this.btnLogOut.StateTracking.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnLogOut.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(113)))));
            this.btnLogOut.StateTracking.Border.Color2 = System.Drawing.Color.Black;
            this.btnLogOut.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnLogOut.StateTracking.Border.Rounding = 12;
            this.btnLogOut.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnLogOut.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnLogOut.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Quicksand", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.TabIndex = 15;
            this.btnLogOut.Values.Text = "Log Out";
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click_1);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(14, 282);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.btnAbout.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(113)))));
            this.btnAbout.OverrideDefault.Back.ColorAngle = 180F;
            this.btnAbout.OverrideDefault.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAbout.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(113)))));
            this.btnAbout.OverrideDefault.Border.Color2 = System.Drawing.Color.Black;
            this.btnAbout.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAbout.OverrideDefault.Border.Rounding = 12;
            this.btnAbout.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAbout.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnAbout.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Quicksand", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnAbout.Size = new System.Drawing.Size(230, 49);
            this.btnAbout.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.btnAbout.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(113)))));
            this.btnAbout.StateCommon.Back.ColorAngle = 180F;
            this.btnAbout.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(113)))));
            this.btnAbout.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.btnAbout.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAbout.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAbout.StateCommon.Border.Rounding = 12;
            this.btnAbout.StateCommon.Border.Width = 1;
            this.btnAbout.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAbout.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Gray;
            this.btnAbout.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Quicksand", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.btnAbout.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(113)))));
            this.btnAbout.StatePressed.Back.ColorAngle = 90F;
            this.btnAbout.StatePressed.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAbout.StatePressed.Border.Color1 = System.Drawing.Color.Black;
            this.btnAbout.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(113)))));
            this.btnAbout.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAbout.StatePressed.Border.Rounding = 12;
            this.btnAbout.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAbout.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnAbout.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Quicksand", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.btnAbout.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(113)))));
            this.btnAbout.StateTracking.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAbout.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(113)))));
            this.btnAbout.StateTracking.Border.Color2 = System.Drawing.Color.Black;
            this.btnAbout.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAbout.StateTracking.Border.Rounding = 12;
            this.btnAbout.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAbout.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnAbout.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Quicksand", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.TabIndex = 14;
            this.btnAbout.Values.Text = "About";
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnAcc
            // 
            this.btnAcc.Location = new System.Drawing.Point(14, 218);
            this.btnAcc.Name = "btnAcc";
            this.btnAcc.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.btnAcc.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(113)))));
            this.btnAcc.OverrideDefault.Back.ColorAngle = 180F;
            this.btnAcc.OverrideDefault.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAcc.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(113)))));
            this.btnAcc.OverrideDefault.Border.Color2 = System.Drawing.Color.Black;
            this.btnAcc.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAcc.OverrideDefault.Border.Rounding = 12;
            this.btnAcc.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAcc.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnAcc.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Quicksand", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcc.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnAcc.Size = new System.Drawing.Size(230, 49);
            this.btnAcc.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.btnAcc.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(113)))));
            this.btnAcc.StateCommon.Back.ColorAngle = 180F;
            this.btnAcc.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(113)))));
            this.btnAcc.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.btnAcc.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAcc.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAcc.StateCommon.Border.Rounding = 12;
            this.btnAcc.StateCommon.Border.Width = 1;
            this.btnAcc.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAcc.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Gray;
            this.btnAcc.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Quicksand", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcc.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.btnAcc.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(113)))));
            this.btnAcc.StatePressed.Back.ColorAngle = 90F;
            this.btnAcc.StatePressed.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAcc.StatePressed.Border.Color1 = System.Drawing.Color.Black;
            this.btnAcc.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(113)))));
            this.btnAcc.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAcc.StatePressed.Border.Rounding = 12;
            this.btnAcc.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAcc.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnAcc.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Quicksand", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcc.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.btnAcc.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(113)))));
            this.btnAcc.StateTracking.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAcc.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(113)))));
            this.btnAcc.StateTracking.Border.Color2 = System.Drawing.Color.Black;
            this.btnAcc.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAcc.StateTracking.Border.Rounding = 12;
            this.btnAcc.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAcc.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnAcc.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Quicksand", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcc.TabIndex = 13;
            this.btnAcc.Values.Text = "My Account";
            this.btnAcc.Click += new System.EventHandler(this.btnAcc_Click);
            // 
            // btnLockOpt
            // 
            this.btnLockOpt.Location = new System.Drawing.Point(14, 153);
            this.btnLockOpt.Name = "btnLockOpt";
            this.btnLockOpt.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.btnLockOpt.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(113)))));
            this.btnLockOpt.OverrideDefault.Back.ColorAngle = 180F;
            this.btnLockOpt.OverrideDefault.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnLockOpt.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(113)))));
            this.btnLockOpt.OverrideDefault.Border.Color2 = System.Drawing.Color.Black;
            this.btnLockOpt.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnLockOpt.OverrideDefault.Border.Rounding = 12;
            this.btnLockOpt.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnLockOpt.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnLockOpt.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Quicksand", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLockOpt.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnLockOpt.Size = new System.Drawing.Size(230, 49);
            this.btnLockOpt.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.btnLockOpt.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(113)))));
            this.btnLockOpt.StateCommon.Back.ColorAngle = 180F;
            this.btnLockOpt.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(113)))));
            this.btnLockOpt.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.btnLockOpt.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnLockOpt.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnLockOpt.StateCommon.Border.Rounding = 12;
            this.btnLockOpt.StateCommon.Border.Width = 1;
            this.btnLockOpt.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnLockOpt.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Gray;
            this.btnLockOpt.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Quicksand", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLockOpt.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.btnLockOpt.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(113)))));
            this.btnLockOpt.StatePressed.Back.ColorAngle = 90F;
            this.btnLockOpt.StatePressed.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnLockOpt.StatePressed.Border.Color1 = System.Drawing.Color.Black;
            this.btnLockOpt.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(113)))));
            this.btnLockOpt.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnLockOpt.StatePressed.Border.Rounding = 12;
            this.btnLockOpt.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnLockOpt.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnLockOpt.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Quicksand", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLockOpt.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.btnLockOpt.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(113)))));
            this.btnLockOpt.StateTracking.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnLockOpt.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(113)))));
            this.btnLockOpt.StateTracking.Border.Color2 = System.Drawing.Color.Black;
            this.btnLockOpt.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnLockOpt.StateTracking.Border.Rounding = 12;
            this.btnLockOpt.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnLockOpt.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnLockOpt.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Quicksand", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLockOpt.TabIndex = 11;
            this.btnLockOpt.Values.Text = "Lock Options";
            this.btnLockOpt.Click += new System.EventHandler(this.btnLockOpt_Click);
            // 
            // btnBroswerPass
            // 
            this.btnBroswerPass.Location = new System.Drawing.Point(14, 87);
            this.btnBroswerPass.Name = "btnBroswerPass";
            this.btnBroswerPass.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.btnBroswerPass.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(113)))));
            this.btnBroswerPass.OverrideDefault.Back.ColorAngle = 180F;
            this.btnBroswerPass.OverrideDefault.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnBroswerPass.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(113)))));
            this.btnBroswerPass.OverrideDefault.Border.Color2 = System.Drawing.Color.Black;
            this.btnBroswerPass.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnBroswerPass.OverrideDefault.Border.Rounding = 12;
            this.btnBroswerPass.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnBroswerPass.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnBroswerPass.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Quicksand", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBroswerPass.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnBroswerPass.Size = new System.Drawing.Size(230, 49);
            this.btnBroswerPass.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.btnBroswerPass.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(113)))));
            this.btnBroswerPass.StateCommon.Back.ColorAngle = 180F;
            this.btnBroswerPass.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(113)))));
            this.btnBroswerPass.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.btnBroswerPass.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnBroswerPass.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnBroswerPass.StateCommon.Border.Rounding = 12;
            this.btnBroswerPass.StateCommon.Border.Width = 1;
            this.btnBroswerPass.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnBroswerPass.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Gray;
            this.btnBroswerPass.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Quicksand", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBroswerPass.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.btnBroswerPass.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(113)))));
            this.btnBroswerPass.StatePressed.Back.ColorAngle = 90F;
            this.btnBroswerPass.StatePressed.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnBroswerPass.StatePressed.Border.Color1 = System.Drawing.Color.Black;
            this.btnBroswerPass.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(113)))));
            this.btnBroswerPass.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnBroswerPass.StatePressed.Border.Rounding = 12;
            this.btnBroswerPass.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnBroswerPass.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnBroswerPass.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Quicksand", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBroswerPass.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.btnBroswerPass.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(113)))));
            this.btnBroswerPass.StateTracking.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnBroswerPass.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(113)))));
            this.btnBroswerPass.StateTracking.Border.Color2 = System.Drawing.Color.Black;
            this.btnBroswerPass.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnBroswerPass.StateTracking.Border.Rounding = 12;
            this.btnBroswerPass.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnBroswerPass.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnBroswerPass.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Quicksand", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBroswerPass.TabIndex = 10;
            this.btnBroswerPass.Values.Text = "Browser Passwords";
            this.btnBroswerPass.Click += new System.EventHandler(this.btnBroswerPass_Click);
            // 
            // btnaddPass
            // 
            this.btnaddPass.Location = new System.Drawing.Point(14, 23);
            this.btnaddPass.Name = "btnaddPass";
            this.btnaddPass.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.btnaddPass.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(113)))));
            this.btnaddPass.OverrideDefault.Back.ColorAngle = 180F;
            this.btnaddPass.OverrideDefault.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnaddPass.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(113)))));
            this.btnaddPass.OverrideDefault.Border.Color2 = System.Drawing.Color.Black;
            this.btnaddPass.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnaddPass.OverrideDefault.Border.Rounding = 12;
            this.btnaddPass.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnaddPass.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnaddPass.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Quicksand", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddPass.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btnaddPass.Size = new System.Drawing.Size(230, 49);
            this.btnaddPass.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.btnaddPass.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(113)))));
            this.btnaddPass.StateCommon.Back.ColorAngle = 180F;
            this.btnaddPass.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(113)))));
            this.btnaddPass.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.btnaddPass.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnaddPass.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnaddPass.StateCommon.Border.Rounding = 12;
            this.btnaddPass.StateCommon.Border.Width = 1;
            this.btnaddPass.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnaddPass.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Gray;
            this.btnaddPass.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Quicksand", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddPass.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.btnaddPass.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(113)))));
            this.btnaddPass.StatePressed.Back.ColorAngle = 90F;
            this.btnaddPass.StatePressed.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnaddPass.StatePressed.Border.Color1 = System.Drawing.Color.Black;
            this.btnaddPass.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(113)))));
            this.btnaddPass.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnaddPass.StatePressed.Border.Rounding = 12;
            this.btnaddPass.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnaddPass.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnaddPass.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Quicksand", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddPass.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(51)))), ((int)(((byte)(57)))));
            this.btnaddPass.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(113)))));
            this.btnaddPass.StateTracking.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnaddPass.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(113)))));
            this.btnaddPass.StateTracking.Border.Color2 = System.Drawing.Color.Black;
            this.btnaddPass.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnaddPass.StateTracking.Border.Rounding = 12;
            this.btnaddPass.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnaddPass.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnaddPass.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Quicksand", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddPass.TabIndex = 9;
            this.btnaddPass.Values.Text = "Add New";
            this.btnaddPass.Click += new System.EventHandler(this.btnaddPass_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "Mona - Background";
            this.notifyIcon1.BalloonTipTitle = "Mona";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // Mona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Quicksand", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "Mona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(43)))));
            this.StateActive.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(43)))));
            this.StateActive.Back.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.StateActive.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(31)))));
            this.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(31)))));
            this.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(43)))));
            this.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(113)))));
            this.StateCommon.Back.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Control;
            this.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(113)))));
            this.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(103)))), ((int)(((byte)(113)))));
            this.StateCommon.Border.ColorAngle = 45F;
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 20;
            this.StateCommon.Header.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(43)))));
            this.StateCommon.Header.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(43)))));
            this.StateCommon.Header.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(43)))));
            this.StateCommon.Header.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(35)))), ((int)(((byte)(43)))));
            this.StateCommon.Header.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Header.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.StateCommon.Header.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.Text = "Mona";
            this.Activated += new System.EventHandler(this.Mona_Activated);
            this.Resize += new System.EventHandler(this.Mona_Resize);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnLogOut;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAbout;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAcc;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnLockOpt;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnBroswerPass;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnaddPass;
        private System.Windows.Forms.Panel panel5;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PasswordId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailorUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConfirmPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn Url;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfCreation;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewButtonColumn Copy;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewButtonColumn Edit;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewButtonColumn Delete;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

