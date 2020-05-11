using AmVinDecoderLib.VinComponents.Enum;
using System;

namespace AmVinDecoderLib.VinComponents
{
    public class Steering : BaseVinComponent
    {
        public Steering(char vinCode)
            : base(vinCode)
        {
        }

        protected override string GetText()
        {
            switch (_vinCode)
            {
                case "A":
                case "C":
                case "E":
                case "J":
                case "L":
                    return SteeringPosition.RHD.ToString();
                case "B":
                case "D":
                case "F":
                case "K":
                case "M":
                    return SteeringPosition.LHD.ToString();
                default: throw new ArgumentException("Unrecognized steering code.");
            }
        }
    }
}
