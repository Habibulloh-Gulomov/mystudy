namespace Service.DTO.CourseDTO
{
    public class CourseRequest
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Length { get; set; }

        public int Price { get; set; }
    }
}