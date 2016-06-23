namespace TVSetsStatePattern.V4
{
    public interface ITvState
    {
        void SoundUp(TVset tvSet);
        void ChannelUp(TVset tvSet);
        void Toggle(TVset tvSet);
    }
}