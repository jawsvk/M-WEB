Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class Customer
    <StringLength(4)>
    Public Property CustomerID As String

    <StringLength(50)>
    Public Property CustomerName As String

    <StringLength(2)>
    Public Property MemberCategory As String

    Public Property Age As Integer?

    Public Property AmountSpent As Decimal?

    <StringLength(65)>
    Public Property Address As String

    <StringLength(30)>
    Public Property City As String

    <StringLength(4)>
    Public Property OldPostalCode As String

    <StringLength(6)>
    Public Property PostalCode As String

    <StringLength(3)>
    Public Property CountryCode As String

    <StringLength(2)>
    Public Property ContactTitle As String

    <StringLength(9)>
    Public Property PhoneNumber As String

    <StringLength(5)>
    Public Property Extension As String

    <StringLength(30)>
    Public Property FaxNumber As String

    <StringLength(50)>
    Public Property EmailAddress As String

    <StringLength(255)>
    Public Property Notes As String
End Class
