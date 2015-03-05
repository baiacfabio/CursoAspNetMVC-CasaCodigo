using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AplicacaoComCodeFirst.Models
{
    public class Tags
    {
        [Key]
        public int TagID { get; set; }

        public string Tag { get; set; }

        public string Descricao { get; set; }

        [InverseProperty("Tags")]
        public virtual ICollection<Posts> Posts { get; set; }

        public Tags()
        {
            Posts = new HashSet<Posts>();
        }
    }
}