﻿using System;
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
            panel.Controls.Clear();

            int x = 0;
            foreach(Colonna colonna in colonne)
            {
                colonna.Draw(panel, x);
                x += 200;
            }
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

        public void SpostaTaskTraColonne(string codiceColonnaDestinazione)
        {
            Colonna colonnaDestinazione = colonne.Where(x => x.ContieneCodiceIdentificativo(codiceColonnaDestinazione)).FirstOrDefault();
            if (colonnaDestinazione == null)
                throw new Exception("Non è possibile trovare la colonna di destinazione");

            colonnaCorrente.removeTask(taskCorrente);
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

    }
}
