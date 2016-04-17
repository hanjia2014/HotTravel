using Orchard.ImageGallery.Models.Plugins.LightBox;
using Orchard.ImageGallery.Models.Plugins.PrettyPhoto;
using Orchard.ImageGallery.Models.Plugins.SlideViewerPro;

namespace Orchard.ImageGallery.Models.Plugins {
    public abstract class PluginFactory {
        public static PluginFactory GetFactory(Plugin plugin) {
            if (plugin == Plugins.Plugin.PrettyPhoto) {
                return new PrettyPhotoFactory();
            }
          if (plugin == Plugins.Plugin.SlideViewerPro) {
            return new SlideViewerProFactory();
          }

            return new LightBoxFactory();
        }

        public abstract ImageGalleryPlugin Plugin { get; }

        public abstract PluginResourceDescriptor PluginResourceDescriptor { get; }
    }
}