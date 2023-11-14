using System;

namespace BlazorApp.Pages
{
    public partial class ToonFoto
    {
        private readonly Random rnd = new Random();
        private string foto = "";
        private readonly string[] fotos = { "breakfast.jpg", "flower.jpg", "flower_red.jpg", "fontain.jpg", "lunch.jpg", "sunset.jpg" };

        protected override void OnInitialized()
        {
            RandomFoto();
        }

        private void RandomFoto()
        {
            int index = rnd.Next(0, fotos.Length);
            foto = fotos[index];
        }
    }
}
