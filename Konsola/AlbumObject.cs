using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konsola
{
    public class AlbumObject
    {
        public string Artist { get; set; }
        public string Album { get; set; }
        public int SongsNumber {  get; set; }
        public DateTime Year { get; set; }
        public int DownloadNumber {  get; set; }
    }
}
