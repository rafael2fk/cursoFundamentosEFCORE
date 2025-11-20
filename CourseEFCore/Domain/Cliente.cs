using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseEFCore.Domain
{
    [Table("Clientes")] // na bd nao e "cliente" e sim "Clientess"
    public class Cliente
    {
        [Key]  //chave primaria
        public int Id { get; set; }

        [Required] // propriedade obrigatorio
        public string Nome { get; set; }

        [Column("Phone")]   // informa que pode ter outro nome na tabela "parecido"
        public string Telefone { get; set; }

        public string CEP { get; set; }

        public string Estado { get; set; }

        public string Cidade { get; set; }
    }
}
