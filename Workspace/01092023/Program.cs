Game game1 = new Game("GTA",7.99,false,96.9,new List<Review>{},13,GameCategory.ACTION);
Software sw1 = new Software("Photoshop",25.99,false,78,new List<Review>{},SoftwareCategory.DESING);
User user1= new User("John",27,125.50,new List<Application>{});

Platform platform1 = new Platform ("Steam", new List<Application>{},new List<User>{});
Review review1 = new Review(user1,"My experience", "I really enjoy this game...", true, new Date (11,8,2023));


