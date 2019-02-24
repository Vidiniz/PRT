using AutoMapper;

namespace PRT.PRApplication.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings() 
        {   
            Mapper.Initialize(x =>
            {
                x.AddProfile<MappingProfile>();
            });            
        }
    }
}