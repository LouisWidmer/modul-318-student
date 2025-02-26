﻿namespace SwissTransport.Core
{
    using System;
    using System.Threading.Tasks;
    using SwissTransport.Models;

    public interface ITransport
    {
        Task<Stations> GetStationsAsync(string query);

        Stations GetStations(string query);

        Task<StationBoardRoot> GetStationBoardAsync(string station, string id);

        StationBoardRoot GetStationBoard(string station, string id);

        Task<Connections> GetConnectionsAsync(string fromStation, string toStation);

        Connections GetConnections(string fromStation, string toStation);

        Task<Connections> GetConnectionsWithTimeAsync(string fromStation, string toStation, DateTime dateTime);

        Connections GetConnectionsWithTime(string fromStation, string toStation, DateTime dateTime);
    }
}