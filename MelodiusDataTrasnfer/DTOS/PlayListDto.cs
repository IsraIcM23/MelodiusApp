using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodiusDataTrasnfer.DTOS
{
    public class PlayListDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime DateOfCreation { get; set; }
        public string? Description { get; set; }
        public bool IsPrivate { get; set; }
        public int? TotalLength { get; set; }
        public int UserId { get; set; }
    }
}
