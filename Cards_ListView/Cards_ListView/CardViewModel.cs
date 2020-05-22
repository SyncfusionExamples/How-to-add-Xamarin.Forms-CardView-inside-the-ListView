using System;
using System.Collections.Generic;
using System.Text;

namespace Cards_ListView
{
    public class CardViewModel
    {
        public IEnumerable<CardModel> Items { get; set; }
        public CardViewModel()
        {
            Items = new CardModel[]
            {
                new CardModel(){ Title = "FaceBook" , Image = "FacebookFill.png"},
                new CardModel(){ Title = "Gmail" , Image = "GmailFill.png"},
                new CardModel(){ Title = "Instagram" , Image = "InstagramFill.png"},
                new CardModel(){ Title = "Whatsapp" , Image = "WhatsappFill.png"},
            };
        }
    }
}
