/*This script has been, partially or completely, generated by the Fungus.GenerateVariableWindow*/
using UnityEngine;


namespace Fungus
{
    // <summary>
    /// Get or Set a property of a Rigidbody2D component
    /// </summary>
    [CommandInfo("Property",
                 "Rigidbody2D",
                 "Get or Set a property of a Rigidbody2D component")]
    [AddComponentMenu("")]
    public class Rigidbody2DProperty : BaseVariableProperty
    {
		//generated property
        public enum Property 
        { 
            Position, 
            Rotation, 
            Velocity, 
            AngularVelocity, 
            UseAutoMass, 
            Mass, 
            CenterOfMass, 
            WorldCenterOfMass, 
            Inertia, 
            Drag, 
            AngularDrag, 
            GravityScale, 
            UseFullKinematicContacts, 
            IsKinematic, 
            FreezeRotation, 
            Simulated, 
            AttachedColliderCount, 
        }

		
        [SerializeField]
        protected Property property;
		
        [SerializeField]
        protected Rigidbody2DData rigidbody2DData;

        [SerializeField]
        [VariableProperty(typeof(Vector2Variable),
                          typeof(FloatVariable),
                          typeof(BooleanVariable),
                          typeof(IntegerVariable))]
        protected Variable inOutVar;

        public override void OnEnter()
        {
            var iov2 = inOutVar as Vector2Variable;
            var iof = inOutVar as FloatVariable;
            var iob = inOutVar as BooleanVariable;
            var ioi = inOutVar as IntegerVariable;


            var target = rigidbody2DData.Value;

            switch (getOrSet)
            {
                case GetSet.Get:
                    switch (property)
                    {
                        case Property.Position:
                            iov2.Value = target.position;
                            break;
                        case Property.Rotation:
                            iof.Value = target.rotation;
                            break;
                        case Property.Velocity:
                            iov2.Value = target.velocity;
                            break;
                        case Property.AngularVelocity:
                            iof.Value = target.angularVelocity;
                            break;
                        case Property.UseAutoMass:
                            iob.Value = target.useAutoMass;
                            break;
                        case Property.Mass:
                            iof.Value = target.mass;
                            break;
                        case Property.CenterOfMass:
                            iov2.Value = target.centerOfMass;
                            break;
                        case Property.WorldCenterOfMass:
                            iov2.Value = target.worldCenterOfMass;
                            break;
                        case Property.Inertia:
                            iof.Value = target.inertia;
                            break;
                        case Property.Drag:
                            iof.Value = target.drag;
                            break;
                        case Property.AngularDrag:
                            iof.Value = target.angularDrag;
                            break;
                        case Property.GravityScale:
                            iof.Value = target.gravityScale;
                            break;
                        case Property.UseFullKinematicContacts:
                            iob.Value = target.useFullKinematicContacts;
                            break;
                        case Property.IsKinematic:
                            iob.Value = target.isKinematic;
                            break;
                        case Property.FreezeRotation:
                            iob.Value = target.freezeRotation;
                            break;
                        case Property.Simulated:
                            iob.Value = target.simulated;
                            break;
                        case Property.AttachedColliderCount:
                            ioi.Value = target.attachedColliderCount;
                            break;
                        default:
                            Debug.Log("Unsupported get or set attempted");
                            break;
                    }

                    break;
                case GetSet.Set:
                    switch (property)
                    {
                        case Property.Position:
                            target.position = iov2.Value;
                            break;
                        case Property.Rotation:
                            target.rotation = iof.Value;
                            break;
                        case Property.Velocity:
                            target.velocity = iov2.Value;
                            break;
                        case Property.AngularVelocity:
                            target.angularVelocity = iof.Value;
                            break;
                        case Property.UseAutoMass:
                            target.useAutoMass = iob.Value;
                            break;
                        case Property.Mass:
                            target.mass = iof.Value;
                            break;
                        case Property.CenterOfMass:
                            target.centerOfMass = iov2.Value;
                            break;
                        case Property.Inertia:
                            target.inertia = iof.Value;
                            break;
                        case Property.Drag:
                            target.drag = iof.Value;
                            break;
                        case Property.AngularDrag:
                            target.angularDrag = iof.Value;
                            break;
                        case Property.GravityScale:
                            target.gravityScale = iof.Value;
                            break;
                        case Property.UseFullKinematicContacts:
                            target.useFullKinematicContacts = iob.Value;
                            break;
                        case Property.IsKinematic:
                            target.isKinematic = iob.Value;
                            break;
                        case Property.FreezeRotation:
                            target.freezeRotation = iob.Value;
                            break;
                        case Property.Simulated:
                            target.simulated = iob.Value;
                            break;
                        default:
                            Debug.Log("Unsupported get or set attempted");
                            break;
                    }

                    break;
                default:
                    break;
            }

            Continue();
        }

        public override string GetSummary()
        {
            if (rigidbody2DData.Value == null)
            {
                return "Error: no rigidbody2D set";
            }
            if (inOutVar == null)
            {
                return "Error: no variable set to push or pull data to or from";
            }

            return getOrSet.ToString() + " " + property.ToString();
        }

        public override Color GetButtonColor()
        {
            return new Color32(235, 191, 217, 255);
        }

        public override bool HasReference(Variable variable)
        {
            if (rigidbody2DData.rigidbody2DRef == variable || inOutVar == variable)
                return true;

            return false;
        }

    }
}