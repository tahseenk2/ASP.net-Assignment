using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace promact.Models
{
    public interface IPostappRepository
    {
        IEnumerable<Postapp> AllMessage { get; }
        Postapp GetMessageById(int messageID);
    }
}
