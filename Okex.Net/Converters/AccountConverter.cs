﻿using CryptoExchange.Net.Converters;
using Okex.Net.Enums;
using System.Collections.Generic;

namespace Okex.Net.Converters
{
    internal class AccountConverter : BaseConverter<OkexAccount>
    {
        public AccountConverter() : this(true) { }
        public AccountConverter(bool quotes) : base(quotes) { }

        protected override List<KeyValuePair<OkexAccount, string>> Mapping => new List<KeyValuePair<OkexAccount, string>>
        {
            new KeyValuePair<OkexAccount, string>(OkexAccount.Spot, "1"),
            new KeyValuePair<OkexAccount, string>(OkexAccount.Futures, "3"),
            new KeyValuePair<OkexAccount, string>(OkexAccount.Margin, "5"),
            new KeyValuePair<OkexAccount, string>(OkexAccount.Funding, "6"),
            new KeyValuePair<OkexAccount, string>(OkexAccount.Swap, "9"),
            new KeyValuePair<OkexAccount, string>(OkexAccount.Option, "12"),
            new KeyValuePair<OkexAccount, string>(OkexAccount.Unified, "18"),
        };
    }
}