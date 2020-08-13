using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hangfire;
using HangfireDemo.Core.Demo;
using Microsoft.AspNetCore.Mvc;

namespace HangfireSetup.Controllers
{
    [Route("/Api/HangFire")]

    public class HangFireController : Controller
    {
        private IDemoService demoService;
        public HangFireController(IDemoService demoService)
        {
            this.demoService = demoService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            RecurringJob.AddOrUpdate("demo-job",() => this.demoService.RunDemoTask(),
            Cron.Minutely);
            this.demoService.RunDemoTask();

            return Ok();
        }
    }
}