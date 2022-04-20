using Microsoft.AspNetCore.Components;

namespace AngWater.Pages
{
    public partial class Channel: ComponentBase
    {
        private int _id;
        [Parameter]
        public int Id 
        { 
            get 
            {
                return _id;
            }
            set 
            {
                _id = value;

                if (_id == 1)
                {
                    ActiveChannel = Tabs.Channel1;
                }
                if (_id == 2)
                {
                    ActiveChannel = Tabs.Channel2;
                }
                if (_id == 3)
                {
                    ActiveChannel = Tabs.Channel3;
                }
                if (_id == 4)
                {
                    ActiveChannel = Tabs.Channel4;
                }

                StateHasChanged();
            }
        }

        public Tabs ActiveChannel { get; set; }
    }

    public enum Tabs
    {
        Channel1,
        Channel2,
        Channel3,
        Channel4
    }
}
