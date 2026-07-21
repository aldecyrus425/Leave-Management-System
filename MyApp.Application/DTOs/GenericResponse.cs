using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.DTOs
{
    public class GenericResponse<T>
    {
        public bool success { get; set; }
        public string message { get; set; }
        public T? Data { get; set; }
    }
}
