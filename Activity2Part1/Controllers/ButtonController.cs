using Activity2Part1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Activity2Part1.Controllers
{
    public class ButtonController : Controller
    {
        static public List<ButtonModel> buttons;
        Random rand = new Random();
        // GET: Button
        public ActionResult Index()
        {
            buttons = getButtonList();
            return View("Button", buttons);
        }

        public ActionResult OnButtonClick(string mine)
        {
            int buttonNumber = Int32.Parse(mine);
            buttons[buttonNumber].State = !buttons[buttonNumber].State;
            return View("Button", buttons);
        }

        private List<ButtonModel> getButtonList()
        {
            buttons = new List<ButtonModel>();
            for (int i = 0; i < 25; i++)
            {
                if (rand.Next(10) > 5)
                    buttons.Add(new ButtonModel(true));
                else
                    buttons.Add(new ButtonModel(false));
            }
            return buttons;
        }
    }
}