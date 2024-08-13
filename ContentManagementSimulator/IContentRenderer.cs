using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContentManagementSimulator
{
    public interface IContentRenderer
    {
        public void Render(IContentItem content);
    }
}
