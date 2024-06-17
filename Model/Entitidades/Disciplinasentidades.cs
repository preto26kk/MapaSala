﻿using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entitidades
{
    public class Disciplinasentidades
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }
        public bool Ativo { get; set; }
        
        public object[] Linha()
        {
            return new object[] { Id, Nome, Sigla };
        }
    }
}
