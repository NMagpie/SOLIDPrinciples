using _12._SOLID_principles.Notifications;
using _12._SOLID_principles.NotificationsService;
using _12._SOLID_principles.NotificationsService.Notificators;
using _12._SOLID_principles.NotificationsService.Users;

NotificationService notificationService = new();

List<User> users = [
    new(0, "qwerty@gmail.com", "+57 (48) 39234", "Samsung"),
    new(1, "placeholder@hotmail.com", "+1 (75) 64325", "iPhone"),
    new(2, "somemail@microsoft.com", "+5 (84) 839234", "Oppo"),
    ];

notificationService.Notify(users[0], users[1], ENotificators.PushNotificator, new Notification("hello!"));

notificationService.Notify(users[1], users[0], ENotificators.SMSNotificator, new Notification("hi!"));

notificationService.Notify(users[2], users[1], new Notification("hey, have you seen user1 online?"));

notificationService.Notify(users[1], users[2], ENotificators.EmailNotificator, new Notification("I did not, why?"));