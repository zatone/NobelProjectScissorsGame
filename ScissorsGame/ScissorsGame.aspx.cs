using DOM.Games.Scissors;
using RestSharp;
using System;
using System.Web.UI;
using static DOM.Games.Scissors.Enums;

namespace ScissorsGame
{
    public partial class ScissorsGame1 : System.Web.UI.Page
    {
        private RestClient _client;

        protected void Page_Load(object sender, EventArgs e)
        {
            _client = new RestClient("http://localhost/Scissors/");
        }

        protected void imgBtnRock_Click(object sender, ImageClickEventArgs e)
        {
            var request = new RestRequest($"PlayGame", Method.POST);

            // Header
            request.AddHeader("Cache-Control", "no-cache");

            // Body
            request.AddParameter("/playerPlay", (int)ScissorGameMove.Rock);

            var response = _client.Execute<ResponseMessage>(request);

            var result = response.Data;

            lblMessage.Text = result.Message;
            imgBtnPlayAgain.Visible = true;
        }

        protected void imgBtnPaper_Click(object sender, ImageClickEventArgs e)
        {
            var request = new RestRequest("PlayGame", Method.POST);

            // Header
            request.AddHeader("Cache-Control", "no-cache");

            // Body
            request.AddParameter("/playerPlay", (int)ScissorGameMove.Paper);

            var response = _client.Execute<ResponseMessage>(request);

            var result = response.Data;

            lblMessage.Text = result.Message;
            imgBtnPlayAgain.Visible = true;
        }

        protected void imgBtnScissors_Click(object sender, ImageClickEventArgs e)
        {
            var request = new RestRequest("PlayGame", Method.POST);

            // Header
            request.AddHeader("Cache-Control", "no-cache");

            // Body
            request.AddParameter("/playerPlay", (int)ScissorGameMove.Scissors);

            var response = _client.Execute<ResponseMessage>(request);

            var result = response.Data;

            lblMessage.Text = result.Message;
            imgBtnPlayAgain.Visible = true;
        }

        protected void imgBtnPlayAgain_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("ScissorsGame.aspx");
        }

        private void TestApi()
        {
            var request = new RestRequest("Test", Method.POST);

            // Header
            request.AddHeader("Cache-Control", "no-cache");

            var response = _client.Execute(request);
        }
    }
}