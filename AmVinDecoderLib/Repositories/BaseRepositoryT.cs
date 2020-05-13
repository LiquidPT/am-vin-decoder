using AmVinDecoderLib.VinComponents;

namespace AmVinDecoderLib.Repositories
{
    public class BaseRepository<TFile> : BaseRepository<TFile, TFile> where TFile : BaseVinComponent
    {
    }
}
