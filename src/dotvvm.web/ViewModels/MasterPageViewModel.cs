using DotVVM.Framework.ViewModel;
using DotVVM.Framework.Runtime.Filters;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace dotvvm.web.ViewModels
{
    [Authorize]
    public class MasterPageViewModel : DotvvmViewModelBase
    {
        public string Username => Context.HttpContext.User.FindFirst("name")?.Value;
    }
}