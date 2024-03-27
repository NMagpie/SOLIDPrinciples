using _12._SOLID_principles.Notifications;
using _12._SOLID_principles.Users;

List<AUser> users = [ new RegularUser(0), new RegularUser(1), new RegularUser(2), new AdminUser(3), new AdminUser(4) ];

users[0].SendNotification(users[1], new EmailNotification("hello!"));

users[1].SendNotification(users[0], new SMSNotification("hi!"));

users[3].SendNotification(users[4], new EmailNotification("ban user with id 3!"));

users[2].SendNotification(users[1], new EmailNotification("user is going to ban themself!"));