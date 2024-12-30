using UnityEngine;

public class Maldicao : Porta
{
    public Efeito Efeito { get; set; }

    public Maldicao(string nome, string tipo, bool jogavel, Efeito efeito) : base(nome, tipo, jogavel)
    {
        Efeito = efeito;
    }

    public void AtivaMaldicao(Jogador jogador)
    {
        // Implementação futura
    }
}
