Public Class AddBook

    Private Sub AddBook_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = Mainform.Panel1.Width

        Me.Width = Mainform.Width - Mainform.Panel1.Width
        Me.Height = Mainform.Height

        Panel1.Left = (Me.Width - Panel1.Width) / 2
        Panel1.Top = (Me.Height - Panel1.Height) / 2


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
    Private Sub Emptyfields()
        txtBname.Clear()
        'txtBpublication.Clear()
        txtBqty.Clear()
        txtBprice.Clear()

    End Sub
    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        If txtBname.Text <> "" And txtBqty.Text <> "" And txtBprice.Text <> "" Then
            Module1.insert_update("insert into Course values('" & txtBname.Text & " ' , ' " & txtBqty.Text & " ' , ' " & txtBprice.Text & " ' )")
            MsgBox(" Cousrse Added", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Cousre Added")
        Else
            MsgBox("Fields Should Not Be Empty")
        End If
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class