using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.source.FactoryMethod
{
    abstract class TranslationFactory
    {
        public abstract TranslationProduct createTranslation();
    }
}
