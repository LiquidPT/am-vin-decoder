using System;

namespace AmVinDecoderLib.VinComponents
{
    public class Factory : BaseVinComponent
    {
        public Factory(char vinCode)
            : base(vinCode)
        {
        }

        protected override string GetText()
        {
            switch (_vinCode)
            {
                case "A": return "Austria, Magna Steyr";
                case "G": return "Gaydon";
                default: throw new ArgumentException("Unrecognized factory code.");
            }
        }
    }
}
