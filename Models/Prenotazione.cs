using System;
using System.ComponentModel.DataAnnotations;

namespace Cavalli.Sarah._5H.PrimaWeb.Models
{
    public class Prenotazione
    {
        public int PrenotazioneId {get; set;}
        public DateTime Data {get; set;} = DateTime.Now;
        public string Nome { get; set; }

        [Required(ErrorMessage="Inserisci una Email valida")]
        [EmailAddress]
        public string Email { get; set; }
       
    }
}
