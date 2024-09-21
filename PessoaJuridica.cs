namespace Atividade;

using System;

public class PessoaJuridica : Clientes
{
    public string cnpj { get; set; }
    public string ie { get; set; }

    public override void PagarImposto(float v)
    {
        this.valor = v;
        this.valorImposto = this.valor * 20 / 100;
        this.total = this.valor + this.valorImposto;
    }
}
