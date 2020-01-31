using System;
using Microsoft.Extensions.Logging;

namespace console
{
    public class ConsoleApplication
    {
        private readonly ITestService _testService;

        private readonly ILogger<ConsoleApplication> _logger;

        public ConsoleApplication(ITestService testService, ILogger<ConsoleApplication> logger)
        {
            _testService = testService ?? throw new ArgumentNullException($"{nameof(testService)}");
            _logger = logger ?? throw new ArgumentNullException($"{nameof(logger)}");
        }

        public void Run()
        {
            _logger.LogInformation("Starting");

            _testService.Do();
            
            _logger.LogInformation("Finishing");
        }
    }
};
