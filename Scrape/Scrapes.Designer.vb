<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Scrapes
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
        Me.btn_DeleteNames = New MetroFramework.Controls.MetroButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lstbx_Tables = New System.Windows.Forms.ListBox()
        Me.lstbx_Scrapes = New System.Windows.Forms.ListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_DeleteScrapes = New MetroFramework.Controls.MetroButton()
        Me.lstbx_Data = New System.Windows.Forms.ListBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_Back = New MetroFramework.Controls.MetroButton()
        Me.btn_DeleteAll = New MetroFramework.Controls.MetroButton()
        Me.lstbx_AllData = New System.Windows.Forms.ListBox()
        Me.lbl_Directory = New MetroFramework.Controls.MetroLabel()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_DeleteNames
        '
        Me.btn_DeleteNames.Location = New System.Drawing.Point(73, 768)
        Me.btn_DeleteNames.Name = "btn_DeleteNames"
        Me.btn_DeleteNames.Size = New System.Drawing.Size(75, 23)
        Me.btn_DeleteNames.TabIndex = 0
        Me.btn_DeleteNames.Text = "Delete"
        Me.btn_DeleteNames.UseSelectable = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lstbx_Tables)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 503)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 249)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Names"
        '
        'lstbx_Tables
        '
        Me.lstbx_Tables.FormattingEnabled = True
        Me.lstbx_Tables.Location = New System.Drawing.Point(6, 16)
        Me.lstbx_Tables.Name = "lstbx_Tables"
        Me.lstbx_Tables.Size = New System.Drawing.Size(188, 225)
        Me.lstbx_Tables.TabIndex = 0
        '
        'lstbx_Scrapes
        '
        Me.lstbx_Scrapes.FormattingEnabled = True
        Me.lstbx_Scrapes.Location = New System.Drawing.Point(6, 16)
        Me.lstbx_Scrapes.Name = "lstbx_Scrapes"
        Me.lstbx_Scrapes.Size = New System.Drawing.Size(188, 225)
        Me.lstbx_Scrapes.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lstbx_Scrapes)
        Me.GroupBox2.Location = New System.Drawing.Point(263, 503)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 249)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Scrapes"
        '
        'btn_DeleteScrapes
        '
        Me.btn_DeleteScrapes.Location = New System.Drawing.Point(315, 768)
        Me.btn_DeleteScrapes.Name = "btn_DeleteScrapes"
        Me.btn_DeleteScrapes.Size = New System.Drawing.Size(75, 23)
        Me.btn_DeleteScrapes.TabIndex = 3
        Me.btn_DeleteScrapes.Text = "Delete"
        Me.btn_DeleteScrapes.UseSelectable = True
        '
        'lstbx_Data
        '
        Me.lstbx_Data.FormattingEnabled = True
        Me.lstbx_Data.Location = New System.Drawing.Point(6, 16)
        Me.lstbx_Data.Name = "lstbx_Data"
        Me.lstbx_Data.Size = New System.Drawing.Size(188, 225)
        Me.lstbx_Data.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lstbx_Data)
        Me.GroupBox3.Location = New System.Drawing.Point(503, 503)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 249)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Data"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(608, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_Back
        '
        Me.btn_Back.Location = New System.Drawing.Point(102, 63)
        Me.btn_Back.Name = "btn_Back"
        Me.btn_Back.Size = New System.Drawing.Size(75, 23)
        Me.btn_Back.TabIndex = 5
        Me.btn_Back.Text = "Back"
        Me.btn_Back.UseSelectable = True
        '
        'btn_DeleteAll
        '
        Me.btn_DeleteAll.Location = New System.Drawing.Point(102, 387)
        Me.btn_DeleteAll.Name = "btn_DeleteAll"
        Me.btn_DeleteAll.Size = New System.Drawing.Size(75, 23)
        Me.btn_DeleteAll.TabIndex = 6
        Me.btn_DeleteAll.Text = "Delete"
        Me.btn_DeleteAll.UseSelectable = True
        '
        'lstbx_AllData
        '
        Me.lstbx_AllData.FormattingEnabled = True
        Me.lstbx_AllData.Location = New System.Drawing.Point(45, 124)
        Me.lstbx_AllData.Name = "lstbx_AllData"
        Me.lstbx_AllData.Size = New System.Drawing.Size(188, 238)
        Me.lstbx_AllData.TabIndex = 0
        '
        'lbl_Directory
        '
        Me.lbl_Directory.AutoSize = True
        Me.lbl_Directory.Location = New System.Drawing.Point(45, 97)
        Me.lbl_Directory.Name = "lbl_Directory"
        Me.lbl_Directory.Size = New System.Drawing.Size(83, 19)
        Me.lbl_Directory.TabIndex = 7
        Me.lbl_Directory.Text = "MetroLabel1"
        '
        'Scrapes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(286, 433)
        Me.Controls.Add(Me.lbl_Directory)
        Me.Controls.Add(Me.lstbx_AllData)
        Me.Controls.Add(Me.btn_DeleteAll)
        Me.Controls.Add(Me.btn_Back)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btn_DeleteScrapes)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_DeleteNames)
        Me.MaximizeBox = False
        Me.Name = "Scrapes"
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow
        Me.Text = "Scrapes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_DeleteNames As MetroFramework.Controls.MetroButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lstbx_Tables As System.Windows.Forms.ListBox
    Friend WithEvents lstbx_Scrapes As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_DeleteScrapes As MetroFramework.Controls.MetroButton
    Friend WithEvents lstbx_Data As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btn_Back As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_DeleteAll As MetroFramework.Controls.MetroButton
    Friend WithEvents lstbx_AllData As System.Windows.Forms.ListBox
    Friend WithEvents lbl_Directory As MetroFramework.Controls.MetroLabel
End Class
