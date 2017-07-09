Public Class frmDigitalDownloads
    Const cdecPricePerDownload As Decimal = 0.99D
    Private Sub picHeadphones_Click(sender As Object, e As EventArgs) Handles picHeadphones.Click

    End Sub

    Private Sub txtNumberOfSongDownloads_TextChanged(sender As Object, e As EventArgs) Handles txtNumberOfSongDownloads.TextChanged

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'clear the text box
        txtNumberOfSongDownloads.Text = ""
        'clear the download/cost label
        lblTotalCost.Text = ""
        'set the focus on the text box
        txtNumberOfSongDownloads.Focus()
    End Sub

    Private Sub btnCalculateCost_Click(sender As Object, e As EventArgs) Handles btnCalculateCost.Click
        'collect number of downloads
        Dim strNumberOfDownloads As String = txtNumberOfSongDownloads.Text
        Dim intNumberOfDownloads As Integer = Convert.ToInt32(strNumberOfDownloads)
        'total cost = number of downloads * download price
        Dim decTotalCost As Decimal
        decTotalCost = intNumberOfDownloads * cdecPricePerDownload
        'display total cost in label
        lblTotalCost.Text = decTotalCost.ToString("C")
    End Sub

    Private Sub frmDigitalDownloads_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'empty the Total Cost label
        lblTotalCost.Text = ""
        'set the price per download label
        'set the focus
        txtNumberOfSongDownloads.Focus()
        'add price for cost of downloads
        lbl99CentPerDownload.Text = cdecPricePerDownload.ToString("C") & " per download"
    End Sub
End Class
