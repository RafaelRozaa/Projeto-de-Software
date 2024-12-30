using UnityEngine;

public class Porta : Carta
{
    public string Tipo { get; set; }

    public Porta(string nome, string tipo, bool jogavel) : base(nome, jogavel)
    {
        Tipo = tipo;
    }

    public void JogarPorta()
    {
        // Implementação futura
    }
}
