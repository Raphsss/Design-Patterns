using System;

namespace DesignPatterns.State
{
    class Player
    {
        public IPlayerState State { get; private set; }

        public Player()
        {
            State = new StoppedState();
            Console.WriteLine($"Estado inicial: {State.Name}");
        }

        public void SetState(IPlayerState state)
        {
            State = state;
            Console.WriteLine($"Estado atual: {State.Name}");
        }

        public void Play() => State.Play(this);
        public void Pause() => State.Pause(this);
        public void Stop() => State.Stop(this);
    }
}
