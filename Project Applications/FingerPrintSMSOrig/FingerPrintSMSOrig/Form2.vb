Public Class Form2

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not ((Asc(e.KeyChar) >= Keys.NumPad0 - 48) And (Asc(e.KeyChar) <= Keys.NumPad9 - 48)) Or _
           e.KeyChar = Chr(Keys.Delete) Or e.KeyChar = Chr(Keys.Back) Then

            Beep()
            MsgBox("Invalid character pressed " & e.KeyChar & "Key not allowed" & vbCrLf & "Ascii Value= " & Asc(e.KeyChar))
            e.KeyChar = Chr(Keys.None)
        Else
            'Beep()
            'MsgBox("Invalid character pressed " & e.KeyChar & "Key not allowed" & vbCrLf & "Ascii Value= " & Asc(e.KeyChar))
            'e.KeyChar = Chr(Keys.None)
        End If


    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If ((Asc(e.KeyChar) >= Keys.NumPad0 - 48) And (Asc(e.KeyChar) <= Keys.NumPad9 - 48)) Then

            Beep()
            MsgBox("Invalid character pressed " & e.KeyChar & "Key not allowed" & vbCrLf & "Ascii Value= " & Asc(e.KeyChar))
            e.KeyChar = Chr(Keys.None)
        End If


    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class