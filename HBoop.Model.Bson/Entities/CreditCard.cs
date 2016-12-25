using System;

namespace HBoop.Model.Bson.Entities
{
    public class CreditCard:Entity
    {
        public string NameOwner { get; set; }
        public long Number { get; set; }
        public DateTime? ExpiratedDate { get; set; }
        public TypeEntity CardType { get; set; }
        public int CryptoCode { get; set; }
    }
}