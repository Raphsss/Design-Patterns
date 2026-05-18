using System;

namespace DesignPatterns.State
{
    public class Program
    {
        static void Main(string[] args)
        {
            var player = new Player();

            player.Play();   // inicia reprodução
            player.Pause();  // pausa
            player.Play();   // retoma
            player.Stop();   // para
            player.Pause();  // tentativa de pausar quando parado
        }
    }
}
