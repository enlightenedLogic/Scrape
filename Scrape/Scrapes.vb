Imports System.Data.OleDb
Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Net

Public Class Scrapes

    Dim provider As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
    Dim myFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) & "\EnlightenedLogic\Scrape"
    Dim myDatabase As String = "\ScrapeData.accdb"
    Public dataFile = myFolder + myDatabase
    Dim connString As String = provider & dataFile
    Dim myConnection As OleDbConnection = New OleDbConnection
    Public dr As OleDbDataReader
    Dim databaseDays As Integer = 30

    Dim databaseTables As New List(Of String)
    Dim databaseColumns As New List(Of String)
    Dim currentTable As String
    Dim currentColumn As String
    Dim currentLocation As String

   


    Private Sub loadTables()
        Debug.WriteLine("LOADING TABLES")
        lstbx_AllData.Items.Clear()
        databaseTables.Clear()
        Try
            Dim userTables As DataTable = Nothing
            Dim restrictions() As String = New String(3) {}
            restrictions(3) = "Table"
            myConnection.ConnectionString = connString
            myConnection.Open()
            Using cmd As New OleDbCommand()
                cmd.Connection = myConnection
                userTables = myConnection.GetSchema("Tables", restrictions)
                For i As Integer = 0 To userTables.Rows.Count - 1 Step i + 1
                    databaseTables.Add(userTables.Rows(i)(2).ToString())
                Next

                Debug.WriteLine("COUNT: " & databaseTables.Count)
                For i = 0 To databaseTables.Count - 1

                    lstbx_Tables.Items.Add(databaseTables(i))
                    lstbx_AllData.Items.Add(databaseTables(i))
                Next
            End Using
            currentLocation = "Tables"
            lbl_Directory.Text = "\"
            Me.Refresh()
            btn_Back.Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        myConnection.Close()
    End Sub

    Private Sub loadColumns(table As String)
        'lstbx_TableItems.Items.Clear()
        lstbx_Scrapes.Items.Clear()
        lstbx_AllData.Items.Clear()
        Debug.WriteLine("Loading Columns from: " & table)
        databaseColumns.Clear()
        Try
            myConnection.ConnectionString = connString
            myConnection.Open()
            Dim schemaTable As DataTable
            schemaTable = myConnection.GetOleDbSchemaTable(OleDbSchemaGuid.Columns, _
                          New Object() {Nothing, Nothing, table, Nothing})
            Debug.Write("Rows count: " & schemaTable.Rows.Count)
            For i As Integer = 0 To schemaTable.Rows.Count - 1
                Console.WriteLine(schemaTable.Rows(i)!COLUMN_NAME.ToString)
                Debug.WriteLine("COLLL: " & schemaTable.Rows(i)!COLUMN_NAME.ToString)
                If (schemaTable.Rows(i)!COLUMN_NAME.ToString <> "ID") Then
                    If (schemaTable.Rows(i)!COLUMN_NAME.ToString <> "Datestamp") Then
                        ' lstbx_TableItems.Items.Add(schemaTable.Rows(i)!COLUMN_NAME.ToString)
                        Debug.WriteLine("COLLL MADE IT: " & schemaTable.Rows(i)!COLUMN_NAME.ToString)
                        databaseColumns.Add(schemaTable.Rows(i)!COLUMN_NAME.ToString)
                    End If

                End If
            Next i

            For i = 0 To databaseColumns.Count - 1

                lstbx_Scrapes.Items.Add(databaseColumns(i))
                lstbx_AllData.Items.Add(databaseColumns(i))
            Next
            Debug.WriteLine("done")
            myConnection.Close()
            currentLocation = "Columns"
            lbl_Directory.Text = "\" & currentTable
            Me.Refresh()
            btn_Back.Visible = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub loadColumnItems(table As String, column As String)
        lstbx_AllData.Items.Clear()
        myConnection.ConnectionString = connString
        myConnection.Open()
        Debug.WriteLine("SELECT " & column & " FROM " & table & "")
        Dim str As String
        str = "SELECT " & column & " FROM " & table & ""
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
        dr = cmd.ExecuteReader
        Debug.WriteLine("1")
        Dim counter As Integer = 0

        While dr.Read()
            '  Debug.WriteLine("2")
            If (dr(column).ToString <> "") Then

                If (counter = 0) Then
                    'Add length and tag item
                    ' Debug.WriteLine(counter & ". " & dr(column).ToString)
                    ' currentTableLength = dr(column).ToString

                    counter += 1
                ElseIf (counter = 1) Then
                    '  currentTagNumber = dr(column).ToString

                    counter += 1
                ElseIf (counter = 2) Then

                    ' currentType = dr(column).ToString

                    counter += 1
                ElseIf (counter = 3) Then

                    ' currentType = dr(column).ToString

                    counter += 1
                ElseIf (counter = 4) Then

                    ' currentType = dr(column).ToString

                    counter += 1
                ElseIf (counter = 5) Then

                    ' currentType = dr(column).ToString

                    counter += 1
                Else

                    lstbx_Data.Items.Add(dr(column).ToString)
                    lstbx_AllData.Items.Add(dr(column).ToString)
                End If
            End If
        End While
        currentLocation = "Items"
        lbl_Directory.Text = "\" & currentTable & "\" & currentColumn
        Me.Refresh()
        btn_Back.Visible = True
        myConnection.Close()

    End Sub

    Private Sub Scrapes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadTables()
        'btn_Back.Visible = False
    End Sub

    Private Sub lstbx_Tables_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstbx_Tables.SelectedIndexChanged
        Try
            loadColumns(lstbx_Tables.SelectedItem)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub lstbx_Scrapes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstbx_Scrapes.SelectedIndexChanged
        Try
            lstbx_Data.Items.Clear()
            loadColumnItems(lstbx_Tables.SelectedItem, lstbx_Scrapes.SelectedItem)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_DeleteNames_Click(sender As Object, e As EventArgs) Handles btn_DeleteNames.Click

        Try
            myConnection.ConnectionString = connString
            myConnection.Open()
            Using cmd As New OleDbCommand()
                cmd.Connection = myConnection
                cmd.CommandText = "DROP TABLE " & lstbx_Tables.SelectedItem
                Try
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                End Try
            End Using
            myConnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        lstbx_Tables.Items.Clear()
        loadTables()
        ' End If
        lstbx_Tables.Select()


    End Sub

    Private Sub btn_DeleteScrapes_Click(sender As Object, e As EventArgs) Handles btn_DeleteScrapes.Click


        ' If (lstbx_TableItems.SelectedItem) Then
        Try
            myConnection.ConnectionString = connString
            myConnection.Open()
            Using cmd As New OleDbCommand()
                cmd.Connection = myConnection
                cmd.CommandText = "ALTER TABLE " & lstbx_Tables.SelectedItem & " DROP COLUMN " & lstbx_Scrapes.SelectedItem
                Debug.WriteLine("ALTER TABLE " & lstbx_Tables.SelectedItem & " DROP COLUMN " & lstbx_Scrapes.SelectedItem)
                Try
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End Using
            myConnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        lstbx_Scrapes.Items.Clear()
        lstbx_Data.Items.Clear()
        loadColumns(lstbx_Tables.SelectedItem)
        ' End If
        lstbx_Tables.Select()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' addDbase()

    End Sub

