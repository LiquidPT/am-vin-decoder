using System;

namespace AmVinDecoderLib.VinComponents
{
    public class Model : BaseVinComponent
    {
        private readonly char _serialModifier;

        public bool IsV12VantageS
        {
            get
            {
                if (!_vinCode.Equals("S", StringComparison.OrdinalIgnoreCase))
                {
                    return false;
                }

                var sMod = _serialModifier;
                if (sMod == '0' || sMod == '2')
                {
                    return true;
                }

                return false;
            }
        }

        public Model(char vinCode, char? serialModifer)
            : base(vinCode)
        {
            if (serialModifer.HasValue && !char.IsDigit(serialModifer.Value))
            {
                throw new ArgumentOutOfRangeException(nameof(serialModifer), "Expecting a digit");
            }

            _serialModifier = serialModifer.GetValueOrDefault();
        }

        protected override string GetText()
        {
            switch (_vinCode)
            {
                case "A": return "DB9 Coupe";
                case "B": return "DB9 Volante";
                case "C": return "V8/V8S Coupe";
                case "D": return "V8/V8S Roadster";
                case "E":
                    {
                        switch (_serialModifier)
                        {
                            case '0': return "DBS Coupe";
                            case '1': return "DBS Volante";
                            default: return "DBS";
                        }
                    }
                case "F": return "Rapide";
                case "G": return "Virage Coupe";
                case "H": return "Virage Volante";
                case "J":
                    {
                        switch (_serialModifier)
                        {
                            case '3': return "Vanquish Zagato Coupe";
                            default: return "Vanquish Coupe";
                        }
                    }
                case "K": return "Vanquish Volante";
                case "L": return "DB11 Coupe";
                case "M": return "DB11 Volante";
                case "N": return "New Vantage Coupe";
                case "R": return "New DBS Coupe";
                case "S":
                    {
                        switch (_serialModifier)
                        {
                            case '0': return "V12 Vantage S Coupe";
                            case '1': return "V12 Vantage Roadster";
                            case '2': return "V12 Vantage S Roadster";
                            default: return "V12 Vantage Coupe";
                        }
                    }
                default: throw new ArgumentException("Unrecognized model code.");
            }
        }
    }
}
