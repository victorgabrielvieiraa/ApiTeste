using System.ComponentModel.DataAnnotations.Schema;

namespace Appis.Model
{
   [Table("deeplinkextra")]
    public class DeepLinkExtra
    {

        public int id {  get; set; }

        public string key { get; set; }

        public string value { get; set; }

        public Notificacao notificacao { get; set; }


    }
}
