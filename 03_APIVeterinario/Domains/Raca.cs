﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIVeterinario.Domains
{

    //Domains é responsavel por guardar as propriedades
    public class Raca
    {

        public int IdRaca { get; set; }

        public string Descricao { get; set; }

        public int IdTipoDePet { get; set; }

    }
}
