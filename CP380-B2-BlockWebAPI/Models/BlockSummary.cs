using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CP380_B2_BlockWebAPI.Models
{
    public class BlockSummary
    {
        public DateTime TimeStamp 
        { get; set; }
        public string PreviousHash 
        { get; set; }
        public string Hash
        { get; set; }

        public BlockSummary()
        {
            List<Payload> data = new() { };

            var block = new Block(DateTime.Now, 0, data);
            {
                this.TimeStamp = block. TimeStamp;
                this.PreviousHash = block. PreviousHash;
                this.Hash. = block.Hash;
            }
        }
    }
}
