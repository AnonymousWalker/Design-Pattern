using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.source.FactoryMethod
{
    class AudioFactory : TranslationFactory
    {
        public override TranslationProduct createTranslation()
        {
            return new AudioTranslation();
        }
    }
}
