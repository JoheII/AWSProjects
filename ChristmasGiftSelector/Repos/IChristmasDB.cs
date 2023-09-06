using ChristmasGiftSelector.Models;

namespace ChristmasGiftSelector.Repos;

public interface IChristmasDB
{
    public Task<Recipient> GetGiftPerson();
    public Task AddUser(User user);
    public Task DeleteUser(User user);
    public Task EditUser(User user);
    public Task CreateNewGiftGroup(GiftGroup giftGroup);
}