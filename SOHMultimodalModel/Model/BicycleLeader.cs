using System;
using System.Collections.Generic;
using Mars.Common.Core.Random;
using Mars.Interfaces.Annotations;
using Mars.Interfaces.Environments;
using SOHBicycleModel.Parking;
using SOHMultimodalModel.Model;

namespace SOHBicycleModel.Model
{
    public class BicycleLeader : HumanTraveler
    {
        protected ISet<ModalChoice> _choices;
        private Queue<Position> stops { get; set; }

        public override void Init(HumanTravelerLayer layer)
        {
            base.Init(layer);

            Gender = (GenderType)RandomHelper.Random.Next(0, 2);
            OvertakingActivated = false;

            _choices = new ModalityChooser().Evaluate(this);

            stops = BicycleLeaderRoute.GetRoute();

            StartPosition = stops.Dequeue();
            GoalPosition = stops.Dequeue();

            const int radiusInM = 1;
            if (_choices.Contains(ModalChoice.CyclingOwnBike) && BicycleParkingLayer != null)
                Bicycle = BicycleParkingLayer.CreateOwnBicycleNear(StartPosition, radiusInM, 1.0);

        }

        public override void Tick()
        {
            getNextRoute();
            base.Move();

            if (IsWaitingAtTrafficLight())
            {
                Console.WriteLine(MultimodalLayer.GetCurrentTick() + " - Angehalten.");
                MultimodalLayer.UnregisterAgent(MultimodalLayer, this);
            }

            if (GoalReached)
            {
                if (stops.Count == 0)
                {
                    Console.WriteLine(MultimodalLayer.GetCurrentTick() + " - Grüne Welle!");
                    MultimodalLayer.UnregisterAgent(MultimodalLayer, this);
                }
                else
                {
                    getNextStopAndRoute();
                }
            }
        }

        private void getNextStopAndRoute()
        {
            StartPosition = GoalPosition;
            GoalPosition = stops.Dequeue();
            getNextRoute();
        }

        private void getNextRoute()
        {
            MultimodalRoute ??= MultimodalLayer.Search(this, StartPosition, GoalPosition, _choices);
        }
    }

    public class ModalityChooser
    {
        public ISet<ModalChoice> Evaluate(BicycleLeader attributes)
        {
            return new HashSet<ModalChoice> { ModalChoice.CyclingOwnBike, ModalChoice.CyclingRentalBike };
        }
    }
}