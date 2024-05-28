namespace Hearthstone.LethalCalculator.Application.Mappers;

public interface IMapper<TDto, TModel>
{
    TDto Map(TModel domain);
    TModel Map(TDto dto);
}
