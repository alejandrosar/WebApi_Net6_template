using AutoMapper;
using Entities.LongFile;
using EntitiesDTOs.LongFileDTOs;
using Helpers.Files;

namespace WebApi_6.Automapper.LongFileMaps
{
    public class LongFileProfile : Profile
    {
        public LongFileProfile()
        {
            CreateMap<LongFileInput_DTO, LongFile>()
                .ForMember(
                    dest => dest.Id,
                    opt => opt.MapFrom(src => 0)
                )
                .ForMember(
                    dest => dest.Name,
                    opt => opt.MapFrom(src => src.Name)
                )
                .ForMember(
                    dest => dest.File,
                    opt => opt.MapFrom(src => FileConversion.IformFileToMemoryStream(src.File))
                )
                .ForMember(
                    dest => dest.Extension,
                    opt => opt.MapFrom(src => src.Extension)

                );

            CreateMap<LongFile, LongFileToReturn_DTO>()
            .ForMember(
                dest => dest.Id,
                opt => opt.MapFrom(src => src.Id)
            )
            .ForMember(
                dest => dest.Name,
                opt => opt.MapFrom(src => src.Name)
            )
            .ForMember(
                dest => dest.Extension,
                opt => opt.MapFrom(src => src.Extension)
            )
            .ForMember(
                dest => dest.File,
                opt => opt.MapFrom(src => FileConversion.ConvertToBase64(src.File))
            );


        }
    }
}
