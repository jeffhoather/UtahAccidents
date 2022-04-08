using Microsoft.ML.OnnxRuntime.Tensors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UtahAccidents.Models
{
    public class AccidentInfoPredictor
    {
        public float WORK_ZONE_RELATED_True { get; set; }
        public float MOTORCYCLE_INVOLVED_True { get; set; }
        public float IMPROPER_RESTRAINT_True { get; set; }
        public float UNRESTRAINED_True { get; set; }
        public float DUI_True { get; set; }
        public float INTERSECTION_RELATED_True { get; set; }
        public float WILD_ANIMAL_RELATED_True { get; set; }
        public float OVERTURN_ROLLOVER_True { get; set; }
        public float COMMERCIAL_MOTOR_VEH_INVOLVED_True { get; set; }
        public float TEENAGE_DRIVER_INVOLVED_True { get; set; }
        public float OLDER_DRIVER_INVOLVED_True { get; set; }
        public float NIGHT_DARK_CONDITION_True { get; set; }
        public float SINGLE_VEHICLE_True { get; set; }
        public float DISTRACTED_DRIVING_True { get; set; }
        public float DROWSY_DRIVING_True { get; set; }
        public float ROADWAY_DEPARTURE_True { get; set; }
        public float CITY_DRAPER { get; set; }
        public float CITY_LAYTON { get; set; }
        public float CITY_LEHI { get; set; }
        public float CITY_LOGAN { get; set; }
        public float CITY_MIDVALE { get; set; }
        public float CITY_MILLCREEK { get; set; }
        public float CITY_MURRAY { get; set; }
        public float CITY_OGDEN { get; set; }
        public float CITY_OREM { get; set; }
        public float CITY_OUTSIDE_CITY_LIMITS { get; set; }
        public float CITY_PROVO { get; set; }
        public float CITY_SALT_LAKE_CITY { get; set; }
        public float CITY_SANDY { get; set; }
        public float CITY_SOUTH_JORDAN { get; set; }
        public float CITY_SOUTH_SALT_LAKE { get; set; }
        public float CITY_ST_GEORGE { get; set; }
        public float CITY_TAYLORSVILLE { get; set; }
        public float CITY_WEST_JORDAN { get; set; }
        public float CITY_WEST_VALLEY_CITY { get; set; }
        public float MAIN_ROAD_NAME_I_15 { get; set; }
        public float MAIN_ROAD_NAME_I_80 { get; set; }
        public float CRASH_SEVERITY_ID { get; set; }



        public Tensor<float> AsTensor()
        {
            float[] data = new float[]
            {
                WORK_ZONE_RELATED_True, MOTORCYCLE_INVOLVED_True, IMPROPER_RESTRAINT_True, UNRESTRAINED_True, DUI_True,
                INTERSECTION_RELATED_True, WILD_ANIMAL_RELATED_True, OVERTURN_ROLLOVER_True, COMMERCIAL_MOTOR_VEH_INVOLVED_True,
                TEENAGE_DRIVER_INVOLVED_True, OLDER_DRIVER_INVOLVED_True, NIGHT_DARK_CONDITION_True, SINGLE_VEHICLE_True,
                DISTRACTED_DRIVING_True, DROWSY_DRIVING_True, ROADWAY_DEPARTURE_True, CITY_DRAPER, CITY_LAYTON, CITY_LEHI, CITY_LOGAN,
                CITY_MIDVALE, CITY_MILLCREEK, CITY_MURRAY, CITY_OGDEN, CITY_OREM, CITY_OUTSIDE_CITY_LIMITS, CITY_PROVO, CITY_SALT_LAKE_CITY,
                CITY_SANDY, CITY_SOUTH_JORDAN, CITY_SOUTH_SALT_LAKE, CITY_ST_GEORGE, CITY_TAYLORSVILLE, CITY_WEST_JORDAN,
                CITY_WEST_VALLEY_CITY, MAIN_ROAD_NAME_I_15, MAIN_ROAD_NAME_I_80
            };
            int[] dimensions = new int[] { 1, 37 };
            return new DenseTensor<float>(data, dimensions);
        }

    }
}
