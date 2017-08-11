using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Slot_Machine
{
    public partial class SlotMachine : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void PlayButton_Click(object sender, EventArgs e)
        {
            string image = spinReel();
            Reel1.ImageUrl = "/Images/" + image + ".png";
        }

        private string spinReel()
        {
            string[] images = new string[] { "Bar", "Bell", "Cherry", "Clover", "Diamond", "HorseShoe", "Lemon", "Orange", "Plum", "Seven", "Strawberry", "Watermellon" };
            Random random = new Random();
            return images[random.Next(11)];

        }
    }
}