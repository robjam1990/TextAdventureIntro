using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    /// <summary>
    /// Represents a system for recording and triggering observations.
    /// </summary>
    public class ObservationSystem
    {
        public object? Encyclopedia { get; private set; } // Object to store observations
        private List<object?> plugins; // List to store plugins
        public ObservationSystem observation; // Observation object

        /// <summary>
        /// Initializes a new instance of the ObservationSystem class.
        /// </summary>
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public ObservationSystem(List<object?> plugins)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            plugins = new List<object?>(); // Initialize the list of plugins
        }

        /// <summary>
        /// Records an observation.
        /// </summary>
        /// <param name="observationName">The name of the observation.</param>
        /// <param name="properties">The properties of the observation.</param>
        /// <param name="participant">The participant related to the observation.</param>
        public class Observation
        {
            private static EventTarget eventEmitter = new EventTarget();
            private static Dictionary<string, Dictionary<string, object?>> encyclopedia = new Dictionary<string, Dictionary<string, object?>>();

            public Dictionary<string, object?>? Encyclopedia { get; private set; }

            /// <summary>
            /// Records an observation.
            /// </summary>
            /// <param name="observationName">The name of the observation.</param>
            /// <param name="properties">The properties of the observation.</param>
            /// <param name="participant">The participant related to the observation.</param>
            public void Record(string observationName, object properties, object participant)
            {
                // Record the observation
                // "Encyclopedia" is an existing object where observations are stored
                if (Encyclopedia is Dictionary<string, object?> encyclopedia)
                {
                    encyclopedia[observationName] = properties;
                }
                else
                {
                    Console.WriteLine("Encyclopedia is not of type Dictionary<string, object>.");
                }
            }

            private class EventTarget
            {
                public EventTarget()
                {
                    // Initialize event target
                    Console.WriteLine("Event target initialized.");
                }

                public void AddEventListener(string eventName, object listener)
                {
                    // Add event listener
                    Console.WriteLine("Event listener added: " + eventName);
                }

                public void RemoveEventListener(string eventName, object listener)
                {
                    // Remove event listener
                    Console.WriteLine("Event listener removed: " + eventName);
                }

                public void DispatchEvent(string eventName, object data)
                {
                    // Dispatch event
                    Console.WriteLine("Event dispatched: " + eventName);
                }
            }
        }
    }
}
