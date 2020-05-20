﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_and_Objects_OOPs_
{

    class Human
    {
        /***********Constructor*********/
        public Human()
        {
            Console.WriteLine("You are welcome human being");
            eyeNo = 2;
            nose = 1;
        }
        public Human(string nameEntered)
        {
            name = nameEntered;
        }

        //This is a Field
        private string name;
        public int eyeNo;
        public int nose;

        //This is a property
        public string Name
        {
            get
            {
                return name + "of student";
            }
            set
            {
                name = value;
            }
        }

        //public string Name { get => name; set => name = value; }


        //This is method
        public void eat()
        {
            Console.WriteLine("Are you Hungry");
        }
        public void sayName()
        {
            Console.WriteLine(Name);
        }
       
    }

}
