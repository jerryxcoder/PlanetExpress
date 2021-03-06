//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JinStore.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CustomerList
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CustomerList()
        {
            this.webpages_Roles = new HashSet<webpages_Roles>();
        }
    
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateLastModified { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string CreditCardNumber { get; set; }
        public string CreditCardName { get; set; }
        public string CVV { get; set; }
        public Nullable<System.DateTime> CreditCardExpirationDate { get; set; }
        public string BillingStreet1 { get; set; }
        public string BillingStreet2 { get; set; }
        public string BillingCity { get; set; }
        public string BillingState { get; set; }
        public string BillingPostalCode { get; set; }
        public string BillingReceipient { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<webpages_Roles> webpages_Roles { get; set; }
    }
}
