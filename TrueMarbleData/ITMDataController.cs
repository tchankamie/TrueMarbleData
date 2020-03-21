using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrueMarbleData
{
    public interface ITMDataController 
    {
      int GetTileWidth();
      int GetTileHeight();
      int GetNumTilesAcross(int zoom);
      int GetNumTilesDown(int zoom);
      byte[] LoadTile(int zoom, int x, int y);
    }
}
