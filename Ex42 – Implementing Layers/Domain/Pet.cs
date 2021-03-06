﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex42___Implementing_Layers.Application;

namespace Ex42___Implementing_Layers.Domain
{
    public class Pet : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();
        

        public Pet(string name, string type, string breed, string dob, float weight, int ownerID)
        {

        }

        public void Attach(IObserver o)
        {
            observers.Add(o);
        }

        public void Detach(IObserver o)
        {
            observers.Remove(o);
        }

        public void Notify()
        {
            foreach (PetRepo p in observers)
            {
                p.Update();
            }
        }
    }
}
