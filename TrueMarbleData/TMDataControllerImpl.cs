using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrueMarbleLibrary;

namespace TrueMarbleData
{
    class TMDataControllerImpl : ITMDataController
    {

        // zoomLevel,tileX ,tileY, bufSize



        private static int tileX;
        private static int tileY;
        private static int numTilesX;
        private static int numTilesY;
        private static int width;
        private static int height;
        private static byte[] imageBuf;
        private static int bufSize;
        private static int jpgSize;
        private static int zoomLevel;



        public TMDataControllerImpl(int zoomLevel, int tileX, int tileY, int bufSize)
        {
            TMDataControllerImpl.zoomLevel = zoomLevel;
            TMDataControllerImpl.tileX = tileX;
            TMDataControllerImpl.tileY = tileY;
            TMDataControllerImpl.bufSize = bufSize;


            TrueMarble.generateJPGPath(zoomLevel, TMDataControllerImpl.tileX, TMDataControllerImpl.tileY);
            TrueMarble.GetNumTiles(zoomLevel, out TMDataControllerImpl.numTilesX, out TMDataControllerImpl.numTilesY);
            TrueMarble.GetTileSize(out TMDataControllerImpl.width, out TMDataControllerImpl.height);
            TrueMarble.GetTileImageAsRawJPG(zoomLevel, tileX, tileY, out TMDataControllerImpl.imageBuf, TMDataControllerImpl.bufSize, out TMDataControllerImpl.jpgSize);
        }

        public int GetNumTilesAcross(int zoom)
        {
            TrueMarble.GetNumTiles(zoom, out TMDataControllerImpl.numTilesX, out TMDataControllerImpl.numTilesY);
            return TMDataControllerImpl.numTilesX;
        }

        public int GetNumTilesDown(int zoom)
        {
            TrueMarble.GetNumTiles(zoom, out TMDataControllerImpl.numTilesX, out TMDataControllerImpl.numTilesY);
            return TMDataControllerImpl.numTilesY;
        }

        public int GetTileHeight()
        {
            return TMDataControllerImpl.height;
        }

        public int GetTileWidth()
        {
            return TMDataControllerImpl.width;
        }

        public byte[] LoadTile(int zoom, int x, int y)
        {
            TrueMarble.GetTileImageAsRawJPG(zoom, x, y, out TMDataControllerImpl.imageBuf, TMDataControllerImpl.bufSize, out TMDataControllerImpl.jpgSize);
            return TMDataControllerImpl.imageBuf;
        }
    }
}
