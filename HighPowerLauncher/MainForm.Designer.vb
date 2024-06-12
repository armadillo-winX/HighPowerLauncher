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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        MenuStrip1 = New MenuStrip()
        LauncherToolStripMenuItem = New ToolStripMenuItem()
        ItemMenuItem = New ToolStripMenuItem()
        AddItemMenuItem = New ToolStripMenuItem()
        RemoveItemMenuItem = New ToolStripMenuItem()
        ToolStripSeparator5 = New ToolStripSeparator()
        WindowsToolsMenuItem = New ToolStripMenuItem()
        LaunchPowershellMenuItem = New ToolStripMenuItem()
        LaunchExplorerMenuItem = New ToolStripMenuItem()
        LaunchRegeditMenuItem = New ToolStripMenuItem()
        LaunchTaskmgrMenuItem = New ToolStripMenuItem()
        ShutDownMenuItem = New ToolStripMenuItem()
        ToolStripSeparator6 = New ToolStripSeparator()
        AddStartupMenuItem = New ToolStripMenuItem()
        ToolStripSeparator4 = New ToolStripSeparator()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        ViewMenuItem = New ToolStripMenuItem()
        ReloadToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem = New ToolStripMenuItem()
        AboutToolStripMenuItem = New ToolStripMenuItem()
        NotifyIcon1 = New NotifyIcon(components)
        ApplicationListBox = New ListBox()
        ToolStrip1 = New ToolStrip()
        LaunchButton = New ToolStripButton()
        OpenLocaleButton = New ToolStripButton()
        ToolStripSeparator1 = New ToolStripSeparator()
        AddItemButton = New ToolStripButton()
        RemoveItemButton = New ToolStripButton()
        ToolStripSeparator2 = New ToolStripSeparator()
        ReloadItemButton = New ToolStripButton()
        ToolStripSeparator3 = New ToolStripSeparator()
        ShutDownButton = New ToolStripButton()
        MenuStrip1.SuspendLayout()
        ToolStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {LauncherToolStripMenuItem, ViewMenuItem, HelpToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(484, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' LauncherToolStripMenuItem
        ' 
        LauncherToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ItemMenuItem, ToolStripSeparator5, WindowsToolsMenuItem, ShutDownMenuItem, ToolStripSeparator6, AddStartupMenuItem, ToolStripSeparator4, ExitToolStripMenuItem})
        LauncherToolStripMenuItem.Name = "LauncherToolStripMenuItem"
        LauncherToolStripMenuItem.Size = New Size(75, 20)
        LauncherToolStripMenuItem.Text = "ランチャー(&L)"
        ' 
        ' ItemMenuItem
        ' 
        ItemMenuItem.DropDownItems.AddRange(New ToolStripItem() {AddItemMenuItem, RemoveItemMenuItem})
        ItemMenuItem.Name = "ItemMenuItem"
        ItemMenuItem.Size = New Size(196, 22)
        ItemMenuItem.Text = "アイテム(&I)"
        ' 
        ' AddItemMenuItem
        ' 
        AddItemMenuItem.Name = "AddItemMenuItem"
        AddItemMenuItem.Size = New Size(114, 22)
        AddItemMenuItem.Text = "追加(&A)"
        ' 
        ' RemoveItemMenuItem
        ' 
        RemoveItemMenuItem.Name = "RemoveItemMenuItem"
        RemoveItemMenuItem.Size = New Size(114, 22)
        RemoveItemMenuItem.Text = "削除(&R)"
        ' 
        ' ToolStripSeparator5
        ' 
        ToolStripSeparator5.Name = "ToolStripSeparator5"
        ToolStripSeparator5.Size = New Size(193, 6)
        ' 
        ' WindowsToolsMenuItem
        ' 
        WindowsToolsMenuItem.DropDownItems.AddRange(New ToolStripItem() {LaunchPowershellMenuItem, LaunchExplorerMenuItem, LaunchRegeditMenuItem, LaunchTaskmgrMenuItem})
        WindowsToolsMenuItem.Name = "WindowsToolsMenuItem"
        WindowsToolsMenuItem.Size = New Size(196, 22)
        WindowsToolsMenuItem.Text = "Windows ツール"
        ' 
        ' LaunchPowershellMenuItem
        ' 
        LaunchPowershellMenuItem.Name = "LaunchPowershellMenuItem"
        LaunchPowershellMenuItem.Size = New Size(154, 22)
        LaunchPowershellMenuItem.Text = "Powershell"
        ' 
        ' LaunchExplorerMenuItem
        ' 
        LaunchExplorerMenuItem.Name = "LaunchExplorerMenuItem"
        LaunchExplorerMenuItem.Size = New Size(154, 22)
        LaunchExplorerMenuItem.Text = "エクスプローラー"
        ' 
        ' LaunchRegeditMenuItem
        ' 
        LaunchRegeditMenuItem.Name = "LaunchRegeditMenuItem"
        LaunchRegeditMenuItem.Size = New Size(154, 22)
        LaunchRegeditMenuItem.Text = "レジストリエディタ"
        ' 
        ' LaunchTaskmgrMenuItem
        ' 
        LaunchTaskmgrMenuItem.Name = "LaunchTaskmgrMenuItem"
        LaunchTaskmgrMenuItem.Size = New Size(154, 22)
        LaunchTaskmgrMenuItem.Text = "タスクマネージャー"
        ' 
        ' ShutDownMenuItem
        ' 
        ShutDownMenuItem.Name = "ShutDownMenuItem"
        ShutDownMenuItem.Size = New Size(196, 22)
        ShutDownMenuItem.Text = "Windows をシャットダウン"
        ' 
        ' ToolStripSeparator6
        ' 
        ToolStripSeparator6.Name = "ToolStripSeparator6"
        ToolStripSeparator6.Size = New Size(193, 6)
        ' 
        ' AddStartupMenuItem
        ' 
        AddStartupMenuItem.Name = "AddStartupMenuItem"
        AddStartupMenuItem.Size = New Size(196, 22)
        AddStartupMenuItem.Text = "スタートアップに登録"
        ' 
        ' ToolStripSeparator4
        ' 
        ToolStripSeparator4.Name = "ToolStripSeparator4"
        ToolStripSeparator4.Size = New Size(193, 6)
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.ShortcutKeys = Keys.Alt Or Keys.F4
        ExitToolStripMenuItem.Size = New Size(196, 22)
        ExitToolStripMenuItem.Text = "終了(&X)"
        ' 
        ' ViewMenuItem
        ' 
        ViewMenuItem.DropDownItems.AddRange(New ToolStripItem() {ReloadToolStripMenuItem})
        ViewMenuItem.Name = "ViewMenuItem"
        ViewMenuItem.Size = New Size(58, 20)
        ViewMenuItem.Text = "表示(&V)"
        ' 
        ' ReloadToolStripMenuItem
        ' 
        ReloadToolStripMenuItem.Name = "ReloadToolStripMenuItem"
        ReloadToolStripMenuItem.Size = New Size(147, 22)
        ReloadToolStripMenuItem.Text = "再読み込み(&R)"
        ' 
        ' HelpToolStripMenuItem
        ' 
        HelpToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AboutToolStripMenuItem})
        HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        HelpToolStripMenuItem.Size = New Size(65, 20)
        HelpToolStripMenuItem.Text = "ヘルプ(&H)"
        ' 
        ' AboutToolStripMenuItem
        ' 
        AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        AboutToolStripMenuItem.Size = New Size(158, 22)
        AboutToolStripMenuItem.Text = "バージョン情報(&A)"
        ' 
        ' NotifyIcon1
        ' 
        NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), Icon)
        NotifyIcon1.Text = "High Power Launcher"
        NotifyIcon1.Visible = True
        ' 
        ' ApplicationListBox
        ' 
        ApplicationListBox.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        ApplicationListBox.Font = New Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ApplicationListBox.FormattingEnabled = True
        ApplicationListBox.HorizontalScrollbar = True
        ApplicationListBox.ItemHeight = 21
        ApplicationListBox.Location = New Point(12, 52)
        ApplicationListBox.Name = "ApplicationListBox"
        ApplicationListBox.Size = New Size(460, 130)
        ApplicationListBox.TabIndex = 2
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.Items.AddRange(New ToolStripItem() {LaunchButton, OpenLocaleButton, ToolStripSeparator1, AddItemButton, RemoveItemButton, ToolStripSeparator2, ReloadItemButton, ToolStripSeparator3, ShutDownButton})
        ToolStrip1.Location = New Point(0, 24)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(484, 25)
        ToolStrip1.TabIndex = 3
        ToolStrip1.Text = "ToolStrip1"
        ' 
        ' LaunchButton
        ' 
        LaunchButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        LaunchButton.Image = CType(resources.GetObject("LaunchButton.Image"), Image)
        LaunchButton.ImageTransparentColor = Color.Magenta
        LaunchButton.Name = "LaunchButton"
        LaunchButton.Size = New Size(23, 22)
        LaunchButton.Text = "ToolStripButton1"
        LaunchButton.ToolTipText = "アプリケーションを実行する"
        ' 
        ' OpenLocaleButton
        ' 
        OpenLocaleButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        OpenLocaleButton.Image = CType(resources.GetObject("OpenLocaleButton.Image"), Image)
        OpenLocaleButton.ImageTransparentColor = Color.Magenta
        OpenLocaleButton.Name = "OpenLocaleButton"
        OpenLocaleButton.Size = New Size(23, 22)
        OpenLocaleButton.Text = "ToolStripButton2"
        OpenLocaleButton.ToolTipText = "実行ファイルの場所を開く"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(6, 25)
        ' 
        ' AddItemButton
        ' 
        AddItemButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        AddItemButton.Image = CType(resources.GetObject("AddItemButton.Image"), Image)
        AddItemButton.ImageTransparentColor = Color.Magenta
        AddItemButton.Name = "AddItemButton"
        AddItemButton.Size = New Size(23, 22)
        AddItemButton.Text = "ToolStripButton3"
        AddItemButton.ToolTipText = "アプリケーションをアイテムに追加"
        ' 
        ' RemoveItemButton
        ' 
        RemoveItemButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        RemoveItemButton.Image = CType(resources.GetObject("RemoveItemButton.Image"), Image)
        RemoveItemButton.ImageTransparentColor = Color.Magenta
        RemoveItemButton.Name = "RemoveItemButton"
        RemoveItemButton.Size = New Size(23, 22)
        RemoveItemButton.Text = "ToolStripButton4"
        RemoveItemButton.ToolTipText = "アプリケーションをアイテムから削除"
        ' 
        ' ToolStripSeparator2
        ' 
        ToolStripSeparator2.Name = "ToolStripSeparator2"
        ToolStripSeparator2.Size = New Size(6, 25)
        ' 
        ' ReloadItemButton
        ' 
        ReloadItemButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        ReloadItemButton.Image = CType(resources.GetObject("ReloadItemButton.Image"), Image)
        ReloadItemButton.ImageTransparentColor = Color.Magenta
        ReloadItemButton.Name = "ReloadItemButton"
        ReloadItemButton.Size = New Size(23, 22)
        ReloadItemButton.Text = "ToolStripButton5"
        ReloadItemButton.ToolTipText = "再読み込みする"
        ' 
        ' ToolStripSeparator3
        ' 
        ToolStripSeparator3.Name = "ToolStripSeparator3"
        ToolStripSeparator3.Size = New Size(6, 25)
        ' 
        ' ShutDownButton
        ' 
        ShutDownButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        ShutDownButton.Image = CType(resources.GetObject("ShutDownButton.Image"), Image)
        ShutDownButton.ImageTransparentColor = Color.Magenta
        ShutDownButton.Name = "ShutDownButton"
        ShutDownButton.Size = New Size(23, 22)
        ShutDownButton.Text = "ToolStripButton6"
        ShutDownButton.ToolTipText = "Windows をシャットダウン"
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(484, 191)
        Controls.Add(ToolStrip1)
        Controls.Add(ApplicationListBox)
        Controls.Add(MenuStrip1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = MenuStrip1
        MaximizeBox = False
        MinimizeBox = False
        Name = "MainForm"
        ShowInTaskbar = False
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

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
