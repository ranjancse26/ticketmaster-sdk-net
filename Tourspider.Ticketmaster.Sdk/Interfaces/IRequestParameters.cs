﻿using Tourspider.Ticketmaster.Sdk;

namespace Tourspider.Ticketmaster.Sdk.Interfaces
{
    public interface IRequestParameters
    {
         void AddToRequest(RestRequest restRequest);
    }
}
