using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Appis.Model
{
    [Table("secao")]
    public class Secao
    {
     [Key]
     public int id { get; set; }

     public string titulo { get; set; }
    

     public List<Notificacao> Notificacaos { get; set; }

    }
}
