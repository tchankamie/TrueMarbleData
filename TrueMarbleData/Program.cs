using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrueMarbleLibrary;

namespace TrueMarbleData
{
    class Program
    {
        static void Main(string[] args)
        {


            //int tileX = 10;
            //int tileY = 20;
            //int numTilesX;
            //int numTilesY;
            //int width;
            //int height;
            //byte[] imageBuf;
            //int bufSize = 100;
            //int jpgSize;
            //int zoomLevel = 10;

            //string generateJPGPath = TrueMarble.generateJPGPath(2, tileX, tileY );
            //int getNumTiles = TrueMarble.GetNumTiles(zoomLevel, out numTilesX, out numTilesY);
            //int getTileSize = TrueMarble.GetTileSize(out width, out height);
            //int getTileImageAsRawJPG = TrueMarble.GetTileImageAsRawJPG(zoomLevel, tileX, tileY, out imageBuf, bufSize, out jpgSize );
            
            var zoomLevel = 3;
            var tileX = 3000000;
            var tileY = 3000000;
            var bufSize = tileX * tileY *3 ;

            TMDataControllerImpl obj = new TMDataControllerImpl(zoomLevel, tileX, tileY, bufSize);

            var GetTileWidth = obj.GetTileWidth();
            var GetTileHeight = obj.GetTileHeight();
            var GetNumTilesAcross = obj.GetNumTilesAcross(zoomLevel);
            var GetNumTilesDown = obj.GetNumTilesDown(zoomLevel);
            var LoadTile = obj.LoadTile(zoomLevel, tileX, tileY);

            Console.WriteLine("TileWidth: " + GetTileWidth);
            Console.WriteLine("TileHeight: " + GetTileHeight);
            Console.WriteLine("NumTilesAcross: " + GetNumTilesAcross);
            Console.WriteLine("NumTilesDown: " + GetNumTilesDown);
            Console.WriteLine("LoadTile: " + LoadTile.ToString());

            Console.ReadKey();

        }
    }
}
