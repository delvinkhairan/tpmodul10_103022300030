using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Web.Http;
using tpmodul10_103022300030.Controllers;

namespace MOD10_103022300030.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> mahasiswaList = new List<Mahasiswa>
        {
            new Mahasiswa("Delvin Khairan Rabbani", "103022300030"), 
            new Mahasiswa("Christiano", "1302000001"),
            new Mahasiswa("Ballerina Cappucina", "1302000002")
        };

        [HttpGet]
        public ActionResult<IEnumerable<Mahasiswa>> Get()
        {
            return mahasiswaList;
        }

        [HttpGet("{id}")]
        public ActionResult<Mahasiswa> Get(int id)
        {
            if (id < 0 || id >= mahasiswaList.Count)
                return NotFound();

            return mahasiswaList[id];
        }

        [HttpDelete("{id}")]
        public ActionResult<IEnumerable<Mahasiswa>> Delete(int id)
        {
            if (id < 0 || id >= mahasiswaList.Count)
                return KeyNotFoundException();

            mahasiswaList.RemoveAt(id);
            return mahasiswaList;
        }

        private ActionResult<IEnumerable<Mahasiswa>> KeyNotFoundException()
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public ActionResult<IEnumerable<Mahasiswa>> Post([FromBody] Mahasiswa mahasiswa)
        {
            mahasiswaList.Add(mahasiswa);
            return mahasiswaList;
        }

        
    }

    public class ControllerBase
    {
    }

    public class ActionResult<T>
    {
    }
}