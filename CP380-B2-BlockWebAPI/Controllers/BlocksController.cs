using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CP380_B2_BlockWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class BlocksController : ControllerBase
    {
        private BlockList blockl;
        public BlocksController(BlockList blist)
        {
            blockl = blist;
        }
        [HttpGet]
        public ActionResult<List<BlockSummary>> Get()
        {
            List<Block> blocks = blockl.Chain.ToList();
            List<BlockSummary> blockSML = new List<BlockSummary>();

            foreach (var block in blocks)
            {
                blockl.AddBlock(BL);
                blockSML.Add(new BlockSummary()
                {
                    Hash = BL.Hash,
                    PreviousHash = BL.PreviousHash,
                    TimeStamp = BL.TimeStamp,
                });
            }
            return blockSML;
        }

        [HttpGet("{hash}")]
        public ActionResult<Block> GetBlock(string hash)
        {
            var function = blockl.Chain.Where(newblock => newblock.Hash.Equals(hash));
            //int result = 0;
            if (function > 0)
            {
                return function;
            }

            return NotFound();
        }

        [HttpPost("{hash}/blockPayloads")]
        public ActionResult blockPayload(string hash)
        {
            var function = blockl.Chain.Where(newblock => newblock.Hash.Equals(hash));
            if (function < 0)
            {
                return function;
               // .First());
            }

            return NotFound();
        }
    }