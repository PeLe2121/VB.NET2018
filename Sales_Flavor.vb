Public Class Sales_Flavor

    'PC: several Public Property variables holding the attributes from the dataset
    Public Property name As String
    Public Property value As Short
    Public Property unitOfMeasurement As String

    'PC: creates a list of DiscountCondition objects for the user
    Public Shared Property Sales_FlavorList As New List(Of Sales_Flavor)
    Public Sub New()
        'PC: constrctor for the Sales_Flavor class
    End Sub
End Class
