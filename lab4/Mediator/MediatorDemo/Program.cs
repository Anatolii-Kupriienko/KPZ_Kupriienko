using MediatorClassLibrary;


Runway runway = new Runway();
Aircraft aircraft = new Aircraft("Bf 109");
new CommandCentre([runway], [aircraft]);

aircraft.TakeOff();
if (runway.CheckIsActive())
{
    aircraft.Land();
}