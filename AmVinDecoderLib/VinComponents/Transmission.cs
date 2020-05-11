using System;

namespace AmVinDecoderLib.VinComponents
{
    public class Transmission : BaseVinComponent
    {
        private readonly bool _isV12VantageS;

        public Transmission(char vinCode, bool isV12VantageS = false)
            : base(vinCode)
        {
            _isV12VantageS = isV12VantageS;
        }

        protected override string GetText()
        {
            switch (_vinCode)
            {
                case "A":
                case "B":
                    return "Manual";
                case "C":
                case "D":
                    return "Auto";
                case "E":
                case "F":
                    return "Sportshift";
                case "J":
                case "K":
                    return _isV12VantageS ? "Sportshift III" : "Sportshift II";
                case "L":
                case "M":
                    return "8-speed Auto";
                default: throw new ArgumentException("Unrecognized transmission code.");
            }
        }
    }
}
