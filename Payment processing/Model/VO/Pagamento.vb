Public Class Pagamento

    Private _id As ULong
    Private _descrisao As String
    Private _data As Date
    Private _valor As Double


    Sub New(_id As ULong, _descrisao As String, _data As Date, _valor As Double)
        Me._id = _id
        Me._descrisao = _descrisao
        Me._valor = _valor
        Me._data = _data
    End Sub

    Sub New(_descrisao As String, _data As Date, _valor As Double)
        Me._descrisao = _descrisao
        Me._valor = _valor
        Me._data = _data
    End Sub

    Sub New()
        ' TODO: Complete member initialization 
    End Sub

    Public Property Id() As ULong
        Get
            Return _id
        End Get
        Set(value As ULong)
            _id = value
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
