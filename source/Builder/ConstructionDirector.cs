using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.source.Builder
{
    class ConstructionDirector
    {
        private Builder builder;
        public ConstructionDirector(Builder b)
        {
            builder = b;
        }

        public void ChangeBuilder(Builder newBuilder)
        {
            builder = newBuilder;
        }

        public void MakeBuild(int cash)
        {
            builder.BuildBase();
            builder.BuildWall();
            
            if (cash >= 1000)
            {
                builder.BuildRoof();
            }
        }
    }
}