#Region "Test Code"

    'Dim currentURL As String
    'Dim currentStart As String
    'Dim currentStartRemoveChar As String
    'Dim currentEnd As String
    'Dim currentEndRemoveChar As String
    'Dim currentItemNumber As String
    'Dim currentData As String

    'Private Sub loadTables()
    '    Debug.WriteLine("ENTERING loadTables")

    '    databaseTables.Clear()
    '    Try
    '        Dim userTables As DataTable = Nothing
    '        Dim restrictions() As String = New String(3) {}
    '        restrictions(3) = "Table"
    '        'myConnection.ConnectionString = connString
    '        'myConnection.Open()
    '        Using cmd As New OleDbCommand()
    '            cmd.Connection = myConnection
    '            userTables = myConnection.GetSchema("Tables", restrictions)
    '            For i As Integer = 0 To userTables.Rows.Count - 1 Step i + 1
    '                databaseTables.Add(userTables.Rows(i)(2).ToString())
    '            Next

    '            Debug.WriteLine("COUNT: " & databaseTables.Count)

    '        End Using
    '    Catch ex As Exception
    '        Debug.WriteLine("ERROR LOADTABLES: " & ex.Message)
    '    End Try
    '    Debug.WriteLine("LEAVING loadTables")
    '    'myConnection.Close()
    'End Sub
    'Private Sub loadColumns(table As String)
    '    'lstbx_TableItems.Items.Clear()
    '    Debug.WriteLine("ENTERING loadColumns")
    '    Debug.WriteLine("Loading Columns from: " & table)
    '    databaseColumns.Clear()
    '    Try
    '        'myConnection.ConnectionString = connString
    '        'myConnection.Open()
    '        Dim schemaTable As DataTable
    '        schemaTable = myConnection.GetOleDbSchemaTable(OleDbSchemaGuid.Columns, _
    '                      New Object() {Nothing, Nothing, table, Nothing})
    '        Debug.Write("Rows count: " & schemaTable.Rows.Count)
    '        For i As Integer = 0 To schemaTable.Rows.Count - 1
    '            Console.WriteLine(schemaTable.Rows(i)!COLUMN_NAME.ToString)
    '            Debug.WriteLine("COLLL: " & schemaTable.Rows(i)!COLUMN_NAME.ToString)
    '            If (schemaTable.Rows(i)!COLUMN_NAME.ToString <> "ID") Then
    '                If (schemaTable.Rows(i)!COLUMN_NAME.ToString <> "Datestamp") Then
    '                    ' lstbx_TableItems.Items.Add(schemaTable.Rows(i)!COLUMN_NAME.ToString)
    '                    Debug.WriteLine("COLLL MADE IT: " & schemaTable.Rows(i)!COLUMN_NAME.ToString)
    '                    databaseColumns.Add(schemaTable.Rows(i)!COLUMN_NAME.ToString)
    '                End If

    '            End If
    '        Next i

    '        Debug.WriteLine("done")
    '        'myConnection.Close()
    '    Catch ex As Exception
    '        Debug.WriteLine("ERROR LOADCOLUMNS: " & ex.Message)
    '    End Try
    '    Debug.WriteLine("LEAVING loadColumns")
    'End Sub
    'Private Sub loadColumnItems(table As String, column As String)
    '    Debug.WriteLine("ENTERING loadColumnItems")
    '    Try




    '    currentURL = ""
    '    currentStart = ""
    '    currentStartRemoveChar = ""
    '    currentEnd = ""
    '    currentEndRemoveChar = ""

    '    'myConnection.ConnectionString = connString
    '    'myConnection.Open()
    '    Debug.WriteLine("SELECT " & column & " FROM " & table & "")
    '    Dim str As String
    '    str = "SELECT " & column & " FROM " & table & ""
    '    Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
    '    dr = cmd.ExecuteReader
    '    Debug.WriteLine("1")
    '    Dim counter As Integer = 0

    '    While dr.Read()
    '        '  Debug.WriteLine("2")
    '        If (dr(column).ToString <> "") Then

    '            If (counter = 0) Then
    '                currentURL = dr(column).ToString

    '                counter += 1
    '            ElseIf (counter = 1) Then
    '                currentStart = dr(column).ToString

    '                counter += 1
    '            ElseIf (counter = 2) Then

    '                currentStartRemoveChar = dr(column).ToString

    '                counter += 1
    '            ElseIf (counter = 3) Then

    '                currentEnd = dr(column).ToString

    '                counter += 1
    '            ElseIf (counter = 4) Then

    '                currentEndRemoveChar = dr(column).ToString

    '                counter += 1
    '            ElseIf (counter = 5) Then

    '                currentItemNumber = dr(column).ToString

    '                counter += 1
    '            Else

    '                ' lstbx_Data.Items.Add(dr(column).ToString)

    '            End If
    '        End If
    '        End While
    '    Catch ex As Exception
    '        Debug.WriteLine("ERROR LOADCOLUMNITEMS: " & ex.Message)
    '    End Try
    '    'myConnection.Close()
    '    Debug.WriteLine("LEAVING loadColumnItems")
    'End Sub

    'Private Sub addDbase()
    '    Debug.WriteLine("ENTERING addDbase")
    '    Try

    '        Dim fileExists As Boolean = File.Exists(dataFile)

    '        If (fileExists) Then

    '            Dim columnString As String
    '            Dim scrapeString As String
    '            myConnection.ConnectionString = connString
    '            myConnection.Open()
    '            loadTables()
    '            Using cmd As New OleDbCommand()
    '                cmd.Connection = myConnection
    '                'Create Column and tag String

    '                For i = 0 To databaseTables.Count - 1
    '                    columnString = ""
    '                    loadColumns(databaseTables(i))
    '                    If (databaseColumns.Count <> 0) Then
    '                        columnString = databaseColumns(0)
    '                        loadColumnItems(databaseTables(i), databaseColumns(0))
    '                        scrape(currentURL)

    '                        scrapeString = "'" & currentData & "'"



    '                        If (databaseColumns.Count > 1) Then
    '                            For c = 1 To databaseColumns.Count - 1
    '                                columnString = columnString & ", " & databaseColumns(c)
    '                                loadColumnItems(databaseTables(i), databaseColumns(c))
    '                                scrape(currentURL)

    '                                scrapeString = scrapeString & ", '" & currentData & "'"

    '                            Next
    '                        End If
    '                        cmd.CommandText = "insert into " & databaseTables(i) & "(" & columnString & ", [Datestamp]) values (" & scrapeString & ", '" & Now.ToString("g") & "' )"
    '                        Try
    '                            cmd.ExecuteNonQuery()
    '                        Catch ex As Exception
    '                            Debug.WriteLine("ERROR: " & ex.Message)
    '                        End Try
    '                        'cmd.CommandText = "insert into " & databaseTables(i) & " ([Datestamp]) values ('" & Now.ToString("g") & "')"

    '                        'Try
    '                        '    cmd.ExecuteNonQuery()
    '                        'Catch ex As Exception
    '                        '    Debug.WriteLine("ERROR: " & ex.Message)
    '                        'End Try
    '                        Debug.WriteLine("SUCCESS")

    '                    End If

    '                Next
    '                cmd.Dispose()
    '            End Using
    '            myConnection.Close()
    '        End If

    '    Catch ex As Exception
    '        Debug.WriteLine("ERROR ADDDBASE: " & ex.Message)
    '    End Try
    '    Debug.WriteLine("LEAVING addDbase")
    'End Sub

    'Private Sub scrape(URL As String)

    '    Debug.WriteLine("Entering scrape")
    '    Debug.WriteLine("Current URL: " & currentURL)
    '    Dim readWebsite As HttpWebRequest = HttpWebRequest.Create(URL)
    '    Dim responseWebsite As HttpWebResponse = readWebsite.GetResponse()
    '    Dim Websitesrc As String = New StreamReader(responseWebsite.GetResponseStream()).ReadToEnd()

    '    Try
    '        Debug.WriteLine("currentStart: " & currentStart)
    '        Debug.WriteLine("currentEnd: " & currentEnd)
    '        Dim Websitesrc1 As String() = GetBetweenAll(Websitesrc, currentStart, currentEnd)
    '        Dim counter As Integer = 0
    '        Debug.WriteLine("currentStartRemoveChar: " & currentStartRemoveChar)
    '        For Each s As String In Websitesrc1

    '            'Remove Chars Before
    '            If (currentStartRemoveChar <> "") Then
    '                Try
    '                    s = s.Remove(0, CInt(currentStartRemoveChar))
    '                Catch ex As Exception
    '                    Debug.WriteLine("Could Not Remove Start Char: " & ex.Message)
    '                End Try
    '            End If
    '            'Debug.WriteLine("Still Here")
    '            ''Remove Chars After
    '            If (currentEndRemoveChar <> "") Then
    '                Try
    '                    s = s.Substring(0, s.Length - currentEndRemoveChar)
    '                Catch ex As Exception
    '                    Debug.WriteLine("Could Not Remove End Char: " & ex.Message)
    '                End Try
    '            End If
    '            Debug.WriteLine("currentItemNumber: " & currentItemNumber)
    '            If (counter = CInt(currentItemNumber)) Then
    '                currentData = s
    '            End If

    '            counter += 1

    '        Next

    '    Catch ex As Exception
    '        Debug.WriteLine("ERROR SCRAPE: " & ex.Message)
    '    End Try
    '    Debug.WriteLine("LEAVING SCRAPE")
    'End Sub

    'Private Function GetBetweenAll(ByVal Source As String, ByVal Str1 As String, ByVal Str2 As String) As String()



    '    Dim Results, T As New List(Of String)
    '    T.AddRange(Regex.Split(Source, Str1))
    '    T.RemoveAt(0)
    '    For Each I As String In T
    '        Results.Add(Regex.Split(I, Str2)(0))
    '    Next
    '    Return Results.ToArray


    'End Function


