using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.source.FactoryMethod
{
    class TextTranslation : TranslationProduct
    {
        public string Format()
        {
            return "text/plain";
        }

        public string Title()
        {
            return "Text translation";
        }
    }
}
