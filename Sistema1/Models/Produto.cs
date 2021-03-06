﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sistema1.Models
{
    public class Produto
    {
        [Key]
        public int ID { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public DateTime UltimaCompra { get; set; }
        public float Estoque { get; set; }
        public string Informacoes { get; set; }
    }
}