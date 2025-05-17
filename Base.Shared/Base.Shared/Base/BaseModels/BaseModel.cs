using Base.Shared.Enums;

namespace Base.Shared.Base.BaseModels
{
    public abstract class BaseModel : RootModel
    {
        public RowStatusOption Status { get; set; }
        public DateTime StatusChangeDate { get; set; }

    }
}
