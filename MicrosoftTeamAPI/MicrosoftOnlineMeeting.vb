Imports System.Threading.Tasks
Imports Microsoft.Graph
Imports Microsoft.Graph.Auth
Imports Microsoft.Identity.Client

Public Class MicrosoftOnlineMeeting
    Private Const client_id As String = "537471fc-995f-47d0-a126-95d22fefbfbf"
    Private Const tenant_id As String = "5a3aeb7f-e50b-4f85-b481-550e68a7c9ad"
    Private Const client_secret As String = "j-h/[6n7mL05K@YMY7__vxOZrI22=.IQ"

    Private Const redirectUri As String = "https://localhost"
    Dim graphScopes As String() = {"https://graph.microsoft.com/.default"}

    Dim graphClient As GraphServiceClient
    Public Sub New()
        'Dim ConfidentialClientApplication As IConfidentialClientApplication = ConfidentialClientApplicationBuilder.
        '    Create(client_id).
        '    WithTenantId(tenant_id).
        '    WithClientSecret(client_secret).
        '    Build()
        'Dim authProvider As ClientCredentialProvider = New ClientCredentialProvider(ConfidentialClientApplication)

        'Dim confidentialClientApplication As IConfidentialClientApplication = ConfidentialClientApplicationBuilder.
        '    Create(client_id).
        '    WithRedirectUri(redirectUri).
        '    WithClientSecret(client_secret).Build()
        'Dim authProvider As AuthorizationCodeProvider = New AuthorizationCodeProvider(confidentialClientApplication, graphScopes)

        Dim confidentialClientApplication As IConfidentialClientApplication = ConfidentialClientApplicationBuilder.
            Create(client_id).
            WithRedirectUri(redirectUri).
            WithClientSecret(client_secret).Build()

        Dim authProvider = New AuthorizationCodeProvider(confidentialClientApplication, graphScopes)

        'Dim authProvider As OnBehalfOfProvider = New OnBehalfOfProvider(confidentialClientApplication, graphScopes)

        graphClient = New GraphServiceClient(authProvider)
    End Sub
    Public Async Function createMeeting() As Threading.Tasks.Task

        Dim onlineMeeting = New OnlineMeeting With {
            .StartDateTime = DateTimeOffset.Parse("2020-07-12T21:30:34.2444915+00:00"),
            .EndDateTime = DateTimeOffset.Parse("2020-07-12T22:00:34.2464912+00:00"),
            .Subject = "User Token Meeting"
        }

        Await graphClient.Communications.OnlineMeetings.Request().AddAsync(onlineMeeting)

    End Function
    Public Sub updateMeeting_Click(sender As Object, e As EventArgs)

    End Sub
    Public Async Function getMeetingInfo(meeting_id As String) As Task

        Dim onlineMeeting = Await graphClient.Communications.OnlineMeetings.
            Request().
            Filter("VideoTeleconferenceId eq '" & meeting_id & "'").
            GetAsync()

    End Function
    Protected Sub addAttender_Click(sender As Object, e As EventArgs)

    End Sub

End Class
