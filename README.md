# Progettazione Roulette

Ci saranno 4 giocatori. Partiranno tutti con 5000 chips.
Il giocatore, in modo random, sceglierà il numero di puntate(max 3), il tipo di puntata e la quantità di chips da puntare sulla giocata. Quando il giocatore avrà finito di puntare toccherà a quello successivo.
Quando tutti i giocatori avranno effettuato le loro puntate toccherà al banco. Il banco girerà la roulette e farà visualizzare il numero uscito. Poi controllerà giocatore per giocatore se le puntate che hanno fatto sono vincenti o no. Se saranno vincenti verrà incrementato il loro budget sennò verrà decrementato.
Quando sarà finito il controllo delle puntate i giocatori ricominceranno a
puntare.

### Oggetti/funzioni utilizzate

- Classe Numeri con le variabili numero, colore, pariDispari, dozzina, colonna, bassoAlto. Ci sarà il costruttore dove sarà possibile assegnare dei valori alle variabili dal formLoad. Ci sarà una Lista di numeri (List<Numeri>) dove aggiungerò i vari numeri con tutte le loro caratteristiche. Ci saranno dei metodi che sfrutteranno questa lista.
- Start Button, l’utente premendo il bottone farà partirà i backgroundWorker, attraverso i runworkerAsync passerò delle tupla che contengono tre textbox.
- Stop Button, l’utente può aspettare che finisca il gioco oppure può premere lo stop button e uccidere subito i backgroundWorker
- 4 backgroundWorker uno per ogni giocatore
- Nel doWork ci saranno due lock uno per gestire le puntate l’altro per far girare la roulette e controllare le vincite. Quindi ci saranno due reportProgress, nella prima passerò i chips puntati e la tupla con le
  textbox, nella seconda passerò il budget aggiornato e la tupla con le textbox. Per effettuare altre giocate ci sarà un do-while finchè il budget non sarà uguale a 0
- Nel progressChanged farò visualizzare il budget, le chips puntate, la puntata sulle textbox
- Nel runworkerCompleted ucciderò il bgw che è uscito dal doWork
- Il tipo di puntata verrà scelta in modo random
- La quantità di chips verranno scelti anch’essi in modo random, ma con un range da 500 a 2000

### Regole

Useremo le regole della roulette francese, 37 numeri da 0 a 36 .
Esistono diversi tipi di puntata:

| **Nome puntata**              | **Numeri coperti** | **Vincita** | **Percentuale** |
| ----------------------------- | ------------------ | ----------- | --------------- |
| Pieno                         | 1                  | x36         | 2,70%           |
| Rosso                         | 18                 | x2          | 48,65%          |
| Nero                          | 18                 | x2          | 48,65%          |
| Dispari                       | 18                 | x2          | 48,65%          |
| Pari                          | 18                 | x2          | 48,65%          |
| Basso (1-18)                  | 18                 | x2          | 48,65%          |
| Alto (19-36)                  | 18                 | x2          | 48,65%          |
| Prima, seconda, terza colonna | 12                 | x3          | 32,43%          |
| Prima, seconda, terza dozzina | 12                 | x3          | 32,43%          |
| Cavallo                       | 2                  | x18         | 5,41%           |
| Terzina                       | 3                  | x12         | 8,11%           |
| Carrè                         | 4                  | x9          | 10,81%          |
| Sestina                       | 6                  | x6          | 16,22%          |

Non useremo le puntate : carrè, cavallo, sestine, terzine.

Nella roulette francese abbiamo un solo zero, che è verde, mentre in quella
americana ne abbiamo due. La roulette americana è più vantaggiosa per il
banco.

## Post codifica

### Cambiamenti

Nella progettazione ho scritto che ogni giocatore poteva fare max 3 puntate a giro, non sono riuscito a farlo, il giocatore fa solo una puntata.

La scelta del tipo di puntata è casuale, ma non tutti i tipi di puntata hanno la stessa percentuale di uscita. Per rendere il gioco più realistico le giocate più facili da prendere hanno una percentuale più alta di uscire.

| **Tipo giocata** | Percentuale |
| ---------------- | ----------- |
| Pieno            | 9%          |
| Colonna          | 17%         |
| Dozzina          | 17%         |
| Colore           | 19%         |
| Basso/Alto       | 19%         |
| Pari/Dispari     | 19%         |

La quantità di chips puntati non è random, ma viene scelta in base al budget del giocatore, più sarà alto il budget più sarà alta la puntata. Questo per evitare che le partite durino tanto.

| **Budget**        | Chips puntati |
| ----------------- | ------------- |
| Budget <= 500     | All in        |
| Tra 500 e 1000    | 500           |
| Tra 1000 e 2000   | 750           |
| Tra 2000 e 3000   | 1000          |
| Tra 3000 e 4000   | 1250          |
| Tra 4000 e 5000   | 1500          |
| Tra 5000 e 6000   | 1750          |
| Tra 6000 e 7000   | 2000          |
| Tra 7000 e 8000   | 2250          |
| Tra 8000 e 0000   | 2500          |
| Tra 9000 e 10000  | 2750          |
| Tra 10000 e 20000 | 3250          |
| Tra 20000 e 30000 | 7500          |
| Tra 30000 e 40000 | 10000         |
| Budget > 40000    | 15000         |

Nel doWork avevo due lock una dopo l’altra e per sincronizzarli ho usato un contatore e un ciclo while infinito che aspetta che tutti i backgroundWorker siano allo stesso punto per poi ricreare il blocco. Ho usato lo stesso modo anche alla fine del ciclo do-while.

Nella classe ho usato 3 metodi:

1. Aggiungi. Per aggiungere i numeri con le loro caratteristiche nella lista di numeri
2. TrovaNumero. Quando il banco gira la ruota ed esce il numero lo mando dentro a questo metodo che mi trova nella lista il numero e viene assegnata ad una variabile globale all’interno della classe
3. ControlloVincita. Dal doWork passo il tipo di puntata e la quantità di chips puntati. Qui confronto la puntata del giocatore con le varie
   caratteristiche del numero generato dalla roulette. Se ha indovinato verrà incrementato il suo budget in base alla quantità di chips che ha puntata e cosa indovinato, in caso contrario perderà i chips puntati.

### Come giocare:

Questo è il form di gioco:

![roulette](/RouletteImage.png)

Per far partire il gioco bisogna preme il bottone Start. All’interno della groupBox ci sono i 4 giocatori. Nella prima textBox a turno
verranno scritti i tipi di puntata dei vari giocatori.

Nella label nella prima parte della puntata verrà scritto la quantità di chip che ogni giocatore punterà. Invece nella seconda parte comparirà un messaggio con su scritto se ha vinto o no.

Quando il banco avrà controllato tutte le vincite verranno cancellate i testi della textBox per il tipo di giocata e la label. Dopo che il banco avrà fatto girare la roulette il numero uscito comparirà nella pictureBox affianco al tavolo. Dopo che il banco ha controllato le vincite verrà modificato la textBox del budget.

Appena un giocatore non avrà più budget uscirà dal gioco. Il gioco finirà quando rimarrà un solo giocatore con del budget. Oppure per smettere di giocare basterà premere il bottone Stop.