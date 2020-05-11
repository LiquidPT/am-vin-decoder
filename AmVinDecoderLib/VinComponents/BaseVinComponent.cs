using System;

namespace AmVinDecoderLib.VinComponents
{
    public abstract class BaseVinComponent
    {
        protected readonly string _vinCode;

        public string Text {
            get
            {
                return GetText();
            }
        }

        public BaseVinComponent()
        {
        }

        public BaseVinComponent(char vinCode)
        {
            if (!char.IsLetter(vinCode))
            {
                throw new ArgumentOutOfRangeException(nameof(vinCode), "Expecting a letter code");
            }

            _vinCode = vinCode.ToString().ToUpperInvariant();
        }

        protected abstract string GetText();
    }
}
