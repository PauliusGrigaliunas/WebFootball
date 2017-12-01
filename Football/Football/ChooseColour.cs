using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Football.ColourPalet;

namespace Football
{
    public class ChooseColour
    {
        ColourPalet colourPalet = new ColourPalet();

        public enum Choices
        {
            Orange,
            Yellow,
            Dark
        }


        public ColourStruct Controler(int index) // comboBox1.SelectedIndex;
        {
            switch (index)
            {
                case 0:
                    return colourPalet.Colour[0];
                case 1:
                    return colourPalet.Colour[1];
                case 2:
                    return colourPalet.Colour[2];
                default:
                    return colourPalet.Colour[0];
            }

        }
    }
}
