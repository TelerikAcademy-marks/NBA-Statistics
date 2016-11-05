﻿using NBAStatistics.Data.Repositories.Contracts;
using NBAStatistics.Models;

namespace NBAStatistics.Reports.Contracts
{
    public interface IXmlReportService
    {
        void CreatePlayedGamesReport(IRepository<StandingsByDay> dataSource);
    }
}
