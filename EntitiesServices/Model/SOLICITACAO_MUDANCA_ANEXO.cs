//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntitiesServices.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class SOLICITACAO_MUDANCA_ANEXO
    {
        public int SOAN_CD_ID { get; set; }
        public int SOMU_CD_ID { get; set; }
        public string SOAN_NM_TITULO { get; set; }
        public Nullable<System.DateTime> SOAN_DT_ANEXO { get; set; }
        public Nullable<int> SOAN_IN_TIPO { get; set; }
        public string SOAN_AQ_ARQUIVO { get; set; }
        public Nullable<int> SOAN_IN_ATIVO { get; set; }
    
        public virtual SOLICITACAO_MUDANCA SOLICITACAO_MUDANCA { get; set; }
    }
}
