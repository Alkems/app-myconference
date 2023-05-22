using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Speaker
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public string Company { get; set; }
        public string Image { get; set; } = "https://static.wikia.nocookie.net/clashroyale/images/3/30/HogRiderCard.png/revision/latest?cb=20171212204811";
    }
}
