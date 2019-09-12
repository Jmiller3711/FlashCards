using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace FlashCardsWinForms.Models
{
    public class SpreadsheetConnector
    {
        private string[] _scopes = { SheetsService.Scope.Spreadsheets };
        private string _applicationName = "FlashCardsApplication";
        private string _spreadsheetId = "1-uCg-OOdL0RhwKHVQtoS-8tyK5v9ckfaYYWsCNE1wTM";
        private SheetsService _sheetsService;

        public SpreadsheetConnector()
        {
            ConnectToGoogle();
        }

        private void ConnectToGoogle()
        {
            GoogleCredential credential;

            // Put your credentials json file in the root of the solution and make sure copy to output dir property is set to always copy 
            using (var stream = new FileStream(Path.Combine(Environment.CurrentDirectory, "FlashCardProject-120429ad768d.json"), FileMode.Open, FileAccess.Read))
            {
                credential = GoogleCredential.FromStream(stream).CreateScoped(_scopes);
            }

            // Create Google Sheets API service.
            _sheetsService = new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = _applicationName
            });
        }

        public string AppendData(List<Card> cards)
        {
            var range = "Sheet1!A:D";

            var valueRange = new ValueRange
            {
                Values = CardConverter(cards)
            };

            // Append the above record...
            var appendRequest = _sheetsService.Spreadsheets.Values.Append(valueRange, _spreadsheetId, range);
            appendRequest.ValueInputOption = SpreadsheetsResource.ValuesResource.AppendRequest.ValueInputOptionEnum.USERENTERED;
            var appendReponse = appendRequest.Execute();
            return JsonConvert.SerializeObject(appendReponse);
        }

        private List<IList<object>> CardConverter(List<Card> cards)
        {
            var cardObjectList = new List<IList<object>>();
            foreach (var card in cards)
            {
                cardObjectList.Add(new List<object> { card.DeckName, card.Question, card.Answer });
            }
            return cardObjectList;
        }

        public List<Card> GetAllData()
        {
            const string range = "Sheet1!A2:D";
            var request = _sheetsService.Spreadsheets.Values.Get(_spreadsheetId, range);
            var response = request.Execute();
            var cards = new List<Card>();
            foreach (var row in response.Values)
            {
                var card = new Card(row[0].ToString(), row[1].ToString(), row[2].ToString());
                cards.Add(card);
            }
            return cards;
        }

        public Deck GetDeck(string deckName)
        {
            const string range = "Sheet1!A2:D";
            var request = _sheetsService.Spreadsheets.Values.Get(_spreadsheetId, range);
            var response = request.Execute();
            var cards = new List<Card>();
            foreach (var row in response.Values)
            {
                var card = new Card(row[0].ToString(), row[1].ToString(), row[2].ToString());
                if (card.DeckName == deckName)
                {
                    cards.Add(card);
                }
            }
            return new Deck(cards);
        }

        public void DeleteCard(string deckName, string question, string answer)
        {
            const string range = "Sheet1!A2:D";
            var request = _sheetsService.Spreadsheets.Values.Get(_spreadsheetId, range);
            var response = request.Execute();

            var rowNumber = 1;
            foreach (var value in response.Values)
            {
                if (value[0].ToString() == deckName && value[1].ToString() == question && value[2].ToString() == answer)
                {
                    Delete(rowNumber, rowNumber + 1);
                    rowNumber--;
                }
                rowNumber++;
            }
        }

        public void DeleteDeck(string deckName)
        {
            const string range = "Sheet1!A2:D";
            var request = _sheetsService.Spreadsheets.Values.Get(_spreadsheetId, range);
            var response = request.Execute();

            var rowNumber = 1;
            foreach (var value in response.Values)
            {
                if (value[0].ToString() == deckName)
                {
                    Delete(rowNumber, rowNumber + 1);
                    rowNumber--;
                }
                rowNumber++;
            }
        }

        private void Delete(int startIndex, int endIndex)
        {
            Request RequestBody = new Request()
            {
                DeleteDimension = new DeleteDimensionRequest()
                {
                    Range = new DimensionRange()
                    {
                        SheetId = 0,
                        Dimension = "ROWS",
                        StartIndex = Convert.ToInt32(startIndex),
                        EndIndex = Convert.ToInt32(endIndex)
                    }
                }
            };

            List<Request> RequestContainer = new List<Request>();
            RequestContainer.Add(RequestBody);

            BatchUpdateSpreadsheetRequest DeleteRequest = new BatchUpdateSpreadsheetRequest();
            DeleteRequest.Requests = RequestContainer;

            SpreadsheetsResource.BatchUpdateRequest Deletion = new SpreadsheetsResource.BatchUpdateRequest(_sheetsService, DeleteRequest, _spreadsheetId);
            Deletion.Execute();
        }
    }
}
