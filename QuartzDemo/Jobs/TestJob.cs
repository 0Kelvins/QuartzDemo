using log4net;
using Quartz;
using System;

namespace QuartzDemo
{
    /// <summary>
    /// 实现IJob接口
    /// </summary>
    public class TestJob : IJob
    {
        private readonly ILog _logger = LogManager.GetLogger(typeof(TestJob));

        public void Execute(IJobExecutionContext context)
        {
            _logger.InfoFormat("TestJob测试");
        }

    }
}