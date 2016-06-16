using DungeonMasterEngine.DungeonContent.Tiles;

namespace DungeonMasterEngine.DungeonContent.Actuators.Wall
{
    class Sensor2 : Sensor<IActuatorX>
    {
        protected override bool Interact(ILeader theron, WallActuator actuator, bool isLast, out bool L0753_B_DoNotTriggerSensor)
        {
            L0753_B_DoNotTriggerSensor = ((theron.Hand == null) != RevertEffect);
            return true;
        }

        public Sensor2(SensorInitializer<IActuatorX> initializer) : base(initializer) { }
    }
}