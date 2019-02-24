using AutoMapper;
using PRT.Domain.Entitites;
using PRT.PRApplication.ViewModels;

namespace PRT.PRApplication.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserViewModel>()
              .ForMember(vm => vm.Id, map => map.MapFrom(m => m.Id))
              .ForMember(vm => vm.Name, map => map.MapFrom(m => m.Name))
              .ForMember(vm => vm.Email, map => map.MapFrom(m => m.Email))
              .ForMember(vm => vm.Password, map => map.MapFrom(m => m.Password))
              .ForMember(vm => vm.Status, map => map.MapFrom(m => m.Status));

            CreateMap<UserViewModel, User>()
              .ForMember(vm => vm.Id, map => map.MapFrom(m => m.Id))
              .ForMember(vm => vm.Name, map => map.MapFrom(m => m.Name))
              .ForMember(vm => vm.Email, map => map.MapFrom(m => m.Email))
              .ForMember(vm => vm.Password, map => map.MapFrom(m => m.Password))
              .ForMember(vm => vm.Status, map => map.MapFrom(m => m.Status));

            CreateMap<Todo, TodoViewModel>()
              .ForMember(vm => vm.Id, map => map.MapFrom(m => m.Id))
              .ForMember(vm => vm.Description, map => map.MapFrom(m => m.Description));

            CreateMap<TodoViewModel, Todo>()
              .ForMember(vm => vm.Id, map => map.MapFrom(m => m.Id))
              .ForMember(vm => vm.Description, map => map.MapFrom(m => m.Description));

        }        
    }
}