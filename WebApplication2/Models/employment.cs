//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class employment
    {
        public int id { get; set; }
        public Nullable<int> id_work { get; set; }
        public Nullable<int> id_executor { get; set; }
    
        public virtual work work { get; set; }
        public virtual executor executor { get; set; }
    }
}
