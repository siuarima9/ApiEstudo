using AutoMapper;

namespace Application.ProvaDev.AutoMapper
{
    public class AutoMapperConfiguration
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(cfg => {
                cfg.AddProfile(new DomainToViewModelMapping());
                cfg.AddProfile(new ViewModelToDomainMapping());
            });
        }
    }
}
