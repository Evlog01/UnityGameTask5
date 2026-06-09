# Игровое портфолио – Кейс-задача №5

Проект выполнен в рамках учебной практики по геймдизайну и разработке игр.  

Демонстрирует навыки работы с Unity, Cinemachine, анимациями, физикой и UI.

## Что реализовано

- **Камера слежения** – Cinemachine Virtual Camera плавно следует за игроком.

- **Анимированный бонус** – при входе в триггер куб активирует анимацию вращения (Animator Controller, параметр `IsPlayerNear`).

- **Сбор монет и кошелёк** – вращающиеся монеты исчезают при касании, счётчик обновляется через `GameManager` и отображается в UI (TextMeshPro).

- **Взрывоопасная бочка** – при сильном ударе (относительная скорость > 8) уничтожает игрока.

- **Подвижное препятствие с уроном** – движется между двумя точками, наносит урон при касании игрока; игрок погибает при нулевом HP.

- **Система частиц** – включается при движении игрока, создавая эффект пыли/следов.

## Технологии

Unity (Built-in Render Pipeline), Cinemachine, Animator, TextMeshPro, Particle System, C#.

## Как запустить

- Установить Unity.

- Загрузить сцену `Assets/Scenes/SampleScene.unity`.

- Нажать Play.


## Автор
[Evlog01](https://github.com/Evlog01)

Студент, геймдизайнер-разработчик
---

*Ссылки на другие проекты практики:*  

[Калькулятор на C#](https://github.com/Evlog01/Calculator) | [Тетрис на C#](https://github.com/Evlog01/TetrisGame)




# Game Portfolio – Case Task #5

The project was completed as part of a training practice in game design and development.

It demonstrates skills in working with Unity, Cinemachine, animations, physics, and UI.

## What has been implemented

- **Follow Camera** – Cinemachine Virtual Camera smoothly follows the player.
- **Animated Bonus** – when the player enters the trigger cube, it activates a rotation animation (Animator Controller, parameter IsPlayerNear).
- **Collecting coins** and a wallet – spinning coins disappear when touched, the counter is updated via GameManager and displayed in the UI (TextMeshPro).
- **Explosive barrel** – destroys the player when hit hard (relative velocity > 8).
- **Moving obstacle** with damage – moves between two points, deals damage when the player touches it; the player dies when HP is zero.
- **Particle System** – turns on when the player moves, creating a dust/trace effect.

## Technologies

Unity (Built-in Render Pipeline), Cinemachine, Animator, TextMeshPro, Particle System, C#.

## How to run

- Install Unity.
- Load the scene Assets/Scenes/SampleScene.unity.
- Click Play.

## Author

[Evlog01](https://github.com/Evlog01)

Student, Game Designer-Developer
---

*Links to other practice projects:*  

[Калькулятор на C#](https://github.com/Evlog01/Calculator) | [Тетрис на C#](https://github.com/Evlog01/TetrisGame)
