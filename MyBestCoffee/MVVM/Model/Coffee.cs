//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyBestCoffee.MVVM.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Coffee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> Id_Class { get; set; }
        public Nullable<int> Id_Recipe { get; set; }
        public Nullable<int> Id_Instruction { get; set; }
        public Nullable<int> Id_Complexity { get; set; }
        public string img { get; set; }
    
        public virtual Class Class { get; set; }
        public virtual Recipe Recipe { get; set; }
        public virtual Complexity Complexity { get; set; }
        public virtual Ingredient Ingredient { get; set; }
    }
}
