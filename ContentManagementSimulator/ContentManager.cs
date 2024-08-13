using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContentManagementSimulator
{
    public class ContentManager : IContentManager
    {
        public List<IContentItem> contents { get; private set; }

        public void Save(IContentItem content)
        {
            
        }

        public void Render(IContentItem content)
        {

        }

        public void SaveAll()
        {
            foreach(IContentItem content in contents)
            {
             
            }
        }

        public void RenderAll()
        {
            foreach(IContentItem content in contents)
            {
            
            }
        }
    }
}
