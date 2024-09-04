using Chapter12_CompoundPatterns;

DuckSimulator simulator = new();
AbstractDuckFactory duckFactory = new CountingDuckFactory();
simulator.Simulate(duckFactory);