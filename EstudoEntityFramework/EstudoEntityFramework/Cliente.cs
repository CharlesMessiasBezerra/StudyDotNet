//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EstudoEntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cliente
    {
        public int pk_intCod { get; set; }
        public Nullable<int> fk_intBairro { get; set; }
        public string strNOME { get; set; }
        public Nullable<int> intIdade { get; set; }
        public string strSexo { get; set; }
    
        public virtual Bairro Bairro { get; set; }
    }
}