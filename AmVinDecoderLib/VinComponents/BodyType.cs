using AmVinDecoderLib.VinComponents.Enum;

namespace AmVinDecoderLib.VinComponents
{
    public class BodyType : BaseVinComponent
    {
        public int DoorCount { get; internal set; }

        public BodyStyle BodyStyle { get; internal set; }
    }
}
