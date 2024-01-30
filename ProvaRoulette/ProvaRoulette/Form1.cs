using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvaRoulette
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Numeri zero;
        //Numeri uno;
        //Numeri due;
        //Numeri tre;
        //Numeri quattro;
        //Numeri cinque;
        //Numeri sei;
        //Numeri sette;
        //Numeri otto;
        //Numeri nove;
        //Numeri dieci;
        //Numeri undici;
        //Numeri dodici;
        //Numeri tredici;
        //Numeri quattordici;
        //Numeri quindici;
        //Numeri sedici;
        //Numeri diciassette;
        //Numeri diciotto;
        //Numeri diciannove;
        //Numeri venti;
        //Numeri ventuno;
        //Numeri ventidue;
        //Numeri ventitre;
        //Numeri ventiquattro;
        //Numeri venticinque;
        //Numeri ventisei;
        //Numeri ventisette;
        //Numeri ventotto;
        //Numeri ventinove;
        //Numeri trenta;
        //Numeri trentuno;
        //Numeri trentadue;
        //Numeri trentatre;
        //Numeri trentaquattro;
        //Numeri trentacinque;
        //Numeri trentasei;

        //ListaNumeri lst;
        Numeri metodiNumeri;

        Random rnd = new Random(Environment.TickCount);


        string tipoPuntata = "";
        int budget = 5000;
        int puntata = 0;


        public int Puntata(int budget)
        {
            int puntata = 500;

            //All in
            if (budget <= 500) puntata = budget;
            else if (budget > 500 && budget <= 1000) puntata = 250;
            else if (budget > 1000 && budget <= 2000) puntata = 500;
            else if (budget > 2000 && budget <= 3000) puntata = 750;
            else if (budget > 3000 && budget <= 4000) puntata = 1000;
            else if (budget > 4000 && budget <= 5000) puntata = 1250;
            else if (budget > 5000 && budget <= 6000) puntata = 1500;
            else if (budget > 6000 && budget <= 7000) puntata = 1750;
            else if (budget > 7000 && budget <= 8000) puntata = 2000;
            else if (budget > 8000 && budget <= 9000) puntata = 2250;
            else if (budget > 9000 && budget <= 10000) puntata = 2500;
            else if(budget>10000) puntata = 3000;

            return puntata;
        }

        public string Numero()
        {
            int numeroGiocatore = rnd.Next(0, 37);
            return numeroGiocatore.ToString();
        }

        public string Colore()
        {
            string colore = "";
            int coloreGiocatore = rnd.Next(0, 2);
            if (coloreGiocatore == 0) colore = "rosso";
            else colore = "nero";

            return colore;
        }

        public string PariDispari()
        {
            string pariDispari = "";
            int pariDispariGiocatore = rnd.Next(0, 2);
            if (pariDispariGiocatore == 0) pariDispari = "pari";
            else pariDispari = "dispari";

            return pariDispari;
        }

        public string Dozzina()
        {
            string dozzina = "";
            int dozzinaGiocatore = rnd.Next(1, 4);
            if (dozzinaGiocatore == 1) dozzina = "prima";
            if (dozzinaGiocatore == 2) dozzina = "seconda";
            else dozzina = "nero";

            return dozzina;
        }

        public string Colonna()
        {
            string colonna = "";
            int colonnaGiocatore = rnd.Next(1, 4);
            if (colonnaGiocatore == 1) colonna = "colonna 1";
            if (colonnaGiocatore == 2) colonna = "colonna 2";
            else colonna = "colonna 3";

            return colonna;
        }

        public string BassoAlto()
        {
            string bassoAlto = "";
            int bassoAltoGiocatore = rnd.Next(0, 2);
            if (bassoAltoGiocatore == 0) bassoAlto = "basso";
            else bassoAlto = "alto";

            return bassoAlto;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //Puntata del giocatore
            int numeroRnd = rnd.Next(1, 101);

            //11% ok
            if (numeroRnd <= 11) tipoPuntata = Numero();
            //19% ok
            if (numeroRnd >= 12 && numeroRnd <= 30) tipoPuntata = Colore();
            //19% ok
            if (numeroRnd >= 31 && numeroRnd <= 49) tipoPuntata = PariDispari();
            //16%
            if (numeroRnd >= 50 && numeroRnd <= 65) tipoPuntata = Dozzina();
            //16%
            if (numeroRnd >= 66 && numeroRnd <= 81) tipoPuntata = Colonna();
            //19%
            if (numeroRnd >= 82) tipoPuntata = BassoAlto();

            txtUtente.Text = tipoPuntata;

            //Gestisco la puntata
            puntata = Puntata(budget);
            txtPuntata.Text = puntata.ToString();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Lista dei numeri con le proprie caratteristiche
            metodiNumeri = new /*Lista*/Numeri();

            //Do delle caratteristiche ai vari numeri e li aggiungo alla lista
            Numeri zero = new Numeri(0, "verde", "/", "/", "/", "/");
            metodiNumeri.Aggiungi(zero);
            Numeri uno = new Numeri(1, "rosso", "dispari", "prima", "colonna 1", "basso");
            metodiNumeri.Aggiungi(uno);
            Numeri due = new Numeri(2, "nero", "pari", "prima", "colonna 2", "basso");
            metodiNumeri.Aggiungi(due);
            Numeri tre = new Numeri(3, "rosso", "dispari", "prima", "colonna 3", "basso");
            metodiNumeri.Aggiungi(tre);
            Numeri quattro = new Numeri(4, "nero", "pari", "prima", "colonna 1", "basso");
            metodiNumeri.Aggiungi(quattro);
            Numeri cinque = new Numeri(5, "rosso", "dispari", "prima", "colonna 2", "basso");
            metodiNumeri.Aggiungi(cinque);
            Numeri sei = new Numeri(6, "nero", "pari", "prima", "colonna 3", "basso");
            metodiNumeri.Aggiungi(sei);
            Numeri sette = new Numeri(7, "rosso", "dispari", "prima", "colonna 1", "basso");
            metodiNumeri.Aggiungi(sette);
            Numeri otto = new Numeri(8, "nero", "pari", "prima", "colonna 2", "basso");
            metodiNumeri.Aggiungi(otto);
            Numeri nove = new Numeri(9, "rosso", "dispari", "prima", "colonna 3", "basso");
            metodiNumeri.Aggiungi(nove);
            Numeri dieci = new Numeri(10, "nero", "pari", "prima", "colonna 1", "basso");
            metodiNumeri.Aggiungi(dieci);
            Numeri undici= new Numeri(11, "nero", "dispari", "prima", "colonna 2", "basso");
            metodiNumeri.Aggiungi(undici);
            Numeri dodici = new Numeri(12, "rosso", "pari", "prima", "colonna 3", "basso");
            metodiNumeri.Aggiungi(dodici);
            Numeri tredici = new Numeri(13, "nero", "dispari", "seconda", "colonna 1", "basso");
            metodiNumeri.Aggiungi(tredici);
            Numeri quattordici = new Numeri(14, "rosso", "pari", "seconda", "colonna 2", "basso");
            metodiNumeri.Aggiungi(quattordici);
            Numeri quindici = new Numeri(15, "nero", "dispari", "seconda", "colonna 3", "basso");
            metodiNumeri.Aggiungi(quindici);
            Numeri sedici = new Numeri(16, "rosso", "pari", "seconda", "colonna 1", "basso");
            metodiNumeri.Aggiungi(sedici);
            Numeri diciassette = new Numeri(17, "nero", "dispari", "seconda", "colonna 2", "basso");
            metodiNumeri.Aggiungi(diciassette);
            Numeri diciotto = new Numeri(18, "rosso", "pari", "seconda", "colonna 3", "basso");
            metodiNumeri.Aggiungi(diciotto);
            Numeri diciannove = new Numeri(19, "rosso", "dispari", "seconda", "colonna 1", "alto");
            metodiNumeri.Aggiungi(diciannove);
            Numeri venti = new Numeri(20, "nero", "pari", "seconda", "colonna 2", "alto");
            metodiNumeri.Aggiungi(venti);
            Numeri ventuno = new Numeri(21, "rosso", "dispari", "seconda", "colonna 3", "alto");
            metodiNumeri.Aggiungi(ventuno);
            Numeri ventidue = new Numeri(22, "nero", "pari", "seconda", "colonna 1", "alto");
            metodiNumeri.Aggiungi(ventidue);
            Numeri ventitre = new Numeri(23, "rosso", "dispari", "seconda", "colonna 2", "alto");
            metodiNumeri.Aggiungi(ventitre);
            Numeri ventiquattro = new Numeri(24, "nero", "pari", "seconda", "colonna 3", "alto");
            metodiNumeri.Aggiungi(ventiquattro);
            Numeri venticinque = new Numeri(25, "rosso", "dispari", "terza", "colonna 1", "alto");
            metodiNumeri.Aggiungi(venticinque);
            Numeri ventisei = new Numeri(26, "nero", "pari", "terza", "colonna 2", "alto");
            metodiNumeri.Aggiungi(ventisei);
            Numeri ventisette = new Numeri(27, "rosso", "dispari", "terza", "colonna 3", "alto");
            metodiNumeri.Aggiungi(ventisette);
            Numeri ventotto = new Numeri(28, "nero", "pari", "terza", "colonna 1", "alto");
            metodiNumeri.Aggiungi(ventotto);
            Numeri ventinove = new Numeri(29, "nero", "dispari", "terza", "colonna 2", "alto");
            metodiNumeri.Aggiungi(ventinove);
            Numeri trenta = new Numeri(30, "rosso", "pari", "terza", "colonna 3", "alto");
            metodiNumeri.Aggiungi(trenta);
            Numeri trentuno = new Numeri(31, "nero", "dispari", "terza", "colonna 1", "alto");
            metodiNumeri.Aggiungi(trentuno);
            Numeri trentadue = new Numeri(32, "rosso", "pari", "terza", "colonna 2", "alto");
            metodiNumeri.Aggiungi(trentadue);
            Numeri trentatre = new Numeri(33, "nero", "dispari", "terza", "colonna 3", "alto");
            metodiNumeri.Aggiungi(trentatre);
            Numeri trentaquattro = new Numeri(34, "rosso", "pari", "terza", "colonna 1", "alto");
            metodiNumeri.Aggiungi(trentaquattro);
            Numeri trentacinque = new Numeri(35, "nero", "dispari", "terza", "colonna 2", "alto");
            metodiNumeri.Aggiungi(trentacinque);
            Numeri trentasei = new Numeri(36, "rosso", "pari", "terza", "colonna 3", "alto");
            metodiNumeri.Aggiungi(trentasei);
        }

        private void btnRoulette_Click(object sender, EventArgs e)
        {
            
            //Giro la roulette
            int numeroRoulette = rnd.Next(0, 37);
            //Faccio visualizzare il numero random
            txtRandom.Text = numeroRoulette.ToString();

            //Trovo il numero random nella lista, quindi ho tutte le sue caratteristiche
            metodiNumeri.TrovaNumero(numeroRoulette);

            //Visualizzo sulle textbox tutte le caratteristiche del numero, inutili nel programma vero
            txtColore.Text = metodiNumeri.Colore();
            txtPariDispari.Text = metodiNumeri.pariDispari();
            txtDozzina.Text = metodiNumeri.Dozzina();
            txtColonna.Text = metodiNumeri.Colonna();
            txtBassoAlto.Text = metodiNumeri.bassoAlto();

            //Il messaggio mi dirà se ho indovinato e cosa ho indovinato
            //string Messaggio = lst.Tutto(tipoPuntata);

            string[] Vincita = new string[2];
            Vincita = metodiNumeri.Tutto(tipoPuntata, puntata);
            string Messaggio = Vincita[0];
            int importoScommesso = Convert.ToInt16(Vincita[1]);

            MessageBox.Show(Messaggio);

            //int puntata2 = lst.Tutto(tipoPuntata, puntata);
            budget += importoScommesso;
            txtBudget.Text = budget.ToString();
            if(budget==0) MessageBox.Show("Hai perso");
        }
    }

}
