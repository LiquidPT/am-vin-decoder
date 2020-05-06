using System;

namespace AmVinDecoderLib.VinComponents
{
    public class ModelYear: BaseVinComponent
    {
        private new readonly char _vinCode;

        public ModelYear(char vinCode)
        {
            if (!char.IsLetterOrDigit(vinCode))
            {
                throw new ArgumentOutOfRangeException(nameof(vinCode), "Expecting a letter or digit");
            }

            _vinCode = vinCode;
        }

        protected override string GetText()
        {
            int digit = (int)char.GetNumericValue(_vinCode);
            if (digit > -1)
            {
                return (2000 + digit).ToString();
            }

            if (char.IsLetter(_vinCode))
            {
                int index = char.ToUpper(_vinCode) - 65;
                return (index + 2010).ToString();
            }

            throw new ArgumentException("Unrecognized model year code.");
        }
    }
}
