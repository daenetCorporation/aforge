using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AForge.Neuro
{
    public interface INetworkSerializer
    {
        Network Load(string fileName);

        void Save(Network network, string fileName);
    }
}
