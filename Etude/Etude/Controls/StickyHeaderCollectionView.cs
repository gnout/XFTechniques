using System.Threading.Tasks;
using Xamarin.Forms;

namespace Etude.Controls
{
    public class StickyHeaderCollectionView : CollectionView
    {
        [TypeConverter(typeof(ReferenceTypeConverter))]
        public View DisappearingContent
        {
            set
            {
                _disappearingContent = value;
                _disappearingContent.SizeChanged += (o, e) => this.Header = new BoxView() { HeightRequest = _disappearingContent.Height };
            }
        }

        private View _disappearingContent;

        [TypeConverter(typeof(ReferenceTypeConverter))]
        public View StickyContent
        {
            set => _stickyContent = value;
        }

        private View _stickyContent;

        public StickyHeaderCollectionView()
        {
            Scrolled += StickyHeaderCollectionView_Scrolled;
        }

        private async void StickyHeaderCollectionView_Scrolled(object sender, ItemsViewScrolledEventArgs e)
        {
            double scrollY = e.VerticalOffset < 0 ? 0 : e.VerticalOffset;
            scrollY = scrollY > _disappearingContent.Height ? _disappearingContent.Height : scrollY;

            // Show or hide the header and scroll the second view
            await Task.WhenAll(_disappearingContent?.TranslateTo(0, -scrollY, 50),
                _stickyContent?.TranslateTo(0, -scrollY + _disappearingContent.Height, 50));
        }
    }
}
