using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pets.GetById;

public class GetPetByIdUseCase
{
    public ResponsePetJson Execute(int id)
    {
        return new ResponsePetJson
        {
            Id = id,
            Name = "Fred",
            Birthday = new DateTime(year: 2018, month: 12, day: 25),
            Type = Communication.Enums.PetType.Cat
        };
    }
}
