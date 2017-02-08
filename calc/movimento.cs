using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    class movimento //transaction
    {
        DateTime _data;
        string _descrizione;
        int _carichi;
        int _scarichi;
        double _prezzo;

        public DateTime data           
        {
            get
            {
                return _data;
            }
        }
        
        public string descrizione
        {
            get
            {
                return _descrizione;
            }
        }

        public int carichi
        {
            get
            {
                return _carichi;
            }
        }
    
        public int scarichi
        {
            get
            {
                return _scarichi;
            }
        }

        public double prezzo
        {
            get
            {
                return _prezzo;
            }
        }

    public movimento()
        {
            _data = DateTime.MinValue;
            _descrizione = "";
        }

        public bool input(string [] inputArray)//ref string errors)
        {
            _descrizione = inputArray[1];
            if (DateTime.TryParse(inputArray[0], out _data) & int.TryParse(inputArray[2], out _carichi) & int.TryParse(inputArray[3], out _scarichi) & double.TryParse(inputArray[4], out _prezzo))
            {
                return true;
            }

            return false;
        }
    }

    class calculator
    {
        public static double LiFo(movimento [] mov)
        {
            int x;
            int a = 1;
            double cc = 0;
            int i = 0;

            while (i < mov.Length)
            {
                if (mov[i].scarichi != 0)
                {
                    x = i;
                    a += mov[i].scarichi;

                    while (x >= 0)
                    { 
                        if (mov[x].carichi != 0)
                        {
                            a = a - mov[x].carichi;

                            if (a > 0)
                            {
                                cc = cc + (mov[x].carichi * mov[x].prezzo);
                            }
                            else
                            {
                                cc = cc + ((a + mov[x].carichi) * mov[x].prezzo);
                            }
                            
                        }

                        x--;
                    }

                }


                i++;
            }

            return cc;
         /*   while (x >= 0)
            {
                if (inputStock[x].carichi != 0)
                {
                    a = a - inputStock[x].carichi;

                    if (a > 0)
                    {
                        cc = cc + (inputStock[x].carichi * inputStock[x].prezzo);
                    }
                    else
                    {
                        cc = (cc + ((a - inputStock[x].carichi) * inputStock[x].prezzo)) * -1;
                    }

                }

                x--;
            }*/
        }

        public static double LifoAdvanced(movimento [] inputStock, ref bool worked)
        {
            if (inputStock != null)
            {
                int a = 0;
                double cc = 0;
                worked = true;

                for (int i = inputStock.Length - 1; i > -1; i--)
                {
                    if (inputStock[i].scarichi != 0)
                    {
                        a += inputStock[i].scarichi;
                    }
                    else if (inputStock[i].scarichi == 0)
                    {
                        a -= inputStock[i].carichi;
                    }

                    if (a < 0)
                    {
                        cc = a * inputStock[i].prezzo;
                    }
                }
                return cc * -1;
            }
            else
            {
                worked = false;
                return 0;
            }
        }
    }

    
}
