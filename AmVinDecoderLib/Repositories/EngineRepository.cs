using AmVinDecoderLib.Utilities;
using AmVinDecoderLib.VinComponents;

namespace AmVinDecoderLib.Repositories
{
    public class EngineRepository : BaseRepository<Engine>
    {
        public static Engine Lookup(char vinCode)
        {
            var validatedVinCode = LookupUtility.ValidateLetterVinCode(vinCode);
            return InitializeData()[validatedVinCode];
        }
    }
}
