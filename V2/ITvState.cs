namespace TVSetsStatePattern.V2
{
    public interface ITvState
    {
        void SoundUp(TVset tvSet);
        void ChannelUp(TVset tvSet);
        void Toggle(TVset tvSet);
    }
}