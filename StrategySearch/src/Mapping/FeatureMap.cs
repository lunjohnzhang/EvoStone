using System.Collections.Generic;

using StrategySearch.Search;

namespace StrategySearch.Mapping
{
   interface FeatureMap
   {
      int NumGroups { get; }
      int NumFeatures { get; }
      Dictionary<string, Individual> EliteMap { get; }
      Dictionary<string, int> CellCount { get; }

      bool Add(Individual toAdd);
      Individual GetRandomElite();
   }
}
