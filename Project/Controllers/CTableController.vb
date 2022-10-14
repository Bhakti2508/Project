Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports Project

Namespace Controllers
    Public Class CTableController
        Inherits System.Web.Mvc.Controller

        Private db As New DbMVCEntities

        ' GET: CTable
        Function Index() As ActionResult
            Return View(db.Tables.ToList())
        End Function

        ' GET: CTable/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim table As Table = db.Tables.Find(id)
            If IsNothing(table) Then
                Return HttpNotFound()
            End If
            Return View(table)
        End Function

        ' GET: CTable/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: CTable/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="C_Id,C_Name")> ByVal table As Table) As ActionResult
            If ModelState.IsValid Then
                db.Tables.Add(table)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(table)
        End Function

        ' GET: CTable/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim table As Table = db.Tables.Find(id)
            If IsNothing(table) Then
                Return HttpNotFound()
            End If
            Return View(table)
        End Function

        ' POST: CTable/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="C_Id,C_Name")> ByVal table As Table) As ActionResult
            If ModelState.IsValid Then
                db.Entry(table).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(table)
        End Function

        ' GET: CTable/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim table As Table = db.Tables.Find(id)
            If IsNothing(table) Then
                Return HttpNotFound()
            End If
            Return View(table)
        End Function

        ' POST: CTable/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim table As Table = db.Tables.Find(id)
            db.Tables.Remove(table)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
