using Moira.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moira.Dominio
{
    public class Board : Subject
    {
        private string codiceUnivoco;
        private string nome;
        private static int codiceProgressivo = 0;
        private List<Colonna> colonne;
        private MoiraTask taskCorrente;
        private Colonna colonnaCorrente;
        private HashSet<Observer> observers;

        public List<Colonna> Colonne { get => new List<Colonna>(colonne); }

        public Board(string nome)
        {
            codiceUnivoco = (codiceProgressivo++).ToString();
            this.nome = nome;

            colonne = new List<Colonna>();
            colonne.Add(new ColonnaBase("Cestinato"));

            observers = new HashSet<Observer>();
        }

        public void creaColonna(string nome, bool daRivedere)
        {
            ColonnaBase colonnaBase = new ColonnaBase(nome);

            if (daRivedere)
            {
                ColonnaConDaRivedere colonnaConDaRivedere = new ColonnaConDaRivedere(colonnaBase);
                colonne.Add(colonnaConDaRivedere);
            }
            else
                colonne.Add(colonnaBase);
        }

        public void creaColonna(string nome, bool daRivedere, int limiteTask)
        {
            Colonna colonna;

            ColonnaBase colonnaBase = new ColonnaBase(nome);
            colonna = colonnaBase;
            if (daRivedere)
                colonna = new ColonnaConDaRivedere(colonna);

            colonna = new ColonnaConLimite(colonna, limiteTask);

            colonne.Add(colonna);
        }

        public void setTaskCorrente(MoiraTask task)
        {
            taskCorrente = task;
        }

        public void addTaskColonna(string codiceColonna)
        {
            foreach (Colonna colonna in colonne)
            {
                if (colonna.ContieneCodiceIdentificativo(codiceColonna))
                {
                    colonna.addTask(taskCorrente);
                    Notify();
                    return;
                }
            }

            throw new Exception("Colonna non trovata");
        }

        public void Draw(Panel panel)
        {
            new BoardUI(this).Draw(panel);
        }

        public void SelezionaTask(string codiceTask, string codiceColonna)
        {
            Colonna colonna = null;
            foreach(Colonna cln in colonne)
            {
                if(cln.ContieneCodiceIdentificativo(codiceColonna))
                    colonna = cln;
            }
            
            if (colonna == null)
                throw new Exception("Non esiste una colonna con codice: " + codiceColonna);

            MoiraTask task = colonna.getTask(codiceTask);

            taskCorrente = task;
            colonnaCorrente = colonna;
        }

        public void SpostaTaskTraColonne(string codiceColonnaDestinazione, bool daRivedereDa, bool daRivedereA)
        {
            Colonna colonnaDestinazione = colonne.Where(x => x.ContieneCodiceIdentificativo(codiceColonnaDestinazione)).FirstOrDefault();
            if (colonnaDestinazione == null)
                throw new Exception("Non è possibile trovare la colonna di destinazione");

            if (daRivedereDa)
            {
                while (colonnaCorrente is ColonnaDecoratore)
                {
                    ColonnaDecoratore colonnaDecoratore = colonnaCorrente as ColonnaDecoratore;
                    if (colonnaCorrente is ColonnaConDaRivedere)
                        break;
                    colonnaCorrente = colonnaDecoratore.Decorato;
                }
                if (colonnaCorrente is not ColonnaConDaRivedere)
                    throw new Exception("La colonna con codice: " + colonnaCorrente.CodiceIdentificativo + " non ammette una sezione da rivedere!");

                ColonnaConDaRivedere colonnaConDaRivedere = colonnaCorrente as ColonnaConDaRivedere;
                colonnaConDaRivedere.removeTaskDaRivedere(taskCorrente);
            }
            else
                colonnaCorrente.removeTask(taskCorrente);

            if (daRivedereA)
            {
                while (colonnaDestinazione.CodiceIdentificativo != codiceColonnaDestinazione && colonnaDestinazione is ColonnaDecoratore)
                {
                    ColonnaDecoratore colonnaDecoratore = colonnaDestinazione as ColonnaDecoratore;
                    if (colonnaDestinazione is ColonnaConDaRivedere)
                        break;
                    colonnaDestinazione = colonnaDecoratore.Decorato;
                }
                if (colonnaDestinazione is not ColonnaConDaRivedere)
                    throw new Exception("La colonna con codice: " + codiceColonnaDestinazione + " non ammette una sezione da rivedere!");

                ColonnaConDaRivedere colonnaConDaRivedere = colonnaDestinazione as ColonnaConDaRivedere;
                colonnaConDaRivedere.addTaskDaRivedere(taskCorrente);
            }
            else
                colonnaDestinazione.addTask(taskCorrente);

            Notify();
        }

        public void Register(Observer observer) => observers.Add(observer);

        public void Remove(Observer observer) => observers.Remove(observer);

        public void Notify()
        {
            foreach (Observer observer in observers)
                observer.update();
        }

        public void SpostaTaskInDaRivedere(string codiceColonnaDaRivedere)
        {
            Colonna colonna = null;
            foreach (Colonna cln in colonne)
            {
                if (cln.ContieneCodiceIdentificativo(codiceColonnaDaRivedere))
                    colonna = cln;
            }

            if (colonna == null)
                throw new Exception("Non esiste una colonna con codice: " + codiceColonnaDaRivedere);

            while (colonna.CodiceIdentificativo != codiceColonnaDaRivedere && colonna is ColonnaDecoratore)
            {
                ColonnaDecoratore colonnaDecoratore = colonna as ColonnaDecoratore;
                colonna = colonnaDecoratore.Decorato;
            }

            if(colonna is not ColonnaConDaRivedere)
                throw new Exception("La colonna con codice: " + codiceColonnaDaRivedere + " non ammette una sezione da rivedere!");

            ColonnaConDaRivedere colonnaConDaRivedere = colonna as ColonnaConDaRivedere;

            colonnaCorrente.removeTask(taskCorrente);
            colonnaConDaRivedere.addTaskDaRivedere(taskCorrente);
            Notify();
        }
    }
}
