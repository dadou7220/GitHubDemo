﻿
using ADONetMovie_RazorPages.Models;
using ADONetMovie_RazorPages.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADONetMovie_RazorPages.Services
{
    public class ActorService : IActorService
    {
     
        private AdonetActorService actorService { get; set; }
        public ActorService(AdonetActorService service)

        {
            actorService = service;
        }
        public IEnumerable<Actor> GetActors()
        {
            return null;
        }
        public Actor GetActorById(int id)
        {
            return null;
        }

        public void DeleteActor(Actor actor)
        {
            //
        }
    }
}
