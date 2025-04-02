using HMS.Dto.Base;


namespace HMS.DTO.DefinitionDTO.CRM.Health
{
    public class ProcedureTypeDTO : BaseDto
    {
        public ProcedureTypeDTO()
        {
        }

        public string Name { get; set; }
        public string Description { get; set; }
    }
}
