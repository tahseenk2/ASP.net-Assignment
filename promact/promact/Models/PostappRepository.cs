using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace promact.Models
{
    public class PostappRepository:IPostappRepository
    {
        private readonly AppDbContext _context;
        public PostappRepository(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Postapp> AllMessage => _context.Message;

        public Postapp GetMessageById(int messageID)
        {
            return _context.Message.FirstOrDefault(m => m.messageID == messageID);
        }


    }
}
