﻿using System.Collections.Generic;

namespace UserApp.Shared.Models
{
    public class PlaceDetails : Place
    {
        public string Text
        {
            get;
            set;
        }

        public string Description
        {
            get;
            set; 
        }

        public string PhoneNumber
        {
            get;
            set;
        }

        public IEnumerable<PictureSource> PicturesUrls
        {
            get;
            set;
        }
    }
}
