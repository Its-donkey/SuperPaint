Public Class frmBasicColourSelector
    'Basic colour selector

    Private Sub trkRed_Scroll(sender As Object, e As EventArgs) Handles trkRed.Scroll, trkGreen.Scroll, trkBlue.Scroll
        txtRedColour.Text = CType(trkRed.Value, String)
        txtGreenColour.Text = CType(trkGreen.Value, String)
        txtBlueColour.Text = CType(trkBlue.Value, String)
        frmSuperPaint.picColourSample.BackColor = Color.FromArgb(trkRed.Value, trkGreen.Value, trkBlue.Value)
        frmSuperPaint.btnFillColour.BackColor = Color.FromArgb(trkRed.Value, trkGreen.Value, trkBlue.Value)
        Colour = Color.FromArgb(trkRed.Value, trkGreen.Value, trkBlue.Value)

    End Sub
    Private Sub txtRedColour_TextChanged(sender As Object, e As EventArgs) Handles txtRedColour.TextChanged
        trkRed.Value = Integer.Parse(txtRedColour.Text)
        frmSuperPaint.picColourSample.BackColor = Color.FromArgb(trkRed.Value, trkGreen.Value, trkBlue.Value)
        frmSuperPaint.btnFillColour.BackColor = Color.FromArgb(trkRed.Value, trkGreen.Value, trkBlue.Value)
        Colour = Color.FromArgb(trkRed.Value, trkGreen.Value, trkBlue.Value)
    End Sub
    Private Sub txtGreenColour_TextChanged(sender As Object, e As EventArgs) Handles txtGreenColour.TextChanged
        trkGreen.Value = Integer.Parse(txtGreenColour.Text)
        frmSuperPaint.picColourSample.BackColor = Color.FromArgb(trkRed.Value, trkGreen.Value, trkBlue.Value)
        frmSuperPaint.btnFillColour.BackColor = Color.FromArgb(trkRed.Value, trkGreen.Value, trkBlue.Value)
        Colour = Color.FromArgb(trkRed.Value, trkGreen.Value, trkBlue.Value)
    End Sub
    Private Sub txtBlueColour_TextChanged(sender As Object, e As EventArgs) Handles txtBlueColour.TextChanged
        trkBlue.Value = Integer.Parse(txtBlueColour.Text)
        frmSuperPaint.picColourSample.BackColor = Color.FromArgb(trkRed.Value, trkGreen.Value, trkBlue.Value)
        Colour = Color.FromArgb(trkRed.Value, trkGreen.Value, trkBlue.Value)
    End Sub

    'Private Sub picColourSampleSelectorDone_Click(sender As Object, e As EventArgs) Handles picColourSampleSelectorDone.Click
    '    frmSuperPaint.picColourSample.BackColor = Color.FromArgb(trkRed.Value, trkGreen.Value, trkBlue.Value)
    '    Close()
    'End Sub
    Private Sub btnColourSelectorDone_Click(sender As Object, e As EventArgs) Handles btnColourSelectorDone.Click
        frmSuperPaint.picColourSample.BackColor = Color.FromArgb(trkRed.Value, trkGreen.Value, trkBlue.Value)
        frmSuperPaint.btnFillColour.BackColor = Color.FromArgb(trkRed.Value, trkGreen.Value, trkBlue.Value)
        Close()
    End Sub
    '---------------------------------------------Preset Colours-----------------------------------------------------

    Private presetColour As Color
    Private Sub picRed_Click(sender As Object, e As EventArgs) Handles picRed.Click, picBrown.Click, picOrange.Click, picGold.Click, picYellow.Click, picYellowGreen.Click, picGreen.Click, picTurquoise.Click, picDeepSkyBlue.Click,
        picBlue.Click, picDarkViolet.Click, picPurple.Click, picDeepPink.Click, picHotPink.Click, picBlack.Click, picDimGray.Click, picGray.Click, picGray.Click, picDarkGray.Click, picSilver.Click, picLightGray.Click,
        picLightGray.Click, picGainsboro.Click, picWhite.Click

        Dim picSender As PictureBox = DirectCast(sender, PictureBox)


        presetColour = picSender.BackColor
        setPresetColour()
    End Sub

    Private Sub picRed_DoubleClick(sender As Object, e As EventArgs) Handles picRed.DoubleClick, picBrown.DoubleClick, picOrange.DoubleClick, picGold.DoubleClick, picYellow.DoubleClick, picYellowGreen.DoubleClick,
        picGreen.DoubleClick, picTurquoise.DoubleClick, picDeepSkyBlue.DoubleClick, picBlue.DoubleClick, picDarkViolet.DoubleClick, picPurple.DoubleClick, picDeepPink.DoubleClick, picHotPink.DoubleClick,
        picBlack.DoubleClick, picDimGray.DoubleClick, picGray.DoubleClick, picGray.DoubleClick, picDarkGray.DoubleClick, picSilver.DoubleClick, picLightGray.DoubleClick, picLightGray.DoubleClick,
        picGainsboro.DoubleClick, picWhite.DoubleClick
        Dim picSender As PictureBox = DirectCast(sender, PictureBox)


        presetColour = picSender.BackColor
        setPresetColour()
        Close()
    End Sub

    Sub setPresetColour()
        Dim colourToARGB As Integer = ColorTranslator.ToWin32(presetColour)
        Colour = presetColour
        frmSuperPaint.picColourSample.BackColor = presetColour
        frmSuperPaint.btnFillColour.BackColor = presetColour
        integerToColor(colourToARGB)
    End Sub
    '--------------------------------------------------------  Functions  --------------------------------------------------------

    Function integerToColor(ByRef RGB As Int32) As System.Drawing.Color

        Dim Bytes As Byte() = BitConverter.GetBytes(RGB)
        Dim Alpha As Byte = Bytes(3)
        Dim Red As Byte = Bytes(0)
        Dim Green As Byte = Bytes(1)
        Dim Blue As Byte = Bytes(2)
        trkRed.Value = Red
        txtRedColour.Text = CType(Red, String)
        trkGreen.Value = Green
        txtGreenColour.Text = CType(Green, String)
        trkBlue.Value = Blue
        txtBlueColour.Text = CType(Blue, String)
    End Function


End Class