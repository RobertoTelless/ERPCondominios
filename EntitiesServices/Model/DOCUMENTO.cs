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
    
    public partial class DOCUMENTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DOCUMENTO()
        {
            this.DOCUMENTO_METADADO = new HashSet<DOCUMENTO_METADADO>();
        }
    
        public int DOCU_CD_ID { get; set; }
        public int TIDO_CD_ID { get; set; }
        public Nullable<int> UNID_CD_ID { get; set; }
        public Nullable<int> FUCR_CD_ID { get; set; }
        public int GRUP_CD_ID { get; set; }
        public string DOCU_NM_TITULO { get; set; }
        public string DOCU_NM_ARQUIVO { get; set; }
        public string DOCU_NM_PALAVRA_CHAVE { get; set; }
        public System.DateTime DOCU_DT_CADASTRO { get; set; }
        public int DOCU_IN_ATIVO { get; set; }
    
        public virtual FUNCIONARIO FUNCIONARIO { get; set; }
        public virtual GRUPO GRUPO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DOCUMENTO_METADADO> DOCUMENTO_METADADO { get; set; }
        public virtual TIPO_DOCUMENTO TIPO_DOCUMENTO { get; set; }
        public virtual UNIDADE UNIDADE { get; set; }
    }
}
