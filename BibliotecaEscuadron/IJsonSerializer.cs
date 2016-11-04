using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp.Deserializers;
using RestSharp.Serializers;

namespace BibliotecaEscuadron
{
    public interface IJsonSerializer : ISerializer, IDeserializer
    {

    }
}
