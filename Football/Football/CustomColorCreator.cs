using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Football
{
    public class CustomColorCreator : Form
    {
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // CustomColorCreator
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "CustomColorCreator";
            this.ResumeLayout(false);

        }

        public CustomColorCreator()
        {
            InitializeComponent();
            FindColor();
        }

        private void FindColor()
        {
            int PointCounter = 0;

            while (PointCounter < 3)
            {
                RequestData();
                PointCounter++;
            }

            DoCalculations();

        }

        private void RequestData()
        {

        }

        private void DoCalculations()
        {

        }
    }
}
