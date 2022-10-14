Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports PagedList
Imports Project

Namespace Controllers
    Public Class PTable1Controller
        Inherits System.Web.Mvc.Controller

        Private db As New DbMVCEntities

        ' GET: PTable1
        Function Index() As ActionResult
            Dim table1 = db.Table1.Include(Function(t) t.Table)
            Return View(table1.ToList())
        End Function

        ' GET: PTable1/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim table1 As Table1 = db.Table1.Find(id)
            If IsNothing(table1) Then
                Return HttpNotFound()
            End If
            Return View(table1)
        End Function

        ' GET: PTable1/Create
        Function Create() As ActionResult
            ViewBag.C_Id = New SelectList(db.Tables, "C_Id", "C_Name")
            Return View()
        End Function

        ' POST: PTable1/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="P_Id,P_Name,C_Id")> ByVal table1 As Table1) As ActionResult
            If ModelState.IsValid Then
                db.Table1.Add(table1)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.C_Id = New SelectList(db.Tables, "C_Id", "C_Name", table1.C_Id)
            Return View(table1)
        End Function

        ' GET: PTable1/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim table1 As Table1 = db.Table1.Find(id)
            If IsNothing(table1) Then
                Return HttpNotFound()
            End If
            ViewBag.C_Id = New SelectList(db.Tables, "C_Id", "C_Name", table1.C_Id)
            Return View(table1)
        End Function

        ' POST: PTable1/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="P_Id,P_Name,C_Id")> ByVal table1 As Table1) As ActionResult
            If ModelState.IsValid Then
                db.Entry(table1).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.C_Id = New SelectList(db.Tables, "C_Id", "C_Name", table1.C_Id)
            Return View(table1)
        End Function

        ' GET: PTable1/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim table1 As Table1 = db.Table1.Find(id)
            If IsNothing(table1) Then
                Return HttpNotFound()
            End If
            Return View(table1)
        End Function

        ' POST: PTable1/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim table1 As Table1 = db.Table1.Find(id)
            db.Table1.Remove(table1)
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
