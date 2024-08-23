using Btl_web_nc.RepositoryInterfaces;
using Microsoft.AspNetCore.Mvc;

public class NotificationViewComponent : ViewComponent
{
    private readonly INotifyRepositories _notifiesRepository;

    public NotificationViewComponent(INotifyRepositories notifiesRepository)
    {
        _notifiesRepository = notifiesRepository;
    }

    public IViewComponentResult Invoke(int userId)
    {
        var notifications = _notifiesRepository.GetNotifiesbyUserId(userId: userId);
        return View(notifications);
    }
}