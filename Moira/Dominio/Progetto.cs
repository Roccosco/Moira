﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moira.Dominio
{
    public class Progetto
    {
        private string nome;
        private string descrizione;

        private int posNuovaUserStory;

        private HashSet<Cliente> clienti;
        private List<UserStory> backlog;

        public Progetto(string nome, string descrizione)
        {
            this.nome = nome;
            this.descrizione = descrizione;

            clienti = new HashSet<Cliente>();
            backlog = new List<UserStory>();
        }

        public string Nome { get => nome;  set => nome = value; }

        public void SetCliente(Cliente cliente)
        {
            clienti.Add(cliente);
        }
    }
}
