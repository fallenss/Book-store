//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace КурсилиусПоПрактосиус2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Покупатель
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Покупатель()
        {
            this.Покупка = new HashSet<Покупка>();
        }
    
        public int Индивидуальный_номер_заказа { get; set; }
        public string ФИО { get; set; }
        public string Номер_Телефона { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Покупка> Покупка { get; set; }
    }
}
