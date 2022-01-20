using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp
{
    public interface IConverter<TInput, TOutput>
    {
        TOutput Convert(TInput  input);
    }
}
