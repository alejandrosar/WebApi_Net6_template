//using AutoMapper;
//using Entities.TestEntity;
//using EntitiesDTOs.TestEntityDTOs;

//namespace Helpers.Automapper.TestEntityMap
//{
//    public class TestEntityProfile : Profile
//    {
//        public TestEntityProfile()
//        {
//            CreateMap<TestEntityFullInput_DTO, TestEntity>()
//                .ForMember(
//                    dest => dest.Id,
//                    opt => opt.MapFrom(src => 0)
//                )
//                .ForMember(
//                    dest => dest.Name,
//                    opt => opt.MapFrom(src => src.Name)
//                )                
//                .ForMember(
//                    dest => dest.Surname,
//                    opt => opt.MapFrom(src => src.Surname)
//                );

//            CreateMap<TestEntity, TestEntityToReturn_DTO>()
//            .ForMember(
//                dest => dest.Id,
//                opt => opt.MapFrom(src => src.Id)
//            )
//            .ForMember(
//                dest => dest.Name_Complete,
//                opt => opt.MapFrom(src => $"{src.Name + " " + src.Surname}")
//            );
            

//        }
//    }
//}
