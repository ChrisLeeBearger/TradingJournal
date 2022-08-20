global using System.Diagnostics;
global using System.Text;
global using System.Text.Json.Serialization;
global using FluentValidation.AspNetCore;
global using MediatR;
global using Microsoft.AspNetCore.Authentication.JwtBearer;
global using Microsoft.AspNetCore.Authorization;
global using Microsoft.AspNetCore.Mvc;
global using Microsoft.AspNetCore.Mvc.RazorPages;
global using Microsoft.EntityFrameworkCore;
global using Microsoft.IdentityModel.Tokens;
global using TradingJournal.Application.Common.Interfaces;
global using TradingJournal.Application.Common.Models;
global using TradingJournal.Application.DependencyInjection;
global using TradingJournal.Application.Entities.Accounts.Commands.ChangeTradingAccountState;
global using TradingJournal.Application.Entities.Accounts.Commands.CreateTradingAccount;
global using TradingJournal.Application.Entities.Accounts.Commands.DeleteTradingAccount;
global using TradingJournal.Application.Entities.Accounts.Queries;
global using TradingJournal.Application.Entities.Reports.Queries.GetDailyReport;
global using TradingJournal.Application.Entities.Reports.Queries.GetMonthReportQuery;
global using TradingJournal.Application.Entities.Trades.Commands.HideTrade;
global using TradingJournal.Application.Entities.Trades.Commands.UpdateJournalingFields;
global using TradingJournal.Application.Trades.Queries;
global using TradingJournal.Domain.Entities;
global using TradingJournal.Infrastructure.DependencyInjection;
global using TradingJournal.Infrastructure.Persistence;
global using TradingJournal.Server.Authentication;
global using TradingJournal.Server.DependencyInjection;
