using UnityEngine;

public class Raca : Porta
{
    public Efeito Habilidade1 { get; set; }
    public Efeito Habilidade2 { get; set; }

    public Raca(string nome, string tipo, bool jogavel, Efeito habilidade1, Efeito habilidade2) : base(nome, tipo, jogavel)
    {
        Habilidade1 = habilidade1;
        Habilidade2 = habilidade2;
    }

    public void AtivaRaca(Jogador jogador, Restricao restricao)
    {
        // Implementação futura
    }

    public void AtivaH1(Jogador jogador, Restricao restricao){
        // Implementação futura
    }

    public void AtivaH2(Jogador jogador, Restricao restricao){
        // Implementação futura
    }

    public void RemoveRaca(Jogador jogador)
    {
        // Implementação futura
    }
}
