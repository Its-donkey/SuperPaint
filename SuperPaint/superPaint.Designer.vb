<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSuperPaint
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSuperPaint))
        Me.mnuTopBar = New System.Windows.Forms.MenuStrip()
        Me.mnuTopBarFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTopBarFileNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTopBarFileOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuTopBarFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTopBarEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTopBarEditClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTopBarHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTopBarHelpSupport = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmbLineStyle = New System.Windows.Forms.ComboBox()
        Me.trkSizeAdjustment = New System.Windows.Forms.TrackBar()
        Me.picColourSample = New System.Windows.Forms.PictureBox()
        Me.btnEraser = New System.Windows.Forms.Button()
        Me.btnPencil = New System.Windows.Forms.Button()
        Me.btnFillColour = New System.Windows.Forms.Button()
        Me.btnLine = New System.Windows.Forms.Button()
        Me.btnSquare = New System.Windows.Forms.Button()
        Me.btnCircle = New System.Windows.Forms.Button()
        Me.tipSuperPaint = New System.Windows.Forms.ToolTip(Me.components)
        Me.picDrawingCanvas = New System.Windows.Forms.PictureBox()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.mnuTopBar.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.trkSizeAdjustment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picColourSample, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDrawingCanvas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnuTopBar
        '
        Me.mnuTopBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuTopBarFile, Me.mnuTopBarEdit, Me.mnuTopBarHelp})
        Me.mnuTopBar.Location = New System.Drawing.Point(0, 0)
        Me.mnuTopBar.Name = "mnuTopBar"
        Me.mnuTopBar.Size = New System.Drawing.Size(997, 24)
        Me.mnuTopBar.TabIndex = 0
        Me.mnuTopBar.Text = "MenuStrip1"
        '
        'mnuTopBarFile
        '
        Me.mnuTopBarFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuTopBarFileNew, Me.mnuTopBarFileOpen, Me.ToolStripSeparator1, Me.mnuTopBarFileExit})
        Me.mnuTopBarFile.Name = "mnuTopBarFile"
        Me.mnuTopBarFile.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.mnuTopBarFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuTopBarFile.Text = "&File"
        '
        'mnuTopBarFileNew
        '
        Me.mnuTopBarFileNew.Name = "mnuTopBarFileNew"
        Me.mnuTopBarFileNew.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.mnuTopBarFileNew.Size = New System.Drawing.Size(146, 22)
        Me.mnuTopBarFileNew.Text = "&New"
        '
        'mnuTopBarFileOpen
        '
        Me.mnuTopBarFileOpen.Name = "mnuTopBarFileOpen"
        Me.mnuTopBarFileOpen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.mnuTopBarFileOpen.Size = New System.Drawing.Size(146, 22)
        Me.mnuTopBarFileOpen.Text = "Open"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(143, 6)
        '
        'mnuTopBarFileExit
        '
        Me.mnuTopBarFileExit.Name = "mnuTopBarFileExit"
        Me.mnuTopBarFileExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.mnuTopBarFileExit.Size = New System.Drawing.Size(146, 22)
        Me.mnuTopBarFileExit.Text = "E&xit"
        '
        'mnuTopBarEdit
        '
        Me.mnuTopBarEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuTopBarEditClear})
        Me.mnuTopBarEdit.Name = "mnuTopBarEdit"
        Me.mnuTopBarEdit.Size = New System.Drawing.Size(39, 20)
        Me.mnuTopBarEdit.Text = "Edit"
        '
        'mnuTopBarEditClear
        '
        Me.mnuTopBarEditClear.Name = "mnuTopBarEditClear"
        Me.mnuTopBarEditClear.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mnuTopBarEditClear.Size = New System.Drawing.Size(175, 22)
        Me.mnuTopBarEditClear.Text = "&Clear"
        '
        'mnuTopBarHelp
        '
        Me.mnuTopBarHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuTopBarHelpSupport})
        Me.mnuTopBarHelp.Name = "mnuTopBarHelp"
        Me.mnuTopBarHelp.Size = New System.Drawing.Size(44, 20)
        Me.mnuTopBarHelp.Text = "Help"
        '
        'mnuTopBarHelpSupport
        '
        Me.mnuTopBarHelpSupport.Name = "mnuTopBarHelpSupport"
        Me.mnuTopBarHelpSupport.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.mnuTopBarHelpSupport.Size = New System.Drawing.Size(152, 22)
        Me.mnuTopBarHelpSupport.Text = "Support"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbLineStyle)
        Me.Panel1.Controls.Add(Me.trkSizeAdjustment)
        Me.Panel1.Controls.Add(Me.picColourSample)
        Me.Panel1.Controls.Add(Me.btnEraser)
        Me.Panel1.Controls.Add(Me.btnPencil)
        Me.Panel1.Controls.Add(Me.btnFillColour)
        Me.Panel1.Controls.Add(Me.btnLine)
        Me.Panel1.Controls.Add(Me.btnSquare)
        Me.Panel1.Controls.Add(Me.btnCircle)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 472)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(997, 80)
        Me.Panel1.TabIndex = 2
        '
        'cmbLineStyle
        '
        Me.cmbLineStyle.FormattingEnabled = True
        Me.cmbLineStyle.Items.AddRange(New Object() {"Solid", "Dash ", "DashDot", "Dash Dot Dot", "Dot"})
        Me.cmbLineStyle.Location = New System.Drawing.Point(403, 30)
        Me.cmbLineStyle.Name = "cmbLineStyle"
        Me.cmbLineStyle.Size = New System.Drawing.Size(121, 21)
        Me.cmbLineStyle.TabIndex = 10
        Me.cmbLineStyle.Text = "Line Style"
        Me.tipSuperPaint.SetToolTip(Me.cmbLineStyle, "Line Style")
        Me.cmbLineStyle.Visible = False
        '
        'trkSizeAdjustment
        '
        Me.trkSizeAdjustment.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.trkSizeAdjustment.Location = New System.Drawing.Point(724, 28)
        Me.trkSizeAdjustment.Maximum = 60
        Me.trkSizeAdjustment.Minimum = 2
        Me.trkSizeAdjustment.Name = "trkSizeAdjustment"
        Me.trkSizeAdjustment.Size = New System.Drawing.Size(110, 45)
        Me.trkSizeAdjustment.TabIndex = 9
        Me.trkSizeAdjustment.TickFrequency = 5
        Me.trkSizeAdjustment.Value = 2
        '
        'picColourSample
        '
        Me.picColourSample.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.picColourSample.BackColor = System.Drawing.Color.Black
        Me.picColourSample.Location = New System.Drawing.Point(920, 3)
        Me.picColourSample.Name = "picColourSample"
        Me.picColourSample.Size = New System.Drawing.Size(74, 74)
        Me.picColourSample.TabIndex = 8
        Me.picColourSample.TabStop = False
        '
        'btnEraser
        '
        Me.btnEraser.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEraser.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEraser.ForeColor = System.Drawing.Color.Black
        Me.btnEraser.Image = CType(resources.GetObject("btnEraser.Image"), System.Drawing.Image)
        Me.btnEraser.Location = New System.Drawing.Point(323, 3)
        Me.btnEraser.Name = "btnEraser"
        Me.btnEraser.Size = New System.Drawing.Size(74, 74)
        Me.btnEraser.TabIndex = 7
        Me.btnEraser.UseVisualStyleBackColor = True
        '
        'btnPencil
        '
        Me.btnPencil.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPencil.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPencil.ForeColor = System.Drawing.Color.Black
        Me.btnPencil.Image = CType(resources.GetObject("btnPencil.Image"), System.Drawing.Image)
        Me.btnPencil.Location = New System.Drawing.Point(243, 3)
        Me.btnPencil.Name = "btnPencil"
        Me.btnPencil.Size = New System.Drawing.Size(74, 74)
        Me.btnPencil.TabIndex = 5
        Me.btnPencil.UseVisualStyleBackColor = True
        '
        'btnFillColour
        '
        Me.btnFillColour.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnFillColour.BackColor = System.Drawing.Color.Black
        Me.btnFillColour.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFillColour.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFillColour.ForeColor = System.Drawing.Color.Black
        Me.btnFillColour.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnFillColour.Location = New System.Drawing.Point(840, 3)
        Me.btnFillColour.Name = "btnFillColour"
        Me.btnFillColour.Size = New System.Drawing.Size(74, 74)
        Me.btnFillColour.TabIndex = 4
        Me.btnFillColour.UseVisualStyleBackColor = False
        Me.btnFillColour.Visible = False
        '
        'btnLine
        '
        Me.btnLine.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLine.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLine.ForeColor = System.Drawing.Color.Black
        Me.btnLine.Location = New System.Drawing.Point(163, 3)
        Me.btnLine.Name = "btnLine"
        Me.btnLine.Size = New System.Drawing.Size(74, 74)
        Me.btnLine.TabIndex = 3
        Me.btnLine.Text = "Line"
        Me.btnLine.UseVisualStyleBackColor = True
        '
        'btnSquare
        '
        Me.btnSquare.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSquare.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSquare.ForeColor = System.Drawing.Color.Black
        Me.btnSquare.Location = New System.Drawing.Point(83, 3)
        Me.btnSquare.Name = "btnSquare"
        Me.btnSquare.Size = New System.Drawing.Size(74, 74)
        Me.btnSquare.TabIndex = 2
        Me.btnSquare.Text = "Square"
        Me.btnSquare.UseVisualStyleBackColor = True
        '
        'btnCircle
        '
        Me.btnCircle.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCircle.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.btnCircle.ForeColor = System.Drawing.Color.Black
        Me.btnCircle.Location = New System.Drawing.Point(3, 3)
        Me.btnCircle.Name = "btnCircle"
        Me.btnCircle.Size = New System.Drawing.Size(74, 74)
        Me.btnCircle.TabIndex = 1
        Me.btnCircle.Text = "Circle"
        Me.btnCircle.UseVisualStyleBackColor = True
        '
        'picDrawingCanvas
        '
        Me.picDrawingCanvas.BackColor = System.Drawing.Color.White
        Me.picDrawingCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picDrawingCanvas.Cursor = System.Windows.Forms.Cursors.Cross
        Me.picDrawingCanvas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picDrawingCanvas.Location = New System.Drawing.Point(0, 24)
        Me.picDrawingCanvas.Name = "picDrawingCanvas"
        Me.picDrawingCanvas.Size = New System.Drawing.Size(997, 448)
        Me.picDrawingCanvas.TabIndex = 6
        Me.picDrawingCanvas.TabStop = False
        '
        'frmSuperPaint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(997, 552)
        Me.Controls.Add(Me.picDrawingCanvas)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.mnuTopBar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.mnuTopBar
        Me.Name = "frmSuperPaint"
        Me.Text = "SuperPaint"
        Me.mnuTopBar.ResumeLayout(False)
        Me.mnuTopBar.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.trkSizeAdjustment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picColourSample, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDrawingCanvas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuTopBar As MenuStrip
    Friend WithEvents mnuTopBarFile As ToolStripMenuItem
    Friend WithEvents mnuTopBarEdit As ToolStripMenuItem
    Friend WithEvents mnuTopBarEditClear As ToolStripMenuItem
    Friend WithEvents mnuTopBarFileNew As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCircle As Button
    Friend WithEvents btnSquare As Button
    Friend WithEvents btnLine As Button
    Friend WithEvents tipSuperPaint As ToolTip
    Friend WithEvents btnFillColour As Button
    Friend WithEvents btnPencil As Button
    Friend WithEvents btnEraser As Button
    Friend WithEvents picColourSample As PictureBox
    Friend WithEvents picDrawingCanvas As PictureBox
    Friend WithEvents trkSizeAdjustment As TrackBar
    Friend WithEvents cmbLineStyle As ComboBox
    Friend WithEvents mnuTopBarFileExit As ToolStripMenuItem
    Friend WithEvents mnuTopBarFileOpen As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents mnuTopBarHelp As ToolStripMenuItem
    Friend WithEvents mnuTopBarHelpSupport As ToolStripMenuItem
    Friend WithEvents HelpProvider1 As HelpProvider
End Class
