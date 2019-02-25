Public Class Util
    Public Shared Function dinheiroToDouble(sValor As String) As Double
        Return Convert.ToDouble(sValor.Substring(3))
    End Function

    Public Shared Function convertDate(sData As String) As Date
        Dim ano, mes, dia As Integer

        dia = Convert.ToInt16(sData.Substring(0, sData.Length - 4))
        Dim meses As String() = {"JAN", "FEV", "MAR", "ABR", "MAI", "JUN", "JUL", "AGO", "SET", "OUT", "NOV", "DEZ"}
        mes = meses.ToList().IndexOf(sData.Substring(sData.Length - 3, 3)) + 1
        ano = IIf(mes <= Today.Month, Today.Year, Today.Year - 1)

        Return New Date(ano, mes, dia)

    End Function

End Class
