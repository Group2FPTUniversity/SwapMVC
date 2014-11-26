﻿

//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace SwapMVC.Models
{

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;


public partial class SwapDBEntities : DbContext
{
    public SwapDBEntities()
        : base("name=SwapDBEntities")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public DbSet<Account> Account { get; set; }

    public DbSet<Book> Book { get; set; }

    public DbSet<Category> Category { get; set; }

    public DbSet<Comment> Comment { get; set; }

    public DbSet<SwapItem> SwapItem { get; set; }

    public DbSet<SwapTransaction> SwapTransaction { get; set; }

    public DbSet<sysdiagrams> sysdiagrams { get; set; }


    public virtual int Account_Delete(Nullable<int> iD)
    {

        var iDParameter = iD.HasValue ?
            new ObjectParameter("ID", iD) :
            new ObjectParameter("ID", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Account_Delete", iDParameter);
    }


    public virtual int Account_Insert(string email, string passwd, string fullname, Nullable<bool> gender, Nullable<int> phone, string city, string usrAddress, byte[] avatar, string accType)
    {

        var emailParameter = email != null ?
            new ObjectParameter("Email", email) :
            new ObjectParameter("Email", typeof(string));


        var passwdParameter = passwd != null ?
            new ObjectParameter("Passwd", passwd) :
            new ObjectParameter("Passwd", typeof(string));


        var fullnameParameter = fullname != null ?
            new ObjectParameter("Fullname", fullname) :
            new ObjectParameter("Fullname", typeof(string));


        var genderParameter = gender.HasValue ?
            new ObjectParameter("Gender", gender) :
            new ObjectParameter("Gender", typeof(bool));


        var phoneParameter = phone.HasValue ?
            new ObjectParameter("Phone", phone) :
            new ObjectParameter("Phone", typeof(int));


        var cityParameter = city != null ?
            new ObjectParameter("City", city) :
            new ObjectParameter("City", typeof(string));


        var usrAddressParameter = usrAddress != null ?
            new ObjectParameter("UsrAddress", usrAddress) :
            new ObjectParameter("UsrAddress", typeof(string));


        var avatarParameter = avatar != null ?
            new ObjectParameter("Avatar", avatar) :
            new ObjectParameter("Avatar", typeof(byte[]));


        var accTypeParameter = accType != null ?
            new ObjectParameter("AccType", accType) :
            new ObjectParameter("AccType", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Account_Insert", emailParameter, passwdParameter, fullnameParameter, genderParameter, phoneParameter, cityParameter, usrAddressParameter, avatarParameter, accTypeParameter);
    }


    public virtual int Account_Update(Nullable<int> iD, string email, string passwd, string fullname, Nullable<System.DateTime> dOB, Nullable<bool> gender, Nullable<int> phone, string city, string usrAddress, byte[] avatar, string accType)
    {

        var iDParameter = iD.HasValue ?
            new ObjectParameter("ID", iD) :
            new ObjectParameter("ID", typeof(int));


        var emailParameter = email != null ?
            new ObjectParameter("Email", email) :
            new ObjectParameter("Email", typeof(string));


        var passwdParameter = passwd != null ?
            new ObjectParameter("Passwd", passwd) :
            new ObjectParameter("Passwd", typeof(string));


        var fullnameParameter = fullname != null ?
            new ObjectParameter("Fullname", fullname) :
            new ObjectParameter("Fullname", typeof(string));


        var dOBParameter = dOB.HasValue ?
            new ObjectParameter("DOB", dOB) :
            new ObjectParameter("DOB", typeof(System.DateTime));


        var genderParameter = gender.HasValue ?
            new ObjectParameter("Gender", gender) :
            new ObjectParameter("Gender", typeof(bool));


        var phoneParameter = phone.HasValue ?
            new ObjectParameter("Phone", phone) :
            new ObjectParameter("Phone", typeof(int));


        var cityParameter = city != null ?
            new ObjectParameter("City", city) :
            new ObjectParameter("City", typeof(string));


        var usrAddressParameter = usrAddress != null ?
            new ObjectParameter("UsrAddress", usrAddress) :
            new ObjectParameter("UsrAddress", typeof(string));


        var avatarParameter = avatar != null ?
            new ObjectParameter("Avatar", avatar) :
            new ObjectParameter("Avatar", typeof(byte[]));


        var accTypeParameter = accType != null ?
            new ObjectParameter("AccType", accType) :
            new ObjectParameter("AccType", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Account_Update", iDParameter, emailParameter, passwdParameter, fullnameParameter, dOBParameter, genderParameter, phoneParameter, cityParameter, usrAddressParameter, avatarParameter, accTypeParameter);
    }


    public virtual int Book_Delete(Nullable<int> iD)
    {

        var iDParameter = iD.HasValue ?
            new ObjectParameter("ID", iD) :
            new ObjectParameter("ID", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Book_Delete", iDParameter);
    }


    public virtual int Book_Insert(Nullable<int> accID, string title, string author, Nullable<int> categoryID, string publisher, Nullable<decimal> pblYear, string descrptn, Nullable<int> price, byte[] bookImage, string bookStatus, string city, string detailAddr, Nullable<System.DateTime> postDate, Nullable<System.DateTime> dueDate)
    {

        var accIDParameter = accID.HasValue ?
            new ObjectParameter("AccID", accID) :
            new ObjectParameter("AccID", typeof(int));


        var titleParameter = title != null ?
            new ObjectParameter("Title", title) :
            new ObjectParameter("Title", typeof(string));


        var authorParameter = author != null ?
            new ObjectParameter("Author", author) :
            new ObjectParameter("Author", typeof(string));


        var categoryIDParameter = categoryID.HasValue ?
            new ObjectParameter("CategoryID", categoryID) :
            new ObjectParameter("CategoryID", typeof(int));


        var publisherParameter = publisher != null ?
            new ObjectParameter("Publisher", publisher) :
            new ObjectParameter("Publisher", typeof(string));


        var pblYearParameter = pblYear.HasValue ?
            new ObjectParameter("PblYear", pblYear) :
            new ObjectParameter("PblYear", typeof(decimal));


        var descrptnParameter = descrptn != null ?
            new ObjectParameter("Descrptn", descrptn) :
            new ObjectParameter("Descrptn", typeof(string));


        var priceParameter = price.HasValue ?
            new ObjectParameter("Price", price) :
            new ObjectParameter("Price", typeof(int));


        var bookImageParameter = bookImage != null ?
            new ObjectParameter("BookImage", bookImage) :
            new ObjectParameter("BookImage", typeof(byte[]));


        var bookStatusParameter = bookStatus != null ?
            new ObjectParameter("BookStatus", bookStatus) :
            new ObjectParameter("BookStatus", typeof(string));


        var cityParameter = city != null ?
            new ObjectParameter("City", city) :
            new ObjectParameter("City", typeof(string));


        var detailAddrParameter = detailAddr != null ?
            new ObjectParameter("DetailAddr", detailAddr) :
            new ObjectParameter("DetailAddr", typeof(string));


        var postDateParameter = postDate.HasValue ?
            new ObjectParameter("PostDate", postDate) :
            new ObjectParameter("PostDate", typeof(System.DateTime));


        var dueDateParameter = dueDate.HasValue ?
            new ObjectParameter("DueDate", dueDate) :
            new ObjectParameter("DueDate", typeof(System.DateTime));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Book_Insert", accIDParameter, titleParameter, authorParameter, categoryIDParameter, publisherParameter, pblYearParameter, descrptnParameter, priceParameter, bookImageParameter, bookStatusParameter, cityParameter, detailAddrParameter, postDateParameter, dueDateParameter);
    }


    public virtual int Book_Update(Nullable<int> iD, Nullable<int> accID, string title, string author, Nullable<int> categoryID, string publisher, Nullable<decimal> pblYear, string descrptn, Nullable<int> price, byte[] bookImage, string bookStatus, string city, string detailAddr, Nullable<System.DateTime> postDate, Nullable<System.DateTime> dueDate)
    {

        var iDParameter = iD.HasValue ?
            new ObjectParameter("ID", iD) :
            new ObjectParameter("ID", typeof(int));


        var accIDParameter = accID.HasValue ?
            new ObjectParameter("AccID", accID) :
            new ObjectParameter("AccID", typeof(int));


        var titleParameter = title != null ?
            new ObjectParameter("Title", title) :
            new ObjectParameter("Title", typeof(string));


        var authorParameter = author != null ?
            new ObjectParameter("Author", author) :
            new ObjectParameter("Author", typeof(string));


        var categoryIDParameter = categoryID.HasValue ?
            new ObjectParameter("CategoryID", categoryID) :
            new ObjectParameter("CategoryID", typeof(int));


        var publisherParameter = publisher != null ?
            new ObjectParameter("Publisher", publisher) :
            new ObjectParameter("Publisher", typeof(string));


        var pblYearParameter = pblYear.HasValue ?
            new ObjectParameter("PblYear", pblYear) :
            new ObjectParameter("PblYear", typeof(decimal));


        var descrptnParameter = descrptn != null ?
            new ObjectParameter("Descrptn", descrptn) :
            new ObjectParameter("Descrptn", typeof(string));


        var priceParameter = price.HasValue ?
            new ObjectParameter("Price", price) :
            new ObjectParameter("Price", typeof(int));


        var bookImageParameter = bookImage != null ?
            new ObjectParameter("BookImage", bookImage) :
            new ObjectParameter("BookImage", typeof(byte[]));


        var bookStatusParameter = bookStatus != null ?
            new ObjectParameter("BookStatus", bookStatus) :
            new ObjectParameter("BookStatus", typeof(string));


        var cityParameter = city != null ?
            new ObjectParameter("City", city) :
            new ObjectParameter("City", typeof(string));


        var detailAddrParameter = detailAddr != null ?
            new ObjectParameter("DetailAddr", detailAddr) :
            new ObjectParameter("DetailAddr", typeof(string));


        var postDateParameter = postDate.HasValue ?
            new ObjectParameter("PostDate", postDate) :
            new ObjectParameter("PostDate", typeof(System.DateTime));


        var dueDateParameter = dueDate.HasValue ?
            new ObjectParameter("DueDate", dueDate) :
            new ObjectParameter("DueDate", typeof(System.DateTime));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Book_Update", iDParameter, accIDParameter, titleParameter, authorParameter, categoryIDParameter, publisherParameter, pblYearParameter, descrptnParameter, priceParameter, bookImageParameter, bookStatusParameter, cityParameter, detailAddrParameter, postDateParameter, dueDateParameter);
    }


    public virtual int Category_Delete(Nullable<int> iD)
    {

        var iDParameter = iD.HasValue ?
            new ObjectParameter("ID", iD) :
            new ObjectParameter("ID", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Category_Delete", iDParameter);
    }


    public virtual int Category_Insert(string name)
    {

        var nameParameter = name != null ?
            new ObjectParameter("Name", name) :
            new ObjectParameter("Name", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Category_Insert", nameParameter);
    }


    public virtual int Category_Update(Nullable<int> iD, string name)
    {

        var iDParameter = iD.HasValue ?
            new ObjectParameter("ID", iD) :
            new ObjectParameter("ID", typeof(int));


        var nameParameter = name != null ?
            new ObjectParameter("Name", name) :
            new ObjectParameter("Name", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Category_Update", iDParameter, nameParameter);
    }


    public virtual int Comment_Delete(Nullable<int> iD)
    {

        var iDParameter = iD.HasValue ?
            new ObjectParameter("ID", iD) :
            new ObjectParameter("ID", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Comment_Delete", iDParameter);
    }


    public virtual int Comment_Insert(Nullable<int> swapItemID, Nullable<int> accID, string content, Nullable<System.DateTime> commentDate)
    {

        var swapItemIDParameter = swapItemID.HasValue ?
            new ObjectParameter("SwapItemID", swapItemID) :
            new ObjectParameter("SwapItemID", typeof(int));


        var accIDParameter = accID.HasValue ?
            new ObjectParameter("AccID", accID) :
            new ObjectParameter("AccID", typeof(int));


        var contentParameter = content != null ?
            new ObjectParameter("Content", content) :
            new ObjectParameter("Content", typeof(string));


        var commentDateParameter = commentDate.HasValue ?
            new ObjectParameter("CommentDate", commentDate) :
            new ObjectParameter("CommentDate", typeof(System.DateTime));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Comment_Insert", swapItemIDParameter, accIDParameter, contentParameter, commentDateParameter);
    }


    public virtual int Comment_Update(Nullable<int> iD, Nullable<int> swapItemID, Nullable<int> accID, string content, Nullable<System.DateTime> commentDate)
    {

        var iDParameter = iD.HasValue ?
            new ObjectParameter("ID", iD) :
            new ObjectParameter("ID", typeof(int));


        var swapItemIDParameter = swapItemID.HasValue ?
            new ObjectParameter("SwapItemID", swapItemID) :
            new ObjectParameter("SwapItemID", typeof(int));


        var accIDParameter = accID.HasValue ?
            new ObjectParameter("AccID", accID) :
            new ObjectParameter("AccID", typeof(int));


        var contentParameter = content != null ?
            new ObjectParameter("Content", content) :
            new ObjectParameter("Content", typeof(string));


        var commentDateParameter = commentDate.HasValue ?
            new ObjectParameter("CommentDate", commentDate) :
            new ObjectParameter("CommentDate", typeof(System.DateTime));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Comment_Update", iDParameter, swapItemIDParameter, accIDParameter, contentParameter, commentDateParameter);
    }


    public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
    {

        var diagramnameParameter = diagramname != null ?
            new ObjectParameter("diagramname", diagramname) :
            new ObjectParameter("diagramname", typeof(string));


        var owner_idParameter = owner_id.HasValue ?
            new ObjectParameter("owner_id", owner_id) :
            new ObjectParameter("owner_id", typeof(int));


        var versionParameter = version.HasValue ?
            new ObjectParameter("version", version) :
            new ObjectParameter("version", typeof(int));


        var definitionParameter = definition != null ?
            new ObjectParameter("definition", definition) :
            new ObjectParameter("definition", typeof(byte[]));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
    }


    public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
    {

        var diagramnameParameter = diagramname != null ?
            new ObjectParameter("diagramname", diagramname) :
            new ObjectParameter("diagramname", typeof(string));


        var owner_idParameter = owner_id.HasValue ?
            new ObjectParameter("owner_id", owner_id) :
            new ObjectParameter("owner_id", typeof(int));


        var versionParameter = version.HasValue ?
            new ObjectParameter("version", version) :
            new ObjectParameter("version", typeof(int));


        var definitionParameter = definition != null ?
            new ObjectParameter("definition", definition) :
            new ObjectParameter("definition", typeof(byte[]));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
    }


    public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
    {

        var diagramnameParameter = diagramname != null ?
            new ObjectParameter("diagramname", diagramname) :
            new ObjectParameter("diagramname", typeof(string));


        var owner_idParameter = owner_id.HasValue ?
            new ObjectParameter("owner_id", owner_id) :
            new ObjectParameter("owner_id", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
    }


    public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
    {

        var diagramnameParameter = diagramname != null ?
            new ObjectParameter("diagramname", diagramname) :
            new ObjectParameter("diagramname", typeof(string));


        var owner_idParameter = owner_id.HasValue ?
            new ObjectParameter("owner_id", owner_id) :
            new ObjectParameter("owner_id", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
    }


    public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
    {

        var diagramnameParameter = diagramname != null ?
            new ObjectParameter("diagramname", diagramname) :
            new ObjectParameter("diagramname", typeof(string));


        var owner_idParameter = owner_id.HasValue ?
            new ObjectParameter("owner_id", owner_id) :
            new ObjectParameter("owner_id", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
    }


    public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
    {

        var diagramnameParameter = diagramname != null ?
            new ObjectParameter("diagramname", diagramname) :
            new ObjectParameter("diagramname", typeof(string));


        var owner_idParameter = owner_id.HasValue ?
            new ObjectParameter("owner_id", owner_id) :
            new ObjectParameter("owner_id", typeof(int));


        var new_diagramnameParameter = new_diagramname != null ?
            new ObjectParameter("new_diagramname", new_diagramname) :
            new ObjectParameter("new_diagramname", typeof(string));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
    }


    public virtual int sp_upgraddiagrams()
    {

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
    }


    public virtual int SwapItem_Delete(Nullable<int> iD)
    {

        var iDParameter = iD.HasValue ?
            new ObjectParameter("ID", iD) :
            new ObjectParameter("ID", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SwapItem_Delete", iDParameter);
    }


    public virtual int SwapItem_Insert(Nullable<int> bookID, Nullable<int> accID, string itemType, string itemTitle, string itemDcrpt, byte[] itemImage, Nullable<int> price, string itemStatus, Nullable<System.DateTime> postDate)
    {

        var bookIDParameter = bookID.HasValue ?
            new ObjectParameter("BookID", bookID) :
            new ObjectParameter("BookID", typeof(int));


        var accIDParameter = accID.HasValue ?
            new ObjectParameter("AccID", accID) :
            new ObjectParameter("AccID", typeof(int));


        var itemTypeParameter = itemType != null ?
            new ObjectParameter("ItemType", itemType) :
            new ObjectParameter("ItemType", typeof(string));


        var itemTitleParameter = itemTitle != null ?
            new ObjectParameter("ItemTitle", itemTitle) :
            new ObjectParameter("ItemTitle", typeof(string));


        var itemDcrptParameter = itemDcrpt != null ?
            new ObjectParameter("ItemDcrpt", itemDcrpt) :
            new ObjectParameter("ItemDcrpt", typeof(string));


        var itemImageParameter = itemImage != null ?
            new ObjectParameter("ItemImage", itemImage) :
            new ObjectParameter("ItemImage", typeof(byte[]));


        var priceParameter = price.HasValue ?
            new ObjectParameter("Price", price) :
            new ObjectParameter("Price", typeof(int));


        var itemStatusParameter = itemStatus != null ?
            new ObjectParameter("ItemStatus", itemStatus) :
            new ObjectParameter("ItemStatus", typeof(string));


        var postDateParameter = postDate.HasValue ?
            new ObjectParameter("PostDate", postDate) :
            new ObjectParameter("PostDate", typeof(System.DateTime));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SwapItem_Insert", bookIDParameter, accIDParameter, itemTypeParameter, itemTitleParameter, itemDcrptParameter, itemImageParameter, priceParameter, itemStatusParameter, postDateParameter);
    }


    public virtual int SwapItem_Update(Nullable<int> iD, Nullable<int> bookID, Nullable<int> accID, string itemType, string itemTitle, string itemDcrpt, byte[] itemImage, Nullable<int> price, string itemStatus, Nullable<System.DateTime> postDate)
    {

        var iDParameter = iD.HasValue ?
            new ObjectParameter("ID", iD) :
            new ObjectParameter("ID", typeof(int));


        var bookIDParameter = bookID.HasValue ?
            new ObjectParameter("BookID", bookID) :
            new ObjectParameter("BookID", typeof(int));


        var accIDParameter = accID.HasValue ?
            new ObjectParameter("AccID", accID) :
            new ObjectParameter("AccID", typeof(int));


        var itemTypeParameter = itemType != null ?
            new ObjectParameter("ItemType", itemType) :
            new ObjectParameter("ItemType", typeof(string));


        var itemTitleParameter = itemTitle != null ?
            new ObjectParameter("ItemTitle", itemTitle) :
            new ObjectParameter("ItemTitle", typeof(string));


        var itemDcrptParameter = itemDcrpt != null ?
            new ObjectParameter("ItemDcrpt", itemDcrpt) :
            new ObjectParameter("ItemDcrpt", typeof(string));


        var itemImageParameter = itemImage != null ?
            new ObjectParameter("ItemImage", itemImage) :
            new ObjectParameter("ItemImage", typeof(byte[]));


        var priceParameter = price.HasValue ?
            new ObjectParameter("Price", price) :
            new ObjectParameter("Price", typeof(int));


        var itemStatusParameter = itemStatus != null ?
            new ObjectParameter("ItemStatus", itemStatus) :
            new ObjectParameter("ItemStatus", typeof(string));


        var postDateParameter = postDate.HasValue ?
            new ObjectParameter("PostDate", postDate) :
            new ObjectParameter("PostDate", typeof(System.DateTime));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SwapItem_Update", iDParameter, bookIDParameter, accIDParameter, itemTypeParameter, itemTitleParameter, itemDcrptParameter, itemImageParameter, priceParameter, itemStatusParameter, postDateParameter);
    }


    public virtual int SwapTransaction_Delete(Nullable<int> iD)
    {

        var iDParameter = iD.HasValue ?
            new ObjectParameter("ID", iD) :
            new ObjectParameter("ID", typeof(int));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SwapTransaction_Delete", iDParameter);
    }


    public virtual int SwapTransaction_Insert(Nullable<int> bookID, Nullable<int> swapItemID, Nullable<System.DateTime> swapDate)
    {

        var bookIDParameter = bookID.HasValue ?
            new ObjectParameter("BookID", bookID) :
            new ObjectParameter("BookID", typeof(int));


        var swapItemIDParameter = swapItemID.HasValue ?
            new ObjectParameter("SwapItemID", swapItemID) :
            new ObjectParameter("SwapItemID", typeof(int));


        var swapDateParameter = swapDate.HasValue ?
            new ObjectParameter("SwapDate", swapDate) :
            new ObjectParameter("SwapDate", typeof(System.DateTime));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SwapTransaction_Insert", bookIDParameter, swapItemIDParameter, swapDateParameter);
    }


    public virtual int SwapTransaction_Update(Nullable<int> iD, Nullable<int> bookID, Nullable<int> swapItemID, Nullable<System.DateTime> swapDate)
    {

        var iDParameter = iD.HasValue ?
            new ObjectParameter("ID", iD) :
            new ObjectParameter("ID", typeof(int));


        var bookIDParameter = bookID.HasValue ?
            new ObjectParameter("BookID", bookID) :
            new ObjectParameter("BookID", typeof(int));


        var swapItemIDParameter = swapItemID.HasValue ?
            new ObjectParameter("SwapItemID", swapItemID) :
            new ObjectParameter("SwapItemID", typeof(int));


        var swapDateParameter = swapDate.HasValue ?
            new ObjectParameter("SwapDate", swapDate) :
            new ObjectParameter("SwapDate", typeof(System.DateTime));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SwapTransaction_Update", iDParameter, bookIDParameter, swapItemIDParameter, swapDateParameter);
    }

}

}

