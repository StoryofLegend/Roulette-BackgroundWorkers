using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4F_Kovacev_Roulette
{
    class Numeri
    {
        public int _numero;
        public string _colore, _pariDispari, _dozzina, _colonna, _bassoAlto;

        //Lista dei numeri con le caratteristiche
        List<Numeri> NumeriRoulette = new List<Numeri>();

        //Il numero che ho generato nel form, qui ha tutte le caratteristiche
        Numeri numeroTrovato;


        public Numeri()
        {
            _numero = 1;
            _colore = "Rosso";
            _pariDispari = "Dispari";
            _dozzina = "prima";
            _colonna = "1";
            _bassoAlto = "basso";
        }

        public Numeri(int numero, string colore, string pariDispari, string dozzina, string colonna, string bassoAlto)
        {
            _numero = numero;
            _colore = colore;
            _pariDispari = pariDispari;
            _dozzina = dozzina;
            _colonna = colonna;
            _bassoAlto = bassoAlto;
        }

        
        //Aggiungo alla lista il numero, posso farlo direttamente qua senza farlo nel form
        public void Aggiungi(Numeri num)
        {
            NumeriRoulette.Add(num);
        }


        public void TrovaNumero(int numeroRandom)
        {
            //Trovo il numero random nella list
            foreach (var item in NumeriRoulette)
            {
                if (numeroRandom == item._numero) numeroTrovato = item;
            }
        }

        public string[] ControlloVincita(string puntata, int importoScommesso)
        {
            string[] Vincita = new string[2];

            string Messaggio = "Non hai indovinato niente";

            //Controlla se la puntata è vincente
            if (puntata == numeroTrovato._numero.ToString())
            {
                importoScommesso *= 36;
                Messaggio = "Hai indovinato il numero";
                Vincita[0] = Messaggio;
                Vincita[1] = importoScommesso.ToString();
            }

            else if (puntata == numeroTrovato._colore)
            {
                Messaggio = "Hai indovinato il colore";
                importoScommesso *= 2;
                Vincita[0] = Messaggio;
                Vincita[1] = importoScommesso.ToString();
            }
            else if (puntata == numeroTrovato._pariDispari)
            {
                Messaggio = "Hai indovinato! il numero è " + puntata;
                importoScommesso *= 2;
                Vincita[0] = Messaggio;
                Vincita[1] = importoScommesso.ToString();
            }
            else if (puntata == numeroTrovato._dozzina)
            {
                Messaggio = "Hai indovinato! il numero si trova nella " + puntata;
                importoScommesso *= 3;
                Vincita[0] = Messaggio;
                Vincita[1] = importoScommesso.ToString();
            }
            else if (puntata == numeroTrovato._colonna)
            {
                Messaggio = "Hai indovinato! il numero si trova nella " + puntata;
                importoScommesso *= 3;
                Vincita[0] = Messaggio;
                Vincita[1] = importoScommesso.ToString();
            }
            else if (puntata == numeroTrovato._bassoAlto)
            {
                Messaggio = "Hai indovinato! è un numero " + puntata;
                importoScommesso *= 2;
                Vincita[0] = Messaggio;
                Vincita[1] = importoScommesso.ToString();
            }

            else
            {
                importoScommesso *= -1;
                Vincita[0] = Messaggio;
                Vincita[1] = importoScommesso.ToString();
            }

            //Ritorno il messaggio è la vincita
            return Vincita;
        }
    }
}
