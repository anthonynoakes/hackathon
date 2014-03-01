using Microsoft.Kinect;

namespace Fizbin.Kinect.Gestures.Segments
{
    public class newScroll1 : IRelativeGestureSegment
    {
        public GesturePartResult CheckGesture(Skeleton skeleton)
        {
            if (skeleton.Joints[JointType.HandLeft].Position.X > skeleton.Joints[JointType.ShoulderLeft].Position.X)
            {
                if (skeleton.Joints[JointType.HandLeft].Position.Y < skeleton.Joints[JointType.HipLeft].Position.Y)
                {
                    return GesturePartResult.Succeed;
                }
                return GesturePartResult.Pausing;
            }
            // hand has not dropped but is not quite where we expect it to be, pausing till next frame
            return GesturePartResult.Fail;
        }
    }

    public class newScroll2 : IRelativeGestureSegment
    {
        public GesturePartResult CheckGesture(Skeleton skeleton)
        {
            if (skeleton.Joints[JointType.HandLeft].Position.X > skeleton.Joints[JointType.ShoulderLeft].Position.X)
            {
                if (skeleton.Joints[JointType.HandLeft].Position.Y > skeleton.Joints[JointType.HipLeft].Position.Y)
                {
                    return GesturePartResult.Succeed;
                }
                return GesturePartResult.Pausing;
            }
            // hand has not dropped but is not quite where we expect it to be, pausing till next frame
            return GesturePartResult.Fail;
        }
    }
}
