namespace FlexOffice.Api.Dto
{
    public class DeskCreateDTO
    {
        public int DeskNumber { get; set; }
        public bool IsFree { get; set; }
        public string ShortDeskDescription { get; set; }
        public int LocationId {get; set;}
    }
}