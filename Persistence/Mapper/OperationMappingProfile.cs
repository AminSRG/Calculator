using AutoMapper;
using Domain.Model;
using Persistence.ViewModel;

namespace Persistence.Mapper
{
    public class OperationMappingProfile : Profile
    {
        public OperationMappingProfile() : base()
        {
            CreateMap<OperationViewModel, Operation>();
            CreateMap<Operation, OperationViewModel>();
        }
    }
}
