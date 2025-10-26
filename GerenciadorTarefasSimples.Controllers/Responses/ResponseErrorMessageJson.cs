namespace GerenciadorTarefasSimples.Controllers.Responses
{
    public class ResponseErrorMessageJson
    {
        public List<string> Errors { get; set; }

        public ResponseErrorMessageJson(string message) 
        {
            Errors = [message];
        }
        public ResponseErrorMessageJson(List<string> messages)
        {
            Errors = messages;
        }
    }
}
