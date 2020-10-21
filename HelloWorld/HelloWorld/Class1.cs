namespace Oxide.Plugins
{
    [Info("hello world", "asdf", "0.0")]
    public class Class1 : RustPlugin
    {

        void Init()
        {
            Puts("Init!");
        }

        void OnPlayerConnected(Network.Message packet)
        {
            //Put kit
        }

    }
}
