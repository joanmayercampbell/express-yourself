using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressYourself
{
    class MediaItem
    {
        public string Title { get; set; }
        public string MediaType { get; set; }
        public string Publisher { get; set; }

        public MediaItem()
        {
            Title = null;
            MediaType = null;
        }

    }

    class BookType: MediaItem
    {
        public string Author { get; set; }
        public int Length { get; set; }
        public int CopyRight { get; set; }

        public BookType()
        {

        }
    }

    class MagazineType: MediaItem
    {
       
        public string Edition { get; set; }
        public int Length { get; set; }

        public MagazineType()
        {

        }

    }

    class DVDType: MediaItem
    {
        
        public int Length { get; set; }

        public DVDType()
        {

        }
    }
}
