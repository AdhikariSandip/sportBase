using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Shared.Enums
{
    public enum RowStatusOption
    {
        [Display(Name = "Save as Draft")]
        SaveAsDraft = -1,

        [Display(Name = "Newly Created")]
        NewlyCreated = 0,

        [Display(Name = "Verified")]
        Verified = 1,

        [Display(Name = "Modified")]
        Modified = 2,

        [Display(Name = "Rejected")]
        Rejected = 3,

    }
}
