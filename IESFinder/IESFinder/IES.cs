using System.Collections.Generic;
using ProtoBuf;

namespace IESFinder
{
    /// <summary>
    /// Classe contendo as informações do ies, lidas do arquivo CADASTRO_DAS_IES_2011.csv
    /// O campo chave é codigo_ies
    /// </summary>
    [ProtoContract]
    public class IES
    {
        int co_ano = 0;
        int co_ies = 0;
        string no_ies = "";
        string sg_ies = "";
        string nu_cnpj = "";
        string regies = "";
        string regiaoies = "";
        string coufies = "";
        string nomeufies = "";
        string sigla = "";
        string municipioies = "";
        string comunicies = "";
        string comunicies12 = "";
        string locies = "";
        string localies = "";
        string org = "";
        string nomeorg = "";
        string corede = "";
        string rede = "";
        string co_dep = "";
        string depadm = "";
        string dep5 = "";
        string depadm5 = "";
        string mant = "";
        string mantenedora = "";
        string nu_cep = "";
        string ds_endereco = "";
        string ds_numero_endereco = "";
        string ds_complemento_endereco { get; set; }
        string no_bairro = "";
        string nu_telefone = "";
        string nu_fax = "";
        string tx_email = "";
        string tx_pagina_eletronica { get; set; }
        string no_procurador_institucional = "";
        string nu_cpf_procurador = "";
        string nu_telefone_procurador = "";
        string tx_email_procurador = "";
        string nies = "";

        [ProtoMember(1)]
        public int CO_ANO { get { return this.co_ano; } set { this.co_ano = value; } }
       
        [ProtoMember(2)]
        public int CO_IES { get { return this.co_ies; } set { this.co_ies = value; } }

        [ProtoMember(3)]
        public string NO_IES { get { return this.no_ies; } set { this.no_ies = value; } }

        [ProtoMember(4)]
        public string SG_IES { get { return this.sg_ies; } set { this.sg_ies = value; } }

        [ProtoMember(5)]
        public string NU_CNPJ { get { return this.nu_cnpj; } set { this.nu_cnpj = value; } }

        [ProtoMember(6)]
        public string REGIES { get { return this.regies; } set { this.regies = value; } }

        [ProtoMember(7)]
        public string REGIAOIES { get { return this.regiaoies; } set { this.regiaoies = value; } }

        [ProtoMember(8)]
        public string COUFIES { get { return this.coufies; } set { this.coufies = value; } }

        [ProtoMember(9)]
        public string NOMEUFIES { get { return this.nomeufies; } set { this.nomeufies = value; } }

        [ProtoMember(10)]
        public string SIGLA { get { return this.sigla; } set { this.sigla = value; } }

        [ProtoMember(11)]
        public string MUNICIPIOIES { get { return this.municipioies; } set { this.municipioies = value; } }

        [ProtoMember(12)]
        public string COMUNICIES { get { return this.comunicies; } set { this.comunicies = value; } }

        [ProtoMember(13)]
        public string COMUNICIES12 { get { return this.comunicies12; } set { this.comunicies12 = value; } }

        [ProtoMember(14)]
        public string LOCIES { get { return this.locies; } set { this.locies = value; } }

        [ProtoMember(15)]
        public string LOCALIES { get { return this.localies; } set { this.localies = value; } }

        [ProtoMember(16)]
        public string ORG { get { return this.org; } set { this.org = value; } }

        [ProtoMember(17)]
        public string NOMEORG { get { return this.nomeorg; } set { this.nomeorg = value; } }

        [ProtoMember(18)]
        public string COREDE { get { return this.corede; } set { this.corede = value; } }

        [ProtoMember(19)]
        public string REDE { get { return this.rede; } set { this.rede = value; } }

        [ProtoMember(20)]
        public string CO_DEP { get { return this.co_dep; } set { this.co_dep = value; } }

        [ProtoMember(21)]
        public string DEPADM { get { return this.depadm; } set { this.depadm = value; } }

        [ProtoMember(22)]
        public string DEP5 { get { return this.dep5; } set { this.dep5 = value; } }

        [ProtoMember(23)]
        public string DEPADM5 { get { return this.depadm5; } set { this.depadm5 = value; } }

        [ProtoMember(24)]
        public string MANT { get { return this.mant; } set { this.mant = value; } }

        [ProtoMember(25)]
        public string MANTENEDORA { get { return this.mantenedora; } set { this.mantenedora = value; } }

        [ProtoMember(26)]
        public string NU_CEP { get { return this.nu_cep; } set { this.nu_cep = value; } }

        [ProtoMember(27)]
        public string DS_ENDERECO { get { return this.ds_endereco; } set { this.ds_endereco = value; } }

        [ProtoMember(28)]
        public string DS_NUMERO_ENDERECO { get { return this.ds_numero_endereco; } set { this.ds_numero_endereco = value; } }

        [ProtoMember(29)]
        public string DS_COMPLEMENTO_ENDERECO { get { return this.ds_complemento_endereco; } set { this.ds_complemento_endereco = value; } }

        [ProtoMember(30)]
        public string NO_BAIRRO { get { return this.no_bairro; } set { this.no_bairro = value; } }

        [ProtoMember(31)]
        public string NU_TELEFONE { get { return this.nu_telefone; } set { this.nu_telefone = value; } }

        [ProtoMember(32)]
        public string NU_FAX { get { return this.nu_fax; } set { this.nu_fax = value; } }

        [ProtoMember(33)]
        public string TX_EMAIL { get { return this.tx_email; } set { this.tx_email = value; } }

        [ProtoMember(34)]
        public string TX_PAGINA_ELETRONICA { get { return this.tx_pagina_eletronica; } set { this.tx_pagina_eletronica = value; } }

        [ProtoMember(35)]
        public string NO_PROCURADOR_INTITUCIONAL { get { return this.no_procurador_institucional; } set { this.no_procurador_institucional = value; } }

        [ProtoMember(36)]
        public string NU_CPF_PROCURADOR { get { return this.nu_cpf_procurador; } set { this.nu_cpf_procurador = value; } }

        [ProtoMember(37)]
        public string NU_TELEFONE_PROCURADOR { get { return this.nu_telefone_procurador; } set { this.nu_telefone_procurador = value; } }

        [ProtoMember(38)]
        public string TX_EMAIL_PROCURADOR { get { return this.tx_email_procurador; } set { this.tx_email_procurador = value; } }

        [ProtoMember(39)]
        public string NIES { get { return this.nies; } set { this.nies = value; } }
    }
}