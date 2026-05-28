# AimPraktika

Jednostavna ali privlačna **WinForms igra za treniranje preciznosti** napravljena u C# kako bi se poboljšala brzina reagovanja i preciznost klika miša.

## 🎮 Pregled Igre

AimPraktika je desktop aplikacija koja vas izaziva sa brzom igrom klika:

- **Meta (Zeleno dugme)**: Klikni da bi dobio poene
- **Prepreke (Crvena dugmeta)**: Izbjegni klika da bi zaštitio svoj rezultat
- **Prazna površina**: Klika bilo gde drugde smanjuje tvoj rezultat

## 📊 Karakteristike

- **Praćenje rezultata u realnom vremenu**: Zarada poena za pogodke, gubitak za greške
- **Brojač vremena**: 30-sekundni odbrojavanje za svaku rundu
- **Procenat preciznosti**: Prati tačnost svojih klikova
- **Dinamičko postavljanje dugmadi**: Mete i prepreke se pojavljuju na random lokacijama
- **Odgovorna igra**: Glatka i interaktivna mehanika klika

## 🎯 Pravila Igre

1. **Pogođena meta**: +10 poena
2. **Pogođena prepreka**: -5 poena
3. **Promašaj (klik u praznu površinu)**: -1 poen
4. **Cilj**: Maksimizuj svoj rezultat u roku od 30 sekundi

## 🛠️ Zahtevi

- Windows 10 ili novije
- .NET Framework 4.7.2 ili novije (ili .NET 6/7/8)
- Visual Studio 2019 ili novije (za razvoj)

## 💻 Instalacija i pokretanje

### Za korisnike
1. Preuzmi najnoviju verziju
2. Raspakuj datoteke
3. Pokreni `AimPraktika.exe`

### Za razvojne inženjere
1. Kloniraj repozitorijum:
   ```bash
   git clone https://github.com/lukabraske37/AimPractice.git
   ```
2. Otvori `AimPractice.sln` u Visual Studio-u
3. Izgradi rešenje (Ctrl+Shift+B)
4. Pokreni projekt (F5)

## 📁 Struktura Projekta

```
AimPractice/
├── AimPractice/              # Glavni direktorijum projekta
│   ├── Form1.cs              # Glavna logika igre
│   ├── Form1.Designer.cs     # UI dizajn (auto-generisano)
│   ├── Program.cs            # Ulazna tačka aplikacije
│   ├── AimPractice.csproj    # Konfiguracija projekta
│   └── Properties/           # Svojstva i resursi projekta
├── .gitignore                # Git ignore pravila
└── README.md                 # Ova datoteka
```

## 🎨 UI Komponente

- **Prikaz rezultata**: Prikazuje trenutne zaradjene poene
- **Prikaz vremena**: Preostalo vreme u sekundama
- **Prikaz preciznosti**: Procenat uspešnih pogodaka mete
- **Dugme mete**: Zeleno dugme na koje klikneš za poene
- **Dugmeta prepreka**: Crvena dugmeta koja treba izbegavati
- **Površina igre**: Nasumično postavljeno dugmeta za klik

## 🚀 Buduća Poboljšanja

Potencijalne karakteristike za buduće verzije:
- [ ] Nivoi težine (Lako, Srednje, Teško)
- [ ] Tabela rezultata / Praćenje top rezultata
- [ ] Različiti modusi igre (Beskonačno, Vremenski, Preživljavanje)
- [ ] Zvučni efekti i vizuelne povratne informacije
- [ ] Varijacije veličine dugmadi na osnovu težine
- [ ] Podrška za multiplayer
- [ ] Meni sa postavkama (zvuk, osetljivost, itd.)

## 📝 Licenca

Ovaj projekat je otvoren kod i dostupan pod MIT licencom.

## 👨‍💻 Autor

**Luka B.** - [GitHub Profil](https://github.com/lukabraske37)

## 📧 Povratna informacija

Pronašao si grešku ili imaš sugestiju? Slobodno otvori problem na GitHub repozitorijumu!

---

**Uživaj u poboljšavanju svoje preciznosti! 🎯**
