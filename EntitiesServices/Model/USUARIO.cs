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
    
    public partial class USUARIO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public USUARIO()
        {
            this.AGENDA = new HashSet<AGENDA>();
            this.AMBIENTE_CHAVE = new HashSet<AMBIENTE_CHAVE>();
            this.AUTORIZACAO_ACESSO = new HashSet<AUTORIZACAO_ACESSO>();
            this.CONTA_PAGAR = new HashSet<CONTA_PAGAR>();
            this.CONTA_RECEBER = new HashSet<CONTA_RECEBER>();
            this.CORPO_DIRETIVO = new HashSet<CORPO_DIRETIVO>();
            this.ENCOMENDA = new HashSet<ENCOMENDA>();
            this.LISTA_NEGRA = new HashSet<LISTA_NEGRA>();
            this.LOG = new HashSet<LOG>();
            this.NOTICIA_AVALIACAO = new HashSet<NOTICIA_AVALIACAO>();
            this.NOTICIA_COMENTARIO = new HashSet<NOTICIA_COMENTARIO>();
            this.NOTIFICACAO = new HashSet<NOTIFICACAO>();
            this.PROPRIETARIO = new HashSet<PROPRIETARIO>();
            this.RESERVA = new HashSet<RESERVA>();
            this.SOLICITACAO_MUDANCA = new HashSet<SOLICITACAO_MUDANCA>();
            this.SOLICITACAO_MUDANCA_COMENTARIO = new HashSet<SOLICITACAO_MUDANCA_COMENTARIO>();
            this.SOLICITACAO_MUDANCA_MOVIMENTO = new HashSet<SOLICITACAO_MUDANCA_MOVIMENTO>();
            this.TAREFA = new HashSet<TAREFA>();
            this.TAREFA1 = new HashSet<TAREFA>();
            this.TAREFA2 = new HashSet<TAREFA>();
            this.TAREFA3 = new HashSet<TAREFA>();
            this.TAREFA_ACOMPANHAMENTO = new HashSet<TAREFA_ACOMPANHAMENTO>();
            this.TAREFA_NOTIFICACAO = new HashSet<TAREFA_NOTIFICACAO>();
            this.USUARIO_ANEXO = new HashSet<USUARIO_ANEXO>();
            this.USUARIO_CONTROLE_ENTRADA = new HashSet<USUARIO_CONTROLE_ENTRADA>();
        }
    
        public int USUA_CD_ID { get; set; }
        public int COND_CD_ID { get; set; }
        public Nullable<int> TORR_CD_ID { get; set; }
        public int PERF_CD_ID { get; set; }
        public Nullable<int> UNID_CD_ID { get; set; }
        public Nullable<int> FUCR_CD_ID { get; set; }
        public Nullable<int> MORA_CD_ID { get; set; }
        public Nullable<int> CARG_CD_ID { get; set; }
        public Nullable<int> CAUS_CD_ID { get; set; }
        public int USUA_IN_MORADOR { get; set; }
        public int USUA_IN_PROPRIETARIO { get; set; }
        public int USUA_IN_FUNCIONARIO { get; set; }
        public int USUA_IN_BLOQUEADO { get; set; }
        public string USUA_NR_CPF { get; set; }
        public string USUA_NM_NOME { get; set; }
        public string USUA_NM_EMAIL { get; set; }
        public string USUA_NR_TELEFONE { get; set; }
        public string USUA_NR_CELULAR { get; set; }
        public string USUA_NM_SENHA { get; set; }
        public string USUA_NM_SENHA_CONFIRMA { get; set; }
        public byte[] USUA_IM_DIGITAL { get; set; }
        public int USUA_IN_PROVISORIA { get; set; }
        public int USUA_IN_LOGIN_PROVISORIO { get; set; }
        public int USUA_NR_ACESSOS { get; set; }
        public int USUA_NR_FALHAS { get; set; }
        public Nullable<System.DateTime> USUA_DT_ALTERACAO { get; set; }
        public Nullable<System.DateTime> USUA_DT_BLOQUEIO { get; set; }
        public Nullable<System.DateTime> USUA_DT_TROCA_SENHA { get; set; }
        public Nullable<System.DateTime> USUA_DT_ACESSO { get; set; }
        public System.DateTime USUA_DT_CADASTRO { get; set; }
        public int USUA_IN_ATIVO { get; set; }
        public Nullable<System.DateTime> USUA_DT_ULTIMA_FALHA { get; set; }
        public string USUA_NOVA_SENHA { get; set; }
        public string USUA_AQ_FOTO { get; set; }
        public string USUA_NM_LOGIN { get; set; }
        public string USUA_TX_OBSERVACOES { get; set; }
        public Nullable<int> USUA_IN_COMPRADOR { get; set; }
        public Nullable<int> USUA_IN_APROVADOR { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AGENDA> AGENDA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AMBIENTE_CHAVE> AMBIENTE_CHAVE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AUTORIZACAO_ACESSO> AUTORIZACAO_ACESSO { get; set; }
        public virtual CARGO CARGO { get; set; }
        public virtual CATEGORIA_USUARIO CATEGORIA_USUARIO { get; set; }
        public virtual CONDOMINIO CONDOMINIO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONTA_PAGAR> CONTA_PAGAR { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONTA_RECEBER> CONTA_RECEBER { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CORPO_DIRETIVO> CORPO_DIRETIVO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ENCOMENDA> ENCOMENDA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LISTA_NEGRA> LISTA_NEGRA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LOG> LOG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NOTICIA_AVALIACAO> NOTICIA_AVALIACAO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NOTICIA_COMENTARIO> NOTICIA_COMENTARIO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NOTIFICACAO> NOTIFICACAO { get; set; }
        public virtual PERFIL PERFIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROPRIETARIO> PROPRIETARIO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RESERVA> RESERVA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SOLICITACAO_MUDANCA> SOLICITACAO_MUDANCA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SOLICITACAO_MUDANCA_COMENTARIO> SOLICITACAO_MUDANCA_COMENTARIO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SOLICITACAO_MUDANCA_MOVIMENTO> SOLICITACAO_MUDANCA_MOVIMENTO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TAREFA> TAREFA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TAREFA> TAREFA1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TAREFA> TAREFA2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TAREFA> TAREFA3 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TAREFA_ACOMPANHAMENTO> TAREFA_ACOMPANHAMENTO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TAREFA_NOTIFICACAO> TAREFA_NOTIFICACAO { get; set; }
        public virtual UNIDADE UNIDADE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USUARIO_ANEXO> USUARIO_ANEXO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USUARIO_CONTROLE_ENTRADA> USUARIO_CONTROLE_ENTRADA { get; set; }
    }
}
