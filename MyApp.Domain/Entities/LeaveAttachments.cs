using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Domain.Entities
{
    public class LeaveAttachments
    {
        public Guid AttachmentId { get; private set; }

        public Guid LeaveRequestId { get; private set; }

        public string FileName { get; private set; } = string.Empty;
        public string FilePath { get; private set; } = string.Empty;
        public string ContentType { get; private set; } = string.Empty;
        public DateTime UploadedAt { get; private set; }
        public virtual LeaveRequests LeaveRequest { get; private set; } = null!;


        protected LeaveAttachments() { }
    }
}
