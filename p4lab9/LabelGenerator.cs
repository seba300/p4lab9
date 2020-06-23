using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace p4lab9
{
    public class LabelGenerator:IControlGenerator
    {
        public LabelGenerator()
        {

        }
        public Control Generate()
        {
            return new Label()
            {
                Content = "MyLabel",
                Width=100,
                Height=50
            };
        }
    }
}
