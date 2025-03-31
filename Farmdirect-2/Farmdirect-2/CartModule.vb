Module CartModule
    Public Cart As New List(Of CartItem)
End Module

Public Class CartItem
    Public Property ProductID As Integer
    Public Property ProductName As String
    Public Property Price As Decimal
    Public Property Quantity As Integer
End Class
