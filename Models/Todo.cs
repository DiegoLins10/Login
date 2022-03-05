using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyTodoApp.Models
{
    public class Todo
    {
        public int Id { get; set; }

        [DisplayName("Titulo")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Title { get; set; }

        [DisplayName("Concluído")]
        public bool Done { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime LastUpdateDate { get; set; } = DateTime.Now;
        public string User { get; set; }
    }
}
