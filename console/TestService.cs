using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace console
{
    public class TestService : ITestService
    {
        private readonly IConfiguration _configuration;

        private readonly ILogger _logger;

        public TestService(IConfiguration configuration, ILogger<TestService> logger)
        {
            _configuration = configuration ?? throw new ArgumentNullException($"{nameof(configuration)}");

            _logger = logger ?? throw new ArgumentNullException($"{nameof(logger)}");
        }

        public void Do()
        {
            var text = _configuration.GetSection($"{nameof(TestService)}").GetSection("text").Value;
            
            _logger.LogDebug(text);

            Console.WriteLine(text);
        }
    }
}