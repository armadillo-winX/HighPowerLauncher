<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.LauncherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ApplicationListBox = New System.Windows.Forms.ListBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.LaunchButton = New System.Windows.Forms.ToolStripButton()
        Me.OpenLocaleButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddItemButton = New System.Windows.Forms.ToolStripButton()
        Me.RemoveItemButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ReloadItemButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.OpenSpecialDirectoryButton = New System.Windows.Forms.ToolStripSplitButton()
        Me.ViewMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LauncherToolStripMenuItem, Me.ViewMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(484, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LauncherToolStripMenuItem
        '
        Me.LauncherToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.LauncherToolStripMenuItem.Name = "LauncherToolStripMenuItem"
        Me.LauncherToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.LauncherToolStripMenuItem.Text = "ランチャー(&L)"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "終了(&X)"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.HelpToolStripMenuItem.Text = "ヘルプ(&H)"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AboutToolStripMenuItem.Text = "バージョン情報(&A)"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "High Power Launcher"
        Me.NotifyIcon1.Visible = True
        '
        'ApplicationListBox
        '
        Me.ApplicationListBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ApplicationListBox.FormattingEnabled = True
        Me.ApplicationListBox.ItemHeight = 15
        Me.ApplicationListBox.Location = New System.Drawing.Point(12, 52)
        Me.ApplicationListBox.Name = "ApplicationListBox"
        Me.ApplicationListBox.Size = New System.Drawing.Size(460, 124)
        Me.ApplicationListBox.TabIndex = 2
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaunchButton, Me.OpenLocaleButton, Me.ToolStripSeparator1, Me.AddItemButton, Me.RemoveItemButton, Me.ToolStripSeparator2, Me.ReloadItemButton, Me.ToolStripSeparator3, Me.OpenSpecialDirectoryButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(484, 25)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'LaunchButton
        '
        Me.LaunchButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.LaunchButton.Image = CType(resources.GetObject("LaunchButton.Image"), System.Drawing.Image)
        Me.LaunchButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.LaunchButton.Name = "LaunchButton"
        Me.LaunchButton.Size = New System.Drawing.Size(23, 22)
        Me.LaunchButton.Text = "ToolStripButton1"
        '
        'OpenLocaleButton
        '
        Me.OpenLocaleButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OpenLocaleButton.Image = CType(resources.GetObject("OpenLocaleButton.Image"), System.Drawing.Image)
        Me.OpenLocaleButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenLocaleButton.Name = "OpenLocaleButton"
        Me.OpenLocaleButton.Size = New System.Drawing.Size(23, 22)
        Me.OpenLocaleButton.Text = "ToolStripButton2"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'AddItemButton
        '
        Me.AddItemButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AddItemButton.Image = CType(resources.GetObject("AddItemButton.Image"), System.Drawing.Image)
        Me.AddItemButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AddItemButton.Name = "AddItemButton"
        Me.AddItemButton.Size = New System.Drawing.Size(23, 22)
        Me.AddItemButton.Text = "ToolStripButton3"
        '
        'RemoveItemButton
        '
        Me.RemoveItemButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RemoveItemButton.Image = CType(resources.GetObject("RemoveItemButton.Image"), System.Drawing.Image)
        Me.RemoveItemButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RemoveItemButton.Name = "RemoveItemButton"
        Me.RemoveItemButton.Size = New System.Drawing.Size(23, 22)
        Me.RemoveItemButton.Text = "ToolStripButton4"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ReloadItemButton
        '
        Me.ReloadItemButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ReloadItemButton.Image = CType(resources.GetObject("ReloadItemButton.Image"), System.Drawing.Image)
        Me.ReloadItemButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ReloadItemButton.Name = "ReloadItemButton"
        Me.ReloadItemButton.Size = New System.Drawing.Size(23, 22)
        Me.ReloadItemButton.Text = "ToolStripButton5"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'OpenSpecialDirectoryButton
        '
        Me.OpenSpecialDirectoryButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OpenSpecialDirectoryButton.Image = CType(resources.GetObject("OpenSpecialDirectoryButton.Image"), System.Drawing.Image)
        Me.OpenSpecialDirectoryButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenSpecialDirectoryButton.Name = "OpenSpecialDirectoryButton"
        Me.OpenSpecialDirectoryButton.Size = New System.Drawing.Size(32, 22)
        Me.OpenSpecialDirectoryButton.Text = "ToolStripButton6"
        '
        'ViewMenuItem
        '
        Me.ViewMenuItem.Name = "ViewMenuItem"
        Me.ViewMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ViewMenuItem.Text = "表示(&V)"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 191)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.ApplicationListBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainForm"
        Me.ShowInTaskbar = False
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents LauncherToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents ViewMenuItem As ToolStripMenuItem
    Friend WithEvents ApplicationListBox As ListBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents LaunchButton As ToolStripButton
    Friend WithEvents OpenLocaleButton As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents AddItemButton As ToolStripButton
    Friend WithEvents RemoveItemButton As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ReloadItemButton As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents OpenSpecialDirectoryButton As ToolStripSplitButton
End Class
