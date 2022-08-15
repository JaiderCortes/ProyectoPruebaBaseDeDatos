Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports System.Data
Public Module Module1
    Public contciudad As Integer
    Public contdoc As Integer
    Public contpersona As Integer

    Public jai As SqlConnection

    Public Function execute(consulta As String)
        Try
            If jai.State = ConnectionState.open Then
                Dim cmd As SqlCommand
                cmd = New SqlCommand
                cmd.Connection = jai
                cmd.CommandText = consulta
                cmd.ExecuteNonQuery()
                jai.Close()
                MsgBox("Registro actualizado", MsgBoxStyle.Information, "Información")
            Else
                jai.Open()
                Dim cmd As SqlCommand
                cmd = New SqlCommand
                cmd.Connection = jai
                cmd.CommandText = consulta
                cmd.ExecuteNonQuery()
                jai.Close()
                MsgBox("Registro actualizado", MsgBoxStyle.Information, "Información")
            End If
        Catch ex As Exception
            MsgBox("Error", MsgBoxStyle.Exclamation, "Error")
        End Try
    End Function

    Public Sub cargarcombo(sentenciasql As String, comb As DropDownList, valor As String, mostrar As String)
        Dim datatab As New DataTable
        Dim dataada As New SqlDataAdapter(sentenciasql, jai)
        dataada.SelectCommand.Connection = jai
        dataada.SelectCommand.CommandText = sentenciasql
        dataada.Fill(datatab)

        If datatab.Rows.Count >= 0 Then
            comb.DataSource = datatab
            comb.DataValueField = datatab.Columns(valor).ToString
            comb.DataTextField = datatab.Columns(mostrar).ToString
            comb.DataBind()
        End If
    End Sub

End Module
