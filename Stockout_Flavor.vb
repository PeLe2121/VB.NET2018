Public Class Stockout_Flavor

    'PC: several Public Property variables holding the attributes from the dataset
    Public Property name As String
    Public Property value As Short
    Public Property unitOfMeasurement As String

    'PC: creates a list of Stockout flavor objects for the user
    Public Shared Property Stockout_FlavorList As New List(Of Stockout_Flavor)
    Public Sub New()
        'PC: constrctor for the Stockout_Flavor class
    End Sub

End Class
