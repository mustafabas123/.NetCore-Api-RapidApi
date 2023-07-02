using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.ViewComponents.Contact
{
    public class ContactCoverPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
