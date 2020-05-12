using AmVinDecoderLib.VinComponents;
using System;

namespace AmVinDecoderLib.VinLookup
{
    public class RestraintSystemLookup
    {
        public static RestraintSystem Lookup(char vinCode, string modelYear, char? modelCode)
        {
            var validatedVinCode = LookupUtility.ValidateLetterVinCode(vinCode);


            int intModelYear = 0;
            if (!string.IsNullOrWhiteSpace(modelYear) && !int.TryParse(modelYear, out intModelYear))
            {
                throw new ArgumentOutOfRangeException(nameof(modelYear), "Expecting numeric year");
            }

            if (modelCode.HasValue && !char.IsLetter(modelCode.Value))
            {
                throw new ArgumentOutOfRangeException(nameof(modelCode), "Expecting a letter");
            }

            return new RestraintSystem
            {
                Text = GetText(validatedVinCode, intModelYear, char.ToUpperInvariant(modelCode.GetValueOrDefault()))
            };
        }

        private static string GetText(string validatedVinCode, int modelYear, char modelCode)
        {
            switch (validatedVinCode)
            {
                  case "A":
                    return "2+2 seating. Front & side (in seats) airbags +  3-point ELR seatbelts with pyro-pretensioner for driver/  passenger (+ALR pass.) + rear seatbelts (ELR/ALR).";
                case "B":
                    return "2+0 seating. Front & side (in seats) airbags +  3-point ELR seatbelts with pyro-pretensioner for driver/  passenger (+ALR pass.).";
                case "E":
                    var eDesc = "2+0 seating. Front & side (in seats) airbags +  3-point ELR seatbelts with pyro-pretensioner for driver/  passenger (+ALR pass.).";
                    if (modelYear >= 2013)
                    {
                        eDesc += " +dual pretensioners / dual stage load limiters for the seat belts.";
                    }
                    return eDesc;
                case "F":
                    var fDesc = "2+2 seating. Front & side (in seats) airbags +  3-point ELR seatbelts with pyro-pretensioner for driver/  passenger (+ALR pass.) + rear seatbelts (ELR/ALR).";
                    if (modelYear >= 2013)
                    {
                        fDesc += " +dual pretensioners / dual stage load limiters for the seat belts.";
                    }
                    return fDesc;
                case "G":
                    return "2+0 seating. Front airbags +  3-point ELR seatbelts with pyro-pretensioner for driver/  passenger (+ALR pass.) (light weight seats).";
                case "H":
                    return "4-seater Front & side (in seats) airbags +  3-point ELR seatbelts with pyro-pretensioner for driver/  passenger (+ALR pass.) + rear seatbelts (ELR/ALR) + side curtain in pass & drvr  + both rear doors, pyro-pretension rear seatbelts.";
                case "K":
                    return "2+0 seating. Front & side (in seats) airbags +  3-point ELR seatbelts with pyro-pretensioner for driver/  passenger (+ALR pass.) + dual  pretensioners/dual stage load limiters + curtain side airbags in the cantrails.";
                case "L":
                    return "2+2 seating. Front & side (in seats) airbags +  3-point ELR seatbelts with pyro-pretensioner for driver/  passenger (+ALR pass.) + rear seatbelts (ELR/ALR) + curtain side  airbags in the cantrails.";
                case "N":
                    return "2+0 seating. Front & side (in seats) airbags +  3-point ELR seatbelts with pyro-pretensioner for driver/  passenger (+ALR pass.) + dual  pretensioners/dual stage load limiters + curtain side airbags in the doors.";
                case "P":
                    return "2+2 seating. Front & side (in seats) airbags +  3-point ELR seatbelts with pyro-pretensioner for driver/  passenger (+ALR pass.) + rear seatbelts (ELR/ALR) + curtain side  airbags in the doors.";
                case "R":
                    var rDesc = "2+2 Airbags Drv/Pass: Front, knee, side (in  seat & cantrail) Seat belts Drv/Pass: 3point ELR, pyropretensioners (Retractor & Sill), singlestage load limiter within retractor (+ ALR pass) Rear Pass: 3point ALR.";
                    if (modelCode.Equals('M')) // DB11 Volante
                    {
                        rDesc += " +Roll Bars & Cantrail airbag in doors.";
                    }
                    return rDesc;
                case "S":
                    return "2+0 Airbags Drv/Pass: Front, knee, side (in  seat & cantrail) Seat belts Drv/Pass: 3point ELR, pyropretensioners (Retractor & Sill), singlestage load limiter  within retractor (+ ALR pass)";

                default: throw new ArgumentException("Unrecognized reatraint code.");
            }
        }
    }
}
