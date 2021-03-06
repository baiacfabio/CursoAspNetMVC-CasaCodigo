﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace AplicacaoComCodeFirst.Models
{
    public class Posts
    {
        [Key]
        public long PostID { get; set; }

        public string TituloPost { get; set; }

        public string ResumoPost { get; set; }

        public string ConteudoPost { get; set; }

        public DateTime DataPostagem { get; set; }

        public int CategoriaID { get; set; }

        [ForeignKey("CategoriaID")]
        public virtual Categorias Categorias { get; set; }

        [InverseProperty("Posts")]
        public virtual ICollection<Tags> Tags { get; set; }

        public Posts()
        {
            Tags = new HashSet<Tags>();
        }

    }
}
