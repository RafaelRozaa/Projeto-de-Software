using UnityEngine;

public class Monstro : Porta
{
    public int Poder { get; set; }
    public Efeito Habilidade { get; set; }
    public Efeito BadStuff { get; set; }
    public int Recompensa1 { get; set; }
    public int Recompensa2 { get; set; }
    public int Recompensa3 { get; set; }

    public Monstro(string nome, string tipo, bool jogavel, int poder, Efeito habilidade, Efeito badStuff, int recompensa1, int recompensa2, int recompensa3) : base(nome, tipo, jogavel)
    {
        Poder = poder;
        Habilidade = habilidade;
        BadStuff = badStuff;
        Recompensa1 = recompensa1;
        Recompensa2 = recompensa2;
        Recompensa3 = recompensa3;
    }

    public void AtivaHabilidade()
    {
        // Implementação futura
    }

    public void AtivaBadStuff(Jogador jogador)
    {
        // Implementação futura
    }
}
