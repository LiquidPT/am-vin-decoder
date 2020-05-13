using AmVinDecoderLib.Utilities;
using AmVinDecoderLib.VinComponents;

namespace AmVinDecoderLib.Repositories
{
    public class FactoryRepository : BaseRepository<Factory>
    {
        public static Factory Lookup(char vinCode)
        {
            var validatedVinCode = LookupUtility.ValidateLetterVinCode(vinCode);
            return InitializeData()[validatedVinCode];
        }
    }
}
