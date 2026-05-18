using System;

namespace DesignPatterns.State
{
    class PlayingState : IPlayerState
    {
        public string Name => "Playing";

        public void Play(Player player)
        {
            Console.WriteLine("Já está tocando.");
        }

        public void Pause(Player player)
        {
            Console.WriteLine("Pausando...");
            player.SetState(new PausedState());
        }

        public void Stop(Player player)
        {
            Console.WriteLine("Parando...");
            player.SetState(new StoppedState());
        }
    }
}
