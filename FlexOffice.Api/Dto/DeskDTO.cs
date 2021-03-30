namespace FlexOffice.Api.Dto
{
    public class DeskDTO
    {
        public int Id { get; set; }
        public int DeskNumber { get; set; }
        public bool IsFree { get; set; }
        public string ShortDeskDescription { get; set; }
        public int LocationId {get; set;}
    }
}