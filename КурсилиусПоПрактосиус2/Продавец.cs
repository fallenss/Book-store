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
    
    public partial class Продавец
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Продавец()
        {
            this.Покупка = new HashSet<Покупка>();
        }
    
        public int ID_номер { get; set; }
        public int Номер_отдела { get; set; }
        public string ФИО { get; set; }
        public string Пароль { get; set; }
    
        public virtual Отдел Отдел { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Покупка> Покупка { get; set; }
    }
}
