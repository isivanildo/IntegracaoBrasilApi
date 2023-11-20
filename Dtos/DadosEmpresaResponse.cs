using System.Text.Json.Serialization;
using Models;

namespace Dtos
{
    public class DadosEmpresaResponse
    {
        public string? Uf { get; set; }
        public string? Cep { get; set; }
        public List<Qsa> Qsa { get; set; } = new List<Qsa>();
        public string? Cnpj { get; set; }
        public string? Pais { get; set; }
        public string? Email { get; set; }
        public string? Porte { get; set; }
        public string? Bairro { get; set; }
        public string? Numero { get; set; }
        public string? DddFax { get; set; }
        public string? Municipio { get; set; }
        public string? Logradouro { get; set; }
        public int? CnaeFiscal { get; set; }
        public string? CodigoPais { get; set; }
        public string? Complemento { get; set; }
        public int? CodigoPorte { get; set; }
        public string? RazaoSocial { get; set; }
        public string? NomeFantasia { get; set; }
        public int? CapitalSocial { get; set; }
        public string? DddTelefone1 { get; set; }
        public string? DddTelefone2 { get; set; }
        public bool OpcaoPeloMei { get; set; }
        public string? DescricaoPorte { get; set; }
        public int CodigoMunicipio { get; set; }
        public List<CnaesSecundario> CnaesSecundarios { get; set; } = new List<CnaesSecundario>();
        public string? NaturezaJuridica { get; set; }
        public string? SituacaoEspecial { get; set; }
        public bool OpcaoPeloSimples { get; set; }
        public int? SituacaoCadastral { get; set; }
        public string? DataOpcaoPeloMei { get; set; }
        public string? DataExclusaoDoMei { get; set; }
        public string? CnaeFiscalDescricao { get; set; }
        public int? CodigoMunicipioIbge { get; set; }
        public string? DataInicioAtividade { get; set; }
        public string? DataSituacaoEspecial { get; set; }
        public string? DataOpcaoPeloSimples { get; set; }
        public string? DataSituacaoCadastral { get; set; }
        public string? NomeCidadeNoExterior { get; set; }
        public int? CodigoNaturezaJuridica { get; set; }
        public string? DataExclusaoDoSimples { get; set; }
        public int? MotivoSituacaoCadastral { get; set; }
        public string? EnteFederativoResponsavel { get; set; }
        public int? IdentificadorMatrizFilial { get; set; }
        public int? QualificacaoDoResponsavel { get; set; }
        public string? DescricaoSituacaoCadastral { get; set; }
        public string? DescricaoTipoDeLogradouro { get; set; }
        public string? DescricaoMotivoSituacaoCadastral { get; set; }
        public string? DescricaoIdentificadorMatrizFilial { get; set; }
    }
}