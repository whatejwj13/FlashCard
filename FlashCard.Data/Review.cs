//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FlashCard.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Review
    {
        public int ReviewId { get; set; }
        public int CardId { get; set; }
        public System.DateTime At { get; set; }
        public bool Passed { get; set; }
        public int MovedTo { get; set; }
    
        public virtual Card Card { get; set; }
    }
}
