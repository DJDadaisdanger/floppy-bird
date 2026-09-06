# floppy-bird

A high-contrast 2D arcade survival runner built in Unity 6 and deployed for the web. Control the avian vessel through procedurally spaced obstacles, balance gravity with downward thrust, and collect bonus loot.

Play live on [itch.io](https://djdadaisdanger.itch.io/floppy-bird).

---

## Gameplay & Controls

* **Thrust / Flap:** `Space`, `Left Mouse Click`, or `Screen Tap` (mobile)
* **Goal:** Thread through vertical pipe gaps without colliding with obstacles or screen boundaries.

### Scoring
* **Pass Obstacle:** +1 point
* **Collect Floating Cloud:** +5 bonus points

---

## Key Features

* **Multi-Input Support:** Unified handling for keyboard, mouse clicks, and touch gestures.
* **Dynamic Bonus System:** Configurable probability-based collectible spawner (`BonusSpawner.cs`) that offsets collectible heights within pipe gaps.
* **Particle System:** Custom directional thruster exhaust layered behind the player sprite.
* **Optimized WebGL Pipeline:** Tuned build profiles for low-latency web browser execution.

---

## Tech Stack

* **Engine:** Unity 6 (6000.x)
* **Language:** C#
* **Physics:** 2D Rigidbody & Trigger Colliders
* **Target Platform:** WebGL (HTML5 Canvas)

---

## Getting Started

### Prerequisites
* Unity 6 LTS (with **WebGL Build Support** installed via Unity Hub)
* Git

### Installation & Local Setup

1. **Clone the repository:**
   ```bash
   git clone [https://github.com/DJDadaisdanger/floppy-bird.git](https://github.com/DJDadaisdanger/floppy-bird.git)
   cd floppy-bird
