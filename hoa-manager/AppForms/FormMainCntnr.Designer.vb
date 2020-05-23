<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMainCntnr
    Inherits System.Windows.Forms.Form

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
        Me.FMC_MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMI_FMC_File_New = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMI_FMC_File_Open = New System.Windows.Forms.ToolStripMenuItem()
        Me.TestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddEditAddressTypeTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddEditStateTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddEditEntityTypeTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddEditPhoneTypeTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.QuitTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.FMC_MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'FMC_MenuStrip
        '
        Me.FMC_MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.AdminToolStripMenuItem, Me.WindowToolStripMenuItem})
        Me.FMC_MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.FMC_MenuStrip.MdiWindowListItem = Me.WindowToolStripMenuItem
        Me.FMC_MenuStrip.Name = "FMC_MenuStrip"
        Me.FMC_MenuStrip.Size = New System.Drawing.Size(800, 24)
        Me.FMC_MenuStrip.TabIndex = 1
        Me.FMC_MenuStrip.Text = "FMC_MenuStrip"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMI_FMC_File_New, Me.TSMI_FMC_File_Open, Me.TestToolStripMenuItem, Me.ToolStripSeparator1, Me.QuitTSMI})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'TSMI_FMC_File_New
        '
        Me.TSMI_FMC_File_New.Name = "TSMI_FMC_File_New"
        Me.TSMI_FMC_File_New.Size = New System.Drawing.Size(180, 22)
        Me.TSMI_FMC_File_New.Text = "&New"
        '
        'TSMI_FMC_File_Open
        '
        Me.TSMI_FMC_File_Open.Name = "TSMI_FMC_File_Open"
        Me.TSMI_FMC_File_Open.Size = New System.Drawing.Size(180, 22)
        Me.TSMI_FMC_File_Open.Text = "&Open"
        '
        'TestToolStripMenuItem
        '
        Me.TestToolStripMenuItem.Name = "TestToolStripMenuItem"
        Me.TestToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TestToolStripMenuItem.Text = "&Test"
        '
        'WindowToolStripMenuItem
        '
        Me.WindowToolStripMenuItem.Name = "WindowToolStripMenuItem"
        Me.WindowToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.WindowToolStripMenuItem.Text = "&Window"
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddEditAddressTypeTSMI, Me.AddEditStateTSMI, Me.AddEditEntityTypeTSMI, Me.AddEditPhoneTypeTSMI})
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.AdminToolStripMenuItem.Text = "Admin"
        '
        'AddEditAddressTypeTSMI
        '
        Me.AddEditAddressTypeTSMI.Name = "AddEditAddressTypeTSMI"
        Me.AddEditAddressTypeTSMI.Size = New System.Drawing.Size(195, 22)
        Me.AddEditAddressTypeTSMI.Text = "Add/Edit Address Type"
        '
        'AddEditStateTSMI
        '
        Me.AddEditStateTSMI.Name = "AddEditStateTSMI"
        Me.AddEditStateTSMI.Size = New System.Drawing.Size(195, 22)
        Me.AddEditStateTSMI.Text = "Add/Edit State"
        '
        'AddEditEntityTypeTSMI
        '
        Me.AddEditEntityTypeTSMI.Name = "AddEditEntityTypeTSMI"
        Me.AddEditEntityTypeTSMI.Size = New System.Drawing.Size(195, 22)
        Me.AddEditEntityTypeTSMI.Text = "Add/Edit Entity Type"
        '
        'AddEditPhoneTypeTSMI
        '
        Me.AddEditPhoneTypeTSMI.Name = "AddEditPhoneTypeTSMI"
        Me.AddEditPhoneTypeTSMI.Size = New System.Drawing.Size(195, 22)
        Me.AddEditPhoneTypeTSMI.Text = "Add/Edit Phone Type"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(177, 6)
        '
        'QuitTSMI
        '
        Me.QuitTSMI.Name = "QuitTSMI"
        Me.QuitTSMI.Size = New System.Drawing.Size(180, 22)
        Me.QuitTSMI.Text = "&Quit"
        '
        'FormMainCntnr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.FMC_MenuStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.FMC_MenuStrip
        Me.Name = "FormMainCntnr"
        Me.Text = "HOA Manager"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.FMC_MenuStrip.ResumeLayout(False)
        Me.FMC_MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FMC_MenuStrip As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TSMI_FMC_File_New As ToolStripMenuItem
    Friend WithEvents TSMI_FMC_File_Open As ToolStripMenuItem
    Friend WithEvents WindowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TestToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddEditAddressTypeTSMI As ToolStripMenuItem
    Friend WithEvents AddEditStateTSMI As ToolStripMenuItem
    Friend WithEvents AddEditEntityTypeTSMI As ToolStripMenuItem
    Friend WithEvents AddEditPhoneTypeTSMI As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents QuitTSMI As ToolStripMenuItem
End Class
