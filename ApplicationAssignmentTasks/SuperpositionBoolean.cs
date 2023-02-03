namespace ApplicationAssignmentTasks
{
    public class SuperpositionBoolean
    {
        public static bool operator ==(SuperpositionBoolean a, bool b) => true;
        public static bool operator !=(SuperpositionBoolean a, bool b) => false;
    }
}