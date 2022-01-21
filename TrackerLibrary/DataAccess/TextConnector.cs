using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;

namespace TrackerLibrary.DataAccess
{
    class TextConnector : IDataConnection
    {
        private const string PrizesFile = "PrizeModels.csv";

        /// <summary>
        /// Saves a new prize to a text file
        /// </summary>
        /// <param name="model">The prize information</param>
        /// <returns>The prize information plus the unique identifier.</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            //Load the text file
            //Convert the text to List<PrizeModel>
            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

            //Find the max ID
            int currentId = 1;

            if (prizes.Count > 0)
            {
                currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = currentId;

            //Add the new record with the new ID (max + 1)
            prizes.Add(model);

            //Convert the prizes to List<string>
            //Save the List<string> to the new file
            prizes.SaveToPrizeFile(PrizesFile);

            return model;
        }
    }
}
