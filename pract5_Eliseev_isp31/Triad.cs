﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract5_Eliseev_isp31
{
    public class Triad
    {

        int _first;
        int _second ;
        int _third;


        public Triad(int first, int second, int third)
        {
            First = first;
            Second = second;
            Third = third;
        }
        

        public int First
        {
            get => _first; 
            set
            {
                if (value % 2 == 0)
                {
                    throw new ArgumentException("Введены неверные данные");
                }

                else
                {
                    _first = value;
                }
            }
        }

        public int Second
        {
            get => _second; set
            {
                if (value % 2 == 0)
                    throw new ArgumentException("Введены неверные данные");

                _second = value;
            }
        }

        public int Third
        {
            get => _third; set
            {
                if (value % 2 == 0)
                    throw new ArgumentException("Введены неверные данные");

                _third = value;
            }
        }

        public bool Equality(Triad value)
        {
            return First == value.First && Second == value.Second && Third == value.Third;
        }

        public bool Equality(Triad triada1, Triad triada2)
        {
            return Equality(triada1) && First == triada2.First && Second == triada2.Second && Third == triada1.Third;
        }


        public override string ToString()
        {
            return $"{0}, {1}, {2}";
        }

    }
    
}

