﻿using System;
using NetModular.Lib.Data.Abstractions.Attributes;
using NetModular.Lib.Data.Core.Entities;

namespace NetModular.Module.Quartz.Domain.JobLog
{
    /// <summary>
    /// 任务日期
    /// </summary>
    [Table("Job_Log")]
    public class JobLogEntity : Entity<int>
    {
        /// <summary>
        /// 任务编号
        /// </summary>
        public Guid JobId { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        public JobLogType Type { get; set; }

        /// <summary>
        /// 内容信息
        /// </summary>
        [Max]
        public string Msg { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreatedTime { get; set; }
    }
}
