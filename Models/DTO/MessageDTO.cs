namespace CitasMedicas.Models.DTO
{
    public class MessageDTO
    {
        public int Code { get; set; }

        public object Data { get; set; }

        public MessageDTO(int code, object data)
        {
            Code = code;
            Data = data;
        }
    }
}