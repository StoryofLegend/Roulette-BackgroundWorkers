using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaRoulette
{
    class Numeri
    {
        public int _numero;
        public string _colore, _pariDispari, _dozzina, _colonna, _bassoAlto;

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

        //Lista dei numeri con le caratteristiche
        List<Numeri> NumeriRoulette = new List<Numeri>();

        //Il numero che ho generato nel form, qui ha tutte le caratteristiche
        Numeri numeroTrovato;

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

                if (numeroRandom == item._numero)
                {
                    numeroTrovato = item;

                }
            }
        }

        //DA SISTEMARE BUGGATO
        public string[] Tutto(string puntata, int importoScommesso)
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
                Messaggio = "Hai indovinato! il numero si trova nella " + puntata + " dozzina";
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
            return Vincita;
        }


        //Queste funzioni servono solo per visualizzare sulla textbox le caratteristiche del numero
        public string Colore()
        {
            return numeroTrovato._colore;
        }

        public string pariDispari()
        {
            return numeroTrovato._pariDispari;
        }

        public string Dozzina()
        {
            return numeroTrovato._dozzina;
        }

        public string Colonna()
        {
            return numeroTrovato._colonna;
        }

        public string bassoAlto()
        {
            return numeroTrovato._bassoAlto;
        }
    }
}
