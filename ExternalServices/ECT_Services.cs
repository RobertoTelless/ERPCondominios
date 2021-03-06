using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesServices.Model;
using Correios.Net;
using ModelServices.Interfaces.ExternalServices;
using EntitiesServices.Work_Classes;

namespace ExternalServices
{
    /// <summary>
    /// The ECT services class.
    /// </summary>
    public static class ECT_Services
    {
        /// <summary>
        /// Gets the adress cep.
        /// </summary>
        /// <param name="CEP">The cep.</param>
        /// <returns></returns>
        public static Address GetAdressCEP(string CEP)
        {
            Address endereco = SearchZip.GetAddress(CEP, 10000);
            return endereco;
        }

        /// <summary>
        /// Gets the adress cep service.
        /// </summary>
        /// <param name="CEP">The cep.</param>
        /// <returns></returns>
        public static Endereco GetAdressCEPService(string CEP)
        {
            Endereco endereco = null;
            try
            {
                var ws = new WSCorreios.AtendeClienteClient();
                var resposta = ws.consultaCEP(CEP);
                endereco = new Endereco();
                endereco.ENDERECO = resposta.end;
                endereco.NUMERO = String.Empty;
                endereco.COMPLEMENTO = resposta.complemento2;
                endereco.BAIRRO = resposta.bairro;
                endereco.CIDADE = resposta.cidade;
                endereco.UF = resposta.uf;
                endereco.CEP = CEP;
                return endereco;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
