using NetModular.Lib.Data.Abstractions.Attributes;
using NetModular.Lib.Utils.Core.Extensions;

namespace NetModular.Module.Quartz.Domain.Job
{
    public partial class JobEntity
    {
        /// <summary>
        /// ������������
        /// </summary>
        [Ignore]
        public string TypeName => JobType.ToDescription();
    }
}
