using Automatiza.Enum;

namespace Automatiza.Model
{
    public class UsuarioModel
    {
        public string UsuarioSisbr { get; set; } = string.Empty;
        public CargosEnum CargoAcesso { get; set; }
        public string NomeIdentificador { get; set; } = string.Empty;
        public string BasePA { get; set; } = string.Empty;
        public bool AlterarBasePA { get; set; }
    }
}
