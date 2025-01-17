﻿namespace Gate.IO.Api;

public class GateRestApiClientOptions : RestApiClientOptions
{
    // Receive Window
    public TimeSpan ReceiveWindow { get; set; }

    // Auto Timestamp
    public bool AutoTimestamp { get; set; }
    public TimeSpan TimestampRecalculationInterval { get; set; }

    /// <summary>
    /// Gate.IO API Broker Id
    /// </summary>
    public string BrokerId { get; set; }

    public GateRestApiClientOptions() : this(null)
    {
    }

    public GateRestApiClientOptions(ApiCredentials credentials)
    {
        // API Credentials
        ApiCredentials = credentials;

        CoreAddress = GateApiAddresses.Default.RestApiAddress;
        // Api Addresses
        BaseAddress = GateApiAddresses.Default.RestApiAddress;

        // Receive Window
        ReceiveWindow = TimeSpan.FromSeconds(5);

        // Auto Timestamp
        AutoTimestamp = true;
        TimestampRecalculationInterval = TimeSpan.FromHours(1);

        // Http Options
        HttpOptions = new HttpOptions
        {
            UserAgent = RestApiConstants.USER_AGENT,
            AcceptMimeType = RestApiConstants.JSON_CONTENT_HEADER,
            RequestTimeout = TimeSpan.FromSeconds(30),
            EncodeQueryString = true,
            BodyFormat = RestBodyFormat.Json,
        };

        // Request Body
        RequestBodyParameterKey = "BODY";

        // Broker Id
        BrokerId = "phalchatha";
    }

}