Imports System.Text.RegularExpressions
Imports System.Net
Imports System.IO
Imports System.Data.OleDb
Imports Enlightened.Management

Public Class MainForm

#Region "Database Setup"
    Dim provider As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
    Dim myDatabase As String = "\ScrapeData.accdb"
    Dim myFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) & "\EnlightenedLogic\Scrape"
    Public dataFile = myFolder + myDatabase
    Dim connString As String = provider & dataFile
    Dim myConnection As OleDbConnection = New OleDbConnection
    Public dr As OleDbDataReader
    Dim databaseDays As Integer = 30
#End Region

#Region "Variables"
    Dim aItems As New List(Of String)
    Dim bItems As New List(Of String)
    Dim cItems As New List(Of String)
    Dim dItems As New List(Of String)
    Dim eItems As New List(Of String)
#End Region

#Region "Scrape/Database Code"

    Private Function GetBetweenAll(ByVal Source As String, ByVal Str1 As String, ByVal Str2 As String) As String()


        Dim Results, T As New List(Of String)
        T.AddRange(Regex.Split(Source, Str1))
        T.RemoveAt(0)
        For Each I As String In T
            Results.Add(Regex.Split(I, Str2)(0))
        Next
        Return Results.ToArray


    End Function

    Private Sub MainForm_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Application.Exit()
    End Sub

    Private Sub checkDatabaseStatus()

        'var settings = ConfigurationManager.ConnectionStrings[ 0 ];

        'var fi = typeof( ConfigurationElement ).GetField( "_bReadOnly", BindingFlags.Instance | BindingFlags.NonPublic );

        'fi.SetValue(settings, false);

        'settings.ConnectionString = "Data Source=Something";
        
        Try


            ' MsgBox("OK: " & dataFile)
            Dim fileExists As Boolean = File.Exists(dataFile)

            If (fileExists) Then

            Else
                Try

                
                    My.Computer.FileSystem.CreateDirectory(myFolder)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                Try

                
                Dim cat As New ADOX.Catalog()
                cat.Create("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & dataFile)
                cat = Nothing
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            ' create the empty DB file

        Catch ex As Exception
            MsgBox("This software Requires Access Database Engine: http://www.microsoft.com/en-us/download/details.aspx?id=39358")
        End Try

        'Try


        '    myConnection.ConnectionString = connString
        '    myConnection.Open()

        '    Using cmd As New OleDbCommand()
        '        cmd.Connection = myConnection

        '        First Try, Create Table/Alter/Add Data
        '        Str = "CREATE DATABASE ScadaData ON PRIMARY (NAME = MyDatabase_Data, FILENAME = 'C:\ProgramData\ScadaData.accdb'"

        '        cmd.CommandText = "CREATE DATABASE ScadaData ON PRIMARY (NAME = MyDatabase_Data, FILENAME = 'C:\ProgramData\ScadaData.accdb'"
        '        cmd.ExecuteNonQuery()
        '    End Using

        '    myConnection.Close()
        'Catch ex As Exception
        '    MsgBox("ERRORz: " & ex.Message)
        'End Try


    End Sub

#End Region

#Region "Buttons"

    Private Sub btn_Scrape_Click(sender As Object, e As EventArgs) Handles btn_Scrape.Click
        Try

 



        lstbx_Data.Items.Clear()
        aItems.Clear()
        bItems.Clear()
        cItems.Clear()
        dItems.Clear()
        eItems.Clear()


        Dim readWebsite As HttpWebRequest = HttpWebRequest.Create(txtbx_URL.Text)
        Dim responseWebsite As HttpWebResponse = readWebsite.GetResponse()
        Dim Websitesrc As String = New StreamReader(responseWebsite.GetResponseStream()).ReadToEnd()


        'Scrape 1st

        Try

            If (txtbx_Before1.Text <> "" And txtbx_After1.Text <> "") Then

                lstbx_Data.Items.Add("----------------------------[A]------------------------")
                lstbx_Data.Items.Add("")

                Dim Websitesrc1 As String() = GetBetweenAll(Websitesrc, txtbx_Before1.Text, txtbx_After1.Text)
                Dim counter As Integer = 0
                For Each s As String In Websitesrc1

                    'Remove Chars Before
                    If (txtbx_CharBefore1.Text <> "") Then
                        s = s.Remove(0, CInt(txtbx_CharBefore1.Text))
                    End If

                    'Remove Chars After
                    If (txtbx_CharAfter1.Text <> "") Then
                        s = s.Substring(0, s.Length - CInt(txtbx_CharAfter1.Text))
                    End If

                    'List Items Found
                    'If (txtbx_ItemNumber.Text <> "") Then
                    '    If (CInt(txtbx_ItemNumber.Text) = counter) Then
                    '        lstbx_Data.Items.Add("Item " & counter & ". " & s)
                    '    End If
                    'Else
                    '    lstbx_Data.Items.Add("Item " & counter & ". " & s)
                    'End If
                    aItems.Add(s)
                    lstbx_Data.Items.Add("Item " & counter & ". " & s)

                    counter += 1

                Next


                lstbx_Data.Items.Add("")
                lstbx_Data.Items.Add("----------------------------[A]------------------------")
                lstbx_Data.Items.Add("")

            End If


        Catch ex As Exception
            Debug.WriteLine("ERROR: " & ex.Message)
        End Try


        'Scrape 2nd



        Try

            If (txtbx_Before2.Text <> "" And txtbx_After2.Text <> "") Then

                lstbx_Data.Items.Add("----------------------------[B]------------------------")
                lstbx_Data.Items.Add("")

                Dim Websitesrc2 As String() = GetBetweenAll(Websitesrc, txtbx_Before2.Text, txtbx_After2.Text)
                Dim counter As Integer = 0
                For Each s As String In Websitesrc2

                    'Remove Chars Before
                    If (txtbx_CharBefore2.Text <> "") Then
                        s = s.Remove(0, CInt(txtbx_CharBefore2.Text))
                    End If

                    'Remove Chars After
                    If (txtbx_CharAfter2.Text <> "") Then
                        s = s.Substring(0, s.Length - txtbx_CharAfter2.Text)
                    End If

                    'List Items Found
                    bItems.Add(s)
                    lstbx_Data.Items.Add("Item " & counter & ". " & s)

                    counter += 1

                Next

                lstbx_Data.Items.Add("")
                lstbx_Data.Items.Add("----------------------------[B]------------------------")
                lstbx_Data.Items.Add("")

            End If

        Catch ex As Exception
            Debug.WriteLine("ERROR: " & ex.Message)
        End Try





        'Scrape 3rd
        Try

            If (txtbx_Before3.Text <> "" And txtbx_After3.Text <> "") Then

                lstbx_Data.Items.Add("----------------------------[C]------------------------")
                lstbx_Data.Items.Add("")

                Dim Websitesrc3 As String() = GetBetweenAll(Websitesrc, txtbx_Before3.Text, txtbx_After3.Text)
                Dim counter As Integer = 0
                For Each s As String In Websitesrc3

                    'Remove Chars Before
                    If (txtbx_CharBefore3.Text <> "") Then
                        s = s.Remove(0, CInt(txtbx_CharBefore3.Text))
                    End If

                    'Remove Chars After
                    If (txtbx_CharAfter3.Text <> "") Then
                        s = s.Substring(0, s.Length - txtbx_CharAfter3.Text)
                    End If

                    'List Items Found
                    cItems.Add(s)
                    lstbx_Data.Items.Add("Item " & counter & ". " & s)

                    counter += 1

                Next


                lstbx_Data.Items.Add("")
                lstbx_Data.Items.Add("----------------------------[C]------------------------")
                lstbx_Data.Items.Add("")

            End If

        Catch ex As Exception
            Debug.WriteLine("ERROR: " & ex.Message)
        End Try




        'Scrape 4th
        Try
            If (txtbx_Before4.Text <> "" And txtbx_After4.Text <> "") Then

                lstbx_Data.Items.Add("----------------------------[D]------------------------")
                lstbx_Data.Items.Add("")

                Dim Websitesrc4 As String() = GetBetweenAll(Websitesrc, txtbx_Before4.Text, txtbx_After4.Text)
                Dim counter As Integer = 0
                For Each s As String In Websitesrc4

                    'Remove Chars Before
                    If (txtbx_CharBefore4.Text <> "") Then
                        s = s.Remove(0, CInt(txtbx_CharBefore4.Text))
                    End If

                    'Remove Chars After
                    If (txtbx_CharAfter4.Text <> "") Then
                        s = s.Substring(0, s.Length - txtbx_CharAfter4.Text)
                    End If

                    'List Items Found
                    dItems.Add(s)
                    lstbx_Data.Items.Add("Item " & counter & ". " & s)

                    counter += 1

                Next


                lstbx_Data.Items.Add("")
                lstbx_Data.Items.Add("----------------------------[D]------------------------")
                lstbx_Data.Items.Add("")

            End If

        Catch ex As Exception
            Debug.WriteLine("ERROR: " & ex.Message)
        End Try



        'Scrape 5th
        Try

            If (txtbx_Before5.Text <> "" And txtbx_After5.Text <> "") Then


                lstbx_Data.Items.Add("----------------------------[E]------------------------")
                lstbx_Data.Items.Add("")

                Dim Websitesrc5 As String() = GetBetweenAll(Websitesrc, txtbx_Before5.Text, txtbx_After5.Text)
                Dim counter As Integer = 0
                For Each s As String In Websitesrc5

                    'Remove Chars Before
                    If (txtbx_CharBefore5.Text <> "") Then
                        s = s.Remove(0, CInt(txtbx_CharBefore5.Text))
                    End If

                    'Remove Chars After
                    If (txtbx_CharAfter5.Text <> "") Then
                        s = s.Substring(0, s.Length - txtbx_CharAfter5.Text)
                    End If

                    'List Items Found
                    eItems.Add(s)
                    lstbx_Data.Items.Add("Item " & counter & ". " & s)

                    counter += 1

                Next


                lstbx_Data.Items.Add("")
                lstbx_Data.Items.Add("----------------------------[E]------------------------")
                lstbx_Data.Items.Add("")

            End If
        Catch ex As Exception
            Debug.WriteLine("ERROR: " & ex.Message)
        End Try
        Catch ex As Exception

            If (ex.ToString.Contains("System.UriFormatException")) Then
                MsgBox("Please Include HTTP:// Before The URL.")
            Else
                MsgBox("Please Check The URL And Try Again.")
            End If


        End Try

        txtbx_Name.Focus()

    End Sub

    Private Sub btn_Add1_Click(sender As Object, e As EventArgs) Handles btn_Add1.Click
        If (txtbx_Name.Text <> "") Then
            If (txtbx_Before1.Text <> "" And txtbx_After1.Text <> "") Then
                If (txtbx_Item1.Text <> "") Then

                    Try
                        Dim currentTable As String = txtbx_Name.Text
                        Dim currentColumn As String = "A"
                        myConnection.ConnectionString = connString
                        myConnection.Open()
                        Using cmd As New OleDbCommand()
                            cmd.Connection = myConnection
                            Try

                                cmd.CommandText = "CREATE TABLE " & currentTable & " (ID COUNTER)"
                                Debug.WriteLine("CREATE TABLE " & currentTable & " (ID COUNTER)")
                                cmd.ExecuteNonQuery()
                                'cmd.CommandText = "ALTER TABLE " & currentTable & " ADD COLUMN Datestamp TEXT(50)"
                                cmd.CommandText = "ALTER TABLE " & currentTable & " ADD COLUMN Datestamp DATETIME"
                                'Debug.WriteLine("ALTER TABLE " & currentTable & " ADD COLUMN Datestamp TEXT(50)")
                                cmd.ExecuteNonQuery()
                                cmd.CommandText = "ALTER TABLE " & currentTable & " ADD COLUMN A TEXT(200)"
                                Debug.WriteLine("ALTER TABLE " & currentTable & " ADD COLUMN A TEXT(200)")
                                cmd.ExecuteNonQuery()
                                cmd.CommandText = "insert into " & currentTable & " ([" & currentColumn & "]) values ('" & txtbx_URL.Text & "')"
                                Debug.WriteLine("insert into " & currentTable & " ([" & currentColumn & "]) values ('" & txtbx_URL.Text & "')")
                                cmd.ExecuteNonQuery()
                                cmd.CommandText = "insert into " & currentTable & " ([" & currentColumn & "]) values ('" & txtbx_Before1.Text.Replace("'", "''") & "')"
                                Debug.WriteLine("insert into " & currentTable & " ([" & currentColumn & "]) values ('" & txtbx_Before1.Text & "')")
                                cmd.ExecuteNonQuery()
                                cmd.CommandText = "insert into " & currentTable & " ([" & currentColumn & "]) values ('" & txtbx_CharBefore1.Text & "')"
                                Debug.WriteLine("insert into " & currentTable & " ([" & currentColumn & "]) values ('" & txtbx_CharBefore1.Text & "')")
                                cmd.ExecuteNonQuery()
                                cmd.CommandText = "insert into " & currentTable & " ([" & currentColumn & "]) values ('" & txtbx_After1.Text.Replace("'", "''") & "')"
                                cmd.ExecuteNonQuery()
                                cmd.CommandText = "insert into " & currentTable & " ([" & currentColumn & "]) values ('" & txtbx_CharAfter1.Text & "')"
                                cmd.ExecuteNonQuery()
                                cmd.CommandText = "insert into " & currentTable & " ([" & currentColumn & "]) values ('" & txtbx_Item1.Text & "')"
                                cmd.ExecuteNonQuery()
                                cmd.CommandText = "insert into " & currentTable & " ([Datestamp], [" & currentColumn & "]) values ('" & Now.ToString("g") & "', '" & aItems(txtbx_Item1.Text) & "')"
                                cmd.ExecuteNonQuery()
                                myConnection.Close()
                            Catch ex As Exception
                                cmd.CommandText = "ALTER TABLE " & currentTable & " ADD COLUMN " & currentColumn & " TEXT(200)"
                                cmd.ExecuteNonQuery()
                                cmd.CommandText = "insert into " & currentTable & " ([" & currentColumn & "]) values ('" & txtbx_URL.Text & "')"
                                cmd.ExecuteNonQuery()
                                cmd.CommandText = "insert into " & currentTable & " ([" & currentColumn & "]) values ('" & txtbx_Before1.Text.Replace("'", "''") & "')"
                                cmd.ExecuteNonQuery()
                                cmd.CommandText = "insert into " & currentTable & " ([" & currentColumn & "]) values ('" & txtbx_CharBefore1.Text & "')"
                                cmd.ExecuteNonQuery()
                                cmd.CommandText = "insert into " & currentTable & " ([" & currentColumn & "]) values ('" & txtbx_After1.Text.Replace("'", "''") & "')"
                                cmd.ExecuteNonQuery()
                                cmd.CommandText = "insert into " & currentTable & " ([" & currentColumn & "]) values ('" & txtbx_CharAfter1.Text & "')"
                                cmd.ExecuteNonQuery()
                                cmd.CommandText = "insert into " & currentTable & " ([" & currentColumn & "]) values ('" & txtbx_Item1.Text & "')"
                                cmd.ExecuteNonQuery()
                                cmd.CommandText = "insert into " & currentTable & " ([Datestamp], [" & currentColumn & "]) values ('" & Now.ToString("g") & "', '" & aItems(txtbx_Item1.Text) & "')"
                                cmd.ExecuteNonQuery()
                                'MsgBox(ex.Message)
                                myConnection.Close()
                            End Try
                        End Using
                        myConnection.Close()
                    Catch ex As Exception
                        ' MsgBox(ex.Message)
                    End Try
                    myConnection.Close()
                    'txtbx_Name.Select()
                Else

                    MsgBox("Please Enter Item Number")
                End If
            Else

                MsgBox("Please Fill Out Before And After For A")
            End If
            Else
                MsgBox("Please Enter A Name")
            End If


        'Try
        '    Dim currentTable As String = txtbx_Name.Text
        '    myConnection.ConnectionString = connString
        '    myConnection.Open()
        '    Using cmd As New OleDbCommand()
        '        cmd.Connection = myConnection
        '        Try
        '            cmd.CommandText = "CREATE TABLE " & currentTable & " (ID COUNTER)"
        '            cmd.ExecuteNonQuery()
        '            cmd.CommandText = "ALTER TABLE " & currentTable & " ADD COLUMN Datestamp TEXT(50)"
        '            cmd.ExecuteNonQuery()
        '            cmd.CommandText = "ALTER TABLE " & currentTable & " ADD COLUMN A TEXT(200)"
        '            cmd.ExecuteNonQuery()
        '            cmd.CommandText = "insert into " & currentTable & " ([A]) values ('" & txtbx_URL.Text & "')"
        '            cmd.ExecuteNonQuery()
        '            cmd.CommandText = "insert into " & currentTable & " ([A]) values ('" & txtbx_Before1.Text & "')"
        '            cmd.ExecuteNonQuery()
        '            cmd.CommandText = "insert into " & currentTable & " ([A]) values ('" & txtbx_CharBefore1.Text & "')"
        '            cmd.ExecuteNonQuery()
        '            cmd.CommandText = "insert into " & currentTable & " ([A]) values ('" & txtbx_After1.Text & "')"
        '            cmd.ExecuteNonQuery()
        '            cmd.CommandText = "insert into " & currentTable & " ([A]) values ('" & txtbx_CharAfter1.Text & "')"
        '            cmd.ExecuteNonQuery()
        '            cmd.CommandText = "insert into " & currentTable & " ([Datestamp], [A]) values ('" & Now.ToString("g") & "', '" & aItems(txtbx_Item1.Text) & "')"
        '            cmd.ExecuteNonQuery()
        '        Catch ex As Exception
        '            MsgBox(ex.Message)
        '        End Try
        '    End Using
        '    myConnection.Close()
        'Catch ex As Exception
        '    MsgBox("This Software Requires SQL")
        'End Try
        'txtbx_Name.Select()

        txtbx_Name.Focus()
    End Sub

    Private Sub checkForUpdate()


        '-----------------------------------BEGIN LICENSE CODE----------------------------------------
        '   Keith Harrison        December 2014        Enlightened Management                         '
        '---------------------------------------------------------------------------------------------'
        ' Give a password and appCode to determine a unique key for your application (between 5 and 9 characters)'
        '                  
        Dim appCode As Integer = 10
        Dim pass As String = "thatsmine"
        'URL you would like to check for updates
        Dim updateTextURL As String = "https://dl.dropboxusercontent.com/u/7794031/Scrape/version.txt"
        'Dim updateTextURL As String = "http://update.enlightenedlogic.com/Scrape/version.txt"
        'URL you would like to download update from
        Dim updateDownloadURL As String = "https://dl.dropboxusercontent.com/u/7794031/Scrape/Scrape%20Setup.exe"
        'Dim updateDownloadURL As String = "http://update.enlightenedlogic.com/Scrape/Scrape%20Setup.exe"
        'URL for change log
        Dim changeLogURL As String = "https://dl.dropboxusercontent.com/u/7794031/Scrape/ChangeLog.txt"
        'Dim changeLogURL As String = "http://update.enlightenedlogic.com/Scrape/ChangeLog.txt"
        'URL you would like to verify serial
        Dim serialURL As String = "https://dl.dropboxusercontent.com/u/7794031/Users.txt"
        'URL for payment
        Dim paymentURL As String = "http://site.enlightenedlogic.com/form/scrape.html"
        '                                                                                             '
        '---------------------------------------------------------------------------------------------'
        '-----------------------------------DO NOT TOUCH THIS-----------------------------------------'
        '                                                                                             '
        Dim getLicense As New generateLicense                                                         '
        Dim licensed As Boolean
        licensed = getLicense.checkSerial(serialURL, pass, paymentURL)
        If (licensed = False) Then
            licensed = getLicense.checkStatus(appCode, pass)
        End If
        getLicense.checkupdate(updateTextURL, updateDownloadURL, changeLogURL)
        '                                                                                             '
        '-----------------------------------END LICENSE CODE-------------------------------------------

    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            checkForUpdate()
            checkDatabaseStatus()
            ScrapeServiceController.ServiceName = "ScraperService"
            checkServiceStatus()
        Catch ex As Exception
            MsgBox("This Software Requires SQL and .Net 4.5 or above")
            Application.Exit()
        End Try
    End Sub

    Private Sub btn_Add2_Click(sender As Object, e As EventArgs) Handles btn_Add2.Click
        If (txtbx_Name.Text <> "") Then
            If (txtbx_Before2.Text <> "" And txtbx_After2.Text <> "") Then
                If (txtbx_Item2.Text <> "") Then
                    Try
                        Dim currentTable As String = txtbx_Name.Text
                        Dim currentColumn As String = "B"
                        myConnection.ConnectionString = connString
                        myConnection.Open()
                        Using cmd As New OleDbCommand()
                            cmd.Connection = myConnection
                            Try
                                cmd.CommandText = "CREATE TABLE " & currentTable & " (ID COUNTER)"
                                cmd.ExecuteNonQuery()
                                cmd.CommandText = "ALTER TABLE " & currentTable & " ADD COLUMN Datestamp DATETIME"
                                cmd.ExecuteNonQuery()
                                cmd.CommandText = "ALTER TABLE " & currentTable & " ADD COLUMN B TEXT(200)"
                                cmd.ExecuteNonQuery()
                                cmd.CommandText = "insert into " & currentTable & " ([" & currentColumn & "]) values ('" & txtbx_URL.Text & "')"
                                cmd.ExecuteNonQuery()
                                cmd.CommandText = "insert into " & currentTable & " ([" & currentColumn & "]) values ('" & txtbx_Before2.Text.Replace("'", "''") & "')"
                                cmd.ExecuteNonQuery()
                                cmd.CommandText = "insert into " & currentTable & " ([" & currentColumn & "]) values ('" & txtbx_CharBefore2.Text & "')"
                                cmd.ExecuteNonQuery()
                                cmd.CommandText = "insert into " & currentTable & " ([" & currentColumn & "]) values ('" & txtbx_After2.Text.Replace("'", "''") & "')"
                                cmd.ExecuteNonQuery()
                                cmd.CommandText = "insert into " & currentTable & " ([" & currentColumn & "]) values ('" & txtbx_CharAfter2.Text & "')"
                                cmd.ExecuteNonQuery()
                                cmd.CommandText = "insert into " & currentTable & " ([" & currentColumn & "]) values ('" & txtbx_Item2.Text & "')"
                                cmd.ExecuteNonQuery()
                                cmd.CommandText = "insert into " & currentTable & " ([Datestamp], [" & currentColumn & "]) values ('" & Now.ToString("g") & "', '" & bItems(txtbx_Item2.Text) & "')"
                                cmd.ExecuteNonQuery()
                                myConnection.Close()
                            Catch ex As Exception
                                cmd.CommandText = "ALTER TABLE " & currentTable & " ADD COLUMN " & currentColumn & " TEXT(200)"
                                cmd.ExecuteNonQuery()
                                cmd.CommandText = "insert into " & currentTable & " ([" & currentColumn & "]) values ('" & txtbx_URL.Text & "')"
                                cmd.ExecuteNonQuery()
                                cmd.CommandText = "insert into " & currentTable & " ([" & currentColumn & "]) values ('" & txtbx_Before2.Text.Replace("'", "''") & "')"
                                cmd.ExecuteNonQuery()
                                cmd.CommandText = "insert into " & currentTable & " ([" & currentColumn & "]) values ('" & txtbx_CharBefore2.Text & "')"
                                cmd.ExecuteNonQuery()
                                cmd.CommandText = "insert into " & currentTable & " ([" & currentColumn & "]) values ('" & txtbx_After2.Text.Replace("'", "''") & "')"
                                cmd.ExecuteNonQuery()
                                cmd.CommandText = "insert into " & currentTable & " ([" & currentColumn & "]) values ('" & txtbx_CharAfter2.Text & "')"
                                cmd.ExecuteNonQuery()
                                cmd.CommandText = "insert into " & currentTable & " ([" & currentColumn & "]) values ('" & txtbx_Item2.Text & "')"
                                cmd.ExecuteNonQuery()
                                cmd.CommandText = "insert into " & currentTable & " ([Datestamp], [" & currentColumn & "]) values ('" & Now.ToString("g") & "', '" & bItems(txtbx_Item2.Text) & "')"
                                cmd.ExecuteNonQuery()
                                myConnection.Close()
                                ' MsgBox(ex.Message)
                            End Try
                        End Using
                        myConnection.Close()
                    Catch ex As Exception
                        'MsgBox(ex.Message)
                    End Try
                    myConnection.Close()
                Else

                    MsgBox("Please Enter Item Number")
                End If
            Else

                MsgBox("Please Fill Out Before And After For B")
            End If
            Else
                MsgBox("Please Enter A Name")
            End If
            txtbx_Name.Select()

    End Sub

    Private Sub btn_Add3_Click(sender As Object, e As EventArgs) Handles btn_Add3.Click
        If (txtbx_Name.Text <> "") Then
            If (txtbx_Before3.Text <> "" And txtbx_After3.Text <> "") Then
                If (txtbx_Item3.Text <> "") Then
                    Try
                        Dim currentTable As String = txtbx_Name.Text
                        Dim currentColumn As String = "C"
                        myConnection.ConnectionString = connString
                        myConnection.Open()
                        Using cmd As New OleDbCommand()
                            cmd.Connection = myConnection
                            Try
                                cmd.CommandText = "CREATE TABLE " & currentTable & " (ID COUNTER)"
                                cmd.ExecuteNonQuery()
                                cmd.CommandText = "ALTER TABLE " & currentTable & " ADD COLUMN Datestamp DATETIME"
                                cmd.ExecuteNonQuery()
                                cmd.CommandText = "ALTER TABLE " & currentTable & " ADD COLUMN C TEXT(200)"
                                cmd.ExecuteNonQuery()
                                cmd.CommandText = "insert into " & currentTable & " ([" & currentColumn & "]) values ('" & txtbx_URL.Text & "')"
                                cmd.ExecuteNonQuery()
                                cmd.CommandText = "insert into " & currentTable & " ([" & currentColumn & "]) values ('" & txtbx_Before3.Text.Replace("'", "''") & "')"
                                cmd.ExecuteNonQuery()
                                cmd.CommandText = "insert into " & currentTable & " ([" & currentColumn & "]) values ('" & txtbx_CharBefore3.Text & "')"
                                cmd.ExecuteNonQuery()
                                cmd.CommandText = "insert into " & currentTable & " ([" & currentColumn & "]) values ('" & txtbx_After3.Text.Replace("'", "''") & "')"
                                cmd.ExecuteNonQuery()
                                cmd.CommandText = "insert into " & currentTable & " ([" & currentColumn & "]) values ('" & txtbx_CharAfter3.Text & "')"
                                cmd.ExecuteNonQuery()
                                cmd.CommandText = "insert into " & currentTable & " ([" & currentColumn & "]) values ('" & txtbx_Item3.Text & "')"
                                cmd.ExecuteNonQuery()
                                cmd.CommandText = "insert into " & currentTable & " ([Datestamp], [" & currentColumn & "]) values ('" & Now.ToString("g") & "', '" & cItems(txtbx_Item3.Text) & "')"
                                cmd.ExecuteNonQuery()
                                myConnection.Close()
                            Catch ex As Exception
                                cmd.CommandText = "ALTER TABLE " & currentTable & " ADD COLUMN " & currentColumn & " TEXT(200)"
                                cmd.ExecuteNonQuery()
                                cmd.CommandText = "insert into " & currentTable & " ([" & currentColumn & "]) values ('" & txtbx_URL.Text & "')"
                                cmd.ExecuteNonQuery()
                                cmd.CommandText = "insert into " & currentTable & " ([" & currentColumn & "]) values ('" & txtbx_Before3.Text.Replace("'", "''") & "')"
                                cmd.ExecuteNonQuery()
                                cmd.CommandText = "insert into " & currentTable & " ([" & currentColumn & "]) values ('" & txtbx_CharBefore3.Text & "')"
                                cmd.ExecuteNonQuery()
                                cmd.CommandText = "insert into " & currentTable & " ([" & currentColumn & "]) values ('" & txtbx_After3.Text.Replace("'", "''") & "')"
                                cmd.ExecuteNonQuery()
                                cmd.CommandText = "insert into " & currentTable & " ([" & currentColumn & "]) values ('" & txtbx_CharAfter3.Text & "')"
                                cmd.ExecuteNonQuery()
                                cmd.CommandText = "insert into " & currentTable & " ([" & currentColumn & "]) values ('" & txtbx_Item3.Text & "')"
                                cmd.ExecuteNonQuery()
                                cmd.CommandText = "insert into " & currentTable & " ([Datestamp], [" & currentColumn & "]) values ('" & Now.ToString("g") & "', '" & cItems(txtbx_Item3.Text) & "')"
                                cmd.ExecuteNonQuery()
                                myConnection.Close()
                                'MsgBox(ex.Message)
                            End Try
                        End Using

                    Catch ex As Exception
                        'MsgBox(ex.Message)
                    End Try
                    myConnection.Close()
                Else

                    MsgBox("Please Enter Item Number")
                End If
            Else

                MsgBox("Please Fill Out Before And After For C")
            End If
            Else
                MsgBox("Please Enter A Name")
            End If

            txtbx_Name.Select()


    End Sub

    Private Sub btn_Add4_Click(sender As Object, e As EventArgs) Handles btn_Add4.Click
        If (txtbx_Name.Text <> "") Then
            If (txtbx_Before4.Text <> "" And txtbx_After4.Text <> "") Then
                If (txtbx_Item4.Text <> "") Then
                    Try
                        Dim currentTable As String = txtbx_Name.Text
                        Dim currentColumn As String = "D"
                        myConnection.ConnectionString = connString
                        myConnection.Open()
                        Using cmd As New OleDbCommand()
                            cmd.Connection = myConnection
                            Try
                                cmd.CommandText = "CREATE TABLE " & currentTable & " (ID COUNTER)"
                                cmd.ExecuteNonQuery()
                                cmd.CommandText = "ALTER TABLE " & currentTable & " ADD COLUMN Datestamp DATETIME"
                                cmd.ExecuteNonQuery()
                                cmd.CommandText = "ALTER TABLE " & currentTable & " ADD COLUMN D TEXT(200)"
                                cmd.ExecuteNonQuery()
                                cmd.CommandText = "insert into " & currentTable & " ([" & currentColumn & "]) values ('" & txtbx_URL.Text & "')"
                                cmd.ExecuteNonQuery()
                                cmd.CommandText = "insert into " & currentTable & " ([" & currentColumn & "]) values ('" & txtbx_Before4.Text.Replace("'", "''") & "')"
                                cmd.ExecuteNonQuery()
                                cmd.CommandText = "insert into " & currentTable & " ([" & currentColumn & "]) values ('" & txtbx_CharBefore4.Text & "')"
                                cmd.ExecuteNonQuery()
                                cmd.CommandText = "insert into " & currentTable & " ([" & currentColumn & "]) values ('" & txtbx_After4.Text.Replace("'", "''") & "')"
                                cmd.ExecuteNonQuery()
                                cmd.CommandText = "insert into " & currentTable & " ([" & currentColumn & "]) values ('" & txtbx_CharAfter4.Text & "')"
                                cmd.ExecuteNonQuery()
                                cmd.CommandText = "insert into " & currentTable & " ([" & currentColumn & "]) values ('" & txtbx_Item4.Text & "')"
                                cmd.ExecuteNonQuery()
                                cmd.CommandText = "insert into " & currentTable & " ([Datestamp], [" & currentColumn & "]) values ('" & Now.ToString("g") & "', '" & dItems(txtbx_Item4.Text) & "')"
                                cmd.ExecuteNonQuery()
                                myConnection.Close()
                            Catch ex As Exception
                                cmd.CommandText = "ALTER TABLE " & currentTable & " ADD COLUMN " & currentColumn & " TEXT(200)"
                                cmd.ExecuteNonQuery()
                                cmd.CommandText = "insert into " & currentTable & " ([" & currentColumn & "]) values ('" & txtbx_URL.Text & "')"
                                cmd.ExecuteNonQuery()
                                cmd.CommandText = "insert into " & currentTable & " ([" & currentColumn & "]) values ('" & txtbx_Before4.Text.Replace("'", "''") & "')"
                                cmd.ExecuteNonQuery()
                                cmd.CommandText = "insert into " & currentTable & " ([" & currentColumn & "]) values ('" & txtbx_CharBefore4.Text & "')"
                                cmd.ExecuteNonQuery()
                                cmd.CommandText = "insert into " & currentTable & " ([" & currentColumn & "]) values ('" & txtbx_After4.Text.Replace("'", "''") & "')"
                                cmd.ExecuteNonQuery()
                                cmd.CommandText = "insert into " & currentTable & " ([" & currentColumn & "]) values ('" & txtbx_CharAfter4.Text & "')"
                                cmd.ExecuteNonQuery()
                                cmd.CommandText = "insert into " & currentTable & " ([" & currentColumn & "]) values ('" & txtbx_Item4.Text & "')"
                                cmd.ExecuteNonQuery()
                                cmd.CommandText = "insert into " & currentTable & " ([Datestamp], [" & currentColumn & "]) values ('" & Now.ToString("g") & "', '" & dItems(txtbx_Item4.Text) & "')"
                                cmd.ExecuteNonQuery()

                                'MsgBox(ex.Message)
                            End Try
                        End Using

                    Catch ex As Exception
                        'MsgBox(ex.Message)
                    End Try
                    ' Else
                    ' MsgBox("Please List Name")
                    'End If
                    myConnection.Close()
                Else

                    MsgBox("Please Enter Item Number")
                End If
            Else

                MsgBox("Please Fill Out Before And After For D")
            End If
            Else
                MsgBox("Please Enter A Name")
            End If
            txtbx_Name.Select()


    End Sub

    Private Sub btn_Add5_Click(sender As Object, e As EventArgs) Handles btn_Add5.Click
        If (txtbx_Name.Text <> "") Then
            If (txtbx_Before5.Text <> "" And txtbx_After5.Text <> "") Then
                If (txtbx_Item5.Text <> "") Then
                    Try
                        Dim currentTable As String = txtbx_Name.Text
                        Dim currentColumn As String = "E"
                        myConnection.ConnectionString = connString
                        myConnection.Open()
                        Using cmd As New OleDbCommand()
                            cmd.Connection = myConnection
                            Try
                                cmd.CommandText = "CREATE TABLE " & currentTable & " (ID COUNTER)"
                                cmd.ExecuteNonQuery()
                                cmd.CommandText = "ALTER TABLE " & currentTable & " ADD COLUMN Datestamp DATETIME"
                                cmd.ExecuteNonQuery()
                                cmd.CommandText = "ALTER TABLE " & currentTable & " ADD COLUMN E TEXT(200)"
                                cmd.ExecuteNonQuery()
                                cmd.CommandText = "insert into " & currentTable & " ([" & currentColumn & "]) values ('" & txtbx_URL.Text & "')"
                                cmd.ExecuteNonQuery()
                                cmd.CommandText = "insert into " & currentTable & " ([" & currentColumn & "]) values ('" & txtbx_Before5.Text.Replace("'", "''") & "')"
                                cmd.ExecuteNonQuery()
                                cmd.CommandText = "insert into " & currentTable & " ([" & currentColumn & "]) values ('" & txtbx_CharBefore5.Text & "')"
                                cmd.ExecuteNonQuery()
                                cmd.CommandText = "insert into " & currentTable & " ([" & currentColumn & "]) values ('" & txtbx_After5.Text.Replace("'", "''") & "')"
                                cmd.ExecuteNonQuery()
                                cmd.CommandText = "insert into " & currentTable & " ([" & currentColumn & "]) values ('" & txtbx_CharAfter5.Text & "')"
                                cmd.ExecuteNonQuery()
                                cmd.CommandText = "insert into " & currentTable & " ([" & currentColumn & "]) values ('" & txtbx_Item5.Text & "')"
                                cmd.ExecuteNonQuery()
                                cmd.CommandText = "insert into " & currentTable & " ([Datestamp], [" & currentColumn & "]) values ('" & Now.ToString("g") & "', '" & eItems(txtbx_Item5.Text) & "')"
                                cmd.ExecuteNonQuery()
                                myConnection.Close()
                            Catch ex As Exception
                                cmd.CommandText = "ALTER TABLE " & currentTable & " ADD COLUMN " & currentColumn & " TEXT(200)"
                                cmd.ExecuteNonQuery()
                                cmd.CommandText = "insert into " & currentTable & " ([" & currentColumn & "]) values ('" & txtbx_URL.Text & "')"
                                cmd.ExecuteNonQuery()
                                cmd.CommandText = "insert into " & currentTable & " ([" & currentColumn & "]) values ('" & txtbx_Before5.Text.Replace("'", "''") & "')"
                                cmd.ExecuteNonQuery()
                                cmd.CommandText = "insert into " & currentTable & " ([" & currentColumn & "]) values ('" & txtbx_CharBefore5.Text & "')"
                                cmd.ExecuteNonQuery()
                                cmd.CommandText = "insert into " & currentTable & " ([" & currentColumn & "]) values ('" & txtbx_After5.Text.Replace("'", "''") & "')"
                                cmd.ExecuteNonQuery()
                                cmd.CommandText = "insert into " & currentTable & " ([" & currentColumn & "]) values ('" & txtbx_CharAfter5.Text & "')"
                                cmd.ExecuteNonQuery()
                                cmd.CommandText = "insert into " & currentTable & " ([" & currentColumn & "]) values ('" & txtbx_Item5.Text & "')"
                                cmd.ExecuteNonQuery()
                                cmd.CommandText = "insert into " & currentTable & " ([Datestamp], [" & currentColumn & "]) values ('" & Now.ToString("g") & "', '" & eItems(txtbx_Item5.Text) & "')"
                                cmd.ExecuteNonQuery()
                                myConnection.Close()
                                'MsgBox(ex.Message)
                            End Try
                        End Using

                    Catch ex As Exception
                        ' MsgBox(ex.Message)
                    End Try
                    myConnection.Close()
                Else

                    MsgBox("Please Enter Item Number")
                End If

            Else

                MsgBox("Please Fill Out Before And After For E")
            End If


            Else
                MsgBox("Please Enter A Name")
            End If
            txtbx_Name.Select()


    End Sub

    Private Sub btn_Scrapes_Click(sender As Object, e As EventArgs) Handles btn_Scrapes.Click
        Scrapes.Show()
        Me.Hide()
        txtbx_Name.Select()

    End Sub

#End Region

    Private Sub StartStop()
        ' ServiceController1
        Try


            If ScrapeServiceController.Status = ServiceProcess.ServiceControllerStatus.Stopped Then
                ScrapeServiceController.Start()
                Console.WriteLine("Starting Service")

                tmr_ServiceDelay.Enabled = True
                btn_StartService.Text = "Stop Service"
                'lbl_MetroServiceStatus.Text = "   Running"
            Else
                ScrapeServiceController.Stop()
                Console.WriteLine("Stopping Service")

                tmr_ServiceDelay.Enabled = True
                btn_StartService.Text = "Start Service"
                'lbl_MetroServiceStatus.Text = "Not Running"
            End If

            ' NotifyIcon1.Text = "Service Status: " & ServiceController1.Status.ToString
        Catch ex As Exception

            MsgBox("You Must Run As Administrator To Start Or Stop The Service From Here")

        End Try
    End Sub

    Private Sub checkServiceStatus()
        If (ScrapeServiceController.Status = ServiceProcess.ServiceControllerStatus.Running) Then
            ' NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
            Debug.WriteLine("Service Status: " & ScrapeServiceController.Status.ToString)
            ' NotifyIcon1.ShowBalloonTip(500)
            btn_StartService.Text = "Stop Service"
            lbl_ServiceStatus.Text = "   Running"
        Else
            ' NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
            Debug.WriteLine("Service Status: " & ScrapeServiceController.Status.ToString)
            btn_StartService.Text = "Start Service"
            lbl_ServiceStatus.Text = "Not Running"
        End If
    End Sub
  
    Private Sub btn_StartService_Click(sender As Object, e As EventArgs) Handles btn_StartService.Click
        StartStop()
        txtbx_Name.Select()
    End Sub

    Private Sub tmr_ServiceDelay_Tick(sender As Object, e As EventArgs) Handles tmr_ServiceDelay.Tick

        tmr_ServiceDelay.Enabled = False
        ScrapeServiceController.Refresh()

        Console.WriteLine("Service Status: " & ScrapeServiceController.Status.ToString)
        lbl_ServiceStatus.Text = ScrapeServiceController.Status.ToString

    End Sub
End Class
