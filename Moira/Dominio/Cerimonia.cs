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
        private TimeSpan durata;
        private HashSet<Cliente> clienti;
        private TipoCerimonia tipo;
        
       

        public Cerimonia(string nome, string descrizione, TipoCerimonia tipo, DateTime data, TimeSpan durata)
        {
            codiceUnivoco = (codiceProgressivo++).ToString();
            this.nome = nome;
            this.descrizione = descrizione;
            this.data = data;
            this.durata = durata;
            clienti = new HashSet<Cliente>();
            this.tipo= tipo;
        }

        public DateTime Data { get => data; }

        public void AggiungiCliente(Cliente cliente)
        {
            if (!clienti.Add(cliente))
                throw new Exception("Cliente già invitato!");
        }
    }
    public enum TipoCerimonia
    {
        standUp,
        review,
        sporadica
    }
}
