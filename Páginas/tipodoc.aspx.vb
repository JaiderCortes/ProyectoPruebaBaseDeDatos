Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports System.Data
Public Class tipodoc
    Inherits System.Web.UI.Page
    Public ds As DataSet
    Private Sub tipodoc_Init(sender As Object, e As EventArgs) Handles Me.Init
        Try
            jai = New SqlConnection
            jai.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Datos_persona.mdf;Integrated Security=True"
            Dim sql As String = "select * from Tipo_doc"
            Dim sen As New SqlDataAdapter(sql, jai)
            ds = New DataSet
            sen.Fill(ds, "Tipo_doc")

            TextBox1.Text = ds.Tables("Tipo_doc").Rows(0).Item("Id")
            TextBox2.Text = ds.Tables("Tipo_doc").Rows(0).Item("Nombre")
        Catch ex As Exception
            MsgBox("Error de conexión: " + ex.Message, MsgBoxStyle.Information, "Error")
        End Try
    End Sub
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        contdoc = 0
        TextBox1.Text = ds.Tables("Tipo_doc").Rows(contdoc).Item("Id")
        TextBox2.Text = ds.Tables("Tipo_doc").Rows(contdoc).Item("Nombre")
    End Sub
    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        contdoc = ds.Tables("Tipo_doc").Rows.Count
        contdoc = contdoc - 1
        TextBox1.Text = ds.Tables("Tipo_doc").Rows(contdoc).Item("Id")
        TextBox2.Text = ds.Tables("Tipo_doc").Rows(contdoc).Item("Nombre")
    End Sub
    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        contdoc = contdoc - 1
        If contdoc < 0 Then
            contdoc = contdoc + 1
            TextBox1.Text = ds.Tables("Tipo_doc").Rows(contdoc).Item("Id")
            TextBox2.Text = ds.Tables("Tipo_doc").Rows(contdoc).Item("Nombre")
        Else
            TextBox1.Text = ds.Tables("Tipo_doc").Rows(contdoc).Item("Id")
            TextBox2.Text = ds.Tables("Tipo_doc").Rows(contdoc).Item("Nombre")
        End If
    End Sub
    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        contdoc = contdoc + 1
        If contdoc >= ds.Tables("Tipo_doc").Rows.Count Then
            contdoc = ds.Tables("Tipo_doc").Rows.Count
            contdoc = contdoc - 1
        End If
        TextBox1.Text = ds.Tables("Tipo_doc").Rows(contdoc).Item("Id")
        TextBox2.Text = ds.Tables("Tipo_doc").Rows(contdoc).Item("Nombre")
    End Sub
    Protected Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = ""
        TextBox2.Text = ""

        Button5.Enabled = False
        Button6.Enabled = True
        Button7.Enabled = False
        Button8.Enabled = False

        TextBox2.Focus()
    End Sub
    Protected Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Call execute("insert into tipo_doc (Nombre) values ('" & TextBox2.Text & "')")
        Button5.Enabled = True
        Button6.Enabled = False
        Button7.Enabled = True
        Button8.Enabled = True

        contdoc = 0
        Response.Redirect("tipodoc.aspx")
    End Sub
    Protected Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Call execute("update tipo_doc set Nombre = '" & TextBox2.Text & "' where Id = " & TextBox1.Text & "")
        contdoc = 0
        Response.Redirect("tipodoc.aspx")
    End Sub
    Protected Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If MsgBox("¿Está seguro de eliminar el tipo de documento? Si lo elimina todas las personas con este desaparecerán jajaja", MsgBoxStyle.YesNo, "¡Pilas pues!") = MsgBoxResult.Yes Then
            Call execute("delete from tipo_doc where Id = " & TextBox1.Text & "")
            contdoc = 0
            Response.Redirect("tipodoc.aspx")
        Else
            Exit Sub
        End If
    End Sub
    Private Sub tipodoc_Load(sender As Object, e As EventArgs) Handles Me.Load
        Page.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None
    End Sub
End Class