using DungeonMasterEngine.DungeonContent.EntitySupport.Properties;
using DungeonMasterEngine.DungeonContent.EntitySupport.Properties.@base;
using DungeonMasterEngine.DungeonContent.EntitySupport.Skills.@base;
using DungeonMasterEngine.DungeonContent.GroupSupport;
using Microsoft.Xna.Framework;

namespace DungeonMasterEngine.DungeonContent.EntitySupport.Skills
{
    public class WizardSkill : SkillBase
    {
        public override ISkillFactory Factory => SkillFactory<WizardSkill>.Instance;
        public override SkillBase BaseSkill => null; 

        protected override void ApplySkills(int majorIncrease, int minorIncrease)
        {
            entity.GetProperty(PropertyFactory<VitalityProperty>.Instance).BaseValue += rand.Next(2) & BaseSkillLevel;
            int stamina = entity.GetProperty(PropertyFactory<StaminaProperty>.Instance).BaseValue >> 5;
            int skillLevelModifer = BaseSkillLevel;
            entity.GetProperty(PropertyFactory<ManaProperty>.Instance).BaseValue += skillLevelModifer + (skillLevelModifer>> 1) + MathHelper.Min(rand.Next(4), skillLevelModifer - 1);
            entity.GetProperty(PropertyFactory<WisdomProperty>.Instance).BaseValue += majorIncrease; 
            entity.GetProperty(PropertyFactory<AntiMagicProperty>.Instance).BaseValue += rand.Next(3); 
            entity.GetProperty(PropertyFactory<HealthProperty>.Instance).BaseValue += skillLevelModifer + rand.Next((skillLevelModifer >> 1) + 1);
            entity.GetProperty(PropertyFactory<StaminaProperty>.Instance).BaseValue += stamina + rand.Next((stamina >> 1) + 1);
        }

        public WizardSkill(IEntity entity) : base(entity) {}
    }
}