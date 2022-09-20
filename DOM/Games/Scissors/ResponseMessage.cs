using static DOM.Games.Scissors.Enums;

namespace DOM.Games.Scissors
{
    public class ResponseMessage
    {
        public string Message { get; set; }
        public ScissorGameMove SystemPlay { get; set; }
    }
}
