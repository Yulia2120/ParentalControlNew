namespace ParentalControlNew
{
    partial class LoginForm
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
            this.kryptonPalette = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbUser = new System.Windows.Forms.Label();
            this.txtBoxUser = new System.Windows.Forms.TextBox();
            this.txtBoxPass = new System.Windows.Forms.TextBox();
            this.lbPass = new System.Windows.Forms.Label();
            this.kryptonBtnLogin = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonBtnExit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPalette
            // 
            this.kryptonPalette.FormStyles.FormMain.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(230)))), ((int)(((byte)(249)))));
            this.kryptonPalette.FormStyles.FormMain.StateActive.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(230)))), ((int)(((byte)(249)))));
            this.kryptonPalette.FormStyles.FormMain.StateActive.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette.FormStyles.FormMain.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(230)))), ((int)(((byte)(249)))));
            this.kryptonPalette.FormStyles.FormMain.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(230)))), ((int)(((byte)(249)))));
            this.kryptonPalette.FormStyles.FormMain.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette.FormStyles.FormMain.StateActive.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(230)))), ((int)(((byte)(249)))));
            this.kryptonPalette.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(230)))), ((int)(((byte)(249)))));
            this.kryptonPalette.FormStyles.FormMain.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette.FormStyles.FormMain.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(230)))), ((int)(((byte)(249)))));
            this.kryptonPalette.FormStyles.FormMain.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(230)))), ((int)(((byte)(249)))));
            this.kryptonPalette.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette.FormStyles.FormMain.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette.FormStyles.FormMain.StateCommon.Border.Rounding = 20;
            this.kryptonPalette.FormStyles.FormMain.StateCommon.Border.Width = 1;
            this.kryptonPalette.FormStyles.FormMain.StateInactive.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette.FormStyles.FormMain.StateInactive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette.FormStyles.FormMain.StateInactive.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(230)))), ((int)(((byte)(249)))));
            this.kryptonPalette.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(230)))), ((int)(((byte)(249)))));
            this.kryptonPalette.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            this.kryptonPalette.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(15, -1, -1, -1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ParentalControlNew.Properties.Resources.login;
            this.pictureBox1.Location = new System.Drawing.Point(37, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Location = new System.Drawing.Point(235, 81);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(63, 13);
            this.lbUser.TabIndex = 1;
            this.lbUser.Text = "User Name:";
            // 
            // txtBoxUser
            // 
            this.txtBoxUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(230)))), ((int)(((byte)(249)))));
            this.txtBoxUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxUser.Location = new System.Drawing.Point(318, 77);
            this.txtBoxUser.Name = "txtBoxUser";
            this.txtBoxUser.Size = new System.Drawing.Size(164, 20);
            this.txtBoxUser.TabIndex = 2;
            // 
            // txtBoxPass
            // 
            this.txtBoxPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(230)))), ((int)(((byte)(249)))));
            this.txtBoxPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxPass.Location = new System.Drawing.Point(318, 134);
            this.txtBoxPass.MaximumSize = new System.Drawing.Size(164, 20);
            this.txtBoxPass.MinimumSize = new System.Drawing.Size(164, 20);
            this.txtBoxPass.Name = "txtBoxPass";
            this.txtBoxPass.Size = new System.Drawing.Size(164, 20);
            this.txtBoxPass.TabIndex = 4;
            this.txtBoxPass.UseSystemPasswordChar = true;
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Location = new System.Drawing.Point(235, 138);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(56, 13);
            this.lbPass.TabIndex = 3;
            this.lbPass.Text = "Password:";
            // 
            // kryptonBtnLogin
            // 
            this.kryptonBtnLogin.Location = new System.Drawing.Point(159, 242);
            this.kryptonBtnLogin.Name = "kryptonBtnLogin";
            this.kryptonBtnLogin.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.kryptonBtnLogin.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.kryptonBtnLogin.OverrideDefault.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonBtnLogin.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.kryptonBtnLogin.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.kryptonBtnLogin.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonBtnLogin.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonBtnLogin.OverrideDefault.Border.Rounding = 20;
            this.kryptonBtnLogin.OverrideDefault.Border.Width = 1;
            this.kryptonBtnLogin.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.kryptonBtnLogin.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.kryptonBtnLogin.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonBtnLogin.OverrideFocus.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonBtnLogin.OverrideFocus.Border.Rounding = 20;
            this.kryptonBtnLogin.OverrideFocus.Border.Width = 1;
            this.kryptonBtnLogin.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonBtnLogin.Size = new System.Drawing.Size(150, 43);
            this.kryptonBtnLogin.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.kryptonBtnLogin.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.kryptonBtnLogin.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.kryptonBtnLogin.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(101)))), ((int)(((byte)(255)))));
            this.kryptonBtnLogin.StateCommon.Border.ColorAngle = 45F;
            this.kryptonBtnLogin.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonBtnLogin.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonBtnLogin.StateCommon.Border.Rounding = 20;
            this.kryptonBtnLogin.StateCommon.Border.Width = 1;
            this.kryptonBtnLogin.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonBtnLogin.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonBtnLogin.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kryptonBtnLogin.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.kryptonBtnLogin.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.kryptonBtnLogin.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.kryptonBtnLogin.StateDisabled.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.kryptonBtnLogin.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonBtnLogin.StateDisabled.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonBtnLogin.StateDisabled.Border.Rounding = 20;
            this.kryptonBtnLogin.StateDisabled.Border.Width = 1;
            this.kryptonBtnLogin.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.kryptonBtnLogin.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.kryptonBtnLogin.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.kryptonBtnLogin.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.kryptonBtnLogin.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonBtnLogin.StateNormal.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonBtnLogin.StateNormal.Border.Rounding = 20;
            this.kryptonBtnLogin.StateNormal.Border.Width = 1;
            this.kryptonBtnLogin.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(101)))), ((int)(((byte)(255)))));
            this.kryptonBtnLogin.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(101)))), ((int)(((byte)(255)))));
            this.kryptonBtnLogin.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(101)))), ((int)(((byte)(255)))));
            this.kryptonBtnLogin.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(101)))), ((int)(((byte)(255)))));
            this.kryptonBtnLogin.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonBtnLogin.StatePressed.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonBtnLogin.StatePressed.Border.Rounding = 20;
            this.kryptonBtnLogin.StatePressed.Border.Width = 1;
            this.kryptonBtnLogin.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonBtnLogin.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonBtnLogin.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.kryptonBtnLogin.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.kryptonBtnLogin.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.kryptonBtnLogin.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.kryptonBtnLogin.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonBtnLogin.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonBtnLogin.StateTracking.Border.Rounding = 20;
            this.kryptonBtnLogin.StateTracking.Border.Width = 1;
            this.kryptonBtnLogin.TabIndex = 5;
            this.kryptonBtnLogin.Values.Text = "Login";
            this.kryptonBtnLogin.Click += new System.EventHandler(this.kryptonBtnLogin_Click);
            // 
            // kryptonBtnExit
            // 
            this.kryptonBtnExit.Location = new System.Drawing.Point(348, 242);
            this.kryptonBtnExit.Name = "kryptonBtnExit";
            this.kryptonBtnExit.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.kryptonBtnExit.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.kryptonBtnExit.OverrideDefault.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonBtnExit.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.kryptonBtnExit.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.kryptonBtnExit.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonBtnExit.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonBtnExit.OverrideDefault.Border.Rounding = 20;
            this.kryptonBtnExit.OverrideDefault.Border.Width = 1;
            this.kryptonBtnExit.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.kryptonBtnExit.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.kryptonBtnExit.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonBtnExit.OverrideFocus.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonBtnExit.OverrideFocus.Border.Rounding = 20;
            this.kryptonBtnExit.OverrideFocus.Border.Width = 1;
            this.kryptonBtnExit.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonBtnExit.Size = new System.Drawing.Size(150, 43);
            this.kryptonBtnExit.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.kryptonBtnExit.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.kryptonBtnExit.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.kryptonBtnExit.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(101)))), ((int)(((byte)(255)))));
            this.kryptonBtnExit.StateCommon.Border.ColorAngle = 45F;
            this.kryptonBtnExit.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonBtnExit.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonBtnExit.StateCommon.Border.Rounding = 20;
            this.kryptonBtnExit.StateCommon.Border.Width = 1;
            this.kryptonBtnExit.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonBtnExit.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonBtnExit.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kryptonBtnExit.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.kryptonBtnExit.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.kryptonBtnExit.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.kryptonBtnExit.StateDisabled.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.kryptonBtnExit.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonBtnExit.StateDisabled.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonBtnExit.StateDisabled.Border.Rounding = 20;
            this.kryptonBtnExit.StateDisabled.Border.Width = 1;
            this.kryptonBtnExit.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.kryptonBtnExit.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.kryptonBtnExit.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.kryptonBtnExit.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.kryptonBtnExit.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonBtnExit.StateNormal.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonBtnExit.StateNormal.Border.Rounding = 20;
            this.kryptonBtnExit.StateNormal.Border.Width = 1;
            this.kryptonBtnExit.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(101)))), ((int)(((byte)(255)))));
            this.kryptonBtnExit.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(101)))), ((int)(((byte)(255)))));
            this.kryptonBtnExit.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(101)))), ((int)(((byte)(255)))));
            this.kryptonBtnExit.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(101)))), ((int)(((byte)(255)))));
            this.kryptonBtnExit.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonBtnExit.StatePressed.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonBtnExit.StatePressed.Border.Rounding = 20;
            this.kryptonBtnExit.StatePressed.Border.Width = 1;
            this.kryptonBtnExit.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonBtnExit.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonBtnExit.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.kryptonBtnExit.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.kryptonBtnExit.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.kryptonBtnExit.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.kryptonBtnExit.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonBtnExit.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonBtnExit.StateTracking.Border.Rounding = 20;
            this.kryptonBtnExit.StateTracking.Border.Width = 1;
            this.kryptonBtnExit.TabIndex = 6;
            this.kryptonBtnExit.Values.Text = "Exit";
            this.kryptonBtnExit.Click += new System.EventHandler(this.kryptonBtnExit_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(230)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(528, 312);
            this.Controls.Add(this.kryptonBtnExit);
            this.Controls.Add(this.kryptonBtnLogin);
            this.Controls.Add(this.txtBoxPass);
            this.Controls.Add(this.lbPass);
            this.Controls.Add(this.txtBoxUser);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoginForm";
            this.Palette = this.kryptonPalette;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.TextBox txtBoxUser;
        private System.Windows.Forms.TextBox txtBoxPass;
        private System.Windows.Forms.Label lbPass;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonBtnLogin;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonBtnExit;
    }
}