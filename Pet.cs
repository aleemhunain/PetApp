using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetApp
{
    internal class Pet
    {
        public string Name 
        {
            get;
        }

        public string Owner
        {
            get; private set;
        }
        public int Age
        {
            get;
        }
        public string Description
        {
            get;
        }
        public bool IsHouseTrained
        {
            get; private set;
        }

        public Pet(string name,
            int age,
            string description)
        {
            this.Name = name;
            this.Age = age;
            this.Description = description;
            this.Owner = "no one";
            this.IsHouseTrained = false;
        }

        public override string ToString()
        {
            return $"Name: {Name} - Owner: {Owner} - Age: {Age} - Description: {Description} - isHouseTrained: {IsHouseTrained}";
        }

        public void SetOwner(string value) 
        { 
            Owner = value;
        }

        public void Train()
        {
            IsHouseTrained = true;
        }

    }
}
