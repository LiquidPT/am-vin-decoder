using AmVinDecoderLib.VinComponents;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace AmVinDecoderLib.Repositories
{
    public class BaseRepository<TFile>: BaseRepository<TFile, TFile> where TFile : BaseVinComponent 
    {
    }
}
