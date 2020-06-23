using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace p4lab9
{
   public class PanelFiller:IPanelFiller
    {
        private readonly IControlGenerator _controlGenerator;

        public PanelFiller(IControlGenerator controlGenerator)
        {
            _controlGenerator = controlGenerator;
        }
        public void Fill(Panel panel,int number)
        {
            for (int i = 0; i < number; i++)
            {
                panel.Children.Add(_controlGenerator.Generate());
            }
        }
    }
}
