﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExpenseReportApp.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class ExpenseReportEntities : DbContext
    {
        public ExpenseReportEntities()
            : base("name=ExpenseReportEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<ExpenseReport> ExpenseReports { get; set; }
        public virtual DbSet<LineItem> LineItems { get; set; }
    
        public virtual int DeleteExpenseReport(Nullable<int> expenseReportId)
        {
            var expenseReportIdParameter = expenseReportId.HasValue ?
                new ObjectParameter("ExpenseReportId", expenseReportId) :
                new ObjectParameter("ExpenseReportId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteExpenseReport", expenseReportIdParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> InsertExpenseReport(string firstName, string lastName, string companyName, Nullable<System.DateTime> date, string description, string userID, Nullable<decimal> expenseTotal)
        {
            var firstNameParameter = firstName != null ?
                new ObjectParameter("FirstName", firstName) :
                new ObjectParameter("FirstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var companyNameParameter = companyName != null ?
                new ObjectParameter("CompanyName", companyName) :
                new ObjectParameter("CompanyName", typeof(string));
    
            var dateParameter = date.HasValue ?
                new ObjectParameter("Date", date) :
                new ObjectParameter("Date", typeof(System.DateTime));
    
            var descriptionParameter = description != null ?
                new ObjectParameter("Description", description) :
                new ObjectParameter("Description", typeof(string));
    
            var userIDParameter = userID != null ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(string));
    
            var expenseTotalParameter = expenseTotal.HasValue ?
                new ObjectParameter("ExpenseTotal", expenseTotal) :
                new ObjectParameter("ExpenseTotal", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("InsertExpenseReport", firstNameParameter, lastNameParameter, companyNameParameter, dateParameter, descriptionParameter, userIDParameter, expenseTotalParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> InsertLineItem(Nullable<int> categoryID, string description, Nullable<System.DateTime> timeStamp, Nullable<decimal> amount, Nullable<int> expenseReportID)
        {
            var categoryIDParameter = categoryID.HasValue ?
                new ObjectParameter("CategoryID", categoryID) :
                new ObjectParameter("CategoryID", typeof(int));
    
            var descriptionParameter = description != null ?
                new ObjectParameter("Description", description) :
                new ObjectParameter("Description", typeof(string));
    
            var timeStampParameter = timeStamp.HasValue ?
                new ObjectParameter("TimeStamp", timeStamp) :
                new ObjectParameter("TimeStamp", typeof(System.DateTime));
    
            var amountParameter = amount.HasValue ?
                new ObjectParameter("Amount", amount) :
                new ObjectParameter("Amount", typeof(decimal));
    
            var expenseReportIDParameter = expenseReportID.HasValue ?
                new ObjectParameter("ExpenseReportID", expenseReportID) :
                new ObjectParameter("ExpenseReportID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("InsertLineItem", categoryIDParameter, descriptionParameter, timeStampParameter, amountParameter, expenseReportIDParameter);
        }
    
        public virtual int UpdateExpenseReport(Nullable<int> expenseReportID, string firstName, string lastName, string companyName, Nullable<System.DateTime> date, string description, string userID, Nullable<decimal> expenseTotal)
        {
            var expenseReportIDParameter = expenseReportID.HasValue ?
                new ObjectParameter("ExpenseReportID", expenseReportID) :
                new ObjectParameter("ExpenseReportID", typeof(int));
    
            var firstNameParameter = firstName != null ?
                new ObjectParameter("FirstName", firstName) :
                new ObjectParameter("FirstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var companyNameParameter = companyName != null ?
                new ObjectParameter("CompanyName", companyName) :
                new ObjectParameter("CompanyName", typeof(string));
    
            var dateParameter = date.HasValue ?
                new ObjectParameter("Date", date) :
                new ObjectParameter("Date", typeof(System.DateTime));
    
            var descriptionParameter = description != null ?
                new ObjectParameter("Description", description) :
                new ObjectParameter("Description", typeof(string));
    
            var userIDParameter = userID != null ?
                new ObjectParameter("UserID", userID) :
                new ObjectParameter("UserID", typeof(string));
    
            var expenseTotalParameter = expenseTotal.HasValue ?
                new ObjectParameter("ExpenseTotal", expenseTotal) :
                new ObjectParameter("ExpenseTotal", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateExpenseReport", expenseReportIDParameter, firstNameParameter, lastNameParameter, companyNameParameter, dateParameter, descriptionParameter, userIDParameter, expenseTotalParameter);
        }
    
        public virtual int UpdateLineItem(Nullable<int> lineItemID, Nullable<int> categoryID, string description, Nullable<System.DateTime> timeStamp, Nullable<decimal> amount, Nullable<int> expenseReportID)
        {
            var lineItemIDParameter = lineItemID.HasValue ?
                new ObjectParameter("LineItemID", lineItemID) :
                new ObjectParameter("LineItemID", typeof(int));
    
            var categoryIDParameter = categoryID.HasValue ?
                new ObjectParameter("CategoryID", categoryID) :
                new ObjectParameter("CategoryID", typeof(int));
    
            var descriptionParameter = description != null ?
                new ObjectParameter("Description", description) :
                new ObjectParameter("Description", typeof(string));
    
            var timeStampParameter = timeStamp.HasValue ?
                new ObjectParameter("TimeStamp", timeStamp) :
                new ObjectParameter("TimeStamp", typeof(System.DateTime));
    
            var amountParameter = amount.HasValue ?
                new ObjectParameter("Amount", amount) :
                new ObjectParameter("Amount", typeof(decimal));
    
            var expenseReportIDParameter = expenseReportID.HasValue ?
                new ObjectParameter("ExpenseReportID", expenseReportID) :
                new ObjectParameter("ExpenseReportID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateLineItem", lineItemIDParameter, categoryIDParameter, descriptionParameter, timeStampParameter, amountParameter, expenseReportIDParameter);
        }
    }
}
