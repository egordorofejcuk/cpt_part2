using LSP;

Bird penguin = new Penguin();
Bird flyingBird = new FlyingBird();
penguin.eat();
flyingBird.eat();
Flyable flyBird = flyingBird as Flyable;
flyBird?.fly();