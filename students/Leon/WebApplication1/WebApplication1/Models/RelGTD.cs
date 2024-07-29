using Microsoft.CodeAnalysis.Elfie.Serialization;
using System.ComponentModel.DataAnnotations;
using WebApplication1.Models;

namespace WebApplication1.Models
{
    public class RelGTD
    {
        [Key]
        public int Id { get; set; }
        public int IdGame { get; set; }
        public int IdCompany { get; set; }


        public RelGTD(int idGame, int idCompany)
        {
            IdGame = idGame;
            IdCompany = idCompany;
        }

    }
}
