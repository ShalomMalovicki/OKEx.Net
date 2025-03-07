﻿using System;
using System.IO;
using CryptoExchange.Net.Authentication;
using System.Security;
using System.Text;
using CryptoExchange.Net;
using Newtonsoft.Json.Linq;

namespace Okex.Net.Objects.Core
{
    public class OkexApiCredentials : ApiCredentials
    {
        public SecureString PassPhrase { get; }

        public OkexApiCredentials(string apiKey, string apiSecret, string apiPassPhrase) : base(apiKey, apiSecret)
        {
            PassPhrase = apiPassPhrase.ToSecureString();
        }

        public override ApiCredentials Copy()
        {
            return new OkexApiCredentials(Key!.GetString(), Secret!.GetString(), PassPhrase!.GetString());
        }
    }
}
