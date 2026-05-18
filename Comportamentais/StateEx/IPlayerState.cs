namespace DesignPatterns.State
{
    interface IPlayerState
    {
        void Play(Player player);
        void Pause(Player player);
        void Stop(Player player);
        string Name { get; }
    }
}
