using System;

namespace DesignPatterns.State
{
    class PausedState : IPlayerState
    {
        public string Name => "Paused";

        public void Play(Player player)
        {
            Console.WriteLine("Retomando reprodução...");
            player.SetState(new PlayingState());
        }

        public void Pause(Player player)
        {
            Console.WriteLine("Já está pausado.");
        }

        public void Stop(Player player)
        {
            Console.WriteLine("Parando a partir do estado pausado...");
            player.SetState(new StoppedState());
        }
    }
}
