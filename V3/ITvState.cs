namespace TVSetsStatePattern.V3
{
    public interface ITvState
    {
        void SoundUp(TVset tvSet);

        void ChannelUp(TVset tvSet);
    }
}