//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Runtime.Serialization;


namespace Enterprise.Logic.Entities
{
    using System;
    using System.Collections.Generic;
    
    [DataContract]
    public partial class Menu: Entity
    {
        
    	[DataMember]
        public int RestaurantId { get; set; }
    	[DataMember]
        public System.DateTime StartDate { get; set; }
    	[DataMember]
        public System.DateTime EndDate { get; set; }
    	[DataMember]
        public string MenuType { get; set; }
    }
}
