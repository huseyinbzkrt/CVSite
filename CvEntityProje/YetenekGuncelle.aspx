﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="YetenekGuncelle.aspx.cs" Inherits="CvEntityProje.WebForm5" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h4> YETENEK GÜNCELLEME SAYFASI</h4>
    <br />
    <%--asp:Label ID="Label1" runat="server" Text="Yetenek Açıklama "></asp:Label>--%>
    <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control pla" placeholder="Yetenek"></asp:TextBox>

    <br />
    <asp:Button ID="Button1" runat="server" Text="Kaydet" CssClass="btn btn-group" OnClick="Button1_Click"  />


</asp:Content>
