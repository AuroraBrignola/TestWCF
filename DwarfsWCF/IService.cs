using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace DwarfsWCF
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        MemoryStream GetStream(string path);

        [OperationContract]
        string GetString(string text);
    }
}
