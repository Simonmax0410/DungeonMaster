using System.Linq;
using DungeonMasterEngine.DungeonContent.Actuators;
using DungeonMasterEngine.DungeonContent.Tiles.Support;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace DungeonMasterEngine.DungeonContent.Tiles.Renderers
{
    public class FountainRenderer : DecorationRenderer<Fountain>
    {
        public FountainRenderer(Texture2D decorationTexture, Fountain item) : base(decorationTexture, item) { }

        public override bool Interact(ILeader leader, ref Matrix currentTransformation, object param)
        {
            if (base.Interact(leader, ref currentTransformation, param))
            {
                return Item.Trigger(leader);
            }
            return false; ;
        }
    }


    public class AlcoveRenderer : DecorationRenderer<Alcove>
    {
        public AlcoveRenderer(Texture2D decorationTexture, Alcove item) : base(decorationTexture, item)
        { }

        public override Matrix Render(ref Matrix currentTransformation, BasicEffect effect, object parameter)
        {
            var baseTransformation = base.Render(ref currentTransformation, effect, parameter);
            int j = 1;
            foreach (var i in Item.Items.Reverse())
            {
                Matrix finalTransformation = Matrix.CreateScale(1 / 0.33f) * Matrix.CreateTranslation(new Vector3(0, -0.2f, (j++ * Epsilon))) * baseTransformation;
                i.Renderer?.Render(ref finalTransformation, effect, parameter);
            }

            return baseTransformation;
        }

        public override bool Interact(ILeader leader, ref Matrix currentTransformation, object param)
        {
            if (base.Interact(leader, ref currentTransformation, param))
            {
                return Item.Trigger(leader);
            }
            return false;
        }
    }
}