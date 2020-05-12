using AmVinDecoderLib.VinComponents;
using System;

namespace AmVinDecoderLib.VinLookup
{
    public class EngineLookup
    {
        public static Engine Lookup(char vinCode)
        {
            var validatedVinCode = LookupUtility.ValidateLetterVinCode(vinCode);

            return new Engine
            {
                Text = GetText(validatedVinCode)
            };
        }

        private static string GetText(string validatedVinCode)
        {
            switch (validatedVinCode)
            {
                case "A": return "V12 AM04";
                case "B": return "AM05 - 4.3";
                case "C": return "AM07 - 4.7";
                case "D": return "V12(DBS) AM08";
                case "E": return "V12 AM09";
                case "F": return "V12(Vantage) AM10";
                case "G": return "GAM05 - 4.3 N400 spec";
                case "J": return "V12(Rapide) AM16";
                case "K": return "4.7(011MY Euro 5) AM14";
                case "L": return "4.7(V8S spec) AM15";
                case "M": return "V12(DB9 13MY +) AM11";
                case "N": return "V12(Virage) AM25";
                case "P": return "V12(Vanquish) AM11";
                case "U": return "(Vanquish 15MY - AM29)";
                case "R": return "V12 Vantage S AM28 ";
                case "T": return "V12(Rapide S) AM11";
                case "S": return "(RapideS 15MY - AM29)";
                case "V": return "V12 Twin Turbo AE31";
                case "W": return "V8 Twin Turbo -177590";
                case "Z": return "Vanquish S(Zagato) AM27";
                default: throw new ArgumentException("Unrecognized engine code.");
            }
        }
    }
}
