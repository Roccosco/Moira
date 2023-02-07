using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moira.Dominio.Controllers
{
    public class ClienteHandler
    {
        private MoiraClass moira;
        private Cliente clienteCorrente;

        public ClienteHandler()
        {
            moira = MoiraClass.Instance;
        }

        public Cliente ClienteCorrente { get => clienteCorrente; }

        public void CreaCliente(string nome, string cognome, string email, string partitaIVA, string numeroTelefono, string indirizzo) => clienteCorrente = new Cliente(nome, cognome, email, partitaIVA, numeroTelefono, indirizzo);

        public void AssociaClienteAProgetto(string nomeProgetto)
        {
            try
            {
                Progetto progetto = moira.GetProgettoSpecifico(nomeProgetto);
                progetto.SetCliente(clienteCorrente);
            }
            catch (KeyNotFoundException e)
            {
                throw e;
            }
        }

        public void ConfermaCreaCliente() => moira.addCliente(clienteCorrente);

        public void SelezionaClienteCorrente(string codiceCliente)
        {
            try
            {
                clienteCorrente = moira.GetClienteSpecifico(codiceCliente);
            }
            catch (KeyNotFoundException e)
            {
                throw e;
            }
        }

        public void ResetInfoCliente(string email, string partitaIVA, string numeroTelefono, string indirizzo)
        {
            clienteCorrente.Email = email;
            clienteCorrente.PartitaIVA = partitaIVA;
            clienteCorrente.Telefono = numeroTelefono;
            clienteCorrente.Indirizzo = indirizzo;
        }

        public void DisassociaClienteAProgetto(string nomeProgetto)
        {
            try
            {
                Progetto progetto = moira.GetProgettoSpecifico(nomeProgetto);
                progetto.removeCliente(clienteCorrente);
            }
            catch (KeyNotFoundException e)
            {
                throw e;
            }
        }


        public void EliminaCliente(string codiceClente)
        {
            try
            {
                moira.deleteCliente(codiceClente);
            }
            catch (KeyNotFoundException e)
            {
                throw e;
            }
        }

        public List<Cliente> GetClienti() => moira.GetClienti();

    }
}
