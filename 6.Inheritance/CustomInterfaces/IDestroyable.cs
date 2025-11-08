namespace CustomInterfaces
{
    interface IDestroyable
    {
        // Property to store audio of the destruction sound
        string DestructionSound { get; set; }

        // Method to destroy an object
        void Destroy();
    }
}