#End Region

    Private Sub lstbx_AllData_DoubleClicked(sender As Object, e As EventArgs) Handles lstbx_AllData.DoubleClick
        Try
            If (lstbx_AllData.SelectedItem <> "") Then

                Debug.WriteLine("Double Clicked: " & lstbx_AllData.SelectedItem)
                Debug.WriteLine("currentLocation: " & currentLocation)
                If (currentLocation = "Tables") Then
                    currentTable = lstbx_AllData.SelectedItem
                    Debug.WriteLine("currentTable: " & currentTable)
                    loadColumns(lstbx_AllData.SelectedItem)
                    ' btn_Back.Visible = False
                ElseIf (currentLocation = "Columns") Then
                    currentColumn = lstbx_AllData.SelectedItem
                    Debug.WriteLine("currentColumn: " & currentColumn)
                    loadColumnItems(currentTable, currentColumn)


                End If
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_Back_Click(sender As Object, e As EventArgs) Handles btn_Back.Click
        Try

       
        Debug.WriteLine("currentLocationA: " & currentLocation)
        If (currentLocation = "Tables") Then
            ' loadTables()
        ElseIf (currentLocation = "Columns") Then
            loadTables()
        ElseIf (currentLocation = "Items") Then
            loadColumns(currentTable)
        End If
            ' Debug.WriteLine("currentLocationB: " & currentLocation)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_DeleteAll_Click(sender As Object, e As EventArgs) Handles btn_DeleteAll.Click
        Try

        
        'Tables
        If (currentLocation = "Tables") Then
            Try
                myConnection.ConnectionString = connString
                myConnection.Open()
                Using cmd As New OleDbCommand()
                    cmd.Connection = myConnection
                    cmd.CommandText = "DROP TABLE " & lstbx_AllData.SelectedItem
                    Try
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                    End Try
                End Using
                myConnection.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            lstbx_Tables.Items.Clear()
            lstbx_AllData.Items.Clear()
            loadTables()
            ' End If
            lstbx_Tables.Select()

        ElseIf (currentLocation = "Columns") Then
            'Columns

            ' If (lstbx_TableItems.SelectedItem) Then
            Try
                myConnection.ConnectionString = connString
                myConnection.Open()
                Using cmd As New OleDbCommand()
                    cmd.Connection = myConnection
                    cmd.CommandText = "ALTER TABLE " & currentTable & " DROP COLUMN " & lstbx_AllData.SelectedItem
                    ' Debug.WriteLine("ALTER TABLE " & lstbx_Tables.SelectedItem & " DROP COLUMN " & lstbx_Scrapes.SelectedItem)
                    Try
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End Using
                myConnection.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            lstbx_Scrapes.Items.Clear()
            lstbx_Data.Items.Clear()
            loadColumns(currentTable)
            ' End If
            lstbx_Tables.Select()
        Else

        End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub lstbx_AllData_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstbx_AllData.SelectedIndexChanged
        Try

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Scrapes_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        MainForm.Show()
       
        Me.Hide()
    End Sub
End Class