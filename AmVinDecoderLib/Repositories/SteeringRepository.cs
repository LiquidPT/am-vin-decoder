using AmVinDecoderLib.Utilities;
using AmVinDecoderLib.VinComponents;

namespace AmVinDecoderLib.Repositories
{
    public class SteeringRepository : BaseRepository<Steering>
    {
        public static Steering Lookup(char vinCode)
        {
            var validatedVinCode = LookupUtility.ValidateLetterVinCode(vinCode);
            return InitializeData()[validatedVinCode];
        }
    }
}
