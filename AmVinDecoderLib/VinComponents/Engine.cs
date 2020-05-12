using AmVinDecoderLib.VinComponents.Enum;

namespace AmVinDecoderLib.VinComponents
{
    public class Engine : BaseVinComponent
    {
        public int Cylinders { get; set; }

        public Induction Induction { get; set; }

        public decimal Displacement { get; set; }

        public decimal Power { get; set; }

        public decimal Torque { get; set; }
    }
}
