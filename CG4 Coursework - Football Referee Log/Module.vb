Module ModuleVariables

    'Declare record
    Public Structure RefereeDetails
        Public FANID As Integer
        Public Name As String
        Public DateofBirth As Date
        Public Gender As Char
        Public Address As String
        Public TelephoneNo As String
        Public MobileNo As String
        Public EmailAddress As String
        Public AffiliationNo As String
        Public CountyFA As String
        Public PromotionReq As Boolean
        Public CurrentLevel As Integer
    End Structure
    'set array structure
    Public PersonalDetails(1) As RefereeDetails


    'Declare record
    Public Structure GameDetails
        Public MatchID As Integer
        Public DateofMatch As Date
        Public Competition As String
        Public HomeTeam As String
        Public AwayTeam As String
        Public HomeScore As Integer
        Public AwayScore As Integer
        Public Surname1, Surname2, Surname3, Surname4, Surname5 As String
        Public Forename1, Forename2, Forename3, Forename4, Forename5 As String
        Public Club1, Club2, Club3, Club4, Club5 As String
        Public CautionSendoff1, CautionSendoff2, CautionSendoff3, CautionSendoff4, CautionSendoff5 As String
        Public Code1, Code2, Code3, Code4, Code5 As String
        Public FACode1, FACode2, FACode3, FACode4, FACode5 As String
        Public Time1, Time2, Time3, Time4, Time5 As String
        Public Referee As String
        Public AssistantReferee1 As String
        Public AssistantReferee2 As String
        Public FourthOfficial As String
        Public Notes As String
    End Structure
    'set array structure
    Public MatchDetails(1000) As GameDetails


    'Declare record
    Public Structure ReportDetails
        Public ReportID As Integer
        Public DateofReport As Date
        Public Competition As String
        Public HomeTeam As String
        Public AwayTeam As String
        Public PlayedAt As String
        Public ReportThat As String
        Public TypeOfOffence As String
        Public Name As String
        Public Club As String
        Public Law12Section As String
        Public AssistantReferees As String
        Public Incident As String
    End Structure
    'set array structure
    Public Report(1000) As ReportDetails


    'Declare record
    Public Structure ExpenseDetails
        Public ExpenseID As Integer
        Public Title As String
        Public Description As String
        Public Amount As Decimal
        Public DateOfExpense As Date
    End Structure
    'set array structure
    Public Expense(1000) As ExpenseDetails


    'Declare record
    Public Structure ContactDetails
        Public ContactID As Integer
        Public Name As String
        Public Position As String
        Public Association As String
        Public Email As String
        Public TelephoneNo As String
        Public MobileNo As String
    End Structure
    'set array structure
    Public Contact(1000) As ContactDetails

End Module
