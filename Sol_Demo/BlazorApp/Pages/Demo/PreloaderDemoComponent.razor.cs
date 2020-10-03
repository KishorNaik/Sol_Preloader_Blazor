using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Pages.Demo
{
    public partial class PreloaderDemoComponent
    {
        #region Private Property

        private bool IsLoad { get; set; }

        #endregion Private Property

        #region Protected Member

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                // Long Running Process
                await Task.Delay(8000);

                IsLoad = true;

                base.StateHasChanged();
            }
        }

        #endregion Protected Member
    }
}