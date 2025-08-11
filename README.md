# Dependency Inversion Principle

**Dependency Inversion Principle** is the fifth principle of SOLID.  
It says:

> *High-level modules should not depend on low-level modules. Both should depend on abstractions.*  
> *Abstractions should not depend on details. Details should depend on abstractions.*

This means that instead of classes depending directly on each other,  
they should depend on **interfaces** or **abstract classes**.

---

## <a href="https://www.linkedin.com/in/soheilsadeghii/"><img src="https://raw.githubusercontent.com/Tarikul-Islam-Anik/Telegram-Animated-Emojis/main/Smileys/Exploding%20Head.webp" alt="Exploding Head" width="35" height="35" /></a> Why is DIP Important?

- Makes code **more flexible** and **easier to change**
- Reduces **tight coupling** between classes
- Makes it easier to **test** with mock implementations
- Helps create systems that are **scalable** and **maintainable**

---

## <a href="https://www.linkedin.com/in/soheilsadeghii/"><img src="https://raw.githubusercontent.com/Tarikul-Islam-Anik/Telegram-Animated-Emojis/main/Symbols/Exclamation%20Question%20Mark.webp" alt="Exclamation Question Mark" width="35" height="35" /></a> How This Project Uses DIP

In this project:

- High-level classes **do not** depend on low-level classes directly.
- Instead, they use **interfaces** to communicate.
- Low-level classes **implement** those interfaces.

Example from the code:
```csharp
public class DatabaseManager
{
    private INotification notification;

    public DatabaseManager(INotification notification)
    {
        this.notification = notification;
    }

    public void Add()
    {
        notification.Send("Add new record.");
    }
}
```
Here:
- Notification (high-level module) depends on IMessageService (abstraction).
- EmailService (low-level module) also depends on the same abstraction.
- We can replace EmailService with SmsService without changing Notification.

---

Thanks for checking out this project!  
If you found it helpful, feel free to <a href="https://www.linkedin.com/in/soheilsadeghii/"><img src="https://raw.githubusercontent.com/Tarikul-Islam-Anik/Telegram-Animated-Emojis/main/Animals%20and%20Nature/Star.webp" alt="Star" width="15" height="15" /></a> the repo or share it with others.  
Contributions, feedback, and suggestions are always welcome!
<br>
<br>
![Visitor Badge](https://visitor-badge.laobi.icu/badge?page_id=SoheilSadeghii.DependencyInversionPrinciple)

