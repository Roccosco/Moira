﻿using System.ComponentModel;

namespace Moira.Dominio
{
    public class Team
    {
        private static int codiceProgressivo = 0;

        private string codiceUnivoco;
        private string nome;
        private HashSet<Impiegato> impiegati;
        private Progetto progetto;

        private MoiraClass moira;
        private Board boardCorrente;
        private Board board;
        private Cliente cliente;
        private Cerimonia cerimoniaCorrente;
        private List<Cerimonia> cerimonie;

        private List<Sprint> sprints;
        private Sprint sprintAttivo;
        private Sprint sprintCorrente;

        public Team(string nome)
        {
            codiceUnivoco = (codiceProgressivo++).ToString();
            this.nome = nome;
            impiegati = new HashSet<Impiegato>();
            cerimonie = new List<Cerimonia>();
            sprints = new List<Sprint>();
        }

        public Cerimonia CerimoniaCorrente { get => cerimoniaCorrente; }

        public string CodiceUnivoco
        {
            get => codiceUnivoco;
        }

        public string Nome
        {
            get => nome;
        }

        [Browsable(false)]
        public Progetto Progetto
        {
            get => progetto;
            set
            {
                if (isLibero())
                    progetto = value;
                else
                    throw new Exception("Il team lavora già a un progetto");
            }
        }

        [Browsable(false)]
        public Board Board
        {
            get => board;
        }

        [Browsable(false)]
        public Sprint SprintAttivo
        {
            get => sprintAttivo;
        }

        public void creaBoard(string nome)
        {
            if (board != null)
                throw new Exception("Il team ha già una board!");

            boardCorrente = new Board(nome);
        }

        public void CreaCerimonia(string nome, string descrizione, TipoCerimonia tipo, DateTime data, TimeSpan durata)
        {

            cerimoniaCorrente = new Cerimonia(nome, descrizione, tipo, data, durata);
        }


        public void creaColonna(string nome, bool daRivedere) => boardCorrente.creaColonna(nome, daRivedere);
        public void creaColonna(string nome, bool daRivedere, int limiteTask) => boardCorrente.creaColonna(nome, daRivedere, limiteTask);

        public void confermaCreaBoard()
        {
            if (board != null)
                throw new Exception("Il team ha già una board!");

            board = boardCorrente;
        }


        public void confermaCreaCerimonia() => cerimonie.Add(cerimoniaCorrente);

        public bool HaGiaCerimonie(DateTime data, TimeSpan durata)
        {
            //la data d'inizio della cerimonia da aggiungere deve essere precedente all'orario di fine di qualsiasi cerimonia
            //la data di fine della cerimonia da aggiungere deve essere successiva all'orario di inizio della stessa cerimonia presa nel rigo sopra
            return cerimonie.Any(x => data.CompareTo(x.Data.Add(durata)) < 0 && data.Add(durata).CompareTo(x.Data) > 0);
        }

        private bool isLibero() => progetto == null;

        public bool addImpiegato(Impiegato impiegato) => impiegati.Add(impiegato);

        public bool removeImpiegato(Impiegato impiegato) => impiegati.Remove(impiegato);

        public void AvviaNuovoSprint()
        {
            if(progetto == null)
                throw new Exception("Il team non lavora per alcun progetto!");
            if (haSprintAttivo())
                throw new Exception("Il team ha già uno sprint attivo! Termina lo sprint per iniziarne uno nuovo!");
            sprintCorrente = new Sprint();
        }

        public bool haSprintAttivo() => sprintAttivo != null;

        public void AggiungiTaskASprint(string codiceTask, int storyPoints)
        {
            MoiraTask task = progetto.getTask(codiceTask);
            sprintCorrente.aggiungiTask(task, storyPoints);
        }

        public void AssociaTaskSprintAImpiegato(Impiegato impiegato)
        {
            sprintCorrente.AssociaTaskAImpiegato(impiegato);
        }

        public void confermaAvvioSprint()
        {
            sprintAttivo = sprintCorrente;
        }

        public void selezionaTaskBacklogs(string codiceTask)
        {
            AlgoritmoTaskBoard algoritmo;
            if (haSprintAttivo())
                algoritmo = new AlgoTaskBoardSCRUM();
            else
                algoritmo = new AlgoTaskBoardNoSCRUM();
            MoiraTask task = algoritmo.getTask(codiceTask, this);
            board.setTaskCorrente(task);
        }

        public MoiraTask getTaskProgetto(string codiceIdentificativo) => progetto.getTask(codiceIdentificativo);

        public List<MoiraTask> getTasksProgetto() => progetto.getTasks();

        public void AggiungiTaskAColonna(string codiceColonna)
        {
            board.addTaskColonna(codiceColonna);
        }

        public void SelezionaTaskBoard(string codiceTask, string codiceColonna) => board.SelezionaTask(codiceTask, codiceColonna);

        public void SpostaTaskTraColonne(string codiceColonnaDestinazione, bool daRivedereDa, bool daRivedereA) => board.SpostaTaskTraColonne(codiceColonnaDestinazione, daRivedereDa, daRivedereA);

        public void SpostaTaskInDaRivedere(string codiceColonnaDaRivedere) => board.SpostaTaskInDaRivedere(codiceColonnaDaRivedere);

        public void TerminaSprint()
        {
            sprintAttivo.Termina();
            sprints.Add(sprintAttivo);
            sprintAttivo = null;
        }

        public List<MoiraTask> getTaskPerBoard()
        {
            AlgoritmoTaskBoard algoritmo;
            if (haSprintAttivo())
                algoritmo = new AlgoTaskBoardSCRUM();
            else
                algoritmo = new AlgoTaskBoardNoSCRUM();
            return algoritmo.getTuttiTaskAggiungibili(this);
        }

        public void EliminaTaskDaBoard(MoiraTask task) => board.EliminaTask(task);

        public List<Impiegato> getImpiegati() => new List<Impiegato>(impiegati);
        
    }
}