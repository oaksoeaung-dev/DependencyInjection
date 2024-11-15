using Example3;

Builder builder = new Builder();
builder.hammer = new Hammer(); // Inject dependency via setter
builder.saw = new Saw();
builder.BuildHouse();