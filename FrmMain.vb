Public Class FrmMain
    Private Sub CalDateOfBirth_DateSelected(sender As Object, e As DateRangeEventArgs) Handles CalDateOfBirth.DateSelected

        TxtDateOfBirth.Text = CalDateOfBirth.SelectionStart.ToLongDateString
        Age = CalculateAge(TxtDateOfBirth.Text)
        TxtAge.Text = Age & " years old!"

    End Sub

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CalDateOfBirth.SelectionStart = New DateTime(1975, 6, 20)

    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click

        Application.Exit()

    End Sub
End Class
