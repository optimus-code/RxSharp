using RmSharp.Attributes;

namespace RxSharp.Rpg
{
    [RmName( "RPG::Class::Learning" )]
    public class ClassLearning
    {
        [RmName( "level" )]
        public int Level { get; set; } = 1;

        [RmName( "skill_id" )]
        public int SkillID { get; set; } = 1;
    }
}