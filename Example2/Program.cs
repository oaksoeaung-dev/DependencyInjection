using Example2;

Hammer hammer = new Hammer();
Saw saw = new Saw();

Builder builder = new Builder(hammer,saw);
builder.BuildHouse();