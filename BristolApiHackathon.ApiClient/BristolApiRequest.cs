﻿using System.Reflection;
using BristolApiHackathon.Models;
using RestSharp;

namespace BristolApiHackathon.ApiClient
{
    public class BristolApiRequest : RestRequest
    {
        private BristolApiRequest(string resource, Method method) : base(resource, method)
        {
        }

        public static BristolApiRequest CreateDirectionsRequest(DirectionsRequest directionsRequest)
            => new BristolApiRequest("/plan/directions", Method.POST).AddJsonBody(directionsRequest) as BristolApiRequest;
    }
}