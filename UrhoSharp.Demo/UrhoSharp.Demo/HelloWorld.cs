using System.Threading.Tasks;
using Urho;
using Urho.Actions;
using Urho.Gui;

namespace UrhoSharp.Demo
{
    public class HelloWorld : Application
    {
        protected override void Start()
        {
            base.Start();

            CreateScene();
        }

        private void CreateScene()
        {
            // Create Text Element
            var text = new Text()
            {
                Value = "Hello World!",
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center
            };

            text.SetColor(Color.Cyan);
            text.SetFont(font: ResourceCache.GetFont("Fonts/Anonymous Pro.ttf"), size: 30);
            // Add to UI Root
            UI.Root.AddChild(text);

        }

    }
}
