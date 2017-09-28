<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FMCrystalViewerKhmer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FMCrystalViewerKhmer))
        Me.AxCrystalActiveXReportViewer1 = New AxCrystalActiveXReportViewerLib105.AxCrystalActiveXReportViewer
        CType(Me.AxCrystalActiveXReportViewer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxCrystalActiveXReportViewer1
        '
        Me.AxCrystalActiveXReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AxCrystalActiveXReportViewer1.Enabled = True
        Me.AxCrystalActiveXReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.AxCrystalActiveXReportViewer1.Name = "AxCrystalActiveXReportViewer1"
        Me.AxCrystalActiveXReportViewer1.OcxState = CType(resources.GetObject("AxCrystalActiveXReportViewer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxCrystalActiveXReportViewer1.Size = New System.Drawing.Size(1049, 483)
        Me.AxCrystalActiveXReportViewer1.TabIndex = 0
        '
        'FMCrystalViewerKhmer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1049, 483)
        Me.Controls.Add(Me.AxCrystalActiveXReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FMCrystalViewerKhmer"
        Me.Text = "Report Viewer"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.AxCrystalActiveXReportViewer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AxCrystalActiveXReportViewer1 As AxCrystalActiveXReportViewerLib105.AxCrystalActiveXReportViewer
End Class
