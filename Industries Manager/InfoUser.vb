Module InfoUser
    Public UserID As Integer
    Public UserIp As String
    Public UserName As String
    Public UserSurname As String
    Public UserFirstName As String
    Public UserLastName As String
    Public UserEmail As String
    Public UserAdm As Boolean
    Public UserDepID As Integer
    Public UserDepAbrv As String
    Public UserDepName As String
    Public UserDepDirectorYN As Boolean
    Public UserDepDirectorID As Integer

    Public Sub getUserFirstAndLastName()
        Dim nomeCompleto As String = UserName & " " & UserSurname
        Dim partesNome() As String = nomeCompleto.Split(" "c)
        UserFirstName = partesNome(0)
        UserLastName = partesNome(partesNome.Length - 1)
    End Sub
End Module
