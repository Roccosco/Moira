using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moira.Dominio
{
    public class Cerimonia 
    {
        private string codiceUnivoco;
        private string nome;
        private string descrizione;
        private int codiceProgressivo = 0;
        private DateTime data;
        private List<Cliente> clienti;
        private TipoCerimonia tipo;
        
       

        public Cerimonia(string nome, string descrizione, TipoCerimonia tipo, DateTime data)
        {
            codiceUnivoco = (codiceProgressivo++).ToString();
            this.nome = nome;
            this.descrizione = descrizione;
            this.data = data;
            clienti = new List<Cliente>();
            this.tipo= tipo;
            
        }

        

        public void AggiungiCliente(Cliente cliente) => clienti.Add(cliente);
    }
    public enum TipoCerimonia
    {
        standUp,
        review,
        sporadica
    }
}
