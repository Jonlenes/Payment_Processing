Public Class VinculoPgtoLanc
    
    Private _idLanc As ULong
    Private _idPgto As ULong

    Sub New(_idLanc As ULong, _idPgto As ULong)
        ' TODO: Complete member initialization 
        Me._idLanc = _idLanc
        Me._idPgto = _idPgto
    End Sub

    Public Property idLanc() As ULong
        Get
            Return _idLanc
        End Get
        Set(value As ULong)
            _idLanc = value
        End Set
    End Property

    Public Property idPgto() As ULong
        Get
            Return _idPgto
        End Get
        Set(value As ULong)
            _idPgto = value
        End Set
    End Property

End Class
