using CL.Models;
using System.Collections.Generic;

namespace BL.Business.Converter
{
    public abstract class AConverter
    {
        public abstract void Converter(ref List<Alive> returnData);
    }
}
