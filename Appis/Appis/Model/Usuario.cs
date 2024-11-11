using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Appis.Model
{
    [Table("usuario")]
    public class Usuario
    {
       

        public Usuario(string idusuario, int numnotificacoesnaolidas)
        {
            this.idusuario = idusuario;
            this.numnotificacoesnaolidas = numnotificacoesnaolidas;
        }

        [Key]
        public string idusuario { get; set; }

        public int numnotificacoesnaolidas { get; set; }

        public List<Secao> Secaos { get; set; }
    }
}
