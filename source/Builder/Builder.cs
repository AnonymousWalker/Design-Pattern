using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.source.Builder
{
    interface Builder
    {
        public void BuildBase();
        public void BuildRoof();
        public void BuildWall();
    }
}
