//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.MyDB
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_productDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_productDetail()
        {
            this.tbl_wishList = new HashSet<tbl_wishList>();
        }
    
        public decimal ad_id { get; set; }
        public Nullable<decimal> cat_id { get; set; }
        public Nullable<decimal> subcat_id { get; set; }
        public Nullable<decimal> user_id { get; set; }
        public string pro_name { get; set; }
        public string pro_image { get; set; }
        public Nullable<decimal> pro_price { get; set; }
        public string pro_desc { get; set; }
        public string ad_status { get; set; }
    
        public virtual tbl_categories tbl_categories { get; set; }
        public virtual tbl_subcategories tbl_subcategories { get; set; }
        public virtual tbl_user tbl_user { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_wishList> tbl_wishList { get; set; }
    }
}
