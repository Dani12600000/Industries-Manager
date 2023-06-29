Module FuncoesRepetitivas
    Dim dataAtual As Date = Today()

    Function DiferencaEntreDataAndHoje(primeiraData As Date) As String
        Dim DateInterval As TimeSpan

        DateInterval = dataAtual - primeiraData

        Return DiferencaDatasStringProcessamento(DateInterval)
    End Function

    Function DiferencaEntreHojeAndData(ultimaData As Date) As String
        Dim DateInterval As TimeSpan

        DateInterval = ultimaData - dataAtual

        Return DiferencaDatasStringProcessamento(DateInterval)
    End Function

    Function DiferencaDatasStringProcessamento(DateInterval As TimeSpan) As String
        Dim DiferencaString As String = ""

        Dim anos As Integer = DateInterval.Days \ 365
        Dim meses As Integer = (DateInterval.Days Mod 365) \ 30
        Dim dias As Integer = (DateInterval.Days Mod 365) Mod 30

        If anos > 0 Then
            DiferencaString = anos.ToString() & " ano"
            If anos > 1 Then
                DiferencaString &= "s"
            End If
        End If

        If meses > 0 Then
            If DiferencaString <> "" Then
                DiferencaString &= ", "
            End If
            DiferencaString &= meses.ToString() & " mês"
            If meses > 1 Then
                DiferencaString &= "es"
            End If
        End If

        If dias > 0 Then
            Dim semanas As Integer = dias \ 7
            Dim diasRestantes As Integer = dias Mod 7

            If DiferencaString <> "" Then
                DiferencaString &= " e "
            End If

            If semanas > 0 Then
                DiferencaString &= semanas.ToString() & " semana"
                If semanas > 1 Then
                    DiferencaString &= "s"
                End If
                If diasRestantes > 0 And meses = 0 Then
                    DiferencaString &= " e " & diasRestantes.ToString() & " dia"
                    If diasRestantes > 1 Then
                        DiferencaString &= "s"
                    End If
                End If
            Else
                DiferencaString &= dias.ToString() & " dia"
                If dias > 1 Then
                    DiferencaString &= "s"
                End If
            End If
        End If

        Return DiferencaString
    End Function
End Module
