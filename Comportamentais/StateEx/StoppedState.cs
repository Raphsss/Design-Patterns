using System;

namespace DesignPatterns.State
{
    class StoppedState : IPlayerState
    {
        public string Name => "Stopped";

        public void Play(Player player)
        {
            Console.WriteLine("Iniciando reprodução...");
            player.SetState(new PlayingState());
        }

        public void Pause(Player player)
        {
            Console.WriteLine("Não é possível pausar: o player está parado.");
        }

        public void Stop(Player player)
        {
            Console.WriteLine("Já está parado.");
        }
    }
}
