using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS2122_4E_INF_Prof_ProvaGestioneArticoli
{
    class Articolo
    {
        // TODO: (8) aggiungere attributi privati di Articolo
        // ...
        int codice;
        double prezzo;
        string descrizione;
        string unitaDiMisura;
        

        // TODO: (9) aggiungere property di sola lettura dei dati necessari all'esterno di Articolo
        // ...
        public Articolo(int codice, string descrizione, string unitaDiMisura, double prezzo)
        {
            // TODO: (10) impostazione costruttore classe Articolo come utilizzato da frmMain
            // ...
            this.prezzo = prezzo  ;
            this.descrizione = descrizione;
            this.unitaDiMisura = unitaDiMisura;
            
        }

        public string Visualizzati()
        {
            return $"{descrizione} {unitaDiMisura} {prezzo} ({codice})";
        }
    }
}
