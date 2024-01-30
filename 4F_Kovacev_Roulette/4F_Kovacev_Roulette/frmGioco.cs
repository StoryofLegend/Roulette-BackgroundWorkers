using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4F_Kovacev_Roulette
{
    public partial class frmGioco : Form
    {
        public frmGioco()
        {
            InitializeComponent();
        }

        #region Variabili Globali

        Random rnd = new Random(Environment.TickCount);

        Numeri metodiNumeri;

        int numeroRoulette;
        //Poi va azzerato nello stop
        int synchBgw = 0;
        int conta = 0;
        int synchbgw4 = 4;
        int synchbgw5 = 5;
        int synchBgw8 = 8;
        bool Pulisci = false;
        string Messaggio;

        int bgwUccisi = 0;

        Image[] ImNumeri = new Image[37];

        Image ImRoulette = Properties.Resources.gifroulette;
        Image ImRouletteGif = Properties.Resources.roulettegiff;


        #endregion

        #region backgroundWorkers

        private void backgroundWorkers_DoWork(object sender, DoWorkEventArgs e)
        {
            //cast
            BackgroundWorker bgw = (BackgroundWorker)sender;
            var tupla = (Tuple<TextBox, TextBox, Label>)e.Argument;

            TextBox txtGiocata = tupla.Item1;
            TextBox txtBudget = tupla.Item2;
            Label lblMessaggio = tupla.Item3;

            //Mi servirà per il reportProgress
            object[] comunicazione = new object[2];

            int budget = 5000;
            int puntata = 0;
            Messaggio = "";
            string tipoPuntata = "";
            //Mi servira per il metodo ControlloVincita e 
            //verranno assegnati i messaggi con su scritto cosa ha indovinato e la vincita
            string[] Vincita = new string[2];

            do
            {
                //Contatori
                conta = 0; //Mi servirà per la roulette
                synchBgw = 0; //mi servirà nel progressChanged e per sincronizzare i bgw

                var tupla_comunicazione = new Tuple<TextBox, TextBox, Label>(txtGiocata, txtBudget, lblMessaggio);

                comunicazione[0] = tupla_comunicazione;

                Pulisci = false;

                //Viene scelta la puntata del giocatore
                lock (rnd)
                {
                    Thread.Sleep(100);
                    //Puntata del giocatore
                    int numeroRnd = rnd.Next(1, 101);

                    Thread.Sleep(rnd.Next(0, 4) * 1000 + 1500);

                    //I tipi di puntata più facili da prendere avranno una percentuale più alta di uscire rispetto agli altri
                    //questo per simulare nel modo più realistico possibile la giocata di un giocatore
                    if (numeroRnd <= 11) tipoPuntata = Numero(); //11%
                    if (numeroRnd >= 12 && numeroRnd <= 30) tipoPuntata = Colore(); //19%
                    if (numeroRnd >= 31 && numeroRnd <= 49) tipoPuntata = PariDispari(); //19%
                    if (numeroRnd >= 50 && numeroRnd <= 65) tipoPuntata = Dozzina(); //16%
                    if (numeroRnd >= 66 && numeroRnd <= 81) tipoPuntata = Colonna(); //16%
                    if (numeroRnd >= 82) tipoPuntata = BassoAlto(); //19%

                    comunicazione[1] = tipoPuntata;

                    Thread.Sleep(500);

                    //Gestisco la puntata, in base al budget verrà scelta la quantità di chips da puntare
                    puntata = GestionePuntata(budget);
                }

                //Riporto la puntata e comunicazione con dentro la tupla e il tipo di puntata
                bgw.ReportProgress(puntata, comunicazione);

                //Sincronizzo i bgw
                while (synchBgw != synchbgw4) //inizialmente diverso da 4
                {

                }

                Thread.Sleep(1000);

                //Banco
                lock (metodiNumeri)
                {
                    //Il numero random va generato una sola volta perchè è uguale per tutti
                    conta++;
                    Thread.Sleep(500);
                    if (conta == 1)
                    {
                        //Gira la roulette
                        numeroRoulette = rnd.Next(0, 37);
                        //Trovo il numero random nella lista, quindi ho tutte le sue caratteristiche
                        metodiNumeri.TrovaNumero(numeroRoulette);


                        pcbRoulette.Image = ImRouletteGif;
                        Thread.Sleep(6000);
                        pcbRoulette.Image = ImRoulette;

                        pcbNumeroRoulette.Image = ImNumeri[numeroRoulette];
                    }

                    //Trovo il numero random nella lista, quindi ho tutte le sue caratteristiche
                    //metodiNumeri.TrovaNumero(numeroRoulette);

                    //Controllo se il giocatore ha vinto e mi faccio ritornare una stringa con su scritta cosa ha indovinato
                    //e i soldi vinti
                    Vincita = metodiNumeri.ControlloVincita(tipoPuntata, puntata);

                    Messaggio = Vincita[0];
                    if (budget == 0) Messaggio = "Hai perso";
                    comunicazione[1] = Messaggio;

                    int importoScommesso = Convert.ToInt16(Vincita[1]);
                    //Aggiorno il budget
                    budget += importoScommesso;

                    Thread.Sleep(1500);
                }

                
                //if (bgwUccisi == 3) comunicazione[1] = "HAI VINTO";
                
                bgw.ReportProgress(budget, comunicazione);

                Thread.Sleep(1000);

                //Sincronizzo i bgw
                while (synchBgw != synchBgw8) //diverso da 8
                {

                }

                if (budget == 0)
                {
                    comunicazione[1] = "Hai perso";
                    e.Result = comunicazione;
                    return;
                }

               

                Thread.Sleep(500);

                //il bgw viene ucciso se non ha più chips da puntare
                

                Thread.Sleep(2000);

                //Il bgw viene ucciso se viene premuto il tasto Stop
                if (bgw.CancellationPending)
                {
                    comunicazione[1] = "Hai perso";
                    e.Result = comunicazione;
                    e.Cancel = true;
                    return;
                }

            } while (budget > 0);
        }

        private void backgroundWorkers_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            object[] comunicazione = (object[])e.UserState;
            var tupla = (Tuple<TextBox, TextBox, Label>)comunicazione[0];
            string messaggio = (string)comunicazione[1];

            //prima budget poi puntata
            int chip = (int)e.ProgressPercentage;

            //tupla
            TextBox txtTipoPuntata = tupla.Item1;
            TextBox txtBudget = tupla.Item2;
            Label lbl = tupla.Item3;

            synchBgw++;

            //Primo reportProgress
            if (synchBgw <= synchbgw4)
            {
                //Scrivo sulla label quanti chip verranno scommessi dal giocatore
                lbl.Text = chip.ToString();
                txtTipoPuntata.Text = messaggio;
            }

            if (synchBgw == synchbgw5) txtNumeroRoulette.Text = numeroRoulette.ToString();

            //Secondo reportProgress
            if (conta > 0)
            {
                //Faccio visualizzare il budget
                txtBudget.Text = chip.ToString();
                //Faccio visualizzare il messaggio
                lbl.Text = messaggio;
            }

            //Quando il banco ha finito di dare controllare le puntate inizia 
            //un nuovo giro di puntate quindi pulisco le giocate precedenti
            if (synchBgw == synchBgw8) Pulisci = true;
            if (Pulisci)
            {
                txtNumeroRoulette.Clear();
                txtGiocatore1.Clear();
                txtGiocatore2.Clear();
                txtGiocatore3.Clear();
                txtGiocatore4.Clear();
                lblGiocatore1.Text = "-";
                lblGiocatore2.Text = "-";
                lblGiocatore3.Text = "-";
                lblGiocatore4.Text = "-";
            }
        }

        private void backgroundWorkers_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                BackgroundWorker bgw = (BackgroundWorker)sender;
                bgw.CancelAsync();

                bgwUccisi++;
                synchbgw4--;
                synchbgw5--;
                synchBgw8 = synchBgw8 - 2;

                object[] comunicazione = (object[])e.Result;
                var tupla = (Tuple<TextBox, TextBox, Label>)comunicazione[0];
                string messaggio = (string)comunicazione[1];

                TextBox txtBudget = tupla.Item2;
                Label lbl = tupla.Item3;

                txtBudget.Text = "0";
                lbl.Text = messaggio;
            }

            if (bgwUccisi == 3)
            {
                bgw1.CancelAsync();
                bgw2.CancelAsync();
                bgw3.CancelAsync();
                bgw4.CancelAsync();

                btnStart.Enabled = true;
                btnStop.Enabled = false;
            }
        }

        #endregion

        #region Numeri
        private void frmGioco_Load(object sender, EventArgs e)
        {
            //Lista dei numeri con le proprie caratteristiche
            metodiNumeri = new Numeri();

            //Do delle caratteristiche ai vari numeri e li aggiungo alla lista
            Numeri zero = new Numeri(0, "verde", "/", "/", "/", "/");
            metodiNumeri.Aggiungi(zero);
            Numeri uno = new Numeri(1, "rosso", "dispari", "prima dozzina", "colonna 1", "basso");
            metodiNumeri.Aggiungi(uno);
            Numeri due = new Numeri(2, "nero", "pari", "prima dozzina", "colonna 2", "basso");
            metodiNumeri.Aggiungi(due);
            Numeri tre = new Numeri(3, "rosso", "dispari", "prima dozzina", "colonna 3", "basso");
            metodiNumeri.Aggiungi(tre);
            Numeri quattro = new Numeri(4, "nero", "pari", "prima dozzina", "colonna 1", "basso");
            metodiNumeri.Aggiungi(quattro);
            Numeri cinque = new Numeri(5, "rosso", "dispari", "prima dozzina", "colonna 2", "basso");
            metodiNumeri.Aggiungi(cinque);
            Numeri sei = new Numeri(6, "nero", "pari", "prima dozzina", "colonna 3", "basso");
            metodiNumeri.Aggiungi(sei);
            Numeri sette = new Numeri(7, "rosso", "dispari", "prima dozzina", "colonna 1", "basso");
            metodiNumeri.Aggiungi(sette);
            Numeri otto = new Numeri(8, "nero", "pari", "prima dozzina", "colonna 2", "basso");
            metodiNumeri.Aggiungi(otto);
            Numeri nove = new Numeri(9, "rosso", "dispari", "prima dozzina", "colonna 3", "basso");
            metodiNumeri.Aggiungi(nove);
            Numeri dieci = new Numeri(10, "nero", "pari", "prima dozzina", "colonna 1", "basso");
            metodiNumeri.Aggiungi(dieci);
            Numeri undici = new Numeri(11, "nero", "dispari", "prima dozzina", "colonna 2", "basso");
            metodiNumeri.Aggiungi(undici);
            Numeri dodici = new Numeri(12, "rosso", "pari", "prima dozzina", "colonna 3", "basso");
            metodiNumeri.Aggiungi(dodici);
            Numeri tredici = new Numeri(13, "nero", "dispari", "seconda dozzina", "colonna 1", "basso");
            metodiNumeri.Aggiungi(tredici);
            Numeri quattordici = new Numeri(14, "rosso", "pari", "seconda dozzina", "colonna 2", "basso");
            metodiNumeri.Aggiungi(quattordici);
            Numeri quindici = new Numeri(15, "nero", "dispari", "seconda dozzina", "colonna 3", "basso");
            metodiNumeri.Aggiungi(quindici);
            Numeri sedici = new Numeri(16, "rosso", "pari", "seconda dozzina", "colonna 1", "basso");
            metodiNumeri.Aggiungi(sedici);
            Numeri diciassette = new Numeri(17, "nero", "dispari", "seconda dozzina", "colonna 2", "basso");
            metodiNumeri.Aggiungi(diciassette);
            Numeri diciotto = new Numeri(18, "rosso", "pari", "seconda dozzina", "colonna 3", "basso");
            metodiNumeri.Aggiungi(diciotto);
            Numeri diciannove = new Numeri(19, "rosso", "dispari", "seconda dozzina", "colonna 1", "alto");
            metodiNumeri.Aggiungi(diciannove);
            Numeri venti = new Numeri(20, "nero", "pari", "seconda dozzina", "colonna 2", "alto");
            metodiNumeri.Aggiungi(venti);
            Numeri ventuno = new Numeri(21, "rosso", "dispari", "seconda dozzina", "colonna 3", "alto");
            metodiNumeri.Aggiungi(ventuno);
            Numeri ventidue = new Numeri(22, "nero", "pari", "seconda dozzina", "colonna 1", "alto");
            metodiNumeri.Aggiungi(ventidue);
            Numeri ventitre = new Numeri(23, "rosso", "dispari", "seconda dozzina", "colonna 2", "alto");
            metodiNumeri.Aggiungi(ventitre);
            Numeri ventiquattro = new Numeri(24, "nero", "pari", "seconda dozzina", "colonna 3", "alto");
            metodiNumeri.Aggiungi(ventiquattro);
            Numeri venticinque = new Numeri(25, "rosso", "dispari", "terza dozzina", "colonna 1", "alto");
            metodiNumeri.Aggiungi(venticinque);
            Numeri ventisei = new Numeri(26, "nero", "pari", "terza dozzina", "colonna 2", "alto");
            metodiNumeri.Aggiungi(ventisei);
            Numeri ventisette = new Numeri(27, "rosso", "dispari", "terza dozzina", "colonna 3", "alto");
            metodiNumeri.Aggiungi(ventisette);
            Numeri ventotto = new Numeri(28, "nero", "pari", "terza dozzina", "colonna 1", "alto");
            metodiNumeri.Aggiungi(ventotto);
            Numeri ventinove = new Numeri(29, "nero", "dispari", "terza dozzina", "colonna 2", "alto");
            metodiNumeri.Aggiungi(ventinove);
            Numeri trenta = new Numeri(30, "rosso", "pari", "terza dozzina", "colonna 3", "alto");
            metodiNumeri.Aggiungi(trenta);
            Numeri trentuno = new Numeri(31, "nero", "dispari", "terza dozzina", "colonna 1", "alto");
            metodiNumeri.Aggiungi(trentuno);
            Numeri trentadue = new Numeri(32, "rosso", "pari", "terza dozzina", "colonna 2", "alto");
            metodiNumeri.Aggiungi(trentadue);
            Numeri trentatre = new Numeri(33, "nero", "dispari", "terza dozzina", "colonna 3", "alto");
            metodiNumeri.Aggiungi(trentatre);
            Numeri trentaquattro = new Numeri(34, "rosso", "pari", "terza dozzina", "colonna 1", "alto");
            metodiNumeri.Aggiungi(trentaquattro);
            Numeri trentacinque = new Numeri(35, "nero", "dispari", "terza dozzina", "colonna 2", "alto");
            metodiNumeri.Aggiungi(trentacinque);
            Numeri trentasei = new Numeri(36, "rosso", "pari", "terza dozzina", "colonna 3", "alto");
            metodiNumeri.Aggiungi(trentasei);

            ImNumeri[1] = Properties.Resources._1;
            ImNumeri[2] = Properties.Resources._2;
            ImNumeri[3] = Properties.Resources._3;
            ImNumeri[4] = Properties.Resources._4;
            ImNumeri[5] = Properties.Resources._5;
            ImNumeri[6] = Properties.Resources._6;
            ImNumeri[7] = Properties.Resources._7;
            ImNumeri[8] = Properties.Resources._8;
            ImNumeri[9] = Properties.Resources._9;
            ImNumeri[10] = Properties.Resources._10;
            ImNumeri[11] = Properties.Resources._11;
            ImNumeri[12] = Properties.Resources._12;
            ImNumeri[13] = Properties.Resources._13;
            ImNumeri[14] = Properties.Resources._14;
            ImNumeri[15] = Properties.Resources._15;
            ImNumeri[16] = Properties.Resources._16;
            ImNumeri[17] = Properties.Resources._17;
            ImNumeri[18] = Properties.Resources._18;
            ImNumeri[19] = Properties.Resources._19;
            ImNumeri[20] = Properties.Resources._20;
            ImNumeri[21] = Properties.Resources._21;
            ImNumeri[22] = Properties.Resources._22;
            ImNumeri[23] = Properties.Resources._23;
            ImNumeri[24] = Properties.Resources._24;
            ImNumeri[25] = Properties.Resources._25;
            ImNumeri[26] = Properties.Resources._26;
            ImNumeri[27] = Properties.Resources._27;
            ImNumeri[28] = Properties.Resources._28;
            ImNumeri[29] = Properties.Resources._29;
            ImNumeri[30] = Properties.Resources._30;
            ImNumeri[31] = Properties.Resources._31;
            ImNumeri[32] = Properties.Resources._32;
            ImNumeri[33] = Properties.Resources._33;
            ImNumeri[34] = Properties.Resources._34;
            ImNumeri[35] = Properties.Resources._35;
            ImNumeri[36] = Properties.Resources._36;
        }

        #endregion

        #region Button
        private void btnStart_Click(object sender, EventArgs e)
        {
            //4 giocatori
            //Passo la textbox dove scriverò il tipo di giocata, la textbox per il budget
            //e la label dove scriverò se la giocata è stata vincente o no
            bgw1.RunWorkerAsync(new Tuple<TextBox,TextBox,Label>(txtGiocatore1,txtBudgetGioc1,lblGiocatore1));
            bgw2.RunWorkerAsync(new Tuple<TextBox, TextBox, Label>(txtGiocatore2, txtBudgetGioc2, lblGiocatore2));
            bgw3.RunWorkerAsync(new Tuple<TextBox, TextBox, Label>(txtGiocatore3, txtBudgetGioc3, lblGiocatore3));
            bgw4.RunWorkerAsync(new Tuple<TextBox, TextBox, Label>(txtGiocatore4, txtBudgetGioc4, lblGiocatore4));

            btnStart.Enabled = false;
            btnStop.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            //Uccido i bgw se l'utente preme stop
            bgw1.CancelAsync();
            bgw2.CancelAsync();
            bgw3.CancelAsync();
            bgw4.CancelAsync();

            txtGiocatore1.Clear();
            txtGiocatore2.Clear();
            txtGiocatore3.Clear();
            txtGiocatore4.Clear();

            //Mi serve per sincronizzare i bgw
            synchBgw = 0;

            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }

        #endregion

        #region Metodi

        //La puntata sarà scelta in base al budget del giocatore
        //La puntata sarà alta con un budget alto per evitare che il gioco duri tanto
        public int GestionePuntata(int budget)
        {
            int puntata = 500;

            if (budget <= 500) puntata = budget; //all in
            else if (budget > 500 && budget <= 1000) puntata = 500;
            else if (budget > 1000 && budget <= 2000) puntata = 750;
            else if (budget > 2000 && budget <= 3000) puntata = 1000;
            else if (budget > 3000 && budget <= 4000) puntata = 1250;
            else if (budget > 4000 && budget <= 5000) puntata = 1500;
            else if (budget > 5000 && budget <= 6000) puntata = 1750;
            else if (budget > 6000 && budget <= 7000) puntata = 2000;
            else if (budget > 7000 && budget <= 8000) puntata = 2250;
            else if (budget > 8000 && budget <= 9000) puntata = 2500;
            else if (budget > 9000 && budget <= 10000) puntata = 2750;
            else if (budget > 10000 && budget <= 20000) puntata = 3250;
            else if (budget > 20000 && budget <= 30000) puntata = 7500;
            else if (budget > 30000 && budget <= 40000) puntata = 10000;
            else if (budget > 40000) puntata = 15000;

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
            if (dozzinaGiocatore == 1) dozzina = "prima dozzina";
            if (dozzinaGiocatore == 2) dozzina = "seconda dozzina";
            else dozzina = "terza dozzina";

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

        #endregion
    }
}
