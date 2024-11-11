namespace Appis.ViewModel
{
    public class NotificacaoViewModel
    {

        public string idnotificacao { get; set; }

        public string tipo {  get; set; }

        public string avatarurl { get; set; }

        public string titulo { get; set; }  

        public string mensagem { get; set; }

        public DateTime enviadaem { get; set; }

        public bool lida {  get; set; }

        public string deeplink { get; set; }

        public List<DeepLinkViewModel> DeepLinkExtras{ get; set; }

    }
}
