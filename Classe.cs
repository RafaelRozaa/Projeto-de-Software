using UnityEngine;

public class Classe : Porta
{
    public Efeito Habilidade1 { get; set; }
    public Efeito Habilidade2 { get; set; }

    public Classe(string nome, string tipo, bool jogavel, Efeito habilidade1, Efeito habilidade2) : base(nome, tipo, jogavel)
    {
        Habilidade1 = habilidade1;
        Habilidade2 = habilidade2;
    }

    public void AtivaClasse(Jogador jogador)
    {
        // Implementação futura
    }

    public void AtivaH1(Jogador jogador, Restricao restricao){
        // Implementação futura
    }

    public void AtivaH2(Jogador jogador, Restricao restricao){
        // Implementação futura
    }

    public void RemoveClasse(Jogador jogador)
    {
        // Implementação futura
    }
}
