﻿using TradingJournal.Application.Common.Interfaces;
using TradingJournal.Application.Entities.Reports.Queries.GetDailyReport;
using TradingJournal.Application.Entities.Reports.Queries.GetMonthReportQuery;
using System.Text.Json;

namespace TradingJournal.Application.ClientServices;

public class ReportService : ClientServiceBase, IReportService
{
    private readonly HttpClient _http;

    public ReportService(HttpClient http)
    {
        _http = http;
    }

    public async Task<WeekdayReportDto> GetWeekdayReport()
    {
        string response = await _http.GetStringAsync("api/reports/weekday");

        return JsonSerializer.Deserialize<WeekdayReportDto>(response, _jsonOptions);
    }

    public async Task<MonthReportDto> GetMonthReport()
    {
        string response = await _http.GetStringAsync("api/reports/month");

        return JsonSerializer.Deserialize<MonthReportDto>(response, _jsonOptions);
    }
}