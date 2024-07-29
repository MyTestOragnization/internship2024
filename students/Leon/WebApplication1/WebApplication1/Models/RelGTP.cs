using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class RelGTP
    {
        [Key]
        public int Id { get; set; }
        public int IdGame { get; set; }
        public int IdCompany { get; set; }








        public RelGTP(int idGame, int idCompany)
        {
            IdGame = idGame;
            IdCompany = idCompany;
        }







    }
}