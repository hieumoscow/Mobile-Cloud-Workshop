﻿using System;
using FreshMvvm;

namespace ContosoFieldService.PageModels
{
    public class DashboardPageModel : FreshBasePageModel
    {
        bool showLogin;
        protected override void ViewIsAppearing(object sender, EventArgs e)
        {
            base.ViewIsAppearing(sender, e);
            if (showLogin)
            {
                showLogin = false;
                CoreMethods.PushPageModel<LoginPageModel>(null, true, false);
            }
        }

        public override void Init(object initData)
        {
            base.Init(initData);

            if (Helpers.Settings.UserIsLoggedIn == false)
                showLogin = true;
        }
    }
}
