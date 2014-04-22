Imports Word = Microsoft.Office.Interop.Word
Imports System.IO

Public Class Form1

    Dim FIRST_NOTICE_PATH As String
    Dim FINAL_NOTICE_PATH As String
    Dim ENVELOPE_PATH As String
    Dim CONSTABLE_FOLDER As String
    Dim WorkingFolder As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim filePaths As ArrayList = New ArrayList
        Dim runningDir As String = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase)
        runningDir = runningDir.Substring(6) + "\ConfigFile.txt"


        Try

            Dim sr As New StreamReader(runningDir)

            Do While sr.Peek() >= 0
                filePaths.Add(sr.ReadLine.ToString)
            Loop

            sr.Close()

        Catch ex As Exception
            Console.WriteLine("The file could not be read")
            Console.WriteLine(ex.StackTrace)
        End Try

        If filePaths.Count > 0 Then
            FIRST_NOTICE_PATH = filePaths.Item(0).ToString
            FINAL_NOTICE_PATH = filePaths.Item(1).ToString
            ENVELOPE_PATH = filePaths.Item(2).ToString
            CONSTABLE_FOLDER = filePaths.Item(3).ToString

        End If

    End Sub

    Private Sub btn_Create_Click(sender As Object, e As EventArgs) Handles btn_Create.Click

        Dim fName, lName, bName, wNumber As String

        fName = txt_fName.Text
        lName = txt_lName.Text
        bName = txt_businessName.Text
        wNumber = txt_WarrantNumber.Text

        Dim cBoxFirstN As CheckBox = chk_FirstNotice
        Dim cBoxFinalN As CheckBox = chk_FinalNotice
        Dim cBoxEnvelope As CheckBox = chk_Envelope

        If cBoxFirstN.Checked Then

            If checkFolder(bName, fName, lName, wNumber) Then
                editFile(bName, fName, lName, FIRST_NOTICE_PATH, "First Notice")
            End If

        End If

        If cBoxFinalN.Checked Then

            If checkFolder(bName, fName, lName, wNumber) Then
                editFile(bName, fName, lName, FINAL_NOTICE_PATH, "Final Notice")
           End If

        End If

        If cBoxEnvelope.Checked Then
            If checkFolder(bName, fName, lName, wNumber) Then
                editEnvelope(bName, fName, lName, ENVELOPE_PATH)
            End If

        End If

    End Sub

    Function checkFolder(ByVal bName As String, ByVal fName As String, ByVal lName As String, wNum As String)

        Dim folderName As String = Nothing

        If bName <> "" Then
            folderName = bName + " " + wNum
        ElseIf fName <> "" And lName <> "" Then
            folderName = lName + ", " + fName + " " + wNum
        End If

        If folderName <> Nothing Then
            If File.Exists(CONSTABLE_FOLDER + folderName) Then
                WorkingFolder = CONSTABLE_FOLDER + folderName
                Return True
                Exit Function
            Else
                Directory.CreateDirectory(CONSTABLE_FOLDER + folderName)
                WorkingFolder = CONSTABLE_FOLDER + folderName
                Return True
                Exit Function
            End If
        End If

        Return False

    End Function

    Sub editFile(ByVal bName As String, ByVal fName As String, ByVal lName As String, ByVal noticePath As String, ByVal saveNoticeType As String)

        Dim address, city, state, warrantNo, zip As String
        Dim warrantAmount As Decimal
        Dim sDate, wDate As Date

        sDate = dtp_date.Value
        sDate = sDate.ToShortDateString
        wDate = dtp_warrantEnd.Value
        wDate = wDate.ToShortDateString

        address = txt_streetAddress.Text
        city = txt_City.Text
        state = txt_state.Text
        warrantNo = txt_WarrantNumber.Text
        zip = txt_zip.Text
        warrantAmount = txt_warrantAmount.Text

        Dim name As String = fName + " " + lName
        Dim fullAddress As String = address + vbCrLf + city + " " + state + " " + zip

        Dim cFee As Decimal = warrantAmount * 0.15
        Dim aFee As Decimal = 25.0
        Dim wTotal As Decimal = warrantAmount + cFee + aFee

        Dim oWord As Word.Application = Nothing
        Dim oDoc As Word.Document = Nothing

        Try
            oWord = CreateObject("Word.Application")
            oDoc = oWord.Documents.Open(noticePath)

            Try

                oWord.Visible = False

                oDoc.Bookmarks.Item("Address").Range.Text = fullAddress
                oDoc.Bookmarks.Item("BodyTotal").Range.Text = String.Format(FormatCurrency(wTotal, 2))
                oDoc.Bookmarks.Item("Date").Range.Text = sDate
                oDoc.Bookmarks.Item("PersonName").Range.Text = name
                oDoc.Bookmarks.Item("BusinessName").Range.Text = bName
                oDoc.Bookmarks.Item("WarrantNumber").Range.Text = warrantNo


                oDoc.Bookmarks.Item("WarrantEnd").Range.Text = wDate.ToString("MMMM yyyy")
                oDoc.Bookmarks.Item("BlockWarrantAmount").Range.Text = String.Format(FormatCurrency(warrantAmount, 2))
                oDoc.Bookmarks.Item("BlockConstableFee").Range.Text = String.Format(FormatCurrency(cFee, 2))
                oDoc.Bookmarks.Item("BlockAdminFee").Range.Text = String.Format(FormatCurrency(aFee, 2))
                oDoc.Bookmarks.Item("BlockTotal").Range.Text = String.Format(FormatCurrency(wTotal, 2))

                Dim fileName As String = sDate.ToString("yyyy.MM.dd") + " " + saveNoticeType + ".docx"

                oDoc.SaveAs(WorkingFolder + "\" + fileName)
                oDoc.PrintOut()
                oDoc.Close()
                oWord.Quit()

            Catch e As Exception

                oDoc.Close()
                oWord.Quit()
                MessageBox.Show(e.StackTrace, "Error", MessageBoxButtons.OK)

            End Try

        Catch e As Exception
            MessageBox.Show(e.StackTrace, "Error", MessageBoxButtons.OK)
        End Try

    End Sub

    Sub editEnvelope(ByVal bName As String, ByVal fName As String, ByVal lName As String, ByVal envelopePath As String)
        Dim address, city, state, zip As String
        Dim sDate As Date

        sDate = dtp_date.Value
        sDate = sDate.ToShortDateString

        address = txt_streetAddress.Text
        city = txt_City.Text
        state = txt_state.Text
        zip = txt_zip.Text

        Dim name As String = fName + " " + lName
        Dim fullAddress As String = address + vbCrLf + city + " " + state + " " + zip

        Dim oWord As Word.Application = Nothing
        Dim oDoc As Word.Document = Nothing

        Try
            oWord = CreateObject("Word.Application")
            oDoc = oWord.Documents.Open(envelopePath)
            oWord.Visible = False

            Try
                oDoc.Bookmarks.Item("Address").Range.Text = fullAddress
                oDoc.Bookmarks.Item("Name").Range.Text = name
                oDoc.Bookmarks.Item("BusinessName").Range.Text = bName
                Dim fileName As String = sDate.ToString("yyyy.MM.dd") + " Envelope.docx"
                oDoc.SaveAs(WorkingFolder + "\" + fileName)
                oDoc.Close()

                oDoc = oWord.Documents.Open(WorkingFolder + "\" + fileName)
                oWord.Visible = True


            Catch e As Exception
                oDoc.Close()
                oWord.Quit()
                MessageBox.Show(e.StackTrace, "Error", MessageBoxButtons.OK)

            End Try
        Catch e As Exception
            MessageBox.Show(e.StackTrace, "Error", MessageBoxButtons.OK)
        End Try

    End Sub
End Class
