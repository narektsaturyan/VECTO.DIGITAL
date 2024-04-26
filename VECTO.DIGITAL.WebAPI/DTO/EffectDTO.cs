namespace VECTO.DIGITAL.WebAPI.DTO
{
    public class EffectDTO
    {
        public Guid Id { get; set; }
        //Should have dynamic solution for each effect to have different parameter type.
        public object EffectParamter { get; set; }
    }
}
