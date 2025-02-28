using System.ComponentModel;
using System.Reflection;

namespace Automatiza.Enum
{
    public enum CargosEnum
    {
        [Description("Assistente de Atendimento")]
        AssistenteAtendimento = 1,

        [Description("Caixa Tesoureiro")]
        CaixaTesoureiro,

        [Description("Caixa")]
        Caixa,

        [Description("Gerente de PA")]
        GerentePA,

        [Description("Gerente de Contas")]
        GerenteContas,

        [Description("Gerente Administrativo")]
        GerenteAdministrativo,

        [Description("Estagiário")]
        Estagiario,


        [Description("Permissão Temporária Gerente Administrativo")]
        TesoureitoXGerenteAdm,


        [Description("Permissão Temporária Gerente PA")]
        GerenteContasXGerentePA,


        [Description("Permissão Temporária Tesoureiro")]
        CaixaXTesoureiro,
    }

    public static class EnumExtensions
    {
        public static string GetDescription(this CargosEnum value)
        {
            FieldInfo field = value.GetType().GetField(value.ToString());
            if (field != null)
            {
                DescriptionAttribute attribute = field.GetCustomAttribute<DescriptionAttribute>();
                if (attribute != null)
                {
                    return attribute.Description;
                }
            }
            return value.ToString();
        }
    }
}