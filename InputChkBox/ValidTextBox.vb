Public Enum dataTypeList
    [Integer]
    Numeric
End Enum

Public Class ValidTextBox
    Inherits System.Windows.Controls.TextBox

    Private _dataType As dataTypeList
    Public Sub InputChkBox_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Select Case _dataType
            Case _dataType.Integer
                Dim input As Integer
                If Not Integer.TryParse(DirectCast(sender, TextBox).Text, input) Then
                    MsgBox("Integer value is required in this field!")
                    DirectCast(sender, TextBox).Undo()
                End If
            Case _dataType.Numeric
                Dim input As Double
                If Not Double.TryParse(DirectCast(sender, TextBox).Text, input) Then
                    MsgBox("Numeric value is required in this field!")
                    DirectCast(sender, TextBox).Undo()
                End If
        End Select
    End Sub
    Public Property DataType() As dataTypeList
        Get
            Return _dataType
        End Get
        Set(value As dataTypeList)
            _dataType = value
        End Set
    End Property
End Class
