using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace kevin_abp.kevinModel
{
    public class kevinItem : BasicAggregateRoot<Guid>
    {
        public string Text { get; set; }
    }
}
