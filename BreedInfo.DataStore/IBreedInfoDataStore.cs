using System;
using BreedInfo.DomainModels;
namespace BreedInfo.DataStore
{
    public interface IBreedInfoDataStore
    {
        BreedInformation GetBreedInfo(string breedName);
        
    }
}
