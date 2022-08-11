using Microsoft.Extensions.DependencyInjection;
using MyTravel.portal.Areas.Blog.Controllers;
using Sitecore.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyTravel.portal
{
	public class GlassCustomConfigurator : IServicesConfigurator
	{
		public void Configure(IServiceCollection serviceCollection)
		{
			serviceCollection.AddTransient<PageController>();
		}
	}
}