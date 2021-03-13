﻿using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;
using System;
using Microsoft.Extensions.Configuration;
using Celebrity;

namespace Hellang.Middleware.ProblemDetails
{
    public static class ProblemDetailsExtensions
    {
        public static IServiceCollection AddProblemDetails(this IServiceCollection services, IWebHostEnvironment environment, IConfiguration configuration) =>
           services.AddProblemDetails(configure =>
           {
               configure.IncludeExceptionDetails = (context, exception) => environment.EnvironmentName == "Development";

               configure.Map<DomainException>(exception =>
               {
                   Serilog.Log.Logger.Warning(exception.Message);
                   return new Microsoft.AspNetCore.Mvc.ProblemDetails()
                   {
                       Title = exception.Message,
                       Detail = exception.StackTrace,
                       Status = StatusCodes.Status400BadRequest,
                       Type = nameof(DomainException)
                   };
               });

               configure.Map<ArgumentException>(exception =>
               {
                   Serilog.Log.Logger.Warning(exception.Message);
                   return new Microsoft.AspNetCore.Mvc.ProblemDetails()
                   {
                       Title = exception.Message,
                       Detail = exception.StackTrace,
                       Status = StatusCodes.Status400BadRequest,
                       Type = nameof(DomainException)
                   };
               });

               configure.Map<NotFoundException>(exception =>
               {
                   return new Microsoft.AspNetCore.Mvc.ProblemDetails()
                   {
                       Title = exception.Message,
                       Detail = exception.StackTrace,
                       Status = StatusCodes.Status404NotFound,
                       Type = nameof(NotFoundException)
                   };
               });

               configure.Map<UnauthorizedAccessException>(exception =>
               {
                   return new Microsoft.AspNetCore.Mvc.ProblemDetails()
                   {
                       Title = exception.Message,
                       Detail = exception.StackTrace,
                       Status = StatusCodes.Status401Unauthorized,
                       Type = nameof(UnauthorizedAccessException)
                   };
               });

               configure.Map<Exception>(exception =>
               {
                   Serilog.Log.Logger.Error(exception.Message);
                   return new Microsoft.AspNetCore.Mvc.ProblemDetails()
                   {
                       Title = exception.Message,
                       Detail = exception.StackTrace,
                       Status = StatusCodes.Status500InternalServerError,
                       Type = nameof(Exception)
                   };
               });
           });
    }
}
