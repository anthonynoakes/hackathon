﻿using Microsoft.Kinect;
using System;
using System.Collections.Generic;

namespace Fizbin.Kinect.Gestures
{
    public class GestureController
    {
        /// <summary>
        /// The list of all gestures we are currently looking for
        /// </summary>
        private List<Gesture> gestures = new List<Gesture>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GestureController"/> class.
        /// </summary>
        public GestureController()
        {
        }

        public void clearAllProgress()
        {
            foreach (var g in gestures)
            {
                g.currentGesturePart = 0;
            }
        }

        /// <summary>
        /// Occurs when [gesture recognised].
        /// </summary>
        public event EventHandler<GestureEventArgs> GestureRecognized;

        /// <summary>
        /// Updates all gestures.
        /// </summary>
        /// <param name="data">The skeleton data.</param>
        public void UpdateAllGestures(Skeleton data)
        {
            for(int i=0; i < gestures.Count - 3; i++)
            {
                gestures[i].UpdateGesture(data);
            }
        }

        public void UpdateVolumeGesture(Skeleton data)
        {
            this.gestures[gestures.Count - 2].UpdateGesture(data);
            this.gestures[gestures.Count - 1].UpdateGesture(data);
        }

        /// <summary>
        /// Adds the gesture.
        /// </summary>
        /// <param name="name">The gesture type.</param>
        /// <param name="gestureDefinition">The gesture definition.</param>
        public void AddGesture(string name, IRelativeGestureSegment[] gestureDefinition)
        {
            Gesture gesture = new Gesture(name, gestureDefinition);
            gesture.GestureRecognized += OnGestureRecognized;
            this.gestures.Add(gesture);
        }

        /// <summary>
        /// Handles the GestureRecognized event of the g control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KinectSkeltonTracker.GestureEventArgs"/> instance containing the event data.</param>
        private void OnGestureRecognized(object sender, GestureEventArgs e)
        {
            if (this.GestureRecognized != null)
            {
                this.GestureRecognized(this, e);
            }

            foreach (Gesture g in this.gestures)
            {
                g.Reset();
            }
        }
    }
}
