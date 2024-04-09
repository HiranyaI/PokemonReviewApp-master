using AutoMapper;
using PokemonReviewApp.Dto;
using PokemonReviewApp.Properties.Models;

namespace PokemonReviewApp.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles() { 
        
            CreateMap<Pokemon, PokemonDto>();  
            CreateMap<Category, CategoryDto>();
            CreateMap<Country, CountryDto>();
            CreateMap<Owner, OwnerDto>();
            CreateMap<Reviewer, ReviewerDto>();
            CreateMap<Review, ReviewerDto>();

        }
    }
}   
