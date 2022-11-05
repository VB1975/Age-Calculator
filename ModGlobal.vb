Module ModGlobal

    Public Age As Long

    Public Function CalculateAge(D As Date) As Long

        Dim myAge As TimeSpan = Now() - D
        Age = New DateTime(myAge.Ticks).Year - 1
        Return Age

    End Function
End Module
