using System.ComponentModel.DataAnnotations;


namespace TestDeployment.Database.DTOs
{
    public class Test
    {
        [Key]
        public int TestID { get; set; }

        public string Name { get; set; }
    }
}
