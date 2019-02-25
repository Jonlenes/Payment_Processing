Imports System.Data.OleDb

Public Class VinculoPgtoLancBo

    Public Shared Sub insert(idPgto As ULong, listVinculo As List(Of VinculoPgtoLanc))

        VinculoPgtoLancDao.deleteAll(idPgto)
        For Each vinculo As VinculoPgtoLanc In listVinculo
            VinculoPgtoLancDao.insert(vinculo)
        Next

    End Sub


End Class
