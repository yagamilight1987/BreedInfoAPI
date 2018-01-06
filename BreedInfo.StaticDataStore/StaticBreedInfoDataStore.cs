using System;
using BreedInfo.DataStore;
using BreedInfo.DomainModels;
namespace BreedInfo.StaticDataStore
{
    public class StaticBreedInfoDataStore : IBreedInfoDataStore
    {
        private BreedInfoList breedInfoList;
        public StaticBreedInfoDataStore()
        {
            this.breedInfoList = new BreedInfoList();
        }

        public BreedInformation GetBreedInfo(string breedName)
        {
            return this.breedInfoList.getBreedInfo(breedName);
        }
    }
}
