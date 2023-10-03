using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain
{
    public class Disco
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public  DateTime LaunchDate { get; set; }
        [DisplayName("Launch Date")]
        public int NumberTrack { get; set; }
        [DisplayName("Numbre Track")]
        public string UrlImage { get; set; }
    }
}
