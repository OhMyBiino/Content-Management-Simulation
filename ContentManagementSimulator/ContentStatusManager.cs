using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContentManagementSimulator
{
    public abstract class ContentStatusManager 
    {
        public void MarkAsPublished(IContentItem content) 
        {
            content.Status = ContentStatus.published;
        }
        public void MarkAsUnpublished(IContentItem content) 
        {
            content.Status = ContentStatus.unpublished;
        }
        public void MarkAsDrafted(IContentItem content) 
        {
            content.Status = ContentStatus.drafted;
        }
        public void MarkAsArchived(IContentItem content)
        {
            content.Status = ContentStatus.archived;
        }
        public void MarkAsDeleted(IContentItem content)
        {
            content.Status = ContentStatus.deleted;
        }
        public void MarkAsScheduled(IContentItem content)
        {
            content.Status = ContentStatus.scheduled;
        }

    }
}
