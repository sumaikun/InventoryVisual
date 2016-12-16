Imports System.Data.SqlClient
Public Class Functions
    Dim sqlconnect As New SqlConnection(My.Settings.Inventory)
    Dim command As SqlCommand
    Dim show_Items As DataTable

    Public Function add_item(ByVal data As Propertys)
        Try
            sqlconnect.Open()
            command = New SqlCommand("SP_createItem", sqlconnect)
            command.CommandType = CommandType.StoredProcedure

            With command.Parameters
                .AddWithValue("@Code", data.code)
                .AddWithValue("@Name", data.name)
                .AddWithValue("@Storaged", data.storaged)
                .AddWithValue("@Pic", data.pic)
            End With

            If command.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            sqlconnect.Close()
        End Try
    End Function

    Public Function edit_item(ByVal data As Propertys)
        Try
            sqlconnect.Open()
            command = New SqlCommand("SP_updateItem", sqlconnect)
            command.CommandType = CommandType.StoredProcedure

            With command.Parameters
                .AddWithValue("@Code", data.code)
                .AddWithValue("@Name", data.name)
                .AddWithValue("@Storaged", data.storaged)
                .AddWithValue("@Pic", data.pic)
            End With

            If command.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            sqlconnect.Close()
        End Try

    End Function

    Public Function delete_item(ByVal data As Propertys)
        Try
            sqlconnect.Open()
            command = New SqlCommand("SP_deleteItem", sqlconnect)
            command.CommandType = CommandType.StoredProcedure

            With command.Parameters
                .AddWithValue("@Code", data.code)

            End With

            If command.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            sqlconnect.Close()
        End Try

    End Function

    Public Function show_item() As DataTable
        Try
            sqlconnect.Open()
            command = New SqlCommand("SP_showItem", sqlconnect)

            If command.ExecuteNonQuery() Then
                Dim da As New SqlDataAdapter(command)
                show_items = New DataTable
                da.Fill(show_Items)

                Return show_Items
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            sqlconnect.Close()
        End Try
    End Function
End Class
