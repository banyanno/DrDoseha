Imports CRAXDDRT

Module CrystalReportKhmerGenerator
    Public Sub GenerateReportKhmer(ByVal Sql As String, ByVal CrvPath As String)

        Try
            Dim crxReport As New CRAXDDRT.Report
            Dim crxApp As New CRAXDDRT.Application
            crxReport = crxApp.OpenReport(CrvPath)
            SetDBLogonForReport(crxReport)
            crxReport.SQLQueryString = Sql

            Dim fReport As New FMCrystalViewerKhmer
            fReport.AxCrystalActiveXReportViewer1.Refresh()
            fReport.AxCrystalActiveXReportViewer1.ReportSource = crxReport
            'crxReport.pri
            fReport.AxCrystalActiveXReportViewer1.ViewReport()
            fReport.ShowDialog()
            crxReport.DiscardSavedData()
            fReport.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Public Sub GenerateSubReport(ByVal MainReport As CRAXDDRT.Report, ByVal SQL As String)
        Dim subReport As CRAXDDRT.SubreportObject
        For Each sectiont As CRAXDDRT.Section In MainReport.Sections
            For Each Item As Object In sectiont.ReportObjects
                subReport = CType(Item, CRAXDDRT.SubreportObject)
                If subReport Is Nothing Then
                Else
                    SetDBLogonForReport(crxReport)

                End If
            Next
        Next
    End Sub
    Private Sub SetDBLogonForReport(ByVal a As CRAXDDRT.Report)
        Dim crxDatabaseTables As DatabaseTables = a.Database.Tables
        For Each tbl As DatabaseTable In crxDatabaseTables
            tbl.SetLogOnInfo(My.Settings.ServerName, My.Settings.DatabaseName, My.Settings.UserName, My.Settings.Password)
        Next
    End Sub
End Module