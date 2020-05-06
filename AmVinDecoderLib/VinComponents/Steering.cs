using System;

namespace AmVinDecoderLib.VinComponents
{
    public class Steering : BaseVinComponent
    {
        private const string leftHandDrive = "LHD";
        private const string rightHandDrive = "RHD";

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
                    return rightHandDrive;
                case "B":
                case "D":
                case "F":
                case "K":
                case "M":
                    return leftHandDrive;
                default: throw new ArgumentException("Unrecognized steering code.");
            }
        }
    }
}
