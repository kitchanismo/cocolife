
Imports System.Data
Imports System.Data.OleDb
Imports DynamicCard
Imports DynamicCard.Styles

'all clients database operations will be happen here

Public Class ClientService
    Inherits Client


    Public Function GetClientCards() As List(Of Card)

        Dim cards As New List(Of Card)

        Connected()

        sql = "Select lastName,id,firstname,policyno from tblClient where isDelete = 'false'"

        CommandRead(sql)

        While (dr.Read())
            Dim fullname As String = dr("lastName") & ", " & dr("firstname")

            cards.Add(New ClientCard With {
                .Key = dr("id"),
                .Title = fullname,
                .Subtitle = dr("policyno"),
                .ImagePath = Application.StartupPath & "\img\" & "boy.png"
             })
        End While

        Return cards
    End Function


    Public Sub ShowArchive(ByVal lv As ListView)
        Connected()
        sql = "Select * from tblClient where isDelete = 'true' order by id"
        CommandRead(sql)
        lv.Items.Clear()
        While (dr.Read())
            With lv.Items.Add(dr("id"))
                .SubItems.Add(dr("policyno"))
                .SubItems.Add(dr("firstname") & " " & dr("middleName") & " " & dr("lastName"))
                .SubItems.Add(dr("officerPromo"))
                .SubItems.Add(dr("officerSales"))
                .SubItems.Add(dr("InsuredDate"))
                .SubItems.Add(dr("AppointDate"))
            End With
        End While
    End Sub

    'this method is to show certain client in designated controls(textbox, combobox, etc)
    Public Sub ShowClientById(ByVal id As Integer)
        Connected()
        sql = "Select * from tblClient where isDelete = 'false' and id = " & id & " "
        CommandRead(sql)
        While (dr.Read())
            policyNumber = dr("policyno")
            firstName = dr("firstname")
            lastName = dr("lastName")
            middleName = dr("middleName")
            address = dr("address")
            gender = dr("gender")
            contact = dr("contactNumber")
            civil = dr("civilStatus")
            birthDate = dr("birthdate")
            promoOfficer = dr("officerPromo")
            salesOfficer = dr("officerSales")
            appointDate = dr("AppointDate")
            insuredDate = dr("InsuredDate")
        End While
    End Sub

    'this method will search users key as or policyno or fname or lname or mname
    Public Sub Search(ByVal str As String, ByVal lv As ListView)
        Connected()
        Dim key As String = "'%" & str.Trim & "%'"
        sql = "Select * from tblClient where policyno like " & key & " or firstname like " & key & " or lastname like " & key & " or middlename like " & key & " and isDelete = 'false' order by id"
        CommandRead(sql)
        lv.Items.Clear()
        While (dr.Read())
            With lv.Items.Add(dr("id"))
                .SubItems.Add(dr("policyno"))
                .SubItems.Add(dr("firstname") & " " & dr("middleName") & " " & dr("lastName"))
                .SubItems.Add(dr("contactNumber"))
                .SubItems.Add(dr("birthdate"))
                .SubItems.Add(dr("gender"))
                .SubItems.Add(dr("address"))
                .SubItems.Add(dr("civilStatus"))
                .SubItems.Add(dr("officerPromo"))
                .SubItems.Add(dr("officerSales"))
                .SubItems.Add(dr("InsuredDate"))
                .SubItems.Add(dr("AppointDate"))
            End With
        End While
    End Sub

    'this method will save user info
    Public Sub Insert()
        Connected()
        sql = "INSERT INTO tblClient " _
            & "(policyno, firstName, lastName, middleName, gender, civilStatus, contactNumber, address, birthdate, officerPromo, officerSales, appointDate, insuredDate, isdelete)" _
            & "VALUES ('" & policyNumber.ToString & "','" & firstName.ToString & "','" & lastName.ToString & "','" & middleName.ToString & "','" & gender.ToString & "','" & civil.ToString & "','" & contact & "','" & address.ToString & "','" & birthDate.ToString & "', " _
            & "'" & promoOfficer.ToString & "','" & salesOfficer.ToString & "','" & appointDate.ToString & "','" & insuredDate.ToString & "','false')"

        CommandExecute(sql)
        MsgBox("Successfully Added", MsgBoxStyle.Information)
    End Sub

    'this method will update user info
    Public Sub Update(ByVal id As Integer)

        Connected()
        sql = "UPDATE tblClient SET policyno = '" & policyNumber.ToString & "',lastName = '" & lastName.ToString & "', firstName = '" & firstName.ToString & "', middleName = '" & middleName.ToString & "', civilStatus = '" & civil.ToString & "'," _
            & "contactNumber=" & contact.ToString & ", address='" & address.ToString & "', birthdate='" & birthDate.ToString & "',officerPromo='" & promoOfficer.ToString & "',officerSales='" & salesOfficer.ToString & "', appointDate='" & appointDate.ToString & "', insuredDate='" & insuredDate.ToString & "', gender='" & gender.ToString & "'" _
            & " where id = " & id & ""

        CommandExecute(sql)
        MsgBox("Successfully Updated", MsgBoxStyle.Information)
    End Sub

    'this method will delete user info
    Public Sub Delete(ByVal id As Integer)
        Connected()
        sql = "UPDATE tblClient SET isDelete = 'true' where id = " & id & ""
        CommandExecute(sql)
        MsgBox("Successfully Deleted", MsgBoxStyle.Information)
    End Sub

    'this method will delete user info
    Public Sub Retrive(ByVal id As Integer)
        Connected()
        sql = "UPDATE tblClient SET isDelete = 'false' where id = " & id & ""
        CommandExecute(sql)
        MsgBox("Successfully Retrived", MsgBoxStyle.Information)
    End Sub

    Public Sub generateReports(ByVal lv As ListView, ByVal fromdate As Date, ByVal todate As Date)
        Connected()
        With lv
            .Items.Clear()
            sql = " SELECT * FROM tblClient where insuredDate >  # " & fromdate & " #   AND insuredDate < # " & todate & " #  order by insuredDate"
            CommandRead(sql)
            lv.Items.Clear()
            While (dr.Read())
                With lv.Items.Add(dr("insuredDate"))
                    .SubItems.Add(dr("policyno"))
                    .SubItems.Add(dr("firstname") & " " & dr("middleName") & " " & dr("lastName"))
                    .SubItems.Add(dr("officerPromo"))
                    .SubItems.Add(dr("officerSales"))
                End With
            End While
        End With
    End Sub

    Public Sub showReports(ByVal lv As ListView)
        Connected()
        With lv
            .Items.Clear()
            sql = " SELECT * FROM tblClient where isdelete = 'false' order by insuredDate"
            CommandRead(sql)
            lv.Items.Clear()
            While (dr.Read())
                With lv.Items.Add(dr("insuredDate"))
                    .SubItems.Add(dr("policyno"))
                    .SubItems.Add(dr("firstname") & " " & dr("middleName") & " " & dr("lastName"))
                    .SubItems.Add(dr("officerPromo"))
                    .SubItems.Add(dr("officerSales"))
                End With
            End While
        End With
    End Sub


    Public Function getDate(ByVal i As String) As String
        Connected()
        sql = " SELECT " & i & "(insuredDate) FROM tblClient"
        CommandRead(sql)
        While (dr.Read())
            Return dr(0).ToString()
        End While
        Return Nothing
    End Function


    Function isPolicyNumExist(ByVal policyno As String) As Boolean
        Connected()
        sql = "Select * from tblClient where policyno = '" & policyno & "'"
        CommandRead(sql)
        If dr.HasRows Then
            Return True
        Else
            Return False
        End If
    End Function



End Class
