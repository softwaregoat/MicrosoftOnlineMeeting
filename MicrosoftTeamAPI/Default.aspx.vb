Imports System.Net.Http
Imports System.Threading.Tasks
Imports Microsoft.Graph
Imports Microsoft.Graph.Auth
Imports Microsoft.Identity.Client
Imports Newtonsoft.Json
Public Class _Default
    Inherits Page
    Dim meeting As MicrosoftOnlineMeeting

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        meeting = New MicrosoftOnlineMeeting
    End Sub

    Protected Function createMeeting_Click(sender As Object, e As EventArgs)
        meeting.createMeeting().Wait()
    End Function
    Protected Sub updateMeeting_Click(sender As Object, e As EventArgs)

    End Sub
    Protected Function getMeetingInfo_Click(sender As Object, e As EventArgs)

        Dim meeting_id = "123456789"
        meeting.getMeetingInfo(meeting_id).Wait()

    End Function
    Protected Sub addAttender_Click(sender As Object, e As EventArgs)

    End Sub
End Class