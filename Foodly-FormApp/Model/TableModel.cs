using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foodly_FormApp.Model
{
    public class TableModel
    {
        [Key]
        public int Id { get; set; }

        public int Size { get; set; }

        public int Sitters { get; set; }

        public ICollection<MenuItemModel> OrderedItems { get; set; }

    }
}
