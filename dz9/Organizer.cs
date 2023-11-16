using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz9
{
    internal class Organizer 
    {
        string name = "оливье ганьян";
        public void AddNewFishing()
        {
            Fishing fishing = new Fishing();
        }
        public void AddNewMouseTrap()
        {
            MouseTrap trap = new MouseTrap();
        }
        public void AddNewSea()
        {
            Sea sea = new Sea();
        }
        public void AddNewSlide()
        {
            Slide slide = new Slide();
        }
        public void AddNewBeach()
        {
            Beach beach = new Beach();
        }
        public void AddNewPostmen()
        {
            Postmen postmen = new Postmen();
        }
    }
}
