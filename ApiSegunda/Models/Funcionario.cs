using System.Runtime.Serialization;

namespace ApiSegunda.Models
{
    [DataContract(Name = "Funcionario", Namespace = "http://localhost:61712/")]
    public class Funcionario : IExtensibleDataObject
    {
        public Funcionario(string cidade, int codigo, string nome, string setor, string sobrenome)
        {
            this.cidade = cidade;
            this.codigo = codigo;
            this.nome = nome;
            this.setor = setor;
            this.sobrenome = sobrenome;
        }

        [DataMember(Name = "Cidade")] private string cidade { get; set; }

        [DataMember(Name = "Codigo")] private int codigo { get; set; }

        [DataMember(Name = "Nome")] private string nome { get; set; }

        [DataMember(Name = "Setor")] private string setor { get; set; }

        [DataMember(Name = "Sobrenome")] private string sobrenome { get; set; }

        public ExtensionDataObject ExtensionData { get; set; }
    }
}