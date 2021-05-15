using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.source.FactoryMethod
{
    class TextFactory : TranslationFactory
    {
        public override TranslationProduct createTranslation()
        {
            return new TextTranslation();
        }
    }
}
