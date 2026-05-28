# AimPractice 🎯

AimPractice je mini **Aim Trainer** igra napravljena u **C# WinForms**.
Cilj igre je treniranje brzine reakcije, preciznosti i kontrole miša kroz jednostavnu ali dinamičnu mehaniku klikanja.

---

# Gameplay

Igrač mora da klikće na zelenu metu dok izbegava crvene prepreke koje se konstantno pomeraju po ekranu.

* 🟢 **Zelena meta** → donosi poene
* 🔴 **Crvene prepreke** → oduzimaju poene
* ⬛ **Klik na praznu površinu** → računa se kao promašaj

Partija traje 30 sekundi, a cilj je ostvariti što veći rezultat uz visoku preciznost.

---

# Funkcionalnosti

* Sistem poena
* Tajmer partije
* Praćenje preciznosti (%)
* Nasumično pomeranje meta
* Dinamična težina igre
* WinForms GUI
* Real-time ažuriranje statistike

---

# Tehnologije

* C#
* Windows Forms
* .NET Framework

---

# Pravila

| Akcija           | Efekat   |
| ---------------- | -------- |
| Pogodak mete     | +1 poen  |
| Klik na prepreku | -1 poen  |
| Klik van mete    | Promašaj |

---

# Pokretanje Projekta

## Pokretanje iz Visual Studio-a

1. Kloniraj repozitorijum

```bash
git clone https://github.com/lukabraske37/AimPractice.git
```

2. Otvori `AimPractice.sln`
3. Pokreni projekat (`F5`)

---

# Struktura Projekta

```text
AimPractice/
│
├── AimPractice/
│   ├── Form1.cs
│   ├── Form1.Designer.cs
│   ├── Program.cs
│   └── Properties/
│
├── .gitignore
└── README.md
```

---

# Screenshot

Evo kako izgleda igra tokom partije:

![AimPractice Gameplay Screenshot](https://github.com/lukabraske37/AimPractice/raw/main/gameplay-screenshot.png)

---

# Buduća Poboljšanja

* Difficulty sistem
* Highscore sistem
* Sound effects
* Fullscreen mod
* Settings meni
* Različite veličine meta
* Animacije i efekti

---

# Autor

Luka B.

GitHub:
https://github.com/lukabraske37

---

# Licenca

MIT License
