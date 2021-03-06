﻿using Newtonsoft.Json;


namespace Tourspider.Ticketmaster.Sdk.Models
{
    public class PriceRanges
    {
        [JsonProperty("excluding_ticket_fees")]
        public TicketFees ExcludingTicketFees { get; set; }

        [JsonProperty("including_ticket_fees")]
        public TicketFees IncludingTicketFees { get; set; }
    }

}
