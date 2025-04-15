# 🍓 Fruit Catcher

A fun and simple 2D game built in **Unity**, where you control a basket to catch falling fruits! Rack up points, enjoy dynamic sounds, and test your reflexes as fruits rain from the sky. Miss one? Game over!

---

## 🎮 Overview

**Fruit Catcher** challenges players to:
- Catch falling fruits with a basket
- Avoid letting any fruit hit the ground
- Aim for the highest score possible!

Built using:
- Unity Engine
- C#
- Custom UI and Audio Management

---

## 🎮 Gameplay
[![IMAGE ALT TEXT HERE](https://img.youtube.com/vi/GOCD7lG6RzY/0.jpg)](https://www.youtube.com/watch?v=GOCD7lG6RzY)

---

## 🕹️ Game Mechanics

### ➡️ Basket Movement
- Controlled using `← →` arrow keys or `A / D` keys
- Movement is constrained between `x = -9` and `x = 9`

### 🍇 Fruit Falling
- Fruits spawn at random intervals
- Each fruit is randomly selected from a set of prefabs

### 🏆 Scoring
- +1 point per caught fruit
- Score updates in real time on screen

---

## 📺 Game States

### 🟢 Start Screen
- Welcome screen with background music
- Features a "Play" button

### 🎮 Main Gameplay
- Fruits fall
- Game continues until a fruit hits the ground

### 🔴 Game Over
- Sound effect plays
- Returns to Start Screen after a brief delay

---

## 🧩 User Interface

- **Start Screen**: Minimal layout with a “Play” button  
- **In-Game UI**: Score display at the top of the screen

---

## 🔊 Sound Management

All audio is handled by a centralized `SoundManager`:

| Sound Type         | When It Plays                          |
|--------------------|----------------------------------------|
| 🎵 Background Music | Loops from the start screen onward      |
| ✅ Collect Sound     | Plays when a fruit is successfully caught |
| ❌ Game Over Sound   | Plays when a fruit touches the ground    |

---

## 🌟 Key Features

- 🎲 Randomized fruit prefabs  
- 📏 Basket movement boundaries  
- 🧠 Centralized `SoundManager`  
- ✅ Smart collision detection using `isCaught` flag

---

## 🛠️ Challenges & Solutions

### 🌀 Collision Issues
- Problem: Multiple score triggers from one fruit
- Fix: Introduced `isCaught` flag to avoid double scoring

### 🎧 Audio Handling
- Problem: Repetitive and scattered sound code
- Fix: Centralized all sound controls via `SoundManager`

---

## ✅ Conclusion

"Fruit Catcher" successfully delivers:
- A functional and polished UI
- Randomized gameplay elements
- Smooth scoring and sound integration

It's a great demo of beginner-friendly Unity skills!
