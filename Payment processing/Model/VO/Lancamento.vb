Public Class Lancamento
    Private _categoria As String
    Private _descrisao As String
    Private _valor As Double
    Private _data As Date

    Class Status
        Public aPagar, emitido, pago As Boolean

        Sub New()
            aPagar = False
            emitido = False
            pago = False
        End Sub

    End Class


    Sub New(_categoria As String, _descrisao As String, _valor As Double, _data As Date)
        Me._categoria = _categoria
        Me._descrisao = _descrisao
        Me._valor = _valor
        Me._data = _data
    End Sub

    Sub New()
        ' TODO: Complete member initialization 
    End Sub


    Public Property Categoria() As String
        Get
            Return _categoria
        End Get
        Private Set(ByVal value As String)
            _categoria = value
        End Set
    End Property

    Public Property Descrisao() As String
        Get
            Return _descrisao
        End Get
        Set(value As String)
            _descrisao = value
        End Set
    End Property

    Public Property Valor() As Double
        Get
            Return _valor
        End Get
        Set(value As Double)
            _valor = value
        End Set
    End Property

    Public Property Data() As Date
        Get
            Return _data
        End Get
        Set(value As Date)
            _data = value
        End Set
    End Property

End Class
