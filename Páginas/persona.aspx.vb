Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports System.Data

Public Class persona
    Inherits System.Web.UI.Page
    Public ds As DataSet

    Private Sub persona_Init(sender As Object, e As EventArgs) Handles Me.Init
        Try
            jai = New SqlConnection
            jai.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Datos_persona.mdf;Integrated Security=True"
            Dim sql As String = "select * from persona"
            Dim da As New SqlDataAdapter(sql, jai)
            ds = New DataSet
            da.Fill(ds, "persona")

            TextBox1.Text = ds.Tables("persona").Rows(0).Item("Id")
            TextBox2.Text = ds.Tables("persona").Rows(0).Item("Nombres")
            TextBox3.Text = ds.Tables("persona").Rows(0).Item("Apellidos")
            TextBox4.Text = ds.Tables("persona").Rows(0).Item("Documento")
            TextBox5.Text = ds.Tables("persona").Rows(0).Item("Direccion")
            TextBox6.Text = ds.Tables("persona").Rows(0).Item("Telefono")
            TextBox7.Text = ds.Tables("persona").Rows(0).Item("Email")

            Call cargarcombo("select * from ciudad", DropDownList1, "Id", "Nombre")
            DropDownList1.SelectedValue = ds.Tables("persona").Rows(0).Item("Id_ciudad")

            Call cargarcombo("select * from tipo_doc", DropDownList2, "Id", "Nombre")
            DropDownList1.SelectedValue = ds.Tables("persona").Rows(0).Item("Id_tipodoc")
        Catch ex As Exception
            MsgBox("Error de conexión: " + ex.Message, MsgBoxStyle.Information, "Error")
        End Try
    End Sub
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        contpersona = 0
        TextBox1.Text = ds.Tables("persona").Rows(contpersona).Item("Id")
        TextBox2.Text = ds.Tables("persona").Rows(contpersona).Item("Nombres")
        TextBox3.Text = ds.Tables("persona").Rows(contpersona).Item("Apellidos")
        TextBox4.Text = ds.Tables("persona").Rows(contpersona).Item("Documento")
        TextBox5.Text = ds.Tables("persona").Rows(contpersona).Item("Direccion")
        TextBox6.Text = ds.Tables("persona").Rows(contpersona).Item("Telefono")
        TextBox7.Text = ds.Tables("persona").Rows(contpersona).Item("Email")
        DropDownList1.SelectedValue = ds.Tables("persona").Rows(contpersona).Item("Id_ciudad")
        DropDownList2.SelectedValue = ds.Tables("persona").Rows(contpersona).Item("Id_tipodoc")
    End Sub
    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        contpersona = ds.Tables("persona").Rows.Count
        contpersona = contpersona - 1
        TextBox1.Text = ds.Tables("persona").Rows(contpersona).Item("Id")
        TextBox2.Text = ds.Tables("persona").Rows(contpersona).Item("Nombres")
        TextBox3.Text = ds.Tables("persona").Rows(contpersona).Item("Apellidos")
        TextBox4.Text = ds.Tables("persona").Rows(contpersona).Item("Documento")
        TextBox5.Text = ds.Tables("persona").Rows(contpersona).Item("Direccion")
        TextBox6.Text = ds.Tables("persona").Rows(contpersona).Item("Telefono")
        TextBox7.Text = ds.Tables("persona").Rows(contpersona).Item("Email")
        DropDownList1.SelectedValue = ds.Tables("persona").Rows(contpersona).Item("Id_ciudad")
        DropDownList2.SelectedValue = ds.Tables("persona").Rows(contpersona).Item("Id_tipodoc")
    End Sub
    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        contpersona = contpersona - 1
        If contpersona < 0 Then
            contpersona = contpersona + 1
            TextBox1.Text = ds.Tables("persona").Rows(contpersona).Item("Id")
            TextBox2.Text = ds.Tables("persona").Rows(contpersona).Item("Nombres")
            TextBox3.Text = ds.Tables("persona").Rows(contpersona).Item("Apellidos")
            TextBox4.Text = ds.Tables("persona").Rows(contpersona).Item("Documento")
            TextBox5.Text = ds.Tables("persona").Rows(contpersona).Item("Direccion")
            TextBox6.Text = ds.Tables("persona").Rows(contpersona).Item("Telefono")
            TextBox7.Text = ds.Tables("persona").Rows(contpersona).Item("Email")
            DropDownList1.SelectedValue = ds.Tables("persona").Rows(contpersona).Item("Id_ciudad")
            DropDownList2.SelectedValue = ds.Tables("persona").Rows(contpersona).Item("Id_tipodoc")
        Else
            TextBox1.Text = ds.Tables("persona").Rows(contpersona).Item("Id")
            TextBox2.Text = ds.Tables("persona").Rows(contpersona).Item("Nombres")
            TextBox3.Text = ds.Tables("persona").Rows(contpersona).Item("Apellidos")
            TextBox4.Text = ds.Tables("persona").Rows(contpersona).Item("Documento")
            TextBox5.Text = ds.Tables("persona").Rows(contpersona).Item("Direccion")
            TextBox6.Text = ds.Tables("persona").Rows(contpersona).Item("Telefono")
            TextBox7.Text = ds.Tables("persona").Rows(contpersona).Item("Email")
            DropDownList1.SelectedValue = ds.Tables("persona").Rows(contpersona).Item("Id_ciudad")
            DropDownList2.SelectedValue = ds.Tables("persona").Rows(contpersona).Item("Id_tipodoc")
        End If
    End Sub
    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        contpersona = contpersona + 1
        If contpersona >= ds.Tables("persona").Rows.Count Then
            contpersona = ds.Tables("persona").Rows.Count
            contpersona = contpersona - 1
        End If
        TextBox1.Text = ds.Tables("persona").Rows(contpersona).Item("Id")
        TextBox2.Text = ds.Tables("persona").Rows(contpersona).Item("Nombres")
        TextBox3.Text = ds.Tables("persona").Rows(contpersona).Item("Apellidos")
        TextBox4.Text = ds.Tables("persona").Rows(contpersona).Item("Documento")
        TextBox5.Text = ds.Tables("persona").Rows(contpersona).Item("Direccion")
        TextBox6.Text = ds.Tables("persona").Rows(contpersona).Item("Telefono")
        TextBox7.Text = ds.Tables("persona").Rows(contpersona).Item("Email")
        DropDownList1.SelectedValue = ds.Tables("persona").Rows(contpersona).Item("Id_ciudad")
        DropDownList2.SelectedValue = ds.Tables("persona").Rows(contpersona).Item("Id_tipodoc")
    End Sub
    Protected Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""

        Button5.Enabled = False
        Button6.Enabled = True
        Button7.Enabled = False
        Button8.Enabled = False

        TextBox2.Focus()
    End Sub
    Protected Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Call execute("insert into persona (Nombres, Apellidos, Documento, Direccion, Telefono, Email, Id_ciudad, Id_tipodoc) values ('" & TextBox2.Text & "', '" & TextBox3.Text & "', '" & TextBox4.Text & "', '" & TextBox5.Text & "', '" & TextBox6.Text & "', '" & TextBox7.Text & "', " & DropDownList1.SelectedValue & ", " & DropDownList2.SelectedValue & ")")
        Button5.Enabled = True
        Button6.Enabled = False
        Button7.Enabled = True
        Button8.Enabled = True

        contpersona = 0
        Response.Redirect("persona.aspx")
    End Sub
    Protected Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Call execute("update persona set Nombres = '" & TextBox2.Text & "', Apellidos = '" & TextBox3.Text & "', Documento = '" & TextBox4.Text & "', Direccion = '" & TextBox5.Text & "', Telefono = '" & TextBox6.Text & "', Email = '" & TextBox7.Text & "', Id_ciudad = " & DropDownList1.SelectedValue & ", Id_tipodoc = " & DropDownList2.SelectedValue & " where Id = " & TextBox1.Text & "")
        contpersona = 0
        Response.Redirect("persona.aspx")
    End Sub
    Protected Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If MsgBox("¿Está seguro que quiere eliminar a esta persona? Si la elimina desaparecerá del mundo jajaja", MsgBoxStyle.YesNo, "¡Atencion!") = MsgBoxResult.Yes Then
            Call execute("delete from persona where Id = " & TextBox1.Text & "")
            contpersona = 0
            Response.Redirect("persona.aspx")
        Else
            Exit Sub
        End If
    End Sub
    Private Sub persona_Load(sender As Object, e As EventArgs) Handles Me.Load
        Page.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None
    End Sub
End Class