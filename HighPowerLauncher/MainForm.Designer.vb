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
        Me.ItemMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddItemMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveItemMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.WindowsToolsMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaunchPowershellMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaunchExplorerMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaunchRegeditMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaunchTaskmgrMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShutDownMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddStartupMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReloadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.ShutDownButton = New System.Windows.Forms.ToolStripButton()
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
        Me.LauncherToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ItemMenuItem, Me.ToolStripSeparator5, Me.WindowsToolsMenuItem, Me.ShutDownMenuItem, Me.ToolStripSeparator6, Me.AddStartupMenuItem, Me.ToolStripSeparator4, Me.ExitToolStripMenuItem})
        Me.LauncherToolStripMenuItem.Name = "LauncherToolStripMenuItem"
        Me.LauncherToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.LauncherToolStripMenuItem.Text = "ランチャー(&L)"
        '
        'ItemMenuItem
        '
        Me.ItemMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddItemMenuItem, Me.RemoveItemMenuItem})
        Me.ItemMenuItem.Name = "ItemMenuItem"
        Me.ItemMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.ItemMenuItem.Text = "アイテム(&I)"
        '
        'AddItemMenuItem
        '
        Me.AddItemMenuItem.Name = "AddItemMenuItem"
        Me.AddItemMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.AddItemMenuItem.Text = "追加(&A)"
        '
        'RemoveItemMenuItem
        '
        Me.RemoveItemMenuItem.Name = "RemoveItemMenuItem"
        Me.RemoveItemMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.RemoveItemMenuItem.Text = "削除(&R)"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(199, 6)
        '
        'WindowsToolsMenuItem
        '
        Me.WindowsToolsMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaunchPowershellMenuItem, Me.LaunchExplorerMenuItem, Me.LaunchRegeditMenuItem, Me.LaunchTaskmgrMenuItem})
        Me.WindowsToolsMenuItem.Name = "WindowsToolsMenuItem"
        Me.WindowsToolsMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.WindowsToolsMenuItem.Text = "Windows ツール"
        '
        'LaunchPowershellMenuItem
        '
        Me.LaunchPowershellMenuItem.Name = "LaunchPowershellMenuItem"
        Me.LaunchPowershellMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.LaunchPowershellMenuItem.Text = "Powershell"
        '
        'LaunchExplorerMenuItem
        '
        Me.LaunchExplorerMenuItem.Name = "LaunchExplorerMenuItem"
        Me.LaunchExplorerMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.LaunchExplorerMenuItem.Text = "エクスプローラー"
        '
        'LaunchRegeditMenuItem
        '
        Me.LaunchRegeditMenuItem.Name = "LaunchRegeditMenuItem"
        Me.LaunchRegeditMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.LaunchRegeditMenuItem.Text = "レジストリエディタ"
        '
        'LaunchTaskmgrMenuItem
        '
        Me.LaunchTaskmgrMenuItem.Name = "LaunchTaskmgrMenuItem"
        Me.LaunchTaskmgrMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.LaunchTaskmgrMenuItem.Text = "タスクマネージャー"
        '
        'ShutDownMenuItem
        '
        Me.ShutDownMenuItem.Name = "ShutDownMenuItem"
        Me.ShutDownMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.ShutDownMenuItem.Text = "Windows をシャットダウン"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(199, 6)
        '
        'AddStartupMenuItem
        '
        Me.AddStartupMenuItem.Name = "AddStartupMenuItem"
        Me.AddStartupMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.AddStartupMenuItem.Text = "スタートアップに登録"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(199, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.ExitToolStripMenuItem.Text = "終了(&X)"
        '
        'ViewMenuItem
        '
        Me.ViewMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReloadToolStripMenuItem})
        Me.ViewMenuItem.Name = "ViewMenuItem"
        Me.ViewMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ViewMenuItem.Text = "表示(&V)"
        '
        'ReloadToolStripMenuItem
        '
        Me.ReloadToolStripMenuItem.Name = "ReloadToolStripMenuItem"
        Me.ReloadToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ReloadToolStripMenuItem.Text = "再読み込み(&R)"
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
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
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
        Me.ApplicationListBox.HorizontalScrollbar = True
        Me.ApplicationListBox.ItemHeight = 15
        Me.ApplicationListBox.Location = New System.Drawing.Point(12, 52)
        Me.ApplicationListBox.Name = "ApplicationListBox"
        Me.ApplicationListBox.Size = New System.Drawing.Size(460, 124)
        Me.ApplicationListBox.TabIndex = 2
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaunchButton, Me.OpenLocaleButton, Me.ToolStripSeparator1, Me.AddItemButton, Me.RemoveItemButton, Me.ToolStripSeparator2, Me.ReloadItemButton, Me.ToolStripSeparator3, Me.ShutDownButton})
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
        Me.LaunchButton.ToolTipText = "アプリケーションを実行する"
        '
        'OpenLocaleButton
        '
        Me.OpenLocaleButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OpenLocaleButton.Image = CType(resources.GetObject("OpenLocaleButton.Image"), System.Drawing.Image)
        Me.OpenLocaleButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenLocaleButton.Name = "OpenLocaleButton"
        Me.OpenLocaleButton.Size = New System.Drawing.Size(23, 22)
        Me.OpenLocaleButton.Text = "ToolStripButton2"
        Me.OpenLocaleButton.ToolTipText = "実行ファイルの場所を開く"
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
        Me.AddItemButton.ToolTipText = "アプリケーションをアイテムに追加"
        '
        'RemoveItemButton
        '
        Me.RemoveItemButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RemoveItemButton.Image = CType(resources.GetObject("RemoveItemButton.Image"), System.Drawing.Image)
        Me.RemoveItemButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RemoveItemButton.Name = "RemoveItemButton"
        Me.RemoveItemButton.Size = New System.Drawing.Size(23, 22)
        Me.RemoveItemButton.Text = "ToolStripButton4"
        Me.RemoveItemButton.ToolTipText = "アプリケーションをアイテムから削除"
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
        Me.ReloadItemButton.ToolTipText = "再読み込みする"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ShutDownButton
        '
        Me.ShutDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ShutDownButton.Image = CType(resources.GetObject("ShutDownButton.Image"), System.Drawing.Image)
        Me.ShutDownButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ShutDownButton.Name = "ShutDownButton"
        Me.ShutDownButton.Size = New System.Drawing.Size(23, 22)
        Me.ShutDownButton.Text = "ToolStripButton6"
        Me.ShutDownButton.ToolTipText = "Windows をシャットダウン"
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
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ViewMenuItem As ToolStripMenuItem
    Friend WithEvents ReloadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ItemMenuItem As ToolStripMenuItem
    Friend WithEvents AddItemMenuItem As ToolStripMenuItem
    Friend WithEvents RemoveItemMenuItem As ToolStripMenuItem
    Friend WithEvents ShutDownButton As ToolStripButton
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents WindowsToolsMenuItem As ToolStripMenuItem
    Friend WithEvents LaunchPowershellMenuItem As ToolStripMenuItem
    Friend WithEvents LaunchExplorerMenuItem As ToolStripMenuItem
    Friend WithEvents LaunchRegeditMenuItem As ToolStripMenuItem
    Friend WithEvents LaunchTaskmgrMenuItem As ToolStripMenuItem
    Friend WithEvents ShutDownMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents AddStartupMenuItem As ToolStripMenuItem
End Class
