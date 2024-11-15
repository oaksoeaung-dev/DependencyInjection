using Example4;

ElectricSaw electricSaw = new ElectricSaw();
Saw saw = new Saw();
Hammer hammer = new Hammer();

Builder builder = new Builder();
builder.BuildHouse(hammer, electricSaw);
builder.BuildHouse(hammer, saw);
