﻿using SeleniumSpecFlowFrameWork.Global;
using SeleniumSpecFlowFrameWork.L2_StepDefinitions.Hooks;
using SeleniumSpecFlowFrameWork.L3_SeleniumCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SeleniumSpecFlowFrameWork.L2_StepDefinitions
{
    [Binding]
    public class CommonPageSteps
    {

        ShareStateObjects sso;

        public CommonPageSteps(ShareStateObjects _sso)
        {
            this.sso = _sso;

        }

        [Given(@"I navigate to the authentication page")]
        [Given(@"The user navigate to the authentication page")]
        public void GivenINavigateToTheAuthenticationPage()
        {
            new CommonPage(sso).NavigateTo(DataHooks.EnvData["baseurl"] + "/index.php?controller=authentication&back=my-account");
        }

        [Given(@"The user navigates to home page")]
        public void GivenTheUserNavigatesToHomePage()
        {
            new CommonPage(sso).NavigateTo(DataHooks.EnvData["baseurl"]);
        }

    }
}
