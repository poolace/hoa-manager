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
        Me.WindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FMC_MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'FMC_MenuStrip
        '
        Me.FMC_MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.WindowToolStripMenuItem})
        Me.FMC_MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.FMC_MenuStrip.MdiWindowListItem = Me.WindowToolStripMenuItem
        Me.FMC_MenuStrip.Name = "FMC_MenuStrip"
        Me.FMC_MenuStrip.Size = New System.Drawing.Size(800, 24)
        Me.FMC_MenuStrip.TabIndex = 1
        Me.FMC_MenuStrip.Text = "FMC_MenuStrip"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMI_FMC_File_New, Me.TSMI_FMC_File_Open})
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
        'WindowToolStripMenuItem
        '
        Me.WindowToolStripMenuItem.Name = "WindowToolStripMenuItem"
        Me.WindowToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.WindowToolStripMenuItem.Text = "&Window"
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
End Class
