/**
 * Copyright (c) 2019-2021 LG Electronics, Inc.
 *
 * This software contains code licensed as described in LICENSE.
 *
 */

namespace Simulator.Map
{
    public class MapParkingSpace : MapDataPoints, IMapType
    {
        public string id
        {
            get;
            set;
        }

        public override void Draw()
        {
            if (mapLocalPositions.Count < 2) return;

            AnnotationGizmos.DrawWaypoints(transform, mapLocalPositions, MapAnnotationTool.WAYPOINT_SIZE, parkingSpaceColor + selectedColor);
            AnnotationGizmos.DrawLines(transform, mapLocalPositions, parkingSpaceColor + selectedColor);
            if (MapAnnotationTool.SHOW_HELP)
            {
#if UNITY_EDITOR
                UnityEditor.Handles.Label(transform.position, "    PARKINGSPACE");
#endif
            }
        }
    }
}