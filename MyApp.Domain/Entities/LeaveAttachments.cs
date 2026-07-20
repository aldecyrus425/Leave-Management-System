using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Domain.Entities
{
    public class LeaveAttachments
    {
        // Primary Key
        public Guid AttachmentId { get; private set; }

        // Foreign Key
        public Guid LeaveRequestId { get; private set; }

        // Attachment Details
        public string FileName { get; private set; } = string.Empty;
        public string FilePath { get; private set; } = string.Empty;
        public string ContentType { get; private set; } = string.Empty;
        public DateTime UploadedAt { get; private set; }

        // Navigation Property
        public virtual LeaveRequests LeaveRequest { get; private set; } = null!;


        protected LeaveAttachments() { }
    }
}
