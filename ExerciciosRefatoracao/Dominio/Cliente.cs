namespace ExerciciosRefatoracao.Dominio
{
    public class Cliente
    {

        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Codigo { get; private set; }

        public Endereco CriarEndereco( )
        { 
            return new Endereco();
        }
        
        public override string ToString()
        {
            var end = new Endereco();
            return "===Dados do Cliente===\n" +
                   $"CPF: {CPF}\n" +
                   $"Nome: {Nome}\n" +
                   $"{end.GetTextoEndereco()}\n";

        }
    }

    public class Endereco
    {
        public string GetTextoEndereco()
        {
            return $"Endereço: {Logradouro} {Numero} {Complemento} - {Bairro} - CEP {CEP} - {Municipio} - {UF}";
        }
    
        public void SetEndereco(string tipoEnd, string endLogradouro, string endNumero, string endComplemento, string endBairro, string endCEP, string endMunicipio, string endUF)
        {
            Logradouro = endLogradouro;
            Numero = endNumero;
            Complemento = endComplemento;
            Bairro = endBairro;
            CEP = endCEP;
            Municipio = endMunicipio;
            UF = endUF;
            TipoEnd = tipoEnd;
        }

        public string Logradouro { get; private set; }
        public string Numero { get; private set; }
        public string Complemento { get; private set; }
        public string Bairro { get; private set; }
        public string CEP { get; private set; }
        public string Municipio { get; private set; }
        public string UF { get; private set; }
        public string TipoEnd { get; set; }

    }
}
