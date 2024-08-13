using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContentManagementSimulator
{
    public interface IContentManager : IContentSaver, IContentRenderer
    {
        public List<IContentItem> contents { get; }
        public void SaveAll();
        public void RenderAll();
    }
}
