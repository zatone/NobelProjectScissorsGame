using DOM.Games.Scissors;
using System;
using System.Threading.Tasks;
using static DOM.Games.Scissors.Enums;

namespace BLL.Games.Scissors
{
    public class ScissorManager
    {
        public async Task<ResponseMessage> Play(ScissorGameMove scissorGameMove)
        {
            var result = new ResponseMessage();

            await Task.Run(() =>
            {
                var playOptions = PlayOptionsGet(scissorGameMove);

                var systemPlay = SystemPlay(playOptions);

                result = Logic(scissorGameMove, systemPlay);
            });

            return result;
        }

        private int[] PlayOptionsGet(ScissorGameMove scissorGameMove)
        {
            int[] playOptions = new int[3];
            playOptions[0] = 1;
            playOptions[1] = 2;
            playOptions[2] = 3;           

            return playOptions;
        }

        private ScissorGameMove SystemPlay(int[] options)
        {
            var random = new Random();

            int result = options[random.Next(options.Length)];

            return (ScissorGameMove)result;
        }

        private ResponseMessage Logic(ScissorGameMove playerPlay, ScissorGameMove systemPlay)
        {
            var result = new ResponseMessage();
            result.SystemPlay = systemPlay;

            if (playerPlay == systemPlay)
                result.Message = "Tie";
            else if (playerPlay == ScissorGameMove.Rock)
            {
                if (systemPlay == ScissorGameMove.Paper)
                    result.Message = "Loose";
                else
                    result.Message = "Win";
            }
            else if (playerPlay == ScissorGameMove.Paper)
            {
                if (systemPlay == ScissorGameMove.Rock)
                    result.Message = "Win";
                else
                    result.Message = "Loose";
            }
            else if (playerPlay == ScissorGameMove.Scissors)
            {
                if (systemPlay == ScissorGameMove.Rock)
                    result.Message = "Loose";
                else
                    result.Message = "Win";
            }

            return result;
        }
    }
}
