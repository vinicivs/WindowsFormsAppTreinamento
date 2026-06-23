using ClassLibraryMd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceTreinamento
{
    [ServiceContract]
    public interface ICepService
    {
        [OperationContract] void InserirCep(MdClass cep);
        [OperationContract] List<MdClass> ListarCeps();
        [OperationContract] void AtualizarCep(MdClass cep);
        [OperationContract] void ExcluirCep(int id);
    }
}
