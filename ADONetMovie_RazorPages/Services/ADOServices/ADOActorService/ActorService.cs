
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
        // dadou && math
        public IEnumerable<Actor> GetActors()
        {
            return actorService.GetActors().ToList();
        }

        // math
        public Actor GetActorById(int id)
        {
            return null;
        }

        //dadou
        public void DeleteActor(Actor actor)
        {
            // I am not able to implement the delete functionality
        }
    }
}
