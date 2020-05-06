<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="MicrosoftTeamAPI._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>ASP.NET</h1>
        <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS and JavaScript.</p>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
    </div>

    <div class="row jumbotron">
        <h2>Create Microsoft teams meeting</h2>
        <p>
            <input id="meetingId" type="text" runat="server"/>
        </p>
        <p>
            <asp:HyperLink  class="btn btn-default" ID="meetingJoinUrl" runat="server">Join Here</asp:HyperLink>
        </p>
        <p>
            <asp:Button ID="createMeeting" class="btn btn-default" runat="server" Text="Create Meeting" OnClick="createMeeting_Click" />
        </p>
    </div>
    <div class="row jumbotron">
        <h2>Get Microsoft teams info</h2>
        <p id="meetingInfo" runat="server">
            Meeting Information
        </p>
        <p>
            <asp:Button ID="getMeetingInfo" class="btn btn-default" runat="server" Text="Get Meeting info" OnClick="getMeetingInfo_Click" />
        </p>
    </div>
    <div class="row jumbotron">
        <h2>Update Microsoft teams meeting</h2>
        <p>
            <input id="topic" type="text" placeholder="topic" runat="server"/>
            <input id="start_time" type="text" placeholder="2019-08-30T18:00:00" runat="server"/>
            <input id="duration" type="text" placeholder="50" runat="server"/>
            <input id="agenda" type="text" placeholder="agenda" runat="server"/>
        </p>
        <p id="updateResult" runat="server">

        </p>
        <p>
            <asp:Button ID="updateMeeting" class="btn btn-default" runat="server" Text="Update Meeting" OnClick="updateMeeting_Click" />
        </p>
        <p>
            <asp:Button ID="addAttend" class="btn btn-default" runat="server" Text="Add Attender" OnClick="addAttender_Click" />
        </p>
    </div>

</asp:Content>
