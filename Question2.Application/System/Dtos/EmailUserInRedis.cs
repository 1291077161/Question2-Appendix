using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emmm.Application.System.Dtos
{
    public class EmailUserInRedis
    {
        public int? id { get; set; }

        // public bool? Id { get; set; }
        public string? email { get; set; }

        public string? user { get; set; }
        public string? token { get; set; }
        public string? time { get; set; }
        public string? error { get; set; }
    }
}