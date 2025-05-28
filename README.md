# <a name="gdd-speed-stick"></a>GDD 2D Game: Speed Stick

## Contents
- [1. Game Development Team](#game-development-team)
  - [1.1. Game Designers](#game-designers)
- [2. Game Concept](#game-concept)
  - [2.1. Inspirations](#inspirations)
- [3. Game Mechanics](#game-mechanics)
  - [3.1. Cube Sides](#cube-sides)
  - [3.2. Jumping](#jumping)
  - [3.3. Snapping](#snapping)
- [4. Walls](#walls)
  - [4.1. Colored Walls](#colored-walls)
  - [4.2. Neutral Walls](#neutral-walls)
- [5. Power Ups](#power-ups)
  - [5.1. Double Jump](#double-jump)
  - [5.2. Wall Break](#wall-break)
  - [5.3. Wall Jump](#wall-jump)
- [6. Audio](#audio)
  - [6.1. Background Music](#background-music)
  - [6.2. Sound Effects](#sound-effects)
- [7. Physics](#physics)
  - [7.1. Gravity](#gravity)
  - [7.2. Friction & Wall Interactions](#friction)
  - [7.3. Collision Detection](#collision)
- [8. Art Style](#art-style)
  - [8.1. Visual Theme](#visual-theme)
  - [8.2. Animation](#animation)
- [9. User Interface (UI)](#ui)
  - [9.1. HUD](#hud)
  - [9.2. Menus](#menus)
- [10. Authors](#authors)

---

## <a name="game-development-team"></a>1. Game Development Team

### <a name="game-designers"></a>1.1. Game Designers
- Hassan Sharif Abbud Gonzalez

---

## <a name="game-concept"></a>2. Game Concept

**Speed Stick** is a 2D up-scroller game where you must climb levels upward against a timer. The player will have tools at their disposal to reach certain platforms, but the main mechanic is jumping and sticking to walls that match the color of the cube’s side.

### <a name="inspirations"></a>2.1. Inspirations
Speed Stick draws inspiration from several iconic titles:
* **Neon White** – For its fast-paced, timer-driven movement and fluid traversal mechanics.
* **Tetris** – For the rotational logic and strategic use of cube sides, inspired by how Tetris pieces must be rotated to fit.
* **Metroid** – Final sections in Metroid involve climbing the level under a timer using all of your power-ups.

---

## <a name="game-mechanics"></a>3. Game Mechanics

### <a name="cube-sides"></a>3.1. Cube Sides
Each side of the player's cube will have a different color. These colors match the colors of walls in the level. The player can rotate the cube in any direction, similar to how pieces are rotated in *Tetris*.

### <a name="jumping"></a>3.2. Jumping
The main method of movement. The player will be able to jump and move left or right to reach platforms and progress through the level.

### <a name="snapping"></a>3.3. Snapping
When the cube’s side color matches a wall’s color, the player can press toward the wall to snap into it and regain the ability to jump again.

<div align="center">
  <img src="Images/github-Concept-SpeedStick.png" alt="Concept art of Speed Stick" width="400"/>
</div>

---

## <a name="walls"></a>4. Walls

### <a name="colored-walls"></a>4.1. Colored Walls
These walls allow the player to stick to them if the cube’s corresponding side matches their color. Otherwise, the cube will slide down.

### <a name="neutral-walls"></a>4.2. Neutral Walls
Neutral-colored walls act as obstacles. The player cannot stick to them under normal conditions. See [Power Ups](#power-ups) for exceptions.

---

## <a name="power-ups"></a>5. Power Ups

### <a name="double-jump"></a>5.1. Double Jump
Allows the player to jump a second time while mid-air.

### <a name="wall-break"></a>5.2. Wall Break
Allows the player to break the next wall they come into contact with — useful for accessing hidden or blocked areas.

### <a name="wall-jump"></a>5.3. Wall Jump
Allows the player to bounce off a neutral wall that would otherwise be non-interactive.

---

## <a name="audio"></a>6. Audio

### <a name="background-music"></a>6.1. Background Music
* Fast-paced, rhythmic soundtrack to complement the time-based climbing mechanic.
* Music tempo may increase as the timer runs low or the player reaches higher levels, similar to Super Mario Galaxy's Ball Rolling theme that grows in intensity as the player goes faster.

### <a name="sound-effects"></a>6.2. Sound Effects
There will be sound effects for interacting with the main elements of the world, mainly:
* Jump, land, snap-to-wall, rotate cube.
* Unique sounds for each power-up activation.
* Ambient sounds for environmental elements like crumbling walls or falling debris.

---

## <a name="physics"></a>7. Physics

### <a name="gravity"></a>7.1. Gravity
* Constant downward force pulling the cube down unless attached to a wall.
* Increased gravity may be applied mid-air to add weight and challenge.

### <a name="friction"></a>7.2. Friction & Wall Interactions
* Colored walls have friction if matched with the cube’s color (allow sticking).
* Neutral walls have no friction, leading to sliding.

### <a name="collision"></a>7.3. Collision Detection
* Cube collides with walls, platforms, and power-ups using 2D collision physics.
* Corner collision detection for realistic snapping mechanics.

---

## <a name="art-style"></a>8. Art Style

### <a name="visual-theme"></a>8.1. Visual Theme
[Pending visual theme]

### <a name="animation"></a>8.2. Animation
* Smooth transitions for cube rotations.
* Particle effects when snapping, jumping, or activating power-ups.

---

## <a name="ui"></a>9. User Interface (UI)

### <a name="hud"></a>9.1. HUD
* Timer countdown.
* Power-up icons (activated/inactive).
* Current level height or progress bar.

### <a name="menus"></a>9.2. Menus
* Start screen, level select, pause/resume, settings, and end screen.
* Options for audio control.

---

## <a name="authors"></a>10. Authors

- [@HassanAbbud](https://github.com/HassanAbbud)
