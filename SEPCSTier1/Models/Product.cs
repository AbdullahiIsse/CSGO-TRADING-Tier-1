﻿namespace SEPCSTier1.Models
{
    public class Product
    {
        public long id { get; set; }
        public long item_id { get; set; }
        public long saleOffer_id { get; set; }
        public string weaponname { get; set; }
        public string weaponURL { get; set; }
        public int sale_price { get; set; }
        public long wallet_id { get; set; }
    }
}