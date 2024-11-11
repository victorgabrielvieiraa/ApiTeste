using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Appis.Model
{
    [Table("notificacao")]
    public class Notificacao
    {
        [Key]
        public string id { get; set; }

        public string tipo { get; set; }

        public string avatarurl { get; set; }

        public string titulo { get; set; }

        public string mensagem { get; set; }

        public DateTime enviadaem { get; set; }

        public bool lida {  get; set; }

        public string deeplink { get; set; }

        public List<DeepLinkExtra> deepLinkExtras{ get; set; }

    }
}
