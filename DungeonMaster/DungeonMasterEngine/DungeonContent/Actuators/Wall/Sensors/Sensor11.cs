using DungeonMasterEngine.DungeonContent.Tiles;

namespace DungeonMasterEngine.DungeonContent.Actuators.Wall
{
    class Sensor11 : SubXc017c011
    {
        protected override bool Interact(ILeader theron, ActuatorX actuator, bool isLast, out bool L0753_B_DoNotTriggerSensor)
        {
            if (!base.Interact(theron, actuator, isLast, out L0753_B_DoNotTriggerSensor))
                return false; ;

            if (!L0753_B_DoNotTriggerSensor)
            {
                F270_xxxx_SENSOR_TriggerLocalEffect(theron, actuator, true); /* This will cause a rotation of the sensors at the specified cell on the specified square after all sensors have been processed */
            }
            return true;
        }

        public Sensor11(ItemConstrainSensorInitalizer initializer) : base(initializer) { }
    }
}