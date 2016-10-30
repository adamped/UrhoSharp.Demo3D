using System.Threading.Tasks;
using Urho;
using Urho.Actions;
using Urho.Gui;

namespace UrhoSharp.Demo
{
    public class HelloWorld : Application
    {
        public HelloWorld() { }
        public HelloWorld(ApplicationOptions options) : base(options) { }

        protected override async void Start()
        {
            base.Start();

            await Create3DObject();
        }

        private async Task Create3DObject()
        {
            // Scene
            var scene = new Scene();
            scene.CreateComponent<Octree>();

            // Node (Rotation and Position)
            Node node = scene.CreateChild();
            node.Position = new Vector3(0, 0, 5);
            node.Rotation = new Quaternion(10, 60, 10);
            node.SetScale(1f);

            // Pyramid Model
            StaticModel modelObject = node.CreateComponent<StaticModel>();
            modelObject.Model = ResourceCache.GetModel("Models/Pyramid.mdl");
            
            // Light
            Node light = scene.CreateChild(name: "light");
            light.SetDirection(new Vector3(0.4f, -0.5f, 0.3f));
            light.CreateComponent<Light>();
            
            // Camera
            Node cameraNode = scene.CreateChild(name: "camera");
            Camera camera = cameraNode.CreateComponent<Camera>();

            // Viewport
            Renderer.SetViewport(0, new Viewport(scene, camera, null));

            // Action
            await node.RunActionsAsync(
                new RepeatForever(new RotateBy(duration: 1,
                    deltaAngleX: 0, deltaAngleY: 90, deltaAngleZ: 0)));

        }

    }
}
