﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moira.Dominio
{
    public class Board
    {
        private string codiceUnivoco;
        private string nome;
        private static int codiceProgressivo = 0;
        private List<Colonna> colonne;
        private MoiraTask taskDaAggiungere;

        public Board(string nome)
        {
            codiceUnivoco = (codiceProgressivo++).ToString();
            this.nome = nome;

            colonne = new List<Colonna>();
            colonne.Add(new ColonnaBase("Cestinato"));
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

        public void addTask(MoiraTask task)
        {
            taskDaAggiungere = task;
        }

        public void addTaskColonna(string codiceColonna)
        {
            foreach (Colonna colonna in colonne)
            {
                if (colonna.CodiceIdentificativo == codiceColonna)
                {
                    colonna.addTask(taskDaAggiungere);
                    return;
                }
            }

            throw new Exception("Colonna non trovata");
        }
    }
}
