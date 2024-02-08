<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    'Inherits System.Windows.Forms.Form
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.txtbx_Name = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.txtbx_URL = New MetroFramework.Controls.MetroTextBox()
        Me.txtbx_Before = New MetroFramework.Controls.MetroTextBox()
        Me.txtbx_After = New MetroFramework.Controls.MetroTextBox()
        Me.lstbx_Data = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MetroLabel12 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.txtbx_CharAfter5 = New MetroFramework.Controls.MetroTextBox()
        Me.txtbx_CharAfter4 = New MetroFramework.Controls.MetroTextBox()
        Me.txtbx_CharAfter3 = New MetroFramework.Controls.MetroTextBox()
        Me.txtbx_CharAfter2 = New MetroFramework.Controls.MetroTextBox()
        Me.txtbx_CharBefore5 = New MetroFramework.Controls.MetroTextBox()
        Me.txtbx_CharBefore4 = New MetroFramework.Controls.MetroTextBox()
        Me.txtbx_CharBefore3 = New MetroFramework.Controls.MetroTextBox()
        Me.txtbx_CharBefore2 = New MetroFramework.Controls.MetroTextBox()
        Me.txtbx_After5 = New MetroFramework.Controls.MetroTextBox()
        Me.txtbx_Before5 = New MetroFramework.Controls.MetroTextBox()
        Me.txtbx_After4 = New MetroFramework.Controls.MetroTextBox()
        Me.txtbx_After3 = New MetroFramework.Controls.MetroTextBox()
        Me.txtbx_After2 = New MetroFramework.Controls.MetroTextBox()
        Me.txtbx_Before4 = New MetroFramework.Controls.MetroTextBox()
        Me.txtbx_Before3 = New MetroFramework.Controls.MetroTextBox()
        Me.txtbx_Before2 = New MetroFramework.Controls.MetroTextBox()
        Me.txtbx_After1 = New MetroFramework.Controls.MetroTextBox()
        Me.txtbx_Before1 = New MetroFramework.Controls.MetroTextBox()
        Me.txtbx_CharAfter1 = New MetroFramework.Controls.MetroTextBox()
        Me.txtbx_CharBefore1 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtbx_Item5 = New MetroFramework.Controls.MetroTextBox()
        Me.txtbx_Item4 = New MetroFramework.Controls.MetroTextBox()
        Me.txtbx_Item3 = New MetroFramework.Controls.MetroTextBox()
        Me.txtbx_Item2 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel14 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel15 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel13 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel16 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel17 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel18 = New MetroFramework.Controls.MetroLabel()
        Me.txtbx_Item1 = New MetroFramework.Controls.MetroTextBox()
        Me.btn_Add1 = New MetroFramework.Controls.MetroButton()
        Me.btn_Add2 = New MetroFramework.Controls.MetroButton()
        Me.btn_Add3 = New MetroFramework.Controls.MetroButton()
        Me.btn_Add4 = New MetroFramework.Controls.MetroButton()
        Me.btn_Add5 = New MetroFramework.Controls.MetroButton()
        Me.btn_Scrape = New MetroFramework.Controls.MetroButton()
        Me.btn_Scrapes = New MetroFramework.Controls.MetroButton()
        Me.txtbx_ItemNumber = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.btn_AddItems = New MetroFramework.Controls.MetroButton()
        Me.btn_StartService = New MetroFramework.Controls.MetroButton()
        Me.lbl_ServiceStatus = New MetroFramework.Controls.MetroLabel()
        Me.ScrapeServiceController = New System.ServiceProcess.ServiceController()
        Me.tmr_ServiceDelay = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 78)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(48, 19)
        Me.MetroLabel1.TabIndex = 1
        Me.MetroLabel1.Text = "Name:"
        '
        'txtbx_Name
        '
        '
        '
        '
        Me.txtbx_Name.CustomButton.Image = Nothing
        Me.txtbx_Name.CustomButton.Location = New System.Drawing.Point(348, 1)
        Me.txtbx_Name.CustomButton.Name = ""
        Me.txtbx_Name.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtbx_Name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtbx_Name.CustomButton.TabIndex = 1
        Me.txtbx_Name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtbx_Name.CustomButton.UseSelectable = True
        Me.txtbx_Name.CustomButton.Visible = False
        Me.txtbx_Name.Lines = New String(-1) {}
        Me.txtbx_Name.Location = New System.Drawing.Point(77, 78)
        Me.txtbx_Name.MaxLength = 32767
        Me.txtbx_Name.Name = "txtbx_Name"
        Me.txtbx_Name.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbx_Name.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtbx_Name.SelectedText = ""
        Me.txtbx_Name.SelectionLength = 0
        Me.txtbx_Name.SelectionStart = 0
        Me.txtbx_Name.Size = New System.Drawing.Size(370, 23)
        Me.txtbx_Name.TabIndex = 2
        Me.txtbx_Name.UseSelectable = True
        Me.txtbx_Name.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtbx_Name.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(36, 107)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(35, 19)
        Me.MetroLabel2.TabIndex = 3
        Me.MetroLabel2.Text = "URL:"
        '
        'txtbx_URL
        '
        '
        '
        '
        Me.txtbx_URL.CustomButton.Image = Nothing
        Me.txtbx_URL.CustomButton.Location = New System.Drawing.Point(348, 1)
        Me.txtbx_URL.CustomButton.Name = ""
        Me.txtbx_URL.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtbx_URL.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtbx_URL.CustomButton.TabIndex = 1
        Me.txtbx_URL.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtbx_URL.CustomButton.UseSelectable = True
        Me.txtbx_URL.CustomButton.Visible = False
        Me.txtbx_URL.Lines = New String(-1) {}
        Me.txtbx_URL.Location = New System.Drawing.Point(77, 107)
        Me.txtbx_URL.MaxLength = 32767
        Me.txtbx_URL.Name = "txtbx_URL"
        Me.txtbx_URL.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbx_URL.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtbx_URL.SelectedText = ""
        Me.txtbx_URL.SelectionLength = 0
        Me.txtbx_URL.SelectionStart = 0
        Me.txtbx_URL.Size = New System.Drawing.Size(370, 23)
        Me.txtbx_URL.TabIndex = 4
        Me.txtbx_URL.UseSelectable = True
        Me.txtbx_URL.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtbx_URL.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtbx_Before
        '
        '
        '
        '
        Me.txtbx_Before.CustomButton.Image = Nothing
        Me.txtbx_Before.CustomButton.Location = New System.Drawing.Point(90, 1)
        Me.txtbx_Before.CustomButton.Name = ""
        Me.txtbx_Before.CustomButton.Size = New System.Drawing.Size(131, 131)
        Me.txtbx_Before.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtbx_Before.CustomButton.TabIndex = 1
        Me.txtbx_Before.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtbx_Before.CustomButton.UseSelectable = True
        Me.txtbx_Before.CustomButton.Visible = False
        Me.txtbx_Before.Lines = New String() {"data-variable=""precip_today"""}
        Me.txtbx_Before.Location = New System.Drawing.Point(696, 194)
        Me.txtbx_Before.MaxLength = 32767
        Me.txtbx_Before.Multiline = True
        Me.txtbx_Before.Name = "txtbx_Before"
        Me.txtbx_Before.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbx_Before.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtbx_Before.SelectedText = ""
        Me.txtbx_Before.SelectionLength = 0
        Me.txtbx_Before.SelectionStart = 0
        Me.txtbx_Before.Size = New System.Drawing.Size(222, 133)
        Me.txtbx_Before.TabIndex = 6
        Me.txtbx_Before.Text = "data-variable=""precip_today"""
        Me.txtbx_Before.UseSelectable = True
        Me.txtbx_Before.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtbx_Before.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtbx_After
        '
        '
        '
        '
        Me.txtbx_After.CustomButton.Image = Nothing
        Me.txtbx_After.CustomButton.Location = New System.Drawing.Point(94, 1)
        Me.txtbx_After.CustomButton.Name = ""
        Me.txtbx_After.CustomButton.Size = New System.Drawing.Size(131, 131)
        Me.txtbx_After.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtbx_After.CustomButton.TabIndex = 1
        Me.txtbx_After.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtbx_After.CustomButton.UseSelectable = True
        Me.txtbx_After.CustomButton.Visible = False
        Me.txtbx_After.Lines = New String() {"</span>"}
        Me.txtbx_After.Location = New System.Drawing.Point(696, 369)
        Me.txtbx_After.MaxLength = 32767
        Me.txtbx_After.Multiline = True
        Me.txtbx_After.Name = "txtbx_After"
        Me.txtbx_After.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbx_After.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtbx_After.SelectedText = ""
        Me.txtbx_After.SelectionLength = 0
        Me.txtbx_After.SelectionStart = 0
        Me.txtbx_After.Size = New System.Drawing.Size(226, 133)
        Me.txtbx_After.TabIndex = 7
        Me.txtbx_After.Text = "</span>"
        Me.txtbx_After.UseSelectable = True
        Me.txtbx_After.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtbx_After.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lstbx_Data
        '
        Me.lstbx_Data.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstbx_Data.FormattingEnabled = True
        Me.lstbx_Data.HorizontalScrollbar = True
        Me.lstbx_Data.Location = New System.Drawing.Point(10, 20)
        Me.lstbx_Data.Name = "lstbx_Data"
        Me.lstbx_Data.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.lstbx_Data.Size = New System.Drawing.Size(452, 143)
        Me.lstbx_Data.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MetroLabel12)
        Me.GroupBox1.Controls.Add(Me.MetroLabel11)
        Me.GroupBox1.Controls.Add(Me.MetroLabel10)
        Me.GroupBox1.Controls.Add(Me.MetroLabel8)
        Me.GroupBox1.Controls.Add(Me.MetroLabel7)
        Me.GroupBox1.Controls.Add(Me.txtbx_CharAfter5)
        Me.GroupBox1.Controls.Add(Me.txtbx_CharAfter4)
        Me.GroupBox1.Controls.Add(Me.txtbx_CharAfter3)
        Me.GroupBox1.Controls.Add(Me.txtbx_CharAfter2)
        Me.GroupBox1.Controls.Add(Me.txtbx_CharBefore5)
        Me.GroupBox1.Controls.Add(Me.txtbx_CharBefore4)
        Me.GroupBox1.Controls.Add(Me.txtbx_CharBefore3)
        Me.GroupBox1.Controls.Add(Me.txtbx_CharBefore2)
        Me.GroupBox1.Controls.Add(Me.txtbx_After5)
        Me.GroupBox1.Controls.Add(Me.txtbx_Before5)
        Me.GroupBox1.Controls.Add(Me.txtbx_After4)
        Me.GroupBox1.Controls.Add(Me.txtbx_After3)
        Me.GroupBox1.Controls.Add(Me.txtbx_After2)
        Me.GroupBox1.Controls.Add(Me.txtbx_Before4)
        Me.GroupBox1.Controls.Add(Me.txtbx_Before3)
        Me.GroupBox1.Controls.Add(Me.txtbx_Before2)
        Me.GroupBox1.Controls.Add(Me.txtbx_After1)
        Me.GroupBox1.Controls.Add(Me.txtbx_Before1)
        Me.GroupBox1.Controls.Add(Me.txtbx_CharAfter1)
        Me.GroupBox1.Controls.Add(Me.txtbx_CharBefore1)
        Me.GroupBox1.Controls.Add(Me.MetroLabel6)
        Me.GroupBox1.Controls.Add(Me.MetroLabel5)
        Me.GroupBox1.Controls.Add(Me.MetroLabel4)
        Me.GroupBox1.Controls.Add(Me.MetroLabel3)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 154)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(604, 193)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "HTML"
        '
        'MetroLabel12
        '
        Me.MetroLabel12.AutoSize = True
        Me.MetroLabel12.Location = New System.Drawing.Point(6, 158)
        Me.MetroLabel12.Name = "MetroLabel12"
        Me.MetroLabel12.Size = New System.Drawing.Size(16, 19)
        Me.MetroLabel12.TabIndex = 48
        Me.MetroLabel12.Text = "E"
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.Location = New System.Drawing.Point(6, 129)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(18, 19)
        Me.MetroLabel11.TabIndex = 47
        Me.MetroLabel11.Text = "D"
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.Location = New System.Drawing.Point(6, 100)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(18, 19)
        Me.MetroLabel10.TabIndex = 46
        Me.MetroLabel10.Text = "C"
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(6, 71)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(17, 19)
        Me.MetroLabel8.TabIndex = 45
        Me.MetroLabel8.Text = "B"
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(6, 42)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(18, 19)
        Me.MetroLabel7.TabIndex = 44
        Me.MetroLabel7.Text = "A"
        '
        'txtbx_CharAfter5
        '
        '
        '
        '
        Me.txtbx_CharAfter5.CustomButton.Image = Nothing
        Me.txtbx_CharAfter5.CustomButton.Location = New System.Drawing.Point(17, 1)
        Me.txtbx_CharAfter5.CustomButton.Name = ""
        Me.txtbx_CharAfter5.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtbx_CharAfter5.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtbx_CharAfter5.CustomButton.TabIndex = 1
        Me.txtbx_CharAfter5.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtbx_CharAfter5.CustomButton.UseSelectable = True
        Me.txtbx_CharAfter5.CustomButton.Visible = False
        Me.txtbx_CharAfter5.Lines = New String() {"0"}
        Me.txtbx_CharAfter5.Location = New System.Drawing.Point(544, 156)
        Me.txtbx_CharAfter5.MaxLength = 32767
        Me.txtbx_CharAfter5.Name = "txtbx_CharAfter5"
        Me.txtbx_CharAfter5.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbx_CharAfter5.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtbx_CharAfter5.SelectedText = ""
        Me.txtbx_CharAfter5.SelectionLength = 0
        Me.txtbx_CharAfter5.SelectionStart = 0
        Me.txtbx_CharAfter5.Size = New System.Drawing.Size(39, 23)
        Me.txtbx_CharAfter5.TabIndex = 39
        Me.txtbx_CharAfter5.Text = "0"
        Me.txtbx_CharAfter5.UseSelectable = True
        Me.txtbx_CharAfter5.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtbx_CharAfter5.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtbx_CharAfter4
        '
        '
        '
        '
        Me.txtbx_CharAfter4.CustomButton.Image = Nothing
        Me.txtbx_CharAfter4.CustomButton.Location = New System.Drawing.Point(17, 1)
        Me.txtbx_CharAfter4.CustomButton.Name = ""
        Me.txtbx_CharAfter4.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtbx_CharAfter4.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtbx_CharAfter4.CustomButton.TabIndex = 1
        Me.txtbx_CharAfter4.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtbx_CharAfter4.CustomButton.UseSelectable = True
        Me.txtbx_CharAfter4.CustomButton.Visible = False
        Me.txtbx_CharAfter4.Lines = New String() {"0"}
        Me.txtbx_CharAfter4.Location = New System.Drawing.Point(544, 127)
        Me.txtbx_CharAfter4.MaxLength = 32767
        Me.txtbx_CharAfter4.Name = "txtbx_CharAfter4"
        Me.txtbx_CharAfter4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbx_CharAfter4.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtbx_CharAfter4.SelectedText = ""
        Me.txtbx_CharAfter4.SelectionLength = 0
        Me.txtbx_CharAfter4.SelectionStart = 0
        Me.txtbx_CharAfter4.Size = New System.Drawing.Size(39, 23)
        Me.txtbx_CharAfter4.TabIndex = 38
        Me.txtbx_CharAfter4.Text = "0"
        Me.txtbx_CharAfter4.UseSelectable = True
        Me.txtbx_CharAfter4.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtbx_CharAfter4.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtbx_CharAfter3
        '
        '
        '
        '
        Me.txtbx_CharAfter3.CustomButton.Image = Nothing
        Me.txtbx_CharAfter3.CustomButton.Location = New System.Drawing.Point(17, 1)
        Me.txtbx_CharAfter3.CustomButton.Name = ""
        Me.txtbx_CharAfter3.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtbx_CharAfter3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtbx_CharAfter3.CustomButton.TabIndex = 1
        Me.txtbx_CharAfter3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtbx_CharAfter3.CustomButton.UseSelectable = True
        Me.txtbx_CharAfter3.CustomButton.Visible = False
        Me.txtbx_CharAfter3.Lines = New String() {"0"}
        Me.txtbx_CharAfter3.Location = New System.Drawing.Point(544, 98)
        Me.txtbx_CharAfter3.MaxLength = 32767
        Me.txtbx_CharAfter3.Name = "txtbx_CharAfter3"
        Me.txtbx_CharAfter3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbx_CharAfter3.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtbx_CharAfter3.SelectedText = ""
        Me.txtbx_CharAfter3.SelectionLength = 0
        Me.txtbx_CharAfter3.SelectionStart = 0
        Me.txtbx_CharAfter3.Size = New System.Drawing.Size(39, 23)
        Me.txtbx_CharAfter3.TabIndex = 37
        Me.txtbx_CharAfter3.Text = "0"
        Me.txtbx_CharAfter3.UseSelectable = True
        Me.txtbx_CharAfter3.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtbx_CharAfter3.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtbx_CharAfter2
        '
        '
        '
        '
        Me.txtbx_CharAfter2.CustomButton.Image = Nothing
        Me.txtbx_CharAfter2.CustomButton.Location = New System.Drawing.Point(17, 1)
        Me.txtbx_CharAfter2.CustomButton.Name = ""
        Me.txtbx_CharAfter2.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtbx_CharAfter2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtbx_CharAfter2.CustomButton.TabIndex = 1
        Me.txtbx_CharAfter2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtbx_CharAfter2.CustomButton.UseSelectable = True
        Me.txtbx_CharAfter2.CustomButton.Visible = False
        Me.txtbx_CharAfter2.Lines = New String() {"0"}
        Me.txtbx_CharAfter2.Location = New System.Drawing.Point(544, 69)
        Me.txtbx_CharAfter2.MaxLength = 32767
        Me.txtbx_CharAfter2.Name = "txtbx_CharAfter2"
        Me.txtbx_CharAfter2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbx_CharAfter2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtbx_CharAfter2.SelectedText = ""
        Me.txtbx_CharAfter2.SelectionLength = 0
        Me.txtbx_CharAfter2.SelectionStart = 0
        Me.txtbx_CharAfter2.Size = New System.Drawing.Size(39, 23)
        Me.txtbx_CharAfter2.TabIndex = 36
        Me.txtbx_CharAfter2.Text = "0"
        Me.txtbx_CharAfter2.UseSelectable = True
        Me.txtbx_CharAfter2.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtbx_CharAfter2.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtbx_CharBefore5
        '
        '
        '
        '
        Me.txtbx_CharBefore5.CustomButton.Image = Nothing
        Me.txtbx_CharBefore5.CustomButton.Location = New System.Drawing.Point(17, 1)
        Me.txtbx_CharBefore5.CustomButton.Name = ""
        Me.txtbx_CharBefore5.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtbx_CharBefore5.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtbx_CharBefore5.CustomButton.TabIndex = 1
        Me.txtbx_CharBefore5.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtbx_CharBefore5.CustomButton.UseSelectable = True
        Me.txtbx_CharBefore5.CustomButton.Visible = False
        Me.txtbx_CharBefore5.Lines = New String() {"0"}
        Me.txtbx_CharBefore5.Location = New System.Drawing.Point(253, 156)
        Me.txtbx_CharBefore5.MaxLength = 32767
        Me.txtbx_CharBefore5.Name = "txtbx_CharBefore5"
        Me.txtbx_CharBefore5.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbx_CharBefore5.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtbx_CharBefore5.SelectedText = ""
        Me.txtbx_CharBefore5.SelectionLength = 0
        Me.txtbx_CharBefore5.SelectionStart = 0
        Me.txtbx_CharBefore5.Size = New System.Drawing.Size(39, 23)
        Me.txtbx_CharBefore5.TabIndex = 35
        Me.txtbx_CharBefore5.Text = "0"
        Me.txtbx_CharBefore5.UseSelectable = True
        Me.txtbx_CharBefore5.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtbx_CharBefore5.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtbx_CharBefore4
        '
        '
        '
        '
        Me.txtbx_CharBefore4.CustomButton.Image = Nothing
        Me.txtbx_CharBefore4.CustomButton.Location = New System.Drawing.Point(17, 1)
        Me.txtbx_CharBefore4.CustomButton.Name = ""
        Me.txtbx_CharBefore4.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtbx_CharBefore4.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtbx_CharBefore4.CustomButton.TabIndex = 1
        Me.txtbx_CharBefore4.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtbx_CharBefore4.CustomButton.UseSelectable = True
        Me.txtbx_CharBefore4.CustomButton.Visible = False
        Me.txtbx_CharBefore4.Lines = New String() {"0"}
        Me.txtbx_CharBefore4.Location = New System.Drawing.Point(253, 127)
        Me.txtbx_CharBefore4.MaxLength = 32767
        Me.txtbx_CharBefore4.Name = "txtbx_CharBefore4"
        Me.txtbx_CharBefore4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbx_CharBefore4.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtbx_CharBefore4.SelectedText = ""
        Me.txtbx_CharBefore4.SelectionLength = 0
        Me.txtbx_CharBefore4.SelectionStart = 0
        Me.txtbx_CharBefore4.Size = New System.Drawing.Size(39, 23)
        Me.txtbx_CharBefore4.TabIndex = 34
        Me.txtbx_CharBefore4.Text = "0"
        Me.txtbx_CharBefore4.UseSelectable = True
        Me.txtbx_CharBefore4.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtbx_CharBefore4.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtbx_CharBefore3
        '
        '
        '
        '
        Me.txtbx_CharBefore3.CustomButton.Image = Nothing
        Me.txtbx_CharBefore3.CustomButton.Location = New System.Drawing.Point(17, 1)
        Me.txtbx_CharBefore3.CustomButton.Name = ""
        Me.txtbx_CharBefore3.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtbx_CharBefore3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtbx_CharBefore3.CustomButton.TabIndex = 1
        Me.txtbx_CharBefore3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtbx_CharBefore3.CustomButton.UseSelectable = True
        Me.txtbx_CharBefore3.CustomButton.Visible = False
        Me.txtbx_CharBefore3.Lines = New String() {"0"}
        Me.txtbx_CharBefore3.Location = New System.Drawing.Point(253, 98)
        Me.txtbx_CharBefore3.MaxLength = 32767
        Me.txtbx_CharBefore3.Name = "txtbx_CharBefore3"
        Me.txtbx_CharBefore3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbx_CharBefore3.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtbx_CharBefore3.SelectedText = ""
        Me.txtbx_CharBefore3.SelectionLength = 0
        Me.txtbx_CharBefore3.SelectionStart = 0
        Me.txtbx_CharBefore3.Size = New System.Drawing.Size(39, 23)
        Me.txtbx_CharBefore3.TabIndex = 33
        Me.txtbx_CharBefore3.Text = "0"
        Me.txtbx_CharBefore3.UseSelectable = True
        Me.txtbx_CharBefore3.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtbx_CharBefore3.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtbx_CharBefore2
        '
        '
        '
        '
        Me.txtbx_CharBefore2.CustomButton.Image = Nothing
        Me.txtbx_CharBefore2.CustomButton.Location = New System.Drawing.Point(17, 1)
        Me.txtbx_CharBefore2.CustomButton.Name = ""
        Me.txtbx_CharBefore2.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtbx_CharBefore2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtbx_CharBefore2.CustomButton.TabIndex = 1
        Me.txtbx_CharBefore2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtbx_CharBefore2.CustomButton.UseSelectable = True
        Me.txtbx_CharBefore2.CustomButton.Visible = False
        Me.txtbx_CharBefore2.Lines = New String() {"0"}
        Me.txtbx_CharBefore2.Location = New System.Drawing.Point(253, 69)
        Me.txtbx_CharBefore2.MaxLength = 32767
        Me.txtbx_CharBefore2.Name = "txtbx_CharBefore2"
        Me.txtbx_CharBefore2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbx_CharBefore2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtbx_CharBefore2.SelectedText = ""
        Me.txtbx_CharBefore2.SelectionLength = 0
        Me.txtbx_CharBefore2.SelectionStart = 0
        Me.txtbx_CharBefore2.Size = New System.Drawing.Size(39, 23)
        Me.txtbx_CharBefore2.TabIndex = 32
        Me.txtbx_CharBefore2.Text = "0"
        Me.txtbx_CharBefore2.UseSelectable = True
        Me.txtbx_CharBefore2.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtbx_CharBefore2.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtbx_After5
        '
        '
        '
        '
        Me.txtbx_After5.CustomButton.Image = Nothing
        Me.txtbx_After5.CustomButton.Location = New System.Drawing.Point(207, 1)
        Me.txtbx_After5.CustomButton.Name = ""
        Me.txtbx_After5.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtbx_After5.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtbx_After5.CustomButton.TabIndex = 1
        Me.txtbx_After5.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtbx_After5.CustomButton.UseSelectable = True
        Me.txtbx_After5.CustomButton.Visible = False
        Me.txtbx_After5.Lines = New String(-1) {}
        Me.txtbx_After5.Location = New System.Drawing.Point(309, 156)
        Me.txtbx_After5.MaxLength = 32767
        Me.txtbx_After5.Name = "txtbx_After5"
        Me.txtbx_After5.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbx_After5.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtbx_After5.SelectedText = ""
        Me.txtbx_After5.SelectionLength = 0
        Me.txtbx_After5.SelectionStart = 0
        Me.txtbx_After5.Size = New System.Drawing.Size(229, 23)
        Me.txtbx_After5.TabIndex = 31
        Me.txtbx_After5.UseSelectable = True
        Me.txtbx_After5.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtbx_After5.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtbx_Before5
        '
        '
        '
        '
        Me.txtbx_Before5.CustomButton.Image = Nothing
        Me.txtbx_Before5.CustomButton.Location = New System.Drawing.Point(201, 1)
        Me.txtbx_Before5.CustomButton.Name = ""
        Me.txtbx_Before5.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtbx_Before5.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtbx_Before5.CustomButton.TabIndex = 1
        Me.txtbx_Before5.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtbx_Before5.CustomButton.UseSelectable = True
        Me.txtbx_Before5.CustomButton.Visible = False
        Me.txtbx_Before5.Lines = New String(-1) {}
        Me.txtbx_Before5.Location = New System.Drawing.Point(24, 156)
        Me.txtbx_Before5.MaxLength = 32767
        Me.txtbx_Before5.Name = "txtbx_Before5"
        Me.txtbx_Before5.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbx_Before5.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtbx_Before5.SelectedText = ""
        Me.txtbx_Before5.SelectionLength = 0
        Me.txtbx_Before5.SelectionStart = 0
        Me.txtbx_Before5.Size = New System.Drawing.Size(223, 23)
        Me.txtbx_Before5.TabIndex = 30
        Me.txtbx_Before5.UseSelectable = True
        Me.txtbx_Before5.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtbx_Before5.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtbx_After4
        '
        '
        '
        '
        Me.txtbx_After4.CustomButton.Image = Nothing
        Me.txtbx_After4.CustomButton.Location = New System.Drawing.Point(207, 1)
        Me.txtbx_After4.CustomButton.Name = ""
        Me.txtbx_After4.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtbx_After4.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtbx_After4.CustomButton.TabIndex = 1
        Me.txtbx_After4.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtbx_After4.CustomButton.UseSelectable = True
        Me.txtbx_After4.CustomButton.Visible = False
        Me.txtbx_After4.Lines = New String(-1) {}
        Me.txtbx_After4.Location = New System.Drawing.Point(309, 127)
        Me.txtbx_After4.MaxLength = 32767
        Me.txtbx_After4.Name = "txtbx_After4"
        Me.txtbx_After4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbx_After4.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtbx_After4.SelectedText = ""
        Me.txtbx_After4.SelectionLength = 0
        Me.txtbx_After4.SelectionStart = 0
        Me.txtbx_After4.Size = New System.Drawing.Size(229, 23)
        Me.txtbx_After4.TabIndex = 29
        Me.txtbx_After4.UseSelectable = True
        Me.txtbx_After4.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtbx_After4.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtbx_After3
        '
        '
        '
        '
        Me.txtbx_After3.CustomButton.Image = Nothing
        Me.txtbx_After3.CustomButton.Location = New System.Drawing.Point(207, 1)
        Me.txtbx_After3.CustomButton.Name = ""
        Me.txtbx_After3.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtbx_After3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtbx_After3.CustomButton.TabIndex = 1
        Me.txtbx_After3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtbx_After3.CustomButton.UseSelectable = True
        Me.txtbx_After3.CustomButton.Visible = False
        Me.txtbx_After3.Lines = New String(-1) {}
        Me.txtbx_After3.Location = New System.Drawing.Point(309, 98)
        Me.txtbx_After3.MaxLength = 32767
        Me.txtbx_After3.Name = "txtbx_After3"
        Me.txtbx_After3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbx_After3.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtbx_After3.SelectedText = ""
        Me.txtbx_After3.SelectionLength = 0
        Me.txtbx_After3.SelectionStart = 0
        Me.txtbx_After3.Size = New System.Drawing.Size(229, 23)
        Me.txtbx_After3.TabIndex = 28
        Me.txtbx_After3.UseSelectable = True
        Me.txtbx_After3.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtbx_After3.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtbx_After2
        '
        '
        '
        '
        Me.txtbx_After2.CustomButton.Image = Nothing
        Me.txtbx_After2.CustomButton.Location = New System.Drawing.Point(207, 1)
        Me.txtbx_After2.CustomButton.Name = ""
        Me.txtbx_After2.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtbx_After2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtbx_After2.CustomButton.TabIndex = 1
        Me.txtbx_After2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtbx_After2.CustomButton.UseSelectable = True
        Me.txtbx_After2.CustomButton.Visible = False
        Me.txtbx_After2.Lines = New String(-1) {}
        Me.txtbx_After2.Location = New System.Drawing.Point(309, 69)
        Me.txtbx_After2.MaxLength = 32767
        Me.txtbx_After2.Name = "txtbx_After2"
        Me.txtbx_After2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbx_After2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtbx_After2.SelectedText = ""
        Me.txtbx_After2.SelectionLength = 0
        Me.txtbx_After2.SelectionStart = 0
        Me.txtbx_After2.Size = New System.Drawing.Size(229, 23)
        Me.txtbx_After2.TabIndex = 27
        Me.txtbx_After2.UseSelectable = True
        Me.txtbx_After2.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtbx_After2.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtbx_Before4
        '
        '
        '
        '
        Me.txtbx_Before4.CustomButton.Image = Nothing
        Me.txtbx_Before4.CustomButton.Location = New System.Drawing.Point(201, 1)
        Me.txtbx_Before4.CustomButton.Name = ""
        Me.txtbx_Before4.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtbx_Before4.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtbx_Before4.CustomButton.TabIndex = 1
        Me.txtbx_Before4.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtbx_Before4.CustomButton.UseSelectable = True
        Me.txtbx_Before4.CustomButton.Visible = False
        Me.txtbx_Before4.Lines = New String(-1) {}
        Me.txtbx_Before4.Location = New System.Drawing.Point(24, 127)
        Me.txtbx_Before4.MaxLength = 32767
        Me.txtbx_Before4.Name = "txtbx_Before4"
        Me.txtbx_Before4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbx_Before4.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtbx_Before4.SelectedText = ""
        Me.txtbx_Before4.SelectionLength = 0
        Me.txtbx_Before4.SelectionStart = 0
        Me.txtbx_Before4.Size = New System.Drawing.Size(223, 23)
        Me.txtbx_Before4.TabIndex = 26
        Me.txtbx_Before4.UseSelectable = True
        Me.txtbx_Before4.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtbx_Before4.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtbx_Before3
        '
        '
        '
        '
        Me.txtbx_Before3.CustomButton.Image = Nothing
        Me.txtbx_Before3.CustomButton.Location = New System.Drawing.Point(201, 1)
        Me.txtbx_Before3.CustomButton.Name = ""
        Me.txtbx_Before3.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtbx_Before3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtbx_Before3.CustomButton.TabIndex = 1
        Me.txtbx_Before3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtbx_Before3.CustomButton.UseSelectable = True
        Me.txtbx_Before3.CustomButton.Visible = False
        Me.txtbx_Before3.Lines = New String(-1) {}
        Me.txtbx_Before3.Location = New System.Drawing.Point(24, 98)
        Me.txtbx_Before3.MaxLength = 32767
        Me.txtbx_Before3.Name = "txtbx_Before3"
        Me.txtbx_Before3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbx_Before3.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtbx_Before3.SelectedText = ""
        Me.txtbx_Before3.SelectionLength = 0
        Me.txtbx_Before3.SelectionStart = 0
        Me.txtbx_Before3.Size = New System.Drawing.Size(223, 23)
        Me.txtbx_Before3.TabIndex = 25
        Me.txtbx_Before3.UseSelectable = True
        Me.txtbx_Before3.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtbx_Before3.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtbx_Before2
        '
        '
        '
        '
        Me.txtbx_Before2.CustomButton.Image = Nothing
        Me.txtbx_Before2.CustomButton.Location = New System.Drawing.Point(201, 1)
        Me.txtbx_Before2.CustomButton.Name = ""
        Me.txtbx_Before2.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtbx_Before2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtbx_Before2.CustomButton.TabIndex = 1
        Me.txtbx_Before2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtbx_Before2.CustomButton.UseSelectable = True
        Me.txtbx_Before2.CustomButton.Visible = False
        Me.txtbx_Before2.Lines = New String(-1) {}
        Me.txtbx_Before2.Location = New System.Drawing.Point(24, 69)
        Me.txtbx_Before2.MaxLength = 32767
        Me.txtbx_Before2.Name = "txtbx_Before2"
        Me.txtbx_Before2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbx_Before2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtbx_Before2.SelectedText = ""
        Me.txtbx_Before2.SelectionLength = 0
        Me.txtbx_Before2.SelectionStart = 0
        Me.txtbx_Before2.Size = New System.Drawing.Size(223, 23)
        Me.txtbx_Before2.TabIndex = 24
        Me.txtbx_Before2.UseSelectable = True
        Me.txtbx_Before2.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtbx_Before2.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtbx_After1
        '
        '
        '
        '
        Me.txtbx_After1.CustomButton.Image = Nothing
        Me.txtbx_After1.CustomButton.Location = New System.Drawing.Point(207, 1)
        Me.txtbx_After1.CustomButton.Name = ""
        Me.txtbx_After1.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtbx_After1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtbx_After1.CustomButton.TabIndex = 1
        Me.txtbx_After1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtbx_After1.CustomButton.UseSelectable = True
        Me.txtbx_After1.CustomButton.Visible = False
        Me.txtbx_After1.Lines = New String(-1) {}
        Me.txtbx_After1.Location = New System.Drawing.Point(309, 40)
        Me.txtbx_After1.MaxLength = 32767
        Me.txtbx_After1.Name = "txtbx_After1"
        Me.txtbx_After1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbx_After1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtbx_After1.SelectedText = ""
        Me.txtbx_After1.SelectionLength = 0
        Me.txtbx_After1.SelectionStart = 0
        Me.txtbx_After1.Size = New System.Drawing.Size(229, 23)
        Me.txtbx_After1.TabIndex = 23
        Me.txtbx_After1.UseSelectable = True
        Me.txtbx_After1.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtbx_After1.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtbx_Before1
        '
        '
        '
        '
        Me.txtbx_Before1.CustomButton.Image = Nothing
        Me.txtbx_Before1.CustomButton.Location = New System.Drawing.Point(201, 1)
        Me.txtbx_Before1.CustomButton.Name = ""
        Me.txtbx_Before1.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtbx_Before1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtbx_Before1.CustomButton.TabIndex = 1
        Me.txtbx_Before1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtbx_Before1.CustomButton.UseSelectable = True
        Me.txtbx_Before1.CustomButton.Visible = False
        Me.txtbx_Before1.Lines = New String(-1) {}
        Me.txtbx_Before1.Location = New System.Drawing.Point(24, 40)
        Me.txtbx_Before1.MaxLength = 32767
        Me.txtbx_Before1.Name = "txtbx_Before1"
        Me.txtbx_Before1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbx_Before1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtbx_Before1.SelectedText = ""
        Me.txtbx_Before1.SelectionLength = 0
        Me.txtbx_Before1.SelectionStart = 0
        Me.txtbx_Before1.Size = New System.Drawing.Size(223, 23)
        Me.txtbx_Before1.TabIndex = 22
        Me.txtbx_Before1.UseSelectable = True
        Me.txtbx_Before1.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtbx_Before1.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtbx_CharAfter1
        '
        '
        '
        '
        Me.txtbx_CharAfter1.CustomButton.Image = Nothing
        Me.txtbx_CharAfter1.CustomButton.Location = New System.Drawing.Point(17, 1)
        Me.txtbx_CharAfter1.CustomButton.Name = ""
        Me.txtbx_CharAfter1.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtbx_CharAfter1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtbx_CharAfter1.CustomButton.TabIndex = 1
        Me.txtbx_CharAfter1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtbx_CharAfter1.CustomButton.UseSelectable = True
        Me.txtbx_CharAfter1.CustomButton.Visible = False
        Me.txtbx_CharAfter1.Lines = New String() {"0"}
        Me.txtbx_CharAfter1.Location = New System.Drawing.Point(544, 40)
        Me.txtbx_CharAfter1.MaxLength = 32767
        Me.txtbx_CharAfter1.Name = "txtbx_CharAfter1"
        Me.txtbx_CharAfter1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbx_CharAfter1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtbx_CharAfter1.SelectedText = ""
        Me.txtbx_CharAfter1.SelectionLength = 0
        Me.txtbx_CharAfter1.SelectionStart = 0
        Me.txtbx_CharAfter1.Size = New System.Drawing.Size(39, 23)
        Me.txtbx_CharAfter1.TabIndex = 16
        Me.txtbx_CharAfter1.Text = "0"
        Me.txtbx_CharAfter1.UseSelectable = True
        Me.txtbx_CharAfter1.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtbx_CharAfter1.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtbx_CharBefore1
        '
        '
        '
        '
        Me.txtbx_CharBefore1.CustomButton.Image = Nothing
        Me.txtbx_CharBefore1.CustomButton.Location = New System.Drawing.Point(17, 1)
        Me.txtbx_CharBefore1.CustomButton.Name = ""
        Me.txtbx_CharBefore1.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtbx_CharBefore1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtbx_CharBefore1.CustomButton.TabIndex = 1
        Me.txtbx_CharBefore1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtbx_CharBefore1.CustomButton.UseSelectable = True
        Me.txtbx_CharBefore1.CustomButton.Visible = False
        Me.txtbx_CharBefore1.Lines = New String() {"0"}
        Me.txtbx_CharBefore1.Location = New System.Drawing.Point(253, 40)
        Me.txtbx_CharBefore1.MaxLength = 32767
        Me.txtbx_CharBefore1.Name = "txtbx_CharBefore1"
        Me.txtbx_CharBefore1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbx_CharBefore1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtbx_CharBefore1.SelectedText = ""
        Me.txtbx_CharBefore1.SelectionLength = 0
        Me.txtbx_CharBefore1.SelectionStart = 0
        Me.txtbx_CharBefore1.Size = New System.Drawing.Size(39, 23)
        Me.txtbx_CharBefore1.TabIndex = 10
        Me.txtbx_CharBefore1.Text = "0"
        Me.txtbx_CharBefore1.UseSelectable = True
        Me.txtbx_CharBefore1.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtbx_CharBefore1.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(244, 16)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(57, 19)
        Me.MetroLabel6.TabIndex = 13
        Me.MetroLabel6.Text = "Remove"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(533, 16)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(57, 19)
        Me.MetroLabel5.TabIndex = 12
        Me.MetroLabel5.Text = "Remove"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(396, 16)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(38, 19)
        Me.MetroLabel4.TabIndex = 11
        Me.MetroLabel4.Text = "After"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(96, 18)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(48, 19)
        Me.MetroLabel3.TabIndex = 10
        Me.MetroLabel3.Text = "Before"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtbx_Item5)
        Me.GroupBox2.Controls.Add(Me.txtbx_Item4)
        Me.GroupBox2.Controls.Add(Me.txtbx_Item3)
        Me.GroupBox2.Controls.Add(Me.txtbx_Item2)
        Me.GroupBox2.Controls.Add(Me.MetroLabel14)
        Me.GroupBox2.Controls.Add(Me.MetroLabel15)
        Me.GroupBox2.Controls.Add(Me.lstbx_Data)
        Me.GroupBox2.Controls.Add(Me.MetroLabel13)
        Me.GroupBox2.Controls.Add(Me.MetroLabel16)
        Me.GroupBox2.Controls.Add(Me.MetroLabel17)
        Me.GroupBox2.Controls.Add(Me.MetroLabel18)
        Me.GroupBox2.Controls.Add(Me.txtbx_Item1)
        Me.GroupBox2.Controls.Add(Me.btn_Add1)
        Me.GroupBox2.Controls.Add(Me.btn_Add2)
        Me.GroupBox2.Controls.Add(Me.btn_Add3)
        Me.GroupBox2.Controls.Add(Me.btn_Add4)
        Me.GroupBox2.Controls.Add(Me.btn_Add5)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 368)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(604, 180)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DATA"
        '
        'txtbx_Item5
        '
        '
        '
        '
        Me.txtbx_Item5.CustomButton.Image = Nothing
        Me.txtbx_Item5.CustomButton.Location = New System.Drawing.Point(17, 1)
        Me.txtbx_Item5.CustomButton.Name = ""
        Me.txtbx_Item5.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtbx_Item5.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtbx_Item5.CustomButton.TabIndex = 1
        Me.txtbx_Item5.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtbx_Item5.CustomButton.UseSelectable = True
        Me.txtbx_Item5.CustomButton.Visible = False
        Me.txtbx_Item5.Lines = New String(-1) {}
        Me.txtbx_Item5.Location = New System.Drawing.Point(489, 152)
        Me.txtbx_Item5.MaxLength = 32767
        Me.txtbx_Item5.Name = "txtbx_Item5"
        Me.txtbx_Item5.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbx_Item5.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtbx_Item5.SelectedText = ""
        Me.txtbx_Item5.SelectionLength = 0
        Me.txtbx_Item5.SelectionStart = 0
        Me.txtbx_Item5.Size = New System.Drawing.Size(39, 23)
        Me.txtbx_Item5.TabIndex = 58
        Me.txtbx_Item5.UseSelectable = True
        Me.txtbx_Item5.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtbx_Item5.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtbx_Item4
        '
        '
        '
        '
        Me.txtbx_Item4.CustomButton.Image = Nothing
        Me.txtbx_Item4.CustomButton.Location = New System.Drawing.Point(17, 1)
        Me.txtbx_Item4.CustomButton.Name = ""
        Me.txtbx_Item4.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtbx_Item4.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtbx_Item4.CustomButton.TabIndex = 1
        Me.txtbx_Item4.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtbx_Item4.CustomButton.UseSelectable = True
        Me.txtbx_Item4.CustomButton.Visible = False
        Me.txtbx_Item4.Lines = New String(-1) {}
        Me.txtbx_Item4.Location = New System.Drawing.Point(489, 122)
        Me.txtbx_Item4.MaxLength = 32767
        Me.txtbx_Item4.Name = "txtbx_Item4"
        Me.txtbx_Item4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbx_Item4.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtbx_Item4.SelectedText = ""
        Me.txtbx_Item4.SelectionLength = 0
        Me.txtbx_Item4.SelectionStart = 0
        Me.txtbx_Item4.Size = New System.Drawing.Size(39, 23)
        Me.txtbx_Item4.TabIndex = 57
        Me.txtbx_Item4.UseSelectable = True
        Me.txtbx_Item4.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtbx_Item4.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtbx_Item3
        '
        '
        '
        '
        Me.txtbx_Item3.CustomButton.Image = Nothing
        Me.txtbx_Item3.CustomButton.Location = New System.Drawing.Point(17, 1)
        Me.txtbx_Item3.CustomButton.Name = ""
        Me.txtbx_Item3.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtbx_Item3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtbx_Item3.CustomButton.TabIndex = 1
        Me.txtbx_Item3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtbx_Item3.CustomButton.UseSelectable = True
        Me.txtbx_Item3.CustomButton.Visible = False
        Me.txtbx_Item3.Lines = New String(-1) {}
        Me.txtbx_Item3.Location = New System.Drawing.Point(489, 93)
        Me.txtbx_Item3.MaxLength = 32767
        Me.txtbx_Item3.Name = "txtbx_Item3"
        Me.txtbx_Item3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbx_Item3.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtbx_Item3.SelectedText = ""
        Me.txtbx_Item3.SelectionLength = 0
        Me.txtbx_Item3.SelectionStart = 0
        Me.txtbx_Item3.Size = New System.Drawing.Size(39, 23)
        Me.txtbx_Item3.TabIndex = 56
        Me.txtbx_Item3.UseSelectable = True
        Me.txtbx_Item3.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtbx_Item3.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtbx_Item2
        '
        '
        '
        '
        Me.txtbx_Item2.CustomButton.Image = Nothing
        Me.txtbx_Item2.CustomButton.Location = New System.Drawing.Point(17, 1)
        Me.txtbx_Item2.CustomButton.Name = ""
        Me.txtbx_Item2.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtbx_Item2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtbx_Item2.CustomButton.TabIndex = 1
        Me.txtbx_Item2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtbx_Item2.CustomButton.UseSelectable = True
        Me.txtbx_Item2.CustomButton.Visible = False
        Me.txtbx_Item2.Lines = New String(-1) {}
        Me.txtbx_Item2.Location = New System.Drawing.Point(489, 64)
        Me.txtbx_Item2.MaxLength = 32767
        Me.txtbx_Item2.Name = "txtbx_Item2"
        Me.txtbx_Item2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbx_Item2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtbx_Item2.SelectedText = ""
        Me.txtbx_Item2.SelectionLength = 0
        Me.txtbx_Item2.SelectionStart = 0
        Me.txtbx_Item2.Size = New System.Drawing.Size(39, 23)
        Me.txtbx_Item2.TabIndex = 55
        Me.txtbx_Item2.UseSelectable = True
        Me.txtbx_Item2.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtbx_Item2.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel14
        '
        Me.MetroLabel14.AutoSize = True
        Me.MetroLabel14.Location = New System.Drawing.Point(468, 154)
        Me.MetroLabel14.Name = "MetroLabel14"
        Me.MetroLabel14.Size = New System.Drawing.Size(16, 19)
        Me.MetroLabel14.TabIndex = 54
        Me.MetroLabel14.Text = "E"
        '
        'MetroLabel15
        '
        Me.MetroLabel15.AutoSize = True
        Me.MetroLabel15.Location = New System.Drawing.Point(468, 123)
        Me.MetroLabel15.Name = "MetroLabel15"
        Me.MetroLabel15.Size = New System.Drawing.Size(18, 19)
        Me.MetroLabel15.TabIndex = 53
        Me.MetroLabel15.Text = "D"
        '
        'MetroLabel13
        '
        Me.MetroLabel13.AutoSize = True
        Me.MetroLabel13.Location = New System.Drawing.Point(489, 12)
        Me.MetroLabel13.Name = "MetroLabel13"
        Me.MetroLabel13.Size = New System.Drawing.Size(35, 19)
        Me.MetroLabel13.TabIndex = 49
        Me.MetroLabel13.Text = "Item"
        '
        'MetroLabel16
        '
        Me.MetroLabel16.AutoSize = True
        Me.MetroLabel16.Location = New System.Drawing.Point(468, 94)
        Me.MetroLabel16.Name = "MetroLabel16"
        Me.MetroLabel16.Size = New System.Drawing.Size(18, 19)
        Me.MetroLabel16.TabIndex = 52
        Me.MetroLabel16.Text = "C"
        '
        'MetroLabel17
        '
        Me.MetroLabel17.AutoSize = True
        Me.MetroLabel17.Location = New System.Drawing.Point(468, 65)
        Me.MetroLabel17.Name = "MetroLabel17"
        Me.MetroLabel17.Size = New System.Drawing.Size(17, 19)
        Me.MetroLabel17.TabIndex = 51
        Me.MetroLabel17.Text = "B"
        '
        'MetroLabel18
        '
        Me.MetroLabel18.AutoSize = True
        Me.MetroLabel18.Location = New System.Drawing.Point(468, 36)
        Me.MetroLabel18.Name = "MetroLabel18"
        Me.MetroLabel18.Size = New System.Drawing.Size(18, 19)
        Me.MetroLabel18.TabIndex = 50
        Me.MetroLabel18.Text = "A"
        '
        'txtbx_Item1
        '
        '
        '
        '
        Me.txtbx_Item1.CustomButton.Image = Nothing
        Me.txtbx_Item1.CustomButton.Location = New System.Drawing.Point(17, 1)
        Me.txtbx_Item1.CustomButton.Name = ""
        Me.txtbx_Item1.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtbx_Item1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtbx_Item1.CustomButton.TabIndex = 1
        Me.txtbx_Item1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtbx_Item1.CustomButton.UseSelectable = True
        Me.txtbx_Item1.CustomButton.Visible = False
        Me.txtbx_Item1.Lines = New String(-1) {}
        Me.txtbx_Item1.Location = New System.Drawing.Point(489, 34)
        Me.txtbx_Item1.MaxLength = 32767
        Me.txtbx_Item1.Name = "txtbx_Item1"
        Me.txtbx_Item1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbx_Item1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtbx_Item1.SelectedText = ""
        Me.txtbx_Item1.SelectionLength = 0
        Me.txtbx_Item1.SelectionStart = 0
        Me.txtbx_Item1.Size = New System.Drawing.Size(39, 23)
        Me.txtbx_Item1.TabIndex = 49
        Me.txtbx_Item1.UseSelectable = True
        Me.txtbx_Item1.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtbx_Item1.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btn_Add1
        '
        Me.btn_Add1.Location = New System.Drawing.Point(534, 34)
        Me.btn_Add1.Name = "btn_Add1"
        Me.btn_Add1.Size = New System.Drawing.Size(49, 23)
        Me.btn_Add1.TabIndex = 22
        Me.btn_Add1.Text = "Add"
        Me.btn_Add1.UseSelectable = True
        '
        'btn_Add2
        '
        Me.btn_Add2.Location = New System.Drawing.Point(534, 64)
        Me.btn_Add2.Name = "btn_Add2"
        Me.btn_Add2.Size = New System.Drawing.Size(49, 23)
        Me.btn_Add2.TabIndex = 40
        Me.btn_Add2.Text = "Add"
        Me.btn_Add2.UseSelectable = True
        '
        'btn_Add3
        '
        Me.btn_Add3.Location = New System.Drawing.Point(534, 93)
        Me.btn_Add3.Name = "btn_Add3"
        Me.btn_Add3.Size = New System.Drawing.Size(49, 23)
        Me.btn_Add3.TabIndex = 41
        Me.btn_Add3.Text = "Add"
        Me.btn_Add3.UseSelectable = True
        '
        'btn_Add4
        '
        Me.btn_Add4.Location = New System.Drawing.Point(534, 123)
        Me.btn_Add4.Name = "btn_Add4"
        Me.btn_Add4.Size = New System.Drawing.Size(49, 23)
        Me.btn_Add4.TabIndex = 42
        Me.btn_Add4.Text = "Add"
        Me.btn_Add4.UseSelectable = True
        '
        'btn_Add5
        '
        Me.btn_Add5.Location = New System.Drawing.Point(534, 152)
        Me.btn_Add5.Name = "btn_Add5"
        Me.btn_Add5.Size = New System.Drawing.Size(49, 23)
        Me.btn_Add5.TabIndex = 43
        Me.btn_Add5.Text = "Add"
        Me.btn_Add5.UseSelectable = True
        '
        'btn_Scrape
        '
        Me.btn_Scrape.Location = New System.Drawing.Point(456, 78)
        Me.btn_Scrape.Name = "btn_Scrape"
        Me.btn_Scrape.Size = New System.Drawing.Size(75, 23)
        Me.btn_Scrape.TabIndex = 18
        Me.btn_Scrape.Text = "Scrape"
        Me.btn_Scrape.UseSelectable = True
        '
        'btn_Scrapes
        '
        Me.btn_Scrapes.Location = New System.Drawing.Point(542, 78)
        Me.btn_Scrapes.Name = "btn_Scrapes"
        Me.btn_Scrapes.Size = New System.Drawing.Size(75, 23)
        Me.btn_Scrapes.TabIndex = 20
        Me.btn_Scrapes.Text = "Scrapes"
        Me.btn_Scrapes.UseSelectable = True
        '
        'txtbx_ItemNumber
        '
        '
        '
        '
        Me.txtbx_ItemNumber.CustomButton.Image = Nothing
        Me.txtbx_ItemNumber.CustomButton.Location = New System.Drawing.Point(17, 1)
        Me.txtbx_ItemNumber.CustomButton.Name = ""
        Me.txtbx_ItemNumber.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtbx_ItemNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtbx_ItemNumber.CustomButton.TabIndex = 1
        Me.txtbx_ItemNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtbx_ItemNumber.CustomButton.UseSelectable = True
        Me.txtbx_ItemNumber.CustomButton.Visible = False
        Me.txtbx_ItemNumber.Lines = New String(-1) {}
        Me.txtbx_ItemNumber.Location = New System.Drawing.Point(793, 78)
        Me.txtbx_ItemNumber.MaxLength = 32767
        Me.txtbx_ItemNumber.Name = "txtbx_ItemNumber"
        Me.txtbx_ItemNumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbx_ItemNumber.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtbx_ItemNumber.SelectedText = ""
        Me.txtbx_ItemNumber.SelectionLength = 0
        Me.txtbx_ItemNumber.SelectionStart = 0
        Me.txtbx_ItemNumber.Size = New System.Drawing.Size(39, 23)
        Me.txtbx_ItemNumber.TabIndex = 17
        Me.txtbx_ItemNumber.UseSelectable = True
        Me.txtbx_ItemNumber.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtbx_ItemNumber.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(754, 80)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(38, 19)
        Me.MetroLabel9.TabIndex = 21
        Me.MetroLabel9.Text = "Item:"
        '
        'btn_AddItems
        '
        Me.btn_AddItems.Location = New System.Drawing.Point(656, 462)
        Me.btn_AddItems.Name = "btn_AddItems"
        Me.btn_AddItems.Size = New System.Drawing.Size(49, 23)
        Me.btn_AddItems.TabIndex = 59
        Me.btn_AddItems.Text = "Add"
        Me.btn_AddItems.UseSelectable = True
        '
        'btn_StartService
        '
        Me.btn_StartService.Location = New System.Drawing.Point(456, 107)
        Me.btn_StartService.Name = "btn_StartService"
        Me.btn_StartService.Size = New System.Drawing.Size(75, 23)
        Me.btn_StartService.TabIndex = 60
        Me.btn_StartService.Text = "Start Service"
        Me.btn_StartService.UseSelectable = True
        '
        'lbl_ServiceStatus
        '
        Me.lbl_ServiceStatus.AutoSize = True
        Me.lbl_ServiceStatus.Location = New System.Drawing.Point(539, 109)
        Me.lbl_ServiceStatus.Name = "lbl_ServiceStatus"
        Me.lbl_ServiceStatus.Size = New System.Drawing.Size(82, 19)
        Me.lbl_ServiceStatus.TabIndex = 61
        Me.lbl_ServiceStatus.Text = "Not Running"
        '
        'tmr_ServiceDelay
        '
        Me.tmr_ServiceDelay.Interval = 10000
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 563)
        Me.Controls.Add(Me.lbl_ServiceStatus)
        Me.Controls.Add(Me.btn_StartService)
        Me.Controls.Add(Me.btn_AddItems)
        Me.Controls.Add(Me.MetroLabel9)
        Me.Controls.Add(Me.txtbx_ItemNumber)
        Me.Controls.Add(Me.btn_Scrapes)
        Me.Controls.Add(Me.txtbx_Before)
        Me.Controls.Add(Me.btn_Scrape)
        Me.Controls.Add(Me.txtbx_URL)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.txtbx_After)
        Me.Controls.Add(Me.txtbx_Name)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow
        Me.Text = "Scrape"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtbx_Name As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtbx_URL As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtbx_Before As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtbx_After As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lstbx_Data As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtbx_CharAfter1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtbx_CharBefore1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Scrape As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_Scrapes As MetroFramework.Controls.MetroButton
    Friend WithEvents txtbx_ItemNumber As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btn_Add5 As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_Add4 As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_Add3 As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_Add2 As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_Add1 As MetroFramework.Controls.MetroButton
    Friend WithEvents txtbx_CharAfter5 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtbx_CharAfter4 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtbx_CharAfter3 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtbx_CharAfter2 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtbx_CharBefore5 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtbx_CharBefore4 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtbx_CharBefore3 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtbx_CharBefore2 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtbx_After5 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtbx_Before5 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtbx_After4 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtbx_After3 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtbx_After2 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtbx_Before4 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtbx_Before3 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtbx_Before2 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtbx_After1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtbx_Before1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel12 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtbx_Item5 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtbx_Item4 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtbx_Item3 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtbx_Item2 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel14 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel15 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel13 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel16 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel17 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel18 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtbx_Item1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btn_AddItems As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_StartService As MetroFramework.Controls.MetroButton
    Friend WithEvents lbl_ServiceStatus As MetroFramework.Controls.MetroLabel
    Friend WithEvents ScrapeServiceController As System.ServiceProcess.ServiceController
    Friend WithEvents tmr_ServiceDelay As System.Windows.Forms.Timer

End Class
