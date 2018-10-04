Imports System.Collections.Specialized


Module connection

    Public sql As String
    Public conn As New System.Data.OleDb.OleDbConnection
    Public cmd As System.Data.OleDb.OleDbCommand
    Public dr As System.Data.OleDb.OleDbDataReader
    'database
    Public Sub Connected()

        With conn
            Try
                If .State = ConnectionState.Open Then .Close()
                .ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\cocolife.accdb"
                .Open()
            Catch ex As Exception
                MsgBox("Error in Database! Contact Administrator. " & vbNewLine & ex.ToString)
                'End
            End Try
        End With
    End Sub

    'cmd use for reading and getting data
    Sub CommandRead(ByVal sql As String)
        Try
            cmd = New OleDb.OleDbCommand(sql, conn)
            dr = cmd.ExecuteReader()
        Catch ex As Exception
            MsgBox("Error in Database! Contact Administrator. " & vbNewLine & ex.ToString)
            'End
        End Try
    End Sub

    'cmd use for saving, updating and deleting data
    Sub CommandExecute(ByVal sql As String)
        Try
            cmd = New OleDb.OleDbCommand(sql, conn)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error in Database! Contact Administrator. " & vbNewLine & ex.ToString)
            End
        End Try
    End Sub

End Module
