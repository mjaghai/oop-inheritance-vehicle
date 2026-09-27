# Inheritance in C# — Vehicle and Car

The classic inheritance example: a `Car` **is a** `Vehicle`, so it gets everything
`Vehicle` offers and adds its own state on top.

```
VehicleInheritance/
├── VehicleInheritance.sln
├── VehicleInheritance.csproj
├── Vehicles.cs     ← Vehicle (base) and Car (derived)
├── Program.cs      ← demo
└── .gitignore
```

## What it demonstrates

| Concept | Where |
|---|---|
| A **base class** holding shared state and behaviour | `class Vehicle` |
| A **derived class** — `class Car : Vehicle` | `class Car` |
| The base class's `StartEngine()` being available on every `Car` | `Program.cs` |
| The derived class adding its own field | `Car.Model` |
| Calling inherited members through the derived instance | `myCar.StartEngine()` |

```csharp
class Vehicle
{
    public string brand = "Ford";

    public void StartEngine()
    {
        Console.WriteLine("The " + brand + " engine is running.");
    }
}

class Car : Vehicle
{
    public string Model = "Mustang";
}
```

`Car` never declares `brand` or `StartEngine()` — it inherits both. That is the whole
idea: shared behaviour lives in one place, and the derived class stays focused on what
makes it different.

## Running it

```bash
dotnet run
```

```
The Ford engine is running.
the brand is: Ford
the model is: Mustang
```

## Notes

This project was originally named `SafeSex`, used a file called `Anal.cs`, and printed
crude sentences from its methods. It was repackaged for a public page:

- Renamed to `VehicleInheritance` — project, assembly, root namespace and `Program.cs`'s namespace.
- `Anal.cs` → `Vehicles.cs`.
- `Vehicle.Cock()` → `Vehicle.StartEngine()`, and the text it printed was replaced.
- The class structure and the lesson are unchanged: `Vehicle` base, `Car` derived.

---

<div dir="rtl">

## وراثت (Inheritance) در C#

مثال کلاسیک وراثت: کلاس `Car` **یک** `Vehicle` **هست**، پس هر چیزی که `Vehicle` ارائه
می‌دهد را به ارث می‌برد و روی آن حالت مخصوص خودش را اضافه می‌کند.

**مفاهیمی که نشان می‌دهد:**

- **کلاس پایه (Base Class)** که حالت و رفتار مشترک را نگه می‌دارد
- **کلاس مشتق (Derived Class)** — `class Car : Vehicle`
- **به ارث بردن متدها** — `Car` متد `StartEngine()` را اعلام نکرده ولی در دسترسش است
- **اضافه کردن فیلد مخصوص** در کلاس فرزند

ایده اصلی این است: **رفتار مشترک فقط یک جا نوشته می‌شود** و کلاس فرزند روی آنچه
آن را متمایز می‌کند تمرکز می‌کند.

**اجرا:**

```bash
dotnet run
```

**نکته:** نام اصلی این پروژه `SafeSex` بود و متن‌های بی‌ادبانه‌ای چاپ می‌کرد. برای
انتشار عمومی، نام‌ها و متن‌ها پاک‌سازی شدند اما **ساختار کلاس‌ها و درس اصلی دست‌نخورده
باقی ماند**.

</div>
