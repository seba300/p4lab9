using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace p4lab9
{
    public class ButtonGenerator: IControlGenerator
    {
        public Control Generate()
        {
            return new Button()
            {
                Content = "MyButton",
                Width = 100,
                Height = 50
            };
        }
    }
}
