//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Blogum.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Comments
    {
        public int CommentId { get; set; }
        public string NameSurName { get; set; }
        public string Email { get; set; }
        public string CommentContent { get; set; }
        public Nullable<System.DateTime> CommentDate { get; set; }
        public Nullable<bool> IsApproved { get; set; }
        public string CommentImage { get; set; }
        public Nullable<int> ArticleId { get; set; }
    
        public virtual Articles Articles { get; set; }
    }
}