
namespace CivilizationClicker.PlayerProfileNameSpace
{
	public class PlayerProfile : IPlayerProfile
	{
		[Inject] public IPlayerResource PlayerResource { get; set; }
	}
}
