namespace Gate.IO.Api.Models.RestApi.Futures;

public class FuturesPosition
{
    /// <summary>
    /// Position mode, including:  - &#x60;single&#x60;: dual mode is not enabled- &#x60;dual_long&#x60;: long position in dual mode- &#x60;dual_short&#x60;: short position in dual mode
    /// </summary>
    [JsonProperty("mode"), JsonConverter(typeof(FuturesPositionModeConverter))]
    public FuturesPositionMode Mode { get; set; }

    /// <summary>
    /// User ID
    /// </summary>
    [JsonProperty("user")]
    public int UserId { get;  set; }

    /// <summary>
    /// Futures contract
    /// </summary>
    [JsonProperty("contract")]
    public string Contract { get;  set; }

    /// <summary>
    /// Position size
    /// </summary>
    [JsonProperty("size")]
    public long Size { get;  set; }

    /// <summary>
    /// Position leverage. 0 means cross margin; positive number means isolated margin
    /// </summary>
    [JsonProperty("leverage")]
    public int Leverage { get; set; }

    /// <summary>
    /// Position risk limit
    /// </summary>
    [JsonProperty("risk_limit")]
    public decimal RiskLimit { get; set; }

    /// <summary>
    /// Maximum leverage under current risk limit
    /// </summary>
    [JsonProperty("leverage_max")]
    public double LeverageMax { get;  set; }

    /// <summary>
    /// Maintenance rate under current risk limit
    /// </summary>
    [JsonProperty("maintenance_rate")]
    public decimal MaintenanceRate { get;  set; }

    /// <summary>
    /// Position value calculated in settlement currency
    /// </summary>
    [JsonProperty("value")]
    public decimal Value { get;  set; }

    /// <summary>
    /// Position margin
    /// </summary>
    [JsonProperty("margin")]
    public decimal Margin { get; set; }

    /// <summary>
    /// Entry price
    /// </summary>
    [JsonProperty("entry_price")]
    public decimal EntryPrice { get;  set; }

    /// <summary>
    /// Liquidation price
    /// </summary>
    [JsonProperty("liq_price")]
    public decimal LiquidationPrice { get;  set; }

    /// <summary>
    /// Current mark price
    /// </summary>
    [JsonProperty("mark_price")]
    public decimal MarkPrice { get;  set; }

    /// <summary>
    /// The initial margin occupied by the position, applicable to the portfolio margin account
    /// </summary>
    [JsonProperty("initial_margin")]
    public decimal InitialMargin { get;  set; }

    /// <summary>
    /// Maintenance margin required for the position, applicable to portfolio margin account
    /// </summary>
    [JsonProperty("maintenance_margin")]
    public decimal MaintenanceMargin { get;  set; }

    /// <summary>
    /// Unrealized PNL
    /// </summary>
    [JsonProperty("unrealised_pnl")]
    public decimal UnrealisedPnl { get;  set; }

    /// <summary>
    /// Realized PNL
    /// </summary>
    [JsonProperty("realised_pnl")]
    public decimal RealisedPnl { get;  set; }

    /// <summary>
    /// History realized PNL
    /// </summary>
    [JsonProperty("history_pnl")]
    public decimal HistoryPnl { get;  set; }

    /// <summary>
    /// PNL of last position close
    /// </summary>
    [JsonProperty("last_close_pnl")]
    public decimal LastClosePnl { get;  set; }

    /// <summary>
    /// Realized POINT PNL
    /// </summary>
    [JsonProperty("realised_point")]
    public decimal RealisedPoint { get;  set; }

    /// <summary>
    /// History realized POINT PNL
    /// </summary>
    [JsonProperty("history_point")]
    public decimal HistoryPoint { get;  set; }

    /// <summary>
    /// ADL ranking, ranging from 1 to 5
    /// </summary>
    [JsonProperty("adl_ranking")]
    public int AdlRanking { get;  set; }

    /// <summary>
    /// Current open orders
    /// </summary>
    [JsonProperty("pending_orders")]
    public int PendingOrders { get;  set; }

    /// <summary>
    /// Gets or Sets CloseOrder
    /// </summary>
    [JsonProperty("close_order", NullValueHandling = NullValueHandling.Ignore)]
    public FuturesPositionCloseOrder CloseOrder { get; set; }

    /// <summary>
    /// Cross margin leverage(valid only when &#x60;leverage&#x60; is 0)
    /// </summary>
    [JsonProperty("cross_leverage_limit")]
    public int CrossLeverageLimit { get; set; }
}

public class FuturesPositionCloseOrder
{
    /// <summary>
    /// Close order ID
    /// </summary>
    [JsonProperty("id")]
    public long OrderId { get; set; }

    /// <summary>
    /// Close order price
    /// </summary>
    [JsonProperty("price")]
    public decimal Price { get; set; }

    /// <summary>
    /// Is the close order from liquidation
    /// </summary>
    [JsonProperty("is_liq")]
    public bool IsLiquidated { get; set; }
}