using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Base.Shared.Base.BaseModels
{
   public abstract class RootModel
    {
        [Key]
        [Required]
        public Guid Id { get; set; }
        public InternalDataCollectionBase InternalDataCollectionBase { get; set; }
    }
    public class InternalData
    {
        public int MenuId { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public string ActionCause { get; set; }
        public dynamic ViewModelData { get; set; }
        public int UserId { get; set; }
        public DateTime CurrentDateTime { get; set; }
    }
}
