using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JSProject.Models
{
    public class AjaxModel
    {
        public string Name { get; set; }
        public IFormFileCollection Photos { get; set; }
    }
}
