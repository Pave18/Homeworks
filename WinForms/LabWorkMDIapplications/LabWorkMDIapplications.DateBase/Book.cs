//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LabWorkMDIapplications.DateBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class Book
    {
        public int IdBook { get; set; }
        public string NameBook { get; set; }
        public int NamPages { get; set; }
        public int IdAutor { get; set; }
        public int IdPublishingHouse { get; set; }
    
        public virtual Autor Autor { get; set; }
        public virtual PublishingHouseSet PublishingHouseSet { get; set; }
    }
}
