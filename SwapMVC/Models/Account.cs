
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
    using System.Collections.Generic;
    
public partial class Account
{

    public Account()
    {

        this.Book = new HashSet<Book>();

        this.Comment = new HashSet<Comment>();

        this.SwapItem = new HashSet<SwapItem>();

    }


    public int ID { get; set; }

    public string Email { get; set; }

    public string Passwd { get; set; }

    public string Fullname { get; set; }

    public Nullable<bool> Gender { get; set; }

    public Nullable<int> Phone { get; set; }

    public string City { get; set; }

    public string UsrAddress { get; set; }

    public string Avatar { get; set; }

    public string AccType { get; set; }



    public virtual ICollection<Book> Book { get; set; }

    public virtual ICollection<Comment> Comment { get; set; }

    public virtual ICollection<SwapItem> SwapItem { get; set; }

}

}
