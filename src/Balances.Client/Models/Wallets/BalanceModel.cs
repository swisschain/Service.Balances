using System;
using Service.Balances.Contracts;

namespace Balances.Client.Models.Wallets
{
    /// <summary>
    /// Represents a balance of an asset.
    /// </summary>
    public class BalanceModel
    {
        /// <summary>
        /// Initialized a new instance of <see cref="BalanceModel"/>.
        /// </summary>
        public BalanceModel()
        {
        }

        internal BalanceModel(Balance balance)
        {
            AssetId = balance.AssetId;
            Amount = decimal.Parse(balance.Amount);
            Reserved = decimal.Parse(balance.Reserved);
            Timestamp = balance.Timestamp.ToDateTime();
        }

        /// <summary>
        /// The asset id.
        /// </summary>
        public string AssetId { get; set; }

        /// <summary>
        /// The amount of balance.
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// The amount that currently are reserved.
        /// </summary>
        public decimal Reserved { get; set; }

        /// <summary>
        /// The date and time of balance.
        /// </summary>
        public DateTime Timestamp { get; set; }
    }
}
