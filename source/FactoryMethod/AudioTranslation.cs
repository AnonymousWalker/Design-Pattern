using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.source.FactoryMethod
{
    class AudioTranslation : TranslationProduct
    {
        public string Format()
        {
            return "audio/mpeg";
        }

        public string Title()
        {
            return "Oral translation";
        }
    }
}
