Public Class Profit_Contribution

    'PC: several Public Property variables holding the attributes from the dataset
    Public Property name As String
    Public Property value As Short
    Public Property unitOfMeasurement As String

    'PC: creates a list of Profit_Contribution objects for the user
    'PC: ProfitCont is short for "profit contribution"
    Public Shared Property ProfitContList As New List(Of Profit_Contribution)
    Public Sub New()
            'PC: constrctor for the Profit_Contribution class
        End Sub
End Class
