Imports System.IO
Imports System.Diagnostics

Public Class frmSuperPaint
    Private colourPickPreviousColour As Color
    Private graphic As Graphics
    Private mouseUpDown As Boolean
    Private initialX, initialY As Integer
    Private initialPoint As Point
    Private shapeWidth, shapeHeight, shapeX, shapeY As Integer
    Private Sub frmSuperPaint_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        graphic = picDrawingCanvas.CreateGraphics()
    End Sub
    Private Sub superPaint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Colour = Color.FromArgb(0, 0, 0)
    End Sub
    Private Sub mnuTopBarEditClear_Click(sender As Object, e As EventArgs) Handles mnuTopBarEditClear.Click
        'Clear The Canvas 
        picDrawingCanvas.Image = Nothing
        picDrawingCanvas.Refresh()
    End Sub
    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuTopBarFileNew.Click
        'Clear the Canvas and reset the colour to white
        picDrawingCanvas.Image = Nothing
        picDrawingCanvas.BackColor = Color.White
        picDrawingCanvas.Refresh()
    End Sub
    Private Sub btnCircle_Click(sender As Object, e As EventArgs) Handles btnCircle.Click
        'Set All Boolean Flags Of Tools Click To False, Except For The
        'Current One: Circle

        blnLineClicked = False
        blnSquareClicked = False
        blnPencilClicked = False
        blnEraserClicked = False
        blnCircleClicked = True
        'Refresh/Repaint The Buttons, To Indicate Current Selection State

        btnCircle.BackColor = Color.CadetBlue
        btnCircle.Font = New Font("Arial", 8.25, FontStyle.Bold)
        btnSquare.BackColor = Color.White
        btnSquare.Font = New Font("Arial", 8.25, FontStyle.Regular)
        btnLine.BackColor = Color.White
        btnLine.Font = New Font("Arial", 8.25, FontStyle.Regular)

        btnFillColour.Visible = True
        cmbLineStyle.Visible = True
        circleState()
    End Sub
    Private Sub btnSquare_Click(sender As Object, e As EventArgs) Handles btnSquare.Click
        'Set All Boolean Flags Of Tools Click To False, Except For The
        'Current One: Square

        blnLineClicked = False
        blnSquareClicked = True
        blnPencilClicked = False
        blnEraserClicked = False
        blnCircleClicked = False

        'Refresh/Repaint The Buttons, To Indicate Current Selection State
        btnCircle.BackColor = Color.White
        btnCircle.Font = New Font("Arial", 8.25, FontStyle.Regular)
        btnSquare.BackColor = Color.CadetBlue
        btnSquare.Font = New Font("Arial", 8.25, FontStyle.Bold)
        btnLine.BackColor = Color.White
        btnLine.Font = New Font("Arial", 8.25, FontStyle.Regular)

        btnFillColour.Visible = True
        cmbLineStyle.Visible = True

        squareState()
    End Sub
    Private Sub btnLine_Click(sender As Object, e As EventArgs) Handles btnLine.Click
        'Set All Boolean Flags Of Tools Click To False, Except For The
        'Current One: Line

        blnLineClicked = True
        blnSquareClicked = False
        blnPencilClicked = False
        blnEraserClicked = False
        blnCircleClicked = False

        'Refresh/Repaint The Buttons, To Indicate Current Selection State
        btnCircle.BackColor = Color.White
        btnCircle.Font = New Font("Arial", 8.25, FontStyle.Regular)
        btnSquare.BackColor = Color.White
        btnSquare.Font = New Font("Arial", 8.25, FontStyle.Regular)
        btnLine.BackColor = Color.CadetBlue
        btnLine.Font = New Font("Arial", 8.25, FontStyle.Bold)

        btnFillColour.Visible = False
        cmbLineStyle.Visible = True
    End Sub
    Private Sub btnPencil_Click(sender As Object, e As EventArgs) Handles btnPencil.Click
        'Set All Boolean Flags Of Tools Click To False, Except For The
        'Current One: Pencil

        blnLineClicked = False
        blnSquareClicked = False
        blnPencilClicked = True
        blnEraserClicked = False
        blnCircleClicked = False

        'Refresh/Repaint The Buttons, To Indicate Current Selection State
        btnCircle.BackColor = Color.White
        btnCircle.Font = New Font("Arial", 8.25, FontStyle.Regular)
        btnSquare.BackColor = Color.White
        btnSquare.Font = New Font("Arial", 8.25, FontStyle.Regular)
        btnLine.BackColor = Color.White
        btnLine.Font = New Font("Arial", 8.25, FontStyle.Regular)

        btnFillColour.Visible = False
        cmbLineStyle.Visible = False
        trkSizeAdjustment.Maximum = 30
    End Sub
    Private Sub btnFillColour_Click(sender As Object, e As EventArgs) Handles btnFillColour.Click
        If blnFillClicked Then
            blnFillClicked = False
        Else
            blnFillClicked = True
        End If

        circleState()
        squareState()
    End Sub
    Private Sub circleState()

        'Circle filled button
        If blnFillClicked = True And blnCircleClicked = True Then
            'Load A Different Picture (Change State)
            btnFillColour.BackgroundImage = My.Resources.filledCircle

            'Display A Different ToolTip, To Indicate State/Tool Change
            tipSuperPaint.SetToolTip(btnFillColour, "Draw A Filled Circle")

            'Fill Is Clicked, Fill The Objects Based On blnFillClicked
            blnFillClicked = True
        ElseIf blnFillClicked = False And blnCircleClicked = True Then
            'Fill Is Not Clicked Anymore, Return To Original Button/Tool State

            blnFillClicked = False
            btnFillColour.BackgroundImage = My.Resources.outlineCircle
            tipSuperPaint.SetToolTip(btnFillColour, "Draw Circle Outline")
        End If

        btnFillColour.BackgroundImageLayout = ImageLayout.Stretch

    End Sub
    Private Sub squareState()

        'Square filled button
        If blnFillClicked = True And blnSquareClicked = True Then
            'Load A Different Picture (Change State)
            btnFillColour.BackgroundImage = My.Resources.filledSquare

            'Display A Different ToolTip, To Indicate State/Tool Change
            tipSuperPaint.SetToolTip(btnFillColour, "Draw A Filled Square")

            'Fill Is Clicked, Fill The Objects Based On blnFillClicked
            blnFillClicked = True
        ElseIf blnFillClicked = False And blnSquareClicked Then
            'Fill Is Not Clicked Anymore, Return To Original Button/Tool State

            blnFillClicked = False
            btnFillColour.BackgroundImage = My.Resources.outlineSquare
            tipSuperPaint.SetToolTip(btnFillColour, "Return to Square Outline")
        End If

        btnFillColour.BackgroundImageLayout = ImageLayout.Stretch

    End Sub



    Private Sub picColourSample_Click(sender As Object, e As MouseEventArgs) Handles picColourSample.MouseClick
        If e.Button = MouseButtons.Left Then
            colourPickPreviousColour = Colour
            picColourSample.BackColor = Colour

            frmBasicColourSelector.StartPosition = FormStartPosition.CenterScreen
            frmBasicColourSelector.BringToFront()
            frmBasicColourSelector.Show()
            picColourSample.BackColor = Colour
            btnFillColour.BackColor = Colour
        End If
        If e.Button = MouseButtons.Right Then
            Dim colourPickDialog As New ColorDialog()

            colourPickDialog.AllowFullOpen = True
            colourPickDialog.Color = picDrawingCanvas.BackColor

            If (colourPickDialog.ShowDialog() = DialogResult.OK) Then
                Colour = colourPickDialog.Color
                picColourSample.BackColor = Colour
                btnFillColour.BackColor = Colour
            End If
        End If
    End Sub
    Private Sub picDrawingCanvas_MouseDown(sender As Object, e As MouseEventArgs) Handles picDrawingCanvas.MouseDown
        If e.Button = MouseButtons.Left Then
            mouseUpDown = True
            initialPoint.X = e.X 'Store X variable of button press
            initialPoint.Y = e.Y
        End If
    End Sub

    Private Sub btnEraser_Click(sender As Object, e As EventArgs) Handles btnEraser.Click
        'Set All Boolean Flags Of Tools Click To False, Except For The
        'Current One: Pencil

        blnLineClicked = False
        blnSquareClicked = False
        blnPencilClicked = False
        blnEraserClicked = True
        blnCircleClicked = False

        'Refresh/Repaint The Buttons, To Indicate Current Selection State
        btnCircle.BackColor = Color.White
        btnCircle.Font = New Font("Arial", 8.25, FontStyle.Regular)
        btnSquare.BackColor = Color.White
        btnSquare.Font = New Font("Arial", 8.25, FontStyle.Regular)
        btnLine.BackColor = Color.White
        btnLine.Font = New Font("Arial", 8.25, FontStyle.Regular)

        btnFillColour.Visible = False
        cmbLineStyle.Visible = False
        trkSizeAdjustment.Maximum = 30

    End Sub

    Private Sub mnuTopBarFileOpen_Click(sender As Object, e As EventArgs) Handles mnuTopBarFileOpen.Click
        Dim dlgOpenImage As New OpenFileDialog()
        dlgOpenImage.Filter = "Bitmap|*.bmp|JPEG|*.jpg"
        dlgOpenImage.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)

        If dlgOpenImage.ShowDialog = DialogResult.Cancel Then Exit Sub
        Try
            Dim newBitmap As New Bitmap(dlgOpenImage.FileName)
            If Not IsNothing(picDrawingCanvas.Image) Then picDrawingCanvas.Image.Dispose()
            picDrawingCanvas.Image = newBitmap
        Catch ex As Exception
            MsgBox("Unable to open the selected file")
        End Try
    End Sub

    Private Sub mnuTopBarHelpSupport_Click(sender As Object, e As EventArgs) Handles mnuTopBarHelpSupport.Click
        Dim pdf As Byte() = My.Resources.helpFile
        Using tmp As New FileStream("SuperPaint_help.pdf", FileMode.Create)
            tmp.Write(pdf, 0, pdf.Length)
        End Using
        Process.Start("SuperPaint_help.pdf")
    End Sub

    Private Sub picDrawingCanvas_MouseMove(sender As Object, e As MouseEventArgs) Handles picDrawingCanvas.MouseMove

        Dim currentPoint As Point

        currentPoint.X = e.X
        currentPoint.Y = e.Y

        If blnPencilClicked And mouseUpDown Then
            graphic.FillEllipse(New SolidBrush(Colour), e.X, e.Y, trkSizeAdjustment.Value, trkSizeAdjustment.Value)
        ElseIf blnEraserClicked And mouseUpDown Then
            graphic.FillRectangle(New SolidBrush(picDrawingCanvas.BackColor), e.X, e.Y, trkSizeAdjustment.Value, trkSizeAdjustment.Value)
        End If
    End Sub
    Private Sub picDrawingCanvas_MouseUp(sender As Object, e As MouseEventArgs) Handles picDrawingCanvas.MouseUp
        If e.Button = MouseButtons.Left Then
            Dim colourPen As New Pen(Colour, trkSizeAdjustment.Value)
            Dim myBrush As New SolidBrush(Colour)
            Dim finalPoint As New Point(e.X, e.Y)

            Select Case cmbLineStyle.SelectedIndex
                Case 0
                    colourPen.DashStyle = Drawing2D.DashStyle.Solid
                Case 1
                    colourPen.DashStyle = Drawing2D.DashStyle.Dash
                Case 2
                    colourPen.DashStyle = Drawing2D.DashStyle.DashDot
                Case 3
                    colourPen.DashStyle = Drawing2D.DashStyle.DashDotDot
                Case 4
                    colourPen.DashStyle = Drawing2D.DashStyle.Dot
            End Select


            If blnCircleClicked And mouseUpDown Then
                If blnFillClicked = False Then
                    shapeSpecs(e)
                    graphic.DrawEllipse(colourPen, shapeX, shapeY, shapeWidth, shapeHeight)
                Else
                    shapeSpecs(e)
                    graphic.FillEllipse(myBrush, shapeX, shapeY, shapeWidth, shapeHeight)
                End If
            ElseIf blnSquareClicked And mouseUpDown Then
                If blnFillClicked = False Then
                    shapeSpecs(e)
                    graphic.DrawRectangle(colourPen, shapeX, shapeY, shapeWidth, shapeHeight)
                Else
                    shapeSpecs(e)
                    graphic.FillRectangle(myBrush, shapeX, shapeY, shapeWidth, shapeHeight)
                End If
            ElseIf blnLineClicked And mouseUpDown Then
                graphic.DrawLine(colourPen, initialPoint, finalPoint)
            End If
            mouseUpDown = False
        End If
    End Sub
    Public Sub shapeSpecs(ByVal e As MouseEventArgs)
        If e.X - initialPoint.X < 0 Then
            shapeWidth = initialPoint.X - e.X
            shapeX = e.X
        Else
            shapeWidth = e.X - initialPoint.X
            shapeX = initialPoint.X
        End If
        If e.Y - initialPoint.Y < 0 Then
            shapeHeight = initialPoint.Y - e.Y
            shapeY = e.Y
        Else
            shapeHeight = e.Y - initialPoint.Y
            shapeY = initialPoint.Y
        End If
    End Sub

    Private Sub picDrawingCanvas_MouseClick(sender As Object, e As MouseEventArgs) Handles picDrawingCanvas.MouseClick
        If e.Button = MouseButtons.Right Then
            Dim backgroundColour As New ColorDialog()

            backgroundColour.AllowFullOpen = True
            backgroundColour.Color = picDrawingCanvas.BackColor

            If (backgroundColour.ShowDialog() = DialogResult.OK) Then
                picDrawingCanvas.BackColor = backgroundColour.Color
            End If
        End If
    End Sub

End Class