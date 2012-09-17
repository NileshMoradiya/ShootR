﻿namespace Shooter
{
    public class ShipConfiguration
    {
        public ShipConfiguration()
        {
            DRAG_AREA = ShipMovementController.DRAG_AREA;
            DRAG_COEFFICIENT = ShipMovementController.DRAG_COEFFICIENT;
            ENGINE_POWER = ShipMovementController.ENGINE_POWER;
            FIRE_RATE = ShipWeaponController.FIRE_RATE;
            HEIGHT = Ship.HEIGHT;
            MAX_SPEED = ShipMovementController.MAX_SPEED;
            ROTATE_SPEED = ShipMovementController.ROTATE_SPEED;
            WIDTH = Ship.WIDTH;
        }

        public double DRAG_AREA { get; set; }
        public double DRAG_COEFFICIENT { get; set; }        
        public double ENGINE_POWER { get; set; }
        public int FIRE_RATE { get; set; }
        public int HEIGHT { get; set; }
        public double MAX_SPEED { get; set; }
        public int WIDTH { get; set; }
        public double ROTATE_SPEED { get; set; }        
    }
}