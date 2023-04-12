Public Class TimeConvert
    Public Enum ConvertType As Integer
        Segundos = 0
        minutos = 1
        horas = 2
    End Enum

    ''' <summary>
    ''' Obtiene el valor en milisegundo a segundos, minutos u horas
    ''' </summary>
    ''' <param name="aTime">numero de minutos, segundos u horas</param>
    ''' <param name="aType">Establece si el tiempo ingresado esta en segundos, minutos u horas</param>
    ''' <returns>Obtiene el tiempo en segundos, minutos u horas</returns>
    ''' <remarks></remarks>
    Public Shared Function ConvertMilliseconds(ByVal aTime As Integer, ByVal aType As ConvertType) As Decimal
        Select Case aType
            Case ConvertType.Segundos
                Return aTime * 1000
            Case ConvertType.minutos
                Return (aTime * 1000) * 60
            Case ConvertType.horas
                Return ((aTime * 1000) * 60) * 60
        End Select
    End Function
End Class
