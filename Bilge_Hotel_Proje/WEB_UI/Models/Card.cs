
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEB_UI.Models
{
    public class Card
    {

        Dictionary<int, CardItem> _myCard = new Dictionary<int, CardItem>();
        

        public List<CardItem> myCard
        {
            get
            {
                return _myCard.Values.ToList();
            }
        }

        public void AddRez(CardItem cartItem)//1
        {
            if (_myCard.ContainsKey(cartItem.RezervasyonID))//1
            {
                _myCard[cartItem.RezervasyonID].GunSayisi += cartItem.GunSayisi;
                return;

            }
            _myCard.Add(cartItem.RezervasyonID, cartItem);
        }
    }
}