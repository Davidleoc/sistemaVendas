﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaVendas.BLL_Classes
{
    internal class userBLL_Class
    {
        public int id { get; set; }
        
        public string nome { get; set; }
        
        public string email { get; set; }
        
        public string usuario { get; set; }
        
        public string senha { get; set; }

        public string tipo_usuario { get; set; }

        public DateTime add_data { get; set; }

        public int add_por { get; set; }
    }
}
